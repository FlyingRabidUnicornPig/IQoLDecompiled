/*
Purpose of this class: Discord Controller. Handles RPC, using Discord for multi-invites, etc.
*/

using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;

public class DiscordController : MonoBehaviour
{
	public void RequestRespondNo()
	{
		Debug.Log("[DiscordController] Responding no to Ask to Join request");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	public void JoinCallback(string encryptedRoomID)
	{
		Debug.Log(string.Format("[DiscordController] Join ({0})", encryptedRoomID));

		// Not sure why we put encrypted id in invoke? not sure what invoke does to begin with.
		//   Prolly doesn't matter, i assume discord doesn't need to match with the game
		this.onJoin.Invoke(encryptedRoomID);
		
		base.StartCoroutine(this.JoinRoomByID(GameManager.Decrypt(encryptedRoomID)));
	}

	public void UpdatePresence(string details, string state = null)
	{
		this.presence.state = state;
		this.presence.details = details;
		this.presence.largeImageKey = "icon_border";
		this.presence.smallImageKey = null;

		CSteamID steamID = new CSteamID();
		try
		{
			if (!Helpers.SteamAPIDown)
				steamID = SteamUser.GetSteamID();
		}
		catch (InvalidOperationException e)
		{
			Helpers.SteamAPIDown = true;
		}

		if (!Helpers.SteamAPIDown && RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);

			this.presence.smallImageText = ResourcesManager.GetLoadedSteamPlayername(steamID, true);
			this.presence.smallImageKey = "white";
			if (loadedRank.place <= 10)
				this.presence.smallImageKey = "gold";
			else if (loadedRank.place <= 25)
				this.presence.smallImageKey = "violet";
			else if (loadedRank.place <= 100)
				this.presence.smallImageKey = "red";
			else if (loadedRank.place <= 500)
				this.presence.smallImageKey = "blue";
		}

		DiscordRpc.UpdatePresence(this.presence);
	}

	// TODO: Provide Menu/Console option to disable discord in-game
	private void OnDisable()
	{
		if (this.inited)
		{
			Debug.Log("[DiscordController] Shutdown");
			DiscordRpc.Shutdown();
		}
	}

	public void SpectateCallback(string id)
	{
		Debug.Log(string.Format("[DiscordController] Spectate ({0})", id));
		this.onSpectate.Invoke(id);
	}

	public void RequestCallback(ref DiscordRpc.DiscordUser user)
	{
		Debug.Log(string.Format("[DiscordController] Join request {0}#{1}: {2}", user.username, user.discriminator, user.userId));
		this.joinRequest = user;
		this.onJoinRequest.Invoke(user);
		base.StartCoroutine(this.JoinRequestDialogue());
	}

	public void ReadyCallback(ref DiscordRpc.DiscordUser user)
	{
		Debug.Log(string.Format("[DiscordController] Connected to {0}#{1}: {2}", user.username, user.discriminator, user.userId));
		this.onConnect.Invoke();
		this.inited = true;
	}

	private IEnumerator JoinRequestDialogue()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(
			"#discord{0}joinrequest".Replace("{0}", this.joinRequest.username),
			"#yes",
			new UnityAction(this.RequestRespondYes),
			"#no",
			new UnityAction(this.RequestRespondNo)));
		yield break;
	}

	public static DiscordController Instance => DiscordController.instance;

	// NOTE: Removed unrecompialable code. Unsure if this breaks anything in related to joining rooms, I assume not but /shrug
	private IEnumerator JoinRoomByID(string roomID)
	{
		try
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(roomID);
		}
		catch { }

		yield break;
	}

	public void RequestRespondYes()
	{
		Debug.Log("[DiscordController] Responding yes to Ask to Join request");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.Yes);
		this.hasResponded.Invoke();
	}

	public void DisconnectedCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[DiscordController] Disconnect {0}: {1}", PNCJHNNOAAP, JKPJCEMPAGH));
		this.onDisconnect.Invoke();
	}

	public void OnEnable()
	{
		Debug.Log("[DiscordController] Init");

		this.EventHandlers = default(DiscordRpc.EventHandlers);

		this.EventHandlers.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(
			this.EventHandlers.readyCallback,
			new DiscordRpc.OnReadyInfo(this.ReadyCallback));

		this.EventHandlers.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(
			this.EventHandlers.disconnectedCallback,
			new DiscordRpc.OnDisconnectedInfo(this.DisconnectedCallback));

		this.EventHandlers.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(
			this.EventHandlers.errorCallback,
			new DiscordRpc.OnErrorInfo(this.ErrorCallback));
			
		this.EventHandlers.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(
			this.EventHandlers.joinCallback,
			new DiscordRpc.OnJoinInfo(this.JoinCallback));

		this.EventHandlers.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(
			this.EventHandlers.spectateCallback,
			new DiscordRpc.OnSpectateInfo(this.SpectateCallback));

		this.EventHandlers.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(
			this.EventHandlers.requestCallback,
			new DiscordRpc.OnRequestInfo(this.RequestCallback));

		DiscordRpc.Initialize(this.applicationId, ref this.EventHandlers, true, this.optionalSteamId);
	}

	// Potentially touchy? Can't send invites after editing this.
	public void ErrorCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[DiscordController] Error {0}: {1}", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public DiscordController()
	{
		this.presence = new DiscordRpc.RichPresence();
	}

	private void Update()
	{
		DiscordRpc.RunCallbacks();
	}

	public void UpdateJoin(string joinSecret = null, string partyID = null, int partySize = 0, int partyMax = 0)
	{
		this.presence.joinSecret = joinSecret != null ? GameManager.Encrypt(joinSecret) : null; // Do we need to encrypt/decrypt?
		this.presence.partyId = joinSecret != null ? partyID : null;
		
		this.presence.partySize = partySize;
		this.presence.partyMax = partyMax;

		DiscordRpc.UpdatePresence(this.presence);
	}

	private void Awake()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length <= 1)
		{
			DiscordController.instance = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
			return;
		}

		UnityEngine.Object.Destroy(base.gameObject);
	}

	private void OnDestroy() { }

	private static DiscordController instance;

	public DiscordRpc.RichPresence presence;

	public string applicationId;
	public string optionalSteamId;

	public DiscordRpc.DiscordUser joinRequest;

	public UnityEvent onConnect;
	public UnityEvent onDisconnect;
	public UnityEvent hasResponded;
	public DiscordJoinEvent onJoin;
	public DiscordJoinEvent onSpectate;
	public DiscordJoinRequestEvent onJoinRequest;

	private DiscordRpc.EventHandlers EventHandlers;

	[HideInInspector]
	public bool inited;
}
