/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000033 RID: 51
[AddComponentMenu("Camera Filter Pack/Antialiasing/FXAA")]
[ExecuteInEditMode]
public class CameraFilterPack_Antialiasing_FXAA : MonoBehaviour
{
	// Token: 0x06000CDB RID: 3291 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x0000420A File Offset: 0x0000240A
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x0000E048 File Offset: 0x0000C248
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x000F7A94 File Offset: 0x000F5C94
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1358f)
			{
				this.HBJJOCHGOPH = 1504f;
			}
			this.NJDIODJNGGA().SetFloat("[", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0000E07F File Offset: 0x0000C27F
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x0000E0B6 File Offset: 0x0000C2B6
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("#forever");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x000F7B34 File Offset: 0x000F5D34
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1454f)
			{
				this.HBJJOCHGOPH = 983f;
			}
			this.BAGICADFBAB().SetFloat("CameraFilterPack/FX_Hexagon_Black", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetVector("GlassesColor2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x0000420A File Offset: 0x0000240A
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x0000E0DA File Offset: 0x0000C2DA
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x0000E111 File Offset: 0x0000C311
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find(". Calling ConnectToRegionMaster() is: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x0000E135 File Offset: 0x0000C335
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Antialiasing_FXAA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x0000E159 File Offset: 0x0000C359
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x000F7BD4 File Offset: 0x000F5DD4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 229f)
			{
				this.HBJJOCHGOPH = 404f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetVector("_BlurPass", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x0000420A File Offset: 0x0000240A
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x0000E190 File Offset: 0x0000C390
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("hidden");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x000F7C74 File Offset: 0x000F5E74
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1502f)
			{
				this.HBJJOCHGOPH = 732f;
			}
			this.NBPKMLMCHFN.SetFloat("#FFFFFFFF", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetVector("_HitPointTexture", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x000F7D14 File Offset: 0x000F5F14
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 643f)
			{
				this.HBJJOCHGOPH = 1291f;
			}
			this.JLHLHKPHDFO().SetFloat("float,1.5", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetVector("a minute ago", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x0000420A File Offset: 0x0000240A
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x0000420A File Offset: 0x0000240A
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x0000E1EB File Offset: 0x0000C3EB
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x0000E222 File Offset: 0x0000C422
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("attempted to spawn a GameObject from recycle bin (");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x000F7DB4 File Offset: 0x000F5FB4
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1268f)
			{
				this.HBJJOCHGOPH = 1181f;
			}
			this.ABHDNGIHBKE().SetFloat("speed", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetVector(" not found", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x000F7E54 File Offset: 0x000F6054
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 133f)
			{
				this.HBJJOCHGOPH = 244f;
			}
			this.OCHJIMJNEMO().SetFloat("0,2,true,0", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetVector("x", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x000F7EF4 File Offset: 0x000F60F4
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0000E246 File Offset: 0x0000C446
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

	// Token: 0x06000CFC RID: 3324 RVA: 0x000F7F94 File Offset: 0x000F6194
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1022f)
			{
				this.HBJJOCHGOPH = 375f;
			}
			this.HEINDEMCGIK().SetFloat("CameraFilterPack/Blend2Camera_Blend", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetVector("Preparing configuration", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x0000E27D File Offset: 0x0000C47D
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x0000E2D8 File Offset: 0x0000C4D8
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x0000420A File Offset: 0x0000240A
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x0000E30F File Offset: 0x0000C50F
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x000F8034 File Offset: 0x000F6234
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 285f)
			{
				this.HBJJOCHGOPH = 529f;
			}
			this.DEFBJOCJJKF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("USE_PREDICATION", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x0000E346 File Offset: 0x0000C546
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("Middle Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x000F80D4 File Offset: 0x000F62D4
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1757f)
			{
				this.HBJJOCHGOPH = 922f;
			}
			this.NBPKMLMCHFN.SetFloat("New level loaded. Removed ", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("G:", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x0000420A File Offset: 0x0000240A
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x000F8174 File Offset: 0x000F6374
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1387f)
			{
				this.HBJJOCHGOPH = 1176f;
			}
			this.OCHJIMJNEMO().SetFloat("(from resources)", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x000F8214 File Offset: 0x000F6414
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1833f)
			{
				this.HBJJOCHGOPH = 764f;
			}
			this.ABHDNGIHBKE().SetFloat("_Radius", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetVector(",", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x0000420A File Offset: 0x0000240A
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x0000420A File Offset: 0x0000240A
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0000E36A File Offset: 0x0000C56A
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x0000E3A1 File Offset: 0x0000C5A1
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("_Lift");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x000F82B4 File Offset: 0x000F64B4
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 368f)
			{
				this.HBJJOCHGOPH = 423f;
			}
			this.MMOODGIODPC().SetFloat("_Red_B", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetVector("Options", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0000420A File Offset: 0x0000240A
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x000F8354 File Offset: 0x000F6554
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 1001f;
			}
			this.HEINDEMCGIK().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("ReconnectAndRejoin() disabled the offline mode. No longer offline.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0000E3C5 File Offset: 0x0000C5C5
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find(").");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x0000E3E9 File Offset: 0x0000C5E9
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("GlassDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x0000420A File Offset: 0x0000240A
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x000F83F4 File Offset: 0x000F65F4
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 988f)
			{
				this.HBJJOCHGOPH = 762f;
			}
			this.HHIFMIPPMPF().SetFloat("{\"items\":", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x000F8494 File Offset: 0x000F6694
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1243f)
			{
				this.HBJJOCHGOPH = 334f;
			}
			this.BAGICADFBAB().SetFloat("_DistortionSize", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetVector("settings.gamemessagesduration", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x0000E40D File Offset: 0x0000C60D
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x0000420A File Offset: 0x0000240A
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x0000E444 File Offset: 0x0000C644
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x000F8534 File Offset: 0x000F6734
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1811f)
			{
				this.HBJJOCHGOPH = 50f;
			}
			this.OCHJIMJNEMO().SetFloat("All bindings reset to default values. PlayerPrefs have been removed for each key.", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetVector("float,2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x0000420A File Offset: 0x0000240A
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x000F85D4 File Offset: 0x000F67D4
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1016f)
			{
				this.HBJJOCHGOPH = 800f;
			}
			this.HHIFMIPPMPF().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetVector("Best region found in PlayerPrefs. Connecting to: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x000F8674 File Offset: 0x000F6874
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 829f;
			}
			this.DONENAMLFLF().SetFloat("_StretchWidth", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("_Bullet_5", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x0000420A File Offset: 0x0000240A
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x000F8714 File Offset: 0x000F6914
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 925f)
			{
				this.HBJJOCHGOPH = 77f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetVector("-1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x0000E47B File Offset: 0x0000C67B
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("achievements.21.progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x0000E49F File Offset: 0x0000C69F
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x0000420A File Offset: 0x0000240A
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0000420A File Offset: 0x0000240A
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x0000E4D6 File Offset: 0x0000C6D6
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("Drop_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x0000E1EB File Offset: 0x0000C3EB
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x0000E4FA File Offset: 0x0000C6FA
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x0000E531 File Offset: 0x0000C731
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("Uploading preview image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x0000420A File Offset: 0x0000240A
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x0000E555 File Offset: 0x0000C755
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x000F87B4 File Offset: 0x000F69B4
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1046f)
			{
				this.HBJJOCHGOPH = 1933f;
			}
			this.NBPKMLMCHFN.SetFloat("STICKRHOR", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetVector("Aug", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x0000E02B File Offset: 0x0000C22B
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x000F8854 File Offset: 0x000F6A54
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 329f)
			{
				this.HBJJOCHGOPH = 349f;
			}
			this.JLHLHKPHDFO().SetFloat("In Main Menu", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetVector("PopulateMapsList", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040001F8 RID: 504
	public Shader SCShader;

	// Token: 0x040001F9 RID: 505
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001FA RID: 506
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001FB RID: 507
	private Material BJFKDHHMLJH;
}
