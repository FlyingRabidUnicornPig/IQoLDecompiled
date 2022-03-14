/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200001D RID: 29
[AddComponentMenu("Camera Filter Pack/3D/Binary")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Binary : MonoBehaviour
{
	// Token: 0x0600057D RID: 1405 RVA: 0x00004C32 File Offset: 0x00002E32
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x000D09AC File Offset: 0x000CEBAC
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1195f)
			{
				this.HBJJOCHGOPH = 1492f;
			}
			this.PGPEMMBJOOG().SetFloat("Connection failed: ", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this.Fade);
			this.JIBOKBCPDLC().SetFloat("event", this.FadeFromBinary);
			this.LPMLLJKMAMP().SetFloat("CompletedLevel", this._FixDistance);
			this.HEINDEMCGIK().SetFloat(" ", this.MatrixSize);
			this.OCHJIMJNEMO().SetColor("ShadersToggle", this._MatrixColor);
			this.DKNJGHFLAIF().SetFloat(" not exist", this.MatrixSpeed * 1122f);
			this.NBPKMLMCHFN.SetFloat("SupportLogger OnApplicationPause: ", (float)((!this._Visualize) ? 1 : 0));
			this.FLOHGDECHHH().SetFloat("workshop.", this.LightIntensity);
			this.AELJLBOJAIL().SetTexture("EnvironmentSlider", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLOHGDECHHH().SetFloat("<command>", 1732f / farClipPlane);
			this.AELJLBOJAIL().SetVector("inventory.itemscash", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 494f, 371f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x000D0B5C File Offset: 0x000CED5C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1510f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.FLOHGDECHHH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("_Value2", this.Fade);
			this.OIMMPLPBLBK().SetFloat("_Value", this.FadeFromBinary);
			this.EMDFHOKEGNG().SetFloat("{0:0} hour{1}, ", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Gradients_Tech", this.MatrixSize);
			this.CEKJODEAMGB().SetColor("_Blue_R", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("Image", this.MatrixSpeed * 152f);
			this.DKNJGHFLAIF().SetFloat("_Value4", (float)((!this._Visualize) ? 0 : 0));
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.LightIntensity);
			this.LENEJAGLCNL().SetTexture("_Value2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/RainFX", 961f / farClipPlane);
			this.EMDFHOKEGNG().SetVector("Alpha", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1102f, 1343f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x000D0D0C File Offset: 0x000CEF0C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 198f)
			{
				this.HBJJOCHGOPH = 398f;
			}
			this.KGOLDDBHIFN().SetFloat(" b.", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat(". Sent by actorNr: ", this.Fade);
			this.OCHJIMJNEMO().SetFloat("<command>", this.FadeFromBinary);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/TV_Posterize", this._FixDistance);
			this.EMDFHOKEGNG().SetFloat("wss://", this.MatrixSize);
			this.BFGNMFCNDBC().SetColor("_ColorRGB", this._MatrixColor);
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.MatrixSpeed * 1322f);
			this.CEKJODEAMGB().SetFloat("LivesSlider", (float)((!this._Visualize) ? 0 : 0));
			this.CEKJODEAMGB().SetFloat("_FgCocMask", this.LightIntensity);
			this.KEMJNOMIPHN().SetTexture("Gameplay/Base", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLOHGDECHHH().SetFloat("StartButton", 697f / farClipPlane);
			this.IGIAPKPKGPK().SetVector("_SecondTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1231f, 196f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0000420A File Offset: 0x0000240A
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00004C69 File Offset: 0x00002E69
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("OpGetGameList()") as Texture2D);
		this.SCShader = Shader.Find("{0} days ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00004CBF File Offset: 0x00002EBF
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Gradients_Ansi") as Texture2D);
		this.SCShader = Shader.Find("RoomDescriptionText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x000D0EBC File Offset: 0x000CF0BC
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 934f)
			{
				this.HBJJOCHGOPH = 702f;
			}
			this.GKILCDHJFEG().SetFloat("End index must in an integer.", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("/", this.Fade);
			this.MCDGIILBNIF().SetFloat("Tab2Content", this.FadeFromBinary);
			this.HFBJAOFLCJI().SetFloat("_Value", this._FixDistance);
			this.MCDGIILBNIF().SetFloat("_ScreenResolution", this.MatrixSize);
			this.CEKJODEAMGB().SetColor("CameraFilterPack/EXTRA_SHOWFPS", this._MatrixColor);
			this.IGIAPKPKGPK().SetFloat("Unknown player asked for PickupItems", this.MatrixSpeed * 1028f);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/Pixelisation_Dot", (float)((!this._Visualize) ? 0 : 0));
			this.OCHJIMJNEMO().SetFloat("_Value1", this.LightIntensity);
			this.EPCGJFCCAFH().SetTexture("_Offsets", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIMMPLPBLBK().SetFloat("Particles/Additive", 480f / farClipPlane);
			this.JIBOKBCPDLC().SetVector("PUN-instantiated '", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 662f, 1256f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0000420A File Offset: 0x0000240A
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00004CF8 File Offset: 0x00002EF8
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Binary1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Binary");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x000D106C File Offset: 0x000CF26C
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
			this.NBPKMLMCHFN.SetFloat("_FadeFromBinary", this.FadeFromBinary);
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

	// Token: 0x0600058C RID: 1420 RVA: 0x00004D31 File Offset: 0x00002F31
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("1159514800");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x000D121C File Offset: 0x000CF41C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1371f)
			{
				this.HBJJOCHGOPH = 661f;
			}
			this.NBPKMLMCHFN.SetFloat("ResourceIDInputField", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("SlidingArea", this.Fade);
			this.IGIAPKPKGPK().SetFloat("maps.", this.FadeFromBinary);
			this.OIMMPLPBLBK().SetFloat("maps.", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("_Value3", this.MatrixSize);
			this.GKILCDHJFEG().SetColor("_BorderColor", this._MatrixColor);
			this.LENEJAGLCNL().SetFloat(":", this.MatrixSpeed * 820f);
			this.KGOLDDBHIFN().SetFloat(" not exist", (float)((!this._Visualize) ? 0 : 0));
			this.FLOHGDECHHH().SetFloat("_TimeX", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("EditMenu", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("false", 1987f / farClipPlane);
			this.LENEJAGLCNL().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 770f, 1321f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x000D13CC File Offset: 0x000CF5CC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 211f)
			{
				this.HBJJOCHGOPH = 1646f;
			}
			this.CEKJODEAMGB().SetFloat("_Green_G", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/Drawing_Comics", this.Fade);
			this.AELJLBOJAIL().SetFloat("Please specify a map name or buildID", this.FadeFromBinary);
			this.HFBJAOFLCJI().SetFloat("<b>#", this._FixDistance);
			this.DKNJGHFLAIF().SetFloat("maps.", this.MatrixSize);
			this.FLOHGDECHHH().SetColor("\" gets executed locally only, if at all.", this._MatrixColor);
			this.MCDGIILBNIF().SetFloat("Tab2Content", this.MatrixSpeed * 1239f);
			this.EPCGJFCCAFH().SetFloat("settings.enablehitsoundsinnormal", (float)((!this._Visualize) ? 1 : 0));
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.LightIntensity);
			this.HEINDEMCGIK().SetTexture("_FarCamera", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Broken_Screen", 1793f / farClipPlane);
			this.OCHJIMJNEMO().SetVector("_HalfResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1475f, 1192f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00004D6A File Offset: 0x00002F6A
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00004DA1 File Offset: 0x00002FA1
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0000420A File Offset: 0x0000240A
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00004DD8 File Offset: 0x00002FD8
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("GhostFade") as Texture2D);
		this.SCShader = Shader.Find("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00004E11 File Offset: 0x00003011
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("setbool") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0000420A File Offset: 0x0000240A
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00004E4A File Offset: 0x0000304A
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.selectedlevelid") as Texture2D);
		this.SCShader = Shader.Find("_VignettingColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0000420A File Offset: 0x0000240A
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00004E83 File Offset: 0x00003083
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00004EBA File Offset: 0x000030BA
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00004EF1 File Offset: 0x000030F1
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x000D157C File Offset: 0x000CF77C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 1370f;
			}
			this.NBPKMLMCHFN.SetFloat("_ZCurve", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("settings.hitvariation", this.Fade);
			this.KGOLDDBHIFN().SetFloat("_Offsets", this.FadeFromBinary);
			this.EPCGJFCCAFH().SetFloat("_Blue_G", this._FixDistance);
			this.DKNJGHFLAIF().SetFloat(": ", this.MatrixSize);
			this.OCHJIMJNEMO().SetColor(",", this._MatrixColor);
			this.LENEJAGLCNL().SetFloat("Jump", this.MatrixSpeed * 1235f);
			this.CEKJODEAMGB().SetFloat("_History1Weight", (float)((!this._Visualize) ? 0 : 0));
			this.HEINDEMCGIK().SetFloat("[Right]", this.LightIntensity);
			this.EPCGJFCCAFH().SetTexture("#highscore", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat("/icon", 1397f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1845f, 1541f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00004F28 File Offset: 0x00003128
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

	// Token: 0x060005A2 RID: 1442 RVA: 0x00004F5F File Offset: 0x0000315F
	private void ICILLMAKLMI()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00004F98 File Offset: 0x00003198
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x000D172C File Offset: 0x000CF92C
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1942f)
			{
				this.HBJJOCHGOPH = 81f;
			}
			this.CEKJODEAMGB().SetFloat("Ev OwnershipTransfer. ViewID ", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("[SteamManager] Connection established, authorization", this.Fade);
			this.KEMJNOMIPHN().SetFloat("VIGNETTE_CLASSIC", this.FadeFromBinary);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this._FixDistance);
			this.LENEJAGLCNL().SetFloat("/icon", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("SetParticlesParticleSpeed", this._MatrixColor);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.MatrixSpeed * 292f);
			this.CEKJODEAMGB().SetFloat("#C8C8C8FF", (float)((!this._Visualize) ? 0 : 1));
			this.FLOHGDECHHH().SetFloat("mapselector.filter.subscribedonly", this.LightIntensity);
			this.JIBOKBCPDLC().SetTexture("CameraFilterPack/Color_RGB", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("BadgeText", 995f / farClipPlane);
			this.OCHJIMJNEMO().SetVector(" : ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1413f, 1611f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00004FCF File Offset: 0x000031CF
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0000420A File Offset: 0x0000240A
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x000D18DC File Offset: 0x000CFADC
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 789f;
			}
			this.AELJLBOJAIL().SetFloat("_Value", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("isVisible", this.Fade);
			this.HEINDEMCGIK().SetFloat("?", this.FadeFromBinary);
			this.KGOLDDBHIFN().SetFloat("_TimeX", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("VisionBlur", this.MatrixSize);
			this.DKNJGHFLAIF().SetColor("_ThirdTex", this._MatrixColor);
			this.KGOLDDBHIFN().SetFloat("Vertical", this.MatrixSpeed * 780f);
			this.EMDFHOKEGNG().SetFloat("Init", (float)((!this._Visualize) ? 1 : 1));
			this.PGPEMMBJOOG().SetFloat("DontDestroy", this.LightIntensity);
			this.FLOHGDECHHH().SetTexture("Mouse X", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", 187f / farClipPlane);
			this.MCDGIILBNIF().SetVector("_Vibrance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1065f, 1332f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0000420A File Offset: 0x0000240A
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00005006 File Offset: 0x00003206
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0000503D File Offset: 0x0000323D
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00005074 File Offset: 0x00003274
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x000050AB File Offset: 0x000032AB
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x000050E2 File Offset: 0x000032E2
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00005119 File Offset: 0x00003319
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00005150 File Offset: 0x00003350
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("COMPLETED") as Texture2D);
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00005189 File Offset: 0x00003389
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x000051C0 File Offset: 0x000033C0
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("_ArScale") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x000051F9 File Offset: 0x000033F9
	private void AEDDNDHCLNN()
	{
		this.FPHEBLMINDA = (Resources.Load("No Dispatcher exists in the scene. Actions will not be invoked!") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x000D1AF8 File Offset: 0x000CFCF8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1715f)
			{
				this.HBJJOCHGOPH = 949f;
			}
			this.LENEJAGLCNL().SetFloat("closed", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_AlphaHexa", this.Fade);
			this.HEINDEMCGIK().SetFloat("_DotSize", this.FadeFromBinary);
			this.JIBOKBCPDLC().SetFloat("_TimeX", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("Mouse ", this.MatrixSize);
			this.OIMMPLPBLBK().SetColor(" PhotonNetwork.networkingPeer.AvailableRegions ", this._MatrixColor);
			this.GKILCDHJFEG().SetFloat("UsernameText", this.MatrixSpeed * 1201f);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Color_YUV", this.LightIntensity);
			this.FLOHGDECHHH().SetTexture("InventoryButton", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("Misses:", 1559f / farClipPlane);
			this.LPMLLJKMAMP().SetVector("tagElement", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 605f, 1727f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x000D1CA8 File Offset: 0x000CFEA8
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 7f)
			{
				this.HBJJOCHGOPH = 1252f;
			}
			this.LENEJAGLCNL().SetFloat("#join", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_Distortion", this.Fade);
			this.EPCGJFCCAFH().SetFloat("ChatHistoryInputField", this.FadeFromBinary);
			this.IGIAPKPKGPK().SetFloat("HandleEventLeave for player ID: ", this._FixDistance);
			this.FLOHGDECHHH().SetFloat("_PrevViewProj", this.MatrixSize);
			this.KGOLDDBHIFN().SetColor("Set Trail Zoom (player camera move forward effect). Base value - 1.5", this._MatrixColor);
			this.CEKJODEAMGB().SetFloat("Up ", this.MatrixSpeed * 719f);
			this.FLOHGDECHHH().SetFloat("offsets", (float)((!this._Visualize) ? 1 : 1));
			this.PGPEMMBJOOG().SetFloat("settings.disablestoryboard", this.LightIntensity);
			this.BFGNMFCNDBC().SetTexture("Source directory does not exist or could not be found: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("_MainTex2", 707f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1631f, 25f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0000420A File Offset: 0x0000240A
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMADKINICIN()
	{
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00005232 File Offset: 0x00003432
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load("skin.") as Texture2D);
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x000D1E58 File Offset: 0x000D0058
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 181f)
			{
				this.HBJJOCHGOPH = 1900f;
			}
			this.JIBOKBCPDLC().SetFloat("_History1LumaTex", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("_TimeX", this.Fade);
			this.BFGNMFCNDBC().SetFloat("[Down]", this.FadeFromBinary);
			this.GKILCDHJFEG().SetFloat("[LevelEditorScene] Map submitted!", this._FixDistance);
			this.JIBOKBCPDLC().SetFloat("MenuScene", this.MatrixSize);
			this.AELJLBOJAIL().SetColor("</color>", this._MatrixColor);
			this.CEKJODEAMGB().SetFloat("#close", this.MatrixSpeed * 5f);
			this.LPMLLJKMAMP().SetFloat("_RedAmplifier", (float)((!this._Visualize) ? 0 : 1));
			this.MCDGIILBNIF().SetFloat("Prints the number of logs currently held by DebugLogs", this.LightIntensity);
			this.MCDGIILBNIF().SetTexture("#yes", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DKNJGHFLAIF().SetFloat("#", 1424f / farClipPlane);
			this.CEKJODEAMGB().SetVector("Item invalid. Make sure your mod contains at leats one file.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1917f, 1244f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0000420A File Offset: 0x0000240A
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x000D2008 File Offset: 0x000D0208
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 295f)
			{
				this.HBJJOCHGOPH = 1891f;
			}
			this.EPCGJFCCAFH().SetFloat("USE_UV_BASED_REPROJECTION", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", this.Fade);
			this.IGIAPKPKGPK().SetFloat("_TimeX", this.FadeFromBinary);
			this.HFBJAOFLCJI().SetFloat("other.dust0", this._FixDistance);
			this.LENEJAGLCNL().SetFloat("_Smooth", this.MatrixSize);
			this.JIBOKBCPDLC().SetColor("CameraFilterPack/Blend2Camera_HardLight", this._MatrixColor);
			this.OCHJIMJNEMO().SetFloat("1159514800", this.MatrixSpeed * 1188f);
			this.KGOLDDBHIFN().SetFloat("_BlurRadius4", (float)((!this._Visualize) ? 0 : 1));
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.LightIntensity);
			this.OIMMPLPBLBK().SetTexture("CHROMATIC_ABERRATION", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JIBOKBCPDLC().SetFloat("_Offsets", 752f / farClipPlane);
			this.GKILCDHJFEG().SetVector("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 186f, 1208f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0000526B File Offset: 0x0000346B
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("BackButton") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x000052A4 File Offset: 0x000034A4
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("SetCrosshairColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x000052DD File Offset: 0x000034DD
	private void FMFNILJIEIA()
	{
		this.FPHEBLMINDA = (Resources.Load("Prints the number of logs currently held by DebugLogs") as Texture2D);
		this.SCShader = Shader.Find("CreateRoom failed, client stays on masterserver: {0}.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0000420A File Offset: 0x0000240A
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00005316 File Offset: 0x00003516
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x0000534D File Offset: 0x0000354D
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x0000420A File Offset: 0x0000240A
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x000D21B8 File Offset: 0x000D03B8
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1422f)
			{
				this.HBJJOCHGOPH = 384f;
			}
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/Distortion_Dream", this.Fade);
			this.DKNJGHFLAIF().SetFloat("LevelInfoInputField", this.FadeFromBinary);
			this.KGOLDDBHIFN().SetFloat("mapselector.filter.subscribedonly", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("\"", this.MatrixSize);
			this.PGPEMMBJOOG().SetColor("#forever", this._MatrixColor);
			this.FLOHGDECHHH().SetFloat("_EmissionColor", this.MatrixSpeed * 1550f);
			this.PGPEMMBJOOG().SetFloat("Bad parameters for setbool! Use <key> <value>", (float)((!this._Visualize) ? 0 : 1));
			this.BFGNMFCNDBC().SetFloat("ItemNameBGImage", this.LightIntensity);
			this.CEKJODEAMGB().SetTexture("appid", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JIBOKBCPDLC().SetFloat(":", 1276f / farClipPlane);
			this.EMDFHOKEGNG().SetVector("CameraFilterPack/Blend2Camera_Hue", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1382f, 1081f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00005384 File Offset: 0x00003584
	private void MNBPNHNAEBK()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x000D2368 File Offset: 0x000D0568
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1026f)
			{
				this.HBJJOCHGOPH = 414f;
			}
			this.LPMLLJKMAMP().SetFloat("[MapsData] Found ", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("#random #epic #item", this.Fade);
			this.IGIAPKPKGPK().SetFloat("_FadeShield", this.FadeFromBinary);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack_VHS2", this._FixDistance);
			this.JIBOKBCPDLC().SetFloat("fade in duration", this.MatrixSize);
			this.BFGNMFCNDBC().SetColor("Delete events", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Lighten", this.MatrixSpeed * 1608f);
			this.HEINDEMCGIK().SetFloat("x", (float)((!this._Visualize) ? 0 : 0));
			this.FLOHGDECHHH().SetFloat("_TimeX", this.LightIntensity);
			this.CEKJODEAMGB().SetTexture("Tab1Content", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.AELJLBOJAIL().SetFloat("_Value2", 522f / farClipPlane);
			this.LENEJAGLCNL().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 289f, 70f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x000D2518 File Offset: 0x000D0718
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 149f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.PGPEMMBJOOG().SetFloat("Texture2", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_VelTex", this.Fade);
			this.IGIAPKPKGPK().SetFloat("_MainTex", this.FadeFromBinary);
			this.HFBJAOFLCJI().SetFloat("_MainTex2", this._FixDistance);
			this.HEINDEMCGIK().SetFloat("[ItemsHandler] Found ", this.MatrixSize);
			this.BFGNMFCNDBC().SetColor("_SSRMultiplier", this._MatrixColor);
			this.GKILCDHJFEG().SetFloat("Failed to 'network-remove' GameObject because it's null.", this.MatrixSpeed * 1312f);
			this.FLOHGDECHHH().SetFloat(".status", (float)((!this._Visualize) ? 1 : 0));
			this.AELJLBOJAIL().SetFloat("Tab1Content", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("[ItemsHandler] Inventory not changed", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JIBOKBCPDLC().SetFloat(":", 188f / farClipPlane);
			this.DKNJGHFLAIF().SetVector("float,10", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1177f, 171f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x000D26C8 File Offset: 0x000D08C8
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 211f)
			{
				this.HBJJOCHGOPH = 227f;
			}
			this.KGOLDDBHIFN().SetFloat("_Factor", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("error", this.Fade);
			this.HFBJAOFLCJI().SetFloat("_Colored", this.FadeFromBinary);
			this.DKNJGHFLAIF().SetFloat("maps.", this._FixDistance);
			this.LENEJAGLCNL().SetFloat("_BorderColor", this.MatrixSize);
			this.FLOHGDECHHH().SetColor("ResourcesConfig", this._MatrixColor);
			this.FLOHGDECHHH().SetFloat("0.00", this.MatrixSpeed * 398f);
			this.HEINDEMCGIK().SetFloat("_Value3", (float)((!this._Visualize) ? 1 : 1));
			this.DKNJGHFLAIF().SetFloat(".lastCheckpoint.longestComboScore", this.LightIntensity);
			this.HEINDEMCGIK().SetTexture("CameraFilterPack_TV_Noise3", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EMDFHOKEGNG().SetFloat("[FileSelector] Dialog ended, result: ", 605f / farClipPlane);
			this.KGOLDDBHIFN().SetVector("Joystick1Button4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 563f, 1555f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0000420A File Offset: 0x0000240A
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x000053BD File Offset: 0x000035BD
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x000053F4 File Offset: 0x000035F4
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Parasite") as Texture2D);
		this.SCShader = Shader.Find("<command>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0000542D File Offset: 0x0000362D
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00005464 File Offset: 0x00003664
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load(" ") as Texture2D);
		this.SCShader = Shader.Find("local CheckCondition = function()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00004CA2 File Offset: 0x00002EA2
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0000549D File Offset: 0x0000369D
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x000D2878 File Offset: 0x000D0A78
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1058f)
			{
				this.HBJJOCHGOPH = 1890f;
			}
			this.DKNJGHFLAIF().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat(". Using max value: 255.", this.Fade);
			this.EMDFHOKEGNG().SetFloat("SetSatelliteColor", this.FadeFromBinary);
			this.OIMMPLPBLBK().SetFloat("_Intensity", this._FixDistance);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/Fly_Vision", this.MatrixSize);
			this.HFBJAOFLCJI().SetColor("Screenshots only supported in PlayMode", this._MatrixColor);
			this.EMDFHOKEGNG().SetFloat("_MainTex2", this.MatrixSpeed * 502f);
			this.JFDGLLEOPGB().SetFloat(".r", (float)((!this._Visualize) ? 0 : 1));
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Color_GrayScale", this.LightIntensity);
			this.OCHJIMJNEMO().SetTexture("PLEASE WAIT", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("BitsData", 1477f / farClipPlane);
			this.FLOHGDECHHH().SetVector("[Up]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1518f, 768f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x000D2A28 File Offset: 0x000D0C28
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 267f)
			{
				this.HBJJOCHGOPH = 1787f;
			}
			this.LPMLLJKMAMP().SetFloat("  |  Events Count: ", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_CurrentMipLevel", this.Fade);
			this.GKILCDHJFEG().SetFloat("_Red_B", this.FadeFromBinary);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/AAA_WaterDropPro", this._FixDistance);
			this.HEINDEMCGIK().SetFloat("[PlayerController] ", this.MatrixSize);
			this.MCDGIILBNIF().SetColor("CameraFilterPack/Lut_Simple", this._MatrixColor);
			this.AELJLBOJAIL().SetFloat("x", this.MatrixSpeed * 1707f);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Distortion_ShockWaveManual", (float)((!this._Visualize) ? 0 : 0));
			this.EPCGJFCCAFH().SetFloat("[Right]", this.LightIntensity);
			this.IGIAPKPKGPK().SetTexture("StartButton", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("IconFileSelector", 494f / farClipPlane);
			this.IGIAPKPKGPK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1491f, 558f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x000054D4 File Offset: 0x000036D4
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040000DD RID: 221
	public Shader SCShader;

	// Token: 0x040000DE RID: 222
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000DF RID: 223
	public bool _Visualize;

	// Token: 0x040000E0 RID: 224
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000E1 RID: 225
	private Material BJFKDHHMLJH;

	// Token: 0x040000E2 RID: 226
	[Range(0f, 100f)]
	public float _FixDistance = 2f;

	// Token: 0x040000E3 RID: 227
	[Range(-5f, 5f)]
	public float LightIntensity;

	// Token: 0x040000E4 RID: 228
	[Range(0f, 8f)]
	public float MatrixSize = 2f;

	// Token: 0x040000E5 RID: 229
	[Range(-4f, 4f)]
	public float MatrixSpeed = 1f;

	// Token: 0x040000E6 RID: 230
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040000E7 RID: 231
	[Range(0f, 1f)]
	public float FadeFromBinary;

	// Token: 0x040000E8 RID: 232
	public Color _MatrixColor = new Color(1f, 0.3f, 0.3f, 1f);

	// Token: 0x040000E9 RID: 233
	public static Color ChangeColorRGB;

	// Token: 0x040000EA RID: 234
	private Texture2D FPHEBLMINDA;
}
