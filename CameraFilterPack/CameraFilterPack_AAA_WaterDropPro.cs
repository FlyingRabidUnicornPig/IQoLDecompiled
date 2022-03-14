/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000031 RID: 49
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/WaterDropPro")]
public class CameraFilterPack_AAA_WaterDropPro : MonoBehaviour
{
	// Token: 0x06000C6F RID: 3183 RVA: 0x0000D85F File Offset: 0x0000BA5F
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x0000420A File Offset: 0x0000240A
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x0000D87C File Offset: 0x0000BA7C
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab2Content") as Texture2D);
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x0000D85F File Offset: 0x0000BA5F
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x0000D8B5 File Offset: 0x0000BAB5
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_WaterDrop") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_WaterDropPro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x000F6454 File Offset: 0x000F4654
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_SizeX", this.SizeX);
			this.NBPKMLMCHFN.SetFloat("_SizeY", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x000F653C File Offset: 0x000F473C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1453f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.HNICHJCGJOC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_Params", this.Distortion);
			this.EFDEIFCDAFG().SetFloat("_Value", this.SizeX);
			this.EFDEIFCDAFG().SetFloat("_Value2", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("0.00", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_SampleCount", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x000F6624 File Offset: 0x000F4824
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 39f)
			{
				this.HBJJOCHGOPH = 982f;
			}
			this.NBPKMLMCHFN.SetFloat(": ", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_Offsets", this.Distortion);
			this.EFDEIFCDAFG().SetFloat(".a", this.SizeX);
			this.HNICHJCGJOC().SetFloat("[DiscordController] Shutdown", this.SizeY);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Speed);
			this.DNLMFEGJJDD().SetTexture("Scale environment object by the values", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x0000D8EE File Offset: 0x0000BAEE
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x000F670C File Offset: 0x000F490C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1395f)
			{
				this.HBJJOCHGOPH = 1092f;
			}
			this.HNICHJCGJOC().SetFloat("achievements.26.progress", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("id", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("Message duration multiplier. Recomended 1", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.SizeY);
			this.EFDEIFCDAFG().SetFloat("_Noise", this.Speed);
			this.HFBJAOFLCJI().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x0000D925 File Offset: 0x0000BB25
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x000F67F4 File Offset: 0x000F49F4
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 737f)
			{
				this.HBJJOCHGOPH = 1614f;
			}
			this.NBPKMLMCHFN.SetFloat("PublishButton", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("open", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("LT", this.SizeX);
			this.EFDEIFCDAFG().SetFloat("Testing, the group has toggled [", this.SizeY);
			this.HFBJAOFLCJI().SetFloat("NetworkCanvas", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x0000D95C File Offset: 0x0000BB5C
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x0000D85F File Offset: 0x0000BA5F
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0000D995 File Offset: 0x0000BB95
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

	// Token: 0x06000C7F RID: 3199 RVA: 0x0000D9CC File Offset: 0x0000BBCC
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x0000420A File Offset: 0x0000240A
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x0000DA42 File Offset: 0x0000BC42
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_LutTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x0000DA7B File Offset: 0x0000BC7B
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("_LightIntensity") as Texture2D);
		this.SCShader = Shader.Find("$ {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0000D85F File Offset: 0x0000BA5F
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x000F68DC File Offset: 0x000F4ADC
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1073f)
			{
				this.HBJJOCHGOPH = 1503f;
			}
			this.EFDEIFCDAFG().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Distortion);
			this.HNICHJCGJOC().SetFloat("/", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("NEW_ACHIEVEMENT_1_26", this.SizeY);
			this.DNLMFEGJJDD().SetFloat("IconImage", this.Speed);
			this.HNICHJCGJOC().SetTexture("HitInRelaxMusicToggle", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x000F69C4 File Offset: 0x000F4BC4
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1634f)
			{
				this.HBJJOCHGOPH = 567f;
			}
			this.EFDEIFCDAFG().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("#rt", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("RanksButton", this.SizeX);
			this.EFDEIFCDAFG().SetFloat("achievements.21.progress", this.SizeY);
			this.DNLMFEGJJDD().SetFloat("\\", this.Speed);
			this.NBPKMLMCHFN.SetTexture("z", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0000420A File Offset: 0x0000240A
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0000DAED File Offset: 0x0000BCED
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("_DX11NoiseTime") as Texture2D);
		this.SCShader = Shader.Find("SubBass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x0000DB26 File Offset: 0x0000BD26
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("#,0") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Edge_Edge_filter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x000F6AAC File Offset: 0x000F4CAC
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1234f)
			{
				this.HBJJOCHGOPH = 1196f;
			}
			this.EFDEIFCDAFG().SetFloat("id", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("OK", this.Distortion);
			this.EFDEIFCDAFG().SetFloat("/Segment-[Down]", this.SizeX);
			this.NBPKMLMCHFN.SetFloat("InfoText", this.SizeY);
			this.HNICHJCGJOC().SetFloat("settings.disablestoryboard", this.Speed);
			this.HNICHJCGJOC().SetTexture("InputField", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0000420A File Offset: 0x0000240A
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0000D85F File Offset: 0x0000BA5F
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x0000DB5F File Offset: 0x0000BD5F
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0000D85F File Offset: 0x0000BA5F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001E8 RID: 488
	public Shader SCShader;

	// Token: 0x040001E9 RID: 489
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001EA RID: 490
	[Range(8f, 64f)]
	public float Distortion = 8f;

	// Token: 0x040001EB RID: 491
	[Range(0f, 7f)]
	public float SizeX = 1f;

	// Token: 0x040001EC RID: 492
	[Range(0f, 7f)]
	public float SizeY = 0.5f;

	// Token: 0x040001ED RID: 493
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x040001EE RID: 494
	private Material BJFKDHHMLJH;

	// Token: 0x040001EF RID: 495
	private Texture2D FPHEBLMINDA;
}
