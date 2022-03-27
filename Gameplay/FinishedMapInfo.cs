/*
Importance of this class: Finished Play info

Purpose of this class: Hold stats about the game you just played.
*/

using System;
using MoonSharp.Interpreter;

[MoonSharpUserData]
[Serializable]
public class FinishedMapInfo
{
	public int multiplayerplayers { get; set; }
	public bool ismultiplayer { get; set; }
	public int multiplayerplace { get; set; }

	public int gamemode { get; set; }

	public bool isofficial { get; set; }
	public bool isloved { get; set; }
	public bool isfunny { get; set; }

	public string maptags { get; set; }
	public string mapid { get; set; }
	public string mapper { get; set; }
	public float mapdifficulty { get; set; }
	public int handsCount { get; set; }

	public float accuracy { get; set; }

	public bool completed { get; set; }
	public int misses { get; set; }
	public int perfecthits { get; set; }
	public int score { get; set; }
	public float time { get; set; }
	public bool isstoryboardactive { get; set; }
	public int loopscount { get; set; }

	public void CopyValues(FinishedMapInfo finishedMap)
	{
		finishedMap.mapid = this.mapid;
		finishedMap.mapdifficulty = this.mapdifficulty;
		finishedMap.maptags = this.maptags;
		finishedMap.handsCount = this.handsCount;
		finishedMap.mapper = this.mapper;
		finishedMap.isofficial = this.isofficial;
		finishedMap.isloved = this.isloved;
		finishedMap.isfunny = this.isfunny;
		finishedMap.completed = this.completed;
		finishedMap.isstoryboardactive = this.isstoryboardactive;
		finishedMap.ismultiplayer = this.ismultiplayer;
		finishedMap.multiplayerplayers = this.multiplayerplayers;
		finishedMap.multiplayerplace = this.multiplayerplace;
		finishedMap.multiplayerplayers = this.multiplayerplayers;
		finishedMap.gamemode = this.gamemode;
		finishedMap.loopscount = this.loopscount;
		finishedMap.accuracy = this.accuracy;
		finishedMap.score = this.score;
		finishedMap.perfecthits = this.perfecthits;
		finishedMap.misses = this.misses;
		finishedMap.time = this.time;
	}
}
