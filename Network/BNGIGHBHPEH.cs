/*
Importance of this class: Potentially Very Important.

Purpose of this class: Seems to be related to online (Intralism/Multiplayer). Signs point to this being a pre-made class.

Deobf status: Manageable. Junk methods but there's a lot of named methods that seem legit. A decent bit of obfuscated variables, may be hard to modify this class?
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000301 RID: 769
internal class BNGIGHBHPEH : OHGAIJCPAJB, IPhotonPeerListener
{
	// Token: 0x0600B1C0 RID: 45504 RVA: 0x00416740 File Offset: 0x00414940
	private bool OELIGNFABAJ()
	{
		AuthenticationValues authenticationValues;
		if ((authenticationValues = this.AuthValues) == null)
		{
			authenticationValues = new AuthenticationValues
			{
				UserId = this.PlayerName
			};
		}
		AuthenticationValues gpdfhodmoij = authenticationValues;
		if (this.AuthMode == AuthModeOption.Auth)
		{
			return this.OpAuthenticate(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.OGLFGPKHEHH);
		}
		return this.OpAuthenticateOnce(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.EncryptionMode, PhotonNetwork.PhotonServerSettings.Protocol);
	}

	// Token: 0x0600B1C1 RID: 45505 RVA: 0x004167E0 File Offset: 0x004149E0
	public void NewSceneLoaded()
	{
		if (this.HMIEGLIHGEM)
		{
			this.HMIEGLIHGEM = false;
			PhotonNetwork.isMessageQueueRunning = true;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, PhotonView> keyValuePair in this.HFCMPEKPBAM)
		{
			PhotonView value = keyValuePair.Value;
			if (value == null)
			{
				list.Add(keyValuePair.Key);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			int key = list[i];
			this.HFCMPEKPBAM.Remove(key);
		}
		if (list.Count > 0 && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log("New level loaded. Removed " + list.Count + " scene view IDs from last level.");
		}
	}

	// Token: 0x0600B1C2 RID: 45506 RVA: 0x004168E0 File Offset: 0x00414AE0
	public PhotonView LDCGKJEKICK(int NADLIACHBNO)
	{
		PhotonView photonView = null;
		this.HFCMPEKPBAM.TryGetValue(NADLIACHBNO, out photonView);
		if (photonView == null)
		{
			PhotonView[] array = UnityEngine.Object.FindObjectsOfType(typeof(PhotonView)) as PhotonView[];
			for (int i = 1; i < array.Length; i++)
			{
				PhotonView photonView2 = array[i];
				if (photonView2.viewID == NADLIACHBNO)
				{
					if (photonView2.GEKLBLEBECG)
					{
						Debug.LogWarning("CameraFilterPack/Blend2Camera_Screen" + photonView2);
					}
					return photonView2;
				}
			}
		}
		return photonView;
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x0600B1C3 RID: 45507 RVA: 0x0008B649 File Offset: 0x00089849
	protected internal string EOCFDCJNAGM
	{
		get
		{
			return string.Format("{0}_{1}", PhotonNetwork.gameVersion, "1.87");
		}
	}

	// Token: 0x0600B1C4 RID: 45508 RVA: 0x00416964 File Offset: 0x00414B64
	public void OpCleanRpcBuffer(PhotonView DFIHBOEOJPI)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = DFIHBOEOJPI.viewID;
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache
		};
		this.OpRaiseEvent(200, hashtable, true, bplhapbmggc);
	}

	// Token: 0x0600B1C5 RID: 45509 RVA: 0x004169AC File Offset: 0x00414BAC
	protected internal PhotonPlayer ICMGDHDNIJD(int MHLPNLMDILP)
	{
		if (this.mActors == null)
		{
			return null;
		}
		PhotonPlayer result = null;
		this.mActors.TryGetValue(MHLPNLMDILP, out result);
		return result;
	}

	// Token: 0x0600B1C6 RID: 45510 RVA: 0x004169D8 File Offset: 0x00414BD8
	public bool SetMasterClient(int BONHLGFPNHF)
	{
		ExitGames.Client.Photon.Hashtable mjjmnidhdec = new ExitGames.Client.Photon.Hashtable
		{
			{
				248,
				BONHLGFPNHF
			}
		};
		ExitGames.Client.Photon.Hashtable kcjikjdcoal = new ExitGames.Client.Photon.Hashtable
		{
			{
				248,
				this.mMasterClientId
			}
		};
		return base.HFECLDIOHNJ(mjjmnidhdec, kcjikjdcoal, false);
	}

	// Token: 0x0600B1C7 RID: 45511 RVA: 0x0008B65F File Offset: 0x0008985F
	public bool LCKOOPIJBBP()
	{
		return this.<DOMFKIAEEAE>k__BackingField;
	}

	// Token: 0x0600B1C8 RID: 45512 RVA: 0x00416A30 File Offset: 0x00414C30
	internal ExitGames.Client.Photon.Hashtable HLFMLHKOOFE(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, int[] BJJMPIBPLEN, object[] NOJGGCLPPAM, bool BLOGDPLEMFH)
	{
		int num = BJJMPIBPLEN[0];
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[1] = PPFBFGBJOHM;
		if (JOPCODOJBHD != Vector3.zero)
		{
			hashtable[1] = JOPCODOJBHD;
		}
		if (LOMLCCLOIKN != Quaternion.identity)
		{
			hashtable[1] = LOMLCCLOIKN;
		}
		if (PNFBEEBFMKC != 0)
		{
			hashtable[2] = PNFBEEBFMKC;
		}
		if (BJJMPIBPLEN.Length > 1)
		{
			hashtable[0] = BJJMPIBPLEN;
		}
		if (NOJGGCLPPAM != null)
		{
			hashtable[1] = NOJGGCLPPAM;
		}
		if (this.PKCNHOKCLJH > 0)
		{
			hashtable[3] = this.PKCNHOKCLJH;
		}
		hashtable[7] = PhotonNetwork.ServerTimestamp;
		hashtable[1] = num;
		this.ACEDLCAELNF((byte)-40, hashtable, false, new RaiseEventOptions
		{
			CachingOption = ((!BLOGDPLEMFH) ? EventCaching.DoNotCache : EventCaching.ReplaceCache)
		});
		return hashtable;
	}

	// Token: 0x0600B1C9 RID: 45513 RVA: 0x00416B58 File Offset: 0x00414D58
	public void RegisterPhotonView(PhotonView LCJKMJCFDGE)
	{
		if (!Application.isPlaying)
		{
			this.HFCMPEKPBAM = new Dictionary<int, PhotonView>();
			return;
		}
		if (LCJKMJCFDGE.viewID == 0)
		{
			Debug.Log("PhotonView register is ignored, because viewID is 0. No id assigned yet to: " + LCJKMJCFDGE);
			return;
		}
		PhotonView photonView = null;
		bool flag = this.HFCMPEKPBAM.TryGetValue(LCJKMJCFDGE.viewID, out photonView);
		if (flag)
		{
			if (!(LCJKMJCFDGE != photonView))
			{
				return;
			}
			Debug.LogError(string.Format("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", LCJKMJCFDGE.viewID, LCJKMJCFDGE, photonView));
			this.EFDAOHIDIIF(photonView.gameObject, true);
		}
		this.HFCMPEKPBAM.Add(LCJKMJCFDGE.viewID, LCJKMJCFDGE);
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Registered PhotonView: " + LCJKMJCFDGE.viewID);
		}
	}

	// Token: 0x0600B1CA RID: 45514 RVA: 0x0008B667 File Offset: 0x00089867
	protected internal void ONKFAPDCCLE(string DPNHODJHGJL)
	{
		this.<GGFFKAEDLBB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x0600B1CC RID: 45516 RVA: 0x0008B670 File Offset: 0x00089870
	// (set) Token: 0x0600B24F RID: 45647 RVA: 0x0008B996 File Offset: 0x00089B96
	public PhotonPlayer LocalPlayer { get; internal set; }

	// Token: 0x0600B1CD RID: 45517 RVA: 0x00416CA0 File Offset: 0x00414EA0
	private void ENIDDCEBCDG()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = -1;
		this.JCCNCJFOMNB((byte)-60, hashtable, false, null);
	}

	// Token: 0x0600B1CE RID: 45518 RVA: 0x00416CD4 File Offset: 0x00414ED4
	private void EBNDKPFKPIJ()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = -1;
		this.OpRaiseEvent(207, hashtable, true, null);
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x0600B1CF RID: 45519 RVA: 0x0008B678 File Offset: 0x00089878
	// (set) Token: 0x0600B1F4 RID: 45556 RVA: 0x0008B7C5 File Offset: 0x000899C5
	public Room CurrentRoom
	{
		get
		{
			if (this.NBCIDPIDCDP != null && this.NBCIDPIDCDP.IsLocalClientInside)
			{
				return this.NBCIDPIDCDP;
			}
			return null;
		}
		private set
		{
			this.NBCIDPIDCDP = value;
		}
	}

	// Token: 0x0600B1D0 RID: 45520 RVA: 0x00416D08 File Offset: 0x00414F08
	private void KIKHKNNMBMN()
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[244] = 0;
		dictionary[247] = 7;
		this.OpCustom(253, dictionary, true, 0);
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x0600B1D4 RID: 45524 RVA: 0x0008B6A6 File Offset: 0x000898A6
	// (set) Token: 0x0600B1D1 RID: 45521 RVA: 0x0008B69D File Offset: 0x0008989D
	public int PlayersOnMasterCount { get; internal set; }

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x0600B21C RID: 45596 RVA: 0x0008B91A File Offset: 0x00089B1A
	// (set) Token: 0x0600B1D2 RID: 45522 RVA: 0x00416D4C File Offset: 0x00414F4C
	public string PlayerName
	{
		get
		{
			return this.OBCEIJGMKGB;
		}
		set
		{
			if (string.IsNullOrEmpty(value) || value.Equals(this.OBCEIJGMKGB))
			{
				return;
			}
			if (this.LocalPlayer != null)
			{
				this.LocalPlayer.NickName = value;
			}
			this.OBCEIJGMKGB = value;
			if (this.CurrentRoom != null)
			{
				this.PACEKOIEHKK();
			}
		}
	}

	// Token: 0x0600B1D3 RID: 45523 RVA: 0x00416DA8 File Offset: 0x00414FA8
	private string IHAJBEOILOE()
	{
		ConnectionProtocol transportProtocol = base.TransportProtocol;
		int num = 0;
		BNGIGHBHPEH.AEGGDHEGGCL.TryGetValue(transportProtocol, out num);
		string arg = string.Empty;
		if (transportProtocol == ConnectionProtocol.WebSocket)
		{
			arg = "ws://";
		}
		else if (transportProtocol == ConnectionProtocol.WebSocketSecure)
		{
			arg = "wss://";
		}
		return string.Format("{0}{1}:{2}", arg, "ns.exitgames.com", num);
	}

	// Token: 0x0600B1D5 RID: 45525 RVA: 0x00416E0C File Offset: 0x0041500C
	public void ChangeLocalID(int LGHIPFAEONM)
	{
		if (this.LocalPlayer == null)
		{
			Debug.LogWarning(string.Format("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", this.LocalPlayer, this.mActors == null, LGHIPFAEONM));
		}
		if (this.mActors.ContainsKey(this.LocalPlayer.ID))
		{
			this.mActors.Remove(this.LocalPlayer.ID);
		}
		this.LocalPlayer.GOCPHBFMIEN(LGHIPFAEONM);
		this.mActors[this.LocalPlayer.ID] = this.LocalPlayer;
		this.LEMBPMNPHCK();
	}

	// Token: 0x0600B1D6 RID: 45526 RVA: 0x00416EB0 File Offset: 0x004150B0
	private bool AKIBKCFMMHO()
	{
		this.IDOAHFHJJJE = true;
		PhotonNetwork.SwitchToProtocol(PhotonNetwork.PhotonServerSettings.Protocol);
		this.KHKMFIFGPCH(this.PKNIJKPIKAF);
		bool flag = base.Connect(this.BLNBCGLIOHP, this.KAOMEDGGMEM, this.LLJDHHLHFME);
		if (flag)
		{
			ServerConnection pknijkpikaf = this.PKNIJKPIKAF;
			if (pknijkpikaf != ServerConnection.NameServer)
			{
				if (pknijkpikaf != ServerConnection.MasterServer)
				{
					if (pknijkpikaf == ServerConnection.GameServer)
					{
						this.State = ClientState.ConnectingToGameserver;
					}
				}
				else
				{
					this.State = ClientState.ConnectingToMasterserver;
				}
			}
			else
			{
				this.State = ClientState.ConnectingToNameServer;
			}
		}
		return flag;
	}

	// Token: 0x0600B1D7 RID: 45527 RVA: 0x0008B6AE File Offset: 0x000898AE
	private void HBBIHADLDLH(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		this.IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x0600B239 RID: 45625 RVA: 0x0008BA97 File Offset: 0x00089C97
	// (set) Token: 0x0600B1D8 RID: 45528 RVA: 0x0008B6BD File Offset: 0x000898BD
	public ClientState State { get; internal set; }

	// Token: 0x0600B1D9 RID: 45529 RVA: 0x00416F48 File Offset: 0x00415148
	private void ANCHCNAJLOJ(int JBHMEHIOGBE)
	{
		bool flag = this.mMasterClientId == JBHMEHIOGBE;
		bool flag2 = JBHMEHIOGBE > 0;
		if (flag2 && !flag)
		{
			return;
		}
		int num;
		if (this.mActors.Count <= 0)
		{
			num = this.LocalPlayer.ID;
		}
		else
		{
			num = 7;
			foreach (int num2 in this.mActors.Keys)
			{
				if (num2 < num && num2 != JBHMEHIOGBE)
				{
					num = num2;
				}
			}
		}
		this.mMasterClientId = num;
		if (flag2)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnJoinedLobby, new object[]
			{
				this.ICMGDHDNIJD(num)
			});
		}
	}

	// Token: 0x0600B1DA RID: 45530 RVA: 0x0008B6C6 File Offset: 0x000898C6
	public int ABDALANPDDH()
	{
		return this.<BBNAEKGKOKM>k__BackingField;
	}

	// Token: 0x0600B1DB RID: 45531 RVA: 0x0008B6CE File Offset: 0x000898CE
	public void SetApp(string PPNEJGFIAJP, string MHMPNKGMNMJ)
	{
		this.KAIBLIKEDHM = PPNEJGFIAJP.Trim();
		if (!string.IsNullOrEmpty(MHMPNKGMNMJ))
		{
			PhotonNetwork.gameVersion = MHMPNKGMNMJ.Trim();
		}
	}

	// Token: 0x0600B1DC RID: 45532 RVA: 0x0041701C File Offset: 0x0041521C
	internal GameObject JFOLGKKLFJP(ExitGames.Client.Photon.Hashtable NNNJPMDHPHH, PhotonPlayer OGKJFFANGMC, GameObject HHLFBCNFLAO)
	{
		string text = (string)NNNJPMDHPHH[0];
		int amciaillaib = (int)NNNJPMDHPHH[6];
		int num = (int)NNNJPMDHPHH[7];
		Vector3 vector;
		if (NNNJPMDHPHH.ContainsKey(1))
		{
			vector = (Vector3)NNNJPMDHPHH[1];
		}
		else
		{
			vector = Vector3.zero;
		}
		Quaternion quaternion = Quaternion.identity;
		if (NNNJPMDHPHH.ContainsKey(2))
		{
			quaternion = (Quaternion)NNNJPMDHPHH[2];
		}
		byte b = 0;
		if (NNNJPMDHPHH.ContainsKey(3))
		{
			b = (byte)NNNJPMDHPHH[3];
		}
		short prefix = 0;
		if (NNNJPMDHPHH.ContainsKey(8))
		{
			prefix = (short)NNNJPMDHPHH[8];
		}
		int[] array;
		if (NNNJPMDHPHH.ContainsKey(4))
		{
			array = (int[])NNNJPMDHPHH[4];
		}
		else
		{
			array = new int[]
			{
				num
			};
		}
		object[] array2;
		if (NNNJPMDHPHH.ContainsKey(5))
		{
			array2 = (object[])NNNJPMDHPHH[5];
		}
		else
		{
			array2 = null;
		}
		if (b != 0 && !this.CHIJNBAJIHE.Contains(b))
		{
			return null;
		}
		if (this.EGNHNBODKHP != null)
		{
			GameObject gameObject = this.EGNHNBODKHP.Instantiate(text, vector, quaternion);
			PhotonView[] photonViewsInChildren = gameObject.GetPhotonViewsInChildren();
			if (photonViewsInChildren.Length != array.Length)
			{
				throw new Exception("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
			}
			for (int i = 0; i < photonViewsInChildren.Length; i++)
			{
				photonViewsInChildren[i].GEKLBLEBECG = false;
				photonViewsInChildren[i].viewID = 0;
				photonViewsInChildren[i].prefix = (int)prefix;
				photonViewsInChildren[i].instantiationId = num;
				photonViewsInChildren[i].isRuntimeInstantiated = true;
				photonViewsInChildren[i].NJDPOGADFJN = array2;
				photonViewsInChildren[i].GEKLBLEBECG = true;
				photonViewsInChildren[i].viewID = array[i];
			}
			gameObject.SendMessage(BNGIGHBHPEH.BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, amciaillaib, null), SendMessageOptions.DontRequireReceiver);
			return gameObject;
		}
		else
		{
			if (HHLFBCNFLAO == null)
			{
				if (!BNGIGHBHPEH.UsePrefabCache || !BNGIGHBHPEH.PrefabCache.TryGetValue(text, out HHLFBCNFLAO))
				{
					HHLFBCNFLAO = (GameObject)Resources.Load(text, typeof(GameObject));
					if (BNGIGHBHPEH.UsePrefabCache)
					{
						BNGIGHBHPEH.PrefabCache.Add(text, HHLFBCNFLAO);
					}
				}
				if (HHLFBCNFLAO == null)
				{
					Debug.LogError("PhotonNetwork error: Could not Instantiate the prefab [" + text + "]. Please verify you have this gameobject in a Resources folder.");
					return null;
				}
			}
			PhotonView[] photonViewsInChildren2 = HHLFBCNFLAO.GetPhotonViewsInChildren();
			if (photonViewsInChildren2.Length != array.Length)
			{
				throw new Exception("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
			}
			for (int j = 0; j < array.Length; j++)
			{
				photonViewsInChildren2[j].viewID = array[j];
				photonViewsInChildren2[j].prefix = (int)prefix;
				photonViewsInChildren2[j].instantiationId = num;
				photonViewsInChildren2[j].isRuntimeInstantiated = true;
			}
			this.DGEJLOAMLHI(num, array2);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(HHLFBCNFLAO, vector, quaternion);
			for (int k = 0; k < array.Length; k++)
			{
				photonViewsInChildren2[k].viewID = 0;
				photonViewsInChildren2[k].prefix = -1;
				photonViewsInChildren2[k].prefixBackup = -1;
				photonViewsInChildren2[k].instantiationId = -1;
				photonViewsInChildren2[k].isRuntimeInstantiated = false;
			}
			this.GKNPNNKFFAL(num);
			gameObject2.SendMessage(BNGIGHBHPEH.BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, amciaillaib, null), SendMessageOptions.DontRequireReceiver);
			return gameObject2;
		}
	}

	// Token: 0x0600B1DD RID: 45533 RVA: 0x004173BC File Offset: 0x004155BC
	private static int OHKBLAANNDH(PhotonPlayer[] NEJPNIGJLGP, int AIMBEFMGEFM)
	{
		if (NEJPNIGJLGP == null || NEJPNIGJLGP.Length == 0)
		{
			return -1;
		}
		int num = 84;
		for (int i = 1; i < NEJPNIGJLGP.Length; i += 0)
		{
			PhotonPlayer photonPlayer = NEJPNIGJLGP[i];
			if (photonPlayer.FHEAKIMCKJC() != AIMBEFMGEFM)
			{
				if (photonPlayer.ID < num)
				{
					num = photonPlayer.FHEAKIMCKJC();
				}
			}
		}
		return num;
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x0600B1DE RID: 45534 RVA: 0x0008B65F File Offset: 0x0008985F
	// (set) Token: 0x0600B252 RID: 45650 RVA: 0x0008BB25 File Offset: 0x00089D25
	public bool IsUsingNameServer { get; protected internal set; }

	// Token: 0x0600B1DF RID: 45535 RVA: 0x0041741C File Offset: 0x0041561C
	public bool BGBLKGFPHBE()
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("In Map Editor");
			return false;
		}
		this.IsUsingNameServer = true;
		this.CloudRegion = CloudRegionCode.usw;
		if (this.State == (ClientState)(-18))
		{
			return true;
		}
		this.KHKMFIFGPCH(ServerConnection.GameServer);
		this.PKNIJKPIKAF = (ServerConnection)6;
		this.BLNBCGLIOHP = this.BDJGCHOLCJN();
		this.KAOMEDGGMEM = "menutheme.27thfloor";
		if (!base.Connect(this.BDJGCHOLCJN(), "_Value3", this.LLJDHHLHFME))
		{
			return true;
		}
		this.HNCIIMJABOJ((ClientState)101);
		return false;
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x0008B77D File Offset: 0x0008997D
	// (set) Token: 0x0600B1E0 RID: 45536 RVA: 0x0008B6F2 File Offset: 0x000898F2
	public int PlayersInRoomsCount { get; internal set; }

	// Token: 0x0600B1E1 RID: 45537 RVA: 0x004174A8 File Offset: 0x004156A8
	protected internal void OMEPCMPKIJK(bool IJJEEIMFOHD)
	{
		if (this.IDIKEJLLFFP.Count > 0)
		{
			Debug.LogWarning("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.");
		}
		if (IJJEEIMFOHD)
		{
			HashSet<GameObject> hashSet = new HashSet<GameObject>();
			foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
			{
				if (photonView.isRuntimeInstantiated)
				{
					hashSet.Add(photonView.gameObject);
				}
			}
			foreach (GameObject obfjphlbfol in hashSet)
			{
				this.EFDAOHIDIIF(obfjphlbfol, true);
			}
		}
		this.IDIKEJLLFFP.Clear();
		PhotonNetwork.FDMEIPEKMHC = 0;
		PhotonNetwork.JIOIILCHMJL = 0;
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x0600B1E2 RID: 45538 RVA: 0x0008B6FB File Offset: 0x000898FB
	// (set) Token: 0x0600B23D RID: 45629 RVA: 0x0008BA9F File Offset: 0x00089C9F
	public string MasterServerAddress { get; protected internal set; }

	// Token: 0x0600B1E3 RID: 45539 RVA: 0x004175A0 File Offset: 0x004157A0
	private void CDNPLJILLFC(int JBHMEHIOGBE)
	{
		bool flag = this.mMasterClientId == JBHMEHIOGBE;
		bool flag2 = JBHMEHIOGBE > 0;
		if (flag2 && !flag)
		{
			return;
		}
		int num;
		if (this.mActors.Count <= 1)
		{
			num = this.LocalPlayer.ID;
		}
		else
		{
			num = int.MaxValue;
			foreach (int num2 in this.mActors.Keys)
			{
				if (num2 < num && num2 != JBHMEHIOGBE)
				{
					num = num2;
				}
			}
		}
		this.mMasterClientId = num;
		if (flag2)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, new object[]
			{
				this.ICMGDHDNIJD(num)
			});
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x0600B1E4 RID: 45540 RVA: 0x0008B703 File Offset: 0x00089903
	// (set) Token: 0x0600B230 RID: 45616 RVA: 0x0008BA4E File Offset: 0x00089C4E
	public List<Region> AvailableRegions { get; protected internal set; }

	// Token: 0x0600B1E5 RID: 45541 RVA: 0x0008B6BD File Offset: 0x000898BD
	internal void HNCIIMJABOJ(ClientState DPNHODJHGJL)
	{
		this.<CKEGJBJJPEC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B1E6 RID: 45542 RVA: 0x00417674 File Offset: 0x00415874
	private static int BBEKGPLBBCA(PhotonPlayer[] NEJPNIGJLGP, int AIMBEFMGEFM)
	{
		if (NEJPNIGJLGP == null || NEJPNIGJLGP.Length == 0)
		{
			return -1;
		}
		int num = int.MaxValue;
		foreach (PhotonPlayer photonPlayer in NEJPNIGJLGP)
		{
			if (photonPlayer.ID != AIMBEFMGEFM)
			{
				if (photonPlayer.ID < num)
				{
					num = photonPlayer.ID;
				}
			}
		}
		return num;
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x0600B1E7 RID: 45543 RVA: 0x0008B70B File Offset: 0x0008990B
	public string NameServerAddress
	{
		get
		{
			return this.IHAJBEOILOE();
		}
	}

	// Token: 0x0600B1E8 RID: 45544 RVA: 0x004176D4 File Offset: 0x004158D4
	internal ExitGames.Client.Photon.Hashtable JBBJFFKDHNO(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, int[] BJJMPIBPLEN, object[] NOJGGCLPPAM, bool BLOGDPLEMFH)
	{
		int num = BJJMPIBPLEN[0];
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = PPFBFGBJOHM;
		if (JOPCODOJBHD != Vector3.zero)
		{
			hashtable[1] = JOPCODOJBHD;
		}
		if (LOMLCCLOIKN != Quaternion.identity)
		{
			hashtable[2] = LOMLCCLOIKN;
		}
		if (PNFBEEBFMKC != 0)
		{
			hashtable[3] = PNFBEEBFMKC;
		}
		if (BJJMPIBPLEN.Length > 1)
		{
			hashtable[4] = BJJMPIBPLEN;
		}
		if (NOJGGCLPPAM != null)
		{
			hashtable[5] = NOJGGCLPPAM;
		}
		if (this.PKCNHOKCLJH > 0)
		{
			hashtable[8] = this.PKCNHOKCLJH;
		}
		hashtable[6] = PhotonNetwork.ServerTimestamp;
		hashtable[7] = num;
		this.OpRaiseEvent(202, hashtable, true, new RaiseEventOptions
		{
			CachingOption = ((!BLOGDPLEMFH) ? EventCaching.AddToRoomCache : EventCaching.AddToRoomCacheGlobal)
		});
		return hashtable;
	}

	// Token: 0x0600B1E9 RID: 45545 RVA: 0x0008B713 File Offset: 0x00089913
	public bool ReconnectToMaster()
	{
		if (this.AuthValues == null)
		{
			Debug.LogWarning("ReconnectToMaster() with AuthValues == null is not correct!");
			this.AuthValues = new AuthenticationValues();
		}
		this.AuthValues.Token = this.JOKLGFENMKE;
		return this.Connect(this.MasterServerAddress, ServerConnection.MasterServer);
	}

	// Token: 0x0600B1EA RID: 45546 RVA: 0x004177FC File Offset: 0x004159FC
	private object[] MFKHMJBJDLE(object[] BJIEGLPODKG, object[] BGJHIKDFIMP)
	{
		if (BGJHIKDFIMP == null || BJIEGLPODKG == null || BJIEGLPODKG.Length != BGJHIKDFIMP.Length)
		{
			return BGJHIKDFIMP;
		}
		if (BGJHIKDFIMP.Length <= 3)
		{
			return null;
		}
		BJIEGLPODKG[1] = false;
		int num = 0;
		Queue<int> queue = null;
		for (int i = 3; i < BGJHIKDFIMP.Length; i++)
		{
			object obj = BGJHIKDFIMP[i];
			object golmelkeafo = BJIEGLPODKG[i];
			if (this.LFAPOBNFPPO(obj, golmelkeafo))
			{
				num++;
				BJIEGLPODKG[i] = null;
			}
			else
			{
				BJIEGLPODKG[i] = obj;
				if (obj == null)
				{
					if (queue == null)
					{
						queue = new Queue<int>(BGJHIKDFIMP.Length);
					}
					queue.Enqueue(i);
				}
			}
		}
		if (num > 0)
		{
			if (num == BGJHIKDFIMP.Length - 3)
			{
				return null;
			}
			BJIEGLPODKG[1] = true;
			if (queue != null)
			{
				BJIEGLPODKG[2] = queue.ToArray();
			}
		}
		BJIEGLPODKG[0] = BGJHIKDFIMP[0];
		return BJIEGLPODKG;
	}

	// Token: 0x0600B1EB RID: 45547 RVA: 0x004178CC File Offset: 0x00415ACC
	protected internal void AHIEJFMHFPG(bool IJJEEIMFOHD)
	{
		if (this.IDIKEJLLFFP.Count > 0)
		{
			Debug.LogWarning("_Saturation");
		}
		if (IJJEEIMFOHD)
		{
			HashSet<GameObject> hashSet = new HashSet<GameObject>();
			foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
			{
				if (photonView.isRuntimeInstantiated)
				{
					hashSet.Add(photonView.gameObject);
				}
			}
			foreach (GameObject obfjphlbfol in hashSet)
			{
				this.EFDAOHIDIIF(obfjphlbfol, true);
			}
		}
		this.IDIKEJLLFFP.Clear();
		PhotonNetwork.FDMEIPEKMHC = 1;
		PhotonNetwork.JIOIILCHMJL = 0;
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x0600B1EC RID: 45548 RVA: 0x0008B753 File Offset: 0x00089953
	protected internal int LALFOLKNJJD
	{
		get
		{
			return (!this.POHIMACBDGL && this.DJIOCIPPBMK != 0) ? (Environment.TickCount - this.DJIOCIPPBMK) : 0;
		}
	}

	// Token: 0x0600B1ED RID: 45549 RVA: 0x004179C4 File Offset: 0x00415BC4
	public void RunViewUpdate()
	{
		if (!PhotonNetwork.connected || PhotonNetwork.offlineMode || this.mActors == null)
		{
			return;
		}
		if (this.mActors.Count <= 1)
		{
			return;
		}
		int num = 0;
		this.PCFOAMAODBD.Reset();
		List<int> list = null;
		foreach (KeyValuePair<int, PhotonView> keyValuePair in this.HFCMPEKPBAM)
		{
			PhotonView value = keyValuePair.Value;
			if (value == null)
			{
				string format = "PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com";
				Dictionary<int, PhotonView>.Enumerator enumerator;
				KeyValuePair<int, PhotonView> keyValuePair2 = enumerator.Current;
				Debug.LogError(string.Format(format, keyValuePair2.Key));
				if (list == null)
				{
					list = new List<int>(4);
				}
				List<int> list2 = list;
				KeyValuePair<int, PhotonView> keyValuePair3 = enumerator.Current;
				list2.Add(keyValuePair3.Key);
			}
			else if (value.synchronization != ViewSynchronization.Off && value.isMine && value.gameObject.activeInHierarchy)
			{
				if (!this.FFBGBLFBHOK.Contains(value.group))
				{
					object[] array = this.OAMPHAGPLEL(value);
					if (array != null)
					{
						if (value.synchronization == ViewSynchronization.ReliableDeltaCompressed || value.PBIDCPBMFKJ)
						{
							ExitGames.Client.Photon.Hashtable hashtable = null;
							if (!this.ECMNAOLPNBO.TryGetValue((int)value.group, out hashtable))
							{
								hashtable = new ExitGames.Client.Photon.Hashtable(BNGIGHBHPEH.ObjectsInOneUpdate);
								this.ECMNAOLPNBO[(int)value.group] = hashtable;
							}
							hashtable.Add((byte)(hashtable.Count + 10), array);
							num++;
							if (hashtable.Count >= BNGIGHBHPEH.ObjectsInOneUpdate)
							{
								num -= hashtable.Count;
								this.PCFOAMAODBD.InterestGroup = value.group;
								hashtable[0] = PhotonNetwork.ServerTimestamp;
								if (this.PKCNHOKCLJH >= 0)
								{
									hashtable[1] = this.PKCNHOKCLJH;
								}
								this.OpRaiseEvent(206, hashtable, true, this.PCFOAMAODBD);
								hashtable.Clear();
							}
						}
						else
						{
							ExitGames.Client.Photon.Hashtable hashtable2 = null;
							if (!this.ABIMEMLJLPA.TryGetValue((int)value.group, out hashtable2))
							{
								hashtable2 = new ExitGames.Client.Photon.Hashtable(BNGIGHBHPEH.ObjectsInOneUpdate);
								this.ABIMEMLJLPA[(int)value.group] = hashtable2;
							}
							hashtable2.Add((byte)(hashtable2.Count + 10), array);
							num++;
							if (hashtable2.Count >= BNGIGHBHPEH.ObjectsInOneUpdate)
							{
								num -= hashtable2.Count;
								this.PCFOAMAODBD.InterestGroup = value.group;
								hashtable2[0] = PhotonNetwork.ServerTimestamp;
								if (this.PKCNHOKCLJH >= 0)
								{
									hashtable2[1] = this.PKCNHOKCLJH;
								}
								this.OpRaiseEvent(201, hashtable2, false, this.PCFOAMAODBD);
								hashtable2.Clear();
							}
						}
					}
				}
			}
		}
		if (list != null)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				this.HFCMPEKPBAM.Remove(list[i]);
				i++;
			}
		}
		if (num == 0)
		{
			return;
		}
		foreach (int num2 in this.ECMNAOLPNBO.Keys)
		{
			this.PCFOAMAODBD.InterestGroup = (byte)num2;
			ExitGames.Client.Photon.Hashtable hashtable3 = this.ECMNAOLPNBO[num2];
			if (hashtable3.Count != 0)
			{
				hashtable3[0] = PhotonNetwork.ServerTimestamp;
				if (this.PKCNHOKCLJH >= 0)
				{
					hashtable3[1] = this.PKCNHOKCLJH;
				}
				this.OpRaiseEvent(206, hashtable3, true, this.PCFOAMAODBD);
				hashtable3.Clear();
			}
		}
		foreach (int num3 in this.ABIMEMLJLPA.Keys)
		{
			this.PCFOAMAODBD.InterestGroup = (byte)num3;
			ExitGames.Client.Photon.Hashtable hashtable4 = this.ABIMEMLJLPA[num3];
			if (hashtable4.Count != 0)
			{
				hashtable4[0] = PhotonNetwork.ServerTimestamp;
				if (this.PKCNHOKCLJH >= 0)
				{
					hashtable4[1] = this.PKCNHOKCLJH;
				}
				this.OpRaiseEvent(201, hashtable4, false, this.PCFOAMAODBD);
				hashtable4.Clear();
			}
		}
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x0600B1EE RID: 45550 RVA: 0x0008B6C6 File Offset: 0x000898C6
	// (set) Token: 0x0600B25B RID: 45659 RVA: 0x0008B9C6 File Offset: 0x00089BC6
	public int RoomsCount { get; internal set; }

	// Token: 0x0600B1F0 RID: 45552 RVA: 0x00417EB0 File Offset: 0x004160B0
	private void LLMNFGHNIND(int DIODBOKJKHM, int EJOIHHAHDLD, bool FEINGCNNFGM)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[7] = DIODBOKJKHM;
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				EJOIHHAHDLD
			}
		};
		this.OpRaiseEvent(202, hashtable, true, raiseEventOptions);
		ExitGames.Client.Photon.Hashtable hashtable2 = new ExitGames.Client.Photon.Hashtable();
		hashtable2[0] = DIODBOKJKHM;
		raiseEventOptions = null;
		if (!FEINGCNNFGM)
		{
			raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.CachingOption = EventCaching.AddToRoomCacheGlobal;
			Debug.Log("Destroying GO as global. ID: " + DIODBOKJKHM);
		}
		this.OpRaiseEvent(204, hashtable2, true, raiseEventOptions);
	}

	// Token: 0x0600B1F1 RID: 45553 RVA: 0x00417F54 File Offset: 0x00416154
	private void LEMBPMNPHCK()
	{
		this.mPlayerListCopy = new PhotonPlayer[this.mActors.Count];
		this.mActors.Values.CopyTo(this.mPlayerListCopy, 0);
		List<PhotonPlayer> list = new List<PhotonPlayer>();
		for (int i = 0; i < this.mPlayerListCopy.Length; i++)
		{
			PhotonPlayer photonPlayer = this.mPlayerListCopy[i];
			if (!photonPlayer.IsLocal)
			{
				list.Add(photonPlayer);
			}
		}
		this.mOtherPlayerListCopy = list.ToArray();
	}

	// Token: 0x0600B1F2 RID: 45554 RVA: 0x00417FD4 File Offset: 0x004161D4
	public void SetInterestGroups(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			if (JKOIGFLNNCN.Length == 0)
			{
				this.CHIJNBAJIHE.Clear();
			}
			else
			{
				foreach (byte b in JKOIGFLNNCN)
				{
					if (b <= 0)
					{
						Debug.LogError("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: " + b + ". The group number should be at least 1.");
					}
					else if (this.CHIJNBAJIHE.Contains(b))
					{
						this.CHIJNBAJIHE.Remove(b);
					}
				}
			}
		}
		if (OBKFHNACHIA != null)
		{
			if (OBKFHNACHIA.Length == 0)
			{
				for (byte b2 = 0; b2 < 255; b2 += 1)
				{
					this.CHIJNBAJIHE.Add(b2);
				}
				this.CHIJNBAJIHE.Add(byte.MaxValue);
			}
			else
			{
				foreach (byte b3 in OBKFHNACHIA)
				{
					if (b3 <= 0)
					{
						Debug.LogError("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: " + b3 + ". The group number should be at least 1.");
					}
					else
					{
						this.CHIJNBAJIHE.Add(b3);
					}
				}
			}
		}
		this.OpChangeGroups(JKOIGFLNNCN, OBKFHNACHIA);
	}

	// Token: 0x0600B1F3 RID: 45555 RVA: 0x0008B785 File Offset: 0x00089985
	private void EGJBHECFAOH(int IJAEJMNLBLK, PhotonPlayer JHOEDACNNKK)
	{
		if (!this.mActors.ContainsKey(IJAEJMNLBLK))
		{
			this.mActors[IJAEJMNLBLK] = JHOEDACNNKK;
			this.LEMBPMNPHCK();
		}
		else
		{
			Debug.LogError("Adding player twice: " + IJAEJMNLBLK);
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x0600B1F5 RID: 45557 RVA: 0x0008B7CE File Offset: 0x000899CE
	private string LLJDHHLHFME
	{
		get
		{
			if (this.AuthMode == AuthModeOption.Auth)
			{
				return null;
			}
			return (this.AuthValues == null) ? null : this.AuthValues.Token;
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x0600B259 RID: 45657 RVA: 0x0008BB37 File Offset: 0x00089D37
	// (set) Token: 0x0600B1F6 RID: 45558 RVA: 0x0008B7F9 File Offset: 0x000899F9
	public AuthenticationValues AuthValues { get; set; }

	// Token: 0x0600B1F7 RID: 45559 RVA: 0x004180FC File Offset: 0x004162FC
	protected internal bool LGPBHHOJPCA(int PHIGECOLKKN, bool PANGJAJJOLO)
	{
		bool flag = this.mMasterClientId != PHIGECOLKKN;
		if (!flag || !this.mActors.ContainsKey(PHIGECOLKKN))
		{
			return false;
		}
		if (PANGJAJJOLO && !this.OpRaiseEvent(208, new ExitGames.Client.Photon.Hashtable
		{
			{
				1,
				PHIGECOLKKN
			}
		}, true, null))
		{
			return false;
		}
		this.hasSwitchedMC = true;
		this.CurrentRoom.EJLAPIIGIMI = PHIGECOLKKN;
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, new object[]
		{
			this.ICMGDHDNIJD(PHIGECOLKKN)
		});
		return true;
	}

	// Token: 0x0600B1F8 RID: 45560 RVA: 0x0008B802 File Offset: 0x00089A02
	public void DestroyAll(bool NOKCKEBHIFJ)
	{
		if (!NOKCKEBHIFJ)
		{
			this.OpRemoveCompleteCache();
			this.EBNDKPFKPIJ();
		}
		this.OMEPCMPKIJK(true);
	}

	// Token: 0x0600B1F9 RID: 45561 RVA: 0x00418190 File Offset: 0x00416390
	public void OnEvent(EventData ADNNKPOCCDJ)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Format("OnEvent: {0}", ADNNKPOCCDJ.ToString()));
		}
		int num = -1;
		PhotonPlayer photonPlayer = null;
		if (ADNNKPOCCDJ.Parameters.ContainsKey(254))
		{
			num = (int)ADNNKPOCCDJ[254];
			photonPlayer = this.ICMGDHDNIJD(num);
		}
		byte code = ADNNKPOCCDJ.Code;
		switch (code)
		{
		case 200:
			this.MBCHEFNAJFH(ADNNKPOCCDJ[245] as ExitGames.Client.Photon.Hashtable, photonPlayer.ID);
			break;
		case 201:
		case 206:
		{
			ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int bfelejplade = (int)hashtable[0];
			short dkcpajgkhni = -1;
			byte b = 10;
			int num2 = 1;
			if (hashtable.ContainsKey(1))
			{
				dkcpajgkhni = (short)hashtable[1];
				num2 = 2;
			}
			byte b2 = b;
			while ((int)(b2 - b) < hashtable.Count - num2)
			{
				this.CKEAHPJAGOO(hashtable[b2] as object[], photonPlayer, bfelejplade, dkcpajgkhni);
				b2 += 1;
			}
			break;
		}
		case 202:
			this.JFOLGKKLFJP((ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245], photonPlayer, null);
			break;
		case 203:
			if (photonPlayer == null || !photonPlayer.IsMasterClient)
			{
				Debug.LogError("Error: Someone else(" + photonPlayer + ") then the masterserver requests a disconnect!");
			}
			else
			{
				PhotonNetwork.LeaveRoom();
			}
			break;
		case 204:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int num3 = (int)hashtable2[0];
			PhotonView photonView = null;
			if (this.HFCMPEKPBAM.TryGetValue(num3, out photonView))
			{
				this.EFDAOHIDIIF(photonView.gameObject, true);
			}
			else if (this.DebugOut >= DebugLevel.ERROR)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"Ev Destroy Failed. Could not find PhotonView with instantiationId ",
					num3,
					". Sent by actorNr: ",
					num
				}));
			}
			break;
		}
		default:
			switch (code)
			{
			case 223:
				if (this.AuthValues == null)
				{
					this.AuthValues = new AuthenticationValues();
				}
				this.AuthValues.Token = (ADNNKPOCCDJ[221] as string);
				this.JOKLGFENMKE = this.AuthValues.Token;
				break;
			case 224:
			{
				string[] array = ADNNKPOCCDJ[213] as string[];
				byte[] array2 = ADNNKPOCCDJ[212] as byte[];
				int[] array3 = ADNNKPOCCDJ[229] as int[];
				int[] array4 = ADNNKPOCCDJ[228] as int[];
				this.HOBLKOKPJOE.Clear();
				for (int i = 0; i < array.Length; i++)
				{
					TypedLobbyInfo typedLobbyInfo = new TypedLobbyInfo();
					typedLobbyInfo.Name = array[i];
					typedLobbyInfo.Type = (LobbyType)array2[i];
					typedLobbyInfo.PlayerCount = array3[i];
					typedLobbyInfo.RoomCount = array4[i];
					this.HOBLKOKPJOE.Add(typedLobbyInfo);
				}
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLobbyStatisticsUpdate, new object[0]);
				break;
			}
			default:
				switch (code)
				{
				case 251:
					if (PhotonNetwork.OnEventCall != null)
					{
						object fkodminiaec = ADNNKPOCCDJ[218];
						PhotonNetwork.OnEventCall(ADNNKPOCCDJ.Code, fkodminiaec, num);
					}
					else
					{
						Debug.LogWarning("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.");
					}
					return;
				case 253:
				{
					int num4 = (int)ADNNKPOCCDJ[253];
					ExitGames.Client.Photon.Hashtable mjjmnidhdec = null;
					ExitGames.Client.Photon.Hashtable faolpblckfj = null;
					if (num4 == 0)
					{
						mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[251];
					}
					else
					{
						faolpblckfj = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[251];
					}
					this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, num4);
					return;
				}
				case 254:
					this.MJMAJHJLBPJ(num, ADNNKPOCCDJ);
					return;
				case 255:
				{
					bool flag = false;
					ExitGames.Client.Photon.Hashtable eaobcipoenn = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[249];
					if (photonPlayer == null)
					{
						bool nigbapgikdf = this.LocalPlayer.ID == num;
						this.EGJBHECFAOH(num, new PhotonPlayer(nigbapgikdf, num, eaobcipoenn));
						this.PAOJLLAACDE();
					}
					else
					{
						flag = photonPlayer.IsInactive;
						photonPlayer.NPOPPIMCDMN(eaobcipoenn);
						photonPlayer.IsInactive = false;
					}
					if (num == this.LocalPlayer.ID)
					{
						int[] homaecigjej = (int[])ADNNKPOCCDJ[252];
						this.ANEENOJMDOJ(homaecigjej);
						if (this.ELNKFMHCMBO == JoinType.JoinOrCreateRoom && this.LocalPlayer.ID == 1)
						{
							BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom, new object[0]);
						}
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom, new object[0]);
					}
					else
					{
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerConnected, new object[]
						{
							this.mActors[num]
						});
						if (flag)
						{
							BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerActivityChanged, new object[]
							{
								this.mActors[num]
							});
						}
					}
					return;
				}
				}
				if (ADNNKPOCCDJ.Code < 200)
				{
					if (PhotonNetwork.OnEventCall != null)
					{
						object fkodminiaec2 = ADNNKPOCCDJ[245];
						PhotonNetwork.OnEventCall(ADNNKPOCCDJ.Code, fkodminiaec2, num);
					}
					else
					{
						Debug.LogWarning("Warning: Unhandled event " + ADNNKPOCCDJ + ". Set PhotonNetwork.OnEventCall.");
					}
				}
				break;
			case 226:
				this.PlayersInRoomsCount = (int)ADNNKPOCCDJ[229];
				this.PlayersOnMasterCount = (int)ADNNKPOCCDJ[227];
				this.RoomsCount = (int)ADNNKPOCCDJ[228];
				break;
			case 229:
			{
				ExitGames.Client.Photon.Hashtable hashtable3 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[222];
				foreach (object obj in hashtable3.Keys)
				{
					string text = (string)obj;
					RoomInfo roomInfo = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable3[obj]);
					if (roomInfo.removedFromList)
					{
						this.mGameList.Remove(text);
					}
					else
					{
						this.mGameList[text] = roomInfo;
					}
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate, new object[0]);
				break;
			}
			case 230:
			{
				this.mGameList = new Dictionary<string, RoomInfo>();
				ExitGames.Client.Photon.Hashtable hashtable4 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[222];
				foreach (object obj2 in hashtable4.Keys)
				{
					string text2 = (string)obj2;
					this.mGameList[text2] = new RoomInfo(text2, (ExitGames.Client.Photon.Hashtable)hashtable4[obj2]);
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate, new object[0]);
				break;
			}
			}
			break;
		case 207:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int num5 = (int)hashtable2[0];
			if (num5 >= 0)
			{
				this.DestroyPlayerObjects(num5, true);
			}
			else
			{
				if (this.DebugOut >= DebugLevel.INFO)
				{
					Debug.Log("Ev DestroyAll! By PlayerId: " + num);
				}
				this.DestroyAll(true);
			}
			break;
		}
		case 208:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int phigecolkkn = (int)hashtable2[1];
			this.LGPBHHOJPCA(phigecolkkn, false);
			break;
		}
		case 209:
		{
			int[] array5 = (int[])ADNNKPOCCDJ.Parameters[245];
			int num6 = array5[0];
			int num7 = array5[1];
			PhotonView photonView2 = PhotonView.Find(num6);
			if (photonView2 == null)
			{
				Debug.LogWarning("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: " + num6);
			}
			else
			{
				if (PhotonNetwork.logLevel == PhotonLogLevel.Informational)
				{
					Debug.Log(string.Concat(new object[]
					{
						"Ev OwnershipRequest ",
						photonView2.ownershipTransfer,
						". ActorNr: ",
						num,
						" takes from: ",
						num7,
						". local RequestedView.ownerId: ",
						photonView2.ownerId,
						" isOwnerActive: ",
						photonView2.isOwnerActive,
						". MasterClient: ",
						this.mMasterClientId,
						". This client's player: ",
						PhotonNetwork.player.ToStringFull()
					}));
				}
				switch (photonView2.ownershipTransfer)
				{
				case OwnershipOption.Fixed:
					Debug.LogWarning("Ownership mode == fixed. Ignoring request.");
					break;
				case OwnershipOption.Takeover:
					if (num7 == photonView2.ownerId || (num7 == 0 && photonView2.ownerId == this.mMasterClientId) || photonView2.ownerId == 0)
					{
						photonView2.OwnerShipWasTransfered = true;
						int ownerId = photonView2.ownerId;
						PhotonPlayer photonPlayer2 = this.ICMGDHDNIJD(ownerId);
						photonView2.ownerId = num;
						if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
						{
							Debug.LogWarning(photonView2 + " ownership transfered to: " + num);
						}
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnOwnershipTransfered, new object[]
						{
							photonView2,
							photonPlayer,
							photonPlayer2
						});
					}
					break;
				case OwnershipOption.Request:
					if ((num7 == PhotonNetwork.player.ID || PhotonNetwork.player.IsMasterClient) && (photonView2.ownerId == PhotonNetwork.player.ID || (PhotonNetwork.player.IsMasterClient && !photonView2.isOwnerActive)))
					{
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnOwnershipRequest, new object[]
						{
							photonView2,
							photonPlayer
						});
					}
					break;
				}
			}
			break;
		}
		case 210:
		{
			int[] array6 = (int[])ADNNKPOCCDJ.Parameters[245];
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(string.Concat(new object[]
				{
					"Ev OwnershipTransfer. ViewID ",
					array6[0],
					" to: ",
					array6[1],
					" Time: ",
					Environment.TickCount % 1000
				}));
			}
			int nadliachbno = array6[0];
			int num8 = array6[1];
			PhotonView photonView3 = PhotonView.Find(nadliachbno);
			if (photonView3 != null)
			{
				int ownerId2 = photonView3.ownerId;
				photonView3.OwnerShipWasTransfered = true;
				photonView3.ownerId = num8;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnOwnershipTransfered, new object[]
				{
					photonView3,
					PhotonPlayer.Find(num8),
					PhotonPlayer.Find(ownerId2)
				});
			}
			break;
		}
		}
	}

	// Token: 0x0600B1FA RID: 45562 RVA: 0x00418CF4 File Offset: 0x00416EF4
	private bool GDEBGIBOKCD()
	{
		AuthenticationValues authenticationValues;
		if ((authenticationValues = this.AuthValues) == null)
		{
			AuthenticationValues authenticationValues2 = new AuthenticationValues();
			authenticationValues2.PBCBCAGKCJG(this.PlayerName);
			authenticationValues = authenticationValues2;
		}
		AuthenticationValues gpdfhodmoij = authenticationValues;
		if (this.AuthMode == AuthModeOption.Auth)
		{
			return this.LBLCMEBOENM(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.OGLFGPKHEHH);
		}
		return this.OGKPIFFLGPN(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.EncryptionMode, PhotonNetwork.PhotonServerSettings.Protocol);
	}

	// Token: 0x0600B1FB RID: 45563 RVA: 0x0008B81D File Offset: 0x00089A1D
	public override void Disconnect()
	{
		if (base.PeerState == PeerStateValue.Disconnected)
		{
			if (!PhotonHandler.MBIFDLCKGKN)
			{
				Debug.LogWarning(string.Format("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", this.State));
			}
			return;
		}
		this.State = ClientState.Disconnecting;
		base.Disconnect();
	}

	// Token: 0x0600B1FC RID: 45564 RVA: 0x0008B85D File Offset: 0x00089A5D
	public override bool OpFindFriends(string[] MIMEHFLKIIG)
	{
		if (this.POHIMACBDGL)
		{
			return false;
		}
		this.BEIPFKHGHPC = MIMEHFLKIIG;
		this.POHIMACBDGL = true;
		return base.OpFindFriends(MIMEHFLKIIG);
	}

	// Token: 0x0600B1FD RID: 45565 RVA: 0x00418D94 File Offset: 0x00416F94
	public void RemoveRPCsInGroup(int PNFBEEBFMKC)
	{
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if ((int)photonView.group == PNFBEEBFMKC)
			{
				this.CleanRpcBufferIfMine(photonView);
			}
		}
	}

	// Token: 0x0600B1FE RID: 45566 RVA: 0x00418E04 File Offset: 0x00417004
	private void PAOJLLAACDE()
	{
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			photonView.EOENPICKCCO = null;
		}
	}

	// Token: 0x0600B1FF RID: 45567 RVA: 0x00418E68 File Offset: 0x00417068
	public void FAPFPBEBONM(PhotonView LCJKMJCFDGE)
	{
		if (!Application.isPlaying)
		{
			this.HFCMPEKPBAM = new Dictionary<int, PhotonView>();
			return;
		}
		if (LCJKMJCFDGE.viewID == 0)
		{
			Debug.Log("_Distortion" + LCJKMJCFDGE);
			return;
		}
		PhotonView photonView = null;
		bool flag = this.HFCMPEKPBAM.TryGetValue(LCJKMJCFDGE.PLMCHLCIABC(), out photonView);
		if (flag)
		{
			if (!(LCJKMJCFDGE != photonView))
			{
				return;
			}
			Debug.LogError(string.Format("  |  Events Count: ", LCJKMJCFDGE.viewID, LCJKMJCFDGE, photonView));
			this.EFDAOHIDIIF(photonView.gameObject, false);
		}
		this.HFCMPEKPBAM.Add(LCJKMJCFDGE.PLMCHLCIABC(), LCJKMJCFDGE);
		if (PhotonNetwork.logLevel >= (PhotonLogLevel)5)
		{
			Debug.Log("_Value4" + LCJKMJCFDGE.viewID);
		}
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x0600B200 RID: 45568 RVA: 0x0008B881 File Offset: 0x00089A81
	private bool OGLFGPKHEHH
	{
		get
		{
			return PhotonNetwork.EnableLobbyStatistics && this.EHALCLFLGJF == ServerConnection.MasterServer;
		}
	}

	// Token: 0x0600B201 RID: 45569 RVA: 0x00418F38 File Offset: 0x00417138
	public void OpRemoveCompleteCache()
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			Receivers = ReceiverGroup.MasterClient
		};
		this.OpRaiseEvent(0, null, true, bplhapbmggc);
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x0600B202 RID: 45570 RVA: 0x0008B899 File Offset: 0x00089A99
	// (set) Token: 0x0600B228 RID: 45608 RVA: 0x0008B8A1 File Offset: 0x00089AA1
	protected internal ServerConnection EHALCLFLGJF { get; private set; }

	// Token: 0x0600B203 RID: 45571 RVA: 0x00418F68 File Offset: 0x00417168
	protected internal void KHKMFIFGPCH(ServerConnection NKGHPPHEGCO)
	{
		ConnectionProtocol connectionProtocol = base.TransportProtocol;
		if (this.AuthMode == AuthModeOption.AuthOnceWss)
		{
			if (NKGHPPHEGCO != ServerConnection.NameServer)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): " + PhotonNetwork.PhotonServerSettings.Protocol);
				}
				connectionProtocol = PhotonNetwork.PhotonServerSettings.Protocol;
			}
			else
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).");
				}
				connectionProtocol = ConnectionProtocol.WebSocketSecure;
			}
		}
		Type type = Type.GetType("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", false);
		if (type == null)
		{
			type = Type.GetType("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", false);
		}
		if (type != null)
		{
			this.SocketImplementationConfig[ConnectionProtocol.WebSocket] = type;
			this.SocketImplementationConfig[ConnectionProtocol.WebSocketSecure] = type;
		}
		if (PhotonHandler.LEILCLLNGGH == null)
		{
			PhotonHandler.LEILCLLNGGH = typeof(PingMono);
		}
		if (base.TransportProtocol == connectionProtocol)
		{
			return;
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
		{
			Debug.LogWarning(string.Concat(new object[]
			{
				"Protocol switch from: ",
				base.TransportProtocol,
				" to: ",
				connectionProtocol,
				"."
			}));
		}
		base.TransportProtocol = connectionProtocol;
	}

	// Token: 0x0600B204 RID: 45572 RVA: 0x00419098 File Offset: 0x00417298
	public void SetSendingEnabled(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			foreach (byte item in JKOIGFLNNCN)
			{
				this.FFBGBLFBHOK.Add(item);
			}
		}
		if (OBKFHNACHIA != null)
		{
			foreach (byte item2 in OBKFHNACHIA)
			{
				this.FFBGBLFBHOK.Remove(item2);
			}
		}
	}

	// Token: 0x0600B205 RID: 45573 RVA: 0x0008B8A1 File Offset: 0x00089AA1
	private void KOBHAFEHLIE(ServerConnection DPNHODJHGJL)
	{
		this.<NFFGNBHFDFM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B206 RID: 45574 RVA: 0x004190FC File Offset: 0x004172FC
	private bool NGKMDAKKIOB(ParameterInfo[] LFONMECHEJD, Type[] HAKMJIHLGNI)
	{
		if (LFONMECHEJD.Length < HAKMJIHLGNI.Length)
		{
			return false;
		}
		for (int i = 1; i < HAKMJIHLGNI.Length; i++)
		{
			Type parameterType = LFONMECHEJD[i].ParameterType;
			if (HAKMJIHLGNI[i] != null && !parameterType.IsAssignableFrom(HAKMJIHLGNI[i]) && (!parameterType.IsEnum || !Enum.GetUnderlyingType(parameterType).IsAssignableFrom(HAKMJIHLGNI[i])))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600B207 RID: 45575 RVA: 0x0008B6AE File Offset: 0x000898AE
	private void DGEJLOAMLHI(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		this.IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	// Token: 0x0600B208 RID: 45576 RVA: 0x0041916C File Offset: 0x0041736C
	protected internal void EPGIIBMOHEG(int NADLIACHBNO, int MLBADICEKFF)
	{
		Debug.Log(string.Concat(new object[]
		{
			"RequestOwnership(): ",
			NADLIACHBNO,
			" from: ",
			MLBADICEKFF,
			" Time: ",
			Environment.TickCount % 1000
		}));
		this.OpRaiseEvent(209, new int[]
		{
			NADLIACHBNO,
			MLBADICEKFF
		}, true, new RaiseEventOptions
		{
			Receivers = ReceiverGroup.All
		});
	}

	// Token: 0x0600B209 RID: 45577 RVA: 0x004191F0 File Offset: 0x004173F0
	protected internal void DKACLKKBLBO(object EPDDBAPELGI)
	{
		if (!PhotonNetwork.automaticallySyncScene || !PhotonNetwork.isMasterClient || PhotonNetwork.room == null)
		{
			return;
		}
		if (EPDDBAPELGI == null)
		{
			Debug.LogError("Parameter levelId can't be null!");
			return;
		}
		if (PhotonNetwork.room.CustomProperties.ContainsKey("curScn"))
		{
			object obj = PhotonNetwork.room.CustomProperties["curScn"];
			if (obj is int && SceneManagerHelper.ActiveSceneBuildIndex == (int)obj)
			{
				return;
			}
			if (obj is string && SceneManagerHelper.ActiveSceneName != null && SceneManagerHelper.ActiveSceneName.Equals((string)obj))
			{
				return;
			}
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		if (EPDDBAPELGI is int)
		{
			hashtable["curScn"] = (int)EPDDBAPELGI;
		}
		else if (EPDDBAPELGI is string)
		{
			hashtable["curScn"] = (string)EPDDBAPELGI;
		}
		else
		{
			Debug.LogError("Parameter levelId must be int or string!");
		}
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		this.SendOutgoingCommands();
	}

	// Token: 0x0600B20A RID: 45578 RVA: 0x00419310 File Offset: 0x00417510
	public void DestroyPlayerObjects(int PHIGECOLKKN, bool NOKCKEBHIFJ)
	{
		if (PHIGECOLKKN <= 0)
		{
			Debug.LogError("Failed to Destroy objects of playerId: " + PHIGECOLKKN);
			return;
		}
		if (!NOKCKEBHIFJ)
		{
			this.NGAEPLGAGAL(PHIGECOLKKN);
			this.OpCleanRpcBuffer(PHIGECOLKKN);
			this.KCNBFALAJMD(PHIGECOLKKN);
		}
		HashSet<GameObject> hashSet = new HashSet<GameObject>();
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if (photonView != null && photonView.CreatorActorNr == PHIGECOLKKN)
			{
				hashSet.Add(photonView.gameObject);
			}
		}
		foreach (GameObject obfjphlbfol in hashSet)
		{
			this.EFDAOHIDIIF(obfjphlbfol, true);
		}
		foreach (PhotonView photonView2 in this.HFCMPEKPBAM.Values)
		{
			if (photonView2.ownerId == PHIGECOLKKN)
			{
				photonView2.ownerId = photonView2.CreatorActorNr;
			}
		}
	}

	// Token: 0x0600B20B RID: 45579 RVA: 0x0041947C File Offset: 0x0041767C
	public bool CODOJHINMEH(int BONHLGFPNHF)
	{
		ExitGames.Client.Photon.Hashtable mjjmnidhdec = new ExitGames.Client.Photon.Hashtable
		{
			{
				(byte)-178,
				BONHLGFPNHF
			}
		};
		ExitGames.Client.Photon.Hashtable kcjikjdcoal = new ExitGames.Client.Photon.Hashtable
		{
			{
				121,
				this.IMIPAHEMOCN()
			}
		};
		return base.ENLHKMFBDMG(mjjmnidhdec, kcjikjdcoal, true);
	}

	// Token: 0x0600B20C RID: 45580 RVA: 0x004194D4 File Offset: 0x004176D4
	public bool ReconnectAndRejoin()
	{
		if (this.AuthValues == null)
		{
			Debug.LogWarning("ReconnectAndRejoin() with AuthValues == null is not correct!");
			this.AuthValues = new AuthenticationValues();
		}
		this.AuthValues.Token = this.JOKLGFENMKE;
		if (!string.IsNullOrEmpty(this.GameServerAddress) && this.AJFMHFLGCFN != null)
		{
			this.ELNKFMHCMBO = JoinType.JoinRoom;
			this.AJFMHFLGCFN.RejoinOnly = true;
			return this.Connect(this.GameServerAddress, ServerConnection.GameServer);
		}
		return false;
	}

	// Token: 0x0600B20D RID: 45581 RVA: 0x00419550 File Offset: 0x00417750
	public bool Connect(string BPMNPBDOMFO, ServerConnection HMGBJCGOLMI)
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		if (this.State == ClientState.Disconnecting)
		{
			Debug.LogError("Connect() failed. Can't connect while disconnecting (still). Current state: " + PhotonNetwork.connectionStateDetailed);
			return false;
		}
		this.PKNIJKPIKAF = HMGBJCGOLMI;
		this.BLNBCGLIOHP = BPMNPBDOMFO;
		this.KAOMEDGGMEM = string.Empty;
		this.KHKMFIFGPCH(HMGBJCGOLMI);
		bool flag = base.Connect(BPMNPBDOMFO, string.Empty, this.LLJDHHLHFME);
		if (flag)
		{
			if (HMGBJCGOLMI != ServerConnection.NameServer)
			{
				if (HMGBJCGOLMI != ServerConnection.MasterServer)
				{
					if (HMGBJCGOLMI == ServerConnection.GameServer)
					{
						this.State = ClientState.ConnectingToGameserver;
					}
				}
				else
				{
					this.State = ClientState.ConnectingToMasterserver;
				}
			}
			else
			{
				this.State = ClientState.ConnectingToNameServer;
			}
		}
		return flag;
	}

	// Token: 0x0600B20E RID: 45582 RVA: 0x00419614 File Offset: 0x00417814
	public void DEECBOGGANC()
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.AddToRoomCache,
			Receivers = ReceiverGroup.All
		};
		this.JCCNCJFOMNB(1, null, true, bplhapbmggc);
	}

	// Token: 0x0600B20F RID: 45583 RVA: 0x00419644 File Offset: 0x00417844
	private void CKEAHPJAGOO(object[] NOJGGCLPPAM, PhotonPlayer NFOGDAHIPNP, int BFELEJPLADE, short DKCPAJGKHNI)
	{
		int num = (int)NOJGGCLPPAM[0];
		PhotonView photonView = this.GetPhotonView(num);
		if (photonView == null)
		{
			Debug.LogWarning(string.Concat(new object[]
			{
				"Received OnSerialization for view ID ",
				num,
				". We have no such PhotonView! Ignored this if you're leaving a room. State: ",
				this.State
			}));
			return;
		}
		if (photonView.prefix > 0 && (int)DKCPAJGKHNI != photonView.prefix)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Received OnSerialization for view ID ",
				num,
				" with prefix ",
				DKCPAJGKHNI,
				". Our prefix is ",
				photonView.prefix
			}));
			return;
		}
		if (photonView.group != 0 && !this.CHIJNBAJIHE.Contains(photonView.group))
		{
			return;
		}
		if (photonView.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] array = this.EFKMNFNHJBL(photonView.EMJBOOJPAII, NOJGGCLPPAM);
			if (array == null)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.Log(string.Concat(new object[]
					{
						"Skipping packet for ",
						photonView.name,
						" [",
						photonView.viewID,
						"] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game."
					}));
				}
				return;
			}
			photonView.EMJBOOJPAII = array;
			NOJGGCLPPAM = array;
		}
		if (NFOGDAHIPNP.ID != photonView.ownerId && (!photonView.OwnerShipWasTransfered || photonView.ownerId == 0) && photonView.currentMasterID == -1)
		{
			photonView.ownerId = NFOGDAHIPNP.ID;
		}
		this.CMABENLIOGI.SetReadStream(NOJGGCLPPAM, 3);
		PhotonMessageInfo dagalcailln = new PhotonMessageInfo(NFOGDAHIPNP, BFELEJPLADE, photonView);
		photonView.DeserializeView(this.CMABENLIOGI, dagalcailln);
	}

	// Token: 0x0600B210 RID: 45584 RVA: 0x00419804 File Offset: 0x00417A04
	private void EDMCCPDDDCC(ExitGames.Client.Photon.Hashtable MJJMNIDHDEC, ExitGames.Client.Photon.Hashtable FAOLPBLCKFJ, int AHNMANJKONI)
	{
		if (FAOLPBLCKFJ != null && FAOLPBLCKFJ.Count > 0)
		{
			if (AHNMANJKONI > 0)
			{
				PhotonPlayer photonPlayer = this.ICMGDHDNIJD(AHNMANJKONI);
				if (photonPlayer != null)
				{
					ExitGames.Client.Photon.Hashtable hashtable = this.LOCGDJDHCHJ(FAOLPBLCKFJ, AHNMANJKONI);
					photonPlayer.NPOPPIMCDMN(hashtable);
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, new object[]
					{
						photonPlayer,
						hashtable
					});
				}
			}
			else
			{
				foreach (object obj in FAOLPBLCKFJ.Keys)
				{
					int num = (int)obj;
					ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)FAOLPBLCKFJ[obj];
					string ebehbbdkdfj = (string)hashtable2[byte.MaxValue];
					PhotonPlayer photonPlayer2 = this.ICMGDHDNIJD(num);
					if (photonPlayer2 == null)
					{
						photonPlayer2 = new PhotonPlayer(false, num, ebehbbdkdfj);
						this.EGJBHECFAOH(num, photonPlayer2);
					}
					photonPlayer2.NPOPPIMCDMN(hashtable2);
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, new object[]
					{
						photonPlayer2,
						hashtable2
					});
				}
			}
		}
		if (this.CurrentRoom != null && MJJMNIDHDEC != null)
		{
			this.CurrentRoom.NPOPPIMCDMN(MJJMNIDHDEC);
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCustomRoomPropertiesChanged, new object[]
			{
				MJJMNIDHDEC
			});
			if (PhotonNetwork.automaticallySyncScene)
			{
				this.DMCKEABNFPJ();
			}
		}
	}

	// Token: 0x0600B211 RID: 45585 RVA: 0x0000420A File Offset: 0x0000240A
	public void OnMessage(object NBCIEBFNLGN)
	{
	}

	// Token: 0x0600B212 RID: 45586 RVA: 0x0008B8AA File Offset: 0x00089AAA
	public int IMIPAHEMOCN()
	{
		if (PhotonNetwork.offlineMode)
		{
			return this.LocalPlayer.FHEAKIMCKJC();
		}
		return (this.CurrentRoom != null) ? this.CurrentRoom.EJLAPIIGIMI : 1;
	}

	// Token: 0x0600B213 RID: 45587 RVA: 0x0041995C File Offset: 0x00417B5C
	public override bool OpJoinRoom(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		bool flag = this.EHALCLFLGJF == ServerConnection.GameServer;
		HBJBKOPJDKJ.OnGameServer = flag;
		if (!flag)
		{
			this.AJFMHFLGCFN = HBJBKOPJDKJ;
		}
		this.ELNKFMHCMBO = ((!HBJBKOPJDKJ.CreateIfNotExists) ? JoinType.JoinRoom : JoinType.JoinOrCreateRoom);
		return base.OpJoinRoom(HBJBKOPJDKJ);
	}

	// Token: 0x0600B214 RID: 45588 RVA: 0x004199A8 File Offset: 0x00417BA8
	private object[] EFKMNFNHJBL(object[] EMJBOOJPAII, object[] JGHJOJFOGCO)
	{
		if (!(bool)JGHJOJFOGCO[1])
		{
			return JGHJOJFOGCO;
		}
		if (EMJBOOJPAII == null)
		{
			return null;
		}
		int[] array = JGHJOJFOGCO[2] as int[];
		for (int i = 3; i < JGHJOJFOGCO.Length; i++)
		{
			if (array == null || !array.Contains(i))
			{
				if (JGHJOJFOGCO[i] == null)
				{
					object obj = EMJBOOJPAII[i];
					JGHJOJFOGCO[i] = obj;
				}
			}
		}
		return JGHJOJFOGCO;
	}

	// Token: 0x0600B215 RID: 45589 RVA: 0x00419A14 File Offset: 0x00417C14
	private void MJMAJHJLBPJ(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Concat(new object[]
			{
				"HandleEventLeave for player ID: ",
				IECJKEIJLCP,
				" evLeave: ",
				EKDHPAFJKFA.ToStringFull()
			}));
		}
		PhotonPlayer photonPlayer = this.ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("Received event Leave for unknown player ID: {0}", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(233))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[233];
			if (photonPlayer.IsInactive != isInactive)
			{
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerActivityChanged, new object[]
				{
					photonPlayer
				});
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"HandleEventLeave for player ID: ",
					IECJKEIJLCP,
					" isInactive: ",
					photonPlayer.IsInactive,
					". Stopping handling if inactive."
				}));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(203))
		{
			int num = (int)EKDHPAFJKFA[203];
			if (num != 0)
			{
				this.mMasterClientId = (int)EKDHPAFJKFA[203];
				this.ELDLAPJAPBJ();
			}
		}
		else if (!this.CurrentRoom.BDHOOLIDFJO)
		{
			this.CDNPLJILLFC(IECJKEIJLCP);
		}
		if (photonPlayer.IsInactive && !isInactive)
		{
			return;
		}
		if (this.CurrentRoom != null && this.CurrentRoom.AutoCleanUp)
		{
			this.DestroyPlayerObjects(IECJKEIJLCP, true);
		}
		this.GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerDisconnected, new object[]
		{
			photonPlayer
		});
	}

	// Token: 0x0600B216 RID: 45590 RVA: 0x00419BDC File Offset: 0x00417DDC
	private bool IHAJPLJACML(ParameterInfo[] LFONMECHEJD, Type[] HAKMJIHLGNI)
	{
		if (LFONMECHEJD.Length < HAKMJIHLGNI.Length)
		{
			return false;
		}
		for (int i = 0; i < HAKMJIHLGNI.Length; i++)
		{
			Type parameterType = LFONMECHEJD[i].ParameterType;
			if (HAKMJIHLGNI[i] != null && !parameterType.IsAssignableFrom(HAKMJIHLGNI[i]) && (!parameterType.IsEnum || !Enum.GetUnderlyingType(parameterType).IsAssignableFrom(HAKMJIHLGNI[i])))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x0600B217 RID: 45591 RVA: 0x0008B8DE File Offset: 0x00089ADE
	// (set) Token: 0x0600B249 RID: 45641 RVA: 0x0008BAEE File Offset: 0x00089CEE
	public int mMasterClientId
	{
		get
		{
			if (PhotonNetwork.offlineMode)
			{
				return this.LocalPlayer.ID;
			}
			return (this.CurrentRoom != null) ? this.CurrentRoom.EJLAPIIGIMI : 0;
		}
		private set
		{
			if (this.CurrentRoom != null)
			{
				this.CurrentRoom.EJLAPIIGIMI = value;
			}
		}
	}

	// Token: 0x0600B218 RID: 45592 RVA: 0x00419C4C File Offset: 0x00417E4C
	private void NDPIAMOMGME()
	{
		ServerConnection serverConnection = this.EHALCLFLGJF;
		if (serverConnection != ServerConnection.NameServer)
		{
			if (serverConnection != ServerConnection.MasterServer)
			{
				if (serverConnection == ServerConnection.GameServer)
				{
					this.State = ClientState.DisconnectingFromGameserver;
					base.Disconnect();
				}
			}
			else
			{
				this.State = ClientState.DisconnectingFromMasterserver;
				base.Disconnect();
			}
		}
		else
		{
			this.State = ClientState.DisconnectingFromNameServer;
			base.Disconnect();
		}
	}

	// Token: 0x0600B219 RID: 45593 RVA: 0x00419CB4 File Offset: 0x00417EB4
	private ExitGames.Client.Photon.Hashtable HHPBLGDNDOP()
	{
		if (PhotonNetwork.player != null)
		{
			return PhotonNetwork.player.AllProperties;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[byte.MaxValue] = this.PlayerName;
		return hashtable;
	}

	// Token: 0x0600B21A RID: 45594 RVA: 0x00419CF4 File Offset: 0x00417EF4
	private void BOJKDNJHBNG()
	{
		bool flag = this.CurrentRoom != null;
		bool flag2 = (this.CurrentRoom == null) ? PhotonNetwork.autoCleanUpPlayerObjects : this.CurrentRoom.AutoCleanUp;
		this.hasSwitchedMC = false;
		this.CurrentRoom = null;
		this.mActors = new Dictionary<int, PhotonPlayer>();
		this.mPlayerListCopy = new PhotonPlayer[0];
		this.mOtherPlayerListCopy = new PhotonPlayer[0];
		this.CHIJNBAJIHE = new HashSet<byte>();
		this.FFBGBLFBHOK = new HashSet<byte>();
		this.mGameList = new Dictionary<string, RoomInfo>();
		this.mGameListCopy = new RoomInfo[0];
		this.POHIMACBDGL = false;
		this.ChangeLocalID(-1);
		if (flag2)
		{
			this.OMEPCMPKIJK(true);
			PhotonNetwork.JMCPHFPJEJC = new List<int>();
		}
		if (flag)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom, new object[0]);
		}
	}

	// Token: 0x0600B21B RID: 45595 RVA: 0x0008B912 File Offset: 0x00089B12
	public TypedLobby BOBIFHPDAOK()
	{
		return this.<IGGEJKPFJJD>k__BackingField;
	}

	// Token: 0x0600B21D RID: 45597 RVA: 0x0008B922 File Offset: 0x00089B22
	private void GKNPNNKFFAL(int HOBFECDCMIL)
	{
		this.IDIKEJLLFFP.Remove(HOBFECDCMIL);
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x0600B21E RID: 45598 RVA: 0x0008B931 File Offset: 0x00089B31
	// (set) Token: 0x0600B25C RID: 45660 RVA: 0x0008B667 File Offset: 0x00089867
	public string GameServerAddress { get; protected internal set; }

	// Token: 0x0600B21F RID: 45599 RVA: 0x00419DC4 File Offset: 0x00417FC4
	public BNGIGHBHPEH(string OBCEIJGMKGB, ConnectionProtocol FDGOINDINNH) : base(FDGOINDINNH)
	{
		base.Listener = this;
		base.LimitOfUnreliableCommands = 40;
		this.lobby = TypedLobby.Default;
		this.PlayerName = OBCEIJGMKGB;
		this.LocalPlayer = new PhotonPlayer(true, -1, this.OBCEIJGMKGB);
		this.EGJBHECFAOH(this.LocalPlayer.ID, this.LocalPlayer);
		this.CPLBCMDIGNB = new Dictionary<string, int>(PhotonNetwork.PhotonServerSettings.RpcList.Count);
		for (int i = 0; i < PhotonNetwork.PhotonServerSettings.RpcList.Count; i++)
		{
			string key = PhotonNetwork.PhotonServerSettings.RpcList[i];
			this.CPLBCMDIGNB[key] = i;
		}
		this.State = ClientState.PeerCreated;
	}

	// Token: 0x0600B220 RID: 45600 RVA: 0x00419F44 File Offset: 0x00418144
	internal void HFFGNHGFKPE(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonTargets MPNMOONBMII, PhotonPlayer JHOEDACNNKK, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		if (this.FFBGBLFBHOK.Contains(DFIHBOEOJPI.group))
		{
			return;
		}
		if (DFIHBOEOJPI.viewID < 1)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Illegal view ID:",
				DFIHBOEOJPI.viewID,
				" method: ",
				LBLKDNNPACO,
				" GO:",
				DFIHBOEOJPI.gameObject.name
			}));
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log(string.Concat(new object[]
			{
				"Sending RPC \"",
				LBLKDNNPACO,
				"\" to target: ",
				MPNMOONBMII,
				" or player:",
				JHOEDACNNKK,
				"."
			}));
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = DFIHBOEOJPI.viewID;
		if (DFIHBOEOJPI.prefix > 0)
		{
			hashtable[1] = (short)DFIHBOEOJPI.prefix;
		}
		hashtable[2] = PhotonNetwork.ServerTimestamp;
		int num = 0;
		if (this.CPLBCMDIGNB.TryGetValue(LBLKDNNPACO, out num))
		{
			hashtable[5] = (byte)num;
		}
		else
		{
			hashtable[3] = LBLKDNNPACO;
		}
		if (GNNEKCBOBEG != null && GNNEKCBOBEG.Length > 0)
		{
			hashtable[4] = GNNEKCBOBEG;
		}
		if (JHOEDACNNKK != null)
		{
			if (this.LocalPlayer.ID == JHOEDACNNKK.ID)
			{
				this.MBCHEFNAJFH(hashtable, JHOEDACNNKK.ID);
			}
			else
			{
				RaiseEventOptions bplhapbmggc = new RaiseEventOptions
				{
					TargetActors = new int[]
					{
						JHOEDACNNKK.ID
					},
					Encrypt = AKFHJNFOCDP
				};
				this.OpRaiseEvent(200, hashtable, true, bplhapbmggc);
			}
			return;
		}
		if (MPNMOONBMII == PhotonTargets.All)
		{
			RaiseEventOptions bplhapbmggc2 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc2);
			this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
		}
		else if (MPNMOONBMII == PhotonTargets.Others)
		{
			RaiseEventOptions bplhapbmggc3 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc3);
		}
		else if (MPNMOONBMII == PhotonTargets.AllBuffered)
		{
			RaiseEventOptions bplhapbmggc4 = new RaiseEventOptions
			{
				CachingOption = EventCaching.AddToRoomCache,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc4);
			this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
		}
		else if (MPNMOONBMII == PhotonTargets.OthersBuffered)
		{
			RaiseEventOptions bplhapbmggc5 = new RaiseEventOptions
			{
				CachingOption = EventCaching.AddToRoomCache,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc5);
		}
		else if (MPNMOONBMII == PhotonTargets.MasterClient)
		{
			if (this.mMasterClientId == this.LocalPlayer.ID)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
			else
			{
				RaiseEventOptions bplhapbmggc6 = new RaiseEventOptions
				{
					Receivers = ReceiverGroup.MasterClient,
					Encrypt = AKFHJNFOCDP
				};
				this.OpRaiseEvent(200, hashtable, true, bplhapbmggc6);
			}
		}
		else if (MPNMOONBMII == PhotonTargets.AllViaServer)
		{
			RaiseEventOptions bplhapbmggc7 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Receivers = ReceiverGroup.All,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc7);
			if (PhotonNetwork.offlineMode)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
		}
		else if (MPNMOONBMII == PhotonTargets.AllBufferedViaServer)
		{
			RaiseEventOptions bplhapbmggc8 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Receivers = ReceiverGroup.All,
				CachingOption = EventCaching.AddToRoomCache,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc8);
			if (PhotonNetwork.offlineMode)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
		}
		else
		{
			Debug.LogError("Unsupported target enum: " + MPNMOONBMII);
		}
	}

	// Token: 0x0600B221 RID: 45601 RVA: 0x0008B939 File Offset: 0x00089B39
	public virtual bool GPJCOHMKODA(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		this.AJFMHFLGCFN = new AKBOPCNHFFJ();
		this.AJFMHFLGCFN.Lobby = IFIMMPPLLHI.TypedLobby;
		this.AJFMHFLGCFN.ExpectedUsers = IFIMMPPLLHI.ExpectedUsers;
		this.ELNKFMHCMBO = (JoinType)4;
		return base.IDCMLGBBFMG(IFIMMPPLLHI);
	}

	// Token: 0x0600B222 RID: 45602 RVA: 0x0008B976 File Offset: 0x00089B76
	private void GPODJOPLJPD(int IJAEJMNLBLK, PhotonPlayer JHOEDACNNKK)
	{
		this.mActors.Remove(IJAEJMNLBLK);
		if (!JHOEDACNNKK.IsLocal)
		{
			this.LEMBPMNPHCK();
		}
	}

	// Token: 0x0600B223 RID: 45603 RVA: 0x0041A354 File Offset: 0x00418554
	public void DebugReturn(DebugLevel DCMIEONIJMA, string JKPJCEMPAGH)
	{
		if (DCMIEONIJMA == DebugLevel.ERROR)
		{
			Debug.LogError(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.WARNING)
		{
			Debug.LogWarning(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.INFO && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.ALL && PhotonNetwork.logLevel == PhotonLogLevel.Full)
		{
			Debug.Log(JKPJCEMPAGH);
		}
	}

	// Token: 0x0600B224 RID: 45604 RVA: 0x0041A3BC File Offset: 0x004185BC
	protected internal void MBCHEFNAJFH(ExitGames.Client.Photon.Hashtable LKGFKFMABPG, int BGNEKPOLEEP = 0)
	{
		if (LKGFKFMABPG == null || !LKGFKFMABPG.ContainsKey(0))
		{
			Debug.LogError("Malformed RPC; this should never occur. Content: " + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		int num = (int)LKGFKFMABPG[0];
		int num2 = 0;
		if (LKGFKFMABPG.ContainsKey(1))
		{
			num2 = (int)((short)LKGFKFMABPG[1]);
		}
		string text;
		if (LKGFKFMABPG.ContainsKey(5))
		{
			int num3 = (int)((byte)LKGFKFMABPG[5]);
			if (num3 > PhotonNetwork.PhotonServerSettings.RpcList.Count - 1)
			{
				Debug.LogError("Could not find RPC with index: " + num3 + ". Going to ignore! Check PhotonServerSettings.RpcList");
				return;
			}
			text = PhotonNetwork.PhotonServerSettings.RpcList[num3];
		}
		else
		{
			text = (string)LKGFKFMABPG[3];
		}
		object[] array = null;
		if (LKGFKFMABPG.ContainsKey(4))
		{
			array = (object[])LKGFKFMABPG[4];
		}
		if (array == null)
		{
			array = new object[0];
		}
		PhotonView photonView = this.GetPhotonView(num);
		if (photonView == null)
		{
			int num4 = num / PhotonNetwork.MAX_VIEW_IDS;
			bool flag = num4 == this.LocalPlayer.ID;
			bool flag2 = num4 == BGNEKPOLEEP;
			if (flag)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"Received RPC \"",
					text,
					"\" for viewID ",
					num,
					" but this PhotonView does not exist! View was/is ours.",
					(!flag2) ? " Remote called." : " Owner called.",
					" By: ",
					BGNEKPOLEEP
				}));
			}
			else
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"Received RPC \"",
					text,
					"\" for viewID ",
					num,
					" but this PhotonView does not exist! Was remote PV.",
					(!flag2) ? " Remote called." : " Owner called.",
					" By: ",
					BGNEKPOLEEP,
					" Maybe GO was destroyed but RPC not cleaned up."
				}));
			}
			return;
		}
		if (photonView.prefix != num2)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Received RPC \"",
				text,
				"\" on viewID ",
				num,
				" with a prefix of ",
				num2,
				", our prefix is ",
				photonView.prefix,
				". The RPC has been ignored."
			}));
			return;
		}
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError("Malformed RPC; this should never occur. Content: " + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Received RPC: " + text);
		}
		if (photonView.group != 0 && !this.CHIJNBAJIHE.Contains(photonView.group))
		{
			return;
		}
		Type[] array2 = new Type[0];
		if (array.Length > 0)
		{
			array2 = new Type[array.Length];
			int num5 = 0;
			foreach (object obj in array)
			{
				if (obj == null)
				{
					array2[num5] = null;
				}
				else
				{
					array2[num5] = obj.GetType();
				}
				num5++;
			}
		}
		int num6 = 0;
		int num7 = 0;
		if (!PhotonNetwork.UseRpcMonoBehaviourCache || photonView.HFCEJMOIGDF == null || photonView.HFCEJMOIGDF.Length == 0)
		{
			photonView.RefreshRpcMonoBehaviourCache();
		}
		for (int j = 0; j < photonView.HFCEJMOIGDF.Length; j++)
		{
			MonoBehaviour monoBehaviour = photonView.HFCEJMOIGDF[j];
			if (monoBehaviour == null)
			{
				Debug.LogError("ERROR You have missing MonoBehaviours on your gameobjects!");
			}
			else
			{
				Type type = monoBehaviour.GetType();
				List<MethodInfo> list = null;
				if (!this.MNKFMEHFNKJ.TryGetValue(type, out list))
				{
					List<MethodInfo> methods = SupportClass.GetMethods(type, typeof(PunRPC));
					this.MNKFMEHFNKJ[type] = methods;
					list = methods;
				}
				if (list != null)
				{
					for (int k = 0; k < list.Count; k++)
					{
						MethodInfo methodInfo = list[k];
						if (methodInfo.Name.Equals(text))
						{
							num7++;
							ParameterInfo[] cachedParemeters = methodInfo.GetCachedParemeters();
							if (cachedParemeters.Length == array2.Length)
							{
								if (this.IHAJPLJACML(cachedParemeters, array2))
								{
									num6++;
									object obj2 = methodInfo.Invoke(monoBehaviour, array);
									if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
									{
										monoBehaviour.StartCoroutine((IEnumerator)obj2);
									}
								}
							}
							else if (cachedParemeters.Length - 1 == array2.Length)
							{
								if (this.IHAJPLJACML(cachedParemeters, array2) && cachedParemeters[cachedParemeters.Length - 1].ParameterType == typeof(PhotonMessageInfo))
								{
									num6++;
									int amciaillaib = (int)LKGFKFMABPG[2];
									object[] array3 = new object[array.Length + 1];
									array.CopyTo(array3, 0);
									array3[array3.Length - 1] = new PhotonMessageInfo(this.ICMGDHDNIJD(BGNEKPOLEEP), amciaillaib, photonView);
									object obj3 = methodInfo.Invoke(monoBehaviour, array3);
									if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
									{
										monoBehaviour.StartCoroutine((IEnumerator)obj3);
									}
								}
							}
							else if (cachedParemeters.Length == 1 && cachedParemeters[0].ParameterType.IsArray)
							{
								num6++;
								object obj4 = methodInfo.Invoke(monoBehaviour, new object[]
								{
									array
								});
								if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
								{
									monoBehaviour.StartCoroutine((IEnumerator)obj4);
								}
							}
						}
					}
				}
			}
		}
		if (num6 != 1)
		{
			string text2 = string.Empty;
			foreach (Type type2 in array2)
			{
				if (text2 != string.Empty)
				{
					text2 += ", ";
				}
				if (type2 == null)
				{
					text2 += "null";
				}
				else
				{
					text2 += type2.Name;
				}
			}
			if (num6 == 0)
			{
				if (num7 == 0)
				{
					Debug.LogError(string.Concat(new object[]
					{
						"PhotonView with ID ",
						num,
						" has no method \"",
						text,
						"\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ",
						text2
					}));
				}
				else
				{
					Debug.LogError(string.Concat(new object[]
					{
						"PhotonView with ID ",
						num,
						" has no method \"",
						text,
						"\" that takes ",
						array2.Length,
						" argument(s): ",
						text2
					}));
				}
			}
			else
			{
				Debug.LogError(string.Concat(new object[]
				{
					"PhotonView with ID ",
					num,
					" has ",
					num6,
					" methods \"",
					text,
					"\" that takes ",
					array2.Length,
					" argument(s): ",
					text2,
					". Should be just one?"
				}));
			}
		}
	}

	// Token: 0x0600B225 RID: 45605 RVA: 0x0008B996 File Offset: 0x00089B96
	internal void CNMLBBFHKOD(PhotonPlayer DPNHODJHGJL)
	{
		this.<NHOFDHIGABI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B226 RID: 45606 RVA: 0x0041AB48 File Offset: 0x00418D48
	public bool ConnectToRegionMaster(CloudRegionCode LPCNAHJGAFK)
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		this.IsUsingNameServer = true;
		this.CloudRegion = LPCNAHJGAFK;
		if (this.State == ClientState.ConnectedToNameServer)
		{
			return this.OELIGNFABAJ();
		}
		this.PKNIJKPIKAF = ServerConnection.NameServer;
		this.BLNBCGLIOHP = this.NameServerAddress;
		this.KAOMEDGGMEM = "ns";
		this.KHKMFIFGPCH(ServerConnection.NameServer);
		if (!base.Connect(this.NameServerAddress, "ns", this.LLJDHHLHFME))
		{
			return false;
		}
		this.State = ClientState.ConnectingToNameServer;
		return true;
	}

	// Token: 0x0600B227 RID: 45607 RVA: 0x0041ABDC File Offset: 0x00418DDC
	public void ADIPGEIPMBK(DebugLevel DCMIEONIJMA, string JKPJCEMPAGH)
	{
		if (DCMIEONIJMA == DebugLevel.OFF)
		{
			Debug.LogError(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.ERROR)
		{
			Debug.LogWarning(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.WARNING && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == (DebugLevel)6 && PhotonNetwork.logLevel == PhotonLogLevel.Full)
		{
			Debug.Log(JKPJCEMPAGH);
		}
	}

	// Token: 0x0600B229 RID: 45609 RVA: 0x0008B99F File Offset: 0x00089B9F
	public override bool Connect(string BPMNPBDOMFO, string KKBGACJIHDP)
	{
		Debug.LogError("Avoid using this directly. Thanks.");
		return false;
	}

	// Token: 0x0600B22A RID: 45610 RVA: 0x0008B9AC File Offset: 0x00089BAC
	public bool LocalCleanPhotonView(PhotonView DFIHBOEOJPI)
	{
		DFIHBOEOJPI.IHPAIFIHLAE = true;
		return this.HFCMPEKPBAM.Remove(DFIHBOEOJPI.viewID);
	}

	// Token: 0x0600B22B RID: 45611 RVA: 0x0008B9C6 File Offset: 0x00089BC6
	internal void KJEHFHLGFIM(int DPNHODJHGJL)
	{
		this.<BBNAEKGKOKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B22C RID: 45612 RVA: 0x0008B9CF File Offset: 0x00089BCF
	private ExitGames.Client.Photon.Hashtable LOCGDJDHCHJ(ExitGames.Client.Photon.Hashtable FPBCPOGCCBD, int KHACEEGCPEP)
	{
		if (FPBCPOGCCBD.ContainsKey(KHACEEGCPEP))
		{
			return (ExitGames.Client.Photon.Hashtable)FPBCPOGCCBD[KHACEEGCPEP];
		}
		return FPBCPOGCCBD;
	}

	// Token: 0x0600B22D RID: 45613 RVA: 0x0008B9F5 File Offset: 0x00089BF5
	public void SetLevelPrefix(short MOALALKJCKJ)
	{
		this.PKCNHOKCLJH = MOALALKJCKJ;
	}

	// Token: 0x0600B22E RID: 45614 RVA: 0x0008B9FE File Offset: 0x00089BFE
	public virtual bool NEGBMLGHJPD(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		return !PhotonNetwork.offlineMode && base.KJNCENGOFBE(IMCBEMICJFC, PEIFAPIIKNJ, ANMGHMBBMAO, BPLHAPBMGGC);
	}

	// Token: 0x0600B22F RID: 45615 RVA: 0x0008BA17 File Offset: 0x00089C17
	private void IFPPBJINADG()
	{
		this.mGameList = new Dictionary<string, RoomInfo>();
		this.mGameListCopy = new RoomInfo[0];
		if (this.insideLobby)
		{
			this.insideLobby = false;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftLobby, new object[0]);
		}
	}

	// Token: 0x0600B231 RID: 45617 RVA: 0x0041AC44 File Offset: 0x00418E44
	private void NGAEPLGAGAL(int KHACEEGCPEP)
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				KHACEEGCPEP
			}
		};
		this.OpRaiseEvent(202, null, true, bplhapbmggc);
	}

	// Token: 0x0600B232 RID: 45618 RVA: 0x0041AC80 File Offset: 0x00418E80
	private void OPKEDOEIKCO(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
		{
			object[] array = new object[8];
			array[0] = "Could not find RPC with index: ";
			array[1] = IECJKEIJLCP;
			array[6] = "https://steamcommunity.com/sharedfiles/filedetails/?id=";
			array[4] = EKDHPAFJKFA.ToStringFull();
			Debug.Log(string.Concat(array));
		}
		PhotonPlayer photonPlayer = this.ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("_HighlightSuppression", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(161))
		{
			photonPlayer.EJABLLBGMGC((bool)EKDHPAFJKFA.Parameters[36]);
			if (photonPlayer.IsInactive != isInactive)
			{
				PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)(-102);
				object[] array2 = new object[0];
				array2[0] = photonPlayer;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array2);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				object[] array3 = new object[7];
				array3[1] = "_Offsets";
				array3[0] = IECJKEIJLCP;
				array3[3] = "_TimeX";
				array3[7] = photonPlayer.IsInactive;
				array3[5] = "maps.";
				Debug.LogWarning(string.Concat(array3));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(44))
		{
			int num = (int)EKDHPAFJKFA[(byte)-184];
			if (num != 0)
			{
				this.mMasterClientId = (int)EKDHPAFJKFA[(byte)-17];
				this.ELDLAPJAPBJ();
			}
		}
		else if (!this.CurrentRoom.BDHOOLIDFJO)
		{
			this.ANCHCNAJLOJ(IECJKEIJLCP);
		}
		if (photonPlayer.IsInactive && !isInactive)
		{
			return;
		}
		if (this.CurrentRoom != null && this.CurrentRoom.HGADABNHIFG())
		{
			this.DestroyPlayerObjects(IECJKEIJLCP, false);
		}
		this.GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
		PhotonNetworkingMessage lelhnddckco2 = PhotonNetworkingMessage.OnWebRpcResponse;
		object[] array4 = new object[0];
		array4[1] = photonPlayer;
		BNGIGHBHPEH.SendMonoMessage(lelhnddckco2, array4);
	}

	// Token: 0x0600B233 RID: 45619 RVA: 0x0008BA57 File Offset: 0x00089C57
	public override bool OpRaiseEvent(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		return !PhotonNetwork.offlineMode && base.OpRaiseEvent(IMCBEMICJFC, PEIFAPIIKNJ, ANMGHMBBMAO, BPLHAPBMGGC);
	}

	// Token: 0x0600B234 RID: 45620 RVA: 0x0041AE48 File Offset: 0x00419048
	public object[] FetchInstantiationData(int HOBFECDCMIL)
	{
		object[] result = null;
		if (HOBFECDCMIL == 0)
		{
			return null;
		}
		this.IDIKEJLLFFP.TryGetValue(HOBFECDCMIL, out result);
		return result;
	}

	// Token: 0x0600B235 RID: 45621 RVA: 0x0041AE70 File Offset: 0x00419070
	private void KIAFOHLEGJO(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			object[] array = new object[3];
			array[0] = " ";
			array[1] = IECJKEIJLCP;
			array[5] = "_ClutTex";
			array[4] = EKDHPAFJKFA.ToStringFull();
			Debug.Log(string.Concat(array));
		}
		PhotonPlayer photonPlayer = this.ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("<b>Time</b>:", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(49))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[24];
			if (photonPlayer.IsInactive != isInactive)
			{
				PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)(-8);
				object[] array2 = new object[1];
				array2[1] = photonPlayer;
				BNGIGHBHPEH.GHLJAECJCKF(lelhnddckco, array2);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				object[] array3 = new object[1];
				array3[0] = "0,7,true,0";
				array3[1] = IECJKEIJLCP;
				array3[5] = ";";
				array3[6] = photonPlayer.IsInactive;
				array3[7] = "_Value";
				Debug.LogWarning(string.Concat(array3));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(72))
		{
			int num = (int)EKDHPAFJKFA[(byte)-174];
			if (num != 0)
			{
				this.mMasterClientId = (int)EKDHPAFJKFA[8];
				this.ELDLAPJAPBJ();
			}
		}
		else if (!this.CurrentRoom.PPODOKJKEHE())
		{
			this.ANCHCNAJLOJ(IECJKEIJLCP);
		}
		if (photonPlayer.IsInactive && !isInactive)
		{
			return;
		}
		if (this.CurrentRoom != null && this.CurrentRoom.AutoCleanUp)
		{
			this.DestroyPlayerObjects(IECJKEIJLCP, false);
		}
		this.GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
		PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)98;
		object[] array4 = new object[1];
		array4[1] = photonPlayer;
		BNGIGHBHPEH.GHLJAECJCKF(lelhnddckco2, array4);
	}

	// Token: 0x0600B236 RID: 45622 RVA: 0x0008BA70 File Offset: 0x00089C70
	public void JAAICPFDENO(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.FFBGBLFBHOK.Add(PNFBEEBFMKC);
		}
		else
		{
			this.FFBGBLFBHOK.Remove(PNFBEEBFMKC);
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x0600B237 RID: 45623 RVA: 0x0008B912 File Offset: 0x00089B12
	// (set) Token: 0x0600B254 RID: 45652 RVA: 0x0008BB2E File Offset: 0x00089D2E
	public TypedLobby lobby { get; set; }

	// Token: 0x0600B238 RID: 45624 RVA: 0x0008B70B File Offset: 0x0008990B
	public string BDJGCHOLCJN()
	{
		return this.IHAJBEOILOE();
	}

	// Token: 0x0600B23A RID: 45626 RVA: 0x0041B038 File Offset: 0x00419238
	protected internal void DLFAOFKNNHF()
	{
		if (!PhotonNetwork.automaticallySyncScene || PhotonNetwork.isMasterClient || PhotonNetwork.room == null)
		{
			return;
		}
		if (!PhotonNetwork.room.CustomProperties.ContainsKey("#discord{0}joinrequest"))
		{
			return;
		}
		object obj = PhotonNetwork.room.GBLNGKOOEMH()["maps."];
		if (obj is int)
		{
			if (SceneManagerHelper.AKDJMHNDCBO() != (int)obj)
			{
				PhotonNetwork.LoadLevel((int)obj);
			}
		}
		else if (obj is string && SceneManagerHelper.JFNAOCLGCFO() != (string)obj)
		{
			PhotonNetwork.LoadLevel((string)obj);
		}
	}

	// Token: 0x0600B23B RID: 45627 RVA: 0x0041B0EC File Offset: 0x004192EC
	public bool OpCreateGame(AKBOPCNHFFJ BDMKOAGEHPM)
	{
		bool flag = this.EHALCLFLGJF == ServerConnection.GameServer;
		BDMKOAGEHPM.OnGameServer = flag;
		BDMKOAGEHPM.PlayerProperties = this.HHPBLGDNDOP();
		if (!flag)
		{
			this.AJFMHFLGCFN = BDMKOAGEHPM;
		}
		this.ELNKFMHCMBO = JoinType.CreateRoom;
		return base.OpCreateRoom(BDMKOAGEHPM);
	}

	// Token: 0x0600B23C RID: 45628 RVA: 0x0041B134 File Offset: 0x00419334
	public void OnStatusChanged(StatusCode FIIDDDBNCLD)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Format("OnStatusChanged: {0} current State: {1}", FIIDDDBNCLD.ToString(), this.State));
		}
		switch (FIIDDDBNCLD)
		{
		case StatusCode.ExceptionOnReceive:
		case StatusCode.DisconnectByServer:
		case StatusCode.DisconnectByServerUserLimit:
		case StatusCode.DisconnectByServerLogic:
			if (this.IsInitialConnect)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					FIIDDDBNCLD,
					" while connecting to: ",
					base.ServerAddress,
					". Check if the server is available."
				}));
				this.IsInitialConnect = false;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
				{
					disconnectCause
				});
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
				{
					disconnectCause
				});
			}
			if (this.AuthValues != null)
			{
				this.AuthValues.Token = null;
			}
			this.Disconnect();
			return;
		case StatusCode.TimeoutDisconnect:
			if (this.IsInitialConnect)
			{
				if (!this.IDOAHFHJJJE)
				{
					Debug.LogWarning(string.Concat(new object[]
					{
						FIIDDDBNCLD,
						" while connecting to: ",
						base.ServerAddress,
						". Check if the server is available."
					}));
					this.IsInitialConnect = false;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
					{
						disconnectCause
					});
				}
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
				{
					disconnectCause
				});
			}
			if (this.AuthValues != null)
			{
				this.AuthValues.Token = null;
			}
			this.Disconnect();
			return;
		default:
			switch (FIIDDDBNCLD)
			{
			case StatusCode.SecurityExceptionOnConnect:
			case StatusCode.ExceptionOnConnect:
			{
				this.IsInitialConnect = false;
				this.State = ClientState.PeerCreated;
				if (this.AuthValues != null)
				{
					this.AuthValues.Token = null;
				}
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
				{
					disconnectCause
				});
				return;
			}
			case StatusCode.Connect:
				if (this.State == ClientState.ConnectingToNameServer)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("Connected to NameServer.");
					}
					this.EHALCLFLGJF = ServerConnection.NameServer;
					if (this.AuthValues != null)
					{
						this.AuthValues.Token = null;
					}
				}
				if (this.State == ClientState.ConnectingToGameserver)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("Connected to gameserver.");
					}
					this.EHALCLFLGJF = ServerConnection.GameServer;
					this.State = ClientState.ConnectedToGameserver;
				}
				if (this.State == ClientState.ConnectingToMasterserver)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("Connected to masterserver.");
					}
					this.EHALCLFLGJF = ServerConnection.MasterServer;
					this.State = ClientState.Authenticating;
					if (this.IsInitialConnect)
					{
						this.IsInitialConnect = false;
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToPhoton, new object[0]);
					}
				}
				if (base.TransportProtocol != ConnectionProtocol.WebSocketSecure)
				{
					if (this.EHALCLFLGJF == ServerConnection.NameServer || this.AuthMode == AuthModeOption.Auth)
					{
						base.EstablishEncryption();
					}
					return;
				}
				if (this.DebugOut == DebugLevel.INFO)
				{
					Debug.Log("Skipping EstablishEncryption. Protocol is secure.");
				}
				goto IL_1AC;
			case StatusCode.Disconnect:
				this.DMCPHGDNGDB = false;
				this.POHIMACBDGL = false;
				if (this.EHALCLFLGJF == ServerConnection.GameServer)
				{
					this.BOJKDNJHBNG();
				}
				if (this.EHALCLFLGJF == ServerConnection.MasterServer)
				{
					this.IFPPBJINADG();
				}
				if (this.State == ClientState.DisconnectingFromMasterserver)
				{
					if (this.Connect(this.GameServerAddress, ServerConnection.GameServer))
					{
						this.State = ClientState.ConnectingToGameserver;
					}
				}
				else if (this.State == ClientState.DisconnectingFromGameserver || this.State == ClientState.DisconnectingFromNameServer)
				{
					this.KHKMFIFGPCH(ServerConnection.MasterServer);
					if (this.Connect(this.MasterServerAddress, ServerConnection.MasterServer))
					{
						this.State = ClientState.ConnectingToMasterserver;
					}
				}
				else
				{
					if (this.IDOAHFHJJJE)
					{
						return;
					}
					if (this.AuthValues != null)
					{
						this.AuthValues.Token = null;
					}
					this.IsInitialConnect = false;
					this.State = ClientState.PeerCreated;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnDisconnectedFromPhoton, new object[0]);
				}
				return;
			case StatusCode.Exception:
				if (this.IsInitialConnect)
				{
					Debug.LogError("Exception while connecting to: " + base.ServerAddress + ". Check if the server is available.");
					if (base.ServerAddress == null || base.ServerAddress.StartsWith("127.0.0.1"))
					{
						Debug.LogWarning("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.");
						if (base.ServerAddress == this.GameServerAddress)
						{
							Debug.LogWarning("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.");
						}
					}
					this.State = ClientState.PeerCreated;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					this.IsInitialConnect = false;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
					{
						disconnectCause
					});
				}
				else
				{
					this.State = ClientState.PeerCreated;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						disconnectCause
					});
				}
				this.Disconnect();
				return;
			case StatusCode.SendError:
				return;
			}
			Debug.LogError("Received unknown status code: " + FIIDDDBNCLD);
			return;
		case StatusCode.EncryptionEstablished:
			break;
		case StatusCode.EncryptionFailedToEstablish:
		{
			Debug.LogError("Encryption wasn't established: " + FIIDDDBNCLD + ". Going to authenticate anyways.");
			AuthenticationValues authenticationValues;
			if ((authenticationValues = this.AuthValues) == null)
			{
				authenticationValues = new AuthenticationValues
				{
					UserId = this.PlayerName
				};
			}
			AuthenticationValues gpdfhodmoij = authenticationValues;
			this.OpAuthenticate(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.OGLFGPKHEHH);
			return;
		}
		}
		IL_1AC:
		this.IDOAHFHJJJE = false;
		if (this.EHALCLFLGJF == ServerConnection.NameServer)
		{
			this.State = ClientState.ConnectedToNameServer;
			if (!this.DMCPHGDNGDB && this.CloudRegion == CloudRegionCode.none)
			{
				this.OpGetRegions(this.KAIBLIKEDHM);
			}
		}
		if (this.EHALCLFLGJF != ServerConnection.NameServer && (this.AuthMode == AuthModeOption.AuthOnce || this.AuthMode == AuthModeOption.AuthOnceWss))
		{
			Debug.Log(string.Concat(new object[]
			{
				"didAuthenticate ",
				this.DMCPHGDNGDB,
				" AuthMode ",
				this.AuthMode
			}));
		}
		else if (!this.DMCPHGDNGDB && (!this.IsUsingNameServer || this.CloudRegion != CloudRegionCode.none))
		{
			this.DMCPHGDNGDB = this.OELIGNFABAJ();
			if (this.DMCPHGDNGDB)
			{
				this.State = ClientState.Authenticating;
			}
		}
	}

	// Token: 0x0600B23E RID: 45630 RVA: 0x0041B788 File Offset: 0x00419988
	public bool GetRegions()
	{
		if (this.EHALCLFLGJF != ServerConnection.NameServer)
		{
			return false;
		}
		bool flag = this.OpGetRegions(this.KAIBLIKEDHM);
		if (flag)
		{
			this.AvailableRegions = null;
		}
		return flag;
	}

	// Token: 0x0600B23F RID: 45631 RVA: 0x0041B7C0 File Offset: 0x004199C0
	private bool LFAPOBNFPPO(object CFKDMFFFPJK, object GOLMELKEAFO)
	{
		if (CFKDMFFFPJK == null || GOLMELKEAFO == null)
		{
			return CFKDMFFFPJK == null && GOLMELKEAFO == null;
		}
		if (!CFKDMFFFPJK.Equals(GOLMELKEAFO))
		{
			if (CFKDMFFFPJK is Vector3)
			{
				Vector3 mpnmoonbmii = (Vector3)CFKDMFFFPJK;
				Vector3 biccgcfnnlp = (Vector3)GOLMELKEAFO;
				if (mpnmoonbmii.AlmostEquals(biccgcfnnlp, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Vector2)
			{
				Vector2 mpnmoonbmii2 = (Vector2)CFKDMFFFPJK;
				Vector2 biccgcfnnlp2 = (Vector2)GOLMELKEAFO;
				if (mpnmoonbmii2.AlmostEquals(biccgcfnnlp2, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Quaternion)
			{
				Quaternion mpnmoonbmii3 = (Quaternion)CFKDMFFFPJK;
				Quaternion biccgcfnnlp3 = (Quaternion)GOLMELKEAFO;
				if (mpnmoonbmii3.AlmostEquals(biccgcfnnlp3, PhotonNetwork.precisionForQuaternionSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is float)
			{
				float mpnmoonbmii4 = (float)CFKDMFFFPJK;
				float biccgcfnnlp4 = (float)GOLMELKEAFO;
				if (mpnmoonbmii4.AlmostEquals(biccgcfnnlp4, PhotonNetwork.precisionForFloatSynchronization))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x0600B240 RID: 45632 RVA: 0x0041B8C0 File Offset: 0x00419AC0
	private object[] OAMPHAGPLEL(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Off)
		{
			return null;
		}
		PhotonMessageInfo dagalcailln = new PhotonMessageInfo(this.LocalPlayer, PhotonNetwork.ServerTimestamp, DFIHBOEOJPI);
		this.ALPAEKHFHPP.MKNINLEEFNI();
		this.ALPAEKHFHPP.SendNext(null);
		this.ALPAEKHFHPP.SendNext(null);
		this.ALPAEKHFHPP.SendNext(null);
		DFIHBOEOJPI.SerializeView(this.ALPAEKHFHPP, dagalcailln);
		if (this.ALPAEKHFHPP.Count <= 3)
		{
			return null;
		}
		object[] array = this.ALPAEKHFHPP.ToArray();
		array[0] = DFIHBOEOJPI.viewID;
		array[1] = false;
		array[2] = null;
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Unreliable)
		{
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.UnreliableOnChange)
		{
			if (this.LFAPOBNFPPO(array, DFIHBOEOJPI.EOENPICKCCO))
			{
				if (DFIHBOEOJPI.PBIDCPBMFKJ)
				{
					return null;
				}
				DFIHBOEOJPI.PBIDCPBMFKJ = true;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			else
			{
				DFIHBOEOJPI.PBIDCPBMFKJ = false;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] result = this.MFKHMJBJDLE(DFIHBOEOJPI.EOENPICKCCO, array);
			DFIHBOEOJPI.EOENPICKCCO = array;
			return result;
		}
		return null;
	}

	// Token: 0x0600B241 RID: 45633 RVA: 0x0041B9E4 File Offset: 0x00419BE4
	private void PCLPOPNEABK(OperationResponse FEOMHKNGOAK)
	{
		if (FEOMHKNGOAK.ReturnCode != 0)
		{
			byte operationCode = FEOMHKNGOAK.OperationCode;
			if (operationCode != 227)
			{
				if (operationCode != 226)
				{
					if (operationCode == 225)
					{
						if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
						{
							Debug.Log("Join failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
							if (FEOMHKNGOAK.ReturnCode == 32758)
							{
								Debug.Log("Most likely the game became empty during the switch to GameServer.");
							}
						}
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonRandomJoinFailed, new object[]
						{
							FEOMHKNGOAK.ReturnCode,
							FEOMHKNGOAK.DebugMessage
						});
					}
				}
				else
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log("Join failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
						if (FEOMHKNGOAK.ReturnCode == 32758)
						{
							Debug.Log("Most likely the game became empty during the switch to GameServer.");
						}
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinRoomFailed, new object[]
					{
						FEOMHKNGOAK.ReturnCode,
						FEOMHKNGOAK.DebugMessage
					});
				}
			}
			else
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.Log("Create failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
				}
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateRoomFailed, new object[]
				{
					FEOMHKNGOAK.ReturnCode,
					FEOMHKNGOAK.DebugMessage
				});
			}
			this.NDPIAMOMGME();
			return;
		}
		this.CurrentRoom = new Room(this.AJFMHFLGCFN.RoomName, null)
		{
			IsLocalClientInside = true
		};
		this.State = ClientState.Joined;
		if (FEOMHKNGOAK.Parameters.ContainsKey(252))
		{
			int[] homaecigjej = (int[])FEOMHKNGOAK.Parameters[252];
			this.ANEENOJMDOJ(homaecigjej);
		}
		int lghipfaeonm = (int)FEOMHKNGOAK[254];
		this.ChangeLocalID(lghipfaeonm);
		ExitGames.Client.Photon.Hashtable faolpblckfj = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[249];
		ExitGames.Client.Photon.Hashtable mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[248];
		this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, 0);
		if (!this.CurrentRoom.BDHOOLIDFJO)
		{
			this.CDNPLJILLFC(-1);
		}
		if (this.BOKEGDFHBAN)
		{
			this.PACEKOIEHKK();
		}
		byte operationCode2 = FEOMHKNGOAK.OperationCode;
		if (operationCode2 != 227)
		{
			if (operationCode2 != 226 && operationCode2 != 225)
			{
			}
		}
		else
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom, new object[0]);
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x0600B251 RID: 45649 RVA: 0x0008BB1D File Offset: 0x00089D1D
	// (set) Token: 0x0600B242 RID: 45634 RVA: 0x0008BAA8 File Offset: 0x00089CA8
	public CloudRegionCode CloudRegion { get; protected internal set; }

	// Token: 0x0600B243 RID: 45635 RVA: 0x0041BC50 File Offset: 0x00419E50
	private void BAEBFLIPKKB(Dictionary<byte, object> FNHGNHCOMBH)
	{
		if (this.AuthMode == AuthModeOption.Auth && this.DebugOut == DebugLevel.ERROR)
		{
			Debug.LogWarning("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: " + FNHGNHCOMBH.ToStringFull());
			return;
		}
		if (this.DebugOut == DebugLevel.INFO)
		{
			Debug.Log("SetupEncryption() got called. " + FNHGNHCOMBH.ToStringFull());
		}
		EncryptionMode encryptionMode = (EncryptionMode)((byte)FNHGNHCOMBH[0]);
		if (encryptionMode != EncryptionMode.PayloadEncryption)
		{
			if (encryptionMode != EncryptionMode.DatagramEncryption)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] encryptionSecret = (byte[])FNHGNHCOMBH[1];
			byte[] hmacSecret = (byte[])FNHGNHCOMBH[2];
			base.InitDatagramEncryption(encryptionSecret, hmacSecret);
		}
		else
		{
			byte[] secret = (byte[])FNHGNHCOMBH[1];
			base.InitPayloadEncryption(secret);
		}
	}

	// Token: 0x0600B244 RID: 45636 RVA: 0x0041BD14 File Offset: 0x00419F14
	private void COOFPMNPDBH(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
		{
			object[] array = new object[]
			{
				null,
				"_SpherePositionX"
			};
			array[1] = IECJKEIJLCP;
			array[5] = "IconImage";
			array[6] = EKDHPAFJKFA.ToStringFull();
			Debug.Log(string.Concat(array));
		}
		PhotonPlayer photonPlayer = this.ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("id", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(150))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[(byte)-119];
			if (photonPlayer.IsInactive != isInactive)
			{
				PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)(-72);
				object[] array2 = new object[1];
				array2[1] = photonPlayer;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array2);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				object[] array3 = new object[0];
				array3[1] = "_ScreenResolution";
				array3[0] = IECJKEIJLCP;
				array3[7] = "resetach21";
				array3[8] = photonPlayer.IsInactive;
				array3[7] = "UI Extensions/UIScreen";
				Debug.LogWarning(string.Concat(array3));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(7))
		{
			int num = (int)EKDHPAFJKFA[188];
			if (num != 0)
			{
				this.mMasterClientId = (int)EKDHPAFJKFA[128];
				this.ELDLAPJAPBJ();
			}
		}
		else if (!this.CurrentRoom.PPODOKJKEHE())
		{
			this.CDNPLJILLFC(IECJKEIJLCP);
		}
		if (photonPlayer.IsInactive && !isInactive)
		{
			return;
		}
		if (this.CurrentRoom != null && this.CurrentRoom.HGADABNHIFG())
		{
			this.DestroyPlayerObjects(IECJKEIJLCP, true);
		}
		this.GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
		PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)104;
		object[] array4 = new object[1];
		array4[1] = photonPlayer;
		BNGIGHBHPEH.GHLJAECJCKF(lelhnddckco2, array4);
	}

	// Token: 0x0600B245 RID: 45637 RVA: 0x0041BEDC File Offset: 0x0041A0DC
	public bool ConnectToNameServer()
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		this.IsUsingNameServer = true;
		this.CloudRegion = CloudRegionCode.none;
		if (this.State == ClientState.ConnectedToNameServer)
		{
			return true;
		}
		this.KHKMFIFGPCH(ServerConnection.NameServer);
		this.PKNIJKPIKAF = ServerConnection.NameServer;
		this.BLNBCGLIOHP = this.NameServerAddress;
		this.KAOMEDGGMEM = "ns";
		if (!base.Connect(this.NameServerAddress, "ns", this.LLJDHHLHFME))
		{
			return false;
		}
		this.State = ClientState.ConnectingToNameServer;
		return true;
	}

	// Token: 0x0600B246 RID: 45638 RVA: 0x0008B9C6 File Offset: 0x00089BC6
	internal void DPOAKDGFINF(int DPNHODJHGJL)
	{
		this.<BBNAEKGKOKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B247 RID: 45639 RVA: 0x0041BF68 File Offset: 0x0041A168
	public void NNENGIKPKII(PhotonView LCJKMJCFDGE)
	{
		if (!Application.isPlaying)
		{
			this.HFCMPEKPBAM = new Dictionary<int, PhotonView>();
			return;
		}
		if (LCJKMJCFDGE.PLMCHLCIABC() == 0)
		{
			Debug.Log("help" + LCJKMJCFDGE);
			return;
		}
		PhotonView photonView = null;
		bool flag = this.HFCMPEKPBAM.TryGetValue(LCJKMJCFDGE.PLMCHLCIABC(), out photonView);
		if (flag)
		{
			if (!(LCJKMJCFDGE != photonView))
			{
				return;
			}
			Debug.LogError(string.Format("CameraFilterPack/3D_Mirror", LCJKMJCFDGE.PLMCHLCIABC(), LCJKMJCFDGE, photonView));
			this.EFDAOHIDIIF(photonView.gameObject, false);
		}
		this.HFCMPEKPBAM.Add(LCJKMJCFDGE.PLMCHLCIABC(), LCJKMJCFDGE);
		if (PhotonNetwork.logLevel >= (PhotonLogLevel)8)
		{
			Debug.Log(" on effect " + LCJKMJCFDGE.viewID);
		}
	}

	// Token: 0x0600B248 RID: 45640 RVA: 0x0008BAB1 File Offset: 0x00089CB1
	public override bool OpJoinRandomRoom(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		this.AJFMHFLGCFN = new AKBOPCNHFFJ();
		this.AJFMHFLGCFN.Lobby = IFIMMPPLLHI.TypedLobby;
		this.AJFMHFLGCFN.ExpectedUsers = IFIMMPPLLHI.ExpectedUsers;
		this.ELNKFMHCMBO = JoinType.JoinRandomRoom;
		return base.OpJoinRandomRoom(IFIMMPPLLHI);
	}

	// Token: 0x0600B24A RID: 45642 RVA: 0x0041C038 File Offset: 0x0041A238
	private void MJLFCEHBMGL()
	{
		Debug.Log("SendVacantViewIds()");
		List<int> list = new List<int>();
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if (!photonView.isOwnerActive)
			{
				list.Add(photonView.viewID);
			}
		}
		Debug.Log("Sending vacant view IDs. Length: " + list.Count);
		this.OpRaiseEvent(211, list.ToArray(), true, null);
	}

	// Token: 0x0600B24B RID: 45643 RVA: 0x0041C0E8 File Offset: 0x0041A2E8
	protected internal void ANEENOJMDOJ(int[] HOMAECIGJEJ)
	{
		foreach (int num in HOMAECIGJEJ)
		{
			if (this.LocalPlayer.ID != num && !this.mActors.ContainsKey(num))
			{
				this.EGJBHECFAOH(num, new PhotonPlayer(false, num, string.Empty));
			}
		}
	}

	// Token: 0x0600B24C RID: 45644 RVA: 0x0041C144 File Offset: 0x0041A344
	protected internal void KIHFINECBEL(ExitGames.Client.Photon.Hashtable LKGFKFMABPG, int BGNEKPOLEEP = 0)
	{
		if (LKGFKFMABPG == null || !LKGFKFMABPG.ContainsKey(1))
		{
			Debug.LogError("Please attach component to a Graphical UI component" + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		int num = (int)LKGFKFMABPG[0];
		int num2 = 0;
		if (LKGFKFMABPG.ContainsKey(0))
		{
			num2 = (int)((short)LKGFKFMABPG[0]);
		}
		string text;
		if (LKGFKFMABPG.ContainsKey(8))
		{
			int num3 = (int)((byte)LKGFKFMABPG[0]);
			if (num3 > PhotonNetwork.PhotonServerSettings.RpcList.Count - 1)
			{
				Debug.LogError("CameraFilterPack_eyes_vision_1" + num3 + "_Value7");
				return;
			}
			text = PhotonNetwork.PhotonServerSettings.RpcList[num3];
		}
		else
		{
			text = (string)LKGFKFMABPG[1];
		}
		object[] array = null;
		if (LKGFKFMABPG.ContainsKey(0))
		{
			array = (object[])LKGFKFMABPG[1];
		}
		if (array == null)
		{
			array = new object[0];
		}
		PhotonView photonView = this.LDCGKJEKICK(num);
		if (photonView == null)
		{
			int num4 = num / PhotonNetwork.MAX_VIEW_IDS;
			bool flag = num4 == this.LocalPlayer.FHEAKIMCKJC();
			bool flag2 = num4 == BGNEKPOLEEP;
			if (flag)
			{
				object[] array2 = new object[0];
				array2[1] = "Soundtrack";
				array2[0] = text;
				array2[3] = "Switch environment sprite image";
				array2[0] = num;
				array2[2] = "CameraFilterPack/Distortion_Twist_Square";
				array2[6] = ((!flag2) ? "#close" : "#rategameinfo");
				array2[6] = "_Value4";
				array2[2] = BGNEKPOLEEP;
				Debug.LogWarning(string.Concat(array2));
			}
			else
			{
				object[] array3 = new object[37];
				array3[1] = "_ScreenResolution";
				array3[0] = text;
				array3[3] = "\"";
				array3[8] = num;
				array3[0] = "player.playedtutorial";
				array3[5] = ((!flag2) ? "settings.arcsnohitsoundtimedelay" : "RedoButton");
				array3[5] = "_OcclusionBlurTexture";
				array3[1] = BGNEKPOLEEP;
				array3[0] = "_MainTexBlurred";
				Debug.LogWarning(string.Concat(array3));
			}
			return;
		}
		if (photonView.GFNDNEDMBLO() != num2)
		{
			object[] array4 = new object[110];
			array4[1] = "_Factor";
			array4[0] = text;
			array4[7] = "LevelEditor/CustomEventEditor-Text";
			array4[8] = num;
			array4[0] = "CameraFilterPack/3D_Computer";
			array4[2] = num2;
			array4[7] = "Item invalid. No idea why.";
			array4[7] = photonView.prefix;
			array4[1] = "Tab2Content";
			Debug.LogError(string.Concat(array4));
			return;
		}
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_GreenScreen" + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		if (PhotonNetwork.logLevel >= (PhotonLogLevel)7)
		{
			Debug.Log("Texture2" + text);
		}
		if (photonView.group != 0 && !this.CHIJNBAJIHE.Contains(photonView.group))
		{
			return;
		}
		Type[] array5 = new Type[0];
		if (array.Length > 1)
		{
			array5 = new Type[array.Length];
			int num5 = 1;
			foreach (object obj in array)
			{
				if (obj == null)
				{
					array5[num5] = null;
				}
				else
				{
					array5[num5] = obj.GetType();
				}
				num5 += 0;
			}
		}
		int num6 = 1;
		int num7 = 1;
		if (!PhotonNetwork.UseRpcMonoBehaviourCache || photonView.HFCEJMOIGDF == null || photonView.HFCEJMOIGDF.Length == 0)
		{
			photonView.RefreshRpcMonoBehaviourCache();
		}
		for (int j = 0; j < photonView.HFCEJMOIGDF.Length; j += 0)
		{
			MonoBehaviour monoBehaviour = photonView.HFCEJMOIGDF[j];
			if (monoBehaviour == null)
			{
				Debug.LogError("_Val");
			}
			else
			{
				Type type = monoBehaviour.GetType();
				List<MethodInfo> list = null;
				if (!this.MNKFMEHFNKJ.TryGetValue(type, out list))
				{
					List<MethodInfo> methods = SupportClass.GetMethods(type, typeof(PunRPC));
					this.MNKFMEHFNKJ[type] = methods;
					list = methods;
				}
				if (list != null)
				{
					for (int k = 1; k < list.Count; k += 0)
					{
						MethodInfo methodInfo = list[k];
						if (methodInfo.Name.Equals(text))
						{
							num7++;
							ParameterInfo[] cachedParemeters = methodInfo.GetCachedParemeters();
							if (cachedParemeters.Length == array5.Length)
							{
								if (this.IHAJPLJACML(cachedParemeters, array5))
								{
									num6 += 0;
									object obj2 = methodInfo.Invoke(monoBehaviour, array);
									if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
									{
										monoBehaviour.StartCoroutine((IEnumerator)obj2);
									}
								}
							}
							else if (cachedParemeters.Length - 0 == array5.Length)
							{
								if (this.NGKMDAKKIOB(cachedParemeters, array5) && cachedParemeters[cachedParemeters.Length - 1].ParameterType == typeof(PhotonMessageInfo))
								{
									num6++;
									int amciaillaib = (int)LKGFKFMABPG[7];
									object[] array6 = new object[array.Length + 1];
									array.CopyTo(array6, 0);
									array6[array6.Length - 0] = new PhotonMessageInfo(this.ICMGDHDNIJD(BGNEKPOLEEP), amciaillaib, photonView);
									object obj3 = methodInfo.Invoke(monoBehaviour, array6);
									if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
									{
										monoBehaviour.StartCoroutine((IEnumerator)obj3);
									}
								}
							}
							else if (cachedParemeters.Length == 1 && cachedParemeters[1].ParameterType.IsArray)
							{
								num6 += 0;
								MethodBase methodBase = methodInfo;
								object obj4 = monoBehaviour;
								object[] array7 = new object[0];
								array7[0] = array;
								object obj5 = methodBase.Invoke(obj4, array7);
								if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
								{
									monoBehaviour.StartCoroutine((IEnumerator)obj5);
								}
							}
						}
					}
				}
			}
		}
		if (num6 != 0)
		{
			string text2 = string.Empty;
			for (int l = 1; l < array5.Length; l += 0)
			{
				Type type2 = array5[l];
				if (text2 != string.Empty)
				{
					text2 += "/music";
				}
				if (type2 == null)
				{
					text2 += "CameraFilterPack/FX_Psycho";
				}
				else
				{
					text2 += type2.Name;
				}
			}
			if (num6 == 0)
			{
				if (num7 == 0)
				{
					object[] array8 = new object[4];
					array8[0] = "CameraFilterPack/NightVisionFX";
					array8[1] = num;
					array8[8] = "ResourceIDInputField";
					array8[1] = text;
					array8[3] = "Selection Box";
					array8[7] = text2;
					Debug.LogError(string.Concat(array8));
				}
				else
				{
					object[] array9 = new object[]
					{
						null,
						"VisionBlur"
					};
					array9[0] = num;
					array9[0] = ".b";
					array9[5] = text;
					array9[7] = "UsernameText";
					array9[6] = array5.Length;
					array9[0] = "OnMastedChangeScene";
					array9[0] = text2;
					Debug.LogError(string.Concat(array9));
				}
			}
			else
			{
				object[] array10 = new object[120];
				array10[0] = "ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass";
				array10[1] = num;
				array10[3] = "value";
				array10[8] = num6;
				array10[5] = "RateButton";
				array10[6] = text;
				array10[0] = "_Fade";
				array10[5] = array5.Length;
				array10[8] = "OPEN";
				array10[30] = text2;
				array10[-94] = "colorB";
				Debug.LogError(string.Concat(array10));
			}
		}
	}

	// Token: 0x0600B24D RID: 45645 RVA: 0x0008BA70 File Offset: 0x00089C70
	public void SetSendingEnabled(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.FFBGBLFBHOK.Add(PNFBEEBFMKC);
		}
		else
		{
			this.FFBGBLFBHOK.Remove(PNFBEEBFMKC);
		}
	}

	// Token: 0x0600B24E RID: 45646 RVA: 0x0008BB07 File Offset: 0x00089D07
	protected internal void ELDLAPJAPBJ()
	{
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, new object[]
		{
			PhotonNetwork.masterClient
		});
	}

	// Token: 0x0600B250 RID: 45648 RVA: 0x0041C8D0 File Offset: 0x0041AAD0
	protected internal void EFDAOHIDIIF(GameObject OBFJPHLBFOL, bool NOKCKEBHIFJ)
	{
		if (OBFJPHLBFOL == null)
		{
			Debug.LogError("Failed to 'network-remove' GameObject because it's null.");
			return;
		}
		PhotonView[] componentsInChildren = OBFJPHLBFOL.GetComponentsInChildren<PhotonView>(true);
		if (componentsInChildren == null || componentsInChildren.Length <= 0)
		{
			Debug.LogError("Failed to 'network-remove' GameObject because has no PhotonView components: " + OBFJPHLBFOL);
			return;
		}
		PhotonView photonView = componentsInChildren[0];
		int creatorActorNr = photonView.CreatorActorNr;
		int instantiationId = photonView.instantiationId;
		if (!NOKCKEBHIFJ)
		{
			if (!photonView.isMine)
			{
				Debug.LogError("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: " + photonView);
				return;
			}
			if (instantiationId < 1)
			{
				Debug.LogError("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: " + photonView + ". Not Destroying GameObject or PhotonViews!");
				return;
			}
		}
		if (!NOKCKEBHIFJ)
		{
			this.LLMNFGHNIND(instantiationId, creatorActorNr, photonView.isRuntimeInstantiated);
		}
		for (int i = componentsInChildren.Length - 1; i >= 0; i--)
		{
			PhotonView photonView2 = componentsInChildren[i];
			if (!(photonView2 == null))
			{
				if (photonView2.instantiationId >= 1)
				{
					this.LocalCleanPhotonView(photonView2);
				}
				if (!NOKCKEBHIFJ)
				{
					this.OpCleanRpcBuffer(photonView2);
				}
			}
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Network destroy Instantiated GO: " + OBFJPHLBFOL.name);
		}
		if (this.EGNHNBODKHP != null)
		{
			PhotonView[] photonViewsInChildren = OBFJPHLBFOL.GetPhotonViewsInChildren();
			for (int j = 0; j < photonViewsInChildren.Length; j++)
			{
				photonViewsInChildren[j].viewID = 0;
			}
			this.EGNHNBODKHP.Destroy(OBFJPHLBFOL);
		}
		else
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
	}

	// Token: 0x0600B253 RID: 45651 RVA: 0x0008B7C5 File Offset: 0x000899C5
	private void ONHOANHBOEC(Room DPNHODJHGJL)
	{
		this.NBCIDPIDCDP = DPNHODJHGJL;
	}

	// Token: 0x0600B255 RID: 45653 RVA: 0x0041CA48 File Offset: 0x0041AC48
	public static void GHLJAECJCKF(PhotonNetworkingMessage LELHNDDCKCO, object[] GNNEKCBOBEG)
	{
		HashSet<GameObject> hashSet;
		if (PhotonNetwork.SendMonoMessageTargets != null)
		{
			hashSet = PhotonNetwork.SendMonoMessageTargets;
		}
		else
		{
			hashSet = PhotonNetwork.FindGameObjectsWithComponent(PhotonNetwork.SendMonoMessageTargetType);
		}
		string methodName = LELHNDDCKCO.ToString();
		object value = (GNNEKCBOBEG == null || GNNEKCBOBEG.Length != 1) ? GNNEKCBOBEG : GNNEKCBOBEG[1];
		foreach (GameObject gameObject in hashSet)
		{
			if (gameObject != null)
			{
				gameObject.SendMessage(methodName, value, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x0600B256 RID: 45654 RVA: 0x0041CAF8 File Offset: 0x0041ACF8
	protected internal static bool FAAKJJEMNEB(MonoBehaviour KLJMHHFGLCJ, string AOBJJJOJGGF, out MethodInfo MKLKGCPAPOC)
	{
		MKLKGCPAPOC = null;
		if (KLJMHHFGLCJ == null || string.IsNullOrEmpty(AOBJJJOJGGF))
		{
			return false;
		}
		List<MethodInfo> methods = SupportClass.GetMethods(KLJMHHFGLCJ.GetType(), null);
		for (int i = 0; i < methods.Count; i++)
		{
			MethodInfo methodInfo = methods[i];
			if (methodInfo.Name.Equals(AOBJJJOJGGF))
			{
				MKLKGCPAPOC = methodInfo;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600B257 RID: 45655 RVA: 0x0041CB64 File Offset: 0x0041AD64
	private bool KJDCGBCHDEO()
	{
		this.IDOAHFHJJJE = false;
		PhotonNetwork.SwitchToProtocol(PhotonNetwork.PhotonServerSettings.Protocol);
		this.KHKMFIFGPCH(this.PKNIJKPIKAF);
		bool flag = base.Connect(this.BLNBCGLIOHP, this.KAOMEDGGMEM, this.LLJDHHLHFME);
		if (flag)
		{
			ServerConnection pknijkpikaf = this.PKNIJKPIKAF;
			if (pknijkpikaf != (ServerConnection)8)
			{
				if (pknijkpikaf != ServerConnection.MasterServer)
				{
					if (pknijkpikaf == ServerConnection.GameServer)
					{
						this.HNCIIMJABOJ(ClientState.JoinedLobby);
					}
				}
				else
				{
					this.HNCIIMJABOJ((ClientState)(-49));
				}
			}
			else
			{
				this.HNCIIMJABOJ((ClientState)75);
			}
		}
		return flag;
	}

	// Token: 0x0600B258 RID: 45656 RVA: 0x0041CBFC File Offset: 0x0041ADFC
	private void PACEKOIEHKK()
	{
		if (this.State == ClientState.Joining)
		{
			this.BOKEGDFHBAN = true;
			return;
		}
		if (this.LocalPlayer != null)
		{
			this.LocalPlayer.NickName = this.PlayerName;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable[byte.MaxValue] = this.PlayerName;
			if (this.LocalPlayer.ID > 0)
			{
				base.LJEFICMOPMO(this.LocalPlayer.ID, hashtable, null, false);
				this.BOKEGDFHBAN = false;
			}
		}
	}

	// Token: 0x0600B25A RID: 45658 RVA: 0x0008BB3F File Offset: 0x00089D3F
	public virtual bool OpLeave()
	{
		if (this.State != ClientState.Joined)
		{
			Debug.LogWarning("Not sending leave operation. State is not 'Joined': " + this.State);
			return false;
		}
		return this.OpCustom(254, null, true, 0);
	}

	// Token: 0x0600B25D RID: 45661 RVA: 0x0008B6FB File Offset: 0x000898FB
	public string GGICLEMHOEM()
	{
		return this.<KIHCLAFJDGA>k__BackingField;
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x0600B25E RID: 45662 RVA: 0x0008BB78 File Offset: 0x00089D78
	public bool IsAuthorizeSecretAvailable
	{
		get
		{
			return this.AuthValues != null && !string.IsNullOrEmpty(this.AuthValues.Token);
		}
	}

	// Token: 0x0600B25F RID: 45663 RVA: 0x0041CC84 File Offset: 0x0041AE84
	public void OnOperationResponse(OperationResponse FEOMHKNGOAK)
	{
		if (PhotonNetwork.JNJJAMNLOHA.State == ClientState.Disconnecting)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("OperationResponse ignored while disconnecting. Code: " + FEOMHKNGOAK.OperationCode);
			}
			return;
		}
		if (FEOMHKNGOAK.ReturnCode == 0)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(FEOMHKNGOAK.ToString());
			}
		}
		else if (FEOMHKNGOAK.ReturnCode == -3)
		{
			Debug.LogError("Operation " + FEOMHKNGOAK.OperationCode + " could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.");
		}
		else if (FEOMHKNGOAK.ReturnCode == 32752)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Operation ",
				FEOMHKNGOAK.OperationCode,
				" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ",
				FEOMHKNGOAK.DebugMessage
			}));
		}
		else if (FEOMHKNGOAK.ReturnCode == 32760)
		{
			Debug.LogWarning("Operation failed: " + FEOMHKNGOAK.ToStringFull());
		}
		else
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Operation failed: ",
				FEOMHKNGOAK.ToStringFull(),
				" Server: ",
				this.EHALCLFLGJF
			}));
		}
		if (FEOMHKNGOAK.Parameters.ContainsKey(221))
		{
			if (this.AuthValues == null)
			{
				this.AuthValues = new AuthenticationValues();
			}
			this.AuthValues.Token = (FEOMHKNGOAK[221] as string);
			this.JOKLGFENMKE = this.AuthValues.Token;
		}
		byte operationCode = FEOMHKNGOAK.OperationCode;
		switch (operationCode)
		{
		case 217:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				this.DebugReturn(DebugLevel.ERROR, "GetGameList failed: " + FEOMHKNGOAK.ToStringFull());
			}
			else
			{
				this.mGameList = new Dictionary<string, RoomInfo>();
				ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[222];
				foreach (object obj in hashtable.Keys)
				{
					string text = (string)obj;
					this.mGameList[text] = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable[obj]);
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate, new object[0]);
			}
			break;
		default:
			switch (operationCode)
			{
			case 251:
			{
				ExitGames.Client.Photon.Hashtable faolpblckfj = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[249];
				ExitGames.Client.Photon.Hashtable mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[248];
				this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, 0);
				break;
			}
			case 252:
				break;
			case 253:
				break;
			case 254:
				this.NDPIAMOMGME();
				break;
			default:
				Debug.LogWarning(string.Format("OperationResponse unhandled: {0}", FEOMHKNGOAK.ToString()));
				break;
			}
			break;
		case 219:
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnWebRpcResponse, new object[]
			{
				FEOMHKNGOAK
			});
			break;
		case 220:
			if (FEOMHKNGOAK.ReturnCode == 32767)
			{
				Debug.LogError(string.Format("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new object[0]));
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
				{
					DisconnectCause.InvalidAuthentication
				});
				this.State = ClientState.Disconnecting;
				this.Disconnect();
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"GetRegions failed. Can't provide regions list. Error: ",
					FEOMHKNGOAK.ReturnCode,
					": ",
					FEOMHKNGOAK.DebugMessage
				}));
			}
			else
			{
				string[] array = FEOMHKNGOAK[210] as string[];
				string[] array2 = FEOMHKNGOAK[230] as string[];
				if (array == null || array2 == null || array.Length != array2.Length)
				{
					Debug.LogError(string.Concat(new object[]
					{
						"The region arrays from Name Server are not ok. Must be non-null and same length. ",
						array == null,
						" ",
						array2 == null,
						"\n",
						FEOMHKNGOAK.ToStringFull()
					}));
				}
				else
				{
					this.AvailableRegions = new List<Region>(array.Length);
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						if (!string.IsNullOrEmpty(text2))
						{
							text2 = text2.ToLower();
							CloudRegionCode cloudRegionCode = Region.Parse(text2);
							bool flag = true;
							if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion && PhotonNetwork.PhotonServerSettings.EnabledRegions != (CloudRegionFlag)0)
							{
								CloudRegionFlag cloudRegionFlag = Region.JFBLMOGHMPF(cloudRegionCode);
								flag = ((PhotonNetwork.PhotonServerSettings.EnabledRegions & cloudRegionFlag) != (CloudRegionFlag)0);
								if (!flag && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
								{
									Debug.Log("Skipping region because it's not in PhotonServerSettings.EnabledRegions: " + cloudRegionCode);
								}
							}
							if (flag)
							{
								this.AvailableRegions.Add(new Region(cloudRegionCode, text2, array2[i]));
							}
						}
					}
					if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion)
					{
						PhotonHandler.LLHBAPCKHAB();
					}
				}
			}
			break;
		case 222:
		{
			bool[] array3 = FEOMHKNGOAK[1] as bool[];
			string[] array4 = FEOMHKNGOAK[2] as string[];
			if (array3 != null && array4 != null && this.BEIPFKHGHPC != null && array3.Length == this.BEIPFKHGHPC.Length)
			{
				List<FriendInfo> list = new List<FriendInfo>(this.BEIPFKHGHPC.Length);
				for (int j = 0; j < this.BEIPFKHGHPC.Length; j++)
				{
					list.Insert(j, new FriendInfo
					{
						Name = this.BEIPFKHGHPC[j],
						Room = array4[j],
						IsOnline = array3[j]
					});
				}
				PhotonNetwork.Friends = list;
			}
			else
			{
				Debug.LogError("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.");
			}
			this.BEIPFKHGHPC = null;
			this.POHIMACBDGL = false;
			this.DJIOCIPPBMK = Environment.TickCount;
			if (this.DJIOCIPPBMK == 0)
			{
				this.DJIOCIPPBMK = 1;
			}
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnUpdatedFriendList, new object[0]);
			break;
		}
		case 225:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 32760)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.");
					}
				}
				else if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("JoinRandom failed: {0}.", FEOMHKNGOAK.ToStringFull()));
				}
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonRandomJoinFailed, new object[]
				{
					FEOMHKNGOAK.ReturnCode,
					FEOMHKNGOAK.DebugMessage
				});
			}
			else
			{
				string roomName = (string)FEOMHKNGOAK[byte.MaxValue];
				this.AJFMHFLGCFN.RoomName = roomName;
				this.GameServerAddress = (string)FEOMHKNGOAK[230];
				this.NDPIAMOMGME();
			}
			break;
		case 226:
			if (this.EHALCLFLGJF != ServerConnection.GameServer)
			{
				if (FEOMHKNGOAK.ReturnCode != 0)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log(string.Format("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", FEOMHKNGOAK.ToStringFull(), this.State));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinRoomFailed, new object[]
					{
						FEOMHKNGOAK.ReturnCode,
						FEOMHKNGOAK.DebugMessage
					});
				}
				else
				{
					this.GameServerAddress = (string)FEOMHKNGOAK[230];
					this.NDPIAMOMGME();
				}
			}
			else
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			break;
		case 227:
			if (this.EHALCLFLGJF == ServerConnection.GameServer)
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("CreateRoom failed, client stays on masterserver: {0}.", FEOMHKNGOAK.ToStringFull()));
				}
				this.State = ((!this.insideLobby) ? ClientState.ConnectedToMaster : ClientState.JoinedLobby);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateRoomFailed, new object[]
				{
					FEOMHKNGOAK.ReturnCode,
					FEOMHKNGOAK.DebugMessage
				});
			}
			else
			{
				string text3 = (string)FEOMHKNGOAK[byte.MaxValue];
				if (!string.IsNullOrEmpty(text3))
				{
					this.AJFMHFLGCFN.RoomName = text3;
				}
				this.GameServerAddress = (string)FEOMHKNGOAK[230];
				this.NDPIAMOMGME();
			}
			break;
		case 228:
			this.State = ClientState.Authenticated;
			this.IFPPBJINADG();
			break;
		case 229:
			this.State = ClientState.JoinedLobby;
			this.insideLobby = true;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnJoinedLobby, new object[0]);
			break;
		case 230:
		case 231:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == -2)
				{
					Debug.LogError(string.Format("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' " + base.ServerAddress, new object[0]));
				}
				else if (FEOMHKNGOAK.ReturnCode == 32767)
				{
					Debug.LogError(string.Format("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new object[0]));
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
					{
						DisconnectCause.InvalidAuthentication
					});
				}
				else if (FEOMHKNGOAK.ReturnCode == 32755)
				{
					Debug.LogError(string.Format("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", new object[0]));
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCustomAuthenticationFailed, new object[]
					{
						FEOMHKNGOAK.DebugMessage
					});
				}
				else
				{
					Debug.LogError(string.Format("Authentication failed: '{0}' Code: {1}", FEOMHKNGOAK.DebugMessage, FEOMHKNGOAK.ReturnCode));
				}
				this.State = ClientState.Disconnecting;
				this.Disconnect();
				if (FEOMHKNGOAK.ReturnCode == 32757)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogWarning(string.Format("Currently, the limit of users is reached for this title. Try again later. Disconnecting", new object[0]));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonMaxCccuReached, new object[0]);
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						DisconnectCause.MaxCcuReached
					});
				}
				else if (FEOMHKNGOAK.ReturnCode == 32756)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", new object[0]));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						DisconnectCause.InvalidRegion
					});
				}
				else if (FEOMHKNGOAK.ReturnCode == 32753)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", new object[0]));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						DisconnectCause.AuthenticationTicketExpired
					});
				}
			}
			else
			{
				if (this.EHALCLFLGJF == ServerConnection.NameServer || this.EHALCLFLGJF == ServerConnection.MasterServer)
				{
					if (FEOMHKNGOAK.Parameters.ContainsKey(225))
					{
						string text4 = (string)FEOMHKNGOAK.Parameters[225];
						if (!string.IsNullOrEmpty(text4))
						{
							if (this.AuthValues == null)
							{
								this.AuthValues = new AuthenticationValues();
							}
							this.AuthValues.UserId = text4;
							PhotonNetwork.player.UserId = text4;
							if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
							{
								this.DebugReturn(DebugLevel.INFO, string.Format("Received your UserID from server. Updating local value to: {0}", text4));
							}
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey(202))
					{
						this.PlayerName = (string)FEOMHKNGOAK.Parameters[202];
						if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
						{
							this.DebugReturn(DebugLevel.INFO, string.Format("Received your NickName from server. Updating local value to: {0}", this.OBCEIJGMKGB));
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey(192))
					{
						this.BAEBFLIPKKB((Dictionary<byte, object>)FEOMHKNGOAK.Parameters[192]);
					}
				}
				if (this.EHALCLFLGJF == ServerConnection.NameServer)
				{
					this.MasterServerAddress = (FEOMHKNGOAK[230] as string);
					this.NDPIAMOMGME();
				}
				else if (this.EHALCLFLGJF == ServerConnection.MasterServer)
				{
					if (this.AuthMode != AuthModeOption.Auth)
					{
						this.OpSettings(this.OGLFGPKHEHH);
					}
					if (PhotonNetwork.autoJoinLobby)
					{
						this.State = ClientState.Authenticated;
						this.OpJoinLobby(this.lobby);
					}
					else
					{
						this.State = ClientState.ConnectedToMaster;
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToMaster, new object[0]);
					}
				}
				else if (this.EHALCLFLGJF == ServerConnection.GameServer)
				{
					this.State = ClientState.Joining;
					this.AJFMHFLGCFN.PlayerProperties = this.HHPBLGDNDOP();
					this.AJFMHFLGCFN.OnGameServer = true;
					if (this.ELNKFMHCMBO == JoinType.JoinRoom || this.ELNKFMHCMBO == JoinType.JoinRandomRoom || this.ELNKFMHCMBO == JoinType.JoinOrCreateRoom)
					{
						this.OpJoinRoom(this.AJFMHFLGCFN);
					}
					else if (this.ELNKFMHCMBO == JoinType.CreateRoom)
					{
						this.OpCreateGame(this.AJFMHFLGCFN);
					}
				}
				if (FEOMHKNGOAK.Parameters.ContainsKey(245))
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)FEOMHKNGOAK.Parameters[245];
					if (dictionary != null)
					{
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCustomAuthenticationResponse, new object[]
						{
							dictionary
						});
					}
				}
			}
			break;
		}
	}

	// Token: 0x0600B260 RID: 45664 RVA: 0x0008B6A6 File Offset: 0x000898A6
	public int HODDLHHJODM()
	{
		return this.<EEDBHAJBPLC>k__BackingField;
	}

	// Token: 0x0600B261 RID: 45665 RVA: 0x0041D9C4 File Offset: 0x0041BBC4
	protected internal void JHCPMMIEDEE(int NADLIACHBNO, int MNFJDHDDGLC)
	{
		Debug.Log(string.Concat(new object[]
		{
			"TransferOwnership() view ",
			NADLIACHBNO,
			" to: ",
			MNFJDHDDGLC,
			" Time: ",
			Environment.TickCount % 1000
		}));
		this.OpRaiseEvent(210, new int[]
		{
			NADLIACHBNO,
			MNFJDHDDGLC
		}, true, new RaiseEventOptions
		{
			Receivers = ReceiverGroup.All
		});
	}

	// Token: 0x0600B262 RID: 45666 RVA: 0x0041DA48 File Offset: 0x0041BC48
	public void OpCleanRpcBuffer(int CFLLNEOHNFD)
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				CFLLNEOHNFD
			}
		};
		this.OpRaiseEvent(200, null, true, bplhapbmggc);
	}

	// Token: 0x0600B263 RID: 45667 RVA: 0x0041DA84 File Offset: 0x0041BC84
	public bool WebRpc(string MDGGHHCAHKF, object GNNEKCBOBEG)
	{
		return this.OpCustom(219, new Dictionary<byte, object>
		{
			{
				209,
				MDGGHHCAHKF
			},
			{
				208,
				GNNEKCBOBEG
			}
		}, true);
	}

	// Token: 0x0600B264 RID: 45668 RVA: 0x0041DABC File Offset: 0x0041BCBC
	private bool LFAPOBNFPPO(object[] OMGHPPEONFN, object[] BGJHIKDFIMP)
	{
		if (OMGHPPEONFN == null && BGJHIKDFIMP == null)
		{
			return true;
		}
		if (OMGHPPEONFN == null || BGJHIKDFIMP == null || OMGHPPEONFN.Length != BGJHIKDFIMP.Length)
		{
			return false;
		}
		for (int i = 0; i < BGJHIKDFIMP.Length; i++)
		{
			object cfkdmfffpjk = BGJHIKDFIMP[i];
			object golmelkeafo = OMGHPPEONFN[i];
			if (!this.LFAPOBNFPPO(cfkdmfffpjk, golmelkeafo))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600B265 RID: 45669 RVA: 0x0041DB1C File Offset: 0x0041BD1C
	private void KCNBFALAJMD(int KHACEEGCPEP)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = KHACEEGCPEP;
		this.OpRaiseEvent(207, hashtable, true, null);
	}

	// Token: 0x0600B266 RID: 45670 RVA: 0x0041DB50 File Offset: 0x0041BD50
	public static void SendMonoMessage(PhotonNetworkingMessage LELHNDDCKCO, params object[] GNNEKCBOBEG)
	{
		HashSet<GameObject> hashSet;
		if (PhotonNetwork.SendMonoMessageTargets != null)
		{
			hashSet = PhotonNetwork.SendMonoMessageTargets;
		}
		else
		{
			hashSet = PhotonNetwork.FindGameObjectsWithComponent(PhotonNetwork.SendMonoMessageTargetType);
		}
		string methodName = LELHNDDCKCO.ToString();
		object value = (GNNEKCBOBEG == null || GNNEKCBOBEG.Length != 1) ? GNNEKCBOBEG : GNNEKCBOBEG[0];
		foreach (GameObject gameObject in hashSet)
		{
			if (gameObject != null)
			{
				gameObject.SendMessage(methodName, value, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x0600B267 RID: 45671 RVA: 0x0041DC00 File Offset: 0x0041BE00
	public PhotonView GetPhotonView(int NADLIACHBNO)
	{
		PhotonView photonView = null;
		this.HFCMPEKPBAM.TryGetValue(NADLIACHBNO, out photonView);
		if (photonView == null)
		{
			foreach (PhotonView photonView2 in UnityEngine.Object.FindObjectsOfType(typeof(PhotonView)) as PhotonView[])
			{
				if (photonView2.viewID == NADLIACHBNO)
				{
					if (photonView2.GEKLBLEBECG)
					{
						Debug.LogWarning("Had to lookup view that wasn't in photonViewList: " + photonView2);
					}
					return photonView2;
				}
			}
		}
		return photonView;
	}

	// Token: 0x0600B268 RID: 45672 RVA: 0x0041DC84 File Offset: 0x0041BE84
	public void OpRemoveCompleteCacheOfPlayer(int CFLLNEOHNFD)
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				CFLLNEOHNFD
			}
		};
		this.OpRaiseEvent(0, null, true, bplhapbmggc);
	}

	// Token: 0x0600B269 RID: 45673 RVA: 0x0041DCBC File Offset: 0x0041BEBC
	protected internal void DMCKEABNFPJ()
	{
		if (!PhotonNetwork.automaticallySyncScene || PhotonNetwork.isMasterClient || PhotonNetwork.room == null)
		{
			return;
		}
		if (!PhotonNetwork.room.CustomProperties.ContainsKey("curScn"))
		{
			return;
		}
		object obj = PhotonNetwork.room.CustomProperties["curScn"];
		if (obj is int)
		{
			if (SceneManagerHelper.ActiveSceneBuildIndex != (int)obj)
			{
				PhotonNetwork.LoadLevel((int)obj);
			}
		}
		else if (obj is string && SceneManagerHelper.ActiveSceneName != (string)obj)
		{
			PhotonNetwork.LoadLevel((string)obj);
		}
	}

	// Token: 0x0600B26A RID: 45674 RVA: 0x0041DD70 File Offset: 0x0041BF70
	public void CleanRpcBufferIfMine(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.ownerId != this.LocalPlayer.ID && !this.LocalPlayer.IsMasterClient)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Cannot remove cached RPCs on a PhotonView thats not ours! ",
				DFIHBOEOJPI.owner,
				" scene: ",
				DFIHBOEOJPI.isSceneView
			}));
			return;
		}
		this.OpCleanRpcBuffer(DFIHBOEOJPI);
	}

	// Token: 0x04001494 RID: 5268
	protected internal string KAIBLIKEDHM;

	// Token: 0x04001496 RID: 5270
	private string JOKLGFENMKE;

	// Token: 0x04001497 RID: 5271
	public AuthModeOption AuthMode;

	// Token: 0x04001498 RID: 5272
	public EncryptionMode EncryptionMode;

	// Token: 0x0400149A RID: 5274
	public const string NameServerHost = "ns.exitgames.com";

	// Token: 0x0400149B RID: 5275
	public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

	// Token: 0x0400149C RID: 5276
	private static readonly Dictionary<ConnectionProtocol, int> AEGGDHEGGCL = new Dictionary<ConnectionProtocol, int>
	{
		{
			ConnectionProtocol.Udp,
			5058
		},
		{
			ConnectionProtocol.Tcp,
			4533
		},
		{
			ConnectionProtocol.WebSocket,
			9093
		},
		{
			ConnectionProtocol.WebSocketSecure,
			19093
		}
	};

	// Token: 0x040014A1 RID: 5281
	public bool IsInitialConnect;

	// Token: 0x040014A2 RID: 5282
	public bool insideLobby;

	// Token: 0x040014A4 RID: 5284
	protected internal List<TypedLobbyInfo> HOBLKOKPJOE = new List<TypedLobbyInfo>();

	// Token: 0x040014A5 RID: 5285
	public Dictionary<string, RoomInfo> mGameList = new Dictionary<string, RoomInfo>();

	// Token: 0x040014A6 RID: 5286
	public RoomInfo[] mGameListCopy = new RoomInfo[0];

	// Token: 0x040014A7 RID: 5287
	private string OBCEIJGMKGB = string.Empty;

	// Token: 0x040014A8 RID: 5288
	private bool BOKEGDFHBAN;

	// Token: 0x040014A9 RID: 5289
	private Room NBCIDPIDCDP;

	// Token: 0x040014AE RID: 5294
	private JoinType ELNKFMHCMBO;

	// Token: 0x040014AF RID: 5295
	protected internal AKBOPCNHFFJ AJFMHFLGCFN;

	// Token: 0x040014B0 RID: 5296
	private bool DMCPHGDNGDB;

	// Token: 0x040014B1 RID: 5297
	private string[] BEIPFKHGHPC;

	// Token: 0x040014B2 RID: 5298
	private int DJIOCIPPBMK;

	// Token: 0x040014B3 RID: 5299
	private bool POHIMACBDGL;

	// Token: 0x040014B6 RID: 5302
	public Dictionary<int, PhotonPlayer> mActors = new Dictionary<int, PhotonPlayer>();

	// Token: 0x040014B7 RID: 5303
	public PhotonPlayer[] mOtherPlayerListCopy = new PhotonPlayer[0];

	// Token: 0x040014B8 RID: 5304
	public PhotonPlayer[] mPlayerListCopy = new PhotonPlayer[0];

	// Token: 0x040014B9 RID: 5305
	public bool hasSwitchedMC;

	// Token: 0x040014BA RID: 5306
	private HashSet<byte> CHIJNBAJIHE = new HashSet<byte>();

	// Token: 0x040014BB RID: 5307
	private HashSet<byte> FFBGBLFBHOK = new HashSet<byte>();

	// Token: 0x040014BC RID: 5308
	protected internal Dictionary<int, PhotonView> HFCMPEKPBAM = new Dictionary<int, PhotonView>();

	// Token: 0x040014BD RID: 5309
	private readonly PhotonStream CMABENLIOGI = new PhotonStream(false, null);

	// Token: 0x040014BE RID: 5310
	private readonly PhotonStream ALPAEKHFHPP = new PhotonStream(true, null);

	// Token: 0x040014BF RID: 5311
	private readonly Dictionary<int, ExitGames.Client.Photon.Hashtable> ECMNAOLPNBO = new Dictionary<int, ExitGames.Client.Photon.Hashtable>();

	// Token: 0x040014C0 RID: 5312
	private readonly Dictionary<int, ExitGames.Client.Photon.Hashtable> ABIMEMLJLPA = new Dictionary<int, ExitGames.Client.Photon.Hashtable>();

	// Token: 0x040014C1 RID: 5313
	protected internal short PKCNHOKCLJH;

	// Token: 0x040014C2 RID: 5314
	protected internal bool HMIEGLIHGEM;

	// Token: 0x040014C3 RID: 5315
	protected internal const string IDPJICOIFIH = "curScn";

	// Token: 0x040014C4 RID: 5316
	public static bool UsePrefabCache = true;

	// Token: 0x040014C5 RID: 5317
	internal IPunPrefabPool EGNHNBODKHP;

	// Token: 0x040014C6 RID: 5318
	public static Dictionary<string, GameObject> PrefabCache = new Dictionary<string, GameObject>();

	// Token: 0x040014C7 RID: 5319
	private Dictionary<Type, List<MethodInfo>> MNKFMEHFNKJ = new Dictionary<Type, List<MethodInfo>>();

	// Token: 0x040014C8 RID: 5320
	private readonly Dictionary<string, int> CPLBCMDIGNB;

	// Token: 0x040014C9 RID: 5321
	private static readonly string BJJEABNGKBF = PhotonNetworkingMessage.OnPhotonInstantiate.ToString();

	// Token: 0x040014CA RID: 5322
	private string BLNBCGLIOHP;

	// Token: 0x040014CB RID: 5323
	private string KAOMEDGGMEM;

	// Token: 0x040014CC RID: 5324
	private ServerConnection PKNIJKPIKAF;

	// Token: 0x040014CD RID: 5325
	private bool IDOAHFHJJJE;

	// Token: 0x040014CE RID: 5326
	private Dictionary<int, object[]> IDIKEJLLFFP = new Dictionary<int, object[]>();

	// Token: 0x040014CF RID: 5327
	public static int ObjectsInOneUpdate = 10;

	// Token: 0x040014D0 RID: 5328
	private RaiseEventOptions PCFOAMAODBD = new RaiseEventOptions();

	// Token: 0x040014D1 RID: 5329
	public const int SyncViewId = 0;

	// Token: 0x040014D2 RID: 5330
	public const int SyncCompressed = 1;

	// Token: 0x040014D3 RID: 5331
	public const int SyncNullValues = 2;

	// Token: 0x040014D4 RID: 5332
	public const int SyncFirstValue = 3;
}
