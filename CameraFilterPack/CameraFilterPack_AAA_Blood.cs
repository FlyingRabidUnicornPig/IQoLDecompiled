/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200002A RID: 42
[AddComponentMenu("Camera Filter Pack/AAA/Blood")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood : MonoBehaviour
{
	// Token: 0x06000AF6 RID: 2806 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x000EF9A8 File Offset: 0x000EDBA8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 433f)
			{
				this.HBJJOCHGOPH = 1285f;
			}
			this.IONHGBPGCHK().SetFloat("_Value6", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_LighterColor", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("true", this.Blood1);
			this.HNICHJCGJOC().SetFloat("_Amount", this.Blood2);
			this.FHFLKLMFHOI().SetFloat("Failed to Destroy objects of playerId: ", this.Blood3);
			this.IONHGBPGCHK().SetFloat("InputField", this.Blood4);
			this.FHFLKLMFHOI().SetTexture("float,0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x000EFAA8 File Offset: 0x000EDCA8
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1131f)
			{
				this.HBJJOCHGOPH = 395f;
			}
			this.HCGJCMDJPGD().SetFloat("_Vignette", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("<b>#", this.LightReflect);
			this.JFDGLLEOPGB().SetFloat("maps.", this.Blood1);
			this.NBPKMLMCHFN.SetFloat("_DiffuseColor", this.Blood2);
			this.LNLKMDPHDCC().SetFloat("_Fade", this.Blood3);
			this.JFDGLLEOPGB().SetFloat("SetScale", this.Blood4);
			this.HCGJCMDJPGD().SetTexture("DPADHOR", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x0000BA9E File Offset: 0x00009C9E
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("\" gets executed locally only, if at all.") as Texture2D);
		this.SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0000BAD7 File Offset: 0x00009CD7
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("Instrumental");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x000EFBA8 File Offset: 0x000EDDA8
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 964f)
			{
				this.HBJJOCHGOPH = 1487f;
			}
			this.JFDGLLEOPGB().SetFloat("Joystick1Button9", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("1", this.LightReflect);
			this.FHFLKLMFHOI().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", this.Blood1);
			this.FHFLKLMFHOI().SetFloat("duration", this.Blood2);
			this.JFDGLLEOPGB().SetFloat("1177138211", this.Blood3);
			this.HNICHJCGJOC().SetFloat("_Intensity", this.Blood4);
			this.HNICHJCGJOC().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x0000BB10 File Offset: 0x00009D10
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0000420A File Offset: 0x0000240A
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x000EFCA8 File Offset: 0x000EDEA8
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1066f)
			{
				this.HBJJOCHGOPH = 1892f;
			}
			this.HNICHJCGJOC().SetFloat("_Glitch", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("settings.fps", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("AccuracyScoreText", this.Blood1);
			this.FHFLKLMFHOI().SetFloat("HandsCountSlider", this.Blood2);
			this.HCGJCMDJPGD().SetFloat("maps.", this.Blood3);
			this.LNLKMDPHDCC().SetFloat("_Value4", this.Blood4);
			this.NBPKMLMCHFN.SetTexture("_LightIntensity", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x000EFDA8 File Offset: 0x000EDFA8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Blood1);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Blood2);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Blood3);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Blood4);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x000EFEA8 File Offset: 0x000EE0A8
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1372f)
			{
				this.HBJJOCHGOPH = 1857f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("SSAARenderTargetCamera", this.LightReflect);
			this.IONHGBPGCHK().SetFloat("steamid", this.Blood1);
			this.FHFLKLMFHOI().SetFloat("[PlayerController] ", this.Blood2);
			this.NDMPCDHADMJ().SetFloat("_Heigh", this.Blood3);
			this.NBPKMLMCHFN.SetFloat("Remove Environment Object", this.Blood4);
			this.NDMPCDHADMJ().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0000BB47 File Offset: 0x00009D47
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0000BB7E File Offset: 0x00009D7E
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("[GameScene] Checkpoints count: ") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x000EFFA8 File Offset: 0x000EE1A8
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1743f)
			{
				this.HBJJOCHGOPH = 562f;
			}
			this.NDMPCDHADMJ().SetFloat("win", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("/music", this.LightReflect);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Pixelisation_OilPaint", this.Blood1);
			this.NDMPCDHADMJ().SetFloat("{0}", this.Blood2);
			this.NBPKMLMCHFN.SetFloat(": ", this.Blood3);
			this.FHFLKLMFHOI().SetFloat(" ", this.Blood4);
			this.NBPKMLMCHFN.SetTexture("musicVolume", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x0000BBB7 File Offset: 0x00009DB7
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("CurrentTimeLabel") as Texture2D);
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x0000420A File Offset: 0x0000240A
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x0000BBF0 File Offset: 0x00009DF0
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("L2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0000420A File Offset: 0x0000240A
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0000420A File Offset: 0x0000240A
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x0000420A File Offset: 0x0000240A
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x0000BC29 File Offset: 0x00009E29
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_Blood1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0000BC62 File Offset: 0x00009E62
	private void MMOKKAPFGAK()
	{
		this.FPHEBLMINDA = (Resources.Load(".lastCheckpoint.bgcolor") as Texture2D);
		this.SCShader = Shader.Find("L1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x0000BCC4 File Offset: 0x00009EC4
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("skin.") as Texture2D);
		this.SCShader = Shader.Find("Joystick1Button11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x0000BCFD File Offset: 0x00009EFD
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x0000BD34 File Offset: 0x00009F34
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x000F00A8 File Offset: 0x000EE2A8
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1979f)
			{
				this.HBJJOCHGOPH = 148f;
			}
			this.IONHGBPGCHK().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("/", this.LightReflect);
			this.HCGJCMDJPGD().SetFloat("ShowTitle", this.Blood1);
			this.HNICHJCGJOC().SetFloat("Set particles count per one beat", this.Blood2);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Blood3);
			this.NDMPCDHADMJ().SetFloat("_ScreenResolution", this.Blood4);
			this.HCGJCMDJPGD().SetTexture("Set Sun MaxSize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x0000BD6B File Offset: 0x00009F6B
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0000BDA2 File Offset: 0x00009FA2
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0000BDD9 File Offset: 0x00009FD9
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x0000BE10 File Offset: 0x0000A010
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("cameramovements:") as Texture2D);
		this.SCShader = Shader.Find("RemoveHighlight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x0000420A File Offset: 0x0000240A
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x000F01A8 File Offset: 0x000EE3A8
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1427f)
			{
				this.HBJJOCHGOPH = 209f;
			}
			this.IONHGBPGCHK().SetFloat("settings.hitvariation", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("Failed to 'network-remove' GameObject because has no PhotonView components: ", this.LightReflect);
			this.HNICHJCGJOC().SetFloat("_MainTex2", this.Blood1);
			this.JFDGLLEOPGB().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", this.Blood2);
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/Colors_Brightness", this.Blood3);
			this.NDMPCDHADMJ().SetFloat("finished", this.Blood4);
			this.LNLKMDPHDCC().SetTexture("_NeighborMaxTex", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0000BE49 File Offset: 0x0000A049
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("Horizontal") as Texture2D);
		this.SCShader = Shader.Find(",viewkeys");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0000BE82 File Offset: 0x0000A082
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("1 Kb") as Texture2D);
		this.SCShader = Shader.Find("_Saturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x000F02A8 File Offset: 0x000EE4A8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 927f)
			{
				this.HBJJOCHGOPH = 1099f;
			}
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/Vision_AuraDistortion", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("OpSetPropertiesOfActor()", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("SetParticlesEmission", this.Blood1);
			this.HNICHJCGJOC().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", this.Blood2);
			this.FHFLKLMFHOI().SetFloat("PossibleMapMaxScoreText", this.Blood3);
			this.NDMPCDHADMJ().SetFloat("RB", this.Blood4);
			this.LNLKMDPHDCC().SetTexture(".highscore", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x000F03A8 File Offset: 0x000EE5A8
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1126f)
			{
				this.HBJJOCHGOPH = 1604f;
			}
			this.HNICHJCGJOC().SetFloat("OK", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat(".lastCheckpoint.comboScore", this.LightReflect);
			this.LNLKMDPHDCC().SetFloat("_Value3", this.Blood1);
			this.HCGJCMDJPGD().SetFloat("UseScanLineSize", this.Blood2);
			this.JFDGLLEOPGB().SetFloat("_Visualize", this.Blood3);
			this.HCGJCMDJPGD().SetFloat("_Value", this.Blood4);
			this.HNICHJCGJOC().SetTexture("LeaderboardsButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0000420A File Offset: 0x0000240A
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0000BEBB File Offset: 0x0000A0BB
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

	// Token: 0x06000B2E RID: 2862 RVA: 0x0000BEF2 File Offset: 0x0000A0F2
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("Drop_Far") as Texture2D);
		this.SCShader = Shader.Find("shader.future");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x000F04A8 File Offset: 0x000EE6A8
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1283f)
			{
				this.HBJJOCHGOPH = 782f;
			}
			this.IONHGBPGCHK().SetFloat("0.00", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("Mid", this.LightReflect);
			this.HCGJCMDJPGD().SetFloat("EventSystem", this.Blood1);
			this.HCGJCMDJPGD().SetFloat("_TapMedium", this.Blood2);
			this.IONHGBPGCHK().SetFloat("ready", this.Blood3);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Drawing_Lines", this.Blood4);
			this.JFDGLLEOPGB().SetTexture("#rt", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x0000420A File Offset: 0x0000240A
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x000F05A8 File Offset: 0x000EE7A8
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 846f)
			{
				this.HBJJOCHGOPH = 137f;
			}
			this.LNLKMDPHDCC().SetFloat("Mouse", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("music", this.LightReflect);
			this.HCGJCMDJPGD().SetFloat("_NoiseScale", this.Blood1);
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/FX_superDot", this.Blood2);
			this.HNICHJCGJOC().SetFloat("itemdefid[0]", this.Blood3);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/3D_Mirror", this.Blood4);
			this.HCGJCMDJPGD().SetTexture("You need to have a Graphic control (such as an Image) for the list [", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x0000BA81 File Offset: 0x00009C81
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000193 RID: 403
	public Shader SCShader;

	// Token: 0x04000194 RID: 404
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000195 RID: 405
	[Range(0f, 128f)]
	public float Blood1;

	// Token: 0x04000196 RID: 406
	[Range(0f, 128f)]
	public float Blood2;

	// Token: 0x04000197 RID: 407
	[Range(0f, 128f)]
	public float Blood3;

	// Token: 0x04000198 RID: 408
	[Range(0f, 128f)]
	public float Blood4 = 1f;

	// Token: 0x04000199 RID: 409
	[Range(0f, 0.004f)]
	public float LightReflect = 0.002f;

	// Token: 0x0400019A RID: 410
	private Material BJFKDHHMLJH;

	// Token: 0x0400019B RID: 411
	private Texture2D FPHEBLMINDA;
}
