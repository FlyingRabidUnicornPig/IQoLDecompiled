/*
Importance of this class: yur mum

Purpose of this class: idk yur mum

Deobf status: I'm just doing this one file rn so i can get a little green square on github before i waste the rest of my day on stellaris and weed.
*/

using System;
using MoonSharp.Interpreter;

[MoonSharpUserData]
[Serializable]
public class GameEventInfo
{
	// goodcamelcase
	public float eventtime { get; set; }
	public int multiplayerplayers { get; set; }
	public int loopscount { get; set; }
	public string mapid { get; set; }
	public int handsCount { get; set; }
	public int gamemode { get; set; }
	public string eventtype { get; set; }
	public bool isstoryboardactive { get; set; }
	public bool isofficial { get; set; }
	public string maptags { get; set; }
	public float mapdifficulty { get; set; }
	public string mapper { get; set; }
	public bool isloved { get; set; }
	public bool isfunny { get; set; }
	public string eventdata { get; set; }
	public bool ismultiplayer { get; set; }
	public int multiplayerplace { get; set; }

	public void CopyValues(GameEventInfo gameEventInfo)
	{
		gameEventInfo.mapid = this.mapid;
		gameEventInfo.mapdifficulty = this.mapdifficulty;
		gameEventInfo.maptags = this.maptags;
		gameEventInfo.handsCount = this.handsCount;
		gameEventInfo.mapper = this.mapper;
		gameEventInfo.isofficial = this.isofficial;
		gameEventInfo.isloved = this.isloved;
		gameEventInfo.isfunny = this.isfunny;
		gameEventInfo.isstoryboardactive = this.isstoryboardactive;
		gameEventInfo.ismultiplayer = this.ismultiplayer;
		gameEventInfo.multiplayerplayers = this.multiplayerplayers;
		gameEventInfo.multiplayerplace = this.multiplayerplace;
		gameEventInfo.multiplayerplayers = this.multiplayerplayers;
		gameEventInfo.gamemode = this.gamemode;
		gameEventInfo.loopscount = this.loopscount;
		gameEventInfo.eventtype = this.eventtype;
		gameEventInfo.eventdata = this.eventdata;
		gameEventInfo.eventtime = this.eventtime;
	}
}

// sus