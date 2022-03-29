/*
Purpose of this class: Client Manager. Very important.

Deobf status: Method Names
*/

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
	public static string Decrypt(string toDecrypt)
	{
		if (string.IsNullOrEmpty(toDecrypt)) return "";

		try
		{
			return Crypto.DecryptStringAES(toDecrypt, GameManager.GetSecurityKey());
		}
		catch { }

		return toDecrypt; // Assume toDecrypt is already decrypted (cause mods) and return it back.
	}

	public static string Encrypt(string toEncrypt)
	{
		if (string.IsNullOrEmpty(toEncrypt)) return "";

		return Crypto.EncryptStringAES(toEncrypt, GameManager.GetSecurityKey());
	}

	public static byte[] Encrypt(byte[] toEncryptBytes) => Crypto.EncryptBytesAES(toEncryptBytes, GameManager.GetSecurityKey());
	public static byte[] Decrypt(byte[] toDecryptBytes) => Crypto.DecryptBytesAES(toDecryptBytes, GameManager.GetSecurityKey());

	public bool IsCheatsAllowed() => true; // MOD: Who fucking cares?
	public void PlayerWarnCheats() { ; }   // MOD: We do not fucking care.
	public void CheckPlayerBans() { ; ; }  // MOD: Not at all
	public int GetCurrentBanLevel() => 0;  // MOD: Nope, fuck it

	public static bool IsOwner() => true;  // MOD: This used to matter, this prevented family-sharing users from getting achievements and other garbage.
	                                       // Another attempt to cuck hackers from hacking a <$3 game when it cucks normal people more instead. 👍
	                                       // Now it's just bloat, adding extra ifs everywhere for no needed reason. I'm gonna need to rid of them aren't I.

	public void DieWithError(string error)
	{
		base.StopAllCoroutines();
		Singleton<Scene>.Instance.ShowCursor(true);
		UnityEngine.Debug.LogError(error);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(error.ToUpper(), "#ok".ToUpper(), new UnityAction(this.ExitGame), true, false, 0f);
	}

	public string HashHMAC(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		HMACSHA256 hmacsha = new HMACSHA256(asciiencoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hmacsha.ComputeHash(asciiencoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public new void Awake()
	{
		base.Awake();

		UnityEngine.Debug.unityLogger.filterLogType = LogType.Warning; // Oooh is this what prevents normal users from seeing more debug shit?
		                                                               // I should make a command that allows users to see more debug if they want.
																	   // Right now I modded my UnityEngine.dll to say my Intralism is in debug; overrides this filter
	}

	public void FinishedMap(FinishedMapInfo fmi)
	{
		if (this.onFinishedMap != null)
			this.onFinishedMap(fmi);
	}

	public void OpenURL(string url, bool useSteamOverlay = true)
	{
		try
		{
			if (useSteamOverlay)
				SteamFriends.ActivateGameOverlayToWebPage(url);
			else
				Application.OpenURL(url);
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogWarning(e.Message);
		}
	}

	public void GameEvent(GameEventInfo gei)
	{
		if (this.onGameEvent != null)
			this.onGameEvent(gei);
	}

	// This is why client-side encryption can't work you fucking moron. The data is somewhere, even if you *tried* to hide it.
	// Modders can access this for free. Normal players cannot. Good job fixing a "hacking" problem by fucking over everyone else to feed one guy's ego.
	public static string GetSecurityKey() => Singleton<GameManager>.Instance.securityKey;

	private bool verified;
	public void OnUserVerified(bool offlineMode = false)
	{
		if (verified && !offlineMode) return; // HACK: Allow offline mode to always go through, causes bug.
		                                      // BUG: Can get into a semi-offline state,
		                                      //      where intralism stuff won't work, official, loved, funny maps, etc.
											  //      but steam stuff will, rank submission, workshop maps
											  // TODO: Make sure this does work when connection to Intralism is flakey, I think it does now, but should double check.
										      //       todo: put this comment on the MenuScene if statement, not here.
		verified = true;

		GameManager.IsOffline = offlineMode;

		if (!GameManager.IsOffline)	SteamUserStats.RequestCurrentStats(); // MOD: Why would you let offline mode attempt to connect to steam?

		Singleton<SaveSystem>.Instance.Init(Helpers.Md5Sum("Data" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.Init();
		Singleton<LuaEnvironment>.Instance.RunFirstInit();
	}

	public void StartOfflineMessage()
	{
		Singleton<Scene>.Instance.ShowCursor(true);
		base.StartCoroutine(
			Singleton<MessageBoxPanel>.Instance.DisplayDialog(
				"#startofflinemessage",
				"#exit".ToUpper(),
				new UnityAction(this.ExitGame),
				"#yes".ToUpper(),
				delegate { this.OnUserVerified(true); }));
	}

	public string CreateServerURL(string harryPotterPrologue) => (!this.isBeta ? this.dataServerURL : this.betaDataServerURL) + harryPotterPrologue;

	public void UpdateOnlineStatus(string details, string state = null, string joinSecret = null, string partyID = null, int partySize = 0, int partyMax = 0)
	{
		DiscordController.Instance.UpdatePresence(details, state);

		if (joinSecret == null)
			DiscordController.Instance.UpdateJoin(null, null, 0, 0);
		else
			DiscordController.Instance.UpdateJoin(joinSecret, partyID, partySize, partyMax);

		SteamFriends.SetRichPresence("status", details + (string.IsNullOrEmpty(state) ? "" : "\n" + state));
		SteamFriends.SetRichPresence("connect", joinSecret);
	}

	public void ExitGame() => Application.Quit();

	private bool isOffline;
	public static bool IsOffline
	{
		get => Singleton<GameManager>.Instance.isOffline;
		private set => Singleton<GameManager>.Instance.isOffline = value;
	}

	public bool isBeta;

	public string cachURL;

	public string securityKey;

	public string dataServerURL;
	public string betaDataServerURL;

	public RanksSystem.Ban actveBan;

	private bool whoTheHellIsSteveJobs; // unused

	public GameManager.GameState currentState;


	public delegate void FinishedMapEvent(FinishedMapInfo DAGALCAILLN);

	public delegate void PlayerGameEvent(GameEventInfo DAGALCAILLN);

	public enum GameState
	{
		Init,
		Loading,
		Menu,
		Playing,
		Finished,
		Editor
	}

	// Can we throw this repeated code into an event or something? I'm not sure i'm not familiar with event shit
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GameManager.FinishedMapEvent onFinishedMap;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GameManager.PlayerGameEvent onGameEvent;

	public event GameManager.PlayerGameEvent OnGameEvent
	{
		add
		{
			GameManager.PlayerGameEvent playerGameEvent = this.onGameEvent;
			GameManager.PlayerGameEvent playerGameEvent2;
			do
			{
				playerGameEvent2 = playerGameEvent;
				playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.onGameEvent, (GameManager.PlayerGameEvent)Delegate.Combine(playerGameEvent2, value), playerGameEvent);
			}
			while (playerGameEvent != playerGameEvent2);
		}
		remove
		{
			GameManager.PlayerGameEvent playerGameEvent = this.onGameEvent;
			GameManager.PlayerGameEvent playerGameEvent2;
			do
			{
				playerGameEvent2 = playerGameEvent;
				playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.onGameEvent, (GameManager.PlayerGameEvent)Delegate.Remove(playerGameEvent2, value), playerGameEvent);
			}
			while (playerGameEvent != playerGameEvent2);
		}
	}

	public event GameManager.FinishedMapEvent OnFinishedMap
	{
		add
		{
			GameManager.FinishedMapEvent finishedMapEvent = this.onFinishedMap;
			GameManager.FinishedMapEvent finishedMapEvent2;
			do
			{
				finishedMapEvent2 = finishedMapEvent;
				finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.onFinishedMap, (GameManager.FinishedMapEvent)Delegate.Combine(finishedMapEvent2, value), finishedMapEvent);
			}
			while (finishedMapEvent != finishedMapEvent2);
		}
		remove
		{
			GameManager.FinishedMapEvent finishedMapEvent = this.onFinishedMap;
			GameManager.FinishedMapEvent finishedMapEvent2;
			do
			{
				finishedMapEvent2 = finishedMapEvent;
				finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.onFinishedMap, (GameManager.FinishedMapEvent)Delegate.Remove(finishedMapEvent2, value), finishedMapEvent);
			}
			while (finishedMapEvent != finishedMapEvent2);
		}
	}
}
