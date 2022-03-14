/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000027 RID: 39
[AddComponentMenu("Camera Filter Pack/3D/Scan_Scene")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Scan_Scene : MonoBehaviour
{
	// Token: 0x06000967 RID: 2407 RVA: 0x000E61D4 File Offset: 0x000E43D4
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 709f)
			{
				this.HBJJOCHGOPH = 1776f;
			}
			this.BFGNMFCNDBC().SetFloat("[ResourcesManager] Load text error: not found", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("bad", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 184f)
				{
					this._Distance = 1078f;
				}
				if (this._Distance < 1617f)
				{
					this._Distance = 43f;
				}
				this.FGENHBKMPDA().SetFloat("Player Connected", this._Distance);
			}
			else
			{
				this.IIBLJCKLGFG().SetFloat("_SprTex", this._Distance);
			}
			this.HEINDEMCGIK().SetFloat(". Calling ConnectToRegionMaster() is: ", this._Size);
			this.FGENHBKMPDA().SetColor("Run a command for the Localization Servise", this.ScanColor);
			this.GCDFNHMJMIP().SetFloat("_TimeX", this._FixDistance);
			this.KEMAALEODNH().SetFloat("1427616858", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BAGICADFBAB().SetFloat("GlassesColor2", 1925f / farClipPlane);
			this.OGMEGHKECAH().SetVector("PointsScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 708f, 144f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x0000A079 File Offset: 0x00008279
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x0000A096 File Offset: 0x00008296
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x0000A0CD File Offset: 0x000082CD
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("Rtt:{0,4} +/-{1,3}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x0000420A File Offset: 0x0000240A
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x0000420A File Offset: 0x0000240A
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x000E63B0 File Offset: 0x000E45B0
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = 0f;
				}
				if (this._Distance < 0f)
				{
					this._Distance = 1f;
				}
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetColor("_ColorRGB", this.ScanColor);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
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

	// Token: 0x0600096E RID: 2414 RVA: 0x000E658C File Offset: 0x000E478C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 286f)
			{
				this.HBJJOCHGOPH = 906f;
			}
			this.IIBLJCKLGFG().SetFloat("_Jitter", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("Tab2Content", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1604f)
				{
					this._Distance = 785f;
				}
				if (this._Distance < 1695f)
				{
					this._Distance = 864f;
				}
				this.IGKFMCPDNOI().SetFloat(".lastCheckpoint.comboScore", this._Distance);
			}
			else
			{
				this.BAGICADFBAB().SetFloat(",0", this._Distance);
			}
			this.GKILCDHJFEG().SetFloat(".lastCheckpoint.penaltyScore", this._Size);
			this.BLMPMOIDGMG().SetColor("Can't start OFFLINE mode while connected!", this.ScanColor);
			this.IIBLJCKLGFG().SetFloat("id", this._FixDistance);
			this.FLOHGDECHHH().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OLHDPICFBOF().SetFloat("0", 1348f / farClipPlane);
			this.IFMAPIDFNLI().SetVector("SetSatelliteRotationSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 878f, 550f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x000E6768 File Offset: 0x000E4968
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 779f)
			{
				this.HBJJOCHGOPH = 1693f;
			}
			this.IFMAPIDFNLI().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("/", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1183f)
				{
					this._Distance = 269f;
				}
				if (this._Distance < 1572f)
				{
					this._Distance = 986f;
				}
				this.NBPKMLMCHFN.SetFloat("[NetworkManager] Joined main lobby", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat(" [", this._Distance);
			}
			this.OLHDPICFBOF().SetFloat("_Fade", this._Size);
			this.BAGICADFBAB().SetColor("[PlayerBase] Loaded music", this.ScanColor);
			this.PGPEMMBJOOG().SetFloat("_Value3", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("sounds/hit_perfect", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FGENHBKMPDA().SetFloat("settings.shaders.bloomintencity", 502f / farClipPlane);
			this.PGPEMMBJOOG().SetVector("CameraFilterPack/Blend2Camera_Luminosity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 89f, 906f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x000E6944 File Offset: 0x000E4B44
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1209f)
			{
				this.HBJJOCHGOPH = 25f;
			}
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat(" GO:", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1794f)
				{
					this._Distance = 1801f;
				}
				if (this._Distance < 29f)
				{
					this._Distance = 1131f;
				}
				this.DEFBJOCJJKF().SetFloat("_Value3", this._Distance);
			}
			else
			{
				this.OGMEGHKECAH().SetFloat("AudioSampler", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("name", this._Size);
			this.OGMEGHKECAH().SetColor("]. Please verify you have this gameobject in a Resources folder.", this.ScanColor);
			this.BFGNMFCNDBC().SetFloat(".jpg", this._FixDistance);
			this.LPCHMEKDCHI().SetFloat("[PlayerController] ", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HEINDEMCGIK().SetFloat("JITTER", 1556f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 513f, 989f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x0000A0F1 File Offset: 0x000082F1
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x0000A128 File Offset: 0x00008328
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("No peer to communicate with. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x0000A14C File Offset: 0x0000834C
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x0000420A File Offset: 0x0000240A
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x0000A170 File Offset: 0x00008370
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("SUBMIT '{0}' FILES");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x000E6B20 File Offset: 0x000E4D20
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1096f)
			{
				this.HBJJOCHGOPH = 56f;
			}
			this.IGKFMCPDNOI().SetFloat("Bad modpack name: {0}", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_Value7", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1951f)
				{
					this._Distance = 131f;
				}
				if (this._Distance < 955f)
				{
					this._Distance = 934f;
				}
				this.FGENHBKMPDA().SetFloat("settings.arcsdestroydelay", this._Distance);
			}
			else
			{
				this.FLOHGDECHHH().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this._Distance);
			}
			this.OGMEGHKECAH().SetFloat("ItemTemplate", this._Size);
			this.PGPEMMBJOOG().SetColor("_Sat", this.ScanColor);
			this.NBPKMLMCHFN.SetFloat(" : ", this._FixDistance);
			this.IFMAPIDFNLI().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLOHGDECHHH().SetFloat("#failed: ", 245f / farClipPlane);
			this.DEFBJOCJJKF().SetVector("_LensDirtIntensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 584f, 1389f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x000E6CFC File Offset: 0x000E4EFC
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 75f)
			{
				this.HBJJOCHGOPH = 1988f;
			}
			this.HEINDEMCGIK().SetFloat("_TreatBackfaceHitAsMiss", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("GroupNameText", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 962f)
				{
					this._Distance = 249f;
				}
				if (this._Distance < 804f)
				{
					this._Distance = 199f;
				}
				this.FGENHBKMPDA().SetFloat("PublishButton", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("No Description", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Distortion_Dream", this._Size);
			this.AELJLBOJAIL().SetColor("SearchTex", this.ScanColor);
			this.BLMPMOIDGMG().SetFloat("PLEASE WAIT", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OGMEGHKECAH().SetFloat(" not exist", 1372f / farClipPlane);
			this.IIBLJCKLGFG().SetVector("EditMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1551f, 147f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x0000A194 File Offset: 0x00008394
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find(". Client is not the MasterClient in this room.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x0000A1B8 File Offset: 0x000083B8
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("InputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x000E6ED8 File Offset: 0x000E50D8
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 509f)
			{
				this.HBJJOCHGOPH = 1383f;
			}
			this.GCDFNHMJMIP().SetFloat(":", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("<color=#{0}>{1}</color>", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 800f)
				{
					this._Distance = 1230f;
				}
				if (this._Distance < 900f)
				{
					this._Distance = 1358f;
				}
				this.FGENHBKMPDA().SetFloat("SetSatelliteTrailLength", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("maps.", this._Distance);
			}
			this.DEFBJOCJJKF().SetFloat("SupportLogger OnJoinedRoom(", this._Size);
			this.BLMPMOIDGMG().SetColor("R1", this.ScanColor);
			this.OLHDPICFBOF().SetFloat("sfxVolume", this._FixDistance);
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BLMPMOIDGMG().SetFloat(".lastCheckpoint.bgcolor", 1307f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("SetBGColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 506f, 1026f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x0000A1DC File Offset: 0x000083DC
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x0000A200 File Offset: 0x00008400
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x000E70B4 File Offset: 0x000E52B4
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1874f)
			{
				this.HBJJOCHGOPH = 954f;
			}
			this.JFDGLLEOPGB().SetFloat("Error: Timeout :S", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("1278033234", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1816f)
				{
					this._Distance = 161f;
				}
				if (this._Distance < 1843f)
				{
					this._Distance = 129f;
				}
				this.OGMEGHKECAH().SetFloat("maps.", this._Distance);
			}
			else
			{
				this.DKKBFFHBHJE().SetFloat("_Value6", this._Distance);
			}
			this.AELJLBOJAIL().SetFloat("_TimeX", this._Size);
			this.BFGNMFCNDBC().SetColor("settings.disablestoryboard", this.ScanColor);
			this.IGKFMCPDNOI().SetFloat("ServerSettings: ", this._FixDistance);
			this.BFGNMFCNDBC().SetFloat("Object ID. Case-Sensitive", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMAALEODNH().SetFloat("[PlayerController] ", 1512f / farClipPlane);
			this.BFGNMFCNDBC().SetVector("menuVolume", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 364f, 1203f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x0000A237 File Offset: 0x00008437
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x000E7290 File Offset: 0x000E5490
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1233f)
			{
				this.HBJJOCHGOPH = 1483f;
			}
			this.PGPEMMBJOOG().SetFloat("GlassColor", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("Tab2Content", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1229f)
				{
					this._Distance = 1926f;
				}
				if (this._Distance < 368f)
				{
					this._Distance = 341f;
				}
				this.IFMAPIDFNLI().SetFloat("_LutTex", this._Distance);
			}
			else
			{
				this.GCDFNHMJMIP().SetFloat("/", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", this._Size);
			this.JFDGLLEOPGB().SetColor("_MainTex2", this.ScanColor);
			this.GKILCDHJFEG().SetFloat("_ScratchOffsetScale", this._FixDistance);
			this.OGMEGHKECAH().SetFloat("useSrcAlphaAsMask", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DKKBFFHBHJE().SetFloat("_History2ChromaTex", 1536f / farClipPlane);
			this.FLOHGDECHHH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 965f, 978f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x0000A25B File Offset: 0x0000845B
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0000A079 File Offset: 0x00008279
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x000E746C File Offset: 0x000E566C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 598f)
			{
				this.HBJJOCHGOPH = 1794f;
			}
			this.OLHDPICFBOF().SetFloat("[LevelEditorScene] Reloaded config for \"", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("/files/editor_manual.pdf", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1803f)
				{
					this._Distance = 29f;
				}
				if (this._Distance < 1306f)
				{
					this._Distance = 54f;
				}
				this.FGENHBKMPDA().SetFloat("_MainTex2", this._Distance);
			}
			else
			{
				this.IFMAPIDFNLI().SetFloat("_Bullet_12", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("_Value7", this._Size);
			this.BFGNMFCNDBC().SetColor("_MainTex2", this.ScanColor);
			this.GCDFNHMJMIP().SetFloat("menutheme.jamaicanorcdub", this._FixDistance);
			this.IGKFMCPDNOI().SetFloat("Hex value #RRGGBB", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BLMPMOIDGMG().SetFloat("] ", 279f / farClipPlane);
			this.IIBLJCKLGFG().SetVector("Set satellite radius (offset)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 468f, 1780f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0000A079 File Offset: 0x00008279
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0000420A File Offset: 0x0000240A
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x0000A292 File Offset: 0x00008492
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Scan_Scene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x0000A2B6 File Offset: 0x000084B6
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x0000A2ED File Offset: 0x000084ED
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_OnOff");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x0000A079 File Offset: 0x00008279
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0000A311 File Offset: 0x00008511
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("\t");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x000E7648 File Offset: 0x000E5848
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1746f)
			{
				this.HBJJOCHGOPH = 1634f;
			}
			this.GKILCDHJFEG().SetFloat("#no", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Value4", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 267f)
				{
					this._Distance = 1683f;
				}
				if (this._Distance < 39f)
				{
					this._Distance = 1417f;
				}
				this.DKKBFFHBHJE().SetFloat("_Value", this._Distance);
			}
			else
			{
				this.GKILCDHJFEG().SetFloat("editor.", this._Distance);
			}
			this.LPCHMEKDCHI().SetFloat("DPADHOR", this._Size);
			this.BAGICADFBAB().SetColor("_TimeX", this.ScanColor);
			this.BLMPMOIDGMG().SetFloat("restrictions\n\n#until: ", this._FixDistance);
			this.BLMPMOIDGMG().SetFloat("mapselector.orderby", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HFBJAOFLCJI().SetFloat("Failed to InstantiateSceneObject prefab:", 1141f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("EnvironmentSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1346f, 1345f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x0000420A File Offset: 0x0000240A
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x0000A335 File Offset: 0x00008535
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x0000A36C File Offset: 0x0000856C
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("other.dust2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x000E7824 File Offset: 0x000E5A24
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 283f)
			{
				this.HBJJOCHGOPH = 909f;
			}
			this.BAGICADFBAB().SetFloat("PLAY [SPACE]", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("_Extra", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1042f)
				{
					this._Distance = 971f;
				}
				if (this._Distance < 621f)
				{
					this._Distance = 1651f;
				}
				this.KEMAALEODNH().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.FLOHGDECHHH().SetFloat("menu.tabid", this._Distance);
			}
			this.OGMEGHKECAH().SetFloat("_Value4", this._Size);
			this.BAGICADFBAB().SetColor("_Distortion", this.ScanColor);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/Drawing_Curve", this._FixDistance);
			this.GKILCDHJFEG().SetFloat("_MainTex2", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.PGPEMMBJOOG().SetFloat("Editor/", 752f / farClipPlane);
			this.FGENHBKMPDA().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1161f, 1566f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x0000A390 File Offset: 0x00008590
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x0000A3C7 File Offset: 0x000085C7
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("skin.hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x0000420A File Offset: 0x0000240A
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x000E7A00 File Offset: 0x000E5C00
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 374f)
			{
				this.HBJJOCHGOPH = 218f;
			}
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("#mapmustbecompletebeforesubmit", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 134f)
				{
					this._Distance = 836f;
				}
				if (this._Distance < 737f)
				{
					this._Distance = 246f;
				}
				this.GKILCDHJFEG().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", this._Distance);
			}
			else
			{
				this.KEMAALEODNH().SetFloat(" | ", this._Distance);
			}
			this.IFMAPIDFNLI().SetFloat("ERROR You should never change PhotonPlayer IDs!", this._Size);
			this.DKKBFFHBHJE().SetColor("Did not read byte array properly", this.ScanColor);
			this.IIBLJCKLGFG().SetFloat("</b>", this._FixDistance);
			this.FLOHGDECHHH().SetFloat("w", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IFMAPIDFNLI().SetFloat("Set sun min/max size", 338f / farClipPlane);
			this.DKKBFFHBHJE().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1378f, 140f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x0000420A File Offset: 0x0000240A
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x0000A3EB File Offset: 0x000085EB
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("No Description");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x000E7C50 File Offset: 0x000E5E50
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 382f)
			{
				this.HBJJOCHGOPH = 1534f;
			}
			this.BLMPMOIDGMG().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("settings.hitvariation", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 402f)
				{
					this._Distance = 1682f;
				}
				if (this._Distance < 783f)
				{
					this._Distance = 506f;
				}
				this.GKILCDHJFEG().SetFloat("SetSunSensitivity", this._Distance);
			}
			else
			{
				this.DEFBJOCJJKF().SetFloat("start", this._Distance);
			}
			this.OLHDPICFBOF().SetFloat("_MainTex2", this._Size);
			this.GKILCDHJFEG().SetColor("_EmissionGain", this.ScanColor);
			this.LPCHMEKDCHI().SetFloat("Set Player Distance", this._FixDistance);
			this.BFGNMFCNDBC().SetFloat("{0:0.0} ms ({1:0.} fps)", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DEFBJOCJJKF().SetFloat("_Gain", 1201f / farClipPlane);
			this.OLHDPICFBOF().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1052f, 929f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0000A40F File Offset: 0x0000860F
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x0000A446 File Offset: 0x00008646
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x0000A47D File Offset: 0x0000867D
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("_TileTexDebug");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x0000A4A1 File Offset: 0x000086A1
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x0000A4C5 File Offset: 0x000086C5
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("UpperMid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x0000A079 File Offset: 0x00008279
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x0000A4E9 File Offset: 0x000086E9
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x0000A520 File Offset: 0x00008720
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("LivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x0000A544 File Offset: 0x00008744
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x000E7E2C File Offset: 0x000E602C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1087f)
			{
				this.HBJJOCHGOPH = 212f;
			}
			this.GCDFNHMJMIP().SetFloat("InventoryGrid", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("maps.", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 155f)
				{
					this._Distance = 1951f;
				}
				if (this._Distance < 1806f)
				{
					this._Distance = 1676f;
				}
				this.OGMEGHKECAH().SetFloat("LeaderboardsButton", this._Distance);
			}
			else
			{
				this.LPCHMEKDCHI().SetFloat("Connecting to server", this._Distance);
			}
			this.AELJLBOJAIL().SetFloat("player.bluelifering", this._Size);
			this.DEFBJOCJJKF().SetColor(".completedCount", this.ScanColor);
			this.BLMPMOIDGMG().SetFloat("_NoiseAmount", this._FixDistance);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/Vision_AuraDistortion", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HEINDEMCGIK().SetFloat("menu.enableselectormusic", 1619f / farClipPlane);
			this.HEINDEMCGIK().SetVector("Default UI Material", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1137f, 426f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x0000A079 File Offset: 0x00008279
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x0000420A File Offset: 0x0000240A
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x0000A57B File Offset: 0x0000877B
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find(".progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x000E8008 File Offset: 0x000E6208
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1337f)
			{
				this.HBJJOCHGOPH = 1070f;
			}
			this.PGPEMMBJOOG().SetFloat("note.7", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("_Offset", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 843f)
				{
					this._Distance = 1249f;
				}
				if (this._Distance < 387f)
				{
					this._Distance = 1851f;
				}
				this.GKILCDHJFEG().SetFloat("_Value4", this._Distance);
			}
			else
			{
				this.OGMEGHKECAH().SetFloat(" not exist", this._Distance);
			}
			this.BAGICADFBAB().SetFloat("RECORD [R]", this._Size);
			this.LPCHMEKDCHI().SetColor("_DistortionWave", this.ScanColor);
			this.NBPKMLMCHFN.SetFloat("OK", this._FixDistance);
			this.KEMAALEODNH().SetFloat(".lastCheckpoint.powerupsScore", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BAGICADFBAB().SetFloat("_Bullet_7", 1159f / farClipPlane);
			this.DEFBJOCJJKF().SetVector("_Bloom4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1566f, 1812f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0000A59F File Offset: 0x0000879F
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x0000420A File Offset: 0x0000240A
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x0000420A File Offset: 0x0000240A
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x0000420A File Offset: 0x0000240A
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x0000A079 File Offset: 0x00008279
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x0000420A File Offset: 0x0000240A
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x000E81E4 File Offset: 0x000E63E4
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1973f)
			{
				this.HBJJOCHGOPH = 243f;
			}
			this.HFBJAOFLCJI().SetFloat("float,10", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_TimeX", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1919f)
				{
					this._Distance = 1176f;
				}
				if (this._Distance < 484f)
				{
					this._Distance = 121f;
				}
				this.JFDGLLEOPGB().SetFloat(".save", this._Distance);
			}
			else
			{
				this.BLMPMOIDGMG().SetFloat("[Right]", this._Distance);
			}
			this.DEFBJOCJJKF().SetFloat("SetParticlesGravity", this._Size);
			this.BLMPMOIDGMG().SetColor("_Glitch", this.ScanColor);
			this.FLOHGDECHHH().SetFloat("RoomPlayersCountText", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("?", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BLMPMOIDGMG().SetFloat("_LutTex", 1360f / farClipPlane);
			this.GKILCDHJFEG().SetVector("HelpMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1213f, 98f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x0000A5D6 File Offset: 0x000087D6
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x0000A60D File Offset: 0x0000880D
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x0000420A File Offset: 0x0000240A
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x0000A079 File Offset: 0x00008279
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0000A644 File Offset: 0x00008844
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x0000A668 File Offset: 0x00008868
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("LevelNameInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x000E83C0 File Offset: 0x000E65C0
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1748f)
			{
				this.HBJJOCHGOPH = 1421f;
			}
			this.KEMAALEODNH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("SearchTex", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1686f)
				{
					this._Distance = 1175f;
				}
				if (this._Distance < 1449f)
				{
					this._Distance = 1266f;
				}
				this.IGKFMCPDNOI().SetFloat("(scene)", this._Distance);
			}
			else
			{
				this.AELJLBOJAIL().SetFloat("arc", this._Distance);
			}
			this.FLOHGDECHHH().SetFloat("_Near", this._Size);
			this.HFBJAOFLCJI().SetColor("CompletedLevel", this.ScanColor);
			this.NBPKMLMCHFN.SetFloat("nd", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("shader.sunny", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("_TimeX", 1185f / farClipPlane);
			this.KEMAALEODNH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 729f, 1564f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0000A079 File Offset: 0x00008279
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x0000A68C File Offset: 0x0000888C
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x000E859C File Offset: 0x000E679C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1541f)
			{
				this.HBJJOCHGOPH = 171f;
			}
			this.PGPEMMBJOOG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("OnReadyClick", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1707f)
				{
					this._Distance = 1007f;
				}
				if (this._Distance < 678f)
				{
					this._Distance = 893f;
				}
				this.GKILCDHJFEG().SetFloat("TestTicket", this._Distance);
			}
			else
			{
				this.OGMEGHKECAH().SetFloat("mapselector.lastSearch", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("StartButton", this._Size);
			this.JFDGLLEOPGB().SetColor("SetSpeed", this.ScanColor);
			this.LPCHMEKDCHI().SetFloat(". Sent by actorNr: ", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("ConfigVersionSlider", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.PGPEMMBJOOG().SetFloat("_Value4", 1380f / farClipPlane);
			this.IIBLJCKLGFG().SetVector("HiddenToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1430f, 1229f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x0000A6C3 File Offset: 0x000088C3
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_HdrParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x000E8778 File Offset: 0x000E6978
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 753f)
			{
				this.HBJJOCHGOPH = 733f;
			}
			this.DKKBFFHBHJE().SetFloat("Data", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("DPADVER", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1447f)
				{
					this._Distance = 1231f;
				}
				if (this._Distance < 1839f)
				{
					this._Distance = 1429f;
				}
				this.OGMEGHKECAH().SetFloat("#mapnotloaded", this._Distance);
			}
			else
			{
				this.BFGNMFCNDBC().SetFloat("_Dist", this._Distance);
			}
			this.BFGNMFCNDBC().SetFloat("Line", this._Size);
			this.NBPKMLMCHFN.SetColor("id", this.ScanColor);
			this.LPCHMEKDCHI().SetFloat("_TimeX", this._FixDistance);
			this.LPCHMEKDCHI().SetFloat("_U", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPCHMEKDCHI().SetFloat("Selection Box", 1306f / farClipPlane);
			this.IFMAPIDFNLI().SetVector("Bad parameters for set! Use <language>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 542f, 446f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x0000A079 File Offset: 0x00008279
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x0000A079 File Offset: 0x00008279
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x000E8954 File Offset: 0x000E6B54
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1775f)
			{
				this.HBJJOCHGOPH = 791f;
			}
			this.GCDFNHMJMIP().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("Tab1Content", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1052f)
				{
					this._Distance = 1069f;
				}
				if (this._Distance < 418f)
				{
					this._Distance = 818f;
				}
				this.LPCHMEKDCHI().SetFloat("Reset 21 achievement progress", this._Distance);
			}
			else
			{
				this.KEMAALEODNH().SetFloat(" has ", this._Distance);
			}
			this.KEMAALEODNH().SetFloat(".lastCheckpoint.currentCombo", this._Size);
			this.OLHDPICFBOF().SetColor("green", this.ScanColor);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this._FixDistance);
			this.IFMAPIDFNLI().SetFloat("_Value2", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GCDFNHMJMIP().SetFloat(" GO:", 1499f / farClipPlane);
			this.BAGICADFBAB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 790f, 1468f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x0000420A File Offset: 0x0000240A
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x0000A71E File Offset: 0x0000891E
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x000E8B30 File Offset: 0x000E6D30
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 142f)
			{
				this.HBJJOCHGOPH = 1873f;
			}
			this.LPCHMEKDCHI().SetFloat("MouseX", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("[MapEditor] Loaded music file: ", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1395f)
				{
					this._Distance = 1577f;
				}
				if (this._Distance < 626f)
				{
					this._Distance = 1390f;
				}
				this.GKILCDHJFEG().SetFloat("value", this._Distance);
			}
			else
			{
				this.DEFBJOCJJKF().SetFloat("GlassDistortion", this._Distance);
			}
			this.GKILCDHJFEG().SetFloat("_BlueAmplifier", this._Size);
			this.FLOHGDECHHH().SetColor("PLEASE WAIT", this.ScanColor);
			this.GKILCDHJFEG().SetFloat("\n", this._FixDistance);
			this.IFMAPIDFNLI().SetFloat("You need to have a Graphic control (such as an Image) for the list [", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IGKFMCPDNOI().SetFloat("_GrainTex", 1932f / farClipPlane);
			this.AELJLBOJAIL().SetVector("green", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 798f, 1949f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0000A079 File Offset: 0x00008279
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0000A755 File Offset: 0x00008955
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0000A78C File Offset: 0x0000898C
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0000A7B0 File Offset: 0x000089B0
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

	// Token: 0x060009C8 RID: 2504 RVA: 0x0000A7E7 File Offset: 0x000089E7
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x000E8D0C File Offset: 0x000E6F0C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1694f)
			{
				this.HBJJOCHGOPH = 1267f;
			}
			this.LPCHMEKDCHI().SetFloat("SetSunEmission", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("maps.", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 177f)
				{
					this._Distance = 335f;
				}
				if (this._Distance < 1719f)
				{
					this._Distance = 725f;
				}
				this.LPCHMEKDCHI().SetFloat("maps.", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("_Value2", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("]", this._Size);
			this.OGMEGHKECAH().SetColor("Incoming: \n", this.ScanColor);
			this.OGMEGHKECAH().SetFloat("GameScene", this._FixDistance);
			this.BFGNMFCNDBC().SetFloat("Set Crosshair Emission", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("SpawnObj", 1760f / farClipPlane);
			this.BAGICADFBAB().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1307f, 1797f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x0000A81E File Offset: 0x00008A1E
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_Bloom1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0000A842 File Offset: 0x00008A42
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x0000420A File Offset: 0x0000240A
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0000A879 File Offset: 0x00008A79
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x000E8EE8 File Offset: 0x000E70E8
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 408f)
			{
				this.HBJJOCHGOPH = 833f;
			}
			this.IFMAPIDFNLI().SetFloat("CameraFilterPack/Vision_Plasma", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("appid", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 953f)
				{
					this._Distance = 1447f;
				}
				if (this._Distance < 1501f)
				{
					this._Distance = 1527f;
				}
				this.OGMEGHKECAH().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this._Distance);
			}
			else
			{
				this.IIBLJCKLGFG().SetFloat("_Value", this._Distance);
			}
			this.DEFBJOCJJKF().SetFloat("_Value3", this._Size);
			this.HEINDEMCGIK().SetColor("_TimeX", this.ScanColor);
			this.OLHDPICFBOF().SetFloat("pointBuffer", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("Overlay", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMAALEODNH().SetFloat("/", 1658f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("_Vignetting2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 819f, 1867f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0000A079 File Offset: 0x00008279
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0000A079 File Offset: 0x00008279
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0000A079 File Offset: 0x00008279
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x0000A079 File Offset: 0x00008279
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x0000A079 File Offset: 0x00008279
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x0000A89D File Offset: 0x00008A9D
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000166 RID: 358
	public Shader SCShader;

	// Token: 0x04000167 RID: 359
	public bool _Visualize;

	// Token: 0x04000168 RID: 360
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000169 RID: 361
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400016A RID: 362
	private Material BJFKDHHMLJH;

	// Token: 0x0400016B RID: 363
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x0400016C RID: 364
	[Range(0f, 0.99f)]
	public float _Distance = 1f;

	// Token: 0x0400016D RID: 365
	[Range(0f, 0.1f)]
	public float _Size = 0.01f;

	// Token: 0x0400016E RID: 366
	public bool AutoAnimatedNear;

	// Token: 0x0400016F RID: 367
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 1f;

	// Token: 0x04000170 RID: 368
	public Color ScanColor = new Color(2f, 0f, 0f, 1f);

	// Token: 0x04000171 RID: 369
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000172 RID: 370
	public static Color ChangeColorRGB;

	// Token: 0x04000173 RID: 371
	private Texture2D FPHEBLMINDA;
}
