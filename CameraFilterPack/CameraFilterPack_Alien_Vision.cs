/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000032 RID: 50
[AddComponentMenu("Camera Filter Pack/Alien/Vision")]
[ExecuteInEditMode]
public class CameraFilterPack_Alien_Vision : MonoBehaviour
{
	// Token: 0x06000C91 RID: 3217 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0000DBB3 File Offset: 0x0000BDB3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Alien_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x0000DBD7 File Offset: 0x0000BDD7
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x0000DBFB File Offset: 0x0000BDFB
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("Xbox Home");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0000DC1F File Offset: 0x0000BE1F
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x0000DC56 File Offset: 0x0000BE56
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find(". Stopping handling if inactive.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x000F6B94 File Offset: 0x000F4D94
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1330f)
			{
				this.HBJJOCHGOPH = 869f;
			}
			this.EJDPNJAEAKJ().SetFloat("float,1", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("/icon", this.Therma_Variation);
			this.DEFBJOCJJKF().SetFloat("}", this.Speed);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/VHS_Tracking", this.ALELLLFCDBF);
			this.EJDPNJAEAKJ().SetFloat("MessageText", this.NFDIFLHGJKB);
			this.HHIFMIPPMPF().SetVector("_NoiseTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 970f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x000F6C94 File Offset: 0x000F4E94
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Therma_Variation);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.NFDIFLHGJKB);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x0000DC7A File Offset: 0x0000BE7A
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x000F6D94 File Offset: 0x000F4F94
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1416f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.HKGAONMOBMH().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("pointBuffer", this.Therma_Variation);
			this.IIBLJCKLGFG().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.ALELLLFCDBF);
			this.IIBLJCKLGFG().SetFloat("LevelEditor/icons", this.NFDIFLHGJKB);
			this.ADGHJOHKEHG().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1368f, 1642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0000DCD2 File Offset: 0x0000BED2
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x0000DD09 File Offset: 0x0000BF09
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("907198288");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0000DD2D File Offset: 0x0000BF2D
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

	// Token: 0x06000CA2 RID: 3234 RVA: 0x0000420A File Offset: 0x0000240A
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x0000DD64 File Offset: 0x0000BF64
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x0000420A File Offset: 0x0000240A
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x0000420A File Offset: 0x0000240A
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x000F6E94 File Offset: 0x000F5094
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1890f)
			{
				this.HBJJOCHGOPH = 1541f;
			}
			this.EJDPNJAEAKJ().SetFloat("LoadingStatusText", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("OnPickedUp", this.Therma_Variation);
			this.HKGAONMOBMH().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.Speed);
			this.IIBLJCKLGFG().SetFloat("StartTime already set: ", this.ALELLLFCDBF);
			this.IIBLJCKLGFG().SetFloat("colorD", this.NFDIFLHGJKB);
			this.MCDGIILBNIF().SetVector("#alreadyexist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1388f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x0000420A File Offset: 0x0000240A
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x0000DD9B File Offset: 0x0000BF9B
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x0000DDBF File Offset: 0x0000BFBF
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x000F6F94 File Offset: 0x000F5194
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 640f)
			{
				this.HBJJOCHGOPH = 1790f;
			}
			this.EPCGJFCCAFH().SetFloat("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/TV_BrokenGlass", this.Therma_Variation);
			this.IIBLJCKLGFG().SetFloat("EventConfigButton", this.Speed);
			this.GCDFNHMJMIP().SetFloat("_BlurVector", this.ALELLLFCDBF);
			this.DEFBJOCJJKF().SetFloat("The image effect ", this.NFDIFLHGJKB);
			this.ADGHJOHKEHG().SetVector("GameScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 249f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x0000DDF6 File Offset: 0x0000BFF6
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("[PlayerBase] Got checkpoint at ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x0000420A File Offset: 0x0000240A
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x000F7094 File Offset: 0x000F5294
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 696f)
			{
				this.HBJJOCHGOPH = 1968f;
			}
			this.ADGHJOHKEHG().SetFloat("input", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("[Up]", this.Therma_Variation);
			this.ADGHJOHKEHG().SetFloat("ItemsCountText", this.Speed);
			this.ADGHJOHKEHG().SetFloat("value", this.ALELLLFCDBF);
			this.ADGHJOHKEHG().SetFloat("distance", this.NFDIFLHGJKB);
			this.HHIFMIPPMPF().SetVector("CameraFilterPack/TV_BrokenGlass2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 346f, 1284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x0000420A File Offset: 0x0000240A
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x0000420A File Offset: 0x0000240A
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x0000DE1A File Offset: 0x0000C01A
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x0000DE3E File Offset: 0x0000C03E
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x0000DD9B File Offset: 0x0000BF9B
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x0000420A File Offset: 0x0000240A
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x000F7194 File Offset: 0x000F5394
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 151f;
			}
			this.IIBLJCKLGFG().SetFloat("0,1,false", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("z", this.Therma_Variation);
			this.ADGHJOHKEHG().SetFloat("_Saturation", this.Speed);
			this.IIBLJCKLGFG().SetFloat("_Value3", this.ALELLLFCDBF);
			this.HHIFMIPPMPF().SetFloat("sounds/hit_wrong", this.NFDIFLHGJKB);
			this.GCDFNHMJMIP().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1078f, 942f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x000F7294 File Offset: 0x000F5494
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 203f)
			{
				this.HBJJOCHGOPH = 891f;
			}
			this.NBPKMLMCHFN.SetFloat("PLEASE WAIT", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Toggle {0} is not part of ToggleGroup {1}", this.Therma_Variation);
			this.HKGAONMOBMH().SetFloat("Backward", this.Speed);
			this.GCDFNHMJMIP().SetFloat("_Wavy", this.ALELLLFCDBF);
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.NFDIFLHGJKB);
			this.EJDPNJAEAKJ().SetVector("StartButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 668f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x000F7394 File Offset: 0x000F5594
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1002f)
			{
				this.HBJJOCHGOPH = 51f;
			}
			this.NBPKMLMCHFN.SetFloat("SupportLogger OnLeftRoom().", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Saturation", this.Therma_Variation);
			this.IIBLJCKLGFG().SetFloat("Please attach component to a Graphical UI component", this.Speed);
			this.IIBLJCKLGFG().SetFloat(" timeUntilRespawn: ", this.ALELLLFCDBF);
			this.DEFBJOCJJKF().SetFloat("_Value5", this.NFDIFLHGJKB);
			this.ADGHJOHKEHG().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 746f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x000F7494 File Offset: 0x000F5694
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 821f)
			{
				this.HBJJOCHGOPH = 761f;
			}
			this.EPCGJFCCAFH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("settings.disablestoryboard", this.Therma_Variation);
			this.HHIFMIPPMPF().SetFloat("_MainTex", this.Speed);
			this.GCDFNHMJMIP().SetFloat("_Params1", this.ALELLLFCDBF);
			this.KBOPGONOCNP().SetFloat("_MatrixSize", this.NFDIFLHGJKB);
			this.HHIFMIPPMPF().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1178f, 968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x000F7594 File Offset: 0x000F5794
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1566f)
			{
				this.HBJJOCHGOPH = 303f;
			}
			this.ADGHJOHKEHG().SetFloat("?", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("StartButton", this.Therma_Variation);
			this.DEFBJOCJJKF().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.Speed);
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack_eyes_vision_2", this.ALELLLFCDBF);
			this.ADGHJOHKEHG().SetFloat("_Value4", this.NFDIFLHGJKB);
			this.IIBLJCKLGFG().SetVector("/512px-512px.png", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 572f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x000F7694 File Offset: 0x000F5894
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 417f)
			{
				this.HBJJOCHGOPH = 523f;
			}
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/Glasses_OnX", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Crosshair2", this.Therma_Variation);
			this.GCDFNHMJMIP().SetFloat("_PrevViewProj", this.Speed);
			this.NBPKMLMCHFN.SetFloat("Default UI Material", this.ALELLLFCDBF);
			this.DEFBJOCJJKF().SetFloat("_NoiseTex", this.NFDIFLHGJKB);
			this.KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 273f, 1461f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0000DE75 File Offset: 0x0000C075
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0000DE99 File Offset: 0x0000C099
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x0000420A File Offset: 0x0000240A
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x0000420A File Offset: 0x0000240A
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x0000420A File Offset: 0x0000240A
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x000F7794 File Offset: 0x000F5994
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 711f;
			}
			this.EPCGJFCCAFH().SetFloat("event", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("inventory.selected.", this.Therma_Variation);
			this.EPCGJFCCAFH().SetFloat("_Near", this.Speed);
			this.ADGHJOHKEHG().SetFloat("_ScreenResolution", this.ALELLLFCDBF);
			this.ADGHJOHKEHG().SetFloat("A", this.NFDIFLHGJKB);
			this.KBOPGONOCNP().SetVector("UseScanLineSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1561f, 244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x0000DED0 File Offset: 0x0000C0D0
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x0000DF07 File Offset: 0x0000C107
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x0000420A File Offset: 0x0000240A
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x0000DF3E File Offset: 0x0000C13E
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0000DF75 File Offset: 0x0000C175
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x000F7894 File Offset: 0x000F5A94
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1460f)
			{
				this.HBJJOCHGOPH = 123f;
			}
			this.EPCGJFCCAFH().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.Therma_Variation);
			this.EPCGJFCCAFH().SetFloat("NEW_ACHIEVEMENT_1_21", this.Speed);
			this.KBOPGONOCNP().SetFloat("_Value2", this.ALELLLFCDBF);
			this.MCDGIILBNIF().SetFloat("_Val2", this.NFDIFLHGJKB);
			this.GCDFNHMJMIP().SetVector("CameraFilterPack_VHS2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1776f, 1797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x000F7994 File Offset: 0x000F5B94
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1092f)
			{
				this.HBJJOCHGOPH = 230f;
			}
			this.ADGHJOHKEHG().SetFloat("Save the map before exiting?", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", this.Therma_Variation);
			this.HKGAONMOBMH().SetFloat("Joystick1Button4", this.Speed);
			this.DEFBJOCJJKF().SetFloat("[PlayerController] ", this.ALELLLFCDBF);
			this.HHIFMIPPMPF().SetFloat("_ScreenResolution", this.NFDIFLHGJKB);
			this.KBOPGONOCNP().SetVector("Rtt:{0,4} +/-{1,3}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 311f, 851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x0000DF99 File Offset: 0x0000C199
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find(" but this PhotonView does not exist! View was/is ours.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x0000DB96 File Offset: 0x0000BD96
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001F0 RID: 496
	public Shader SCShader;

	// Token: 0x040001F1 RID: 497
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001F2 RID: 498
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001F3 RID: 499
	private Material BJFKDHHMLJH;

	// Token: 0x040001F4 RID: 500
	[Range(0f, 0.5f)]
	public float Therma_Variation = 0.5f;

	// Token: 0x040001F5 RID: 501
	[Range(0f, 1f)]
	public float Speed = 0.5f;

	// Token: 0x040001F6 RID: 502
	[Range(0f, 4f)]
	private float ALELLLFCDBF;

	// Token: 0x040001F7 RID: 503
	[Range(0f, 16f)]
	private float NFDIFLHGJKB = 1f;
}
