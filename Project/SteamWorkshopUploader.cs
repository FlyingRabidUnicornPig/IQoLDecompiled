// TODO: Deobf, Cleanup
// TODO: Namespace folders

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Project
{
	[DisallowMultipleComponent]
	public class SteamWorkshopUploader : MonoBehaviour
	{
		public void ClearPackList()
		{
			IEnumerator enumerator = this.packListRoot.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		private void OnEnable()
		{
			if (SteamManager.Initialized)
			{
				this.PEKJOGMJHJC = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.FindPlayerCount));
				this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.CreateItem));
				this.MAKNNJPMHMM = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.SubmitItem));
			}
		}

		private void SubmitItemUpdate(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(MEHNKGDFPEF, AMCGCGIGPCN.changenote);
			this.MAKNNJPMHMM.Set(hAPICall, null);
		}

		public void OnCurrentModPackChanges()
		{
			this.OnChanges(this.MOJAGCMNOKC);
			this.RefreshCurrentModPack();
		}

		public void SubmitDescription()
		{
			SteamUGC.SetItemDescription(this.FHKGDJDOKNB, this.modPackDescription.text);
		}

		private void Start()
		{
			this.versionText.text = "<b>Intralism Items Uploader</b> by Oxy949";
			if (SteamUtils.GetAppID() == AppId_t.Invalid)
			{
				UnityEngine.Debug.LogError("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", this);
			}
			this.RefreshPackList();
			this.RefreshCurrentModPack();
		}

		public void RefreshPreview()
		{
			if (this.MOJAGCMNOKC.previewfile != null && this.MOJAGCMNOKC.previewfile.Length != 0)
			{
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + this.MOJAGCMNOKC.previewfile;
				if (!File.Exists(text))
				{
					File.Copy(Application.streamingAssetsPath + "/512px-512px.png", text, false);
				}
				this.modPackPreview.texture = FILE.ReadTexture(text);
				return;
			}
			this.modPackPreview.texture = null;
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F1))
			{
				SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
				this.PEKJOGMJHJC.Set(numberOfCurrentPlayers, null);
				UnityEngine.Debug.Log("Called GetNumberOfCurrentPlayers()");
			}
			if (this.FHKGDJDOKNB != UGCUpdateHandle_t.Invalid)
			{
				this.UpdateProgressBar(this.FHKGDJDOKNB);
			}
			else
			{
				this.progressBar.value = 0f;
			}
		}

		public void EditModPack(string HEDGDOFMELF)
		{
			Process.Start(HEDGDOFMELF);
		}

		public void OnSelectedPreview(string HKMBPFKAPFG)
		{
			string text = "icon" + Path.GetExtension(HKMBPFKAPFG);
			string text2 = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + text;
			UnityEngine.Debug.Log("Copy from " + HKMBPFKAPFG + " to " + text2);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(HKMBPFKAPFG, text2);
			this.MOJAGCMNOKC.previewfile = text;
			this.OnCurrentModPackChanges();
		}

		private IEnumerator CreateAndPublishItem()
		{
			this.PrepareItemForPublish();
			this.PublishOrUpdateItem(this.MOJAGCMNOKC);
			yield break;
		}

		public void ExitToMenu()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.SaveCurrentModPack();
			}
			SceneManager.LoadScene("MenuScene");
		}

		public void OpenContentFolder()
		{
			Application.OpenURL(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
		}

		public void ValidateCurrentModPack()
		{
			this.ValidateModPack(this.MOJAGCMNOKC);
		}

		private void PrepareItemForPublish()
		{
			if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
			{
				SteamAPICall_t hAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeMicrotransaction);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				this.statusText.text = "Creating new item...";
			}
		}

		public void SubmitPreviewFile()
		{
			SteamUGC.UpdateItemPreviewFile(this.FHKGDJDOKNB, 0U, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + this.MOJAGCMNOKC.previewfile);
		}

		public void ViewHelp()
		{
			Singleton<GameManager>.Instance.OpenURL("https://bitbucket.org/khb-soft/intralismarcsviewer/", false);
		}

		private void SetSteamDeets(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamUGC.SetItemTitle(MEHNKGDFPEF, AMCGCGIGPCN.title);
			SteamUGC.SetItemDescription(MEHNKGDFPEF, AMCGCGIGPCN.description);
			SteamUGC.SetItemVisibility(MEHNKGDFPEF, (ERemoteStoragePublishedFileVisibility)AMCGCGIGPCN.visibility);
			SteamUGC.SetItemContent(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
			SteamUGC.SetItemPreview(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + AMCGCGIGPCN.previewfile);
			SteamUGC.SetItemMetadata(MEHNKGDFPEF, AMCGCGIGPCN.metadata);
			List<string> list = new List<string>();
			if (AMCGCGIGPCN.itemtype == 0)
			{
				list.Add("arcs");
			}
			if (AMCGCGIGPCN.itemtype == 1)
			{
				list.Add("menutheme");
			}
			if (AMCGCGIGPCN.itemtype == 2)
			{
				list.Add("MascotChallenge2019");
			}
			list.AddRange(this.modPackTags.text.Split(new char[]
			{
				','
			}));
			SteamUGC.SetItemTags(MEHNKGDFPEF, list);
		}

		private void UpdateProgressBar(UGCUpdateHandle_t MEHNKGDFPEF)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(MEHNKGDFPEF, out num, out num2);
			float value = num / num2;
			this.progressBar.value = value;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				if (this.FindFiles(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
				{
					this.statusText.text = "Item invalid. Make sure your mod contains at leats one file.";
				}
				else
				{
					this.statusText.text = "Item invalid. No idea why.";
				}
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				this.statusText.text = "Preparing configuration...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				this.statusText.text = "Preparing content...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				this.statusText.text = "Uploading content...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				this.statusText.text = "Uploading preview image...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				this.statusText.text = "Committing changes...";
				break;
			}
		}

		public void SelectModPack(string DDAOMDPAIEP)
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.SaveCurrentModPack();
			}
			SteamWorkshopUploader.WorkshopModPack workshopModPack = SteamWorkshopUploader.WorkshopModPack.Load(DDAOMDPAIEP);
			if (workshopModPack != null)
			{
				this.MOJAGCMNOKC = workshopModPack;
				this.MIKAJJJAOCP = DDAOMDPAIEP;
				this.RefreshCurrentModPack();
			}
		}

		private void CheckUploaderDirectory()
		{
			this.GBDJMFMBKCG = new DirectoryInfo(Helpers.GetDirectory("Uploader")).FullName;
			if (!Directory.Exists(this.GBDJMFMBKCG))
			{
				Directory.CreateDirectory(this.GBDJMFMBKCG);
			}
		}

		private void CreateItem(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "Error: I/O Failure! :(";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult != EResult.k_EResultInsufficientPrivilege)
			{
				if (eResult != EResult.k_EResultTimeout)
				{
					if (eResult == EResult.k_EResultNotLoggedOn)
					{
						this.statusText.text = "Error: You're not logged into Steam!";
					}
				}
				else
				{
					this.statusText.text = "Error: Timeout :S";
				}
			}
			else
			{
				this.statusText.text = "Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
			}
			if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
			}
			if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
			{
				this.statusText.text = "Item creation successful! Published Item ID: " + NPIKJHPJIEA.m_nPublishedFileId.ToString();
				UnityEngine.Debug.Log("Item created: Id: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.MOJAGCMNOKC.publishedfileid = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			}
		}

		private void FindPlayerCount(NumberOfCurrentPlayers_t IAFAANLMOAG, bool MIOCPAMDBCN)
		{
			if (IAFAANLMOAG.m_bSuccess != 1 || MIOCPAMDBCN)
			{
				UnityEngine.Debug.Log("There was an error retrieving the NumberOfCurrentPlayers.");
			}
			else
			{
				UnityEngine.Debug.Log("The number of players playing your game: " + IAFAANLMOAG.m_cPlayers);
			}
		}

		private void SubmitItem(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "Error: I/O Failure! :(";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult == EResult.k_EResultOK)
			{
				this.statusText.text = "SUCCESS! Item submitted! :D :D :D";
				SteamFriends.ActivateGameOverlayToWebPage("https://steamcommunity.com/sharedfiles/filedetails/?id=" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
			}
		}

		private void PublishOrUpdateItem(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			ulong value = ulong.Parse(AMCGCGIGPCN.publishedfileid);
			PublishedFileId_t nPublishedFileID = new PublishedFileId_t(value);
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), nPublishedFileID);
			AMCGCGIGPCN.changenote = this.modPackChangeNotes.text;
			this.FHKGDJDOKNB = ugcupdateHandle_t;
			this.SetSteamDeets(ugcupdateHandle_t, AMCGCGIGPCN);
			this.SubmitItemUpdate(ugcupdateHandle_t, AMCGCGIGPCN);
		}

		public void Shutdown()
		{
			SteamAPI.Shutdown();
		}

		private IEnumerable<string> FindFiles(string BNJFKKGOACF)
		{
			Queue<string> queue = new Queue<string>();
			queue.Enqueue(BNJFKKGOACF);
			while (queue.Count > 0)
			{
				BNJFKKGOACF = queue.Dequeue();
				try
				{
					foreach (string item in Directory.GetDirectories(BNJFKKGOACF))
					{
						queue.Enqueue(item);
					}
				}
				catch (Exception message)
				{
					UnityEngine.Debug.LogError(message);
				}
				string[] array = null;
				try
				{
					array = Directory.GetFiles(BNJFKKGOACF);
				}
				catch (Exception message2)
				{
					UnityEngine.Debug.LogError(message2);
				}
				if (array != null)
				{
					for (int j = 0; j < array.Length; j++)
					{
						yield return array[j];
					}
				}
			}
			yield break;
		}

		public void CreateModPack()
		{
			string text = this.modPackName.text;
			if (string.IsNullOrEmpty(text) || text.Contains("."))
			{
				this.statusText.text = string.Format("Bad modpack name: {0}", this.modPackName.text);
			}
			else
			{
				string text2 = Path.Combine(this.GBDJMFMBKCG, text + ".workshop.json");
				new SteamWorkshopUploader.WorkshopModPack
				{
					contentfolder = text
				}.Save(text2);
				string text3 = this.modPackName.text;
				string path = Path.Combine(this.GBDJMFMBKCG, text3);
				Directory.CreateDirectory(path);
				this.RefreshPackList();
				this.SelectModPack(text2);
			}
		}

		public void SubmitCurrentModPack()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnChanges(this.MOJAGCMNOKC);
				this.SaveCurrentModPack();
				if (this.ValidateModPack(this.MOJAGCMNOKC))
				{
					if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
					{
						base.StartCoroutine(this.CreateAndPublishItem());
					}
					else
					{
						this.PublishOrUpdateItem(this.MOJAGCMNOKC);
					}
				}
			}
		}

		public string[] GetPackFilenames()
		{
			return Directory.GetFiles(this.GBDJMFMBKCG, "*.workshop.json", SearchOption.TopDirectoryOnly);
		}

		public void SaveCurrentModPack()
		{
			if (this.MOJAGCMNOKC != null && !string.IsNullOrEmpty(this.MIKAJJJAOCP))
			{
				this.MOJAGCMNOKC.Save(this.MIKAJJJAOCP);
			}
		}

		private void Awake()
		{
			this.CheckUploaderDirectory();
		}

		public void OnChanges(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			AMCGCGIGPCN.title = this.modPackTitle.text;
			AMCGCGIGPCN.description = this.modPackDescription.text;
			AMCGCGIGPCN.tags = new List<string>(this.modPackTags.text.Split(new char[]
			{
				','
			}));
			AMCGCGIGPCN.itemtype = this.modPackItemType.value;
			AMCGCGIGPCN.visibility = this.modPackVisibility.value;
		}

		private void OnApplicationQuit()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.SaveCurrentModPack();
			}
			SteamAPI.Shutdown();
		}

		public void RefreshCurrentModPack()
		{
			if (this.MOJAGCMNOKC == null)
			{
				this.currentItemPanel.gameObject.SetActive(false);
				return;
			}
			this.currentItemPanel.gameObject.SetActive(true);
			string filename = this.MOJAGCMNOKC.filename;
			this.submitButtonText.text = string.Format("SUBMIT '{0}' FILES", Path.GetFileNameWithoutExtension(filename.Replace(".workshop", string.Empty)));
			this.modPackContents.text = JsonUtility.ToJson(this.MOJAGCMNOKC, true);
			this.RefreshPreview();
			this.modPackTitle.text = this.MOJAGCMNOKC.title;
			this.modPackPreviewFilename.text = this.MOJAGCMNOKC.previewfile;
			this.modPackContentFolder.text = this.MOJAGCMNOKC.contentfolder;
			this.modPackDescription.text = this.MOJAGCMNOKC.description;
			this.modPackTags.text = string.Join(",", this.MOJAGCMNOKC.tags.ToArray());
			this.modPackVisibility.value = this.MOJAGCMNOKC.visibility;
			this.modPackItemType.value = this.MOJAGCMNOKC.itemtype;
		}

		public void RefreshPackList()
		{
			this.ClearPackList();
			string[] packFilenames = this.GetPackFilenames();
			for (int i = 0; i < packFilenames.Length; i++)
			{
				string text = packFilenames[i];
				string fileName = Path.GetFileName(text);
				Button component = UnityEngine.Object.Instantiate<GameObject>(this.packListButtonPrefab, Vector3.zero, Quaternion.identity).GetComponent<Button>();
				component.transform.SetParent(this.packListRoot);
				component.GetComponentInChildren<Text>().text = fileName.Replace(".workshop.json", string.Empty);
				if (component != null)
				{
					component.onClick.AddListener(delegate()
					{
						this.SelectModPack(text);
					});
				}
			}
		}

		private void OnApplicationFocus()
		{
			this.RefreshPackList();
		}

		public bool ValidateModPack(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			bool result;
			try
			{
				this.statusText.text = "Validating mod pack...";
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + AMCGCGIGPCN.previewfile;
				if (AMCGCGIGPCN.previewfile == null || AMCGCGIGPCN.previewfile.Length == 0)
				{
					this.statusText.text = "ERROR: preview file name is empty in modName.workshop.json";
					result = false;
				}
				else if (!File.Exists(text))
				{
					this.statusText.text = "ERROR: Preview file name in modName.workshop.json doesn't match any file";
					result = false;
				}
				else
				{
					FileInfo fileInfo = new FileInfo(text);
					if (fileInfo.Length >= 1048576L)
					{
						this.statusText.text = "ERROR: Preview file must be <1MB!";
						result = false;
					}
					else if (!Directory.Exists(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)))
					{
						this.statusText.text = "ERROR: mod directory not found!";
						result = false;
					}
					else if (this.FindFiles(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
					{
						this.statusText.text = "ERROR: Make sure your mod contains at leats one file!";
						result = false;
					}
					else
					{
						this.statusText.text = "No problem found, so far";
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogException(ex);
				this.statusText.text = "EXCEPTION:" + ex.ToString();
				result = false;
			}
			return result;
		}

		public const int version = 6;

		public Text versionText;

		public Text statusText;

		public Slider progressBar;

		public RectTransform packListRoot;

		public GameObject packListButtonPrefab;

		[Header("ModPack Interface")]
		public RectTransform currentItemPanel;

		public Text submitButtonText;

		public Text modPackContents;

		public RawImage modPackPreview;

		public InputField modPackName;

		public InputField modPackTitle;

		public InputField modPackPreviewFilename;

		public InputField modPackContentFolder;

		public InputField modPackChangeNotes;

		public InputField modPackDescription;

		public InputField modPackTags;

		public Dropdown modPackItemType;

		public Dropdown modPackVisibility;

		private const string MLGHCBDKEFO = "NewCustomItem.workshop.json";

		private const string GKIMDKGACEO = "NewCustomItem";

		private const string KPEELNPGEIJ = "Uploader";

		private string GBDJMFMBKCG;

		private SteamWorkshopUploader.WorkshopModPack MOJAGCMNOKC;

		private string MIKAJJJAOCP;

		private UGCUpdateHandle_t FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;

		protected CallResult<CreateItemResult_t> CEJIPNKDJKJ;

		protected CallResult<SubmitItemUpdateResult_t> MAKNNJPMHMM;

		private CallResult<NumberOfCurrentPlayers_t> PEKJOGMJHJC;

		[Serializable]
		public class WorkshopModPack
		{
			public WorkshopModPack()
			{
				this.changenote = "Version 1.0";
				this.publishedfileid = string.Empty;
				this.contentfolder = string.Empty;
				this.previewfile = string.Empty;
				this.title = "My New Mod Pack";
				this.description = "Description goes here";
				this.metadata = string.Empty;
				this.tags = new List<string>();
			}

			public void Save(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, true);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			public static SteamWorkshopUploader.WorkshopModPack Load(string HAEBGHHMEBH)
			{
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(FILE.ReadText(HAEBGHHMEBH));
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			[NonSerialized]
			public string filename;

			[NonSerialized]
			public string changenote;

			public string publishedfileid;

			public string contentfolder;

			public string previewfile;

			public int visibility;

			public int itemtype;

			public string title;

			public string description;

			public string metadata;

			public List<string> tags;
		}
	}
}
