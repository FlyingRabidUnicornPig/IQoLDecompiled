/*
Importance of this class: Maybe not as important as other debug classes

Purpose of this class: Seems to be a GUI Debug? Prossibly dev-accessible only.
*/

using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugSystem : MonoBehaviour
{
	private IEnumerator GiveOxyATestItemLol(int JMMILEFMACB)
	{
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wwwform.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		WWW www = new WWW(url, data);
		yield return www;
		yield break;
	}

	private void OnGUI()
	{
		GUI.skin = this.skin;

		string[] commandLineArgs = Environment.GetCommandLineArgs();

		bool flag = false;

		foreach (string a in commandLineArgs)
			if (a == "-help")
				flag = true;

		if (!Singleton<SaveSystem>.Instance.HasKey("isBunned", null) && flag)
		{
			GUILayout.Label("Emergency Help:", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			GUILayout.Label(string.Concat(new object[]
			{
				"Current xp: ",
				Helpers.GetStat("player.xp"),
				" | Level: ",
				Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"))
			}), new GUILayoutOption[0]);

			if (GUILayout.Button("Reset XP", new GUILayoutOption[0]))
				Singleton<SaveSystem>.Instance.SetInt("player.xp", 0, null);

			if (GUILayout.Button("Reload Steam Inventory", new GUILayoutOption[0]))
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();

			if (GUILayout.Button("Reload Maps", new GUILayoutOption[0]))
				Singleton<MapsSystem>.Instance.Init();

			if (GUILayout.Button("Obtain promo Item", new GUILayoutOption[0])) {}

			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 25, new GUILayoutOption[0]);

			if (GUILayout.Button("Obtain test Item", new GUILayoutOption[0]))
				base.StartCoroutine(this.GiveOxyATestItemLol(int.Parse(this.JMMILEFMACB)));

			if (GUILayout.Button("Reset All", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(0);
			}
			
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void Update() {}

	private void Start() {}

	// I don't think we need to care about these, just don't delete em
	public GUISkin skin;
	private GameObject NGNILGONOOC;
	private bool AHBEBGJJIJH;
	private bool CKIEEIONLPH;

	// Test Item ID
	private string JMMILEFMACB = "0";
}
