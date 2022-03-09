/*
Importance of this class: Unknown

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000028 RID: 40
[AddComponentMenu("Camera Filter Pack/3D/Shield")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Shield : MonoBehaviour
{
	// Token: 0x060009D6 RID: 2518 RVA: 0x0000A8D4 File Offset: 0x00008AD4
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x0000A90B File Offset: 0x00008B0B
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0000A942 File Offset: 0x00008B42
	private Material DCCHGBHLAAF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x0000A979 File Offset: 0x00008B79
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x0000420A File Offset: 0x0000240A
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x000E90C4 File Offset: 0x000E72C4
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 1553f;
			}
			this.FLGPDBBKAIP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 979f)
				{
					this._Distance = 1687f;
				}
				if (this._Distance < 675f)
				{
					this._Distance = 38f;
				}
				this.MJJIEHANFJA().SetFloat("Bad parameters for getstring! Use <key> <value>", this._Distance);
			}
			else
			{
				this.GJHPODJOBHL().SetFloat("ItemsCountText", this._Distance);
			}
			this.OKJOKHGJHGF().SetFloat("#or", this._Size);
			this.GJHPODJOBHL().SetFloat("y", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("Drop_With_Obj", this.LightIntensity * 366f);
			this.OIIDAKBILMI().SetFloat("_Speed", (float)((!this._Visualize) ? 1 : 1));
			this.OIIDAKBILMI().SetFloat("Item creation successful! Published Item ID: ", this._FadeShield);
			this.FGENHBKMPDA().SetFloat("00", this.Speed);
			this.DCCHGBHLAAF().SetFloat("_Value8", this.Speed_X);
			this.KOHGPKOFEJO().SetFloat("GameObject ", this.Speed_Y);
			this.IIJMIPBMMBF().SetFloat("_CurrentMipLevel", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/FX_ZebraColor", 562f / farClipPlane);
			this.DEFBJOCJJKF().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1576f, 846f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0000A996 File Offset: 0x00008B96
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x0000A9BA File Offset: 0x00008BBA
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x0000420A File Offset: 0x0000240A
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x0000A9DE File Offset: 0x00008BDE
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x0000A979 File Offset: 0x00008B79
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0000AA02 File Offset: 0x00008C02
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x0000AA39 File Offset: 0x00008C39
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x0000AA70 File Offset: 0x00008C70
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x0000AAA7 File Offset: 0x00008CA7
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("Ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x000E938C File Offset: 0x000E758C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 191f)
			{
				this.HBJJOCHGOPH = 1974f;
			}
			this.OIIDAKBILMI().SetFloat("Map: ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 951f)
				{
					this._Distance = 1486f;
				}
				if (this._Distance < 412f)
				{
					this._Distance = 50f;
				}
				this.OIIDAKBILMI().SetFloat("HightScoreMaxPointsText", this._Distance);
			}
			else
			{
				this.MJJIEHANFJA().SetFloat("PhotonServerSettings", this._Distance);
			}
			this.DEFBJOCJJKF().SetFloat("_MainTex", this._Size);
			this.LPPEPKGFOEM().SetFloat("/../", this._FixDistance);
			this.HNICHJCGJOC().SetFloat(":", this.LightIntensity * 756f);
			this.NBMPPNFKFLB().SetFloat("_Saturation", (float)((!this._Visualize) ? 1 : 1));
			this.IGKFMCPDNOI().SetFloat(".lastCheckpoint.time", this._FadeShield);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Vision_Plasma", this.Speed);
			this.KEMAALEODNH().SetFloat("icon.png", this.Speed_X);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", this.Speed_Y);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("_PositionX", 1230f / farClipPlane);
			this.HNICHJCGJOC().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 550f, 856f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x0000AACB File Offset: 0x00008CCB
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("_Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x0000AAEF File Offset: 0x00008CEF
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x0000AB13 File Offset: 0x00008D13
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("https://discord.gg/intralism");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x0000AB37 File Offset: 0x00008D37
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("sfxVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x0000A979 File Offset: 0x00008B79
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x0000A979 File Offset: 0x00008B79
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x0000420A File Offset: 0x0000240A
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x000E95C8 File Offset: 0x000E77C8
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 353f)
			{
				this.HBJJOCHGOPH = 786f;
			}
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack_OldFilm1", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 317f)
				{
					this._Distance = 317f;
				}
				if (this._Distance < 1864f)
				{
					this._Distance = 634f;
				}
				this.ACHNOHCLGOO().SetFloat("OneHand", this._Distance);
			}
			else
			{
				this.KEMAALEODNH().SetFloat("_TimeX", this._Distance);
			}
			this.ACHNOHCLGOO().SetFloat("mapselector.filter.officialsortmode", this._Size);
			this.IIBLJCKLGFG().SetFloat("_Greenness", this._FixDistance);
			this.PLBEJJIHFPB().SetFloat("ViewMenu", this.LightIntensity * 1352f);
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/Film_Grain", (float)((!this._Visualize) ? 0 : 0));
			this.FKEOGPDLBDD().SetFloat(".lastCheckpoint.isMapCompleted", this._FadeShield);
			this.DCCHGBHLAAF().SetFloat(".lastCheckpoint.checkpointsUsed", this.Speed);
			this.CIAFLBFJLEJ().SetFloat("_ReflectionTexture3", this.Speed_X);
			this.CIAFLBFJLEJ().SetFloat("HPText", this.Speed_Y);
			this.BFGNMFCNDBC().SetFloat("_CurveParams", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("Metal", 291f / farClipPlane);
			this.IIBLJCKLGFG().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 228f, 1505f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x0000AB5B File Offset: 0x00008D5B
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x0000AB92 File Offset: 0x00008D92
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x0000ABB6 File Offset: 0x00008DB6
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x0000A979 File Offset: 0x00008B79
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0000420A File Offset: 0x0000240A
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0000A979 File Offset: 0x00008B79
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x0000A979 File Offset: 0x00008B79
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0000ABED File Offset: 0x00008DED
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("sounds/hit_normal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x000E9804 File Offset: 0x000E7A04
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 421f)
			{
				this.HBJJOCHGOPH = 1944f;
			}
			this.HEINDEMCGIK().SetFloat("_NoiseTex", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1003f)
				{
					this._Distance = 27f;
				}
				if (this._Distance < 1436f)
				{
					this._Distance = 1100f;
				}
				this.FGENHBKMPDA().SetFloat("[SERVER] Selected mode: ", this._Distance);
			}
			else
			{
				this.IIJMIPBMMBF().SetFloat("roomDescription", this._Distance);
			}
			this.FGENHBKMPDA().SetFloat("HighScaleShot", this._Size);
			this.CECJJMKLEAK().SetFloat("_Wavy", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("RestartButton", this.LightIntensity * 948f);
			this.CECJJMKLEAK().SetFloat("MainCamera", (float)((!this._Visualize) ? 0 : 0));
			this.HNICHJCGJOC().SetFloat("menu.tabid", this._FadeShield);
			this.LELKBCALFCF().SetFloat("_Offsets", this.Speed);
			this.FKEOGPDLBDD().SetFloat("Day_", this.Speed_X);
			this.NBPKMLMCHFN.SetFloat("id", this.Speed_Y);
			this.IIJMIPBMMBF().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMAALEODNH().SetFloat("_Value3", 1988f / farClipPlane);
			this.KEMAALEODNH().SetVector("_BlurDirectionPacked", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 970f, 1074f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0000AC11 File Offset: 0x00008E11
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x0000420A File Offset: 0x0000240A
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0000AC48 File Offset: 0x00008E48
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0000A979 File Offset: 0x00008B79
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x000E9A40 File Offset: 0x000E7C40
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 445f)
			{
				this.HBJJOCHGOPH = 1000f;
			}
			this.KEMAALEODNH().SetFloat("/Segment-[Left]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1281f)
				{
					this._Distance = 1006f;
				}
				if (this._Distance < 1855f)
				{
					this._Distance = 293f;
				}
				this.NBPKMLMCHFN.SetFloat("GlassesColor2", this._Distance);
			}
			else
			{
				this.FGENHBKMPDA().SetFloat("_ScreenResolution", this._Distance);
			}
			this.HNICHJCGJOC().SetFloat(".png", this._Size);
			this.HNICHJCGJOC().SetFloat("_Sat", this._FixDistance);
			this.NBMPPNFKFLB().SetFloat("_ScreenResolution", this.LightIntensity * 1304f);
			this.OIIDAKBILMI().SetFloat("settings.showHP", (float)((!this._Visualize) ? 1 : 0));
			this.GJHPODJOBHL().SetFloat("ready", this._FadeShield);
			this.HJGEHJDMCGI().SetFloat("menutheme.jamaicanorcdub", this.Speed);
			this.FGENHBKMPDA().SetFloat("Winter2020", this.Speed_X);
			this.OKJOKHGJHGF().SetFloat("RarityImage", this.Speed_Y);
			this.PGPEMMBJOOG().SetFloat("/../", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIIDAKBILMI().SetFloat("Editor/", 1842f / farClipPlane);
			this.HNICHJCGJOC().SetVector("CameraFilterPack/Blend2Camera_GreenScreen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 14f, 72f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0000AC7F File Offset: 0x00008E7F
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x0000ACB6 File Offset: 0x00008EB6
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0000ACDA File Offset: 0x00008EDA
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x0000A979 File Offset: 0x00008B79
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x0000AD11 File Offset: 0x00008F11
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("settings.volume.editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x0000420A File Offset: 0x0000240A
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0000AD35 File Offset: 0x00008F35
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("EnvironmentSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x0000420A File Offset: 0x0000240A
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x000E9C7C File Offset: 0x000E7E7C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1429f)
			{
				this.HBJJOCHGOPH = 1963f;
			}
			this.DCCHGBHLAAF().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1601f)
				{
					this._Distance = 1391f;
				}
				if (this._Distance < 1019f)
				{
					this._Distance = 0f;
				}
				this.FKEOGPDLBDD().SetFloat("player.xp", this._Distance);
			}
			else
			{
				this.FKEOGPDLBDD().SetFloat("Tab1Content", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat(">", this._Size);
			this.DCCHGBHLAAF().SetFloat("menu.selectedplaymode", this._FixDistance);
			this.OKJOKHGJHGF().SetFloat("OK", this.LightIntensity * 320f);
			this.HJGEHJDMCGI().SetFloat("YES", (float)((!this._Visualize) ? 0 : 0));
			this.HJGEHJDMCGI().SetFloat("HPText", this._FadeShield);
			this.JFDGLLEOPGB().SetFloat("menu.tabid", this.Speed);
			this.MJJIEHANFJA().SetFloat("_Value3", this.Speed_X);
			this.LPPEPKGFOEM().SetFloat("seconds", this.Speed_Y);
			this.ACHNOHCLGOO().SetFloat("To Log", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("_ScreenResolution", 476f / farClipPlane);
			this.KOHGPKOFEJO().SetVector("UseScanLineSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 373f, 1925f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x000E9EB8 File Offset: 0x000E80B8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 460f)
			{
				this.HBJJOCHGOPH = 1072f;
			}
			this.PGPEMMBJOOG().SetFloat("_Green_C", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 53f)
				{
					this._Distance = 1682f;
				}
				if (this._Distance < 973f)
				{
					this._Distance = 233f;
				}
				this.PGPEMMBJOOG().SetFloat(".highscore", this._Distance);
			}
			else
			{
				this.NBMPPNFKFLB().SetFloat("Received event Leave for unknown player ID: {0}", this._Distance);
			}
			this.OKJOKHGJHGF().SetFloat("settings_bindings_controller_type", this._Size);
			this.JFDGLLEOPGB().SetFloat("id", this._FixDistance);
			this.NBMPPNFKFLB().SetFloat("_MainTex2", this.LightIntensity * 1941f);
			this.DEFBJOCJJKF().SetFloat("fade out duration", (float)((!this._Visualize) ? 0 : 0));
			this.IIJMIPBMMBF().SetFloat("NameText", this._FadeShield);
			this.CECJJMKLEAK().SetFloat("_Value4", this.Speed);
			this.PLBEJJIHFPB().SetFloat("TimeBGSlider", this.Speed_X);
			this.FLGPDBBKAIP().SetFloat("offsets", this.Speed_Y);
			this.GJHPODJOBHL().SetFloat("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HNICHJCGJOC().SetFloat("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", 483f / farClipPlane);
			this.FLGPDBBKAIP().SetVector("_ReflectionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1735f, 81f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0000AD59 File Offset: 0x00008F59
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("Incoming: \n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x0000420A File Offset: 0x0000240A
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x0000A979 File Offset: 0x00008B79
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x000EA0F4 File Offset: 0x000E82F4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1755f)
			{
				this.HBJJOCHGOPH = 618f;
			}
			this.CIAFLBFJLEJ().SetFloat("SetPosition", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1801f)
				{
					this._Distance = 1985f;
				}
				if (this._Distance < 513f)
				{
					this._Distance = 839f;
				}
				this.NBPKMLMCHFN.SetFloat("R:", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_ReflectionTexture2", this._Distance);
			}
			this.ACHNOHCLGOO().SetFloat("InventoryButton", this._Size);
			this.CECJJMKLEAK().SetFloat("Case-Sensitive", this._FixDistance);
			this.DCCHGBHLAAF().SetFloat("Operation failed: ", this.LightIntensity * 921f);
			this.GJHPODJOBHL().SetFloat("_EmissionColor", (float)((!this._Visualize) ? 1 : 0));
			this.IIBLJCKLGFG().SetFloat("settings.hitvariation", this._FadeShield);
			this.GJHPODJOBHL().SetFloat("settings.enablehitsoundsinrelax", this.Speed);
			this.FGENHBKMPDA().SetFloat("_Bullet_11", this.Speed_X);
			this.HJGEHJDMCGI().SetFloat("_TimeX", this.Speed_Y);
			this.HJGEHJDMCGI().SetFloat("colorA", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("RecieveChatActionMessage", 1748f / farClipPlane);
			this.CECJJMKLEAK().SetVector("Skipping packet for ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 746f, 1198f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x000EA330 File Offset: 0x000E8530
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1111f)
			{
				this.HBJJOCHGOPH = 781f;
			}
			this.NBMPPNFKFLB().SetFloat("CameraFilterPack/Gradients_Stripe", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 981f)
				{
					this._Distance = 884f;
				}
				if (this._Distance < 1824f)
				{
					this._Distance = 1752f;
				}
				this.IGKFMCPDNOI().SetFloat("t", this._Distance);
			}
			else
			{
				this.IIBLJCKLGFG().SetFloat("#", this._Distance);
			}
			this.FKEOGPDLBDD().SetFloat("{0} seconds ago", this._Size);
			this.DEFBJOCJJKF().SetFloat("GhostPosY", this._FixDistance);
			this.GJHPODJOBHL().SetFloat("Protocol switch from: ", this.LightIntensity * 160f);
			this.LPPEPKGFOEM().SetFloat("_Min", (float)((!this._Visualize) ? 0 : 1));
			this.FLGPDBBKAIP().SetFloat("LevelEditor/icons", this._FadeShield);
			this.FKEOGPDLBDD().SetFloat(".", this.Speed);
			this.DEFBJOCJJKF().SetFloat("[Right]", this.Speed_X);
			this.JFDGLLEOPGB().SetFloat("no lives color", this.Speed_Y);
			this.IIJMIPBMMBF().SetFloat("[MenuScene] Error: ", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OKJOKHGJHGF().SetFloat("_Value5", 1312f / farClipPlane);
			this.CIAFLBFJLEJ().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1708f, 1200f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x000EA56C File Offset: 0x000E876C
	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 801f)
			{
				this.HBJJOCHGOPH = 1973f;
			}
			this.BFGNMFCNDBC().SetFloat("_Value", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1568f)
				{
					this._Distance = 190f;
				}
				if (this._Distance < 840f)
				{
					this._Distance = 332f;
				}
				this.BFGNMFCNDBC().SetFloat("Value", this._Distance);
			}
			else
			{
				this.HJGEHJDMCGI().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this._Distance);
			}
			this.LPPEPKGFOEM().SetFloat("_ScreenResolution", this._Size);
			this.IIBLJCKLGFG().SetFloat("skin.", this._FixDistance);
			this.NBMPPNFKFLB().SetFloat("No Description", this.LightIntensity * 382f);
			this.ACHNOHCLGOO().SetFloat("_Quality", (float)((!this._Visualize) ? 1 : 1));
			this.OIIDAKBILMI().SetFloat(".lastCheckpoint.time", this._FadeShield);
			this.LPPEPKGFOEM().SetFloat("OnAwakeRPC", this.Speed);
			this.KEMAALEODNH().SetFloat("float,0", this.Speed_X);
			this.FKEOGPDLBDD().SetFloat("#timeuntilchallenge: ", this.Speed_Y);
			this.NBMPPNFKFLB().SetFloat("_TileMaxOffs", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IIBLJCKLGFG().SetFloat("/", 633f / farClipPlane);
			this.KEMAALEODNH().SetVector("OnSerialize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 761f, 1873f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x000EA7A8 File Offset: 0x000E89A8
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 203f;
			}
			this.JFDGLLEOPGB().SetFloat("_Source", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1706f)
				{
					this._Distance = 1121f;
				}
				if (this._Distance < 1598f)
				{
					this._Distance = 32f;
				}
				this.HEINDEMCGIK().SetFloat("_Value3", this._Distance);
			}
			else
			{
				this.KEMAALEODNH().SetFloat("CameraFilterPack/Color_Contrast", this._Distance);
			}
			this.IIJMIPBMMBF().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this._Size);
			this.GJHPODJOBHL().SetFloat("maps.", this._FixDistance);
			this.IIBLJCKLGFG().SetFloat("LevelURLInputField", this.LightIntensity * 1874f);
			this.IIJMIPBMMBF().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			this.ACHNOHCLGOO().SetFloat("_Glow", this._FadeShield);
			this.LPPEPKGFOEM().SetFloat("checkpoint", this.Speed);
			this.FLGPDBBKAIP().SetFloat("CameraFilterPack/Blend2Camera_Overlay", this.Speed_X);
			this.IGKFMCPDNOI().SetFloat(".lastCheckpoint.comboScore", this.Speed_Y);
			this.IIJMIPBMMBF().SetFloat("shader.ghost", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CECJJMKLEAK().SetFloat("_Value4", 1846f / farClipPlane);
			this.KEMAALEODNH().SetVector("steamid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1083f, 980f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x0000AD7D File Offset: 0x00008F7D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Shield");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x000EA9E4 File Offset: 0x000E8BE4
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 638f)
			{
				this.HBJJOCHGOPH = 933f;
			}
			this.KOHGPKOFEJO().SetFloat(",", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1054f)
				{
					this._Distance = 855f;
				}
				if (this._Distance < 202f)
				{
					this._Distance = 1727f;
				}
				this.IIJMIPBMMBF().SetFloat("CameraFilterPack_Paper2", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("PLAY [SPACE]", this._Distance);
			}
			this.CIAFLBFJLEJ().SetFloat("Joystick", this._Size);
			this.DEFBJOCJJKF().SetFloat("_OcclusionTexture", this._FixDistance);
			this.DCCHGBHLAAF().SetFloat(" SphereWaveform.cs", this.LightIntensity * 499f);
			this.LELKBCALFCF().SetFloat("_NormalAndRoughnessTexture", (float)((!this._Visualize) ? 1 : 1));
			this.LPPEPKGFOEM().SetFloat("misses", this._FadeShield);
			this.FKEOGPDLBDD().SetFloat("bad", this.Speed);
			this.OIIDAKBILMI().SetFloat("_TimeX", this.Speed_X);
			this.OIIDAKBILMI().SetFloat("OK", this.Speed_Y);
			this.LELKBCALFCF().SetFloat("_ScreenResolution", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("Cross", 1954f / farClipPlane);
			this.NBMPPNFKFLB().SetVector("CameraFilterPack/Vision_Psycho", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1690f, 1609f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x0000ADA1 File Offset: 0x00008FA1
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x0000A979 File Offset: 0x00008B79
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0000ADD8 File Offset: 0x00008FD8
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("Using constructor for new PingNativeDynamic()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x000EAC20 File Offset: 0x000E8E20
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 749f)
			{
				this.HBJJOCHGOPH = 780f;
			}
			this.HJGEHJDMCGI().SetFloat("LeaderboardsButton", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 890f)
				{
					this._Distance = 335f;
				}
				if (this._Distance < 1578f)
				{
					this._Distance = 815f;
				}
				this.FKEOGPDLBDD().SetFloat("896296812", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("_Value2", this._Distance);
			}
			this.DCCHGBHLAAF().SetFloat("SAVE FILE", this._Size);
			this.CIAFLBFJLEJ().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", this._FixDistance);
			this.KOHGPKOFEJO().SetFloat("InfoText", this.LightIntensity * 1262f);
			this.ACHNOHCLGOO().SetFloat("_Vibrance", (float)((!this._Visualize) ? 0 : 0));
			this.ACHNOHCLGOO().SetFloat("Illegal view ID:", this._FadeShield);
			this.BFGNMFCNDBC().SetFloat("#tryagain", this.Speed);
			this.HNICHJCGJOC().SetFloat("GlassDistortion", this.Speed_X);
			this.PGPEMMBJOOG().SetFloat("#accuracy", this.Speed_Y);
			this.IIBLJCKLGFG().SetFloat("skin.", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HJGEHJDMCGI().SetFloat("OpSettings()", 741f / farClipPlane);
			this.PLBEJJIHFPB().SetVector("STICKRVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 954f, 1416f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x0000ADFC File Offset: 0x00008FFC
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x0000AE33 File Offset: 0x00009033
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x0000AE6A File Offset: 0x0000906A
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x0000AEA1 File Offset: 0x000090A1
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x0000A979 File Offset: 0x00008B79
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x000EAE5C File Offset: 0x000E905C
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 194f)
			{
				this.HBJJOCHGOPH = 313f;
			}
			this.ACHNOHCLGOO().SetFloat("mapselector.filter.favoriteonly", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1335f)
				{
					this._Distance = 479f;
				}
				if (this._Distance < 91f)
				{
					this._Distance = 1495f;
				}
				this.OKJOKHGJHGF().SetFloat("_Value6", this._Distance);
			}
			else
			{
				this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this._Distance);
			}
			this.HNICHJCGJOC().SetFloat("EnableRankedNotificationsToggle", this._Size);
			this.IIJMIPBMMBF().SetFloat("Mouse Y", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this.LightIntensity * 1990f);
			this.PLBEJJIHFPB().SetFloat("mapselector.filter.subscribedonly", (float)((!this._Visualize) ? 1 : 1));
			this.PLBEJJIHFPB().SetFloat("/files/editor_manual.pdf", this._FadeShield);
			this.HJGEHJDMCGI().SetFloat("GlassColor", this.Speed);
			this.BFGNMFCNDBC().SetFloat("] to be droppable", this.Speed_X);
			this.PLBEJJIHFPB().SetFloat("sprite", this.Speed_Y);
			this.KEMAALEODNH().SetFloat("_Blurred", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DCCHGBHLAAF().SetFloat("_Offsets", 359f / farClipPlane);
			this.KOHGPKOFEJO().SetVector("_Threshold", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 438f, 586f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x000EB098 File Offset: 0x000E9298
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1661f)
			{
				this.HBJJOCHGOPH = 1430f;
			}
			this.FKEOGPDLBDD().SetFloat("_Value2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 542f)
				{
					this._Distance = 1226f;
				}
				if (this._Distance < 1150f)
				{
					this._Distance = 654f;
				}
				this.IGKFMCPDNOI().SetFloat("Children", this._Distance);
			}
			else
			{
				this.MJJIEHANFJA().SetFloat("_ScreenResolution", this._Distance);
			}
			this.CIAFLBFJLEJ().SetFloat("[Right]", this._Size);
			this.GJHPODJOBHL().SetFloat("EventData0DropDownList", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat("SetEnvSpriteColor", this.LightIntensity * 511f);
			this.IIBLJCKLGFG().SetFloat("masterSteamID", (float)((!this._Visualize) ? 1 : 0));
			this.KOHGPKOFEJO().SetFloat("_ForceYSwap", this._FadeShield);
			this.NBMPPNFKFLB().SetFloat(" region", this.Speed);
			this.IIJMIPBMMBF().SetFloat("EventMenu", this.Speed_X);
			this.FGENHBKMPDA().SetFloat("#forever", this.Speed_Y);
			this.NBPKMLMCHFN.SetFloat("ChangeSelectedLevel", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("_Red_C", 908f / farClipPlane);
			this.BFGNMFCNDBC().SetVector("_TraceBehindObjects", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1271f, 839f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x0000AED8 File Offset: 0x000090D8
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("_BlurTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x0000420A File Offset: 0x0000240A
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x0000420A File Offset: 0x0000240A
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x0000AEFC File Offset: 0x000090FC
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0000AF33 File Offset: 0x00009133
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("[PlayerBase] Loading checkpoint data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x0000A979 File Offset: 0x00008B79
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x0000A996 File Offset: 0x00008B96
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x000EB2D4 File Offset: 0x000E94D4
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 55f)
			{
				this.HBJJOCHGOPH = 1157f;
			}
			this.FKEOGPDLBDD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 913f)
				{
					this._Distance = 1486f;
				}
				if (this._Distance < 1007f)
				{
					this._Distance = 1047f;
				}
				this.GJHPODJOBHL().SetFloat("_FixDistance", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("UseScanLineSize", this._Distance);
			}
			this.KOHGPKOFEJO().SetFloat("_FarCamera", this._Size);
			this.KOHGPKOFEJO().SetFloat("_ScreenResolution", this._FixDistance);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Distortion_Flush", this.LightIntensity * 964f);
			this.HJGEHJDMCGI().SetFloat("settings.enablehitsoundsinnormal", (float)((!this._Visualize) ? 0 : 1));
			this.GJHPODJOBHL().SetFloat("_WaveIntensity", this._FadeShield);
			this.PGPEMMBJOOG().SetFloat("_FixDistance", this.Speed);
			this.HNICHJCGJOC().SetFloat("_Intensity", this.Speed_X);
			this.ACHNOHCLGOO().SetFloat("Drop_With_Obj", this.Speed_Y);
			this.LPPEPKGFOEM().SetFloat("/icon", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FGENHBKMPDA().SetFloat("maps.", 1047f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("CloseConnection: Only the masterclient can kick another player.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 257f, 530f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x0000AF57 File Offset: 0x00009157
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find(". Going to ignore! Check PhotonServerSettings.RpcList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x000EB510 File Offset: 0x000E9710
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 411f)
			{
				this.HBJJOCHGOPH = 1348f;
			}
			this.LELKBCALFCF().SetFloat("masterSteamID", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 787f)
				{
					this._Distance = 1812f;
				}
				if (this._Distance < 1740f)
				{
					this._Distance = 1785f;
				}
				this.OIIDAKBILMI().SetFloat("_Bullet_4", this._Distance);
			}
			else
			{
				this.FKEOGPDLBDD().SetFloat("randomdrop", this._Distance);
			}
			this.OIIDAKBILMI().SetFloat("_Value3", this._Size);
			this.GJHPODJOBHL().SetFloat("RB", this._FixDistance);
			this.PLBEJJIHFPB().SetFloat("Please specify either t or f.", this.LightIntensity * 1389f);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 0 : 0));
			this.CIAFLBFJLEJ().SetFloat("#startofflinemessage", this._FadeShield);
			this.IGKFMCPDNOI().SetFloat("_DotSize", this.Speed);
			this.IIBLJCKLGFG().SetFloat("Drop_With_Obj", this.Speed_X);
			this.KOHGPKOFEJO().SetFloat(" ", this.Speed_Y);
			this.NBMPPNFKFLB().SetFloat("inventory.itemscash", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FKEOGPDLBDD().SetFloat("_TimeX", 740f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("_PosX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 458f, 1289f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x0000AF7B File Offset: 0x0000917B
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("bpmgrid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x000EB74C File Offset: 0x000E994C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1053f)
			{
				this.HBJJOCHGOPH = 623f;
			}
			this.LPPEPKGFOEM().SetFloat(" x ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 472f)
				{
					this._Distance = 1387f;
				}
				if (this._Distance < 574f)
				{
					this._Distance = 880f;
				}
				this.CECJJMKLEAK().SetFloat("_Value5", this._Distance);
			}
			else
			{
				this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Blur_Regular", this._Distance);
			}
			this.NBMPPNFKFLB().SetFloat("PlayButton", this._Size);
			this.PGPEMMBJOOG().SetFloat("_Value2", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("stretchWidth", this.LightIntensity * 1006f);
			this.MJJIEHANFJA().SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 0));
			this.OKJOKHGJHGF().SetFloat("offsets", this._FadeShield);
			this.FKEOGPDLBDD().SetFloat("LivesSlider", this.Speed);
			this.PGPEMMBJOOG().SetFloat("_CutOff", this.Speed_X);
			this.BFGNMFCNDBC().SetFloat("Items/", this.Speed_Y);
			this.OKJOKHGJHGF().SetFloat("_Value6", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLGPDBBKAIP().SetFloat("/files/mods_terms.pdf", 194f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 57f, 157f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x0000AF9F File Offset: 0x0000919F
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x0000AFD6 File Offset: 0x000091D6
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x0000AFFA File Offset: 0x000091FA
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x0000B031 File Offset: 0x00009231
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x0000B068 File Offset: 0x00009268
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0000B09F File Offset: 0x0000929F
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

	// Token: 0x06000A2E RID: 2606 RVA: 0x0000420A File Offset: 0x0000240A
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x0000B0D6 File Offset: 0x000092D6
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("tagElement");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x0000A979 File Offset: 0x00008B79
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x0000B0FA File Offset: 0x000092FA
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("SetParticlesCountPerBeat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x0000B11E File Offset: 0x0000931E
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Atmosphere_Rain_FX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x0000B142 File Offset: 0x00009342
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_TexelOffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x0000B166 File Offset: 0x00009366
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("_SoftZDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x0000B18A File Offset: 0x0000938A
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x0000A979 File Offset: 0x00008B79
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x0000A979 File Offset: 0x00008B79
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x000EB988 File Offset: 0x000E9B88
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
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
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FadeShield", this._FadeShield);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed_X);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Speed_Y);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Intensity);
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

	// Token: 0x06000A3A RID: 2618 RVA: 0x000EBBC4 File Offset: 0x000E9DC4
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1192f)
			{
				this.HBJJOCHGOPH = 852f;
			}
			this.HEINDEMCGIK().SetFloat(", ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 372f)
				{
					this._Distance = 589f;
				}
				if (this._Distance < 992f)
				{
					this._Distance = 312f;
				}
				this.FKEOGPDLBDD().SetFloat("_Value2", this._Distance);
			}
			else
			{
				this.LELKBCALFCF().SetFloat("_Value", this._Distance);
			}
			this.IIJMIPBMMBF().SetFloat("_MainTex2", this._Size);
			this.CIAFLBFJLEJ().SetFloat("_HalfResolution", this._FixDistance);
			this.DEFBJOCJJKF().SetFloat("#FFFFFFFF", this.LightIntensity * 1613f);
			this.LELKBCALFCF().SetFloat("[PlayerBase] SetBGColor error: ", (float)((!this._Visualize) ? 1 : 0));
			this.CIAFLBFJLEJ().SetFloat(",", this._FadeShield);
			this.FKEOGPDLBDD().SetFloat("Tonemapper curve texture", this.Speed);
			this.HNICHJCGJOC().SetFloat("#yes", this.Speed_X);
			this.IIJMIPBMMBF().SetFloat("image", this.Speed_Y);
			this.CIAFLBFJLEJ().SetFloat("settings.arcsdestroydelay", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OKJOKHGJHGF().SetFloat("Data", 692f / farClipPlane);
			this.FLGPDBBKAIP().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1993f, 1354f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x0000B1C1 File Offset: 0x000093C1
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x0000B1E5 File Offset: 0x000093E5
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x0000B21C File Offset: 0x0000941C
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find(".played");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x000EBE00 File Offset: 0x000EA000
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1886f)
			{
				this.HBJJOCHGOPH = 742f;
			}
			this.HNICHJCGJOC().SetFloat("Identity LUT", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 568f)
				{
					this._Distance = 1850f;
				}
				if (this._Distance < 1242f)
				{
					this._Distance = 1030f;
				}
				this.IIJMIPBMMBF().SetFloat("Left", this._Distance);
			}
			else
			{
				this.FGENHBKMPDA().SetFloat("bpmgrid", this._Distance);
			}
			this.PGPEMMBJOOG().SetFloat(" or player:", this._Size);
			this.GJHPODJOBHL().SetFloat("Set object anchor to another object", this._FixDistance);
			this.HEINDEMCGIK().SetFloat(".", this.LightIntensity * 628f);
			this.FLGPDBBKAIP().SetFloat("ItemNameBGImage", (float)((!this._Visualize) ? 1 : 0));
			this.DCCHGBHLAAF().SetFloat("CameraFilterPack/Light_Water2", this._FadeShield);
			this.DCCHGBHLAAF().SetFloat("_MainTex2", this.Speed);
			this.HNICHJCGJOC().SetFloat(" player(s)", this.Speed_X);
			this.DCCHGBHLAAF().SetFloat("_Value", this.Speed_Y);
			this.LELKBCALFCF().SetFloat("#rategameinfo", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Distortion_BlackHole", 1368f / farClipPlane);
			this.IIJMIPBMMBF().SetVector("[NetworkManager] Join failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1117f, 1285f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x0000420A File Offset: 0x0000240A
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x0000B240 File Offset: 0x00009440
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0000420A File Offset: 0x0000240A
	private void DEEPMOLMGED()
	{
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x0000B277 File Offset: 0x00009477
	private void GNJDKAECPKA()
	{
		this.SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x0000B29B File Offset: 0x0000949B
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x0000B2D2 File Offset: 0x000094D2
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x0000B2F6 File Offset: 0x000094F6
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0000A979 File Offset: 0x00008B79
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x0000A979 File Offset: 0x00008B79
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x0000420A File Offset: 0x0000240A
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0000B32D File Offset: 0x0000952D
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("_NeighbourMaxTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x0000B351 File Offset: 0x00009551
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x0000A979 File Offset: 0x00008B79
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0000B388 File Offset: 0x00009588
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0000B3AC File Offset: 0x000095AC
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0000A979 File Offset: 0x00008B79
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x0000A979 File Offset: 0x00008B79
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x0000B3D0 File Offset: 0x000095D0
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x0000420A File Offset: 0x0000240A
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x000EC03C File Offset: 0x000EA23C
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1920f)
			{
				this.HBJJOCHGOPH = 1069f;
			}
			this.KOHGPKOFEJO().SetFloat("Gameplay/sprite", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1641f)
				{
					this._Distance = 1760f;
				}
				if (this._Distance < 1434f)
				{
					this._Distance = 1877f;
				}
				this.PLBEJJIHFPB().SetFloat("Identity LUT", this._Distance);
			}
			else
			{
				this.FKEOGPDLBDD().SetFloat("_TimeX", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Size", this._Size);
			this.OKJOKHGJHGF().SetFloat("Data/Localization", this._FixDistance);
			this.NBMPPNFKFLB().SetFloat("[PlayerController] ", this.LightIntensity * 558f);
			this.FLGPDBBKAIP().SetFloat("SetCrosshairColor", (float)((!this._Visualize) ? 0 : 0));
			this.KOHGPKOFEJO().SetFloat("#tryagain", this._FadeShield);
			this.GJHPODJOBHL().SetFloat("[Left]", this.Speed);
			this.LPPEPKGFOEM().SetFloat("_TimeX", this.Speed_X);
			this.KOHGPKOFEJO().SetFloat("_TimeX", this.Speed_Y);
			this.OKJOKHGJHGF().SetFloat("{0}", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("#TBD", 401f / farClipPlane);
			this.CECJJMKLEAK().SetVector("stretchWidth", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 435f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x0000A979 File Offset: 0x00008B79
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x000EC278 File Offset: 0x000EA478
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1599f)
			{
				this.HBJJOCHGOPH = 1084f;
			}
			this.IGKFMCPDNOI().SetFloat("[SERVER] Selected mode: ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 273f)
				{
					this._Distance = 1339f;
				}
				if (this._Distance < 945f)
				{
					this._Distance = 1105f;
				}
				this.GJHPODJOBHL().SetFloat("Please specify either t or f.", this._Distance);
			}
			else
			{
				this.NBMPPNFKFLB().SetFloat(" not exist", this._Distance);
			}
			this.GJHPODJOBHL().SetFloat("_MatrixColor", this._Size);
			this.IIJMIPBMMBF().SetFloat("_SSAO", this._FixDistance);
			this.OKJOKHGJHGF().SetFloat(": ", this.LightIntensity * 726f);
			this.PLBEJJIHFPB().SetFloat("float,0", (float)((!this._Visualize) ? 1 : 1));
			this.KEMAALEODNH().SetFloat("_VignettingColor", this._FadeShield);
			this.HNICHJCGJOC().SetFloat("x", this.Speed);
			this.GJHPODJOBHL().SetFloat("_Offsets", this.Speed_X);
			this.HEINDEMCGIK().SetFloat("player.bat", this.Speed_Y);
			this.LPPEPKGFOEM().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HEINDEMCGIK().SetFloat("RequestForPickupItems", 1818f / farClipPlane);
			this.KOHGPKOFEJO().SetVector("Hidden/DepthOfField/DepthOfField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1933f, 346f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x000EC4B4 File Offset: 0x000EA6B4
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 353f)
			{
				this.HBJJOCHGOPH = 1128f;
			}
			this.NBMPPNFKFLB().SetFloat("StartButton", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1857f)
				{
					this._Distance = 195f;
				}
				if (this._Distance < 1153f)
				{
					this._Distance = 810f;
				}
				this.FGENHBKMPDA().SetFloat("_AxialAberration", this._Distance);
			}
			else
			{
				this.CIAFLBFJLEJ().SetFloat("menu.selectedplaymode", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this._Size);
			this.FLGPDBBKAIP().SetFloat("_EmissionColor", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("_Value2", this.LightIntensity * 1933f);
			this.CECJJMKLEAK().SetFloat("SaveButton", (float)((!this._Visualize) ? 1 : 0));
			this.LELKBCALFCF().SetFloat("FinalScoreSmallText", this._FadeShield);
			this.IGKFMCPDNOI().SetFloat("LoadMapCanvas", this.Speed);
			this.FGENHBKMPDA().SetFloat("Chat", this.Speed_X);
			this.FLGPDBBKAIP().SetFloat("_Value2", this.Speed_Y);
			this.LPPEPKGFOEM().SetFloat("SetEnvSpriteImage", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/TV_WideScreenHV", 82f / farClipPlane);
			this.CECJJMKLEAK().SetVector("CameraFilterPack/Blend2Camera_BlueScreen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 699f, 1494f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x0000A979 File Offset: 0x00008B79
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x0000B3F4 File Offset: 0x000095F4
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x0000A979 File Offset: 0x00008B79
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x0000A979 File Offset: 0x00008B79
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x0000420A File Offset: 0x0000240A
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x000EC6F0 File Offset: 0x000EA8F0
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1241f)
			{
				this.HBJJOCHGOPH = 1114f;
			}
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1225f)
				{
					this._Distance = 1142f;
				}
				if (this._Distance < 1545f)
				{
					this._Distance = 15f;
				}
				this.PLBEJJIHFPB().SetFloat("_Value", this._Distance);
			}
			else
			{
				this.ACHNOHCLGOO().SetFloat("Up", this._Distance);
			}
			this.MJJIEHANFJA().SetFloat("_ScreenResolution", this._Size);
			this.FGENHBKMPDA().SetFloat("_TimeX", this._FixDistance);
			this.HNICHJCGJOC().SetFloat("_InternalLutTex", this.LightIntensity * 93f);
			this.IGKFMCPDNOI().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", (float)((!this._Visualize) ? 1 : 1));
			this.PLBEJJIHFPB().SetFloat("_Line", this._FadeShield);
			this.DCCHGBHLAAF().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Speed);
			this.OKJOKHGJHGF().SetFloat("ConfigVersionSlider", this.Speed_X);
			this.KEMAALEODNH().SetFloat("value", this.Speed_Y);
			this.MJJIEHANFJA().SetFloat("Texture2", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_TimeX", 425f / farClipPlane);
			this.LPPEPKGFOEM().SetVector("_DotSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 854f, 684f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x000EC92C File Offset: 0x000EAB2C
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 213f)
			{
				this.HBJJOCHGOPH = 1571f;
			}
			this.KOHGPKOFEJO().SetFloat("MaxLivesSlider", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1095f)
				{
					this._Distance = 1446f;
				}
				if (this._Distance < 17f)
				{
					this._Distance = 977f;
				}
				this.HEINDEMCGIK().SetFloat("menu.tabid", this._Distance);
			}
			else
			{
				this.KOHGPKOFEJO().SetFloat("_Amount", this._Distance);
			}
			this.LELKBCALFCF().SetFloat(" user's map(s)", this._Size);
			this.NBMPPNFKFLB().SetFloat("Dropped Object: ", this._FixDistance);
			this.PLBEJJIHFPB().SetFloat("visible", this.LightIntensity * 1931f);
			this.OKJOKHGJHGF().SetFloat("_FixDistance", (float)((!this._Visualize) ? 0 : 0));
			this.OIIDAKBILMI().SetFloat("_SSAO", this._FadeShield);
			this.HEINDEMCGIK().SetFloat("CloseConnection: No such player connected!", this.Speed);
			this.FGENHBKMPDA().SetFloat("[#clicktoacceptchallenge]", this.Speed_X);
			this.LPPEPKGFOEM().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.Speed_Y);
			this.IGKFMCPDNOI().SetFloat("_Light", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMAALEODNH().SetFloat("_TimeX", 910f / farClipPlane);
			this.ACHNOHCLGOO().SetVector("BloodAlternative2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 633f, 1029f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x0000B418 File Offset: 0x00009618
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x0000B43C File Offset: 0x0000963C
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("[EMPTY]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000174 RID: 372
	public Shader SCShader;

	// Token: 0x04000175 RID: 373
	public bool _Visualize;

	// Token: 0x04000176 RID: 374
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000177 RID: 375
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000178 RID: 376
	private Material BJFKDHHMLJH;

	// Token: 0x04000179 RID: 377
	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	// Token: 0x0400017A RID: 378
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	// Token: 0x0400017B RID: 379
	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	// Token: 0x0400017C RID: 380
	[Range(0f, 1f)]
	public float _FadeShield = 0.75f;

	// Token: 0x0400017D RID: 381
	[Range(-0.2f, 0.2f)]
	public float LightIntensity = 0.025f;

	// Token: 0x0400017E RID: 382
	public bool AutoAnimatedNear;

	// Token: 0x0400017F RID: 383
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000180 RID: 384
	[Range(0f, 10f)]
	public float Speed = 0.2f;

	// Token: 0x04000181 RID: 385
	[Range(0f, 10f)]
	public float Speed_X = 0.2f;

	// Token: 0x04000182 RID: 386
	[Range(0f, 1f)]
	public float Speed_Y = 0.3f;

	// Token: 0x04000183 RID: 387
	[Range(0f, 10f)]
	public float Intensity = 2.4f;

	// Token: 0x04000184 RID: 388
	public static Color ChangeColorRGB;
}
