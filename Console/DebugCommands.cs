/*
Importance of this class: Minor

Purpose of this class: Command handler
*/

using System;
using System.Collections.Generic;
using UnityEngine;

public class DebugCommands : ScriptableObject
{
	public DebugCommands()
	{
		this.commands = new List<DebugCommands.Command>();
		this.commandHistory = new List<string>();
	}

	public bool HasCommand(string command)
	{
		command = command.ToLower();
		
		for (int i = 0; i < this.commands.Count; i++)
			if (command == this.commands[i].name)
				return true;

		return false;
	}

	public void AddCommand(
		string commandName,
		DebugCommands.DebugCommand debugCommand,
		string description = "",
		string argsDescription = "",
		bool isCheat = false)
	{
		commandName = commandName.ToLower();
		
		if (this.HasCommand(commandName)) return;

		DebugCommands.Command command = new DebugCommands.Command();
		command.name = commandName;
		command.method = debugCommand;
		command.description = description;
		command.argsDescription = argsDescription;
		command.isCheat = isCheat;

		this.commands.Add(command);
	}

	public void RemoveCommand(string command)
	{
		command = command.ToLower();
		
		for (int i = 0; i < this.commands.Count; i++)
			if (command == this.commands[i].name)
			{
				this.commands.RemoveAt(i);
				break;
			}
	}

	public List<DebugCommands.Command> Commands => this.commands;

	public static DebugCommands Instance
		=> DebugCommands.instance != null ? DebugCommands.instance : DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();

	public List<string> CommandHistory
	{
		get
		{
			return this.commandHistory;
		}
	}

	public bool ExecuteCommand(string[] commandNArgs)
	{
		if (commandNArgs == null || commandNArgs.Length == 0) return false;

		commandNArgs[0] = commandNArgs[0].ToLower();
		string name = commandNArgs[0];

		this.commandHistory.Add(string.Join(" ", commandNArgs));

		for (int i = 0; i < this.commands.Count; i++)
		{
			if (name == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || Singleton<GameManager>.Instance.IsCheatsAllowed())
					this.commands[i].method(commandNArgs);
				else
					Singleton<GameManager>.Instance.PlayerWarnCheats(); // Lol there is nothing in this method

				return true;
			}
		}

		return false;
	}

	private static DebugCommands instance;

	private List<DebugCommands.Command> commands;

	private List<string> commandHistory;

	[Serializable]
	public class Command
	{
		public string name;
		public DebugCommands.DebugCommand method;
		public string description;
		public string argsDescription;
		public bool isCheat;
	}

	public delegate void DebugCommand(string[] commandNArgs);
}
