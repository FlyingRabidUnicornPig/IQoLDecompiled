/*
Map Icon and all the tidbits that come with it
*/

using System;
using System.Collections;
using System.IO;
using System.Linq;
using AudioVisualizer;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsListElementButton : MonoBehaviour
{
	private IEnumerator LoadMapIcon()
	{
		string fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));

		base.StartCoroutine(this.DisplayMapIcon((Sprite)ResourcesManager.GetLoadedResource(fullName)));

		yield break;
	}

	private IEnumerator DisplayMapIcon(Sprite icon)
	{
		// Set map icon
		// MOD fix: used to flash default icon before fading in proper icon, FadeOutMapIcon() was used on default image
		this.bgImage.sprite = icon;
		
		// Set transparency to 0
		this.bgImage.color = new Color(bgImage.color.r, bgImage.color.g, bgImage.color.b, 0f);
		
		// Fit image within bounds
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;

		// Fade in map image
		yield return base.StartCoroutine(this.FadeInMapIcon(this.bgImage, 1f, 0.1f));
		yield break;
	}

	private IEnumerator FadeOutMapIcon(Image icon, float finalAlpha, float fadeSpeed)
	{
		float alpha = icon.color.a;
		float speed = 0.3f / fadeSpeed;

		while (alpha > finalAlpha)
		{
			alpha -= Time.deltaTime * speed;
			icon.color = new Color(icon.color.r, icon.color.g, icon.color.b, alpha);
			yield return new WaitForFixedUpdate();
		}

		yield break;
	}

	private IEnumerator FadeInMapIcon(Image icon, float finalAlpha, float fadeSpeed)
	{
		float alpha = icon.color.a;
		float speed = 0.3f / fadeSpeed;

		while (alpha < finalAlpha)
		{
			alpha += Time.deltaTime * speed; // So oxy uses deltatime on fades but not gameplay elements :|
			icon.color = new Color(icon.color.r, icon.color.g, icon.color.b, alpha);
			yield return new WaitForFixedUpdate();
		}

		yield break;
	}

	public void LoaderPanelOnButton(int restartFromCheck)
	{
		if (restartFromCheck == 1)
			Singleton<SaveSystem>.Instance.SetInt("menu.resetlevelcheckpoint", 1, null);

		SceneManager.LoadScene("GameScene");
	}

	public void OnClick()
	{
		if (this.launchLevelMode < 0) return;
		
		if (this.fullLevelData.isUnlocked())
			Singleton<MapsListSelector>.Instance.Close(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData), false);
	}

	public void OnRateClick() { }

	public void OnMouseEnter()
	{
		// If preview on
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null) && this.fullLevelData.isUnlocked())
		{
			// if, audio clip null, create audio clip and start playing
			if (this.audioSource.clip == null)
				base.StartCoroutine(this.PreviewAudio());

			// if hovering again, unpause it
			if (!this.audioSource.isPlaying)
				this.audioSource.UnPause();

			this.isSelected = true;

			// Mute background music I assume
			GameObject audioSampler = GameObject.Find("AudioSampler");
			if (audioSampler != null)
				audioSampler.GetComponent<AudioSampler>().isMuted = true;
		}
	}

	public void OnItemRated(bool upVotesToTheLeft)
	{
		Helpers.ObtainAchievement(28);

		// Set the rating
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(this.fullLevelData.workshopId)] = upVotesToTheLeft ? 1 : -1;
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(this.fullLevelData.workshopId), upVotesToTheLeft);

		// Display rating on map
		this.InitRateButton();
		this.ChangeRateIcon();

		this.rateCanvas.SetActive(false);

		// Add to rated maps, in case it wasn't here already? shouldn't the first line through an error on first time rating? (it doesn't)
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(this.fullLevelData.workshopId)))
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(this.fullLevelData.workshopId), upVotesToTheLeft ? 1 : -1);
	}

	// BUG: Unreasonably laggy
	// TODO: Cache bullshit into a file for quick load previews
	private IEnumerator PreviewAudio()
	{
		FileInfo fileInfo = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.musicFile);
		// Don't send annoying pop ups if we're trying to play broken mp3 files
		if (!fileInfo.Extension.Equals(".mp3"))
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fileInfo.FullName, fileInfo.FullName, true, false, true));
			this.audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fileInfo.FullName);
			this.audioSource.loop = true;
			this.audioSource.Play();
		}

		yield break;
	}

	private IEnumerator FindMapperSteamName(ulong steamID)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)steamID, false));
		string name = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)steamID, false);

		Transform mapperNameText = base.transform.FindDeepChild("MapperNameText");
		if (mapperNameText != null)
			mapperNameText.GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + name;

		yield break;
	}

	public void Update()
	{
		// Fade in/out preview music
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null))
			this.audioSource.volume = Mathf.Lerp(this.audioSource.volume, (float)((!this.isSelected) ? 0 : 1), Time.deltaTime * 10f);
	}

	public void OnDeleteButton()
	{
		if (this.fullLevelData.source == FullMapData.MapSource.Editor)
			base.StartCoroutine(this.DeleteEditorMap());

		if (this.fullLevelData.source == FullMapData.MapSource.Workshop)
			base.StartCoroutine(this.DeleteWorkshopMap());
	}

	private IEnumerator DeleteEditorMap()
	{
		// Are you sure?
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		
		// Yes
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);

			// If in game, leave game
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}

		yield break;
	}

	private IEnumerator DeleteWorkshopMap()
	{
		// Are you sure?
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("unsubscribemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		
		// Yes
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.UnsubscribeLevel(this.fullLevelData.workshopId);
			UnityEngine.Object.Destroy(base.gameObject);

			// If in game, leave game
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}

		yield break;
	}

	public void ToggleInfo()
	{
		this.infoCanvas.SetActive(!this.infoCanvas.activeSelf);
		this.leaderboardsCanvas.SetActive(false);
		this.rateCanvas.SetActive(false);
	}

	public void LoadMapperNickname()
		=> base.StartCoroutine(this.FindMapperSteamName(this.fullLevelData.mapperSteamID));

	public void InitRateButton()
	{
		int rate = Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId));
		this.rateButton.SetActive(rate == 0);
		this.ratedUpButton.SetActive(rate == 1);
		this.ratedDownButton.SetActive(rate == -1);
	}

	private void ChangeRateIcon()
	{
		int rate = Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId));
		this.rateCanvas.transform.Find("VoteUpToggle").GetComponent<Toggle>().isOn = rate == 1;
		this.rateCanvas.transform.Find("VoteDownToggle").GetComponent<Toggle>().isOn = rate == -1;
	}

	// Show the big Thumbs Up and smaller Thumbs Down rating thing
	public void ToggleRate()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(false);
		this.leaderboardsCanvas.SetActive(false);

		this.ChangeRateIcon();
		this.InitRateButton();
	}

	public void ToggleLeaderboards()
		=> base.StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(1, this.fullLevelData.workshopId, null, null));

	// Open workshop page or more info
	public void GetMoreInfo(int workshopOrNot = 0)
	{
		string url = "";
		if (workshopOrNot == 0)
			url = this.fullLevelData.mapData.moreInfoURL;

		if (workshopOrNot == 1)
			url = "http://steamcommunity.com/sharedfiles/filedetails/?id=" + this.fullLevelData.workshopId;

		Singleton<GameManager>.Instance.OpenURL(url, true);
	}

	public void OnMouseExit()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null))
		{
			this.isSelected = false;

			try
			{
				this.audioSource.Pause();

				GameObject audioSampler = GameObject.Find("AudioSampler");
				if (audioSampler != null)
					audioSampler.GetComponent<AudioSampler>().isMuted = false;
			}
			catch (Exception) { }
		}
	}

	public void OnLoaderPanelCansel()
	{
		base.GetComponent<Button>().interactable = true;
		base.GetComponent<Button>().Select();
	}

	public void Start()
	{
		this.LoadMapperNickname();
		base.StartCoroutine(this.LoadMapIcon());
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(base.gameObject, true, null, true, 0.2f, true));
	}

	public void OnFavoriteClick(bool addToFavorite)
	{
		// I don't think this first if is needed but it's kinda confusing so fuck it, it stays for now
		if (Singleton<MapsSystem>.Instance.IsMapFavorite(ulong.Parse(this.fullLevelData.workshopId)) != addToFavorite)
		{
			if (addToFavorite)
				Singleton<MapsSystem>.Instance.AddToFavorite(this.fullLevelData);
			else
				Singleton<MapsSystem>.Instance.RemoveFromFavorite(this.fullLevelData);
		}
	}

	public Image bgImage;

	public GameObject listMessage;
	public GameObject highscoresElement;

	public int launchLevelMode;

	public FullMapData fullLevelData;

	public GameObject infoCanvas;
	public GameObject rateCanvas;
	public GameObject leaderboardsCanvas;
	public GameObject lockedCanvas;
	public GameObject highscoresScrollRectContent;
	public GameObject loaderPanel;

	public GameObject rateButton;
	public GameObject ratedUpButton;
	public GameObject ratedDownButton;
	
	public GameObject favButton;
	public GameObject delButton;
	public GameObject moreInfoButton;

	public GameObject workshopButton;

	public AudioSource audioSource;

	public bool isSelected;
}
