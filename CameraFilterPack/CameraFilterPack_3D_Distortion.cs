/*
Importance of this class: Unknown

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000020 RID: 32
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Distortion")]
public class CameraFilterPack_3D_Distortion : MonoBehaviour
{
	// Token: 0x06000681 RID: 1665 RVA: 0x00006375 File Offset: 0x00004575
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000D63E4 File Offset: 0x000D45E4
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1408f)
			{
				this.HBJJOCHGOPH = 740f;
			}
			this.KGOLDDBHIFN().SetFloat("_Value2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1227f)
				{
					this._Distance = 35f;
				}
				if (this._Distance < 1763f)
				{
					this._Distance = 694f;
				}
				this.PLBEJJIHFPB().SetFloat(",", this._Distance);
			}
			else
			{
				this.IIBLJCKLGFG().SetFloat("[#clicktoacceptchallenge]", this._Distance);
			}
			this.ADBKPGFMNKO().SetFloat("[PlayerBase] Saveing checkpoint data", this._Size);
			this.ADBKPGFMNKO().SetFloat("14", this._FixDistance);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.DistortionLevel * 1926f);
			this.KGOLDDBHIFN().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.DistortionSize * 404f);
			this.KGOLDDBHIFN().SetFloat("Keypad", this.LightIntensity * 991f);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Blur_Focus", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ACHNOHCLGOO().SetFloat(", data: ", 725f / farClipPlane);
			this.GCDFNHMJMIP().SetVector("InventoryGrid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1220f, 986f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x000D65E8 File Offset: 0x000D47E8
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 621f)
			{
				this.HBJJOCHGOPH = 931f;
			}
			this.EPCGJFCCAFH().SetFloat("musicVolume", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 115f)
				{
					this._Distance = 260f;
				}
				if (this._Distance < 91f)
				{
					this._Distance = 104f;
				}
				this.ADBKPGFMNKO().SetFloat("Please wait..", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("seconds", this._Distance);
			}
			this.PLBEJJIHFPB().SetFloat(" has no method \"", this._Size);
			this.NBPKMLMCHFN.SetFloat(": ", this._FixDistance);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.DistortionLevel * 838f);
			this.ACHNOHCLGOO().SetFloat("_Parasite", this.DistortionSize * 1821f);
			this.HFBJAOFLCJI().SetFloat("\" gets executed locally only, if at all.", this.LightIntensity * 812f);
			this.NBPKMLMCHFN.SetFloat("note.4", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.PLBEJJIHFPB().SetFloat(".lastCheckpoint.penaltyScore", 437f / farClipPlane);
			this.PLBEJJIHFPB().SetVector("CameraFilterPack/Gradients_Ansi", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 387f, 1609f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00006392 File Offset: 0x00004592
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("FullscreenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00006375 File Offset: 0x00004575
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x000063B6 File Offset: 0x000045B6
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("SetParticlesEmission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x000063DA File Offset: 0x000045DA
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00006411 File Offset: 0x00004611
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00006448 File Offset: 0x00004648
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x0000646C File Offset: 0x0000466C
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x0000420A File Offset: 0x0000240A
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x000D67EC File Offset: 0x000D49EC
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 505f)
			{
				this.HBJJOCHGOPH = 825f;
			}
			this.PLBEJJIHFPB().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 977f)
				{
					this._Distance = 1219f;
				}
				if (this._Distance < 1060f)
				{
					this._Distance = 1735f;
				}
				this.OIMMPLPBLBK().SetFloat("CameraFilterPack_TV_BrokenGlass_2", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("88f00bdf0ad61b16b803971ebe071962", this._Distance);
			}
			this.OIMMPLPBLBK().SetFloat("Received event Leave for unknown player ID: {0}", this._Size);
			this.OIMMPLPBLBK().SetFloat("_ScreenResolution", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("color", this.DistortionLevel * 940f);
			this.ACHNOHCLGOO().SetFloat("_BlurVector", this.DistortionSize * 1632f);
			this.PLBEJJIHFPB().SetFloat("Subscribed cells:\n", this.LightIntensity * 1936f);
			this.NBPKMLMCHFN.SetFloat(", data: ", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("Instantiating: ", 1856f / farClipPlane);
			this.IIBLJCKLGFG().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 751f, 600f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x000064A3 File Offset: 0x000046A3
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x000064C7 File Offset: 0x000046C7
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("Forward");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x000D69F0 File Offset: 0x000D4BF0
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
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel * 28f);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize * 16f);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
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

	// Token: 0x06000691 RID: 1681 RVA: 0x00006375 File Offset: 0x00004575
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x000064EB File Offset: 0x000046EB
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00006522 File Offset: 0x00004722
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("SetSatelliteInput");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00006546 File Offset: 0x00004746
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00006375 File Offset: 0x00004575
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x0000657D File Offset: 0x0000477D
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x000065B4 File Offset: 0x000047B4
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x0000420A File Offset: 0x0000240A
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600069D RID: 1693 RVA: 0x000065EB File Offset: 0x000047EB
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

	// Token: 0x0600069E RID: 1694 RVA: 0x00006375 File Offset: 0x00004575
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00006622 File Offset: 0x00004822
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x000D6C60 File Offset: 0x000D4E60
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1091f)
			{
				this.HBJJOCHGOPH = 85f;
			}
			this.IONHGBPGCHK().SetFloat("[Left]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1411f)
				{
					this._Distance = 861f;
				}
				if (this._Distance < 1201f)
				{
					this._Distance = 403f;
				}
				this.EPCGJFCCAFH().SetFloat("UseScanLineSize", this._Distance);
			}
			else
			{
				this.IONHGBPGCHK().SetFloat("_MainTex2", this._Distance);
			}
			this.EPCGJFCCAFH().SetFloat("maphash", this._Size);
			this.OIMMPLPBLBK().SetFloat("/", this._FixDistance);
			this.EPCGJFCCAFH().SetFloat("_Luminance", this.DistortionLevel * 973f);
			this.IONHGBPGCHK().SetFloat("_Vignette", this.DistortionSize * 1641f);
			this.NBPKMLMCHFN.SetFloat(".lastCheckpoint.penaltyScore", this.LightIntensity * 1139f);
			this.MMOODGIODPC().SetFloat("DPADVER", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ACHNOHCLGOO().SetFloat("[PlayerBase] Loaded spawner data", 86f / farClipPlane);
			this.EPCGJFCCAFH().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1416f, 1734f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00006646 File Offset: 0x00004846
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x0000667D File Offset: 0x0000487D
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x000066A1 File Offset: 0x000048A1
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x000066D8 File Offset: 0x000048D8
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00006375 File Offset: 0x00004575
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x000D6E64 File Offset: 0x000D5064
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 419f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.GCDFNHMJMIP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1957f)
				{
					this._Distance = 1663f;
				}
				if (this._Distance < 884f)
				{
					this._Distance = 1588f;
				}
				this.OIMMPLPBLBK().SetFloat("_TimeX", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this._Distance);
			}
			this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Blend2Camera_Color", this._Size);
			this.KGOLDDBHIFN().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("CorrectHitsScoreText", this.DistortionLevel * 1900f);
			this.IIBLJCKLGFG().SetFloat("_LightIntensity", this.DistortionSize * 1445f);
			this.PLBEJJIHFPB().SetFloat("_MainTex2", this.LightIntensity * 771f);
			this.IIBLJCKLGFG().SetFloat("SetPlayerDistance", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_Value3", 844f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("settings.gamemessagesduration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1740f, 199f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00006375 File Offset: 0x00004575
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x000D7068 File Offset: 0x000D5268
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1818f)
			{
				this.HBJJOCHGOPH = 426f;
			}
			this.OIMMPLPBLBK().SetFloat(": ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1787f)
				{
					this._Distance = 355f;
				}
				if (this._Distance < 1701f)
				{
					this._Distance = 137f;
				}
				this.MMOODGIODPC().SetFloat("%", this._Distance);
			}
			else
			{
				this.EPCGJFCCAFH().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this._Distance);
			}
			this.ACHNOHCLGOO().SetFloat("ShowSprite", this._Size);
			this.KGOLDDBHIFN().SetFloat("_FarCamera", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("Show Image", this.DistortionLevel * 10f);
			this.ACHNOHCLGOO().SetFloat(" ", this.DistortionSize * 685f);
			this.EPCGJFCCAFH().SetFloat("_Vignetting", this.LightIntensity * 449f);
			this.GCDFNHMJMIP().SetFloat("health", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MMOODGIODPC().SetFloat("_TimeX", 815f / farClipPlane);
			this.MMOODGIODPC().SetVector("menutheme.27thfloor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1032f, 441f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x0000670F File Offset: 0x0000490F
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x000D726C File Offset: 0x000D546C
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 303f)
			{
				this.HBJJOCHGOPH = 769f;
			}
			this.ADBKPGFMNKO().SetFloat("ClearEnvironment", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1754f)
				{
					this._Distance = 525f;
				}
				if (this._Distance < 115f)
				{
					this._Distance = 1955f;
				}
				this.GCDFNHMJMIP().SetFloat("_", this._Distance);
			}
			else
			{
				this.EPCGJFCCAFH().SetFloat("_TimeX", this._Distance);
			}
			this.PLBEJJIHFPB().SetFloat("Set camera (or player) distance. Base player distance - 14", this._Size);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this._FixDistance);
			this.IONHGBPGCHK().SetFloat("MapperNameText", this.DistortionLevel * 1054f);
			this.NBPKMLMCHFN.SetFloat("The given 2D texture ", this.DistortionSize * 1551f);
			this.GCDFNHMJMIP().SetFloat("_Value2", this.LightIntensity * 949f);
			this.KGOLDDBHIFN().SetFloat("_Value1", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HFBJAOFLCJI().SetFloat("No child content found, exiting..", 1922f / farClipPlane);
			this.MMOODGIODPC().SetVector(" - ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 302f, 1608f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000105 RID: 261
	public Shader SCShader;

	// Token: 0x04000106 RID: 262
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000107 RID: 263
	public bool _Visualize;

	// Token: 0x04000108 RID: 264
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000109 RID: 265
	private Material BJFKDHHMLJH;

	// Token: 0x0400010A RID: 266
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x0400010B RID: 267
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	// Token: 0x0400010C RID: 268
	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	// Token: 0x0400010D RID: 269
	[Range(0f, 10f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x0400010E RID: 270
	[Range(0.1f, 10f)]
	public float DistortionSize = 1.4f;

	// Token: 0x0400010F RID: 271
	[Range(-2f, 4f)]
	public float LightIntensity = 0.08f;

	// Token: 0x04000110 RID: 272
	public bool AutoAnimatedNear;

	// Token: 0x04000111 RID: 273
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000112 RID: 274
	public static Color ChangeColorRGB;
}
