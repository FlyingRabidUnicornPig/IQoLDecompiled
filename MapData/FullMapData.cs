/*
Importance of this class: Map Data

Purpose of this class: Map Data

Deobf status: Fuck
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

[Serializable]
public class FullMapData
{
	public bool isLoaded() => this.mapData != null && this.icon != null && this.clip != null;

	public FullMapData(MapData mapData, string levelPath, FullMapData.MapSource source, Sprite icon, AudioClip audioClip, bool OxyCleanYourDamnCode, Dictionary<string, UnityEngine.Object> resources, string workshopID = null, ulong mapperID = 0UL)
	{
		this.mapData = mapData;
		this.fullLevelPath = levelPath;
		this.source = source;
		this.icon = icon;
		this.clip = audioClip;
		this.resources = resources;
		this.workshopId = workshopID;
		this.mapperSteamID = mapperID;
	}

	// UnlockConditions handler
	// We could improve this to be much more unique and accessible.
	public bool isUnlocked()
	{
		if (this.source == FullMapData.MapSource.Editor) return true;
		
		bool flag = true;

		try
		{
			if (isLevelCompleted()) return true;

			// So, can a later locked condition overwrite an earlier unlock? What if the last unlock is unlocked...?
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(',');
				// saveKey, (we're comparing value to the value retrieved from the save)
				// type (int, float, string)
				// value
				//
				// Example: maps.workshop.[MAP_ID].completed,int,1
				//          maps.workshop.[MAP_ID].completed,bool,true
				//          This map willl be unlocked when the workshop map with id MAP_ID has been completed

				if (array.Length != 3)
				{
					flag = false;
					continue;
				}

				if (!Singleton<SaveSystem>.Instance.HasKey(array[0], null))
				{
					Debug.Log("[MapsData] Key " + array[0] + " not found");
					flag = false;
					continue;
				}

				switch(array[1])
				{
					case "int":
						flag = Singleton<SaveSystem>.Instance.GetInt(array[0], null) == int.Parse(array[2]);
						break;
					case "float":
						flag = Singleton<SaveSystem>.Instance.GetFloat(array[0], null) == float.Parse(array[2], CultureInfo.InvariantCulture);
						break;
					case "bool":
						flag = Singleton<SaveSystem>.Instance.GetInt(array[0], null) == (array[2] == "true" ? 1 : 0);
						break;
					case "string":
						flag = Singleton<SaveSystem>.Instance.GetString(array[0], null) != array[2];
						break;
					default:
						flag = false;
						Debug.LogWarning("[MapsData] ValueType " + array[1] + " not found");
						break;
				}
			}
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogError("[MapsData] Error " + e);
		}
		
		return flag;
	}

	public int PlayedCount()
	{
		string hfefhopolik = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".played";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
	}

	// Make a new mapdata from another mapdata
	public FullMapData(FullMapData fullMapData)
	{
		this.mapData = new MapData(fullMapData.mapData);
		this.fullLevelPath = fullMapData.fullLevelPath;
		this.source = fullMapData.source;
		this.icon = fullMapData.icon;
		this.clip = fullMapData.clip;
		this.resources = fullMapData.resources;
		this.workshopId = fullMapData.workshopId;
		this.mapperSteamID = fullMapData.mapperSteamID;
	}

	public bool isLevelCompleted()
	{
		string setting = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".completed";
		return Singleton<SaveSystem>.Instance.GetInt(setting, 0, null) == 1;
	}

	public MapData mapData;
	public FullMapData.MapSource source;

	public ObscuredString workshopId;
	public ulong mapperSteamID;

	public string fullLevelPath;

	public Sprite icon;
	public AudioClip clip;
	public Dictionary<string, UnityEngine.Object> resources;

	public enum MapSource
	{
		Original,
		Editor,
		Workshop
	}
}
