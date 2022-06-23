/*
Player Game Object for lobbies
*/

using System;
using System.Collections;
using Photon;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class LobbyPlayerElement : PunBehaviour
{
	[PunRPC]
	public void OnReadyClick(PhotonPlayer player)
	{
		Debug.Log("[LobbyPlayerElement] On ready click");
		this.CheckIsReady();
	}

	public void CheckIsReady()
	{
		this.isReady = (base.photonView.owner.GetTeam() != PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void KickPlayer()
	{
		if (PhotonNetwork.isMasterClient)
			this.SendKickPlayer(base.photonView.owner);
	}

	public void SendKickPlayer(PhotonPlayer player)
	{
		if (player == PhotonNetwork.player)
			Helpers.ObtainAchievement(23);

		base.photonView.RPC("KickThePlayer", player, new object[0]);
	}

	[PunRPC]
	private void KickThePlayer()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("LobbyCanvas").gameObject.SetActive(false);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#kicked", "#ok", null, true, false, 0f);
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	private void OnEnable() { }

	private IEnumerator LoadPlayerBySteamID(CSteamID steamId)
	{
		// Name
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamId, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamId, false);
		
		// Avatar
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamId, false));
		if (ResourcesManager.GetLoadedAvatar(steamId))
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(steamId);
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamId);

		// Rank & Color
		int rank = 0;
		if (loadedRank != null)
			rank = loadedRank.place;
		this.bg.color = RanksSystem.GetRankColor(rank, false);

		// Contributor
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamId));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamId));

		yield break;
	}

	public void OpenProfile()
	{
		CSteamID csteamID = new CSteamID(ulong.Parse(base.photonView.owner.name));
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?player=") + csteamID.m_SteamID, true);
	}

	private void Start()
	{
		if (!base.photonView.isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1f, 1f, 1f);
			this.Init();
		}
	}

	public void Init()
	{
		Debug.Log("[LobbyPlayerElement] Created lpe for " + base.photonView.owner.name);

		this.isReady = false;

		CSteamID steamId = new CSteamID(ulong.Parse(base.photonView.owner.name));
		base.StartCoroutine(this.LoadPlayerBySteamID(steamId));

		this.CheckIsReady();
	}

	private void Update()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public GameObject readyCanvas;

	public Text nicknameText;
	public Image bg;
	public Image icon;

	public bool isReady;

	public GameObject removeButton;

	public GameObject contributorGO;
}
