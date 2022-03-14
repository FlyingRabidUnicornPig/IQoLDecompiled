/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000036 RID: 54
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro")]
public class CameraFilterPack_Atmosphere_Rain_Pro : MonoBehaviour
{
	// Token: 0x06000E46 RID: 3654 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x000FCD30 File Offset: 0x000FAF30
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1731f)
			{
				this.HBJJOCHGOPH = 1107f;
			}
			this.ABHDNGIHBKE().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("_Color2", this.Fade);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper3", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("FileMenu", this.DirectionX);
			this.KAFBNOBOIAJ().SetFloat("/?player=", this.Speed);
			this.ABHDNGIHBKE().SetFloat("RarityImage", this.Size);
			this.KAFBNOBOIAJ().SetFloat("_Value7", this.Distortion);
			this.IIJMIPBMMBF().SetFloat("Network destroy Instantiated GO: ", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("menu.playedsolo", this.DropOnOff);
			this.HHIFMIPPMPF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1082f, 541f));
			this.LONNIJMNKFB().SetTexture("[DiscordController] Join request {0}#{1}: {2}", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x0000FD34 File Offset: 0x0000DF34
	private void JONGNKNLLND()
	{
		this.FPHEBLMINDA = (Resources.Load("#,0.00") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x0000FD6D File Offset: 0x0000DF6D
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
	private Material NBPKMLMCHFN
	{
		get
		{
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.BJFKDHHMLJH;
		}
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x0000FDDB File Offset: 0x0000DFDB
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load("' ping: ") as Texture2D);
		this.SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x0000420A File Offset: 0x0000240A
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x0000420A File Offset: 0x0000240A
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x000FCEA0 File Offset: 0x000FB0A0
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1556f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.KAFBNOBOIAJ().SetFloat("Set Satellite Radius", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("_ThirdTex", this.Fade);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Intensity);
			this.OLHDPICFBOF().SetFloat("_TimeX", this.DirectionX);
			this.KAFBNOBOIAJ().SetFloat("InventoryContent", this.Speed);
			this.JLHLHKPHDFO().SetFloat("SetSunMaxSize", this.Size);
			this.OLHDPICFBOF().SetFloat("Start", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("settings.disablestoryboard", this.StormFlashOnOff);
			this.EMDFHOKEGNG().SetFloat("_History2ChromaTex", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1723f, 1267f));
			this.EMDFHOKEGNG().SetTexture("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x000FD010 File Offset: 0x000FB210
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1816f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			this.JLHLHKPHDFO().SetFloat("Xbox Home", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("isBunned", this.Fade);
			this.LDNADDJMIPK().SetFloat("\r", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("OpenButton", this.DirectionX);
			this.KAFBNOBOIAJ().SetFloat("\r", this.Speed);
			this.KGOLDDBHIFN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.Size);
			this.HHIFMIPPMPF().SetFloat("value", this.Distortion);
			this.KEMAALEODNH().SetFloat("#checkpoint", this.StormFlashOnOff);
			this.DKKBFFHBHJE().SetFloat(" elements", this.DropOnOff);
			this.IIJMIPBMMBF().SetVector("Map id for", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1129f, 1050f));
			this.NBPKMLMCHFN.SetTexture("_Value4", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x000FD180 File Offset: 0x000FB380
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1623f)
			{
				this.HBJJOCHGOPH = 1630f;
			}
			this.KGOLDDBHIFN().SetFloat("FinalScoreText", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("PunRespawn", this.Fade);
			this.KGOLDDBHIFN().SetFloat(" with a prefix of ", this.Intensity);
			this.DNLMFEGJJDD().SetFloat("id", this.DirectionX);
			this.EMDFHOKEGNG().SetFloat("_Value3", this.Speed);
			this.KGOLDDBHIFN().SetFloat("/", this.Size);
			this.LONNIJMNKFB().SetFloat("[PlayerBase] SpawnObj error: ", this.Distortion);
			this.DKKBFFHBHJE().SetFloat("workshop.", this.StormFlashOnOff);
			this.LDNADDJMIPK().SetFloat("Switch environment sprite image", this.DropOnOff);
			this.OLHDPICFBOF().SetVector("Set sun lerp speed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1394f, 728f));
			this.DNLMFEGJJDD().SetTexture("bad", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x000FD2F0 File Offset: 0x000FB4F0
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 248f)
			{
				this.HBJJOCHGOPH = 786f;
			}
			this.KGOLDDBHIFN().SetFloat("Reset XP", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("event", this.Fade);
			this.KEMAALEODNH().SetFloat("RecieveChatActionMessage", this.Intensity);
			this.OLHDPICFBOF().SetFloat("fade out duration", this.DirectionX);
			this.OLHDPICFBOF().SetFloat("_Value3", this.Speed);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Colors_RgbClamp", this.Size);
			this.KGOLDDBHIFN().SetFloat("EditMenu", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("_Value10", this.StormFlashOnOff);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.DropOnOff);
			this.KAFBNOBOIAJ().SetVector("SetPlayerDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 235f, 911f));
			this.OLHDPICFBOF().SetTexture(". Stopping handling if inactive.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x0000420A File Offset: 0x0000240A
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x000FD460 File Offset: 0x000FB660
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1547f)
			{
				this.HBJJOCHGOPH = 1634f;
			}
			this.LONNIJMNKFB().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("UseScanLineSize", this.Fade);
			this.LONNIJMNKFB().SetFloat(" or player:", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("_Near", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat(".r", this.Speed);
			this.DNLMFEGJJDD().SetFloat("workshop.", this.Size);
			this.HHIFMIPPMPF().SetFloat("<b>", this.Distortion);
			this.KAFBNOBOIAJ().SetFloat("other.dust0", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button11", this.DropOnOff);
			this.KGOLDDBHIFN().SetVector("<b>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1725f, 351f));
			this.IIJMIPBMMBF().SetTexture("CameraFilterPack/Light_Rainbow2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x000FD5D0 File Offset: 0x000FB7D0
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1099f)
			{
				this.HBJJOCHGOPH = 1137f;
			}
			this.HNICHJCGJOC().SetFloat("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("[ResourcesManager] Load audio error: ", this.Fade);
			this.NBPKMLMCHFN.SetFloat("DeleteButton", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("_Intensity", this.DirectionX);
			this.KAFBNOBOIAJ().SetFloat("Chat", this.Speed);
			this.ABHDNGIHBKE().SetFloat("ready", this.Size);
			this.DNLMFEGJJDD().SetFloat("/", this.Distortion);
			this.ABHDNGIHBKE().SetFloat("_Value", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.DropOnOff);
			this.DNLMFEGJJDD().SetVector("[EditorEvent] Exception: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 648f, 1437f));
			this.LDNADDJMIPK().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x000FD740 File Offset: 0x000FB940
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 403f)
			{
				this.HBJJOCHGOPH = 1047f;
			}
			this.LDNADDJMIPK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("_Visualize", this.Fade);
			this.NBPKMLMCHFN.SetFloat("settings.arcsnohitsoundtimedelay", this.Intensity);
			this.DKKBFFHBHJE().SetFloat("View", this.DirectionX);
			this.DNLMFEGJJDD().SetFloat("LevelInfoInputField", this.Speed);
			this.KEMAALEODNH().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.Size);
			this.HHIFMIPPMPF().SetFloat("_ScreenResolution", this.Distortion);
			this.HNICHJCGJOC().SetFloat("/", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("RecieveChatActionMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1446f, 434f));
			this.OLHDPICFBOF().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x0000FE14 File Offset: 0x0000E014
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("_ColorBuffer") as Texture2D);
		this.SCShader = Shader.Find("There are {0} reported logs.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x000FD8B0 File Offset: 0x000FBAB0
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 530f)
			{
				this.HBJJOCHGOPH = 1237f;
			}
			this.IIJMIPBMMBF().SetFloat("/", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("RecieveChatActionMessage", this.Fade);
			this.LDNADDJMIPK().SetFloat("DPADHOR", this.Intensity);
			this.KEMAALEODNH().SetFloat("true", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat("_ScreenResolution", this.Speed);
			this.IIJMIPBMMBF().SetFloat("\t", this.Size);
			this.KEMAALEODNH().SetFloat("_Value2", this.Distortion);
			this.KEMAALEODNH().SetFloat("[PlayerController] ", this.StormFlashOnOff);
			this.EMDFHOKEGNG().SetFloat("_Value1", this.DropOnOff);
			this.OLHDPICFBOF().SetVector("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1195f, 133f));
			this.KAFBNOBOIAJ().SetTexture("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x0000FE4D File Offset: 0x0000E04D
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Distortion_ShockWaveManual") as Texture2D);
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x000FDA20 File Offset: 0x000FBC20
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1976f)
			{
				this.HBJJOCHGOPH = 1741f;
			}
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/EXTRA_Rotation", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("...", this.Fade);
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.Intensity);
			this.HHIFMIPPMPF().SetFloat("_SunPosition", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat("_Greenness", this.Speed);
			this.DNLMFEGJJDD().SetFloat("BestScoreText", this.Size);
			this.DNLMFEGJJDD().SetFloat("<size=24>", this.Distortion);
			this.JLHLHKPHDFO().SetFloat("/icon", this.StormFlashOnOff);
			this.HNICHJCGJOC().SetFloat("BloomShaderValueSlider", this.DropOnOff);
			this.KEMAALEODNH().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1954f, 276f));
			this.LDNADDJMIPK().SetTexture(".jpg", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x0000FE86 File Offset: 0x0000E086
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain_Pro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x000FDB90 File Offset: 0x000FBD90
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1430f)
			{
				this.HBJJOCHGOPH = 1502f;
			}
			this.HNICHJCGJOC().SetFloat("Joystick1Button12", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("player", this.Fade);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("Mouse", this.DirectionX);
			this.HNICHJCGJOC().SetFloat("settings.fps", this.Speed);
			this.OLHDPICFBOF().SetFloat("Yes", this.Size);
			this.JLHLHKPHDFO().SetFloat("Zoom speed. Base 1.5", this.Distortion);
			this.LONNIJMNKFB().SetFloat("_Value2", this.StormFlashOnOff);
			this.DNLMFEGJJDD().SetFloat(" with a prefix of ", this.DropOnOff);
			this.NBPKMLMCHFN.SetVector("_dec.json", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 283f, 459f));
			this.KEMAALEODNH().SetTexture("float,1.5", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x0000FEBF File Offset: 0x0000E0BF
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ") as Texture2D);
		this.SCShader = Shader.Find("PossibleMapMaxScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("SetBGColor") as Texture2D);
		this.SCShader = Shader.Find("Received RPC \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x0000FF31 File Offset: 0x0000E131
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x000FDD78 File Offset: 0x000FBF78
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1596f)
			{
				this.HBJJOCHGOPH = 1465f;
			}
			this.LDNADDJMIPK().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("offsets", this.Fade);
			this.EMDFHOKEGNG().SetFloat("<b>Time</b>:", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("_Contrast", this.DirectionX);
			this.LONNIJMNKFB().SetFloat("Alpha", this.Speed);
			this.KAFBNOBOIAJ().SetFloat("note.0", this.Size);
			this.OLHDPICFBOF().SetFloat("_Amount", this.Distortion);
			this.OLHDPICFBOF().SetFloat("set", this.StormFlashOnOff);
			this.HNICHJCGJOC().SetFloat("EventMenu", this.DropOnOff);
			this.DKKBFFHBHJE().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1662f, 75f));
			this.HHIFMIPPMPF().SetTexture("_EmissionGain", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x000FDEE8 File Offset: 0x000FC0E8
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1005f)
			{
				this.HBJJOCHGOPH = 539f;
			}
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.Fade);
			this.IIJMIPBMMBF().SetFloat("_History1ChromaTex", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("_Overlay", this.DirectionX);
			this.DKKBFFHBHJE().SetFloat("menutheme.jamaicanorcdub", this.Speed);
			this.HHIFMIPPMPF().SetFloat("_Value2", this.Size);
			this.HHIFMIPPMPF().SetFloat("maps.", this.Distortion);
			this.LONNIJMNKFB().SetFloat("local CheckCondition = function()", this.StormFlashOnOff);
			this.IIJMIPBMMBF().SetFloat(" - GameWebCallback] - ", this.DropOnOff);
			this.JLHLHKPHDFO().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 351f, 474f));
			this.NBPKMLMCHFN.SetTexture("settings.disablestoryboard", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x0000FF68 File Offset: 0x0000E168
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x0000FF9F File Offset: 0x0000E19F
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("scenes") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x000FE058 File Offset: 0x000FC258
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1808f)
			{
				this.HBJJOCHGOPH = 1527f;
			}
			this.HNICHJCGJOC().SetFloat("Netw. Sim.", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("Init", this.Fade);
			this.HNICHJCGJOC().SetFloat("intensity", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("_ReflectionTexture1", this.DirectionX);
			this.DNLMFEGJJDD().SetFloat("_FarCamera", this.Speed);
			this.NBPKMLMCHFN.SetFloat("green", this.Size);
			this.KGOLDDBHIFN().SetFloat("AddEnvironmentSprite", this.Distortion);
			this.ABHDNGIHBKE().SetFloat("FinalScoreSmallText", this.StormFlashOnOff);
			this.IIJMIPBMMBF().SetFloat("Messages (shift+tab)", this.DropOnOff);
			this.HHIFMIPPMPF().SetVector("_Colored", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 361f, 468f));
			this.NBPKMLMCHFN.SetTexture("_VelTex", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x000FE1C8 File Offset: 0x000FC3C8
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1655f)
			{
				this.HBJJOCHGOPH = 1809f;
			}
			this.JLHLHKPHDFO().SetFloat("EventSystem", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat(".icon", this.Fade);
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("_TimeX", this.DirectionX);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.Speed);
			this.NBPKMLMCHFN.SetFloat("/", this.Size);
			this.NBPKMLMCHFN.SetFloat("Editor/", this.Distortion);
			this.LDNADDJMIPK().SetFloat("[SERVER] Player ", this.StormFlashOnOff);
			this.LONNIJMNKFB().SetFloat("EnvironmentSlider", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("{0} minutes ago", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 824f, 431f));
			this.HNICHJCGJOC().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x0000420A File Offset: 0x0000240A
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x000FE338 File Offset: 0x000FC538
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 941f)
			{
				this.HBJJOCHGOPH = 1286f;
			}
			this.KEMAALEODNH().SetFloat("{0}{1}:{2}", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("checkpoint", this.Fade);
			this.EMDFHOKEGNG().SetFloat("ResourceIDInputField", this.Intensity);
			this.LONNIJMNKFB().SetFloat("ItemNameText", this.DirectionX);
			this.DKKBFFHBHJE().SetFloat("Rotate environment object to the rotation", this.Speed);
			this.LDNADDJMIPK().SetFloat("MessageText", this.Size);
			this.KGOLDDBHIFN().SetFloat("Joystick1Button10", this.Distortion);
			this.OLHDPICFBOF().SetFloat("_Value4", this.StormFlashOnOff);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack_VHS2", this.DropOnOff);
			this.HNICHJCGJOC().SetVector("settings.selectormapsperpage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 145f, 1584f));
			this.JLHLHKPHDFO().SetTexture(".", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x0000420A File Offset: 0x0000240A
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x000FE4A8 File Offset: 0x000FC6A8
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 797f)
			{
				this.HBJJOCHGOPH = 335f;
			}
			this.IIJMIPBMMBF().SetFloat("sprite", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("BitsData", this.Fade);
			this.KGOLDDBHIFN().SetFloat("Received RPC: ", this.Intensity);
			this.LONNIJMNKFB().SetFloat("_CenterY", this.DirectionX);
			this.EMDFHOKEGNG().SetFloat("_MainTex2", this.Speed);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.Size);
			this.DKKBFFHBHJE().SetFloat("SupportLogger OnApplicationPause: ", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("The given 2D texture ", this.StormFlashOnOff);
			this.HNICHJCGJOC().SetFloat("maps.", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("menu.enableselectormusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 381f, 1534f));
			this.EMDFHOKEGNG().SetTexture("#tryagain", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x0001000F File Offset: 0x0000E20F
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00010046 File Offset: 0x0000E246
	private void HDMDKOKOOJC()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value4") as Texture2D);
		this.SCShader = Shader.Find("_Blue_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x0001007F File Offset: 0x0000E27F
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x000FE618 File Offset: 0x000FC818
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("_Value8", this.DropOnOff);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x000FE788 File Offset: 0x000FC988
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1281f)
			{
				this.HBJJOCHGOPH = 88f;
			}
			this.KGOLDDBHIFN().SetFloat("{0:0} day{1}, ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("[PlayerBase] Current attempt: ", this.Fade);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/Special_Bubble", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			this.HNICHJCGJOC().SetFloat("maxScore", this.Speed);
			this.HNICHJCGJOC().SetFloat("mapselector.orderby", this.Size);
			this.DNLMFEGJJDD().SetFloat("_Red_C", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.StormFlashOnOff);
			this.JLHLHKPHDFO().SetFloat("_Value", this.DropOnOff);
			this.LONNIJMNKFB().SetVector("EnableRankingToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 1982f));
			this.KAFBNOBOIAJ().SetTexture("kick", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x000FE8F8 File Offset: 0x000FCAF8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1090f)
			{
				this.HBJJOCHGOPH = 1285f;
			}
			this.IIJMIPBMMBF().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("#combo", this.Fade);
			this.DKKBFFHBHJE().SetFloat("_TexelOffsetScale", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("_Blend", this.Speed);
			this.DKKBFFHBHJE().SetFloat("_Value3", this.Size);
			this.KAFBNOBOIAJ().SetFloat("STICKLVER", this.Distortion);
			this.KGOLDDBHIFN().SetFloat("#combo", this.StormFlashOnOff);
			this.IIJMIPBMMBF().SetFloat("Type \"help\" for list of commands", this.DropOnOff);
			this.KGOLDDBHIFN().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 480f, 1064f));
			this.DNLMFEGJJDD().SetTexture("Tab1Content", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x000100B6 File Offset: 0x0000E2B6
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x000100ED File Offset: 0x0000E2ED
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00010124 File Offset: 0x0000E324
	private void DBEMDAJDDDA()
	{
		this.FPHEBLMINDA = (Resources.Load("achievements.26.progress") as Texture2D);
		this.SCShader = Shader.Find("checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x0000420A File Offset: 0x0000240A
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x0001015D File Offset: 0x0000E35D
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00010194 File Offset: 0x0000E394
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x000101CB File Offset: 0x0000E3CB
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("Object ID. Case-Sensitive") as Texture2D);
		this.SCShader = Shader.Find("AccuracyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x000FEA68 File Offset: 0x000FCC68
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 466f)
			{
				this.HBJJOCHGOPH = 1793f;
			}
			this.KAFBNOBOIAJ().SetFloat("player.greenlollipop", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("CameraFilterPack/Color_Convert_Normal", this.Fade);
			this.LDNADDJMIPK().SetFloat("#{0:00}{1}{2}", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("_TileTexDebug", this.DirectionX);
			this.KAFBNOBOIAJ().SetFloat(":", this.Speed);
			this.KGOLDDBHIFN().SetFloat("X2", this.Size);
			this.JLHLHKPHDFO().SetFloat("id", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("nogamesfound", this.StormFlashOnOff);
			this.KAFBNOBOIAJ().SetFloat("_MainTex", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("CameraFilterPack_Glasses_On6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1096f, 1864f));
			this.OLHDPICFBOF().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00010204 File Offset: 0x0000E404
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x000FEBD8 File Offset: 0x000FCDD8
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 860f)
			{
				this.HBJJOCHGOPH = 1123f;
			}
			this.EMDFHOKEGNG().SetFloat("SettingsCanvas", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/TV_BrokenGlass2", this.Fade);
			this.HHIFMIPPMPF().SetFloat("[Up-Down-Left]", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("...", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat(".lastCheckpoint.powerupsScore", this.Speed);
			this.LDNADDJMIPK().SetFloat("PossibleMapPointsText", this.Size);
			this.KGOLDDBHIFN().SetFloat("achievements.21.completed.", this.Distortion);
			this.EMDFHOKEGNG().SetFloat("_TimeX", this.StormFlashOnOff);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.DropOnOff);
			this.IIJMIPBMMBF().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1297f, 229f));
			this.JLHLHKPHDFO().SetTexture("ItemNameText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x000FED48 File Offset: 0x000FCF48
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1030f)
			{
				this.HBJJOCHGOPH = 1670f;
			}
			this.KEMAALEODNH().SetFloat(" : ", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat(".completed", this.Fade);
			this.EMDFHOKEGNG().SetFloat("SetSpeed", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("Vertical", this.DirectionX);
			this.JLHLHKPHDFO().SetFloat("Can't set MaxPlayers when not in that room.", this.Speed);
			this.KGOLDDBHIFN().SetFloat("ClearEnvironment", this.Size);
			this.OLHDPICFBOF().SetFloat("TestMapButton", this.Distortion);
			this.OLHDPICFBOF().SetFloat(".completed", this.StormFlashOnOff);
			this.DNLMFEGJJDD().SetFloat("DifficultyBG", this.DropOnOff);
			this.OLHDPICFBOF().SetVector("[NetworkManager] Join failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1099f, 598f));
			this.NBPKMLMCHFN.SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x0001023B File Offset: 0x0000E43B
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("_Fade") as Texture2D);
		this.SCShader = Shader.Find("USE_UV_BASED_REPROJECTION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x0000420A File Offset: 0x0000240A
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x000FEEB8 File Offset: 0x000FD0B8
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1722f)
			{
				this.HBJJOCHGOPH = 1055f;
			}
			this.IIJMIPBMMBF().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_Value10", this.Fade);
			this.OLHDPICFBOF().SetFloat("[Right]", this.Intensity);
			this.JLHLHKPHDFO().SetFloat("_LensDirt", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat("CurrentTimeLabel", this.Speed);
			this.NBPKMLMCHFN.SetFloat("TotalHitsScoreText", this.Size);
			this.KGOLDDBHIFN().SetFloat("_Value4", this.Distortion);
			this.HHIFMIPPMPF().SetFloat("scenes", this.StormFlashOnOff);
			this.EMDFHOKEGNG().SetFloat("_Value", this.DropOnOff);
			this.DKKBFFHBHJE().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 551f, 438f));
			this.KGOLDDBHIFN().SetTexture("NameText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00010274 File Offset: 0x0000E474
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x0000420A File Offset: 0x0000240A
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x000FF028 File Offset: 0x000FD228
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 280f)
			{
				this.HBJJOCHGOPH = 437f;
			}
			this.IIJMIPBMMBF().SetFloat("settings.volume.menu", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("SettingsCanvas", this.Fade);
			this.HHIFMIPPMPF().SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("player.redabstract", this.DirectionX);
			this.LDNADDJMIPK().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", this.Speed);
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/Blur_Bloom", this.Size);
			this.KEMAALEODNH().SetFloat("ResourceFileSelector", this.Distortion);
			this.KEMAALEODNH().SetFloat("Down", this.StormFlashOnOff);
			this.KGOLDDBHIFN().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("[Down]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 594f, 5f));
			this.DNLMFEGJJDD().SetTexture("[Left]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x000102AB File Offset: 0x0000E4AB
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x0000420A File Offset: 0x0000240A
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x000FF198 File Offset: 0x000FD398
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 616f)
			{
				this.HBJJOCHGOPH = 164f;
			}
			this.NBPKMLMCHFN.SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat(";", this.Fade);
			this.DNLMFEGJJDD().SetFloat("RT", this.Intensity);
			this.DKKBFFHBHJE().SetFloat(" - ", this.DirectionX);
			this.DKKBFFHBHJE().SetFloat("_TexelOffsetScale", this.Speed);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/TV_WideScreenHV", this.Size);
			this.HNICHJCGJOC().SetFloat("\r", this.Distortion);
			this.KGOLDDBHIFN().SetFloat("Joystick1Button12", this.StormFlashOnOff);
			this.HHIFMIPPMPF().SetFloat("May", this.DropOnOff);
			this.JLHLHKPHDFO().SetVector("No child content found, exiting..", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 552f));
			this.HHIFMIPPMPF().SetTexture("HighScaleShot", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x000102E2 File Offset: 0x0000E4E2
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x0000420A File Offset: 0x0000240A
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x000FF308 File Offset: 0x000FD508
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 254f)
			{
				this.HBJJOCHGOPH = 124f;
			}
			this.HNICHJCGJOC().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("#forever", this.Fade);
			this.HHIFMIPPMPF().SetFloat("_FarCamera", this.Intensity);
			this.KEMAALEODNH().SetFloat(": ", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat("n/a", this.Speed);
			this.EMDFHOKEGNG().SetFloat("ConnectToRegion: ", this.Size);
			this.OLHDPICFBOF().SetFloat("_Value2", this.Distortion);
			this.DNLMFEGJJDD().SetFloat(". Client is not the MasterClient in this room.", this.StormFlashOnOff);
			this.LONNIJMNKFB().SetFloat("Text", this.DropOnOff);
			this.KAFBNOBOIAJ().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 799f, 1992f));
			this.DNLMFEGJJDD().SetTexture("received</b>\n#reason: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x0000FD17 File Offset: 0x0000DF17
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x0001031B File Offset: 0x0000E51B
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000212 RID: 530
	public Shader SCShader;

	// Token: 0x04000213 RID: 531
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000214 RID: 532
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000215 RID: 533
	private Material BJFKDHHMLJH;

	// Token: 0x04000216 RID: 534
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000217 RID: 535
	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	// Token: 0x04000218 RID: 536
	[Range(-0.25f, 0.25f)]
	public float DirectionX = 0.12f;

	// Token: 0x04000219 RID: 537
	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	// Token: 0x0400021A RID: 538
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x0400021B RID: 539
	[Range(0f, 0.5f)]
	public float Distortion = 0.025f;

	// Token: 0x0400021C RID: 540
	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	// Token: 0x0400021D RID: 541
	[Range(0f, 1f)]
	public float DropOnOff = 1f;

	// Token: 0x0400021E RID: 542
	private Texture2D FPHEBLMINDA;
}
