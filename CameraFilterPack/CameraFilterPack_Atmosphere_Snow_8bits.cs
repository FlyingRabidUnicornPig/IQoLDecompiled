/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000038 RID: 56
[AddComponentMenu("Camera Filter Pack/Pixel/Snow_8bits")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Snow_8bits : MonoBehaviour
{
	// Token: 0x06000ED4 RID: 3796 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00101D14 File Offset: 0x000FFF14
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 911f)
			{
				this.HBJJOCHGOPH = 1319f;
			}
			this.DBOLLHHMKKN().SetFloat("_ReflectionTexture2", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("UI Extensions/UIScreen", this.Threshold);
			this.OIMMPLPBLBK().SetFloat(" ", this.Size);
			this.GCDFNHMJMIP().SetFloat("_Value", this.DirectionX);
			this.EOCCJGIGEGJ().SetFloat("Menu", this.Fade);
			this.FLOHGDECHHH().SetVector("UndoButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 637f, 918f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00010802 File Offset: 0x0000EA02
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00010802 File Offset: 0x0000EA02
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00101E14 File Offset: 0x00100014
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 230f)
			{
				this.HBJJOCHGOPH = 6f;
			}
			this.MCDGIILBNIF().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("settings.hitvariation", this.Threshold);
			this.KGOLDDBHIFN().SetFloat("float,10", this.Size);
			this.NFMGLIKNOOC().SetFloat("_Visualize", this.DirectionX);
			this.EOCCJGIGEGJ().SetFloat("menu.selectedlevelid", this.Fade);
			this.NBPKMLMCHFN.SetVector(" not found", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 927f, 1534f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x0001081F File Offset: 0x0000EA1F
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("player.bluebat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00101F14 File Offset: 0x00100114
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 449f)
			{
				this.HBJJOCHGOPH = 1702f;
			}
			this.GJHLADDCMFF().SetFloat("Uploading content", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("<size=24>", this.Threshold);
			this.DBOLLHHMKKN().SetFloat(":", this.Size);
			this.KGOLDDBHIFN().SetFloat("/Saved Games/", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("Tab2Content", this.Fade);
			this.MICHFGAOPKM().SetVector("[MapEditor] Loading events...", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 158f, 909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x0000420A File Offset: 0x0000240A
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00010843 File Offset: 0x0000EA43
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x0001087A File Offset: 0x0000EA7A
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x0001089E File Offset: 0x0000EA9E
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00102014 File Offset: 0x00100214
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00102114 File Offset: 0x00100314
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1521f)
			{
				this.HBJJOCHGOPH = 248f;
			}
			this.MCDGIILBNIF().SetFloat("GlassesColor", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("The other scroll rect doesnt support scrolling vertically", this.Threshold);
			this.NFMGLIKNOOC().SetFloat(") then the masterserver requests a disconnect!", this.Size);
			this.MCDGIILBNIF().SetFloat("_TimeX", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("In Map Editor", this.Fade);
			this.EOCCJGIGEGJ().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 205f, 32f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00010802 File Offset: 0x0000EA02
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x000108D5 File Offset: 0x0000EAD5
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x0001090C File Offset: 0x0000EB0C
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0000420A File Offset: 0x0000240A
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00010930 File Offset: 0x0000EB30
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00010954 File Offset: 0x0000EB54
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0001098B File Offset: 0x0000EB8B
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00010802 File Offset: 0x0000EA02
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00010802 File Offset: 0x0000EA02
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x000109C2 File Offset: 0x0000EBC2
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x000109F9 File Offset: 0x0000EBF9
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00010A30 File Offset: 0x0000EC30
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

	// Token: 0x06000EEF RID: 3823 RVA: 0x00010802 File Offset: 0x0000EA02
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00010802 File Offset: 0x0000EA02
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00102214 File Offset: 0x00100414
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 1653f;
			}
			this.MCDGIILBNIF().SetFloat("y", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_Glitch", this.Threshold);
			this.PDEAHJPOMEF().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.Size);
			this.NFMGLIKNOOC().SetFloat("[RanksSystem] Ranks updated. Next update: ", this.DirectionX);
			this.OKJOKHGJHGF().SetFloat("challenges.", this.Fade);
			this.OIMMPLPBLBK().SetVector("NameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1495f, 1818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00010802 File Offset: 0x0000EA02
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0000420A File Offset: 0x0000240A
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x00010802 File Offset: 0x0000EA02
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00010A67 File Offset: 0x0000EC67
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00102314 File Offset: 0x00100514
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 698f)
			{
				this.HBJJOCHGOPH = 433f;
			}
			this.MICHFGAOPKM().SetFloat("ControllerRightY", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("MenuScene", this.Threshold);
			this.OKJOKHGJHGF().SetFloat("_Level", this.Size);
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", this.DirectionX);
			this.MCDGIILBNIF().SetFloat("_Shadow", this.Fade);
			this.NBPKMLMCHFN.SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1062f, 1609f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00010802 File Offset: 0x0000EA02
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00010802 File Offset: 0x0000EA02
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00010802 File Offset: 0x0000EA02
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00010A9E File Offset: 0x0000EC9E
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("points:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00010AC2 File Offset: 0x0000ECC2
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00010AF9 File Offset: 0x0000ECF9
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x00102414 File Offset: 0x00100614
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 835f)
			{
				this.HBJJOCHGOPH = 1017f;
			}
			this.NBPKMLMCHFN.SetFloat("_Dist", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("0.00", this.Threshold);
			this.OIMMPLPBLBK().SetFloat("MultiplayerButton", this.Size);
			this.ADBKPGFMNKO().SetFloat("_BlurredColor", this.DirectionX);
			this.OIMMPLPBLBK().SetFloat("UseFinalGlassColor", this.Fade);
			this.KGOLDDBHIFN().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 692f, 529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00010B1D File Offset: 0x0000ED1D
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00010B54 File Offset: 0x0000ED54
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Snow_8bits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00010802 File Offset: 0x0000EA02
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00010B78 File Offset: 0x0000ED78
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0000420A File Offset: 0x0000240A
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00010B9C File Offset: 0x0000ED9C
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("GlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00102514 File Offset: 0x00100714
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1580f)
			{
				this.HBJJOCHGOPH = 428f;
			}
			this.MCDGIILBNIF().SetFloat("_HrDepthTex", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("sprite", this.Threshold);
			this.EOCCJGIGEGJ().SetFloat("/?player=", this.Size);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack_3D_Myst1", this.DirectionX);
			this.BFGNMFCNDBC().SetFloat("_Red_G", this.Fade);
			this.NBPKMLMCHFN.SetVector("LastHighScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1849f, 732f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00010BC0 File Offset: 0x0000EDC0
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00010BF7 File Offset: 0x0000EDF7
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00010802 File Offset: 0x0000EA02
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00010802 File Offset: 0x0000EA02
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00010C1B File Offset: 0x0000EE1B
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x00010802 File Offset: 0x0000EA02
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x00102614 File Offset: 0x00100814
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1561f)
			{
				this.HBJJOCHGOPH = 153f;
			}
			this.DBOLLHHMKKN().SetFloat("_Green_C", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("settings_bindings_", this.Threshold);
			this.PDEAHJPOMEF().SetFloat("tagElement", this.Size);
			this.NFMGLIKNOOC().SetFloat("Tab1Content", this.DirectionX);
			this.OKJOKHGJHGF().SetFloat("GlassDistortion", this.Fade);
			this.GJHLADDCMFF().SetVector("+", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1806f, 1564f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00010C52 File Offset: 0x0000EE52
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("RemoveEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00010CAA File Offset: 0x0000EEAA
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00010802 File Offset: 0x0000EA02
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00010CE1 File Offset: 0x0000EEE1
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00010D18 File Offset: 0x0000EF18
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00010D3C File Offset: 0x0000EF3C
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[NetworkManager] Connecting...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00102714 File Offset: 0x00100914
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1927f)
			{
				this.HBJJOCHGOPH = 798f;
			}
			this.MCDGIILBNIF().SetFloat("z", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat(" in-game items", this.Threshold);
			this.OIMMPLPBLBK().SetFloat("================================", this.Size);
			this.OIMMPLPBLBK().SetFloat("_Amount", this.DirectionX);
			this.GJHLADDCMFF().SetFloat(" BETA", this.Fade);
			this.DBOLLHHMKKN().SetVector("steamid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 388f, 1653f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00010D60 File Offset: 0x0000EF60
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000235 RID: 565
	public Shader SCShader;

	// Token: 0x04000236 RID: 566
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000237 RID: 567
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000238 RID: 568
	private Material BJFKDHHMLJH;

	// Token: 0x04000239 RID: 569
	[Range(0.9f, 2f)]
	public float Threshold = 1f;

	// Token: 0x0400023A RID: 570
	[Range(8f, 256f)]
	public float Size = 64f;

	// Token: 0x0400023B RID: 571
	[Range(-0.5f, 0.5f)]
	public float DirectionX;

	// Token: 0x0400023C RID: 572
	[Range(0f, 1f)]
	public float Fade = 1f;
}
