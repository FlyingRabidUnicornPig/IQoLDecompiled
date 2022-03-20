/*
Important: Yeah kinda.

Purpose of this class: Log handler
*/

using System;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogs : ScriptableObject
{
	public DebugLogs()
	{
		this.logs = new List<DebugLogs.Log>();
	}

	private void OnLogMessageReceived(string message, string stackTrace, LogType logType)
	{
		if (!string.IsNullOrEmpty(stackTrace))
			stackTrace = stackTrace.Remove(stackTrace.Length - 1, 1);

		this.AddLog(new DebugLogs.Log
		{
			type = logType,
			message = message,
			stackTrace = stackTrace
		});
	}

	public static DebugLogs Instance => 
		DebugLogs.instance != null ? DebugLogs.instance : DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();

	private void OnDestroy() => Application.logMessageReceived -= this.OnLogMessageReceived;

	public void ClearLogs()
	{
		this.logs.Clear();

		if (this.OnLogsCleared != null)
			this.OnLogsCleared();
	}

	public void AddLog(DebugLogs.Log log)
	{
		this.logs.Add(log);

		if (this.OnLogAdded != null)
			this.OnLogAdded(log);
	}

	private void OnEnable() => Application.logMessageReceived += this.OnLogMessageReceived;

	public static DebugLogs Touch() => DebugLogs.Instance;

	public List<DebugLogs.Log> Logs => this.logs;
	private List<DebugLogs.Log> logs;

	private static DebugLogs instance;

	public Action<DebugLogs.Log> OnLogAdded;
	public Action OnLogsCleared;

	[Serializable]
	public class Log
	{
		public LogType type;
		public string message;
		public string stackTrace;
	}
}
