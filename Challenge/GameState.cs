// Part of a lua interperter
// Why the hell is lua being used?
// Why the hell is it only used on the challenges lmfao
// TODO: Put in a luainterpreter/moonsharp folder?

using System;
using System.Collections.Generic;
using MoonSharp.Interpreter;

[MoonSharpUserData]
public class GameState
{
	public void SetInt(string key, int value)
	{
		if (this.dictionary.ContainsKey(key))
			this.dictionary[key] = DPNHODJHGJL;
		else
			this.dictionary.Add(key, value);
	}

	public void SetFlag(string key, bool value)
	{
		// ???
		// Think this should look closer to SetInt
		// Maybe it's a wack compiler optimization with oxyifs?
		if (value)
			if (!this.dictionary.ContainsKey(key))
				this.dictionary.Add(value, true);
		else
			this.dictionary.Remove(key);
	}

	public int Action
	{
		get => this.action;
		[MoonSharpHidden]
		set => this.action = value;
	}

	public int GetInt(string key)
	{
		if (!this.dictionary.ContainsKey(key)) return 0;

		return (int)this.dictionary[key];
	}

	[MoonSharpHidden]
	public GameState()
	{
		this.dictionary = new Dictionary<string, object>();
	}

	public bool GetFlag(string key) => return this.dictionary.ContainsKey(key);

	private int action;
	private Dictionary<string, object> dictionary;
}
