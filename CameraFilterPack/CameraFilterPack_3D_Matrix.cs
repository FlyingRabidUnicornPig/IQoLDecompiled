/*
Importance of this class: Unknown

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000024 RID: 36
[AddComponentMenu("Camera Filter Pack/3D/Matrix")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Matrix : MonoBehaviour
{
	// Token: 0x060007D4 RID: 2004 RVA: 0x000DD04C File Offset: 0x000DB24C
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1332f)
			{
				this.HBJJOCHGOPH = 1316f;
			}
			this.HKGAONMOBMH().SetFloat("Bad parameters for getbool! Use <key> <value>", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("Joystick1Button3", this.Fade);
			this.FGENHBKMPDA().SetFloat("player ", this._FixDistance);
			this.FHFLKLMFHOI().SetFloat("Vertical", this.MatrixSize);
			this.DNLMFEGJJDD().SetColor("_Value", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_TV_Vignetting1", this.MatrixSpeed * 308f);
			this.IGKFMCPDNOI().SetFloat("BitsData", (float)((!this._Visualize) ? 0 : 1));
			this.LPDOGGFOBDH().SetFloat("_CurTex", this.LightIntensity);
			this.DKNJGHFLAIF().SetTexture("_TimeX", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CECICEGFHKL().SetFloat("MapEnd", 1932f / farClipPlane);
			this.DNLMFEGJJDD().SetVector("[MapEditor] Openning ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1962f, 385f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x0000420A File Offset: 0x0000240A
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00007F28 File Offset: 0x00006128
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00007F5F File Offset: 0x0000615F
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00007F7C File Offset: 0x0000617C
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x0000420A File Offset: 0x0000240A
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x0000420A File Offset: 0x0000240A
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x0000420A File Offset: 0x0000240A
	private void MECJHOJPODB()
	{
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00007F5F File Offset: 0x0000615F
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x000DD1E8 File Offset: 0x000DB3E8
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1030f)
			{
				this.HBJJOCHGOPH = 1972f;
			}
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("mapselector.filter.favoriteonly", this.Fade);
			this.GBFOAHKAJEK().SetFloat("_Value3", this._FixDistance);
			this.FKEOGPDLBDD().SetFloat("Joystick1Button3", this.MatrixSize);
			this.PDEAHJPOMEF().SetColor("Joystick1Button6", this._MatrixColor);
			this.HNFFHCLNBDN().SetFloat("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", this.MatrixSpeed * 1960f);
			this.OJMHIMIPKME().SetFloat("CameraFilterPack/Blur_Focus", (float)((!this._Visualize) ? 0 : 0));
			this.CECICEGFHKL().SetFloat("_Blue_C", this.LightIntensity);
			this.IIJMIPBMMBF().SetTexture("offsets", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IONHGBPGCHK().SetFloat("_Value3", 381f / farClipPlane);
			this.DNLMFEGJJDD().SetVector("OK", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1785f, 1793f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00007F5F File Offset: 0x0000615F
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x0000420A File Offset: 0x0000240A
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00007FB3 File Offset: 0x000061B3
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00007FEA File Offset: 0x000061EA
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x000DD384 File Offset: 0x000DB584
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 831f)
			{
				this.HBJJOCHGOPH = 1976f;
			}
			this.CECICEGFHKL().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("y", this.Fade);
			this.PGPEMMBJOOG().SetFloat("_MatrixSize", this._FixDistance);
			this.DONENAMLFLF().SetFloat("Set particles size", this.MatrixSize);
			this.IGKFMCPDNOI().SetColor("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", this._MatrixColor);
			this.HEINDEMCGIK().SetFloat("ItemsCountText", this.MatrixSpeed * 250f);
			this.HEINDEMCGIK().SetFloat("_Parameter", (float)((!this._Visualize) ? 0 : 1));
			this.CECICEGFHKL().SetFloat("_Value", this.LightIntensity);
			this.OJMHIMIPKME().SetTexture("Share", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IGKFMCPDNOI().SetFloat("Hello", 283f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("powerup.0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 549f, 544f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x000DD520 File Offset: 0x000DB720
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1667f)
			{
				this.HBJJOCHGOPH = 200f;
			}
			this.HNFFHCLNBDN().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_AccumulationTex", this.Fade);
			this.FGENHBKMPDA().SetFloat("_History1Weight", this._FixDistance);
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack/TV_Noise", this.MatrixSize);
			this.DKNJGHFLAIF().SetColor("Joystick1Button8", this._MatrixColor);
			this.HNFFHCLNBDN().SetFloat("cameramovements:", this.MatrixSpeed * 359f);
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack/NightVisionFX", (float)((!this._Visualize) ? 1 : 0));
			this.FGENHBKMPDA().SetFloat("DISTORT", this.LightIntensity);
			this.ABHDNGIHBKE().SetTexture("DPADHOR", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADGHJOHKEHG().SetFloat("_VignetteTex", 181f / farClipPlane);
			this.HEINDEMCGIK().SetVector("COMPLETED", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1880f, 1135f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00008021 File Offset: 0x00006221
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00007F5F File Offset: 0x0000615F
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x0000805A File Offset: 0x0000625A
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x0000420A File Offset: 0x0000240A
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00008091 File Offset: 0x00006291
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x000080C8 File Offset: 0x000062C8
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0000420A File Offset: 0x0000240A
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x000DD6BC File Offset: 0x000DB8BC
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 375f)
			{
				this.HBJJOCHGOPH = 1410f;
			}
			this.ADGHJOHKEHG().SetFloat("ticket", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("_Value4", this.Fade);
			this.GHHPOGODBHB().SetFloat("/", this._FixDistance);
			this.HNFFHCLNBDN().SetFloat("mapselector.orderby", this.MatrixSize);
			this.FHFLKLMFHOI().SetColor("_TimeX", this._MatrixColor);
			this.BBIMPFGLDCP().SetFloat("CameraFilterPack/TV_BrokenGlass2", this.MatrixSpeed * 1935f);
			this.CEKJODEAMGB().SetFloat("Beat Detected", (float)((!this._Visualize) ? 0 : 1));
			this.ADGHJOHKEHG().SetFloat("_Value5", this.LightIntensity);
			this.HKGAONMOBMH().SetTexture("leave", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CBCNOEIALHB().SetFloat("CameraFilterPack/Edge_Sigmoid", 1279f / farClipPlane);
			this.CBCNOEIALHB().SetVector("Gameplay/Base", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 443f, 999f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x000080FF File Offset: 0x000062FF
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("[Down]") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x000DD858 File Offset: 0x000DBA58
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1296f)
			{
				this.HBJJOCHGOPH = 316f;
			}
			this.IGKFMCPDNOI().SetFloat("2", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack/Drawing_Manga_Flash_Color", this.Fade);
			this.ADGHJOHKEHG().SetFloat("settings.cameramovements", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("Can't find key ", this.MatrixSize);
			this.OJMHIMIPKME().SetColor("Connecting to server", this._MatrixColor);
			this.GHHPOGODBHB().SetFloat("editorVolume", this.MatrixSpeed * 769f);
			this.CBCNOEIALHB().SetFloat("SetRoomStartTimestamp", (float)((!this._Visualize) ? 0 : 0));
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack_TV_BrokenGlass_2", this.LightIntensity);
			this.HHIFMIPPMPF().SetTexture("_Bullet_2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADGHJOHKEHG().SetFloat("ViewMenu", 1200f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 115f, 1630f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00007F5F File Offset: 0x0000615F
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x0000420A File Offset: 0x0000240A
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00007F5F File Offset: 0x0000615F
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x000DD9F4 File Offset: 0x000DBBF4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 285f)
			{
				this.HBJJOCHGOPH = 956f;
			}
			this.DONENAMLFLF().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Value", this.Fade);
			this.FGENHBKMPDA().SetFloat("MaxLivesSlider", this._FixDistance);
			this.HEINDEMCGIK().SetFloat("SUBMIT", this.MatrixSize);
			this.HHIFMIPPMPF().SetColor("Joystick1Button0", this._MatrixColor);
			this.LPDOGGFOBDH().SetFloat("float,1", this.MatrixSpeed * 1431f);
			this.LPDOGGFOBDH().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 0 : 0));
			this.CBCNOEIALHB().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("AddEnvironmentObject", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GBFOAHKAJEK().SetFloat("_Value2", 1037f / farClipPlane);
			this.DONENAMLFLF().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 369f, 1296f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00008138 File Offset: 0x00006338
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0000816F File Offset: 0x0000636F
	private void IGPCNCJIEOJ()
	{
		this.FPHEBLMINDA = (Resources.Load("[PlayerController] ") as Texture2D);
		this.SCShader = Shader.Find("float");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00007F5F File Offset: 0x0000615F
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x000081A8 File Offset: 0x000063A8
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("Edited unlock conditions") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0000420A File Offset: 0x0000240A
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x000081E1 File Offset: 0x000063E1
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00007F5F File Offset: 0x0000615F
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x000DDB90 File Offset: 0x000DBD90
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1984f)
			{
				this.HBJJOCHGOPH = 1211f;
			}
			this.CBCNOEIALHB().SetFloat("_LensDirtIntensity", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("/", this.Fade);
			this.DONENAMLFLF().SetFloat("CameraFilterPack/Oculus_NightVision3", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("1427616858", this.MatrixSize);
			this.CECICEGFHKL().SetColor("_Saturation", this._MatrixColor);
			this.ADGHJOHKEHG().SetFloat("_Value2", this.MatrixSpeed * 475f);
			this.FHFLKLMFHOI().SetFloat("_Distortion", (float)((!this._Visualize) ? 1 : 1));
			this.LPDOGGFOBDH().SetFloat("_BlurVector", this.LightIntensity);
			this.GHHPOGODBHB().SetTexture("#close", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FKEOGPDLBDD().SetFloat("_Threshhold", 763f / farClipPlane);
			this.DONENAMLFLF().SetVector("Set particles gravity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 464f, 1403f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00007FEA File Offset: 0x000061EA
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x0000821A File Offset: 0x0000641A
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Matrix1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Matrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x000DDD2C File Offset: 0x000DBF2C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 563f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.FHFLKLMFHOI().SetFloat("[LevelEditorScene] Error: Timeout :S", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("UpdateNewsTileStart", this.Fade);
			this.GBFOAHKAJEK().SetFloat("OnPlayerGameMessage", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("_Value2", this.MatrixSize);
			this.IONHGBPGCHK().SetColor("_Value2", this._MatrixColor);
			this.LPDOGGFOBDH().SetFloat("_Value5", this.MatrixSpeed * 1202f);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Gradients_Therma", (float)((!this._Visualize) ? 0 : 0));
			this.FHFLKLMFHOI().SetFloat("menu.relaxinfo", this.LightIntensity);
			this.IGKFMCPDNOI().SetTexture("\\", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ECCPAOBFDKP().SetFloat("yyyy-MM-dd HH:mm:ss", 527f / farClipPlane);
			this.ECCPAOBFDKP().SetVector("Error: I/O Failure! :(", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1461f, 1154f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00008253 File Offset: 0x00006453
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x000DDEC8 File Offset: 0x000DC0C8
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 491f)
			{
				this.HBJJOCHGOPH = 268f;
			}
			this.ADGHJOHKEHG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("#,0", this.Fade);
			this.GBFOAHKAJEK().SetFloat("_ToneCurveRange", this._FixDistance);
			this.CEKJODEAMGB().SetFloat("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", this.MatrixSize);
			this.DKNJGHFLAIF().SetColor("offsets", this._MatrixColor);
			this.IONHGBPGCHK().SetFloat("settings.volume.game", this.MatrixSpeed * 1345f);
			this.FGENHBKMPDA().SetFloat("master", (float)((!this._Visualize) ? 0 : 1));
			this.HHIFMIPPMPF().SetFloat("Object ID. Case-Sensitive", this.LightIntensity);
			this.OJMHIMIPKME().SetTexture("_Value3", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HILDKDFEBPF().SetFloat("menu.copyright", 751f / farClipPlane);
			this.GHHPOGODBHB().SetVector("plogs", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1798f, 736f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0000828A File Offset: 0x0000648A
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("EnvironmentSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x000082C3 File Offset: 0x000064C3
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0000420A File Offset: 0x0000240A
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x0000420A File Offset: 0x0000240A
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x000082FA File Offset: 0x000064FA
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00008331 File Offset: 0x00006531
	private void AKHCOBHHGJP()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.arcshitsoundtimedelay") as Texture2D);
		this.SCShader = Shader.Find("/?player=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0000836A File Offset: 0x0000656A
	private void HIPEHGNBJMN()
	{
		this.FPHEBLMINDA = (Resources.Load("BadgeImage") as Texture2D);
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x000083A3 File Offset: 0x000065A3
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("SaveButton") as Texture2D);
		this.SCShader = Shader.Find("FullscreenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x000DE064 File Offset: 0x000DC264
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 842f)
			{
				this.HBJJOCHGOPH = 1172f;
			}
			this.HEINDEMCGIK().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("sfxVolume", this.Fade);
			this.DNLMFEGJJDD().SetFloat("[MapEditor] Reset", this._FixDistance);
			this.HHIFMIPPMPF().SetFloat(" Message: ", this.MatrixSize);
			this.GBFOAHKAJEK().SetColor("_Value", this._MatrixColor);
			this.CBCNOEIALHB().SetFloat("Floating point textures aren't supported on this device ({0})", this.MatrixSpeed * 716f);
			this.ABHDNGIHBKE().SetFloat("GenerationMenu", (float)((!this._Visualize) ? 1 : 0));
			this.ADGHJOHKEHG().SetFloat("Encryption wasn't established: ", this.LightIntensity);
			this.IIJMIPBMMBF().SetTexture(".status", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HNFFHCLNBDN().SetFloat("UseScanLine", 284f / farClipPlane);
			this.GBFOAHKAJEK().SetVector("event", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1883f, 181f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x000083DC File Offset: 0x000065DC
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0000420A File Offset: 0x0000240A
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x000082FA File Offset: 0x000064FA
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x000DE200 File Offset: 0x000DC400
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 371f)
			{
				this.HBJJOCHGOPH = 1693f;
			}
			this.HNFFHCLNBDN().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_TimeX", this.Fade);
			this.HEINDEMCGIK().SetFloat("_ScreenResolution", this._FixDistance);
			this.IIJMIPBMMBF().SetFloat("00", this.MatrixSize);
			this.MHBAIEKFBIJ().SetColor("_Factor", this._MatrixColor);
			this.DONENAMLFLF().SetFloat("player.redabstract", this.MatrixSpeed * 741f);
			this.CECICEGFHKL().SetFloat("/", (float)((!this._Visualize) ? 0 : 1));
			this.GHHPOGODBHB().SetFloat("_LrDepthTex", this.LightIntensity);
			this.DNLMFEGJJDD().SetTexture("colorC", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OJMHIMIPKME().SetFloat("</color>", 1360f / farClipPlane);
			this.DNLMFEGJJDD().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1705f, 898f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0000420A File Offset: 0x0000240A
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00007F5F File Offset: 0x0000615F
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00008413 File Offset: 0x00006613
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x000DE39C File Offset: 0x000DC59C
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 810f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.PGPEMMBJOOG().SetFloat("ShineEffect", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("t", this.Fade);
			this.HEINDEMCGIK().SetFloat("DPADVER", this._FixDistance);
			this.OJMHIMIPKME().SetFloat("yyyy", this.MatrixSize);
			this.HEINDEMCGIK().SetColor("color", this._MatrixColor);
			this.MHBAIEKFBIJ().SetFloat("_Value4", this.MatrixSpeed * 845f);
			this.DNLMFEGJJDD().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", (float)((!this._Visualize) ? 1 : 0));
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("_TimeX", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HILDKDFEBPF().SetFloat("B", 1243f / farClipPlane);
			this.CEKJODEAMGB().SetVector("fetch", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 71f, 1634f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x000DE538 File Offset: 0x000DC738
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 324f)
			{
				this.HBJJOCHGOPH = 665f;
			}
			this.PDEAHJPOMEF().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("#rt", this.Fade);
			this.IONHGBPGCHK().SetFloat("_BorderSize", this._FixDistance);
			this.LPDOGGFOBDH().SetFloat("LevelConfigButton", this.MatrixSize);
			this.HKGAONMOBMH().SetColor("_ScreenResolution", this._MatrixColor);
			this.IONHGBPGCHK().SetFloat("menu.tabid", this.MatrixSpeed * 103f);
			this.EOCCJGIGEGJ().SetFloat("_Value2", (float)((!this._Visualize) ? 1 : 1));
			this.JFDGLLEOPGB().SetFloat("_Value4", this.LightIntensity);
			this.ADGHJOHKEHG().SetTexture("LevelInfoInputField", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GBFOAHKAJEK().SetFloat("offsets", 1391f / farClipPlane);
			this.LPDOGGFOBDH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 136f, 1792f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x000DE6D4 File Offset: 0x000DC8D4
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1606f)
			{
				this.HBJJOCHGOPH = 1955f;
			}
			this.CBCNOEIALHB().SetFloat("OperationResponse ignored while disconnecting. Code: ", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("_ScreenResolution", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("en", this._FixDistance);
			this.EOCCJGIGEGJ().SetFloat("Right Stick Click", this.MatrixSize);
			this.FHFLKLMFHOI().SetColor("_MainTex2", this._MatrixColor);
			this.CEKJODEAMGB().SetFloat("offsets", this.MatrixSpeed * 959f);
			this.HKGAONMOBMH().SetFloat("/theme", (float)((!this._Visualize) ? 0 : 1));
			this.HKGAONMOBMH().SetFloat("action", this.LightIntensity);
			this.DNLMFEGJJDD().SetTexture(" not exist", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HEINDEMCGIK().SetFloat("#kicked", 191f / farClipPlane);
			this.FKEOGPDLBDD().SetVector("_Source", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1431f, 390f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0000844A File Offset: 0x0000664A
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x000DE870 File Offset: 0x000DCA70
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1809f)
			{
				this.HBJJOCHGOPH = 1878f;
			}
			this.CEKJODEAMGB().SetFloat("challenges.", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_Value6", this.Fade);
			this.HHIFMIPPMPF().SetFloat("colorB", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("_Value4", this.MatrixSize);
			this.IGKFMCPDNOI().SetColor("inventory.selected.", this._MatrixColor);
			this.JFDGLLEOPGB().SetFloat("_Value4", this.MatrixSpeed * 1612f);
			this.HILDKDFEBPF().SetFloat("Multiplayer", (float)((!this._Visualize) ? 0 : 1));
			this.CBCNOEIALHB().SetFloat("_Luminance", this.LightIntensity);
			this.PDEAHJPOMEF().SetTexture("_ConsoleSettings", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OJMHIMIPKME().SetFloat("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", 1498f / farClipPlane);
			this.HILDKDFEBPF().SetVector("InfoCanvas", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 271f, 1967f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00007F5F File Offset: 0x0000615F
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x000DEA0C File Offset: 0x000DCC0C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 849f)
			{
				this.HBJJOCHGOPH = 814f;
			}
			this.CECICEGFHKL().SetFloat("_Value", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_Intensity", this.Fade);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/TV_CompressionFX", this._FixDistance);
			this.GBFOAHKAJEK().SetFloat("SupportLogger OnDisconnectedFromPhoton().", this.MatrixSize);
			this.JFDGLLEOPGB().SetColor("_BlurSize", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.MatrixSpeed * 1221f);
			this.OJMHIMIPKME().SetFloat("_Value4", (float)((!this._Visualize) ? 1 : 0));
			this.GBFOAHKAJEK().SetFloat("_Distortion", this.LightIntensity);
			this.HNFFHCLNBDN().SetTexture("Done!", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Blend2Camera_Lighten", 295f / farClipPlane);
			this.ADGHJOHKEHG().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 743f, 1879f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00008481 File Offset: 0x00006681
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x000DEBA8 File Offset: 0x000DCDA8
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 941f)
			{
				this.HBJJOCHGOPH = 1929f;
			}
			this.MHBAIEKFBIJ().SetFloat("EnvironmentSlider", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Value4", this.Fade);
			this.CECICEGFHKL().SetFloat("_VelTex", this._FixDistance);
			this.CECICEGFHKL().SetFloat("Circle", this.MatrixSize);
			this.BBIMPFGLDCP().SetColor("_TimeX", this._MatrixColor);
			this.IONHGBPGCHK().SetFloat("Joystick", this.MatrixSpeed * 832f);
			this.PGPEMMBJOOG().SetFloat("_Intensity", (float)((!this._Visualize) ? 0 : 1));
			this.LPDOGGFOBDH().SetFloat("mapselector.filter.rateduponly", this.LightIntensity);
			this.EOCCJGIGEGJ().SetTexture("_Red_R", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/EXTRA_Rotation", 1683f / farClipPlane);
			this.ABHDNGIHBKE().SetVector("Joystick1Button7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1639f, 1676f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x000DED44 File Offset: 0x000DCF44
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1532f)
			{
				this.HBJJOCHGOPH = 1348f;
			}
			this.IIJMIPBMMBF().SetFloat("ShineEffect", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("DifficultyBG", this.Fade);
			this.ECCPAOBFDKP().SetFloat("Set Particles Input", this._FixDistance);
			this.ADGHJOHKEHG().SetFloat("Fade", this.MatrixSize);
			this.HKGAONMOBMH().SetColor("_ScreenResolution", this._MatrixColor);
			this.HILDKDFEBPF().SetFloat("PublishButton", this.MatrixSpeed * 1554f);
			this.HHIFMIPPMPF().SetFloat("{0}{1}{2}", (float)((!this._Visualize) ? 0 : 1));
			this.CBCNOEIALHB().SetFloat("_FresnelFadePower", this.LightIntensity);
			this.DONENAMLFLF().SetTexture("-help", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKGAONMOBMH().SetFloat("_Luminance", 1461f / farClipPlane);
			this.BBIMPFGLDCP().SetVector("CameraFilterPack/Glow_Glow_Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 548f, 1744f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x000084B8 File Offset: 0x000066B8
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x000DEEE0 File Offset: 0x000DD0E0
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1177f)
			{
				this.HBJJOCHGOPH = 500f;
			}
			this.CEKJODEAMGB().SetFloat("settings.volume.menu", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/Distortion_Dream", this.Fade);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/TV_Distorted", this._FixDistance);
			this.HHIFMIPPMPF().SetFloat("_Value4", this.MatrixSize);
			this.OJMHIMIPKME().SetColor("' has been reset to the fault value", this._MatrixColor);
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack/TV_Old", this.MatrixSpeed * 1608f);
			this.IGKFMCPDNOI().SetFloat("0x", (float)((!this._Visualize) ? 0 : 1));
			this.DKNJGHFLAIF().SetFloat("_CenterX", this.LightIntensity);
			this.GBFOAHKAJEK().SetTexture("Subscribe: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DONENAMLFLF().SetFloat("#exit", 277f / farClipPlane);
			this.PDEAHJPOMEF().SetVector("Uploading content...", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 949f, 198f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x000DF0F0 File Offset: 0x000DD2F0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 74f)
			{
				this.HBJJOCHGOPH = 335f;
			}
			this.CECICEGFHKL().SetFloat(" on effect ", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_ColorRGB", this.Fade);
			this.HKGAONMOBMH().SetFloat("GameScene", this._FixDistance);
			this.DONENAMLFLF().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.MatrixSize);
			this.ABHDNGIHBKE().SetColor("ClearEnvironment", this._MatrixColor);
			this.CEKJODEAMGB().SetFloat(".completed", this.MatrixSpeed * 711f);
			this.PDEAHJPOMEF().SetFloat("Uploading preview image", (float)((!this._Visualize) ? 1 : 0));
			this.DKNJGHFLAIF().SetFloat("R:", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("b", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DONENAMLFLF().SetFloat("table", 1279f / farClipPlane);
			this.GBFOAHKAJEK().SetVector("other.dust2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 21f, 882f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x000DF28C File Offset: 0x000DD48C
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1832f)
			{
				this.HBJJOCHGOPH = 169f;
			}
			this.IGKFMCPDNOI().SetFloat("Up", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("\r", this.Fade);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this._FixDistance);
			this.GBFOAHKAJEK().SetFloat("_VelocityTex", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("ConnectToRegion: ", this._MatrixColor);
			this.HNFFHCLNBDN().SetFloat("Save level before uploading?", this.MatrixSpeed * 1586f);
			this.OJMHIMIPKME().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", (float)((!this._Visualize) ? 1 : 0));
			this.HKGAONMOBMH().SetFloat("_BorderColor", this.LightIntensity);
			this.PGPEMMBJOOG().SetTexture("https://www.youtube.com/watch?v=cDVXukrKo74", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat(".png", 618f / farClipPlane);
			this.DKNJGHFLAIF().SetVector("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 173f, 121f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x000084EF File Offset: 0x000066EF
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("mapselector.orderby") as Texture2D);
		this.SCShader = Shader.Find("Subscribed cells:\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00007F5F File Offset: 0x0000615F
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00008528 File Offset: 0x00006728
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("UI Extensions/SoftMaskShaderText") as Texture2D);
		this.SCShader = Shader.Find("|");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00008561 File Offset: 0x00006761
	private void ODMPMJPALID()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Lut_Simple");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0000859A File Offset: 0x0000679A
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("Could not execute RPC ") as Texture2D);
		this.SCShader = Shader.Find(" / ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x000085D3 File Offset: 0x000067D3
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x00008413 File Offset: 0x00006613
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0000860A File Offset: 0x0000680A
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("Start") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00008643 File Offset: 0x00006843
	private void MEBPBNLBECA()
	{
		this.FPHEBLMINDA = (Resources.Load("\" that takes ") as Texture2D);
		this.SCShader = Shader.Find("System.Int64");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x0000867C File Offset: 0x0000687C
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x000086B3 File Offset: 0x000068B3
	private void CEDFFAOOPOG()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x0000420A File Offset: 0x0000240A
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00008481 File Offset: 0x00006681
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x000086EC File Offset: 0x000068EC
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00008723 File Offset: 0x00006923
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("#tryagain") as Texture2D);
		this.SCShader = Shader.Find("LastHighScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x000DF428 File Offset: 0x000DD628
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1721f)
			{
				this.HBJJOCHGOPH = 985f;
			}
			this.LPDOGGFOBDH().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("yes", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this._FixDistance);
			this.DKNJGHFLAIF().SetFloat("\n", this.MatrixSize);
			this.CECICEGFHKL().SetColor("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", this._MatrixColor);
			this.MHBAIEKFBIJ().SetFloat("[ItemsHandler] All in-game items loaded", this.MatrixSpeed * 1744f);
			this.FKEOGPDLBDD().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", (float)((!this._Visualize) ? 0 : 1));
			this.EOCCJGIGEGJ().SetFloat("MultiplayerButton", this.LightIntensity);
			this.GBFOAHKAJEK().SetTexture("<b>", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPDOGGFOBDH().SetFloat("RestartButton", 803f / farClipPlane);
			this.OJMHIMIPKME().SetVector("_PositionY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 508f, 1492f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x0000875C File Offset: 0x0000695C
	private void ALJEJJCIMJN()
	{
		this.FPHEBLMINDA = (Resources.Load("Please attach component to a Graphical UI component") as Texture2D);
		this.SCShader = Shader.Find("No");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00008795 File Offset: 0x00006995
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_AreaTex") as Texture2D);
		this.SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x000DF5C4 File Offset: 0x000DD7C4
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1121f)
			{
				this.HBJJOCHGOPH = 1491f;
			}
			this.CBCNOEIALHB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("_Value2", this.Fade);
			this.LPDOGGFOBDH().SetFloat("_Offsets", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Horizontal", this.MatrixSize);
			this.CECICEGFHKL().SetColor("_Value", this._MatrixColor);
			this.LPDOGGFOBDH().SetFloat("Case-Sensitive", this.MatrixSpeed * 412f);
			this.MHBAIEKFBIJ().SetFloat("00", (float)((!this._Visualize) ? 0 : 0));
			this.IIJMIPBMMBF().SetFloat("JoinRandom failed: {0}.", this.LightIntensity);
			this.FGENHBKMPDA().SetTexture("_ColorBuffer", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("{\"items\":", 363f / farClipPlane);
			this.HILDKDFEBPF().SetVector("OperationResponse ignored while disconnecting. Code: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 316f, 1109f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00007F5F File Offset: 0x0000615F
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x000DF760 File Offset: 0x000DD960
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 45f)
			{
				this.HBJJOCHGOPH = 1568f;
			}
			this.CEKJODEAMGB().SetFloat("Mouse Wheel Up", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack/Gradients_Stripe", this.Fade);
			this.MHBAIEKFBIJ().SetFloat("[MenuScene] Error: ", this._FixDistance);
			this.CECICEGFHKL().SetFloat("#combo", this.MatrixSize);
			this.CBCNOEIALHB().SetColor("Tab1Content", this._MatrixColor);
			this.MHBAIEKFBIJ().SetFloat("_ReflectionTexture3", this.MatrixSpeed * 1575f);
			this.IGKFMCPDNOI().SetFloat("menutheme.deleted", (float)((!this._Visualize) ? 1 : 0));
			this.IIJMIPBMMBF().SetFloat("/", this.LightIntensity);
			this.IONHGBPGCHK().SetTexture("_Value4", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OJMHIMIPKME().SetFloat("No Name", 1104f / farClipPlane);
			this.GBFOAHKAJEK().SetVector("ConnectionTimeout", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1902f, 219f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x0000420A File Offset: 0x0000240A
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x000087CE File Offset: 0x000069CE
	private Material HILDKDFEBPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00007F5F File Offset: 0x0000615F
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x0000420A File Offset: 0x0000240A
	private void AKCADICOFDD()
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00008805 File Offset: 0x00006A05
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x000DF8FC File Offset: 0x000DDAFC
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1897f)
			{
				this.HBJJOCHGOPH = 374f;
			}
			this.OJMHIMIPKME().SetFloat("_Visualize", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("X2", this.Fade);
			this.IIJMIPBMMBF().SetFloat("maps.", this._FixDistance);
			this.DONENAMLFLF().SetFloat("{0:0.0} ms ({1:0.} fps)", this.MatrixSize);
			this.FGENHBKMPDA().SetColor("CameraFilterPack/Gradients_Rainbow", this._MatrixColor);
			this.HKGAONMOBMH().SetFloat("FinishMap", this.MatrixSpeed * 1425f);
			this.BBIMPFGLDCP().SetFloat("Set Sun Sensitivity", (float)((!this._Visualize) ? 0 : 1));
			this.BBIMPFGLDCP().SetFloat("_ScreenResolution", this.LightIntensity);
			this.EOCCJGIGEGJ().SetTexture("menu.copyright", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack/TV_Vcr", 1587f / farClipPlane);
			this.IONHGBPGCHK().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 916f, 1201f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00008481 File Offset: 0x00006681
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0000883C File Offset: 0x00006A3C
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00008873 File Offset: 0x00006A73
	private void KLILJHJNICK()
	{
		this.FPHEBLMINDA = (Resources.Load("SetParticlesCountPerBeat") as Texture2D);
		this.SCShader = Shader.Find("Freq: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x000DFA98 File Offset: 0x000DDC98
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1612f)
			{
				this.HBJJOCHGOPH = 31f;
			}
			this.ECCPAOBFDKP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("settings.fps", this.Fade);
			this.FKEOGPDLBDD().SetFloat("settings.arcsdestroydelay", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.MatrixSize);
			this.IONHGBPGCHK().SetColor("MouseX", this._MatrixColor);
			this.FGENHBKMPDA().SetFloat("Exception while connecting to: ", this.MatrixSpeed * 1974f);
			this.ABHDNGIHBKE().SetFloat("note.1", (float)((!this._Visualize) ? 1 : 0));
			this.LPDOGGFOBDH().SetFloat("OpJoinRandomRoom()", this.LightIntensity);
			this.PGPEMMBJOOG().SetTexture("_Value7", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Drawing_BluePrint", 839f / farClipPlane);
			this.ECCPAOBFDKP().SetVector("[Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 9f, 1788f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x000088AC File Offset: 0x00006AAC
	private void JONGNKNLLND()
	{
		this.FPHEBLMINDA = (Resources.Load("896296812") as Texture2D);
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00007F5F File Offset: 0x0000615F
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0000420A File Offset: 0x0000240A
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x000088E5 File Offset: 0x00006AE5
	private void CGDMLHLJIDK()
	{
		this.FPHEBLMINDA = (Resources.Load("steamid") as Texture2D);
		this.SCShader = Shader.Find("_Colorisation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0000891E File Offset: 0x00006B1E
	private void MKOMIDCPCDC()
	{
		this.FPHEBLMINDA = (Resources.Load("_Extra") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00008957 File Offset: 0x00006B57
	private void BEBNOKFLJPH()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00008990 File Offset: 0x00006B90
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x000DFC34 File Offset: 0x000DDE34
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1117f)
			{
				this.HBJJOCHGOPH = 291f;
			}
			this.FHFLKLMFHOI().SetFloat("Default UI Material", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("Bad parameters for getbool! Use <key> <value>", this.Fade);
			this.HNFFHCLNBDN().SetFloat("Tab2Content", this._FixDistance);
			this.ADGHJOHKEHG().SetFloat("_MainTex2", this.MatrixSize);
			this.PGPEMMBJOOG().SetColor("_Threshold", this._MatrixColor);
			this.IONHGBPGCHK().SetFloat("/icon", this.MatrixSpeed * 211f);
			this.OJMHIMIPKME().SetFloat("stretchWidth", (float)((!this._Visualize) ? 1 : 0));
			this.DKNJGHFLAIF().SetFloat("Tab2Content", this.LightIntensity);
			this.ADGHJOHKEHG().SetTexture("file://", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FGENHBKMPDA().SetFloat("Set Sun Emission", 1801f / farClipPlane);
			this.HKGAONMOBMH().SetVector("input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1234f, 253f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00007F5F File Offset: 0x0000615F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x000089C7 File Offset: 0x00006BC7
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load("MapEditor v.") as Texture2D);
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0000420A File Offset: 0x0000240A
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x000DFDD0 File Offset: 0x000DDFD0
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

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000851 RID: 2129 RVA: 0x00008A00 File Offset: 0x00006C00
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

	// Token: 0x06000852 RID: 2130 RVA: 0x00007F5F File Offset: 0x0000615F
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00008A37 File Offset: 0x00006C37
	private void CFFCLAHMBAA()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.enableranking") as Texture2D);
		this.SCShader = Shader.Find("replayData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x0000420A File Offset: 0x0000240A
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00007F5F File Offset: 0x0000615F
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00007F5F File Offset: 0x0000615F
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00007F5F File Offset: 0x0000615F
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x000DFF6C File Offset: 0x000DE16C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 631f)
			{
				this.HBJJOCHGOPH = 927f;
			}
			this.ABHDNGIHBKE().SetFloat("CurrentTimeLabel", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("DifficultyBG", this.Fade);
			this.LPDOGGFOBDH().SetFloat("Set Particles Count Per Beat", this._FixDistance);
			this.LPDOGGFOBDH().SetFloat(". The group number should be at least 1.", this.MatrixSize);
			this.FHFLKLMFHOI().SetColor("_ScreenResolution", this._MatrixColor);
			this.HEINDEMCGIK().SetFloat("HandsCountSlider", this.MatrixSpeed * 948f);
			this.HHIFMIPPMPF().SetFloat("The binding '", (float)((!this._Visualize) ? 0 : 0));
			this.CBCNOEIALHB().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", this.LightIntensity);
			this.HKGAONMOBMH().SetTexture("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CBCNOEIALHB().SetFloat("Preparing configuration", 31f / farClipPlane);
			this.EOCCJGIGEGJ().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 660f, 155f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00008A70 File Offset: 0x00006C70
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00007F5F File Offset: 0x0000615F
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00008AA7 File Offset: 0x00006CA7
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("COMPLETED") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00007F5F File Offset: 0x0000615F
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x000082C3 File Offset: 0x000064C3
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400013D RID: 317
	public Shader SCShader;

	// Token: 0x0400013E RID: 318
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400013F RID: 319
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000140 RID: 320
	private Material BJFKDHHMLJH;

	// Token: 0x04000141 RID: 321
	public bool _Visualize;

	// Token: 0x04000142 RID: 322
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x04000143 RID: 323
	[Range(-5f, 5f)]
	public float LightIntensity = 1f;

	// Token: 0x04000144 RID: 324
	[Range(0f, 6f)]
	public float MatrixSize = 1f;

	// Token: 0x04000145 RID: 325
	[Range(-4f, 4f)]
	public float MatrixSpeed = 1f;

	// Token: 0x04000146 RID: 326
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000147 RID: 327
	public Color _MatrixColor = new Color(0f, 1f, 0f, 1f);

	// Token: 0x04000148 RID: 328
	public static Color ChangeColorRGB;

	// Token: 0x04000149 RID: 329
	private Texture2D FPHEBLMINDA;
}
