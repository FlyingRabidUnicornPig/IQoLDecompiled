/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Blood On Screen")]
public class CameraFilterPack_AAA_BloodOnScreen : MonoBehaviour
{
	// Token: 0x06000B77 RID: 2935 RVA: 0x0000C485 File Offset: 0x0000A685
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("LoadMapCanvas") as Texture2D);
		this.SCShader = Shader.Find("Hidden/DepthOfField/MedianFilter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x0000C4BE File Offset: 0x0000A6BE
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x0000420A File Offset: 0x0000240A
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x0000C4DB File Offset: 0x0000A6DB
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x0000C512 File Offset: 0x0000A712
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x0000C54B File Offset: 0x0000A74B
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x0000C582 File Offset: 0x0000A782
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x0000C4BE File Offset: 0x0000A6BE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x000F2358 File Offset: 0x000F0558
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1792f)
			{
				this.HBJJOCHGOPH = 474f;
			}
			this.DBOLLHHMKKN().SetFloat("event", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("Mar", Mathf.Clamp(this.Blood_On_Screen, 1000f, 1844f));
			this.NBPKMLMCHFN.SetFloat("Connection error: ", Mathf.Clamp(this.Blood_Intensify, 1796f, 201f));
			this.NBPKMLMCHFN.SetFloat("_ThirdTex", Mathf.Clamp(this.Blood_Darkness, 4f, 1773f));
			this.DBOLLHHMKKN().SetFloat("note.2", Mathf.Clamp(this.Blood_Fade, 114f, 1077f));
			this.NBPKMLMCHFN.SetFloat("SetPosition", Mathf.Clamp(this.Blood_Distortion_Speed, 1580f, 1245f));
			this.NBPKMLMCHFN.SetColor("LevelEditor/CustomEventEditor-", this.Blood_Color);
			this.ADBKPGFMNKO().SetTexture("_DotSize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x0000C5BB File Offset: 0x0000A7BB
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_BloodOnScreen1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_BloodOnScreen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0000C62B File Offset: 0x0000A82B
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

	// Token: 0x06000B84 RID: 2948 RVA: 0x0000C4BE File Offset: 0x0000A6BE
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x0000C662 File Offset: 0x0000A862
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("player.licenceaccepted") as Texture2D);
		this.SCShader = Shader.Find("_Factor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x0000C69B File Offset: 0x0000A89B
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x0000420A File Offset: 0x0000240A
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x0000C4BE File Offset: 0x0000A6BE
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x0000C6D2 File Offset: 0x0000A8D2
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load(" Remote called.") as Texture2D);
		this.SCShader = Shader.Find("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x0000C4BE File Offset: 0x0000A6BE
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x0000C70B File Offset: 0x0000A90B
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x000F2518 File Offset: 0x000F0718
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
			this.NBPKMLMCHFN.SetFloat("_Value", Mathf.Clamp(this.Blood_On_Screen, 0.02f, 1.6f));
			this.NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(this.Blood_Intensify, 0f, 2f));
			this.NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(this.Blood_Darkness, 0f, 2f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Blood_Fade, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(this.Blood_Distortion_Speed, 0f, 2f));
			this.NBPKMLMCHFN.SetColor("_Color2", this.Blood_Color);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0000C4BE File Offset: 0x0000A6BE
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001BE RID: 446
	public Shader SCShader;

	// Token: 0x040001BF RID: 447
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001C0 RID: 448
	[Range(0.02f, 1.6f)]
	public float Blood_On_Screen = 1f;

	// Token: 0x040001C1 RID: 449
	public Color Blood_Color = Color.red;

	// Token: 0x040001C2 RID: 450
	[Range(0f, 2f)]
	public float Blood_Intensify = 0.7f;

	// Token: 0x040001C3 RID: 451
	[Range(0f, 2f)]
	public float Blood_Darkness = 0.5f;

	// Token: 0x040001C4 RID: 452
	[Range(0f, 1f)]
	public float Blood_Distortion_Speed = 0.25f;

	// Token: 0x040001C5 RID: 453
	[Range(0f, 1f)]
	public float Blood_Fade = 1f;

	// Token: 0x040001C6 RID: 454
	private Material BJFKDHHMLJH;

	// Token: 0x040001C7 RID: 455
	private Texture2D FPHEBLMINDA;
}
