/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000035 RID: 53
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Rain")]
public class CameraFilterPack_Atmosphere_Rain : MonoBehaviour
{
	// Token: 0x06000DB3 RID: 3507 RVA: 0x0000EF23 File Offset: 0x0000D123
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x0000EF77 File Offset: 0x0000D177
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("\n\n#") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
	private void JMEOGJHCONJ()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab1Content") as Texture2D);
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x000FA5CC File Offset: 0x000F87CC
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1137f)
			{
				this.HBJJOCHGOPH = 602f;
			}
			this.JIBOKBCPDLC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("Subscribe: ", this.Fade);
			this.FKEOGPDLBDD().SetFloat("Please wait..", this.Intensity);
			this.HKIMAANBGMJ().SetFloat("ViewMenu", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("_RGB", this.Speed);
			this.MJJIEHANFJA().SetFloat("maps.", this.Size);
			this.JIBOKBCPDLC().SetFloat(" ", this.Distortion);
			this.GJHLADDCMFF().SetFloat("_Exponent", this.StormFlashOnOff);
			this.KGOLDDBHIFN().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 583f, 516f));
			this.PDEAHJPOMEF().SetTexture("Bad parameters for getstring! Use <key> <value>", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x000FA724 File Offset: 0x000F8924
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1436f)
			{
				this.HBJJOCHGOPH = 1714f;
			}
			this.GJHLADDCMFF().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("Set Sun Sensitivity", this.Fade);
			this.IKBJACCLPCL().SetFloat("Set arcs speed. Base value - 15", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("STICKLHOR", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.Speed);
			this.HKIMAANBGMJ().SetFloat(". Should be just one?", this.Size);
			this.HKIMAANBGMJ().SetFloat("_EmissionGain", this.Distortion);
			this.KHCLIAMBBNC().SetFloat("settings.enablehitsoundsinnormal", this.StormFlashOnOff);
			this.FKEOGPDLBDD().SetVector("EventData0DropDownList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 353f, 520f));
			this.GJHLADDCMFF().SetTexture(" (", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x0000EFE9 File Offset: 0x0000D1E9
	private void FHPFJBFCOOF()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab2Content") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x0000F022 File Offset: 0x0000D222
	private void KMCPMOGKDEH()
	{
		this.FPHEBLMINDA = (Resources.Load("Set Object Scale") as Texture2D);
		this.SCShader = Shader.Find("_BlurDirectionPacked");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x0000F05B File Offset: 0x0000D25B
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x0000420A File Offset: 0x0000240A
	private void ICGNMOFMLFA()
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x000FA87C File Offset: 0x000F8A7C
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 1302f;
			}
			this.KHCLIAMBBNC().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_BlurParams", this.Fade);
			this.FGENHBKMPDA().SetFloat("_Glitch", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.DirectionX);
			this.IGKFMCPDNOI().SetFloat("ShowTitle", this.Speed);
			this.JIBOKBCPDLC().SetFloat("Save", this.Size);
			this.FKEOGPDLBDD().SetFloat("GlassesColor", this.Distortion);
			this.NFKFAAHHLLM().SetFloat("_ScreenResolution", this.StormFlashOnOff);
			this.LPDOGGFOBDH().SetVector("{0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1050f, 1229f));
			this.KGOLDDBHIFN().SetTexture("LoadPlayerSkin", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x0000F092 File Offset: 0x0000D292
	private void AEDDNDHCLNN()
	{
		this.FPHEBLMINDA = (Resources.Load("Please define the RectTransform for the Center viewport of the scrollable area") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x000FA9D4 File Offset: 0x000F8BD4
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 938f)
			{
				this.HBJJOCHGOPH = 630f;
			}
			this.HKIMAANBGMJ().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("RenderTextureUtilityTempTexture", this.Fade);
			this.NFKFAAHHLLM().SetFloat("_ScreenResolution", this.Intensity);
			this.NJDIODJNGGA().SetFloat("_ScreenResolution", this.DirectionX);
			this.IGKFMCPDNOI().SetFloat("SetCrosshairColor", this.Speed);
			this.KLKILLCHJHO().SetFloat("_Value", this.Size);
			this.PLBEJJIHFPB().SetFloat("[PlayerBase] Invoke event ", this.Distortion);
			this.IKBJACCLPCL().SetFloat("_Value2", this.StormFlashOnOff);
			this.IGKFMCPDNOI().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 682f, 318f));
			this.NJDIODJNGGA().SetTexture("original.tutorial", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x0000420A File Offset: 0x0000240A
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x000FAB2C File Offset: 0x000F8D2C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1026f)
			{
				this.HBJJOCHGOPH = 648f;
			}
			this.JIBOKBCPDLC().SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("EventSystem", this.Fade);
			this.KOHGPKOFEJO().SetFloat("_TimeX", this.Intensity);
			this.EBJKJPAIAAM().SetFloat("yyyy-MM-dd HH:mm:ss", this.DirectionX);
			this.EOCCJGIGEGJ().SetFloat("Operation failed: ", this.Speed);
			this.PLBEJJIHFPB().SetFloat("_Value", this.Size);
			this.LPDOGGFOBDH().SetFloat("original.tutorial", this.Distortion);
			this.ECCPAOBFDKP().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this.StormFlashOnOff);
			this.NFKFAAHHLLM().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 364f, 587f));
			this.LPDOGGFOBDH().SetTexture("CameraFilterPack/Drawing_Paper3", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x0000420A File Offset: 0x0000240A
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x000FAC84 File Offset: 0x000F8E84
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 10f)
			{
				this.HBJJOCHGOPH = 1738f;
			}
			this.IIJMIPBMMBF().SetFloat("{0}", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("LoadPlayerEnvironment", this.Fade);
			this.FKEOGPDLBDD().SetFloat("PUNCloudBestRegion", this.Intensity);
			this.DIOAAHJDMLK().SetFloat(".highscore", this.DirectionX);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.Speed);
			this.BLMPMOIDGMG().SetFloat("x", this.Size);
			this.MJJIEHANFJA().SetFloat("0.00", this.Distortion);
			this.OCHJIMJNEMO().SetFloat("y", this.StormFlashOnOff);
			this.EOCCJGIGEGJ().SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 985f, 554f));
			this.FGENHBKMPDA().SetTexture("CameraFilterPack/Blend2Camera_Saturation", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x000FADDC File Offset: 0x000F8FDC
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x0000F0CB File Offset: 0x0000D2CB
	private Material IKBJACCLPCL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x0000F102 File Offset: 0x0000D302
	private void MKOMIDCPCDC()
	{
		this.FPHEBLMINDA = (Resources.Load("float,0") as Texture2D);
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x0000F13B File Offset: 0x0000D33B
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x0000F172 File Offset: 0x0000D372
	private void LGHCJCFHEMF()
	{
		this.FPHEBLMINDA = (Resources.Load(" url: ") as Texture2D);
		this.SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x0000F1AB File Offset: 0x0000D3AB
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x0000F21B File Offset: 0x0000D41B
	private void PDHKMDBNGGN()
	{
		this.FPHEBLMINDA = (Resources.Load("[MapsData] Found ") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack_TV_Arcade1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x0000F254 File Offset: 0x0000D454
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x0000F28B File Offset: 0x0000D48B
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("setAF") as Texture2D);
		this.SCShader = Shader.Find("Bass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x000FAF34 File Offset: 0x000F9134
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 122f)
			{
				this.HBJJOCHGOPH = 659f;
			}
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/3D_Myst", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_Value4", this.Fade);
			this.PDEAHJPOMEF().SetFloat("_Blue_B", this.Intensity);
			this.KHCLIAMBBNC().SetFloat(":</b> ", this.DirectionX);
			this.PDEAHJPOMEF().SetFloat("Distortion", this.Speed);
			this.KOHGPKOFEJO().SetFloat("Pop", this.Size);
			this.ECCPAOBFDKP().SetFloat("_SmoothEnd", this.Distortion);
			this.DIOAAHJDMLK().SetFloat("shader.invert", this.StormFlashOnOff);
			this.PLBEJJIHFPB().SetVector("skin.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 263f, 1547f));
			this.MJJIEHANFJA().SetTexture("SetParent", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x0000F2FB File Offset: 0x0000D4FB
	private void ECBILENEOOL()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("\r");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x000FB08C File Offset: 0x000F928C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1187f)
			{
				this.HBJJOCHGOPH = 1194f;
			}
			this.KEMAALEODNH().SetFloat("y", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("Fade", this.Fade);
			this.JIBOKBCPDLC().SetFloat("Set Satellite Input", this.Intensity);
			this.DIOAAHJDMLK().SetFloat("_AccumulationTex", this.DirectionX);
			this.BLMPMOIDGMG().SetFloat("float,0", this.Speed);
			this.GJHLADDCMFF().SetFloat("Joystick1Button9", this.Size);
			this.KOHGPKOFEJO().SetFloat("/config", this.Distortion);
			this.IGKFMCPDNOI().SetFloat("unsubscribemap", this.StormFlashOnOff);
			this.KLKILLCHJHO().SetVector("SpectatingUserInfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 321f, 637f));
			this.KEMAALEODNH().SetTexture("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x000FB1E4 File Offset: 0x000F93E4
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 447f)
			{
				this.HBJJOCHGOPH = 1614f;
			}
			this.LPDOGGFOBDH().SetFloat("Jazz", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat(" to: ", this.Fade);
			this.IIJMIPBMMBF().SetFloat("_Value6", this.Intensity);
			this.KEMAALEODNH().SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", this.DirectionX);
			this.FGENHBKMPDA().SetFloat("Subscribe: ", this.Speed);
			this.IIJMIPBMMBF().SetFloat("[LevelEditorScene] Creating new item...", this.Size);
			this.BLMPMOIDGMG().SetFloat("SpawnObj", this.Distortion);
			this.PLBEJJIHFPB().SetFloat("shader.none", this.StormFlashOnOff);
			this.PLBEJJIHFPB().SetVector("Had to lookup view that wasn't in photonViewList: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 814f, 1907f));
			this.KOHGPKOFEJO().SetTexture("Beat Detected", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x0000F334 File Offset: 0x0000D534
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load(". Calling ConnectToRegionMaster() is: ") as Texture2D);
		this.SCShader = Shader.Find("[Up-Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x0000F36D File Offset: 0x0000D56D
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("1,30,true,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x0000F3A6 File Offset: 0x0000D5A6
	private void EIMNPCMHJLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("Creating new item...") as Texture2D);
		this.SCShader = Shader.Find("colorC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x0000F3DF File Offset: 0x0000D5DF
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x0000F416 File Offset: 0x0000D616
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("?") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x000FB33C File Offset: 0x000F953C
	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 475f)
			{
				this.HBJJOCHGOPH = 1901f;
			}
			this.FKEOGPDLBDD().SetFloat("End index must in an integer.", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("CameraFilterPack/BlurTiltShift_Hole", this.Fade);
			this.KOHGPKOFEJO().SetFloat(">", this.Intensity);
			this.KLKILLCHJHO().SetFloat("_Value3", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("_SecondTex", this.Speed);
			this.KHCLIAMBBNC().SetFloat("EditMenu", this.Size);
			this.KGOLDDBHIFN().SetFloat("_Value2", this.Distortion);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack_TV_BrokenGlass1", this.StormFlashOnOff);
			this.KHCLIAMBBNC().SetVector("finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1143f, 1617f));
			this.EOCCJGIGEGJ().SetTexture("/../", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x0000F44F File Offset: 0x0000D64F
	private void DOKAKEMDALN()
	{
		this.FPHEBLMINDA = (Resources.Load("Creating new item...") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x000FB494 File Offset: 0x000F9694
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1841f)
			{
				this.HBJJOCHGOPH = 1556f;
			}
			this.KEMAALEODNH().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_Value2", this.Fade);
			this.PDEAHJPOMEF().SetFloat("0 - default, 1 - left, 2 - right", this.Intensity);
			this.BLMPMOIDGMG().SetFloat(".completed", this.DirectionX);
			this.HKIMAANBGMJ().SetFloat("ResourceIDInputField", this.Speed);
			this.PDEAHJPOMEF().SetFloat("_MainTex2", this.Size);
			this.MJJIEHANFJA().SetFloat(".lastCheckpoint.perfectHits", this.Distortion);
			this.NJDIODJNGGA().SetFloat("GenerationMenu", this.StormFlashOnOff);
			this.NFKFAAHHLLM().SetVector("inventory.selected.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 785f, 187f));
			this.KLKILLCHJHO().SetTexture(". Stopping handling if inactive.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x0000F488 File Offset: 0x0000D688
	private void CEAGPJBGBMH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Bullet_1") as Texture2D);
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x0000420A File Offset: 0x0000240A
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x000FB5EC File Offset: 0x000F97EC
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1631f)
			{
				this.HBJJOCHGOPH = 1123f;
			}
			this.KEMAALEODNH().SetFloat(" takes from: ", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_Amount", this.Fade);
			this.PLBEJJIHFPB().SetFloat(".completed", this.Intensity);
			this.GJHLADDCMFF().SetFloat("_TimeX", this.DirectionX);
			this.KEMAALEODNH().SetFloat("settings.enablerankingnotifications", this.Speed);
			this.FKEOGPDLBDD().SetFloat("_Parasite", this.Size);
			this.IGKFMCPDNOI().SetFloat("Feb", this.Distortion);
			this.LPDOGGFOBDH().SetFloat("CameraFilterPack/Distortion_Twist", this.StormFlashOnOff);
			this.FGENHBKMPDA().SetVector("[MapEditor] Item creation successful! Published Item ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 977f, 333f));
			this.KLKILLCHJHO().SetTexture("float,1.5", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x000FB744 File Offset: 0x000F9944
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1913f)
			{
				this.HBJJOCHGOPH = 74f;
			}
			this.KHCLIAMBBNC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("GlassesColor", this.Fade);
			this.OCHJIMJNEMO().SetFloat("0.00/0.00", this.Intensity);
			this.IKBJACCLPCL().SetFloat("CameraFilterPack/Distortion_Half_Sphere", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("Set sun min/max size", this.Speed);
			this.GJHLADDCMFF().SetFloat("_Value", this.Size);
			this.EBJKJPAIAAM().SetFloat("_MaxBlurRadius", this.Distortion);
			this.NJDIODJNGGA().SetFloat("[LevelEditorScene] Print Audio Wave: Done", this.StormFlashOnOff);
			this.ECCPAOBFDKP().SetVector("_FadeFX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 838f, 903f));
			this.GJHLADDCMFF().SetTexture("#failed: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x000FB89C File Offset: 0x000F9A9C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1045f)
			{
				this.HBJJOCHGOPH = 1209f;
			}
			this.DIOAAHJDMLK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_Alpha", this.Fade);
			this.OCHJIMJNEMO().SetFloat("#onrankchangeuptext", this.Intensity);
			this.FGENHBKMPDA().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.DirectionX);
			this.IIJMIPBMMBF().SetFloat("IconImage", this.Speed);
			this.IIJMIPBMMBF().SetFloat("_Amount", this.Size);
			this.DIOAAHJDMLK().SetFloat("_TimeX", this.Distortion);
			this.KGOLDDBHIFN().SetFloat("In Main Menu", this.StormFlashOnOff);
			this.IKBJACCLPCL().SetVector("_VignetteCenter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 362f, 54f));
			this.DIOAAHJDMLK().SetTexture("settings.crosshairopacity", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x000FB9F4 File Offset: 0x000F9BF4
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 944f)
			{
				this.HBJJOCHGOPH = 388f;
			}
			this.HKIMAANBGMJ().SetFloat("[ERROR KEY {0}]", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat(":", this.Fade);
			this.KLKILLCHJHO().SetFloat("_MainTex2", this.Intensity);
			this.JIBOKBCPDLC().SetFloat("\n", this.DirectionX);
			this.GJHLADDCMFF().SetFloat("float,0", this.Speed);
			this.NBPKMLMCHFN.SetFloat("MapEnd", this.Size);
			this.KHCLIAMBBNC().SetFloat("_Fade", this.Distortion);
			this.KEMAALEODNH().SetFloat("EndlessLoopsScoreText", this.StormFlashOnOff);
			this.NJDIODJNGGA().SetVector("_SprTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 876f, 688f));
			this.KGOLDDBHIFN().SetTexture("maps.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x000FBB4C File Offset: 0x000F9D4C
	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 782f)
			{
				this.HBJJOCHGOPH = 978f;
			}
			this.KEMAALEODNH().SetFloat("skin.", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat(" Remote called.", this.Fade);
			this.KEMAALEODNH().SetFloat("Editor/", this.Intensity);
			this.KLKILLCHJHO().SetFloat("Bass", this.DirectionX);
			this.JIBOKBCPDLC().SetFloat("_Green_G", this.Speed);
			this.EBJKJPAIAAM().SetFloat("_Light2", this.Size);
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/Distortion_Aspiration", this.Distortion);
			this.NJDIODJNGGA().SetFloat("_FarCamera", this.StormFlashOnOff);
			this.IKBJACCLPCL().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1409f, 21f));
			this.NFKFAAHHLLM().SetTexture("PRESS A KEY", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x0000420A File Offset: 0x0000240A
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x0000F4C1 File Offset: 0x0000D6C1
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x000FBCA4 File Offset: 0x000F9EA4
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1600f)
			{
				this.HBJJOCHGOPH = 437f;
			}
			this.KOHGPKOFEJO().SetFloat("#status", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("CameraFilterPack/TV_Video3D", this.Fade);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("_MainTex2", this.DirectionX);
			this.LPDOGGFOBDH().SetFloat("_Value", this.Speed);
			this.KHCLIAMBBNC().SetFloat("EventMenu", this.Size);
			this.MJJIEHANFJA().SetFloat("_TimeX", this.Distortion);
			this.IIJMIPBMMBF().SetFloat("_VelocityScale", this.StormFlashOnOff);
			this.PLBEJJIHFPB().SetVector(" - PUBLISHED #", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 557f, 157f));
			this.LPDOGGFOBDH().SetTexture("ConnectUsingSettings() disabled the offline mode. No longer offline.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
	private void ODBNMPGBCGO()
	{
		this.FPHEBLMINDA = (Resources.Load("GameScene") as Texture2D);
		this.SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x0000F531 File Offset: 0x0000D731
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x0000F568 File Offset: 0x0000D768
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("_ExposureAdjustment") as Texture2D);
		this.SCShader = Shader.Find("ns");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x000FBDFC File Offset: 0x000F9FFC
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 233f)
			{
				this.HBJJOCHGOPH = 1560f;
			}
			this.KOHGPKOFEJO().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("Joystick1Button5", this.Fade);
			this.GJHLADDCMFF().SetFloat("attempted to spawn go (", this.Intensity);
			this.PLBEJJIHFPB().SetFloat("_Distortion", this.DirectionX);
			this.JIBOKBCPDLC().SetFloat("_FadeFX", this.Speed);
			this.KOHGPKOFEJO().SetFloat("SetParticlesColor", this.Size);
			this.PDEAHJPOMEF().SetFloat("a year ago", this.Distortion);
			this.KEMAALEODNH().SetFloat("_TimeX", this.StormFlashOnOff);
			this.PLBEJJIHFPB().SetVector("-", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 675f, 16f));
			this.KHCLIAMBBNC().SetTexture("CameraFilterPack/Color_Switching", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x0000F5A1 File Offset: 0x0000D7A1
	private void AKHCOBHHGJP()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.selectormapsperpage") as Texture2D);
		this.SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x0000F5DA File Offset: 0x0000D7DA
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x000FBF54 File Offset: 0x000FA154
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 568f)
			{
				this.HBJJOCHGOPH = 1532f;
			}
			this.MJJIEHANFJA().SetFloat("time: ", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("{\"items\":", this.Fade);
			this.FGENHBKMPDA().SetFloat("<b>Speed</b>:", this.Intensity);
			this.NJDIODJNGGA().SetFloat("Editor/", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("_ConsoleSettings", this.Speed);
			this.ECCPAOBFDKP().SetFloat("/", this.Size);
			this.ECCPAOBFDKP().SetFloat("_FilteredReflections", this.Distortion);
			this.HKIMAANBGMJ().SetFloat("skin.hit_wrong", this.StormFlashOnOff);
			this.JIBOKBCPDLC().SetVector("menu.enableselectormusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1139f, 1491f));
			this.MJJIEHANFJA().SetTexture("inventory.selected.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x0000F611 File Offset: 0x0000D811
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Speed") as Texture2D);
		this.SCShader = Shader.Find("settings.enablehitsoundsinrelax");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x0000F64A File Offset: 0x0000D84A
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x0000420A File Offset: 0x0000240A
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x0000420A File Offset: 0x0000240A
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x000FC0AC File Offset: 0x000FA2AC
	private void KHGEBPHKAGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 961f)
			{
				this.HBJJOCHGOPH = 1226f;
			}
			this.ECCPAOBFDKP().SetFloat("skin.", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("_TimeX", this.Fade);
			this.FKEOGPDLBDD().SetFloat("MenuScene", this.Intensity);
			this.FKEOGPDLBDD().SetFloat("bans.viewed.", this.DirectionX);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.Speed);
			this.GJHLADDCMFF().SetFloat("skin.hit_wrong", this.Size);
			this.KLKILLCHJHO().SetFloat(" is not supported on this platform!", this.Distortion);
			this.KEMAALEODNH().SetFloat("_Value7", this.StormFlashOnOff);
			this.GJHLADDCMFF().SetVector("[SERVER] Selected map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1194f, 543f));
			this.FGENHBKMPDA().SetTexture("%", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x0000F683 File Offset: 0x0000D883
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.crosshairopacity") as Texture2D);
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x000FC204 File Offset: 0x000FA404
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1457f)
			{
				this.HBJJOCHGOPH = 3f;
			}
			this.NBPKMLMCHFN.SetFloat("[ResourcesManager] Load text error: not found", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("Vignette", this.Fade);
			this.KGOLDDBHIFN().SetFloat("_VelTex", this.Intensity);
			this.MJJIEHANFJA().SetFloat("BitsData", this.DirectionX);
			this.PDEAHJPOMEF().SetFloat("LivesSlider", this.Speed);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack/Retro_Loading", this.Size);
			this.NJDIODJNGGA().SetFloat("config.txt", this.Distortion);
			this.KOHGPKOFEJO().SetFloat("[Right]", this.StormFlashOnOff);
			this.NJDIODJNGGA().SetVector("Overlay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 589f));
			this.NJDIODJNGGA().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x0000F6BC File Offset: 0x0000D8BC
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x0000F5DA File Offset: 0x0000D7DA
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0000F6F3 File Offset: 0x0000D8F3
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

	// Token: 0x06000E0C RID: 3596 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x0000F72A File Offset: 0x0000D92A
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x0000F761 File Offset: 0x0000D961
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x0000F798 File Offset: 0x0000D998
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x000FC35C File Offset: 0x000FA55C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1241f)
			{
				this.HBJJOCHGOPH = 851f;
			}
			this.FGENHBKMPDA().SetFloat("settings.selectormapsperpage", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("LevelEditor/CustomEventEditor-Text", this.Fade);
			this.ECCPAOBFDKP().SetFloat(".", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.DirectionX);
			this.ECCPAOBFDKP().SetFloat("LoadingStatusText", this.Speed);
			this.DIOAAHJDMLK().SetFloat("_BlurCoe", this.Size);
			this.NJDIODJNGGA().SetFloat("_TimeX", this.Distortion);
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack_Glasses_On4", this.StormFlashOnOff);
			this.NFKFAAHHLLM().SetVector("no lives color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1466f, 565f));
			this.ECCPAOBFDKP().SetTexture(",", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x0000F7CF File Offset: 0x0000D9CF
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("<b>") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x0000F808 File Offset: 0x0000DA08
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x0000F83F File Offset: 0x0000DA3F
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("Mouse X") as Texture2D);
		this.SCShader = Shader.Find("[MapsData] Bad map: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x0000F878 File Offset: 0x0000DA78
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x0000F8AF File Offset: 0x0000DAAF
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("red") as Texture2D);
		this.SCShader = Shader.Find("[PlayerBase] Invoke event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x0000F91F File Offset: 0x0000DB1F
	private void HAIAHJPCPAG()
	{
		this.FPHEBLMINDA = (Resources.Load("SpawnObj") as Texture2D);
		this.SCShader = Shader.Find("[TextSaver] Text saved to ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x0000F958 File Offset: 0x0000DB58
	private void OGJJDKENBNC()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x000FC4B4 File Offset: 0x000FA6B4
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 15f)
			{
				this.HBJJOCHGOPH = 160f;
			}
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.Fade);
			this.KLKILLCHJHO().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", this.Intensity);
			this.MJJIEHANFJA().SetFloat("CompletedLevel", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("maps.", this.Speed);
			this.FKEOGPDLBDD().SetFloat("Edited event", this.Size);
			this.IIJMIPBMMBF().SetFloat("UseScanLineSize", this.Distortion);
			this.DIOAAHJDMLK().SetFloat("1.87", this.StormFlashOnOff);
			this.HKIMAANBGMJ().SetVector("Failed to Destroy objects of playerId: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 726f, 1871f));
			this.KOHGPKOFEJO().SetTexture("Line", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x000FC60C File Offset: 0x000FA80C
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1895f)
			{
				this.HBJJOCHGOPH = 1119f;
			}
			this.LPDOGGFOBDH().SetFloat("AudioSampler", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("float,2", this.Fade);
			this.LPDOGGFOBDH().SetFloat("CameraMovementSlider", this.Intensity);
			this.NJDIODJNGGA().SetFloat("_Value2", this.DirectionX);
			this.NFKFAAHHLLM().SetFloat("threshold", this.Speed);
			this.DIOAAHJDMLK().SetFloat("UsernameText", this.Size);
			this.JIBOKBCPDLC().SetFloat("inventory.selected.", this.Distortion);
			this.EOCCJGIGEGJ().SetFloat("ItemNameText", this.StormFlashOnOff);
			this.GJHLADDCMFF().SetVector("LevelConfigButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1794f, 86f));
			this.LPDOGGFOBDH().SetTexture("GlassAberration", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x0000F991 File Offset: 0x0000DB91
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("player.goldwatermelon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x0000420A File Offset: 0x0000240A
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x0000F9CA File Offset: 0x0000DBCA
	private void IKDNLHLBHID()
	{
		this.FPHEBLMINDA = (Resources.Load("DPADHOR") as Texture2D);
		this.SCShader = Shader.Find(" connected: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x0000F6BC File Offset: 0x0000D8BC
	private Material EBJKJPAIAAM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x0000FA03 File Offset: 0x0000DC03
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("Right Stick Click") as Texture2D);
		this.SCShader = Shader.Find("LivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x0000FA3C File Offset: 0x0000DC3C
	private void NLDKIPEMILC()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.hitvariation") as Texture2D);
		this.SCShader = Shader.Find("Have you fully accept the terms?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x0000420A File Offset: 0x0000240A
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x0000FA75 File Offset: 0x0000DC75
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x0000420A File Offset: 0x0000240A
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x0000FAAC File Offset: 0x0000DCAC
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x0000420A File Offset: 0x0000240A
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x0000FAE3 File Offset: 0x0000DCE3
	private void FJNCHGLIEMA()
	{
		this.FPHEBLMINDA = (Resources.Load("Cant ask anyone else for PickupItem spawn times.") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x000FC764 File Offset: 0x000FA964
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 993f)
			{
				this.HBJJOCHGOPH = 1793f;
			}
			this.HKIMAANBGMJ().SetFloat("float,0", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("JoinButton", this.Fade);
			this.KEMAALEODNH().SetFloat(" not exist", this.Intensity);
			this.DIOAAHJDMLK().SetFloat("_Offsets", this.DirectionX);
			this.OCHJIMJNEMO().SetFloat("NEW_ACHIEVEMENT_1_", this.Speed);
			this.DIOAAHJDMLK().SetFloat("_DotSize", this.Size);
			this.KOHGPKOFEJO().SetFloat("Registered PhotonView: ", this.Distortion);
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this.StormFlashOnOff);
			this.KLKILLCHJHO().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 829f, 1708f));
			this.NFKFAAHHLLM().SetTexture("Error0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x0000420A File Offset: 0x0000240A
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x000FC928 File Offset: 0x000FAB28
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1363f)
			{
				this.HBJJOCHGOPH = 21f;
			}
			this.MJJIEHANFJA().SetFloat("_BlurredColor", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_MainTex2", this.Fade);
			this.BLMPMOIDGMG().SetFloat("settings.selectormapsperpage", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.DirectionX);
			this.BLMPMOIDGMG().SetFloat("_RampTex", this.Speed);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Edge_BlackLine", this.Size);
			this.IKBJACCLPCL().SetFloat("_Value5", this.Distortion);
			this.MJJIEHANFJA().SetFloat("id", this.StormFlashOnOff);
			this.KGOLDDBHIFN().SetVector("GlassDistortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 19f, 1179f));
			this.EBJKJPAIAAM().SetTexture("/", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x0000420A File Offset: 0x0000240A
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x0000420A File Offset: 0x0000240A
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x0000FB1C File Offset: 0x0000DD1C
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load("cancel") as Texture2D);
		this.SCShader = Shader.Find("OnEvent: {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x0000FB55 File Offset: 0x0000DD55
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("BadgeText") as Texture2D);
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x0000FB8E File Offset: 0x0000DD8E
	private void NNFMIAFHMJM()
	{
		this.FPHEBLMINDA = (Resources.Load("&search=") as Texture2D);
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x0000FBC7 File Offset: 0x0000DDC7
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x0000FBFE File Offset: 0x0000DDFE
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("-") as Texture2D);
		this.SCShader = Shader.Find("sounds/no_hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x0000FC37 File Offset: 0x0000DE37
	private void EDPDMBFLHLP()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x0000FC70 File Offset: 0x0000DE70
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x000FCA80 File Offset: 0x000FAC80
	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1153f)
			{
				this.HBJJOCHGOPH = 1602f;
			}
			this.KGOLDDBHIFN().SetFloat("HandsCountSlider", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("[MapEditor] Created new map: ", this.Fade);
			this.KEMAALEODNH().SetFloat(").png", this.Intensity);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack_Glasses_On7", this.DirectionX);
			this.NFKFAAHHLLM().SetFloat("PossibleMapPointsText", this.Speed);
			this.IKBJACCLPCL().SetFloat("_ScreenResolution", this.Size);
			this.JIBOKBCPDLC().SetFloat(" has been disabled as it's not supported on the current platform.", this.Distortion);
			this.KOHGPKOFEJO().SetFloat("_Curve", this.StormFlashOnOff);
			this.PDEAHJPOMEF().SetVector("steamid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 601f, 765f));
			this.KOHGPKOFEJO().SetTexture("CameraFilterPack/EXTRA_Rotation", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x0000FCA7 File Offset: 0x0000DEA7
	private void GNJDKAECPKA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Bullet_6") as Texture2D);
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x000FCBD8 File Offset: 0x000FADD8
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1655f)
			{
				this.HBJJOCHGOPH = 655f;
			}
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_Value", this.Fade);
			this.BLMPMOIDGMG().SetFloat("UseScanLine", this.Intensity);
			this.NJDIODJNGGA().SetFloat("_Size", this.DirectionX);
			this.MJJIEHANFJA().SetFloat("_TimeX", this.Speed);
			this.KLKILLCHJHO().SetFloat("_NoOuterClip", this.Size);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Drawing_Toon", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("Default UI Material", this.StormFlashOnOff);
			this.ECCPAOBFDKP().SetVector("Oct", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 445f, 238f));
			this.KHCLIAMBBNC().SetTexture("22x1", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x0000EF5A File Offset: 0x0000D15A
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x0000420A File Offset: 0x0000240A
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000206 RID: 518
	public Shader SCShader;

	// Token: 0x04000207 RID: 519
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000208 RID: 520
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000209 RID: 521
	private Material BJFKDHHMLJH;

	// Token: 0x0400020A RID: 522
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400020B RID: 523
	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	// Token: 0x0400020C RID: 524
	[Range(-0.25f, 0.25f)]
	public float DirectionX = 0.12f;

	// Token: 0x0400020D RID: 525
	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	// Token: 0x0400020E RID: 526
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x0400020F RID: 527
	[Range(0f, 0.5f)]
	public float Distortion = 0.05f;

	// Token: 0x04000210 RID: 528
	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	// Token: 0x04000211 RID: 529
	private Texture2D FPHEBLMINDA;
}
