/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000039 RID: 57
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Blend")]
public class CameraFilterPack_Blend2Camera_Blend : MonoBehaviour
{
	// Token: 0x06000F1A RID: 3866 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void DLMPALHKMON()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00102814 File Offset: 0x00100A14
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -80);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00010DD1 File Offset: 0x0000EFD1
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void HGDDCINLDAD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00010E08 File Offset: 0x0000F008
	private void ELANJOHIJME()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void ODGMCJILIHF()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00102880 File Offset: 0x00100A80
	private void LIBGAKMKHJJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00010E43 File Offset: 0x0000F043
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x001028EC File Offset: 0x00100AEC
	private void BMOFEBKGLFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -64);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x0000420A File Offset: 0x0000240A
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void KMOCDAOKGLI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x0000420A File Offset: 0x0000240A
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00102958 File Offset: 0x00100B58
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1451f)
			{
				this.HBJJOCHGOPH = 1526f;
			}
			this.DONENAMLFLF().SetTexture("_EmissionColor", this.JDMCFBKJHDD);
			this.NDMPCDHADMJ().SetFloat("_Green_R", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_TileMaxLoop", this.BlendFX);
			this.JLHLHKPHDFO().SetVector("_BlurRadius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1773f, 8f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00102A2C File Offset: 0x00100C2C
	private void HAIAHJPCPAG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 87);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00102A98 File Offset: 0x00100C98
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00010EA3 File Offset: 0x0000F0A3
	private void PLNLNCDPPGG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00010EDE File Offset: 0x0000F0DE
	private void LIFBFDKFMMH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00010F19 File Offset: 0x0000F119
	private void NLGDPIBFHMK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void DHENLPJJOEN()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00102B6C File Offset: 0x00100D6C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1322f)
			{
				this.HBJJOCHGOPH = 992f;
			}
			this.OLHDPICFBOF().SetTexture("_ContrastGainGamma", this.JDMCFBKJHDD);
			this.DBOLLHHMKKN().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("\nCreated by Oxy949", this.BlendFX);
			this.OIIDAKBILMI().SetVector("[PlayerBase] SetSpeed error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 675f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00010F54 File Offset: 0x0000F154
	private void BFKANNFLAKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -102);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x0000420A File Offset: 0x0000240A
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00102C40 File Offset: 0x00100E40
	private void JHANGPCOCIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x0000420A File Offset: 0x0000240A
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x0000420A File Offset: 0x0000240A
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00010F8F File Offset: 0x0000F18F
	private void HJDPEBAPBPN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00010FCA File Offset: 0x0000F1CA
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00011005 File Offset: 0x0000F205
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0000420A File Offset: 0x0000240A
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x0001103C File Offset: 0x0000F23C
	private void GHMDNIFLGOB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00011077 File Offset: 0x0000F277
	private void HPGKMAIPDEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 44);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x000110B2 File Offset: 0x0000F2B2
	private void LHGFCBDACBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void EKCDEFDELMP()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00102CAC File Offset: 0x00100EAC
	private void JDKHBGDEONK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x000110ED File Offset: 0x0000F2ED
	private void KFCCKOBOLAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x0000420A File Offset: 0x0000240A
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void OFPPIKHNJOD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00102D18 File Offset: 0x00100F18
	private void DBLILJGKGHJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00011128 File Offset: 0x0000F328
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00102D84 File Offset: 0x00100F84
	private void JECMJNFGBGC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00102DF0 File Offset: 0x00100FF0
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 187f)
			{
				this.HBJJOCHGOPH = 62f;
			}
			this.JLHLHKPHDFO().SetTexture(" has no method \"", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("1", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.BlendFX);
			this.OLHDPICFBOF().SetVector("Hex value #RRGGBB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1709f, 579f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00102EC4 File Offset: 0x001010C4
	private void KNBJBNDGCIJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void IMGGCJICLHK()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00102F30 File Offset: 0x00101130
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 664f)
			{
				this.HBJJOCHGOPH = 1487f;
			}
			this.JLHLHKPHDFO().SetTexture("CameraFilterPack_AAA_Blood_Hit1", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_Value2", this.BlendFX);
			this.OLHDPICFBOF().SetVector("OnMastedChangeScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 208f, 378f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00103004 File Offset: 0x00101204
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1449f)
			{
				this.HBJJOCHGOPH = 1775f;
			}
			this.NDMPCDHADMJ().SetTexture("GameScene", this.JDMCFBKJHDD);
			this.DONENAMLFLF().SetFloat("note.6", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_TimeX", this.BlendFX);
			this.JFDGLLEOPGB().SetVector("Joystick1Button2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1579f, 813f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0001115F File Offset: 0x0000F35F
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

	// Token: 0x06000F4B RID: 3915 RVA: 0x001030D8 File Offset: 0x001012D8
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 434f)
			{
				this.HBJJOCHGOPH = 1610f;
			}
			this.OCHJIMJNEMO().SetTexture("[PlayerController] ", this.JDMCFBKJHDD);
			this.IONHGBPGCHK().SetFloat("ArcsDestroyDelaySlider", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("_Value4", this.BlendFX);
			this.IONHGBPGCHK().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1136f, 1981f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void PAEGLMEOKHP()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00011196 File Offset: 0x0000F396
	private void CCKABCDEOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x000111D1 File Offset: 0x0000F3D1
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void EJJEDJIOFAB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00011208 File Offset: 0x0000F408
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x001031AC File Offset: 0x001013AC
	private void AEDDNDHCLNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 82);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x0001123F File Offset: 0x0000F43F
	private void MDMDGKHDPKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x0001127A File Offset: 0x0000F47A
	private void GHICDLBKEJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 39);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x000112B5 File Offset: 0x0000F4B5
	private void DPGHJILBPCE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00103218 File Offset: 0x00101418
	private void IDJKNBDKHBD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x000112F0 File Offset: 0x0000F4F0
	private void BILILBEBLFL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00103284 File Offset: 0x00101484
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1468f)
			{
				this.HBJJOCHGOPH = 231f;
			}
			this.NBPKMLMCHFN.SetTexture("Map id for", this.JDMCFBKJHDD);
			this.JFDGLLEOPGB().SetFloat("_Rand", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("CameraFilterPack_Paper3", this.BlendFX);
			this.OLHDPICFBOF().SetVector("PLEASE WAIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 65f, 296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x0001132B File Offset: 0x0000F52B
	private void KPLKDJFKPDI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00011366 File Offset: 0x0000F566
	private void KHDANGFKIGL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 68);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00103358 File Offset: 0x00101558
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1753f)
			{
				this.HBJJOCHGOPH = 1196f;
			}
			this.OIIDAKBILMI().SetTexture("note.6", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("StartButton", this.BlendFX);
			this.OCHJIMJNEMO().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1984f, 143f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x000110B2 File Offset: 0x0000F2B2
	private void GJPONJKJICG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x000113A1 File Offset: 0x0000F5A1
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x000113D8 File Offset: 0x0000F5D8
	private void MIAMLFNACAI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -17);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x0010342C File Offset: 0x0010162C
	private void HMPGIFBJFIK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -10);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00011413 File Offset: 0x0000F613
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00103498 File Offset: 0x00101698
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 906f)
			{
				this.HBJJOCHGOPH = 1672f;
			}
			this.JFDGLLEOPGB().SetTexture("_LensDirtIntensity", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("MenuPlayButton", this.BlendFX);
			this.OLHDPICFBOF().SetVector("EventSystem", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1987f, 1159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x0010356C File Offset: 0x0010176C
	private void CNGAJDBOCLJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -21);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void EAHCLIEEJOG()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x001035D8 File Offset: 0x001017D8
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 848f)
			{
				this.HBJJOCHGOPH = 872f;
			}
			this.IONHGBPGCHK().SetTexture("_Curve", this.JDMCFBKJHDD);
			this.JLHLHKPHDFO().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.BlendFX);
			this.OCHJIMJNEMO().SetVector("AddEnvironmentObject", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 483f, 1941f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x0001144A File Offset: 0x0000F64A
	private void JDCJBNHAFCI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x001036AC File Offset: 0x001018AC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 978f)
			{
				this.HBJJOCHGOPH = 778f;
			}
			this.NDMPCDHADMJ().SetTexture("http", this.JDMCFBKJHDD);
			this.JLHLHKPHDFO().SetFloat("Jit ", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("</b>", this.BlendFX);
			this.NBPKMLMCHFN.SetVector("PLEASE WAIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 234f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void PHJLHCMCCKE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00011485 File Offset: 0x0000F685
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00103780 File Offset: 0x00101980
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x000114BC File Offset: 0x0000F6BC
	private void HGPLPMCJNLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x000114F7 File Offset: 0x0000F6F7
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00011532 File Offset: 0x0000F732
	private void FNGDOKOAKLA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x0000420A File Offset: 0x0000240A
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x001037EC File Offset: 0x001019EC
	private void DKGBFNCOAEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void OCCGJMPAJIK()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x0001156D File Offset: 0x0000F76D
	private void KOCPGJCINKD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00103858 File Offset: 0x00101A58
	private void FLKEJJEGCFA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 37);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x000115A8 File Offset: 0x0000F7A8
	private void CAOLLBOBPFF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void CNDACAHCCOI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x001038C4 File Offset: 0x00101AC4
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 24f)
			{
				this.HBJJOCHGOPH = 964f;
			}
			this.DBOLLHHMKKN().SetTexture("_TimeX", this.JDMCFBKJHDD);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Color_Chromatic_Plus", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_FixDistance", this.BlendFX);
			this.DBOLLHHMKKN().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1008f, 1394f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x000114F7 File Offset: 0x0000F6F7
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00103998 File Offset: 0x00101B98
	private void COIJKMKIEAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x00103A04 File Offset: 0x00101C04
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1992f)
			{
				this.HBJJOCHGOPH = 107f;
			}
			this.DONENAMLFLF().SetTexture(" ", this.JDMCFBKJHDD);
			this.DBOLLHHMKKN().SetFloat("LoadingStatusText", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_DistortionSize", this.BlendFX);
			this.IONHGBPGCHK().SetVector("[Right]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 207f, 1382f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x000115E3 File Offset: 0x0000F7E3
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00010D97 File Offset: 0x0000EF97
	private void IFIHBNJKEKD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x0000420A File Offset: 0x0000240A
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0000420A File Offset: 0x0000240A
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x0001161A File Offset: 0x0000F81A
	private void OLAGABIMGDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 35);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00103AD8 File Offset: 0x00101CD8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1047f)
			{
				this.HBJJOCHGOPH = 84f;
			}
			this.NDMPCDHADMJ().SetTexture("CameraFilterPack/TV_LED", this.JDMCFBKJHDD);
			this.NBPKMLMCHFN.SetFloat("skin.", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("GraphicsQualitySlider", this.BlendFX);
			this.DBOLLHHMKKN().SetVector("Type of observed is unknown when receiving.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 769f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00103BAC File Offset: 0x00101DAC
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 978f)
			{
				this.HBJJOCHGOPH = 701f;
			}
			this.DBOLLHHMKKN().SetTexture("_TimeX", this.JDMCFBKJHDD);
			this.GJHPODJOBHL().SetFloat("yyyy-MM-dd HH:mm:ss", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("SetSunMinSize", this.BlendFX);
			this.JLHLHKPHDFO().SetVector("Editor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 165f, 1182f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400023D RID: 573
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Blend";

	// Token: 0x0400023E RID: 574
	public Shader SCShader;

	// Token: 0x0400023F RID: 575
	public Camera Camera2;

	// Token: 0x04000240 RID: 576
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000241 RID: 577
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000242 RID: 578
	private Material BJFKDHHMLJH;

	// Token: 0x04000243 RID: 579
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000244 RID: 580
	private RenderTexture JDMCFBKJHDD;
}
