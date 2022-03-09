/*
Importance of this class: Unknown

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200001F RID: 31
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Computer")]
public class CameraFilterPack_3D_Computer : MonoBehaviour
{
	// Token: 0x06000621 RID: 1569 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x000059D3 File Offset: 0x00003BD3
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x000D4814 File Offset: 0x000D2A14
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1706f)
			{
				this.HBJJOCHGOPH = 662f;
			}
			this.HKHBBBFLGJH().SetFloat("_LutTex", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("z", this.Fade);
			this.HHIAIGCAHDA().SetFloat("/../", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("[Left]", this.MatrixSize);
			this.KGOLDDBHIFN().SetColor("checkpoint", this._MatrixColor);
			this.HHIAIGCAHDA().SetFloat("RoomPlayersCountText", this.MatrixSpeed * 1627f);
			this.ADBKPGFMNKO().SetFloat("SpawnObj", (float)((!this._Visualize) ? 1 : 0));
			this.NFKFAAHHLLM().SetFloat("inventory.selected.", this.LightIntensity);
			this.DOHGBNPMBKG().SetTexture("GetLive", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.AELJLBOJAIL().SetFloat("settings.volume.editor", 1168f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("[CraftingPanel] Init", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 82f, 91f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x000D49B0 File Offset: 0x000D2BB0
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 44f)
			{
				this.HBJJOCHGOPH = 1874f;
			}
			this.DBOLLHHMKKN().SetFloat("#checkpoint", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("_BlurVector", this.Fade);
			this.ACHNOHCLGOO().SetFloat("MenuScene", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("SetParticlesParticleSpeed", this.MatrixSize);
			this.IGKFMCPDNOI().SetColor(".played", this._MatrixColor);
			this.HFBJAOFLCJI().SetFloat("_FadeShield", this.MatrixSpeed * 173f);
			this.DKKBFFHBHJE().SetFloat("Using Stopwatch as precision timer for PUN.", (float)((!this._Visualize) ? 1 : 0));
			this.HFBJAOFLCJI().SetFloat("SupportLogger OnJoinedRoom(", this.LightIntensity);
			this.ADBKPGFMNKO().SetTexture("#savemapbeforeuploading", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DKKBFFHBHJE().SetFloat("ItemsCountText", 1694f / farClipPlane);
			this.NFKFAAHHLLM().SetVector("string", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1535f, 1473f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00005A0A File Offset: 0x00003C0A
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load(".mp3") as Texture2D);
		this.SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00005A43 File Offset: 0x00003C43
	private void MJEFMIPLFAB()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlurRadius4") as Texture2D);
		this.SCShader = Shader.Find("CorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00005A7C File Offset: 0x00003C7C
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor") as Texture2D);
		this.SCShader = Shader.Find("-");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x000D4B4C File Offset: 0x000D2D4C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 101f)
			{
				this.HBJJOCHGOPH = 1999f;
			}
			this.DOHGBNPMBKG().SetFloat("Data/Editor/leveltemplate", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat(" not exist", this.Fade);
			this.KGOLDDBHIFN().SetFloat("LevelConfigButton", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("PerfectHitsScoreText", this.MatrixSize);
			this.KEMAALEODNH().SetColor("USE_UV_BASED_REPROJECTION", this._MatrixColor);
			this.FAIFBBGFAIB().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", this.MatrixSpeed * 1455f);
			this.DOHGBNPMBKG().SetFloat("skin.no_hit", (float)((!this._Visualize) ? 0 : 0));
			this.ACHNOHCLGOO().SetFloat("_Value3", this.LightIntensity);
			this.FAIFBBGFAIB().SetTexture("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KGOLDDBHIFN().SetFloat("Zoom speed. Base 1.5", 143f / farClipPlane);
			this.NBMPPNFKFLB().SetVector("Joystick1Button10", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1194f, 1399f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00005AB5 File Offset: 0x00003CB5
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0000420A File Offset: 0x0000240A
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x00005AEC File Offset: 0x00003CEC
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("true") as Texture2D);
		this.SCShader = Shader.Find("time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00005B25 File Offset: 0x00003D25
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x000D4CE8 File Offset: 0x000D2EE8
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
			this.NBPKMLMCHFN.SetFloat("_DepthLevel", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_MatrixSize", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("_MatrixColor", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("_MatrixSpeed", this.MatrixSpeed * 2f);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00005B5C File Offset: 0x00003D5C
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Computer1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x000D4E84 File Offset: 0x000D3084
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1857f)
			{
				this.HBJJOCHGOPH = 1078f;
			}
			this.DOHGBNPMBKG().SetFloat("float,50", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.Fade);
			this.IIJMIPBMMBF().SetFloat("_ExposureAdjustment", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("ChallengesButton", this.MatrixSize);
			this.OLHDPICFBOF().SetColor("Item creation successful! Published Item ID: ", this._MatrixColor);
			this.HHIAIGCAHDA().SetFloat("GameModeText", this.MatrixSpeed * 1769f);
			this.NBMPPNFKFLB().SetFloat("/", (float)((!this._Visualize) ? 1 : 1));
			this.IGKFMCPDNOI().SetFloat("_ScreenResolution", this.LightIntensity);
			this.LNLKMDPHDCC().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OLHDPICFBOF().SetFloat("EnableRankingToggle", 79f / farClipPlane);
			this.DBOLLHHMKKN().SetVector("[GameScene] Submiting rank", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1256f, 1181f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00005B95 File Offset: 0x00003D95
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x000D5020 File Offset: 0x000D3220
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1039f)
			{
				this.HBJJOCHGOPH = 1262f;
			}
			this.LNLKMDPHDCC().SetFloat("x", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_PixelsPerMeterAtOneMeter", this.Fade);
			this.AELJLBOJAIL().SetFloat("ZoomFade", this._FixDistance);
			this.NBMPPNFKFLB().SetFloat("Circle", this.MatrixSize);
			this.AELJLBOJAIL().SetColor("default", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("_CurveParams", this.MatrixSpeed * 198f);
			this.AELJLBOJAIL().SetFloat("RecieveChatActionMessage", (float)((!this._Visualize) ? 0 : 1));
			this.LNLKMDPHDCC().SetFloat("wss://", this.LightIntensity);
			this.HCGJCMDJPGD().SetTexture("menu.selectedplaymode", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KGOLDDBHIFN().SetFloat("Keypad", 57f / farClipPlane);
			this.KEMAALEODNH().SetVector("FinalScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 442f, 1890f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00005BCC File Offset: 0x00003DCC
	private void PDHKMDBNGGN()
	{
		this.FPHEBLMINDA = (Resources.Load("[SaveSystem] Outdated savefile found") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000636 RID: 1590 RVA: 0x00005C05 File Offset: 0x00003E05
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

	// Token: 0x06000637 RID: 1591 RVA: 0x00005C3C File Offset: 0x00003E3C
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("TotalTimeLabel") as Texture2D);
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x000D51BC File Offset: 0x000D33BC
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 1310f;
			}
			this.IIJMIPBMMBF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("BadgeText", this.Fade);
			this.DKKBFFHBHJE().SetFloat("_Fade", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("1,30,true,0", this.MatrixSize);
			this.HKHBBBFLGJH().SetColor("_ScreenResolution", this._MatrixColor);
			this.NFKFAAHHLLM().SetFloat("settings_bindings_controller_type", this.MatrixSpeed * 1880f);
			this.NFKFAAHHLLM().SetFloat("ChallengesButton", (float)((!this._Visualize) ? 0 : 1));
			this.DKKBFFHBHJE().SetFloat("Right", this.LightIntensity);
			this.NBMPPNFKFLB().SetTexture("_Far", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBMPPNFKFLB().SetFloat("_TimeX", 836f / farClipPlane);
			this.EFMCNLELMDO().SetVector("Loaded Game: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 127f, 1018f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00005C75 File Offset: 0x00003E75
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0000420A File Offset: 0x0000240A
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00005CAC File Offset: 0x00003EAC
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("RenderTextureUtilityTempTexture") as Texture2D);
		this.SCShader = Shader.Find("RT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00005CE5 File Offset: 0x00003EE5
	private void AEDDNDHCLNN()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("AddEnvironmentSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00005D1E File Offset: 0x00003F1E
	private void IDJKNBDKHBD()
	{
		this.FPHEBLMINDA = (Resources.Load("Use ticket: ") as Texture2D);
		this.SCShader = Shader.Find("Aug");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x0000420A File Offset: 0x0000240A
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x0000420A File Offset: 0x0000240A
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00005D57 File Offset: 0x00003F57
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000D5358 File Offset: 0x000D3558
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 462f)
			{
				this.HBJJOCHGOPH = 679f;
			}
			this.DKKBFFHBHJE().SetFloat("_BlurTex", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("#close", this.Fade);
			this.HFBJAOFLCJI().SetFloat("_BlurRadius4", this._FixDistance);
			this.IIJMIPBMMBF().SetFloat("#currentbpm: ", this.MatrixSize);
			this.LNLKMDPHDCC().SetColor("Created", this._MatrixColor);
			this.IIJMIPBMMBF().SetFloat("shader.invert", this.MatrixSpeed * 736f);
			this.IIJMIPBMMBF().SetFloat("Hex value #RRGGBB", (float)((!this._Visualize) ? 0 : 1));
			this.HKHBBBFLGJH().SetFloat("FToA", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("CameraFilterPack_Paper4", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBMPPNFKFLB().SetFloat("ShowSprite", 1714f / farClipPlane);
			this.KEMAALEODNH().SetVector("mainmenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1734f, 1755f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00005D8E File Offset: 0x00003F8E
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x000D54F4 File Offset: 0x000D36F4
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 964f)
			{
				this.HBJJOCHGOPH = 866f;
			}
			this.HFBJAOFLCJI().SetFloat(". Sent by actorNr: ", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("Set particles start speed", this.Fade);
			this.EFMCNLELMDO().SetFloat("[Left]", this._FixDistance);
			this.JIBOKBCPDLC().SetFloat(".b", this.MatrixSize);
			this.HFBJAOFLCJI().SetColor(". Should be just one?", this._MatrixColor);
			this.LNLKMDPHDCC().SetFloat("_FrustumCornersWS", this.MatrixSpeed * 417f);
			this.ACHNOHCLGOO().SetFloat("float,10", (float)((!this._Visualize) ? 0 : 1));
			this.EFMCNLELMDO().SetFloat("_Intensity", this.LightIntensity);
			this.HFBJAOFLCJI().SetTexture("Up", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKHBBBFLGJH().SetFloat(".b", 1388f / farClipPlane);
			this.EFMCNLELMDO().SetVector("<color=#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 398f, 786f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00005DC7 File Offset: 0x00003FC7
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x0000420A File Offset: 0x0000240A
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00005DFE File Offset: 0x00003FFE
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("All bindings reset to default values. PlayerPrefs have been removed for each key.") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00005E37 File Offset: 0x00004037
	private void CGDMLHLJIDK()
	{
		this.FPHEBLMINDA = (Resources.Load("]") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/TV_Old");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00005E70 File Offset: 0x00004070
	private void HDMDKOKOOJC()
	{
		this.FPHEBLMINDA = (Resources.Load("/music") as Texture2D);
		this.SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00005EA9 File Offset: 0x000040A9
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_PosY") as Texture2D);
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x000D5704 File Offset: 0x000D3904
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1734f)
			{
				this.HBJJOCHGOPH = 1883f;
			}
			this.NBMPPNFKFLB().SetFloat("Paste events", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("1", this.Fade);
			this.FAIFBBGFAIB().SetFloat("Incoming: \n", this._FixDistance);
			this.HHIAIGCAHDA().SetFloat("Fade", this.MatrixSize);
			this.NFKFAAHHLLM().SetColor("Sent count: ", this._MatrixColor);
			this.NFKFAAHHLLM().SetFloat("settings.crosshairopacity", this.MatrixSpeed * 897f);
			this.NFKFAAHHLLM().SetFloat("You must complete your map before submiting it to Workshop", (float)((!this._Visualize) ? 1 : 1));
			this.HKHBBBFLGJH().SetFloat("Editor/", this.LightIntensity);
			this.KEMAALEODNH().SetTexture("Missing shader in ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DBOLLHHMKKN().SetFloat("_TimeX", 1642f / farClipPlane);
			this.DKKBFFHBHJE().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1597f, 1217f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x0000420A File Offset: 0x0000240A
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000D58A0 File Offset: 0x000D3AA0
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 927f)
			{
				this.HBJJOCHGOPH = 6f;
			}
			this.HKHBBBFLGJH().SetFloat("Left Stick Click", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_Value4", this.Fade);
			this.ACHNOHCLGOO().SetFloat("2;13;14;15;16", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("ResetSpeed", this.MatrixSize);
			this.HCGJCMDJPGD().SetColor("_EmissionColor", this._MatrixColor);
			this.HFBJAOFLCJI().SetFloat("MultiplayerButton", this.MatrixSpeed * 1780f);
			this.IGKFMCPDNOI().SetFloat("Most likely the game became empty during the switch to GameServer.", (float)((!this._Visualize) ? 1 : 0));
			this.KEMAALEODNH().SetFloat("CameraFilterPack_3D_Computer1", this.LightIntensity);
			this.LNLKMDPHDCC().SetTexture("y", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("HighScaleShot", 643f / farClipPlane);
			this.EFMCNLELMDO().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1909f, 1799f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00005EE2 File Offset: 0x000040E2
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00005F1B File Offset: 0x0000411B
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00005F52 File Offset: 0x00004152
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x000D5A3C File Offset: 0x000D3C3C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 773f)
			{
				this.HBJJOCHGOPH = 1505f;
			}
			this.HHIAIGCAHDA().SetFloat("_Alpha2", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("settings.volume.menu", this.Fade);
			this.IIJMIPBMMBF().SetFloat("ItemsCountText", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("_PositionX", this.MatrixSize);
			this.NBMPPNFKFLB().SetColor("_TimeX", this._MatrixColor);
			this.NFKFAAHHLLM().SetFloat("<b>", this.MatrixSpeed * 0f);
			this.DKKBFFHBHJE().SetFloat("#task", (float)((!this._Visualize) ? 0 : 1));
			this.HFBJAOFLCJI().SetFloat("[", this.LightIntensity);
			this.LNLKMDPHDCC().SetTexture("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FAIFBBGFAIB().SetFloat("OK", 1604f / farClipPlane);
			this.OLHDPICFBOF().SetVector("s", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1778f, 778f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00005F89 File Offset: 0x00004189
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x000D5BD8 File Offset: 0x000D3DD8
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1228f)
			{
				this.HBJJOCHGOPH = 892f;
			}
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Drawing_Comics", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("maps.", this.Fade);
			this.HKHBBBFLGJH().SetFloat("NewIconFileSelector", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("Set particless emission (glow)", this.MatrixSize);
			this.HCGJCMDJPGD().SetColor("Set object anchor to another object", this._MatrixColor);
			this.ACHNOHCLGOO().SetFloat("Object ID. Case-Sensitive", this.MatrixSpeed * 335f);
			this.EFMCNLELMDO().SetFloat("_FixDistance", (float)((!this._Visualize) ? 1 : 1));
			this.NBMPPNFKFLB().SetFloat(": ", this.LightIntensity);
			this.HCGJCMDJPGD().SetTexture("The given 2D texture ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ACHNOHCLGOO().SetFloat("_MainTex2", 921f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("#reward: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1853f, 1816f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00005FC0 File Offset: 0x000041C0
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00005FF7 File Offset: 0x000041F7
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0000602E File Offset: 0x0000422E
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00006065 File Offset: 0x00004265
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x0000609C File Offset: 0x0000429C
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x000060D3 File Offset: 0x000042D3
	private void COOHIILCOCO()
	{
		this.FPHEBLMINDA = (Resources.Load("PointsScoreText") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0000610C File Offset: 0x0000430C
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load(". The group number should be at least 1.") as Texture2D);
		this.SCShader = Shader.Find("SetSatelliteRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00006145 File Offset: 0x00004345
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load(". Prefab must have a PhotonView component.") as Texture2D);
		this.SCShader = Shader.Find("SlidingArea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x0000617E File Offset: 0x0000437E
	private void LIBGAKMKHJJ()
	{
		this.FPHEBLMINDA = (Resources.Load("#submit") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x000D5D74 File Offset: 0x000D3F74
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 349f)
			{
				this.HBJJOCHGOPH = 1644f;
			}
			this.DOHGBNPMBKG().SetFloat("&page=", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("Clears all text from the debug console", this.Fade);
			this.DBOLLHHMKKN().SetFloat("1234332714", this._FixDistance);
			this.OLHDPICFBOF().SetFloat("================================", this.MatrixSize);
			this.JIBOKBCPDLC().SetColor("settings.customdataskin", this._MatrixColor);
			this.DBOLLHHMKKN().SetFloat("[NetworkMenu] Joining ", this.MatrixSpeed * 1037f);
			this.NBMPPNFKFLB().SetFloat("winter2020", (float)((!this._Visualize) ? 1 : 1));
			this.KEMAALEODNH().SetFloat("_Value", this.LightIntensity);
			this.LNLKMDPHDCC().SetTexture("GlassesColor2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KGOLDDBHIFN().SetFloat("_Value", 1957f / farClipPlane);
			this.NFKFAAHHLLM().SetVector("Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1478f, 343f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x000061B7 File Offset: 0x000043B7
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_LighterColor") as Texture2D);
		this.SCShader = Shader.Find("fetch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x000D5F10 File Offset: 0x000D4110
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 556f)
			{
				this.HBJJOCHGOPH = 1254f;
			}
			this.DKKBFFHBHJE().SetFloat("#forever", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Mouse Wheel Down", this.Fade);
			this.HCGJCMDJPGD().SetFloat("SpeedSlider", this._FixDistance);
			this.NFKFAAHHLLM().SetFloat("CameraFilterPack/AAA_Super_Computer", this.MatrixSize);
			this.KGOLDDBHIFN().SetColor("_TexelOffsetScale", this._MatrixColor);
			this.KGOLDDBHIFN().SetFloat("[Right]", this.MatrixSpeed * 30f);
			this.DBOLLHHMKKN().SetFloat("_Value4", (float)((!this._Visualize) ? 1 : 1));
			this.NBMPPNFKFLB().SetFloat("float,50", this.LightIntensity);
			this.IIJMIPBMMBF().SetTexture("[PlayerController] ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFMCNLELMDO().SetFloat("ScreenResolutionPanel", 1337f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("ChatInput", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1890f, 1970f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x000061F0 File Offset: 0x000043F0
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("PublishButton") as Texture2D);
		this.SCShader = Shader.Find("Set Particle Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00006229 File Offset: 0x00004429
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x0000420A File Offset: 0x0000240A
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00006260 File Offset: 0x00004460
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000D60AC File Offset: 0x000D42AC
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 49f)
			{
				this.HBJJOCHGOPH = 176f;
			}
			this.KGOLDDBHIFN().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("rarity", this.Fade);
			this.FAIFBBGFAIB().SetFloat("DPADHOR", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat("_TimeX", this.MatrixSize);
			this.LNLKMDPHDCC().SetColor("Exception while connecting to: ", this._MatrixColor);
			this.IIJMIPBMMBF().SetFloat("settings.disablestoryboard", this.MatrixSpeed * 481f);
			this.LNLKMDPHDCC().SetFloat("Lightning", (float)((!this._Visualize) ? 1 : 1));
			this.HFBJAOFLCJI().SetFloat("_Red_G", this.LightIntensity);
			this.JIBOKBCPDLC().SetTexture("UseScanLine", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.AELJLBOJAIL().SetFloat("EndlessLoopsScoreText", 1006f / farClipPlane);
			this.EFMCNLELMDO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 854f, 1103f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x0000420A File Offset: 0x0000240A
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00006297 File Offset: 0x00004497
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00005C75 File Offset: 0x00003E75
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x000062CE File Offset: 0x000044CE
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00006307 File Offset: 0x00004507
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x0000420A File Offset: 0x0000240A
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x0000633E File Offset: 0x0000453E
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x000D6248 File Offset: 0x000D4448
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1719f)
			{
				this.HBJJOCHGOPH = 502f;
			}
			this.OLHDPICFBOF().SetFloat("Events Moved", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("maps.", this.Fade);
			this.ACHNOHCLGOO().SetFloat("Gameplay/satellite", this._FixDistance);
			this.KEMAALEODNH().SetFloat("Joystick1Button2", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("SetLives", this._MatrixColor);
			this.FAIFBBGFAIB().SetFloat("InfoText", this.MatrixSpeed * 509f);
			this.FAIFBBGFAIB().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 0 : 1));
			this.DBOLLHHMKKN().SetFloat("/Saved Games/", this.LightIntensity);
			this.DOHGBNPMBKG().SetTexture("4,28,true,0", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHIAIGCAHDA().SetFloat("menu.enableselectormusic", 54f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("Reset XP", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1294f, 1723f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x000059B6 File Offset: 0x00003BB6
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040000F8 RID: 248
	public Shader SCShader;

	// Token: 0x040000F9 RID: 249
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000FA RID: 250
	public bool _Visualize;

	// Token: 0x040000FB RID: 251
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000FC RID: 252
	private Material BJFKDHHMLJH;

	// Token: 0x040000FD RID: 253
	[Range(0f, 100f)]
	public float _FixDistance = 2f;

	// Token: 0x040000FE RID: 254
	[Range(-5f, 5f)]
	public float LightIntensity = 1f;

	// Token: 0x040000FF RID: 255
	[Range(0f, 8f)]
	public float MatrixSize = 2f;

	// Token: 0x04000100 RID: 256
	[Range(-4f, 4f)]
	public float MatrixSpeed = 0.1f;

	// Token: 0x04000101 RID: 257
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000102 RID: 258
	public Color _MatrixColor = new Color(0f, 0.5f, 1f, 1f);

	// Token: 0x04000103 RID: 259
	public static Color ChangeColorRGB;

	// Token: 0x04000104 RID: 260
	private Texture2D FPHEBLMINDA;
}
