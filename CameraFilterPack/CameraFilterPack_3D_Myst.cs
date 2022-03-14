/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000026 RID: 38
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Myst")]
public class CameraFilterPack_3D_Myst : MonoBehaviour
{
	// Token: 0x060008DB RID: 2267 RVA: 0x00009398 File Offset: 0x00007598
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x0000420A File Offset: 0x0000240A
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x000093CF File Offset: 0x000075CF
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load(": ") as Texture2D);
		this.SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00009408 File Offset: 0x00007608
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("_DistortionLevel") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x000E2874 File Offset: 0x000E0A74
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 230f)
			{
				this.HBJJOCHGOPH = 657f;
			}
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 784f)
				{
					this._Distance = 1735f;
				}
				if (this._Distance < 1301f)
				{
					this._Distance = 1762f;
				}
				this.FEAEGGCNIAA().SetFloat("SpawnObj", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("Reset XP", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_FarCamera", this._Size);
			this.JLHLHKPHDFO().SetFloat("menu.enableselectormusic", (float)((!this._Visualize) ? 0 : 0));
			this.HKIMAANBGMJ().SetFloat("levelcompleted", this._FixDistance);
			this.ADAFMBOGPLN().SetFloat(". Going to authenticate anyways.", this.DistortionLevel * 1426f);
			this.HHLFDHNEIAH().SetFloat("\n", this.DistortionSize * 319f);
			this.NMDBCDFPGOK().SetFloat("Y", this.LightIntensity * 130f);
			this.OCMBHMLNCEK().SetTexture("Hex value #RRGGBB", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("x", 679f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("[UI] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1437f, 280f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00009441 File Offset: 0x00007641
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x000E2AFC File Offset: 0x000E0CFC
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 623f)
			{
				this.HBJJOCHGOPH = 1684f;
			}
			this.ADBKPGFMNKO().SetFloat("/music", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 730f)
				{
					this._Distance = 1828f;
				}
				if (this._Distance < 5f)
				{
					this._Distance = 559f;
				}
				this.HHLFDHNEIAH().SetFloat("BloodAlternative3", this._Distance);
			}
			else
			{
				this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this._Distance);
			}
			this.OCMBHMLNCEK().SetFloat("GraphicsQualitySlider", this._Size);
			this.CECICEGFHKL().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.GHHPOGODBHB().SetFloat(":", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("input", this.DistortionLevel * 1004f);
			this.NBPKMLMCHFN.SetFloat("bad", this.DistortionSize * 1218f);
			this.ADAFMBOGPLN().SetFloat("_MainTex2", this.LightIntensity * 1123f);
			this.HFBJAOFLCJI().SetTexture(",", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADAFMBOGPLN().SetFloat("Tab2Content", 1755f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1082f, 937f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00009441 File Offset: 0x00007641
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x0000945E File Offset: 0x0000765E
	private void LFAFJKJAEEL()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/TV_ARCADE_2") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x000E2D18 File Offset: 0x000E0F18
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1649f)
			{
				this.HBJJOCHGOPH = 1668f;
			}
			this.ADBKPGFMNKO().SetFloat("In Network lobby", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1331f)
				{
					this._Distance = 222f;
				}
				if (this._Distance < 848f)
				{
					this._Distance = 481f;
				}
				this.GCDFNHMJMIP().SetFloat("skin.hit_wrong", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("GameMessagesDurationSlider", this._Distance);
			}
			this.ADBKPGFMNKO().SetFloat("ResetButton", this._Size);
			this.CECICEGFHKL().SetFloat("/Saved Games/", (float)((!this._Visualize) ? 1 : 0));
			this.CFEDGDGBCHE().SetFloat("_Value3", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("maps.", this.DistortionLevel * 723f);
			this.HKIMAANBGMJ().SetFloat("mapselector.filter.favoriteonly", this.DistortionSize * 110f);
			this.HHLFDHNEIAH().SetFloat("_NoiseTex", this.LightIntensity * 1332f);
			this.KEMJNOMIPHN().SetTexture("EventTimeInputField", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKHBBBFLGJH().SetFloat("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", 1789f / farClipPlane);
			this.GCDFNHMJMIP().SetVector("player.quantum", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 741f, 1412f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00009497 File Offset: 0x00007697
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00009441 File Offset: 0x00007641
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00009441 File Offset: 0x00007641
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x0000420A File Offset: 0x0000240A
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060008EB RID: 2283 RVA: 0x000094CE File Offset: 0x000076CE
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

	// Token: 0x060008EC RID: 2284 RVA: 0x00009505 File Offset: 0x00007705
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00009441 File Offset: 0x00007641
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x0000953C File Offset: 0x0000773C
	private void LFBGJIIECLD()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value8") as Texture2D);
		this.SCShader = Shader.Find("[ERROR KEY {0}]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x0000420A File Offset: 0x0000240A
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x0000420A File Offset: 0x0000240A
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x000E2F34 File Offset: 0x000E1134
	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 651f)
			{
				this.HBJJOCHGOPH = 1450f;
			}
			this.OCMBHMLNCEK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 307f)
				{
					this._Distance = 1644f;
				}
				if (this._Distance < 1254f)
				{
					this._Distance = 1004f;
				}
				this.NMDBCDFPGOK().SetFloat("#", this._Distance);
			}
			else
			{
				this.CECICEGFHKL().SetFloat("#FFDA44", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("_Value", this._Size);
			this.ADBKPGFMNKO().SetFloat("[NetworkManager] Joined room with ", (float)((!this._Visualize) ? 1 : 0));
			this.NBPKMLMCHFN.SetFloat("_FarCamera", this._FixDistance);
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.DistortionLevel * 177f);
			this.JLHLHKPHDFO().SetFloat("maps.", this.DistortionSize * 53f);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.LightIntensity * 694f);
			this.OCMBHMLNCEK().SetTexture("_DiffuseColor", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKIMAANBGMJ().SetFloat("_MainTex2", 796f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("settings.fps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 959f, 762f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x000E3150 File Offset: 0x000E1350
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 19f)
			{
				this.HBJJOCHGOPH = 1671f;
			}
			this.KEMJNOMIPHN().SetFloat("_OcclusionTexture", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 171f)
				{
					this._Distance = 1971f;
				}
				if (this._Distance < 695f)
				{
					this._Distance = 1715f;
				}
				this.KEMJNOMIPHN().SetFloat(" isOwnerActive: ", this._Distance);
			}
			else
			{
				this.GCDFNHMJMIP().SetFloat("_Value4", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("FPSToggle", this._Size);
			this.LMLENGFLEBD().SetFloat("ShowTitle", (float)((!this._Visualize) ? 1 : 0));
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Curve", this._FixDistance);
			this.JLHLHKPHDFO().SetFloat("Selection Box", this.DistortionLevel * 11f);
			this.NBPKMLMCHFN.SetFloat("/", this.DistortionSize * 735f);
			this.HHLFDHNEIAH().SetFloat("_Axis", this.LightIntensity * 1198f);
			this.HKIMAANBGMJ().SetTexture("note.1", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EOCCJGIGEGJ().SetFloat("_Value2", 1133f / farClipPlane);
			this.LMLENGFLEBD().SetVector("_Near", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1092f, 425f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00009575 File Offset: 0x00007775
	private void DBLILJGKGHJ()
	{
		this.FPHEBLMINDA = (Resources.Load("points:") as Texture2D);
		this.SCShader = Shader.Find("UI Extensions/SoftMaskShaderText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00009441 File Offset: 0x00007641
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x000095AE File Offset: 0x000077AE
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Heigh") as Texture2D);
		this.SCShader = Shader.Find("VIGNETTE_CLASSIC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x000095E7 File Offset: 0x000077E7
	private void NEFHGMNAPEP()
	{
		this.FPHEBLMINDA = (Resources.Load("0,2,true,0") as Texture2D);
		this.SCShader = Shader.Find("Joystick1Button8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00009441 File Offset: 0x00007641
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00009441 File Offset: 0x00007641
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x000E336C File Offset: 0x000E156C
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 254f)
			{
				this.HBJJOCHGOPH = 1682f;
			}
			this.EOCCJGIGEGJ().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 260f)
				{
					this._Distance = 832f;
				}
				if (this._Distance < 1454f)
				{
					this._Distance = 409f;
				}
				this.CFEDGDGBCHE().SetFloat("w", this._Distance);
			}
			else
			{
				this.HKIMAANBGMJ().SetFloat("player.mysteryitem", this._Distance);
			}
			this.ADAFMBOGPLN().SetFloat("Tab2Content", this._Size);
			this.HFBJAOFLCJI().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 1));
			this.JLHLHKPHDFO().SetFloat("SetPlayerDistance", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("KickThePlayer", this.DistortionLevel * 615f);
			this.HKHBBBFLGJH().SetFloat("ResourceIDInputField", this.DistortionSize * 1246f);
			this.CECICEGFHKL().SetFloat("_TimeX", this.LightIntensity * 1673f);
			this.GCDFNHMJMIP().SetTexture("_Value", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat("CameraFilterPack/Alien_Vision", 1139f / farClipPlane);
			this.JLHLHKPHDFO().SetVector("_Parameter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1703f, 53f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x000E3588 File Offset: 0x000E1788
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1287f)
			{
				this.HBJJOCHGOPH = 894f;
			}
			this.LMLENGFLEBD().SetFloat("InputField", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 356f)
				{
					this._Distance = 789f;
				}
				if (this._Distance < 848f)
				{
					this._Distance = 1839f;
				}
				this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", this._Distance);
			}
			else
			{
				this.MFHPKGICPIO().SetFloat("CameraFilterPack/Real_VHS", this._Distance);
			}
			this.HKHBBBFLGJH().SetFloat("/icon", this._Size);
			this.NBPKMLMCHFN.SetFloat("_Value", (float)((!this._Visualize) ? 0 : 0));
			this.LMLENGFLEBD().SetFloat("_Value5", this._FixDistance);
			this.CECICEGFHKL().SetFloat("[PlayerController] ", this.DistortionLevel * 928f);
			this.GHHPOGODBHB().SetFloat("LastNewsButton", this.DistortionSize * 1001f);
			this.HHLFDHNEIAH().SetFloat("resource id", this.LightIntensity * 797f);
			this.HKHBBBFLGJH().SetTexture("_Value2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GCDFNHMJMIP().SetFloat("CameraMovementSlider", 1349f / farClipPlane);
			this.EFDEIFCDAFG().SetVector("System.Int64", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1981f, 1584f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00009441 File Offset: 0x00007641
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00009620 File Offset: 0x00007820
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00009441 File Offset: 0x00007641
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00009657 File Offset: 0x00007857
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x0000420A File Offset: 0x0000240A
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x0000968E File Offset: 0x0000788E
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("Multiplayer") as Texture2D);
		this.SCShader = Shader.Find("PossibleMapMaxScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x000096C7 File Offset: 0x000078C7
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00009441 File Offset: 0x00007641
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x000E37A4 File Offset: 0x000E19A4
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 662f)
			{
				this.HBJJOCHGOPH = 390f;
			}
			this.KEMJNOMIPHN().SetFloat("[#clicktoacceptchallenge]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 534f)
				{
					this._Distance = 283f;
				}
				if (this._Distance < 156f)
				{
					this._Distance = 1902f;
				}
				this.LMLENGFLEBD().SetFloat("Scale environment object by the values", this._Distance);
			}
			else
			{
				this.ADBKPGFMNKO().SetFloat("\n", this._Distance);
			}
			this.HKHBBBFLGJH().SetFloat("[PlayerController] ", this._Size);
			this.FEAEGGCNIAA().SetFloat("_ColorBuffer", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("PerfectHitsScoreText", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("_MainTex2", this.DistortionLevel * 898f);
			this.EOCCJGIGEGJ().SetFloat("$ {0}", this.DistortionSize * 1458f);
			this.HHLFDHNEIAH().SetFloat("Ev OwnershipRequest ", this.LightIntensity * 1723f);
			this.GHHPOGODBHB().SetTexture("SetLives", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NMDBCDFPGOK().SetFloat("CameraFilterPack/Blend2Camera_VividLight", 769f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("AskForPickupItemSpawnTimes", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 893f, 1989f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x000E39C0 File Offset: 0x000E1BC0
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1814f)
			{
				this.HBJJOCHGOPH = 1896f;
			}
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/3D_Binary", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1358f)
				{
					this._Distance = 1873f;
				}
				if (this._Distance < 1647f)
				{
					this._Distance = 1048f;
				}
				this.MFHPKGICPIO().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("Bad parameters for setstring! Use <key> <value>", this._Size);
			this.ADAFMBOGPLN().SetFloat("[ResourcesManager] Load text error: not found", (float)((!this._Visualize) ? 0 : 0));
			this.HKIMAANBGMJ().SetFloat("_GrainOffsetScale", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("file://", this.DistortionLevel * 1048f);
			this.EOCCJGIGEGJ().SetFloat("Set satellite emission (glow)", this.DistortionSize * 1915f);
			this.HKIMAANBGMJ().SetFloat("event", this.LightIntensity * 1437f);
			this.CFEDGDGBCHE().SetTexture("A", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("offsets", 1718f / farClipPlane);
			this.JLHLHKPHDFO().SetVector("workshop.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 997f, 387f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x000096FE File Offset: 0x000078FE
	private void HPFIHLMKIPF()
	{
		this.FPHEBLMINDA = (Resources.Load(".played") as Texture2D);
		this.SCShader = Shader.Find(".completedCount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00009737 File Offset: 0x00007937
	private void JFJLGJEPEAA()
	{
		this.FPHEBLMINDA = (Resources.Load("ACCEPT") as Texture2D);
		this.SCShader = Shader.Find("en");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00009441 File Offset: 0x00007641
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00009770 File Offset: 0x00007970
	private void CFFCLAHMBAA()
	{
		this.FPHEBLMINDA = (Resources.Load("in seconds. 0 - forever") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x000097A9 File Offset: 0x000079A9
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("_History4Weight") as Texture2D);
		this.SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x000E3BDC File Offset: 0x000E1DDC
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 193f)
			{
				this.HBJJOCHGOPH = 861f;
			}
			this.KEMJNOMIPHN().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 621f)
				{
					this._Distance = 1161f;
				}
				if (this._Distance < 1429f)
				{
					this._Distance = 619f;
				}
				this.EFDEIFCDAFG().SetFloat("colorC", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("Result for ", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("_ScreenSize", this._Size);
			this.ADAFMBOGPLN().SetFloat("00", (float)((!this._Visualize) ? 1 : 0));
			this.HKIMAANBGMJ().SetFloat(",", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("_EmissionColor", this.DistortionLevel * 259f);
			this.GHHPOGODBHB().SetFloat("_Value4", this.DistortionSize * 9f);
			this.LMLENGFLEBD().SetFloat("[NetworkManager] Exited", this.LightIntensity * 1635f);
			this.EFDEIFCDAFG().SetTexture("USE_PREDICATION", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHLFDHNEIAH().SetFloat("_TimeX", 226f / farClipPlane);
			this.OCMBHMLNCEK().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 680f, 1854f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x000097E2 File Offset: 0x000079E2
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("float,2") as Texture2D);
		this.SCShader = Shader.Find("PointsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x000E3DF8 File Offset: 0x000E1FF8
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 759f)
			{
				this.HBJJOCHGOPH = 353f;
			}
			this.EOCCJGIGEGJ().SetFloat("Tab1Content", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 221f)
				{
					this._Distance = 704f;
				}
				if (this._Distance < 1545f)
				{
					this._Distance = 1748f;
				}
				this.HKIMAANBGMJ().SetFloat("_BorderColor", this._Distance);
			}
			else
			{
				this.OCMBHMLNCEK().SetFloat("error", this._Distance);
			}
			this.HKHBBBFLGJH().SetFloat("x", this._Size);
			this.NMDBCDFPGOK().SetFloat("CompletedLevel", (float)((!this._Visualize) ? 1 : 1));
			this.FEAEGGCNIAA().SetFloat("PLEASE WAIT", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("KickThePlayer", this.DistortionLevel * 589f);
			this.GCDFNHMJMIP().SetFloat("You need to have a child LayoutGroup content set for the list: ", this.DistortionSize * 294f);
			this.FEAEGGCNIAA().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", this.LightIntensity * 1242f);
			this.FEAEGGCNIAA().SetTexture("_MainTex2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKIMAANBGMJ().SetFloat("_Value5", 1961f / farClipPlane);
			this.MFHPKGICPIO().SetVector("'{0}'{1}{2}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 262f, 98f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00009441 File Offset: 0x00007641
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x0000981B File Offset: 0x00007A1B
	private void MMMDPANNAIO()
	{
		this.FPHEBLMINDA = (Resources.Load("[NetworkManager] Connected to ") as Texture2D);
		this.SCShader = Shader.Find("SetEnvSpriteImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00009854 File Offset: 0x00007A54
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x000E4014 File Offset: 0x000E2214
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1002f)
			{
				this.HBJJOCHGOPH = 221f;
			}
			this.CFEDGDGBCHE().SetFloat("itemdefid[0]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 40f)
				{
					this._Distance = 65f;
				}
				if (this._Distance < 400f)
				{
					this._Distance = 1020f;
				}
				this.OCMBHMLNCEK().SetFloat("_Value", this._Distance);
			}
			else
			{
				this.HHLFDHNEIAH().SetFloat("Gameplay/Base", this._Distance);
			}
			this.MFHPKGICPIO().SetFloat("_Value", this._Size);
			this.OCMBHMLNCEK().SetFloat("_NeighbourMaxTex", (float)((!this._Visualize) ? 0 : 0));
			this.HKIMAANBGMJ().SetFloat("settings.fps", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("settings.showHP", this.DistortionLevel * 454f);
			this.HFBJAOFLCJI().SetFloat("[MapsData] Preloading ", this.DistortionSize * 216f);
			this.JLHLHKPHDFO().SetFloat("_ScreenResolution", this.LightIntensity * 359f);
			this.EFDEIFCDAFG().SetTexture(": ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat("StartButton", 1444f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("restrictions\n\n#until: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 319f, 1192f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x000E4230 File Offset: 0x000E2430
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 460f)
			{
				this.HBJJOCHGOPH = 391f;
			}
			this.HFBJAOFLCJI().SetFloat("System.Int64", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 688f)
				{
					this._Distance = 849f;
				}
				if (this._Distance < 1895f)
				{
					this._Distance = 960f;
				}
				this.HKHBBBFLGJH().SetFloat("HightScoreMaxPointsText", this._Distance);
			}
			else
			{
				this.CECICEGFHKL().SetFloat("_TimeX", this._Distance);
			}
			this.ADBKPGFMNKO().SetFloat("[ResourcesManager] Unloading data resources", this._Size);
			this.ADBKPGFMNKO().SetFloat("Delete events", (float)((!this._Visualize) ? 0 : 0));
			this.ADBKPGFMNKO().SetFloat("'{0}' \t{1}ms \t{2}", this._FixDistance);
			this.OCMBHMLNCEK().SetFloat("_ScreenResolution", this.DistortionLevel * 1414f);
			this.CFEDGDGBCHE().SetFloat("_Visualize", this.DistortionSize * 138f);
			this.EOCCJGIGEGJ().SetFloat(".lastCheckpoint.playerdistance", this.LightIntensity * 12f);
			this.CFEDGDGBCHE().SetTexture("Screenshots only supported in PlayMode", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NMDBCDFPGOK().SetFloat("AddEnvironmentObject", 1700f / farClipPlane);
			this.EOCCJGIGEGJ().SetVector("_DiffuseColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1638f, 1467f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00009441 File Offset: 0x00007641
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x0000988B File Offset: 0x00007A8B
	private void JDKHBGDEONK()
	{
		this.FPHEBLMINDA = (Resources.Load("_Threshold") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x000098C4 File Offset: 0x00007AC4
	private void EDPDMBFLHLP()
	{
		this.FPHEBLMINDA = (Resources.Load("[PlayerBase] Checkpoint error: ") as Texture2D);
		this.SCShader = Shader.Find("Deleted data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x000098FD File Offset: 0x00007AFD
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("EnvironmentSlider") as Texture2D);
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00009936 File Offset: 0x00007B36
	private void HPFOFGJPNCI()
	{
		this.FPHEBLMINDA = (Resources.Load("BadgeText") as Texture2D);
		this.SCShader = Shader.Find("SettingsCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00009441 File Offset: 0x00007641
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0000996F File Offset: 0x00007B6F
	private void IBLGHLNNAHN()
	{
		this.FPHEBLMINDA = (Resources.Load(". The RPC has been ignored.") as Texture2D);
		this.SCShader = Shader.Find("ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x000099A8 File Offset: 0x00007BA8
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x000099DF File Offset: 0x00007BDF
	private void JOHOFNKJDEB()
	{
		this.FPHEBLMINDA = (Resources.Load("HiddenToggle") as Texture2D);
		this.SCShader = Shader.Find("keys");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x0000420A File Offset: 0x0000240A
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00009441 File Offset: 0x00007641
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00009A18 File Offset: 0x00007C18
	private void MMPHNFPPEHO()
	{
		this.FPHEBLMINDA = (Resources.Load("couldn't be found!") as Texture2D);
		this.SCShader = Shader.Find("_Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00009A51 File Offset: 0x00007C51
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.playedsolo") as Texture2D);
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00009A8A File Offset: 0x00007C8A
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00009AC1 File Offset: 0x00007CC1
	private void GLEJGFLCLPJ()
	{
		this.FPHEBLMINDA = (Resources.Load("#roomname") as Texture2D);
		this.SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00009AFA File Offset: 0x00007CFA
	private void AIBNKIDADPI()
	{
		this.FPHEBLMINDA = (Resources.Load("Joined room ") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00009B33 File Offset: 0x00007D33
	private void BOPKKCAFODF()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button8") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x000E444C File Offset: 0x000E264C
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 195f)
			{
				this.HBJJOCHGOPH = 950f;
			}
			this.MFHPKGICPIO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 97f)
				{
					this._Distance = 1558f;
				}
				if (this._Distance < 1036f)
				{
					this._Distance = 587f;
				}
				this.ADBKPGFMNKO().SetFloat("Updated!", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("ConfigVersionSlider", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("[Singleton] Using instance of '", this._Size);
			this.FEAEGGCNIAA().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 1));
			this.CFEDGDGBCHE().SetFloat("checkpoint", this._FixDistance);
			this.HHLFDHNEIAH().SetFloat("<start_index> <end_index>", this.DistortionLevel * 1021f);
			this.CFEDGDGBCHE().SetFloat("_Scale", this.DistortionSize * 1017f);
			this.EOCCJGIGEGJ().SetFloat("_MainTex2", this.LightIntensity * 1323f);
			this.ADBKPGFMNKO().SetTexture("_TimeX", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/FX_EarthQuake", 1114f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("event", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1976f, 1021f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00009B6C File Offset: 0x00007D6C
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("Show image from resources by id at the center of the screen at foreground or background") as Texture2D);
		this.SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00009BA5 File Offset: 0x00007DA5
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00009BDC File Offset: 0x00007DDC
	private void DNNFHBOOPIN()
	{
		this.FPHEBLMINDA = (Resources.Load("finished") as Texture2D);
		this.SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x0000420A File Offset: 0x0000240A
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00009441 File Offset: 0x00007641
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x0000420A File Offset: 0x0000240A
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00009C15 File Offset: 0x00007E15
	private void ALNNIDLFILB()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x000E4668 File Offset: 0x000E2868
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1933f)
			{
				this.HBJJOCHGOPH = 1053f;
			}
			this.HKIMAANBGMJ().SetFloat("Save Game", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1324f)
				{
					this._Distance = 1284f;
				}
				if (this._Distance < 945f)
				{
					this._Distance = 840f;
				}
				this.NBPKMLMCHFN.SetFloat("mapselector.filter.rateduponly", this._Distance);
			}
			else
			{
				this.OCMBHMLNCEK().SetFloat("_Value", this._Distance);
			}
			this.CECICEGFHKL().SetFloat("EventData0DropDownList", this._Size);
			this.GHHPOGODBHB().SetFloat("SetPosition", (float)((!this._Visualize) ? 1 : 1));
			this.LMLENGFLEBD().SetFloat("_CurveTex", this._FixDistance);
			this.JLHLHKPHDFO().SetFloat("OnStatusChanged: {0} current State: {1}", this.DistortionLevel * 1825f);
			this.KEMJNOMIPHN().SetFloat("_Value", this.DistortionSize * 1790f);
			this.EFDEIFCDAFG().SetFloat("#FFDA44", this.LightIntensity * 1427f);
			this.ADBKPGFMNKO().SetTexture("\" error: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("GLITCH", 423f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("AddEnvironmentObject", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 870f, 155f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00009C4E File Offset: 0x00007E4E
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x000E4884 File Offset: 0x000E2A84
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 703f)
			{
				this.HBJJOCHGOPH = 1278f;
			}
			this.LMLENGFLEBD().SetFloat("_Value4", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 410f)
				{
					this._Distance = 1264f;
				}
				if (this._Distance < 1192f)
				{
					this._Distance = 1775f;
				}
				this.OCMBHMLNCEK().SetFloat("Error0", this._Distance);
			}
			else
			{
				this.GHHPOGODBHB().SetFloat("BloomShaderValueSlider", this._Distance);
			}
			this.ADAFMBOGPLN().SetFloat("Joystick", this._Size);
			this.EOCCJGIGEGJ().SetFloat("shader.invert", (float)((!this._Visualize) ? 0 : 1));
			this.CFEDGDGBCHE().SetFloat("_VelocityScale", this._FixDistance);
			this.NMDBCDFPGOK().SetFloat("_SmoothEnd", this.DistortionLevel * 105f);
			this.HFBJAOFLCJI().SetFloat("_SpawnHeuristic", this.DistortionSize * 1462f);
			this.HKIMAANBGMJ().SetFloat("Populate Mesh Data", this.LightIntensity * 829f);
			this.KEMJNOMIPHN().SetTexture("settings.showHP", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("Image effects aren't supported on this device ({0})", 1407f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_Linecount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 834f, 1142f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00009C85 File Offset: 0x00007E85
	private void FMNPFCHBLJF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Saturation") as Texture2D);
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00009BA5 File Offset: 0x00007DA5
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00009441 File Offset: 0x00007641
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00009CBE File Offset: 0x00007EBE
	private void DOFDGBGEDFI()
	{
		this.FPHEBLMINDA = (Resources.Load("_PrevViewProj") as Texture2D);
		this.SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00009441 File Offset: 0x00007641
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x000E4AA0 File Offset: 0x000E2CA0
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 799f)
			{
				this.HBJJOCHGOPH = 1831f;
			}
			this.FEAEGGCNIAA().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 115f)
				{
					this._Distance = 779f;
				}
				if (this._Distance < 419f)
				{
					this._Distance = 87f;
				}
				this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/OldFilm_Cutting1", this._Distance);
			}
			else
			{
				this.HHLFDHNEIAH().SetFloat("randomdrop", this._Distance);
			}
			this.KEMJNOMIPHN().SetFloat("_Value3", this._Size);
			this.CECICEGFHKL().SetFloat("_Value3", (float)((!this._Visualize) ? 1 : 1));
			this.HHLFDHNEIAH().SetFloat("_TimeX", this._FixDistance);
			this.EOCCJGIGEGJ().SetFloat("_ArScale", this.DistortionLevel * 485f);
			this.KEMJNOMIPHN().SetFloat("[LocalizationService] Loading file: ", this.DistortionSize * 1250f);
			this.CECICEGFHKL().SetFloat("_Value2", this.LightIntensity * 1117f);
			this.EOCCJGIGEGJ().SetTexture("  |  ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKHBBBFLGJH().SetFloat("_TimeX", 1346f / farClipPlane);
			this.NMDBCDFPGOK().SetVector("bad", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 253f, 1847f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x0000420A File Offset: 0x0000240A
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x000E4CBC File Offset: 0x000E2EBC
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1004f)
			{
				this.HBJJOCHGOPH = 889f;
			}
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 623f)
				{
					this._Distance = 1176f;
				}
				if (this._Distance < 360f)
				{
					this._Distance = 730f;
				}
				this.JLHLHKPHDFO().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", this._Distance);
			}
			else
			{
				this.JLHLHKPHDFO().SetFloat("_Value5", this._Distance);
			}
			this.HKHBBBFLGJH().SetFloat("inventory.selected.", this._Size);
			this.CFEDGDGBCHE().SetFloat("_NoisePerChannel", (float)((!this._Visualize) ? 0 : 1));
			this.MFHPKGICPIO().SetFloat("ZoomSpeed", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("\n - NetID: ", this.DistortionLevel * 1856f);
			this.ADAFMBOGPLN().SetFloat("_Glitch", this.DistortionSize * 455f);
			this.EOCCJGIGEGJ().SetFloat("resource id", this.LightIntensity * 1754f);
			this.ADBKPGFMNKO().SetTexture("distance", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", 891f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("[Down]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1098f, 1055f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x000E4ED8 File Offset: 0x000E30D8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1609f)
			{
				this.HBJJOCHGOPH = 877f;
			}
			this.HKHBBBFLGJH().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 756f)
				{
					this._Distance = 298f;
				}
				if (this._Distance < 1540f)
				{
					this._Distance = 1714f;
				}
				this.ADAFMBOGPLN().SetFloat("BlockCount", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("ChallengesButton", this._Distance);
			}
			this.EFDEIFCDAFG().SetFloat("/", this._Size);
			this.HHLFDHNEIAH().SetFloat("GameScene", (float)((!this._Visualize) ? 0 : 0));
			this.EFDEIFCDAFG().SetFloat(").png", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("OxOD.lastPath", this.DistortionLevel * 1004f);
			this.ADAFMBOGPLN().SetFloat("player.deleted", this.DistortionSize * 1339f);
			this.HHLFDHNEIAH().SetFloat("_TimeX", this.LightIntensity * 949f);
			this.CECICEGFHKL().SetTexture("SetSunInput", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HFBJAOFLCJI().SetFloat("_Value4", 1588f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("). ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1048f, 1201f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00009CF7 File Offset: 0x00007EF7
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load("\n\n#") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x000E50F4 File Offset: 0x000E32F4
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
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel * 28f);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize * 16f);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
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

	// Token: 0x0600093B RID: 2363 RVA: 0x00009441 File Offset: 0x00007641
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00009D30 File Offset: 0x00007F30
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00009441 File Offset: 0x00007641
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00009D67 File Offset: 0x00007F67
	private void JMEOGJHCONJ()
	{
		this.FPHEBLMINDA = (Resources.Load(":\n") as Texture2D);
		this.SCShader = Shader.Find("ticket.ticket1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00009441 File Offset: 0x00007641
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00009441 File Offset: 0x00007641
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x000E5310 File Offset: 0x000E3510
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 74f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.GHHPOGODBHB().SetFloat("_Green_B", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1419f)
				{
					this._Distance = 504f;
				}
				if (this._Distance < 45f)
				{
					this._Distance = 1451f;
				}
				this.EFDEIFCDAFG().SetFloat("[RanksSystem] Ranks updated. Next update: ", this._Distance);
			}
			else
			{
				this.HKIMAANBGMJ().SetFloat("Vertical", this._Distance);
			}
			this.LMLENGFLEBD().SetFloat("_BlurCoe", this._Size);
			this.NMDBCDFPGOK().SetFloat("_PColor", (float)((!this._Visualize) ? 1 : 0));
			this.GHHPOGODBHB().SetFloat(" on effect ", this._FixDistance);
			this.MFHPKGICPIO().SetFloat("EditMenu", this.DistortionLevel * 1173f);
			this.GCDFNHMJMIP().SetFloat("_InternalLutParams", this.DistortionSize * 1450f);
			this.OCMBHMLNCEK().SetFloat(" (inactive)", this.LightIntensity * 305f);
			this.CECICEGFHKL().SetTexture("_Value3", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CECICEGFHKL().SetFloat("_SampleCount", 1187f / farClipPlane);
			this.EFDEIFCDAFG().SetVector("_NormalAndRoughnessTexture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 885f, 112f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00009441 File Offset: 0x00007641
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x000E552C File Offset: 0x000E372C
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 191f)
			{
				this.HBJJOCHGOPH = 84f;
			}
			this.EFDEIFCDAFG().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 60f)
				{
					this._Distance = 1782f;
				}
				if (this._Distance < 1654f)
				{
					this._Distance = 1958f;
				}
				this.NBPKMLMCHFN.SetFloat("menu.playedpage", this._Distance);
			}
			else
			{
				this.MFHPKGICPIO().SetFloat("player.arrow", this._Distance);
			}
			this.HKHBBBFLGJH().SetFloat("_TimeX", this._Size);
			this.FEAEGGCNIAA().SetFloat("Default UI Material", (float)((!this._Visualize) ? 0 : 0));
			this.LMLENGFLEBD().SetFloat("CameraFilterPack/Drawing_CellShading", this._FixDistance);
			this.HKIMAANBGMJ().SetFloat("_Value4", this.DistortionLevel * 1633f);
			this.JLHLHKPHDFO().SetFloat("UI", this.DistortionSize * 416f);
			this.EOCCJGIGEGJ().SetFloat("Can't set open when not in that room.", this.LightIntensity * 14f);
			this.ADAFMBOGPLN().SetTexture("_Smooth", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HFBJAOFLCJI().SetFloat("float,1.5", 525f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("_FadeFromBinary", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1132f, 1200f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x000E5748 File Offset: 0x000E3948
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 566f)
			{
				this.HBJJOCHGOPH = 407f;
			}
			this.NBPKMLMCHFN.SetFloat("Selection Box", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1525f)
				{
					this._Distance = 565f;
				}
				if (this._Distance < 171f)
				{
					this._Distance = 1674f;
				}
				this.LMLENGFLEBD().SetFloat("fetch", this._Distance);
			}
			else
			{
				this.CFEDGDGBCHE().SetFloat("End index must in an integer.", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("_MatrixSize", this._Size);
			this.EFDEIFCDAFG().SetFloat("offline room", (float)((!this._Visualize) ? 1 : 1));
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/Light_Water2", this._FixDistance);
			this.CFEDGDGBCHE().SetFloat("workshop.", this.DistortionLevel * 229f);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/AAA_Blood_Hit", this.DistortionSize * 1014f);
			this.MFHPKGICPIO().SetFloat("SetPosition", this.LightIntensity * 13f);
			this.CFEDGDGBCHE().SetTexture("_Red_G", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Gradients_NeonGradient", 323f / farClipPlane);
			this.JLHLHKPHDFO().SetVector("CameraFilterPack/Blur_Regular", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 408f, 672f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00009DA0 File Offset: 0x00007FA0
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00009DD7 File Offset: 0x00007FD7
	private void LGHCJCFHEMF()
	{
		this.FPHEBLMINDA = (Resources.Load("value") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00009E10 File Offset: 0x00008010
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_PColor2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x000E5964 File Offset: 0x000E3B64
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1517f)
			{
				this.HBJJOCHGOPH = 615f;
			}
			this.HHLFDHNEIAH().SetFloat("Editor/", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1438f)
				{
					this._Distance = 1014f;
				}
				if (this._Distance < 1843f)
				{
					this._Distance = 1931f;
				}
				this.EOCCJGIGEGJ().SetFloat("\n\n#", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("BlockCount", this._Size);
			this.ADAFMBOGPLN().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", (float)((!this._Visualize) ? 1 : 0));
			this.KEMJNOMIPHN().SetFloat("_TimeX", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_History4ChromaTex", this.DistortionLevel * 1014f);
			this.KEMJNOMIPHN().SetFloat("_TimeX", this.DistortionSize * 621f);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.LightIntensity * 1233f);
			this.NBPKMLMCHFN.SetTexture("_Distortion", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OCMBHMLNCEK().SetFloat("SetSunColors", 1968f / farClipPlane);
			this.HHLFDHNEIAH().SetVector("ChatInput", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1364f, 607f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00009E49 File Offset: 0x00008049
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00009E80 File Offset: 0x00008080
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00009441 File Offset: 0x00007641
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00009EB7 File Offset: 0x000080B7
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Intensity") as Texture2D);
		this.SCShader = Shader.Find("_Threshhold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x0000420A File Offset: 0x0000240A
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x0000420A File Offset: 0x0000240A
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x000E5B80 File Offset: 0x000E3D80
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 376f)
			{
				this.HBJJOCHGOPH = 407f;
			}
			this.HHLFDHNEIAH().SetFloat("_EdgeSize", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1749f)
				{
					this._Distance = 415f;
				}
				if (this._Distance < 1519f)
				{
					this._Distance = 1196f;
				}
				this.LMLENGFLEBD().SetFloat(" connected: ", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("#close", this._Distance);
			}
			this.JLHLHKPHDFO().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this._Size);
			this.JLHLHKPHDFO().SetFloat("CameraFilterPack_TV_BrokenGlass1", (float)((!this._Visualize) ? 0 : 0));
			this.MFHPKGICPIO().SetFloat("value", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("_Value", this.DistortionLevel * 619f);
			this.MFHPKGICPIO().SetFloat("MenuScene", this.DistortionSize * 1021f);
			this.HFBJAOFLCJI().SetFloat("s", this.LightIntensity * 1025f);
			this.ADBKPGFMNKO().SetTexture("Return: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("UseFinalGlassColor", 448f / farClipPlane);
			this.HHLFDHNEIAH().SetVector("Horizontal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1271f, 641f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00009EF0 File Offset: 0x000080F0
	private void PKLOBJHKFEO()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlurVector") as Texture2D);
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x0000420A File Offset: 0x0000240A
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x000E5D9C File Offset: 0x000E3F9C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1722f)
			{
				this.HBJJOCHGOPH = 1736f;
			}
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1756f)
				{
					this._Distance = 1617f;
				}
				if (this._Distance < 339f)
				{
					this._Distance = 1258f;
				}
				this.EOCCJGIGEGJ().SetFloat("#", this._Distance);
			}
			else
			{
				this.HKHBBBFLGJH().SetFloat("_Value4", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("_Value", this._Size);
			this.GHHPOGODBHB().SetFloat("ERROR: mod directory not found!", (float)((!this._Visualize) ? 0 : 1));
			this.HHLFDHNEIAH().SetFloat("Scenes List:", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("#challengecomplete", this.DistortionLevel * 106f);
			this.MFHPKGICPIO().SetFloat("_Linecount", this.DistortionSize * 1505f);
			this.CFEDGDGBCHE().SetFloat("mapselector.filter.subscribedonly", this.LightIntensity * 143f);
			this.EFDEIFCDAFG().SetTexture("_Value", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("id", 1478f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("VisionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 1242f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00009F29 File Offset: 0x00008129
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load(". The group number should be at least 1.") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x0000420A File Offset: 0x0000240A
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00009F62 File Offset: 0x00008162
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x000E5FB8 File Offset: 0x000E41B8
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1223f)
			{
				this.HBJJOCHGOPH = 1843f;
			}
			this.KEMJNOMIPHN().SetFloat("_Value", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 749f)
				{
					this._Distance = 789f;
				}
				if (this._Distance < 665f)
				{
					this._Distance = 767f;
				}
				this.HFBJAOFLCJI().SetFloat("clear", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("maps.", this._Distance);
			}
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this._Size);
			this.KEMJNOMIPHN().SetFloat("There is already a virtual button named ", (float)((!this._Visualize) ? 1 : 0));
			this.NBPKMLMCHFN.SetFloat("ShadersToggle", this._FixDistance);
			this.NMDBCDFPGOK().SetFloat("/", this.DistortionLevel * 593f);
			this.HFBJAOFLCJI().SetFloat("NEW", this.DistortionSize * 1946f);
			this.EFDEIFCDAFG().SetFloat("PossibleMapMaxScoreText", this.LightIntensity * 416f);
			this.ADBKPGFMNKO().SetTexture("Event Received", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EOCCJGIGEGJ().SetFloat(".", 1631f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1608f, 1610f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00009441 File Offset: 0x00007641
	private void OHIJGCLBMJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x0000420A File Offset: 0x0000240A
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00009441 File Offset: 0x00007641
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x0000420A File Offset: 0x0000240A
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x0000420A File Offset: 0x0000240A
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00009F99 File Offset: 0x00008199
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00009FD0 File Offset: 0x000081D0
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Myst1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00009441 File Offset: 0x00007641
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00009441 File Offset: 0x00007641
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x0000A009 File Offset: 0x00008209
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00009441 File Offset: 0x00007641
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00009441 File Offset: 0x00007641
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x0000A040 File Offset: 0x00008240
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load("time") as Texture2D);
		this.SCShader = Shader.Find("RPC: 'OnAwakeRPC' Parameter: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000157 RID: 343
	public Shader SCShader;

	// Token: 0x04000158 RID: 344
	public bool _Visualize;

	// Token: 0x04000159 RID: 345
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400015A RID: 346
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400015B RID: 347
	private Material BJFKDHHMLJH;

	// Token: 0x0400015C RID: 348
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x0400015D RID: 349
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	// Token: 0x0400015E RID: 350
	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	// Token: 0x0400015F RID: 351
	[Range(0f, 10f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x04000160 RID: 352
	[Range(0.1f, 10f)]
	public float DistortionSize = 1.4f;

	// Token: 0x04000161 RID: 353
	[Range(-2f, 4f)]
	public float LightIntensity = 0.08f;

	// Token: 0x04000162 RID: 354
	public bool AutoAnimatedNear;

	// Token: 0x04000163 RID: 355
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000164 RID: 356
	private Texture2D FPHEBLMINDA;

	// Token: 0x04000165 RID: 357
	public static Color ChangeColorRGB;
}
