/*
Importance of this class: Likely unusued

Purpose of this class: Connect to random multiplayer room base class?

Deobf status: Bad
*/

using System;
using Photon;
using UnityEngine;

// Token: 0x0200033C RID: 828
public class ConnectAndJoinRandom : Photon.MonoBehaviour
{
	// Token: 0x0600BBA3 RID: 48035 RVA: 0x0008F5B8 File Offset: 0x0008D7B8
	public void CHLAEFHCKEO()
	{
		Debug.Log("_Value");
	}

	// Token: 0x0600BBA4 RID: 48036 RVA: 0x0008F5C4 File Offset: 0x0008D7C4
	public void OnJoinedRoom()
	{
		Debug.Log("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");
	}

	// Token: 0x0600BBA5 RID: 48037 RVA: 0x0008F5D0 File Offset: 0x0008D7D0
	public virtual void EDCHDNKMIIC()
	{
		Debug.Log("win");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBA6 RID: 48038 RVA: 0x0008F5E2 File Offset: 0x0008D7E2
	public virtual void DKOPKPBLDHH()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	// Token: 0x0600BBA7 RID: 48039 RVA: 0x0008F5EA File Offset: 0x0008D7EA
	public virtual void JKAKGAKGIJM(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(".lastCheckpoint.incorrectScore" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBA8 RID: 48040 RVA: 0x0008F601 File Offset: 0x0008D801
	public virtual void JEKHFJLBNGG()
	{
		Debug.Log("_Value");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBA9 RID: 48041 RVA: 0x0008F613 File Offset: 0x0008D813
	public virtual void HDPJHKKEBAP()
	{
		Debug.Log("0.00");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBAA RID: 48042 RVA: 0x0008F625 File Offset: 0x0008D825
	public void KJIFILNIJIH()
	{
		Debug.Log("[MapEditor] Exported to ");
	}

	// Token: 0x0600BBAB RID: 48043 RVA: 0x0008F631 File Offset: 0x0008D831
	public virtual void FOADJANPIBI()
	{
		Debug.Log("_ChangeGreen");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBAC RID: 48044 RVA: 0x00443980 File Offset: 0x00441B80
	public virtual void Update()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();");
			this.IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(this.Version + "." + SceneManagerHelper.ActiveSceneBuildIndex);
		}
	}

	// Token: 0x0600BBAD RID: 48045 RVA: 0x0008F643 File Offset: 0x0008D843
	public void LGHDAPHGGKG()
	{
		Debug.Log("menu.selectedlevelid");
	}

	// Token: 0x0600BBAE RID: 48046 RVA: 0x0008F64F File Offset: 0x0008D84F
	public void HJBBKKKMCLH()
	{
		Debug.Log("13");
	}

	// Token: 0x0600BBAF RID: 48047 RVA: 0x0008F65B File Offset: 0x0008D85B
	public void BDKAKHFLAKD()
	{
		Debug.Log(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.");
	}

	// Token: 0x0600BBB0 RID: 48048 RVA: 0x0008F667 File Offset: 0x0008D867
	public virtual void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("Cause: " + BMDDEFBNHAL);
	}

	// Token: 0x0600BBB1 RID: 48049 RVA: 0x0008F67E File Offset: 0x0008D87E
	public virtual void GDDGKGCDKDP()
	{
		Debug.Log(" Message: ");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBB2 RID: 48050 RVA: 0x004439E4 File Offset: 0x00441BE4
	public virtual void EOGBNCKOOFC()
	{
		Debug.Log("menu.copyright");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 2
		}, null);
	}

	// Token: 0x0600BBB3 RID: 48051 RVA: 0x0008F690 File Offset: 0x0008D890
	public virtual void FDFBJFKIAHD()
	{
		Debug.Log("_TimeX");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBB4 RID: 48052 RVA: 0x0008F6A2 File Offset: 0x0008D8A2
	public virtual void CHDPOPKEINF()
	{
		Debug.Log("ConfigVersionSlider");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBB5 RID: 48053 RVA: 0x00443A14 File Offset: 0x00441C14
	public virtual void OnPhotonRandomJoinFailed()
	{
		Debug.Log("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 4
		}, null);
	}

	// Token: 0x0600BBB6 RID: 48054 RVA: 0x0007DCB5 File Offset: 0x0007BEB5
	public void LJBIAHLMGOO()
	{
		Debug.Log("_TimeX");
	}

	// Token: 0x0600BBB7 RID: 48055 RVA: 0x0008F6B4 File Offset: 0x0008D8B4
	public virtual void PIFDBALMCFG(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("hidden" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBB8 RID: 48056 RVA: 0x0008F6CB File Offset: 0x0008D8CB
	public virtual void AICGHDMKIPD(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(": " + BMDDEFBNHAL);
	}

	// Token: 0x0600BBB9 RID: 48057 RVA: 0x0008F6E2 File Offset: 0x0008D8E2
	public void ONDMIDMACBE()
	{
		Debug.Log("settings.crosshairopacity");
	}

	// Token: 0x0600BBBA RID: 48058 RVA: 0x0008F6EE File Offset: 0x0008D8EE
	public virtual void DPCGDHKDHME(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_EmissionGain" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBBB RID: 48059 RVA: 0x0008F705 File Offset: 0x0008D905
	public virtual void CEKMOLLPHOC()
	{
		Debug.Log("Set satellite beat detection sensitivity");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBBC RID: 48060 RVA: 0x0008F717 File Offset: 0x0008D917
	public void FACGFPDFHBL()
	{
		Debug.Log("Feb");
	}

	// Token: 0x0600BBBD RID: 48061 RVA: 0x0008F723 File Offset: 0x0008D923
	public virtual void CPPKKMBGKAP(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_Value4" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBBE RID: 48062 RVA: 0x00443A44 File Offset: 0x00441C44
	public virtual void DODDDMCNOKJ()
	{
		Debug.Log("_Distortion");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 7
		}, null);
	}

	// Token: 0x0600BBBF RID: 48063 RVA: 0x00443A74 File Offset: 0x00441C74
	public virtual void MDCFIHDPLIG()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("Editor/");
			this.IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(this.Version + "Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()" + SceneManagerHelper.POHFFGEDEAF());
		}
	}

	// Token: 0x0600BBC0 RID: 48064 RVA: 0x00443AD8 File Offset: 0x00441CD8
	public virtual void BDFFMKGNDJE()
	{
		Debug.Log("_ProjectToPixelMatrix");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 3
		}, null);
	}

	// Token: 0x0600BBC1 RID: 48065 RVA: 0x0008F73A File Offset: 0x0008D93A
	public virtual void IIOGBEKDFAO()
	{
		Debug.Log(". The group number should be at least 1.");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBC2 RID: 48066 RVA: 0x0008F74C File Offset: 0x0008D94C
	public void JAMJOIHHLMG()
	{
		Debug.Log("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ");
	}

	// Token: 0x0600BBC3 RID: 48067 RVA: 0x00443B08 File Offset: 0x00441D08
	public virtual void ADKHHMPFPIE()
	{
		Debug.Log("GameScene");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 6
		}, null);
	}

	// Token: 0x0600BBC4 RID: 48068 RVA: 0x0008F758 File Offset: 0x0008D958
	public virtual void OCLFNGINGPN()
	{
		Debug.Log("Fade");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBC5 RID: 48069 RVA: 0x0008F76A File Offset: 0x0008D96A
	public virtual void JDJLABNKBJG()
	{
		Debug.Log("player.bluearc");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBC6 RID: 48070 RVA: 0x0008F77C File Offset: 0x0008D97C
	public virtual void PIHNFEGIHOM(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("No Name" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBC8 RID: 48072 RVA: 0x0008F7B0 File Offset: 0x0008D9B0
	public virtual void JKFDDNMPOJH()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BBC9 RID: 48073 RVA: 0x0008F7B8 File Offset: 0x0008D9B8
	public virtual void KHLMJJNOBOF()
	{
		Debug.Log("IconFileSelector");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBCA RID: 48074 RVA: 0x0008F7B0 File Offset: 0x0008D9B0
	public virtual void FHGKIOOMMOH()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BBCB RID: 48075 RVA: 0x00443B38 File Offset: 0x00441D38
	public virtual void MECJHOJPODB()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_ScreenResolution");
			this.IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(this.Version + ".completedCount" + SceneManagerHelper.AKDJMHNDCBO());
		}
	}

	// Token: 0x0600BBCC RID: 48076 RVA: 0x0008F7CA File Offset: 0x0008D9CA
	public void MBBBDIIIOFC()
	{
		Debug.Log("_Value4");
	}

	// Token: 0x0600BBCD RID: 48077 RVA: 0x0008F723 File Offset: 0x0008D923
	public virtual void GEHACFFGLBI(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_Value4" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBCE RID: 48078 RVA: 0x00443B9C File Offset: 0x00441D9C
	public virtual void GFNEMBOAHIF()
	{
		Debug.Log("MainButton");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 2
		}, null);
	}

	// Token: 0x0600BBCF RID: 48079 RVA: 0x0008F7D6 File Offset: 0x0008D9D6
	public virtual void KACKAMLHICO()
	{
		Debug.Log("_UserLutParams");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBD0 RID: 48080 RVA: 0x00443BCC File Offset: 0x00441DCC
	public virtual void BAMLNAEDCKM()
	{
		Debug.Log("_Distortion");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 4
		}, null);
	}

	// Token: 0x0600BBD1 RID: 48081 RVA: 0x00443BFC File Offset: 0x00441DFC
	public virtual void EHCGBJDFMHG()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("y");
			this.IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(this.Version + "SingleplayerButton" + SceneManagerHelper.DFNPAKFIHLA());
		}
	}

	// Token: 0x0600BBD2 RID: 48082 RVA: 0x0008F7E8 File Offset: 0x0008D9E8
	public virtual void HMFNLECAOOI()
	{
		Debug.Log("[Up-Right-Left]");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBD3 RID: 48083 RVA: 0x0008F7FA File Offset: 0x0008D9FA
	public virtual void DMPFMJNADPE()
	{
		Debug.Log("BlockCount");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBD4 RID: 48084 RVA: 0x0008F80C File Offset: 0x0008DA0C
	public void CDDBANKMALP()
	{
		Debug.Log(".lastCheckpoint.powerupsScore");
	}

	// Token: 0x0600BBD5 RID: 48085 RVA: 0x0008F818 File Offset: 0x0008DA18
	public void PLEDKHBAIAA()
	{
		Debug.Log("Load Game");
	}

	// Token: 0x0600BBD6 RID: 48086 RVA: 0x00443C60 File Offset: 0x00441E60
	public virtual void BKGPGINIGNI()
	{
		Debug.Log("_Circle");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 3
		}, null);
	}

	// Token: 0x0600BBD7 RID: 48087 RVA: 0x0008F824 File Offset: 0x0008DA24
	public virtual void BJMKOOAEMKO(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("[LevelEditorScene] Exported to " + BMDDEFBNHAL);
	}

	// Token: 0x0600BBD8 RID: 48088 RVA: 0x00443C90 File Offset: 0x00441E90
	public virtual void LEAHIBJDMBI()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_EmissionGain");
			this.IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(this.Version + "BadgeText" + SceneManagerHelper.EEGMAAFDFFB());
		}
	}

	// Token: 0x0600BBD9 RID: 48089 RVA: 0x00443CF4 File Offset: 0x00441EF4
	public virtual void OECLABNKGLA()
	{
		Debug.Log("float,0");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 0
		}, null);
	}

	// Token: 0x0600BBDA RID: 48090 RVA: 0x0008F83B File Offset: 0x0008DA3B
	public virtual void KLNNHMBIBOF(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_DiffuseColor" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBDB RID: 48091 RVA: 0x0008F852 File Offset: 0x0008DA52
	public virtual void ENPAMMGKEOP()
	{
		Debug.Log("_Value2");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBDC RID: 48092 RVA: 0x0008F864 File Offset: 0x0008DA64
	public virtual void KNLFHKBNBOD()
	{
		Debug.Log("SetSpeed");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBDD RID: 48093 RVA: 0x0008F876 File Offset: 0x0008DA76
	public virtual void LBJNODGBDME(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("[LevelEditorScene] Error: I/O Failure! :(" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBDE RID: 48094 RVA: 0x0008F88D File Offset: 0x0008DA8D
	public virtual void OnConnectedToMaster()
	{
		Debug.Log("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBDF RID: 48095 RVA: 0x0008F89F File Offset: 0x0008DA9F
	public virtual void GHKONEJJHMI(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("3d text" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBE0 RID: 48096 RVA: 0x0008F8B6 File Offset: 0x0008DAB6
	public virtual void MDMLFBLLIDG(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("LivesSlider" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBE1 RID: 48097 RVA: 0x0008F8CD File Offset: 0x0008DACD
	public void EEKBPIMIOAF()
	{
		Debug.Log("LevelEditor/CustomEventEditor-Text");
	}

	// Token: 0x0600BBE2 RID: 48098 RVA: 0x0008F8D9 File Offset: 0x0008DAD9
	public virtual void KNIFJMBBDBC()
	{
		Debug.Log(" is muted");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBE3 RID: 48099 RVA: 0x00443D24 File Offset: 0x00441F24
	public virtual void JJLCCMBFHDF()
	{
		Debug.Log("_ScreenResolution");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 1
		}, null);
	}

	// Token: 0x0600BBE4 RID: 48100 RVA: 0x0008F5E2 File Offset: 0x0008D7E2
	public virtual void Start()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	// Token: 0x0600BBE5 RID: 48101 RVA: 0x0008F7B0 File Offset: 0x0008D9B0
	public virtual void HDMDKOKOOJC()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BBE6 RID: 48102 RVA: 0x0008F8EB File Offset: 0x0008DAEB
	public virtual void MOBFDKFDHGN()
	{
		Debug.Log("CameraFilterPack/Drawing_Paper");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBE7 RID: 48103 RVA: 0x00443D54 File Offset: 0x00441F54
	public virtual void BMODOIJGIOO()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_TimeX");
			this.IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(this.Version + "settings.showHP" + SceneManagerHelper.DFNPAKFIHLA());
		}
	}

	// Token: 0x0600BBE8 RID: 48104 RVA: 0x0008F8FD File Offset: 0x0008DAFD
	public virtual void CJLPBOCGBLF(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("y" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBE9 RID: 48105 RVA: 0x0008F914 File Offset: 0x0008DB14
	public void IMPGHNBKJAE()
	{
		Debug.Log(":\n");
	}

	// Token: 0x0600BBEA RID: 48106 RVA: 0x0008F920 File Offset: 0x0008DB20
	public virtual void CGHHMLOOHCI(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("Default UI Material" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBEB RID: 48107 RVA: 0x00443DB8 File Offset: 0x00441FB8
	public virtual void PKGJJFIFLII()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_Value7");
			this.IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(this.Version + "shader.future" + SceneManagerHelper.DFNPAKFIHLA());
		}
	}

	// Token: 0x0600BBEC RID: 48108 RVA: 0x0008F937 File Offset: 0x0008DB37
	public virtual void LFNJEGMCDOP()
	{
		Debug.Log("SUCCESS! Item submitted! :D :D :D");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBED RID: 48109 RVA: 0x0008F949 File Offset: 0x0008DB49
	public virtual void CCMEIDEFLPA()
	{
		Debug.Log("_Green_R");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBEE RID: 48110 RVA: 0x0008F95B File Offset: 0x0008DB5B
	public virtual void CDLHKKEOADJ()
	{
		Debug.Log("_Value5");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBEF RID: 48111 RVA: 0x0008F96D File Offset: 0x0008DB6D
	public virtual void FMJEFGEDCDC(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(".completed" + BMDDEFBNHAL);
	}

	// Token: 0x0600BBF0 RID: 48112 RVA: 0x0008F984 File Offset: 0x0008DB84
	public virtual void OnJoinedLobby()
	{
		Debug.Log("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBF1 RID: 48113 RVA: 0x0008F5E2 File Offset: 0x0008D7E2
	public virtual void HIPEHGNBJMN()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	// Token: 0x0600BBF2 RID: 48114 RVA: 0x0008F996 File Offset: 0x0008DB96
	public virtual void EBPNGJOJALB()
	{
		Debug.Log("OnRelease");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBF3 RID: 48115 RVA: 0x00443E1C File Offset: 0x0044201C
	public virtual void LDDKCCMHMIC()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_Value13");
			this.IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(this.Version + "DPADHOR" + SceneManagerHelper.EEGMAAFDFFB());
		}
	}

	// Token: 0x0600BBF4 RID: 48116 RVA: 0x0008F9A8 File Offset: 0x0008DBA8
	public virtual void NPKFIAGKGAN()
	{
		Debug.Log("connect");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBF5 RID: 48117 RVA: 0x00443E80 File Offset: 0x00442080
	public virtual void AIJGAJIOJDJ()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log(" not exist");
			this.IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(this.Version + "[DiscordController] Shutdown" + SceneManagerHelper.POHFFGEDEAF());
		}
	}

	// Token: 0x0600BBF6 RID: 48118 RVA: 0x0008F9BA File Offset: 0x0008DBBA
	public virtual void CLOFNBEGCJO()
	{
		Debug.Log("[NetworkManager] Connection failed: ");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBF7 RID: 48119 RVA: 0x0008F5E2 File Offset: 0x0008D7E2
	public virtual void BGDPIHMAACO()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	// Token: 0x0600BBF8 RID: 48120 RVA: 0x0008F9CC File Offset: 0x0008DBCC
	public virtual void AKAFCLCCHFG()
	{
		Debug.Log("[Left]");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBF9 RID: 48121 RVA: 0x0008F9DE File Offset: 0x0008DBDE
	public void OLFOHNNDHMK()
	{
		Debug.Log("_Noise");
	}

	// Token: 0x0600BBFA RID: 48122 RVA: 0x0008F9EA File Offset: 0x0008DBEA
	public virtual void PFCHOPCKCCL()
	{
		Debug.Log(".lastCheckpoint.checkpointsUsed");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBFB RID: 48123 RVA: 0x0008F9FC File Offset: 0x0008DBFC
	public virtual void PKPHEOCKKJJ()
	{
		Debug.Log("MenuScene");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBFC RID: 48124 RVA: 0x0008F5E2 File Offset: 0x0008D7E2
	public virtual void OKLAJINHPAN()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	// Token: 0x0600BBFD RID: 48125 RVA: 0x0008F7B0 File Offset: 0x0008D9B0
	public virtual void LGHCJCFHEMF()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BBFE RID: 48126 RVA: 0x0008FA0E File Offset: 0x0008DC0E
	public virtual void NEKBGCKIBIL()
	{
		Debug.Log("_PositionY");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BBFF RID: 48127 RVA: 0x00443EE4 File Offset: 0x004420E4
	public virtual void POJFHDFJOPE()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_WorldToCameraMatrix");
			this.IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(this.Version + "float,1.5" + SceneManagerHelper.HDHPKIDODDJ());
		}
	}

	// Token: 0x0600BC00 RID: 48128 RVA: 0x0008FA20 File Offset: 0x0008DC20
	public void NAMDCKFBFFN()
	{
		Debug.Log("mapselector.filter.rateduponly");
	}

	// Token: 0x0600BC01 RID: 48129 RVA: 0x0008FA2C File Offset: 0x0008DC2C
	public virtual void KBEHDPKDBBO()
	{
		Debug.Log("0 - default, 1 - left, 2 - right");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BC02 RID: 48130 RVA: 0x0008FA3E File Offset: 0x0008DC3E
	public virtual void FFJDANGJLEM()
	{
		Debug.Log(" Remote called.");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BC03 RID: 48131 RVA: 0x0008FA50 File Offset: 0x0008DC50
	public virtual void MKHEAFHHHMC()
	{
		Debug.Log("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BC04 RID: 48132 RVA: 0x0008FA62 File Offset: 0x0008DC62
	public virtual void AKIDKDMNEME()
	{
		Debug.Log("MapEnd");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BC05 RID: 48133 RVA: 0x0008FA74 File Offset: 0x0008DC74
	public void DIHHOKDGMLA()
	{
		Debug.Log("_SSAO");
	}

	// Token: 0x04001608 RID: 5640
	public bool AutoConnect = true;

	// Token: 0x04001609 RID: 5641
	public byte Version = 1;

	// Token: 0x0400160A RID: 5642
	private bool IDBCIKHLGKL = true;
}
