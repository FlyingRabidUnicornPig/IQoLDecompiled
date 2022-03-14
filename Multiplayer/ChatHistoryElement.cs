/*
Importance of this class: Probably pretty important for multi-lobbies

Purpose of this class: The graphics object for chat messages
*/

using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class ChatHistoryElement : MonoBehaviour
{
	public void Init(string message)
	{
		this.message.text = message;
		base.GetComponent<ContentSizeFitterFx>().DoFix();
	}

	public void Init(CSteamID steamId, string message)
	{
		this.message.text = message;
		base.StartCoroutine(this.CreateUserIcon(steamId));
	}

	private IEnumerator CreateUserIcon(CSteamID steamId)
	{
		// Load username
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamId, false));
		
		// Color the name
        	this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamId, true);
		
		// Load Avatar
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamId, false));
		if (ResourcesManager.GetLoadedAvatar(steamId))
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(steamId);
		
		// Avatar background color
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamId);
		int rank = loadedRank != null ? loadedRank.place : 0;
		this.bg.color = RanksSystem.GetRankColor(rank, false);
		
		// Contributor icon
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamId));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamId));
		
		// Fit content
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	public ChatHistoryElement.ChatHistoryType messageType;

	// Visible Shit
	public Text nicknameText;
	public Image bg;
	public Image icon;
	public GameObject contributorGO;
	public Text message;

	private CSteamID steamID;

	public enum ChatHistoryType
	{
		FromPlayer,
		Server
	}
}
