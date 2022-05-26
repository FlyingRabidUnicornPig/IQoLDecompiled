/*
Purpose of this class: mf'ing Console class
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeviceConsole : Singleton<DeviceConsole>
{
	// Title
	public void IAmNotSureWhatThisIsForButItIsUniqueSoIAmKeepingIt(DeviceConsole.OnCommandEvent commandEvent)
	{
		DeviceConsole.OnCommandEvent onCommandEvent = this.currentOnCommandEvent;
		DeviceConsole.OnCommandEvent onCommandEvent2;
		do
		{
			onCommandEvent2 = onCommandEvent;
			onCommandEvent = Interlocked.CompareExchange<DeviceConsole.OnCommandEvent>(ref this.currentOnCommandEvent, (DeviceConsole.OnCommandEvent)Delegate.Combine(onCommandEvent2, commandEvent), onCommandEvent);
		}
		while (onCommandEvent != onCommandEvent2);
	}

	// Seems to have the first bit of IAmNotSureWhatThisIsForButItIsUniqueSoIAmKeepingIt, hmm
	public event DeviceConsole.OnCommandEvent CommandEvent
	{
		add
		{
			DeviceConsole.OnCommandEvent onCommandEvent = this.currentOnCommandEvent;
			DeviceConsole.OnCommandEvent onCommandEvent2;
			do
			{
				onCommandEvent2 = onCommandEvent;
				onCommandEvent = Interlocked.CompareExchange<DeviceConsole.OnCommandEvent>(ref this.currentOnCommandEvent, (DeviceConsole.OnCommandEvent)Delegate.Combine(onCommandEvent2, value), onCommandEvent);
			}
			while (onCommandEvent != onCommandEvent2);
		}
		remove
		{
			DeviceConsole.OnCommandEvent onCommandEvent = this.currentOnCommandEvent;
			DeviceConsole.OnCommandEvent onCommandEvent2;
			do
			{
				onCommandEvent2 = onCommandEvent;
				onCommandEvent = Interlocked.CompareExchange<DeviceConsole.OnCommandEvent>(ref this.currentOnCommandEvent, (DeviceConsole.OnCommandEvent)Delegate.Remove(onCommandEvent2, value), onCommandEvent);
			}
			while (onCommandEvent != onCommandEvent2);
		}
	}

	private void OnDestroy()
	{
		// Doesn't seem to be updated with all commmands /shrug
		DebugLogs instance = DebugLogs.Instance;
		instance.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Remove(instance.OnLogAdded, new Action<DebugLogs.Log>(this.OnLogAdded));
		instance.OnLogsCleared = (Action)Delegate.Remove(instance.OnLogsCleared, new Action(this.OnLogsCleared));
		DebugCommands.Instance.RemoveCommand("plogs");
		DebugCommands.Instance.RemoveCommand("setAF");
	}

	public DeviceConsole()
	{
		this.autoFocusInputField = true;
	}

	public new void Awake()
	{
		base.Awake();
		
		this.DeviceLogs = new List<DeviceLogUI>();
		this.CommandHistoryIndex = 0;
		
		this.DrawHeaderText();
		this.PreLogIDK();
		
		// General Logging
		DebugLogs instance = DebugLogs.Instance;
		instance.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Combine(instance.OnLogAdded, new Action<DebugLogs.Log>(this.OnLogAdded));
		instance.OnLogsCleared = (Action)Delegate.Combine(instance.OnLogsCleared, new Action(this.OnLogsCleared));

		// Special commands
		DebugCommands instance2 = DebugCommands.Instance;
		instance2.AddCommand("help", new DebugCommands.DebugCommand(DeviceConsole.OnHelpCommand), "Prints list of commands", string.Empty, false);
		instance2.AddCommand("clear", new DebugCommands.DebugCommand(DeviceConsole.OnClearCommand), "Clears all text from the debug console", string.Empty, false);
		instance2.AddCommand("history", new DebugCommands.DebugCommand(DeviceConsole.OnHistoryCommand), "Prints list of all previous commands", string.Empty, false);
		instance2.AddCommand("logc", new DebugCommands.DebugCommand(DeviceConsole.OnLogCountCommand), "Prints the number of logs currently held by DebugLogs", string.Empty, false);
		instance2.AddCommand("plogs", new DebugCommands.DebugCommand(this.OnPrintLogCommand), "Clears the console and prints the logs in the specified range", "<start_index> <end_index>", false);
		instance2.AddCommand("logAll", new DebugCommands.DebugCommand(DeviceConsole.OnLogAllCommand), "Show all logs", "< true | false >", false);
		instance2.AddCommand("setAF", new DebugCommands.DebugCommand(this.OnSetAutoFocusCommand), "Sets the boolean value of the Auto Focus Input Field property.", "< true | false >", false);
		instance2.AddCommand("scenes", new DebugCommands.DebugCommand(this.OnScenesCommand), "Print the list of scenes, avalable in game.", string.Empty, false);
		instance2.AddCommand("loadscene", new DebugCommands.DebugCommand(DeviceConsole.OnLoadSceneCommand), "Load scene by name or build id", "<scene_name> or <id>", false);
		instance2.AddCommand("resetach21", new DebugCommands.DebugCommand(this.OnResetAchievement21Command), "Reset 21 achievement progress", string.Empty, false);
		instance2.AddCommand("quit", new DebugCommands.DebugCommand(DeviceConsole.OnQuitCommand), "Closes the app", string.Empty, false);
	}

	public void SetVisible(bool visible)
	{
		this.uiContainer.SetActive(visible);

		// Check if console up or down
		if (this.commandInputField == null) return;

		this.commandInputField.text = string.Empty;

		if (visible)
			this.ActivateConsole();
	}
	
	public bool IsVisible()
	{
		return this.uiContainer.active;
	}

	public void OnEndEdit()
	{
		if (!this.uiContainer.activeSelf) return;

		string text = this.commandInputField.text;

		int num = text.IndexOf('\n');
		if (num >= 0)
			text = text.Remove(num, 1);

		if (string.IsNullOrEmpty(text))	return;

		string[] array = text.Split(' ');

		if (this.currentOnCommandEvent != null)
			this.currentOnCommandEvent(this, new DeviceConsole.OnCommandEventArgs(array));
		
		// Log input/output of command
		LogType prevLog = UnityEngine.Debug.unityLogger.filterLogType;
		UnityEngine.Debug.unityLogger.filterLogType = LogType.Log;

		UnityEngine.Debug.Log(string.Format("$ {0}", text));

		DebugCommands.Instance.ExecuteCommand(array);

		// If (legit) logall, don't reset prevLog status, the line above already set it for us.
		if (array[0].ToLower() != "logall" || array.Length <= 1 || !DeviceConsole.TrueOrFalse(array[1], out bool ok))
			UnityEngine.Debug.unityLogger.filterLogType = prevLog;

		this.CommandHistoryIndex = DebugCommands.Instance.CommandHistory.Count;
		
		this.commandInputField.text = string.Empty;
		
		this.ActivateConsole();
	}

	private void Update()
	{
		// Command History by pressing up/down
		if (this.commandInputField != null)
			HandleCommandHistory();
		
		// If ` open console
		if (Input.GetKeyDown(KeyCode.BackQuote))
			this.SetVisible(!this.uiContainer.activeInHierarchy);
	}

	private void HandleCommandHistory()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow) && this.CommandHistoryIndex > 0)
		{
			this.CommandHistoryIndex--;
			this.commandInputField.text = DebugCommands.Instance.CommandHistory[this.CommandHistoryIndex];
			this.commandInputField.MoveTextEnd(false);
			
			this.ActivateConsole();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow) && this.CommandHistoryIndex < DebugCommands.Instance.CommandHistory.Count)
		{
			this.CommandHistoryIndex++;

			if (this.CommandHistoryIndex == DebugCommands.Instance.CommandHistory.Count)
			{
				this.commandInputField.text = string.Empty;
			}
			else
			{
				this.commandInputField.text = DebugCommands.Instance.CommandHistory[this.CommandHistoryIndex];
				this.commandInputField.MoveTextEnd(false);
			}

			this.ActivateConsole();
		}
	}

	private void ThrowReadyLogAtConsole(DebugLogs.Log log, string extraMessage = "")
	{
		if (this.logContainer == null) return;
		
		DeviceLogUI deviceLog = null;
		switch (log.type)
		{
			case LogType.Error:
				deviceLog = this.errorLogPrefab;
				break;
			case LogType.Assert:
				deviceLog = this.assertLogPrefab;
				break;
			case LogType.Warning:
				deviceLog = this.warningLogPrefab;
				break;
			case LogType.Log:
				deviceLog = this.logPrefab;
				break;
			case LogType.Exception:
				deviceLog = this.exceptionLogPrefab;
				break;
		}

		this.AddDeviceLogToConsole(deviceLog, extraMessage + log.message);

		if (log.type == LogType.Exception)
			this.CarefulConsoleLog(log.stackTrace, this.exceptionStackTracePrefab);
	}

	private void OnPrintLogCommand(string[] args)
	{
		if (args.Length != 3)
		{
			UnityEngine.Debug.Log("Need to specify a start index and end index.");
			return;
		}

		int num;
		int num2;
		if (!int.TryParse(args[1], out num) || !int.TryParse(args[2], out num2))
		{
			UnityEngine.Debug.Log("End index must in an integer.");
			return;
		}

		// Fix min/max
		if (num < 0)
			num = 0;
		if (num2 >= DebugLogs.Instance.Logs.Count)
			num2 = DebugLogs.Instance.Logs.Count - 1;

		this.ClearLogs();

		// Loop through and print old logs
		for (int i = Math.Min(num, num2); i <= Math.Max(num, num2); i++)
			this.ThrowReadyLogAtConsole(DebugLogs.Instance.Logs[i], i + ":");
	}

	private void ActivateConsole()
	{
		if (this.autoFocusInputField && this.commandInputField != null)
		{
			this.commandInputField.Select();
			this.commandInputField.ActivateInputField();
		}
	}

	private void ClearLogs()
	{
		if (this.DeviceLogs != null)
			for (int i = 0; i < this.DeviceLogs.Count; i++)
				UnityEngine.Object.Destroy(this.DeviceLogs[i].gameObject);

		this.DeviceLogs.Clear();
		this.ConsoleTextLength = 0;
	}

	private static void OnHelpCommand(string[] args)
	{
		// Loop through each command and log its use
		for (int i = 0; i < DebugCommands.Instance.Commands.Count; i++)
		{
			DebugCommands.Command command = DebugCommands.Instance.Commands[i];
			
			// Add name
			string text = string.Format("{0}", command.name);
			
			// Add arg description
			if (!string.IsNullOrEmpty(command.argsDescription))
				text += string.Format(" {0}", command.argsDescription);
			
			// Add description
			if (!string.IsNullOrEmpty(command.description))
				text += string.Format(" - {0}", command.description);
			
			// Log it
			UnityEngine.Debug.Log(text);
		}
	}

	// Log accessible scenes
	private void OnScenesCommand(string[] args)
	{
		UnityEngine.Debug.Log("Scenes List:");

		for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
			UnityEngine.Debug.Log(string.Concat(new object[]
			{
				i +
				". Name: ",
				SceneManager.GetSceneByBuildIndex(i).name,
				" Path: ",
				SceneManager.GetSceneByBuildIndex(i).path,
				" Loaded: ",
				SceneManager.GetSceneByBuildIndex(i).isLoaded
			}));
	}

	private void OnLogsCleared()
	{
		this.ClearLogs();
		this.DrawHeaderText();
	}

	private static void OnLogCountCommand(string[] args)
		=> UnityEngine.Debug.Log(string.Format("There are {0} reported logs.", DebugLogs.Instance.Logs.Count));

	private static void OnLoadSceneCommand(string[] args)
	{
		if (args.Length != 2)
		{
			UnityEngine.Debug.LogError("Please specify a map name or buildID");
			return;
		}
		
		int sceneBuildIndex = 0;
		if (int.TryParse(args[1], out sceneBuildIndex))
		{
			SceneManager.LoadScene(sceneBuildIndex);
			return;
		}

		SceneManager.LoadScene(args[1]);
	}

	private static bool TrueOrFalse(string arg, out bool lol)
	{
		lol = arg == "t" || arg.ToLower() == "true";
		return lol || arg == "f" || arg.ToLower() == "false";
	}

	private static void OnLogAllCommand(string[] args)
	{
		if (args.Length != 2)
		{
			UnityEngine.Debug.LogError("Please specify either t or f.");
			return;
		}

		bool save;
		if (TrueOrFalse(args[1], save))
			Singleton<SaveSystem>.Instance.SetBool("console.logAll", out save);
		else
			UnityEngine.Debug.LogError("Please specify either t or f.");
	}

	private string ColorToString(Color32 color) => color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");

	private void PreLogIDK()
	{
		for (int i = 0; i < DebugLogs.Instance.Logs.Count; i++)
			this.ThrowReadyLogAtConsole(DebugLogs.Instance.Logs[i], string.Empty);
	}

	private static void OnHistoryCommand(string[] args)
	{
		for (int i = 0; i < DebugCommands.Instance.CommandHistory.Count; i++)
			UnityEngine.Debug.Log(DebugCommands.Instance.CommandHistory[i]);
	}

	private void CarefulConsoleLog(string message, DeviceLogUI deviceLog = null)
	{
		if (this.logContainer != null)
			this.AddDeviceLogToConsole((deviceLog == null) ? this.logPrefab : deviceLog, message);
	}

	private void AddDeviceLogToConsole(DeviceLogUI deviceLog, string message)
	{
		// Setup
		DeviceLogUI deviceLogUI = UnityEngine.Object.Instantiate<DeviceLogUI>(deviceLog);
		deviceLogUI.textUI.text = message;
		deviceLogUI.transform.SetParent(this.logContainer.transform);
		deviceLogUI.transform.localScale = Vector3.one;

		// Remove extra lines until we're under max character limit
		this.ConsoleTextLength += deviceLogUI.textUI.text.Length;
		while (this.ConsoleTextLength > DeviceConsole.MaxConsoleCharacterLength)
		{
			this.ConsoleTextLength -= this.DeviceLogs[0].textUI.text.Length;
			UnityEngine.Object.Destroy(this.DeviceLogs[0].gameObject);
			this.DeviceLogs.RemoveAt(0);
		}

		// Now add the log
		this.DeviceLogs.Add(deviceLogUI);
	}

	private void OnSetAutoFocusCommand(string[] args)
	{
		if (args.Length != 2)
		{
			UnityEngine.Debug.LogError("Please specify either t or f.");
			return;
		}

		if (DeviceConsole.TrueOrFalse(args[1], out bool save))
		{
			this.autoFocusInputField = save;
			return;
		}

		UnityEngine.Debug.LogError("Please specify either t or f.");
	}

	private static void OnClearCommand(string[] args) => DebugLogs.Instance.ClearLogs();

	private void OnLogAdded(DebugLogs.Log log) => this.ThrowReadyLogAtConsole(log, string.Empty);

	private void DrawHeaderText()
	{
		this.CarefulConsoleLog(string.Format("<color=#{0}>{1}</color>", this.ColorToString(this.headerColour), this.headerText), null);
		this.CarefulConsoleLog(string.Format("<color=#{0}>{1}</color>", this.ColorToString(this.headerColour),
			"       ██╗ ████╗         ██╗\n" +
			"  ██╗  ██║██╔═██╗  ████╗ ██║\n" +
			"██████╗██║██║ ██║ ██╔═██╗██║\n" +
			"╚═██╔═╝██║██║ ██║ ██║ ██║██║\n" +
			"  ╚═╝  ██║╚██████╗╚████╔╝███████╗\n" +
			"       ╚═╝ ╚═════╝ ╚═══╝ ╚══════╝"),
		null); // whoever reads this is gay
		this.CarefulConsoleLog(string.Format("<color=#{0}>{1}</color>", this.ColorToString(this.headerColour), "Game Version: " + Helpers.GetGameVersion()), null);
		this.CarefulConsoleLog(string.Format("<color=#{0}>{1}</color>", this.ColorToString(this.headerColour), "Type \"help\" for list of commands"), null);
		this.CarefulConsoleLog(string.Format("<color=#{0}>{1}</color>", this.ColorToString(this.headerColour), "================================"), null);
	}

	private void OnResetAchievement21Command(string[] BDGDDFKKGGA)
	{
		// Lol are these supposed to be official maps? I believe there stored somewhere else... :facepalm:
		foreach (string str in new List<string>
		{
		"896296812",
		"1248864821",
		"1087340967",
		"907198288",
		"1177138211",
		"1234332714",
		"1427616858",
		"880078120",
		"1278033234",
		"1332644700",
		"1159514800"
		})
		{
			Singleton<SaveSystem>.Instance.SetBool("achievements.21.completed.workshop." + str, false, null);
		}
		
		Helpers.SetStat("achievements.21.progress", 0);
		SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_21", (uint)Helpers.GetStat("achievements.21.progress"), 10U);

		UnityEngine.Debug.Log("Achievement 21 progress reseted");
	}

	private static void OnQuitCommand(string[] args) => Application.Quit();

	[SerializeField]
	private GameObject uiContainer;
	[SerializeField]
	private GameObject logContainer;

	[SerializeField]
	private InputField commandInputField;
	[SerializeField]
	private bool autoFocusInputField;

	[SerializeField]
	private Color headerColour;
	[SerializeField]
	private string headerText;

	[SerializeField]
	private DeviceLogUI logPrefab;
	[SerializeField]
	private DeviceLogUI warningLogPrefab;
	[SerializeField]
	private DeviceLogUI errorLogPrefab;
	[SerializeField]
	private DeviceLogUI assertLogPrefab;
	[SerializeField]
	private DeviceLogUI exceptionLogPrefab;
	[SerializeField]
	private DeviceLogUI exceptionStackTracePrefab;

	private int CommandHistoryIndex;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DeviceConsole.OnCommandEvent currentOnCommandEvent;

	private static int MaxConsoleCharacterLength = 15000;
	private int ConsoleTextLength;

	private List<DeviceLogUI> DeviceLogs;

	public class OnCommandEventArgs : EventArgs
	{
		public OnCommandEventArgs(string[] args)
		{
			this.args = args;
		}

		public string[] args;
	}

	public delegate void OnCommandEvent(object NFOGDAHIPNP, DeviceConsole.OnCommandEventArgs KJPAHOFPCKD);
}
