/*
Main Gameplay class
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScene : global::Scene
{
	public void OnStartRound()
	{
		// stop loading, start game
		this.loadingCanvas.SetActive(false);
		this.ingameUICanvas.SetActive(true);

		// Highscore
		Transform bestScoreText = this.ingameUICanvas.transform.FindDeepChild("BestScoreText");
		bestScoreText.GetComponent<Text>().text = this.highScore + ": " + this.pbase.lastBestScore;

		// Reset UI
		this.HPTextnAcc.color = Color.white;
		this.scoreText.color = Color.white;
		this.comboTextGO.color = Color.white;
		bestScoreText.GetComponent<Text>().color = Color.white;
		this.ingameUICanvas.transform.FindDeepChild("Fill").GetComponent<Image>().color = new Color(0.654902f, 0.8784314f, 0.9843137f);

		// In relax mode, remove scoring UI elements
		if (this.gameMode == GameScene.GameMode.Relax)
		{
			bestScoreText.gameObject.SetActive(false);
			this.scoreText.gameObject.SetActive(false);
			this.HPTextnAcc.gameObject.SetActive(false);
			this.comboTextGO.gameObject.SetActive(false);
		}

		// Remove score but not accuracy for PlayTest mode
		// Encourage getting well timed patterns rather than playing for high score
		// Also a way to signal to users "This is a different mode than others"
		if (this.gameMode == GameScene.GameMode.PlayTest)
		{
			bestScoreText.gameObject.SetActive(false);
			this.scoreText.gameObject.SetActive(false);
		}

		// If in mutliplayer hide the chat
		if (!PhotonNetwork.offlineMode)
			Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	public void Reset()
	{
		// Audio volume/pitch, used for game over effects
		foreach (AudioSource audioSource in this.asampler.audioSources)
		{
			audioSource.pitch = 1f;
			audioSource.volume = 1f;
		}

		// Remove all player bases
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 0; i < array.Length; i++)
			UnityEngine.Object.DestroyImmediate(array[i].gameObject);

		// UI
		this.gameOverCanvas.SetActive(false);
		this.spectatorCanvas.SetActive(false);
		this.spectatePanel.SetActive(false);
		this.ingameUICanvas.SetActive(false);
		this.restartCheckpointPanel.SetActive(false);
		this.restartNoCheckpointPanel.SetActive(false);

		// bools
		this.gameOver = false;
		this.gameOverSetUp = false;
		this.isGameStarted = false;
		this.calculatedmaptime = 0f;
		this.asampler.isMuted = false;
		this.asampler.isInited = false;
		this.haveWeDoneFirstFrameShitYet = false;

		// Level Progress Bar
		try
		{
			this.levelProgressBar = this.ingameUICanvas.transform.Find("LevelProgressBar").gameObject;
			this.levelProgressBar.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = new Color(0.654902f, 0.8784314f, 0.9843137f);
			this.levelProgressBar.GetComponent<Slider>().value = 0f;
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogWarning("Error while reseting loading bar:\n" + e.Message);
		}

		// Score Text
		try
		{
			this.scoreText = this.ingameUICanvas.transform.FindDeepChild("ScoreText").GetComponent<Text>();
			this.scoreText.text = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper() + ": " + 0;
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogWarning("Error while reseting score text:\n" + e.Message);
		}

		// HP/Accuracy Text
		try
		{
			this.showHP = Singleton<SaveSystem>.Instance.GetBool("settings.showHP", true, null);
			this.HPTextnAcc = this.ingameUICanvas.transform.FindDeepChild("HPText").GetComponent<Text>();
			this.HPTextnAcc.text = string.Empty;
			this.HPTextnAcc.horizontalOverflow = HorizontalWrapMode.Overflow;
			this.HPTextnAcc.verticalOverflow = VerticalWrapMode.Overflow;
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogWarning("Error while reseting HP and Acc text:\n" + e.Message);
		}

		// Combo Text
		try
		{
			this.comboTextGO = this.ingameUICanvas.transform.FindDeepChild("ComboText").GetComponent<Text>();
			this.comboTextGO.text = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper() + ": " + 0;
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogWarning("Error while reseting combo text:\n" + e.Message);
		}

		base.ShowCursor(false);
	}

	// Queue Banner Message
	public void AddMessage(string message, float time = 1f)
	{
		this.messageTextQueue.Add(message);
		this.messageTimeQueue.Add(time);
	}

	public void OnExitButton()
	{
		if (PhotonNetwork.offlineMode && this.mapID != "original.tutorial")
			Singleton<SaveSystem>.Instance.SetBool("menu.playedsolo", true, null);
			
		if (this.pbase != null)
		{
			this.pbase.DeletePlayerCheckpointData();
			PhotonNetwork.offlineMode = false;
		}

		base.GetComponent<NetworkScene>().OnExitButton(0);

		Singleton<SaveSystem>.Instance.Flush();
	}

	public bool AllPlayersFinished()
	{
		bool result = true;
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
		{
			result = photonPlayer.CustomProperties["finished"] != null ? (bool)photonPlayer.CustomProperties["finished"] : false;
			
			if (!result)
				break;
		}

		return result;
	}

	public IEnumerator UpdateSpectatingInfo()
	{
		ulong num = 0UL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[this.pbase.spectrid].NickName);
		}
		catch (Exception) { }

		Sprite sprite = null;
		CSteamID csteamID = new CSteamID(num);
		if (num != 0UL)
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));

			if (ResourcesManager.GetLoadedAvatar(csteamID))
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
		}

		GameObject spectatingInfo = GameObject.Find("SpectatingUserInfo");
		spectatingInfo.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
		spectatingInfo.transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;

		yield break;
	}

	public void OnSpectatePrevButton()
	{
		this.pbase.SpectateNext(false);
		base.StartCoroutine(this.UpdateSpectatingInfo());
	}

	public void ShowGameOverScreen(bool showCanvas = false)
	{
		// Switch canvases
		this.gameOverCanvas.SetActive(showCanvas);
		this.spectatePanel.SetActive(!this.AllPlayersFinished());

		if (this.AllPlayersFinished())
		{
			// Add "reset from checkpoint" button
			bool resetFromCheckpoint = !this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint();
			this.restartCheckpointPanel.SetActive(resetFromCheckpoint);
			this.restartNoCheckpointPanel.SetActive(!resetFromCheckpoint);
			
			base.ShowCursor(true);
			
			// Did you win a multiplayer match?
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && base.GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
				Helpers.ObtainAchievement(17);
		}

		for (int i = 0; i < this.levelInfoContent.transform.childCount; i++)
			UnityEngine.Object.Destroy(this.levelInfoContent.transform.GetChild(i).gameObject);

		// Set up the map icon on the right I think?
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		
		GameObject mapIcon = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelInfo, mapData, this.levelInfoContent);
		mapIcon.GetComponent<LevelsListElementButton>().launchLevelMode = -1;

		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
			mapIcon.GetComponent<LevelsListElementButton>().ToggleRate();
	}

	// Show Banner Message
	public IEnumerator ShowMessage(string message, float howLong)
	{
		// Why bother with 0 timing?
		if (howLong == 0f)
			yield break;

		this.messageCanvas.GetComponentInChildren<Text>().text = message;

		// Max fade time of 1 second, otherwise 1/4th of howLong
		this.messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((howLong >= 1f) ? 1f : (howLong / 4f));

		// Open over fade-time
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		// Wait for howLong
		yield return new WaitForSeconds(howLong);
		// Close over fade-time
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		// wait for fade time before showing another message
		yield return new WaitForSeconds((howLong >= 1f) ? 1f : (howLong / 4f));
		yield break;
	}

	private IEnumerator NewHighScoreMeme()
	{
		yield return new WaitForSeconds(1f);
		
		this.pbase.scoreBeated = true; // My dad beated me as a child
		
		Debug.Log("[PlayerBase] New highscore");

		this.AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"), 1f);

		string highScoreSave = "maps." + this.mapID + 
		                       (this.gameMode != GameScene.GameMode.Normal ? "." + this.gameMode.ToString().ToLower() : "") +
							   ".highScore";

		Singleton<SaveSystem>.Instance.SetInt(highScoreSave, this.pbase.GetCurrentScore(), null);
		yield break;
	}

	private void HandleMultiplayerStuff(string result)
	{
		if (!PhotonNetwork.offlineMode)
			Singleton<MultiplayerSystem>.Instance.ShowChat();

		base.GetComponent<NetworkScene>().UpdateScoreboard();

		// Saying "I'm done"
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && result != "CompletedLevel") // Not sure how you can be in a room and not online mode, testing?
		{
			base.GetComponent<NetworkScene>().photonView.RPC("OnPlayerGameMessage", PhotonTargets.Others, new object[]
			{
				PhotonNetwork.playerName,
				"Finished"
			});
		}
	}

	private void ObtainAchievementsAndLevelUp(RanksSystem.Map map, FullMapData mapData)
	{
		bool proGamer = this.gameMode != GameScene.GameMode.Relax && this.pbase.isPlayerWon;
		bool mapExists = map != null;

		// Multiplayer achievements
		if (!PhotonNetwork.offlineMode)
		{
			// Orgy?
			if (PhotonNetwork.room.PlayerCount >= 2)
				Helpers.ObtainAchievement(18);
			// Fap?
			if (PhotonNetwork.room.PlayerCount == 1)
				Helpers.ObtainAchievement(19);
			
			// Play workshop map in multiplayer
			if (mapData.source == FullMapData.MapSource.Workshop)
				Helpers.ObtainAchievement(16);

			if (proGamer)
			{
				// Are you winning son?
				Helpers.ObtainAchievement(15);
			}
		}
		
		// Achievements/Level Up for beating a non-relax map
		if (proGamer)
		{
			// Played 10 official maps achievement (May be broken?)
			if (Singleton<SaveSystem>.Instance.GetInt("achievements.21.progress", 0) < 10 && // Played less than 10 official
			    mapExists &&
				!Singleton<SaveSystem>.Instance.GetBool("achievements.21.completed." + this.mapID, true)) // we haven't finished this map before
			{
				Singleton<SaveSystem>.Instance.SetBool("achievements.21.completed." + this.mapID, true, null);
				Helpers.AddToStat("achievements.21.progress", 1);
				SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_21", (uint)Helpers.GetStat("achievements.21.progress"), 10U);
			}

			// 90% or better achievement
			if (this.pbase.accuracyScore >= 0.9f && mapData.source == FullMapData.MapSource.Workshop && map != null)
				Helpers.ObtainAchievement(22);

			// XP gained is acc * score
			Helpers.AddToStat("player.xp", (int)(this.pbase.accuracyScore * (float)this.pbase.correctScore));

			this.pbase.DeletePlayerCheckpointData();
		}
		else if (this.pbase.isPlayerWon && this.gameMode == GameScene.GameMode.Relax && mapData.source == FullMapData.MapSource.Workshop)
		{
			// Relax tracker achievement
			Helpers.AddToStat("achievements.26.progress", 1);
			SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_26", (uint)Helpers.GetStat("achievements.26.progress"), 5U);

			// Perfect relax game achievement
			if (mapExists && this.pbase.incorrectScore == 0)
				Helpers.ObtainAchievement(27);
		}
	}

	private void BuildMapInfo(RanksSystem.Map map, FullMapData mapData)
	{
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.completed = this.pbase.isMapCompleted;

			finishedMapInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false, null);
			finishedMapInfo.gamemode = (int)this.gameMode;

			finishedMapInfo.loopscount = this.pbase.loopsCount;

			if (map != null)
			{
				finishedMapInfo.isofficial = map.isOfficial;
				finishedMapInfo.isloved = map.isLoved;
				finishedMapInfo.isfunny = map.isFunny;
				finishedMapInfo.mapdifficulty = map.difficulty;
			}
			else
			{
				finishedMapInfo.isofficial = false;
				finishedMapInfo.isloved = false;
				finishedMapInfo.isfunny = false;
				finishedMapInfo.mapdifficulty = -1f;
			}

			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = base.GetComponent<NetworkScene>().place;

			finishedMapInfo.handsCount = mapData.mapData.handCount;

			finishedMapInfo.mapid = this.mapID;
			finishedMapInfo.maptags = string.Join(",", mapData.mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + mapData.mapperSteamID;

			finishedMapInfo.misses = this.pbase.incorrectScore;
			finishedMapInfo.perfecthits = this.pbase.perfectHits;
			finishedMapInfo.score = this.pbase.GetCurrentScore();
			finishedMapInfo.accuracy = this.pbase.accuracyScore;

			finishedMapInfo.time = this.CurrentTime;

			foreach (GameEventInfo gei in this.pbase.gameEventInfoList)
				Singleton<GameManager>.Instance.GameEvent(gei);
			
			this.pbase.gameEventInfoList.Clear();

			Singleton<GameManager>.Instance.FinishedMap(finishedMapInfo);
		}
		catch (Exception) { }
	}

	public void ShowResult(string result = "")
	{
		this.gameOver = true;

		HandleMultiplayerStuff(result);

		if (this.AllPlayersFinished())
			this.currentMusicTime = this.calculatedmaptime;

		if (string.IsNullOrEmpty(result))
			this.levelProgressBar.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.red;

		// Completed level?
		bool completed = result.Equals("CompletedLevel");
		this.pbase.isMapCompleted = completed;
		this.pbase.isPlayerWon = completed;

		// Got highscore?
		if (this.gameMode != GameScene.GameMode.Relax && this.pbase.GetCurrentScore() > this.pbase.lastBestScore && !this.pbase.scoreBeated)
			base.StartCoroutine(this.NewHighScoreMeme());

		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);

		// Submit score and "replay" to server
		this.pbase.StopReplayRecording();
		ulong workshopId = 0;
		if (Singleton<SaveSystem>.Instance.GetInt("settings.enableranking", 1, null) == 1
			&& this.gameMode != GameScene.GameMode.Relax
			&& mapData.source == FullMapData.MapSource.Workshop
			&& ulong.TryParse(mapData.workshopId, out workshopId)
			&& workshopId != 0
			&& RanksSystem.IsOfficial(workshopId, false))
		{
			string mapFilePath = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			string replayJson  = this.pbase.Replay() != null ? JsonConvert.SerializeObject(this.pbase.Replay()) : "{}";

			base.StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(mapData.workshopId, this.gameMode, this.pbase.GetCurrentScore(), this.pbase.accuracyScore, this.pbase.incorrectScore, YAFECWOW.CompressString(replayJson), Helpers.CalculateMD5(mapFilePath)));
		}

		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();

		// Add 1 to playcount of this map
		string timesPlayedSave = "maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".played";
		Helpers.AddToStat(timesPlayedSave, 1);

		RanksSystem.Map map = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map x) => "workshop." + x.id == this.mapID);
		BuildMapInfo(map, mapData);
		ObtainAchievementsAndLevelUp(map, mapData);

		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
			SteamUGC.StopPlaytimeTrackingForAllItems();

		this.resultText.GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey(!this.pbase.isPlayerWon ? "failed" : "levelcompleted").ToUpper();
		
		this.OnGameOverEvent.Invoke();

		this.ShowGameOverScreen(false);
	}

	public ObscuredFloat CurrentTime
	{
		get => this.currentMusicTime;
		set
		{
			this.currentMusicTime = value;

			if (this.currentMusicTime >= 0f)
			{
				if (this.asampler.audioSources[0].clip)
					this.asampler.audioSources[0].time = this.currentMusicTime;

				if (this.asampler.audioSources[1].clip)
					this.asampler.audioSources[1].time = this.currentMusicTime;
			}
		}
	}

	public void RestartEndless()
	{
		this.pbase.loopsCount++;
		base.StartCoroutine(this.ShowMessage("#loopnumber " + this.pbase.loopsCount, 1f * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f, null)));
		this.haveWeDoneFirstFrameShitYet = false;
		this.currentMusicTime = -1f;
		this.pbase.ResetEndless();
	}

	public override void Update()
	{
		base.Update();

		// Display Messages
		// TODO: Make this a method
		if (this.messageTextQueue.Count > 0 && !this.messageCanvas.activeSelf)
		{
			string message = this.messageTextQueue[0];
			
			float messageDuration = 1f;
			if (this.messageTimeQueue.Count == this.messageTextQueue.Count)
				messageDuration = this.messageTimeQueue[0];

			base.StartCoroutine(this.ShowMessage(message, messageDuration * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f, null)));
			this.messageTextQueue.RemoveAt(0);
			this.messageTimeQueue.RemoveAt(0);
		}

		// Game Over?
		if (this.gameOver)
		{
			if (!gameOverSetUp && this.AllPlayersFinished() && (this.pbase.currentState == PlayerBase.PlayerState.Spectator || this.spectatePanel.activeSelf))
			{
				this.OxyPls(); // Turn off gameplay UI
				this.pbase.currentState = PlayerBase.PlayerState.Finished;
			}
			if (this.pbase.currentState == PlayerBase.PlayerState.Finished)
				this.SetUpGameOverShit(); // Setup Gameover UI and lower the volume and/or pitch
			return;
		}

		// Gameplay
		if (this.isGameStarted)
		{
			// Press play on the music objects when we hit 0 seconds
			if (!this.haveWeDoneFirstFrameShitYet && this.currentMusicTime > 0f)
				this.FirstFrameShit();

			if (this.currentMusicTime < this.calculatedmaptime && !this.IsRoundFinished())
			{
				this.currentMusicTime += Time.deltaTime;
				this.UpdateUI();
				if (hardInput.GetKeyDown("restart") && PhotonNetwork.offlineMode)
				{
					foreach (GameEventInfo gei in this.pbase.gameEventInfoList)
						Singleton<GameManager>.Instance.GameEvent(gei);

					this.pbase.gameEventInfoList.Clear();
					this.OnRestartButton(true);
				}
			}
			else if (!this.gameOver)
				this.HandleEndingShitIThink();
		}
		else if (this.AllPlayerLoaded())
		{
			this.pbase.photonView.RPC("StartRound", PhotonTargets.AllBufferedViaServer, null);
		}
	}

	public bool AllPlayerLoaded()
	{
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
			if (photonPlayer.CustomProperties["ready"] == null || (photonPlayer.CustomProperties["ready"] != null && !(bool)photonPlayer.CustomProperties["ready"]))
				return false;
		return true;
	}

	public GameScene()
	{
		this.gameOver = false;
		this.gameOverSetUp = false;

		this.isGameStarted = false;

		this.usingCheckpoints = true;
		this.gameMode = GameScene.GameMode.Normal;

		this.haveWeDoneFirstFrameShitYet = false;

		this.messageTextQueue = new List<string>();
		this.messageTimeQueue = new List<float>();

		this.scoreStr = string.Empty;
		this.livesAndOrAcc = string.Empty;
		this.highScore = string.Empty;
		this.combo = string.Empty;

		this.currentMusicTime = 0f;
	}

	public void OnSpectateButton()
	{
		this.restartCheckpointPanel.SetActive(false);
		this.restartNoCheckpointPanel.SetActive(false);

		this.gameOverCanvas.SetActive(false);
		this.spectatorCanvas.SetActive(true);

		base.StartCoroutine(this.UpdateSpectatingInfo());
		this.pbase.StartSpectating();
	}

	public void OnSpectateNextButton()
	{
		this.pbase.SpectateNext(true);
		base.StartCoroutine(this.UpdateSpectatingInfo());
	}

	public void OnEnable() { }

	public bool IsRoundFinished() => this.gameOver && this.AllPlayersFinished();

	public override void Start() => this.Start(0f);

	public void OnRestartRound()
	{
		this.loadingCanvas.SetActive(true);
		base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	public void OnRestartButton(bool fullRestart)
	{
		if (fullRestart)
			this.pbase.DeletePlayerCheckpointData();
		else if (this.pbase.ach12)
			Helpers.ObtainAchievement(12);
		
		base.GetComponent<NetworkScene>().photonView.RPC("OnMastedChangeScene", PhotonTargets.AllViaServer, SceneManager.GetActiveScene().name);
	}

	public void Start(float time)
	{
		base.Start();
		this.Reset();

		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = true;
			PhotonNetwork.JoinOrCreateRoom("offline", new RoomOptions(), TypedLobby.Default);
		}

		this.mapID = Singleton<SaveSystem>.Instance.GetString("menu.selectedlevelid", null);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);

		this.gameMode = (GameScene.GameMode)Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0, null);

		// UI
		this.scoreStr = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper();
		this.highScore = LocalizationService.Instance.GetLocalizatedText("#highscore").ToUpper();
		this.combo = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper();

		// Display accuaracy only on hardcore
		if (this.gameMode != GameScene.GameMode.Hardcore)
			this.livesAndOrAcc = LocalizationService.Instance.GetLocalizatedText("#lives").ToUpper();
		else
			this.livesAndOrAcc = LocalizationService.Instance.GetLocalizatedText("#accuracy").ToUpper();

		if (this.showHP)
			this.HPTextnAcc.text = string.Empty;
		else
			this.HPTextnAcc.gameObject.SetActive(false);
		
		// Remove previous info
		for (int i = 0; i < this.levelInfoContent.transform.childCount; i++)
			UnityEngine.Object.Destroy(this.levelInfoContent.transform.GetChild(i).gameObject);

		// Create map info
		GameObject mapInfo = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelInfo, mapData, gameObject);
		mapInfo.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source != FullMapData.MapSource.Original && mapData.source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
			mapInfo.GetComponent<LevelsListElementButton>().ToggleRate();

		GameObject gameBase = (!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate<GameObject>(Resources.Load("Gameplay/Base") as GameObject) : PhotonNetwork.Instantiate("Gameplay/Base", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
		this.pbase = gameBase.GetComponent<PlayerBase>();
			
		// Discord RPC
		bool discord = this.gameMode.Equals(GameScene.GameMode.PlayTest) && Singleton<SaveSystem>.Instance.GetBool("settings.disableeditordiscordrpc", true, null);
		
		string RPCDetails = "Play" + ((!PhotonNetwork.offlineMode) ? "ing Multiplayer" : (discord ? "testing" : "ing Solo"));
		string RPCState = discord ? "" : ("Map: " + mapData.mapData.name.Replace(Environment.NewLine, string.Empty));

		Singleton<GameManager>.Instance.UpdateOnlineStatus(RPCDetails, RPCState, null, null, 0, 0);

		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count); // Can't we just make the array instead of doing this crap with a list?
		}

		Debug.Log("[GameScene] Checkpoints count: " + mapData.mapData.checkpoints.Count);
		Debug.Log("[GameScene] Events count: " + mapData.mapData.events.Count);
		
		MapEvent mapEvent = mapData.mapData.events.Find((MapEvent x) => x.data[0] == "MapEnd");
		this.calculatedmaptime = mapEvent == null ? mapData.mapData.musicTime : mapEvent.time;

		this.usingCheckpoints = (this.gameMode != GameScene.GameMode.Hardcore && this.gameMode != GameScene.GameMode.Endless);

		this.pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();

		try
		{
			gameEventInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false, null);

			gameEventInfo.gamemode = (int)this.gameMode;

			RanksSystem.Map map = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map x) => "workshop." + x.id == this.mapID);
			
			bool mapExists = map != null;
			gameEventInfo.isofficial = mapExists && map.isOfficial;
			gameEventInfo.isloved = mapExists && map.isLoved;
			gameEventInfo.isfunny = mapExists && map.isFunny;

			gameEventInfo.mapdifficulty = mapExists ? map.difficulty : -1f;
			gameEventInfo.handsCount = mapData.mapData.handCount;

			gameEventInfo.mapid = this.mapID;
			gameEventInfo.maptags = string.Join(",", mapData.mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + mapData.mapperSteamID;
		}
		catch (Exception) { }

		this.pbase.gameEventInfoBase = gameEventInfo;
		this.pbase.InitSystem();
	}

	private void OxyPls()
	{
		if (!this.doneWithOxy)
		{
			this.gameOverCanvas.SetActive(true);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(false);
			this.ingameUICanvas.SetActive(false);

			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
				this.restartCheckpointPanel.SetActive(true);
			else
				this.restartNoCheckpointPanel.SetActive(true);
		}

		this.doneWithOxy = true;
	}

	// TODO: GIANT FUCKING METHOD FUCKING MAKE IT MULTIPLE FOR READABILITY
	private void SetUpGameOverShit()
	{
		// TODO: Init this into a member, not a local
		Text bestScoreText = this.ingameUICanvas.transform.FindDeepChild("BestScoreText").GetComponent<Text>();
		Image blueUIFill = this.ingameUICanvas.transform.FindDeepChild("Fill").GetComponent<Image>();

		if (this.AllPlayersFinished())
		{
			foreach (AudioSource audioSource in this.asampler.audioSources)
			{
				// If lost, audio pitch down
				if (!this.pbase.isPlayerWon)
					audioSource.pitch = Helpers.Damp(audioSource.pitch, 0f, 0.5f);

				// Lower audio volume
				audioSource.volume = Helpers.Damp(audioSource.volume, 0f, 0.5f);
			}

			// Fade out UI
			if (this.ingameUICanvas.active)
			{
				// TODO: Stop using lerp and damp lmfao
				Color visible = new Color(HPTextnAcc.color.r, HPTextnAcc.color.g, HPTextnAcc.color.b, Helpers.Damp(HPTextnAcc.color.a, 0f, 2.5f));
				this.HPTextnAcc.color = visible;
				this.scoreText.color = visible;
				this.comboTextGO.color = visible;
				bestScoreText.color = visible;
				blueUIFill.color = new Color(blueUIFill.color.r, blueUIFill.color.b, blueUIFill.color.g, visible.a);
			}

			this.asampler.isMuted = true;
		}

		if (Singleton<RanksSystem>.Instance.isRankChanged)
			Singleton<RanksSystem>.Instance.DisplayRanksChanges();

		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			Singleton<ItemsHandler>.Instance.ShowNewItems();

		if (Singleton<ChallengesManager>.Instance.HasProgress())
			Singleton<ChallengesManager>.Instance.RewardsReadyNotification();

		if (this.gameOverSetUp || !this.gameOverCanvas.active) return;
		
		// Hide Game UI (but not progress bar)
		HPTextnAcc.text = "";
		scoreText.text = "";
		comboTextGO.text = "";
		bestScoreText.text = "";
		blueUIFill.color = new Color(0.666f, 0.666f, 0.666f, 0f); // Spooky

		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);

		// In Vanilla, we fucking called "Find" up to 4 times for each object.... "if (Find()) { Find().changeMe }" fucking gross
		// Even this is unoptimal, shoulda been initialized into members without find...
		GameObject finalScoreText         = GameObject.Find("FinalScoreText");

		GameObject highScoreMaxPointsText = GameObject.Find("HightScoreMaxPointsText");
		GameObject maxPossiblePointsText  = GameObject.Find("PossibleMapPointsText");
		GameObject pointsText             = GameObject.Find("PointsScoreText");
		GameObject finalScoreSmallText    = GameObject.Find("FinalScoreSmallText");

		GameObject checkpointScoreText    = GameObject.Find("CheckpointsScoreText");
		GameObject endlessLoopsScoreText  = GameObject.Find("EndlessLoopsScoreText");

		GameObject lastHighScoreText      = GameObject.Find("LastHighScoreText");
		GameObject maxPossibleScoreText   = GameObject.Find("PossibleMapMaxScoreText");

		GameObject gameModeText           = GameObject.Find("GameModeText");

		GameObject totalHitsScoreText     = GameObject.Find("TotalHitsScoreText");
		GameObject perfectHitsScoreText   = GameObject.Find("PerfectHitsScoreText");
		GameObject correctHitsScoreText   = GameObject.Find("CorrectHitsScoreText");
		GameObject incorrectHitsScoreText = GameObject.Find("IncorrectHitsScoreText");

		GameObject comboScoreText         = GameObject.Find("ComboScoreText");
		GameObject penaltyScoreText       = GameObject.Find("PenaltyScoreText");
		GameObject accuracyScoreText      = GameObject.Find("AccuracyScoreText");
		GameObject checkpointsScoreText   = GameObject.Find("CheckpointsScoreText");

		GameObject exitButton             = GameObject.Find("ExitButton");
		GameObject resetButton            = GameObject.Find("ResetButton");

		int currentScore = this.pbase.GetCurrentScore();


		ulong workshopId = 0;
		// Ranked play? (Official on hardcore/normal)
		bool isRanked = (this.gameMode == GameScene.GameMode.Hardcore || this.gameMode == GameScene.GameMode.Normal)
		                && ulong.TryParse(mapData.workshopId, out workshopId) // Mod: Stop assuming workshopID is always parsable
		                && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map x) => x.id == workshopId && x.isOfficial);

		if (finalScoreText != null)	        finalScoreText.SetActive(!isRanked);

		if (highScoreMaxPointsText != null) highScoreMaxPointsText.SetActive(isRanked);
		if (maxPossiblePointsText != null)  maxPossiblePointsText.SetActive(isRanked);
		if (pointsText != null)             pointsText.SetActive(isRanked);
		if (finalScoreSmallText != null)    finalScoreSmallText.SetActive(isRanked);

		if (checkpointScoreText != null)    checkpointScoreText.SetActive(this.gameMode != GameScene.GameMode.Hardcore && this.gameMode != GameScene.GameMode.Endless);
		if (endlessLoopsScoreText != null)  endlessLoopsScoreText.SetActive(this.gameMode == GameScene.GameMode.Endless);

		if (lastHighScoreText != null)      lastHighScoreText.GetComponent<Text>().text = "" + this.pbase.lastBestScore;
		if (maxPossibleScoreText != null)   maxPossibleScoreText.GetComponent<Text>().text = "" + Helpers.GetMapMaxScore(this.pbase.fullMapData.mapData);

		string gameModeString =
			LocalizationService.Instance.GetLocalizatedText("#" + this.gameMode.ToString().ToLower() + "mode").ToUpper();
		if (gameModeText != null)           gameModeText.GetComponent<Text>().text = gameModeString;

		if (finalScoreText != null)         finalScoreText.GetComponent<Text>().text = "" + currentScore;

		if (totalHitsScoreText != null)     totalHitsScoreText.GetComponent<Text>().text = "" + (this.pbase.correctScore + this.pbase.incorrectScore);
		if (perfectHitsScoreText != null)   perfectHitsScoreText.GetComponent<Text>().text = "" + this.pbase.perfectHits;
		if (correctHitsScoreText != null)   correctHitsScoreText.GetComponent<Text>().text = "" + (this.pbase.correctScore - this.pbase.perfectHits);
		if (incorrectHitsScoreText != null) incorrectHitsScoreText.GetComponent<Text>().text = "" + this.pbase.incorrectScore;

		string accuracyScoreString =
			(Math.Floor((double)(this.pbase.accuracyScore * 10000f)) / 10000.0 * 100.0).ToString("0.00") + "%";
		if (comboScoreText != null)         comboScoreText.GetComponent<Text>().text = "" + Mathf.RoundToInt(this.pbase.comboScore);
		if (penaltyScoreText != null)       penaltyScoreText.GetComponent<Text>().text = "" + Mathf.CeilToInt(this.pbase.penaltyScore);
		if (accuracyScoreText != null)      accuracyScoreText.GetComponent<Text>().text = accuracyScoreString;

		if (checkpointsScoreText != null)   checkpointsScoreText.GetComponent<Text>().text = "" + this.pbase.checkpointsUsed;
		if (endlessLoopsScoreText != null)  endlessLoopsScoreText.GetComponent<Text>().text = "" + this.pbase.loopsCount;

		if (maxPossiblePointsText != null && isRanked)
			maxPossiblePointsText.GetComponent<Text>().text = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map x) => x.id == workshopId).difficulty.ToString("0.00");
		if (finalScoreSmallText != null)    finalScoreSmallText.GetComponent<Text>().text = "" + currentScore;
			
		if (highScoreMaxPointsText != null && isRanked)
		{
			float num = (float)this.pbase.lastBestScore / (float)Helpers.GetMapMaxScore(this.pbase.fullMapData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map x) => x.id == workshopId).difficulty;
			highScoreMaxPointsText.GetComponent<Text>().text = (Math.Floor((double)(num * 100f)) / 100.0).ToString("0.00");
		}
			
		if (pointsText != null && isRanked)
		{
			float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(this.pbase.fullMapData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map x) => x.id == workshopId).difficulty;
			num2 = ((num2 >= 0f) ? num2 : 0f);
			pointsText.GetComponent<Text>().text = (Math.Floor((double)(num2 * 100f)) / 100.0).ToString("0.00");
		}
			
		if (exitButton != null)
		{
			if (!PhotonNetwork.offlineMode)
			{
				exitButton.gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("leave").ToUpper() : LocalizationService.Instance.GetTextByKey("tolobby").ToUpper());
				base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(PhotonNetwork.inRoom);
				if (resetButton != null)
					resetButton.GetComponent<Button>().interactable = PhotonNetwork.inRoom && PhotonNetwork.isMasterClient;
			}
			else if (this.gameMode == GameScene.GameMode.PlayTest)
				exitButton.gameObject.GetComponentInChildren<Text>().text = "Return To Editor";

		}

		this.gameOverSetUp = true;
	}

	private void FirstFrameShit()
	{
		this.asampler.audioSources[0].time = this.currentMusicTime;
		this.asampler.audioSources[1].time = this.currentMusicTime;
		this.asampler.Play(0);
		this.asampler.Play(1);
		this.haveWeDoneFirstFrameShitYet = true;
	}

	private void HandleEndingShitIThink()
	{
		foreach (GameObject gameObject in this.pbase.playerController.objects)
			if (gameObject.transform.childCount > 0) return;
			
		this.pbase.isMapCompleted = true;

		if (this.gameMode != GameScene.GameMode.Endless)
		{
			ExitGames.Client.Photon.Hashtable finishedHashtable = new ExitGames.Client.Photon.Hashtable {{"finished", true}};
			PhotonNetwork.player.SetCustomProperties(finishedHashtable, null, false);
			this.pbase.currentState = PlayerBase.PlayerState.Finished;
			if (this.pbase.photonView.isMine)
			{
				ExitGames.Client.Photon.Hashtable winHashtable = new ExitGames.Client.Photon.Hashtable {{"win", true}};
				PhotonNetwork.player.SetCustomProperties(winHashtable, null, false);
			}

			this.ShowResult("CompletedLevel");
			return;
		}

		this.RestartEndless();
	}

	private void UpdateUI()
	{
		this.levelProgressBar.GetComponent<Slider>().value = this.currentMusicTime;

		PlayerBase spectatedPlayerBase = this.pbase;
		
		if (this.pbase.currentState == PlayerBase.PlayerState.Spectator && this.pbase.spectatedPlayerBase != null)
			spectatedPlayerBase = this.pbase.spectatedPlayerBase;
		
		// Mod: show hp and text at once
		if (this.showHP)
		{
			this.HPTextnAcc.text = string.Empty;
			if (this.gameMode != GameScene.GameMode.Hardcore)
				this.HPTextnAcc.text = LocalizationService.Instance.GetLocalizatedText("#lives").ToUpper() +
				                       ": " + spectatedPlayerBase.lives + " / " +
				                       spectatedPlayerBase.fullMapData.mapData.maxLives + "\n";

			this.HPTextnAcc.text += LocalizationService.Instance.GetLocalizatedText("#accuracy").ToUpper() +
			                        ": " + (Math.Floor((double)(spectatedPlayerBase.accuracyScore * 10000f)) / 10000.0 * 100.0).ToString("0.00") + "%";
		}

		this.scoreText.text = this.scoreStr + ": " + spectatedPlayerBase.GetCurrentScore();

		this.comboTextGO.text = this.combo + ": " + "x" + spectatedPlayerBase.currentCombo;
	}

	public Image hiddenImage;

	public ObscuredBool gameOver;

	public ObscuredBool isGameStarted;

	public AudioSampler asampler;

	[HideInInspector]
	public PlayerBase pbase;

	public GameObject levelCanvas;

	public GameObject levelCanvasImage;

	public GameObject gameOverCanvas;

	public GameObject messageCanvas;

	public GameObject spectatorCanvas;

	public GameObject messageAnimation;

	public GameObject resultText;

	public GameObject ingameUICanvas;

	public GameObject loadingCanvas;

	public UnityEvent OnGameOverEvent;

	[HideInInspector]
	public ObscuredString mapID;

	public bool usingCheckpoints;

	public GameScene.GameMode gameMode;

	public UnityEvent OnLoaded;

	public GameObject restartCheckpointPanel;

	public GameObject restartNoCheckpointPanel;

	public GameObject spectatePanel;

	public GameObject levelInfo;

	public GameObject levelInfoContent;

	public float calculatedmaptime;

	private ObscuredBool haveWeDoneFirstFrameShitYet;

	private List<string> messageTextQueue;

	private List<float> messageTimeQueue;

	private string scoreStr;

	private string livesAndOrAcc;

	private string highScore;

	private string combo;

	private GameObject levelProgressBar;

	private Text scoreText;

	private Text HPTextnAcc;

	[HideInInspector]
	public Text comboTextGO;

	private bool showHP;

	private ObscuredFloat currentMusicTime;

	private bool doneWithOxy;

	private bool gameOverSetUp;

	public enum GameMode
	{
		Relax,
		Normal,
		Hardcore,
		Random,
		Endless,
		Hidden,
		PlayTest // Mod
	}
}
