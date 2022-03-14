/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000034 RID: 52
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Fog")]
public class CameraFilterPack_Atmosphere_Fog : MonoBehaviour
{
	// Token: 0x06000D41 RID: 3393 RVA: 0x000F88F4 File Offset: 0x000F6AF4
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 1462f;
			}
			this.EMDFHOKEGNG().SetFloat("NEW", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("\t", this.Fade);
			this.NFMGLIKNOOC().SetFloat("_TimeX", this._Near);
			this.FLOHGDECHHH().SetFloat("MenuScene", this._Far);
			this.JLHLHKPHDFO().SetColor("skin.hit_wrong", this.FogColor);
			this.JLHLHKPHDFO().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1412f, 1330f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.CECJJMKLEAK().SetTexture("_Offsets", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x000F8A18 File Offset: 0x000F6C18
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1055f)
			{
				this.HBJJOCHGOPH = 670f;
			}
			this.DKNJGHFLAIF().SetFloat("<b>#", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("float,0", this.Fade);
			this.FGENHBKMPDA().SetFloat("float,10", this._Near);
			this.OOMFJGPAOKL().SetFloat("EventData0DropDownList", this._Far);
			this.EMDFHOKEGNG().SetColor("EventSystem", this.FogColor);
			this.OOMFJGPAOKL().SetVector("Items", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1733f, 1385f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.FLOHGDECHHH().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x000F8B3C File Offset: 0x000F6D3C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1005f)
			{
				this.HBJJOCHGOPH = 289f;
			}
			this.NFMGLIKNOOC().SetFloat("Rock", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("x", this.Fade);
			this.FLOHGDECHHH().SetFloat("SetSatelliteInput", this._Near);
			this.IIBLJCKLGFG().SetFloat("?", this._Far);
			this.FEAEGGCNIAA().SetColor("_Fade", this.FogColor);
			this.NBPKMLMCHFN.SetVector("_Green_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1111f, 1430f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.FKEOGPDLBDD().SetTexture(".completedCount", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x000F8C60 File Offset: 0x000F6E60
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1013f)
			{
				this.HBJJOCHGOPH = 741f;
			}
			this.DKNJGHFLAIF().SetFloat("SetSunMinSize", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("RecordButton", this.Fade);
			this.NBPKMLMCHFN.SetFloat("id", this._Near);
			this.KEMAALEODNH().SetFloat(" SphereWaveform.cs", this._Far);
			this.IGKFMCPDNOI().SetColor("_Value4", this.FogColor);
			this.EMDFHOKEGNG().SetVector("_ProjInfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 159f, 1703f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.EMDFHOKEGNG().SetTexture("note.1", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x0000E59F File Offset: 0x0000C79F
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x000F8D84 File Offset: 0x000F6F84
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 785f)
			{
				this.HBJJOCHGOPH = 922f;
			}
			this.DKNJGHFLAIF().SetFloat("_Near", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("[PlayerController] ", this.Fade);
			this.IGKFMCPDNOI().SetFloat(".", this._Near);
			this.FGENHBKMPDA().SetFloat("Error: you cannot write/send to this stream that you are reading!", this._Far);
			this.OOMFJGPAOKL().SetColor("[MapsData] Caching ", this.FogColor);
			this.IIBLJCKLGFG().SetVector("(\\[ */ *i *\\])", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1756f, 1034f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.IIBLJCKLGFG().SetTexture("Gameplay/sun", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x000F8EA8 File Offset: 0x000F70A8
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 605f)
			{
				this.HBJJOCHGOPH = 1994f;
			}
			this.FGENHBKMPDA().SetFloat("System.Single", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_VignettingDirt", this.Fade);
			this.EHDJJANLINB().SetFloat("</size>", this._Near);
			this.NFMGLIKNOOC().SetFloat("Achievement 21 progress reseted", this._Far);
			this.FLOHGDECHHH().SetColor("IEnumerable", this.FogColor);
			this.FLOHGDECHHH().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 579f, 95f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.FKEOGPDLBDD().SetTexture("SpawnObj", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x0000E5F3 File Offset: 0x0000C7F3
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x0000E62A File Offset: 0x0000C82A
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x0000E661 File Offset: 0x0000C861
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("_MatrixColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x0000420A File Offset: 0x0000240A
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x0000E69A File Offset: 0x0000C89A
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0000E6D1 File Offset: 0x0000C8D1
	private void LIBGAKMKHJJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_TexelOffsetScale") as Texture2D);
		this.SCShader = Shader.Find("_Color2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x000F8FCC File Offset: 0x000F71CC
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 642f)
			{
				this.HBJJOCHGOPH = 302f;
			}
			this.NBPKMLMCHFN.SetFloat("0,1,false", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_Saturation", this.Fade);
			this.NBMPPNFKFLB().SetFloat("_ScreenResolution", this._Near);
			this.IIBLJCKLGFG().SetFloat("ItemsCountText", this._Far);
			this.IIJMIPBMMBF().SetColor("2", this.FogColor);
			this.NLFJGMBCICG().SetVector("ComboText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 756f, 737f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.CECJJMKLEAK().SetTexture("NameText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x000F90F0 File Offset: 0x000F72F0
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1925f)
			{
				this.HBJJOCHGOPH = 1567f;
			}
			this.JLHLHKPHDFO().SetFloat("Mouse X", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("IntraSig", this.Fade);
			this.DKNJGHFLAIF().SetFloat("AVG Misses:", this._Near);
			this.KEMAALEODNH().SetFloat("Object ID. Case-Sensitive", this._Far);
			this.OOMFJGPAOKL().SetColor("_Near", this.FogColor);
			this.FLOHGDECHHH().SetVector("\\\"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1830f, 43f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.IGKFMCPDNOI().SetTexture("EventData0DropDownList", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x0000420A File Offset: 0x0000240A
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0000420A File Offset: 0x0000240A
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x000F9214 File Offset: 0x000F7414
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1051f)
			{
				this.HBJJOCHGOPH = 458f;
			}
			this.IGKFMCPDNOI().SetFloat(" has been disabled as it's not supported on the current platform.", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("ItemNameText", this.Fade);
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] Unknown event: ", this._Near);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", this._Far);
			this.FEAEGGCNIAA().SetColor("Run a command for data system", this.FogColor);
			this.JLHLHKPHDFO().SetVector("Hip-hop", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 866f, 399f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.FEAEGGCNIAA().SetTexture("CameraFilterPack/TV_MovieNoise", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x0000E70A File Offset: 0x0000C90A
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("_PositionY") as Texture2D);
		this.SCShader = Shader.Find("USE_DIAG_SEARCH");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x0000E743 File Offset: 0x0000C943
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x0000E77A File Offset: 0x0000C97A
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x0000E7B1 File Offset: 0x0000C9B1
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x000F9338 File Offset: 0x000F7538
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 584f)
			{
				this.HBJJOCHGOPH = 1354f;
			}
			this.MICHFGAOPKM().SetFloat("PRESS A KEY", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("SetParticlesParticleSize", this.Fade);
			this.JLHLHKPHDFO().SetFloat(" Server: ", this._Near);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", this._Far);
			this.DKNJGHFLAIF().SetColor("[PlayerBase] Loaded spawner data", this.FogColor);
			this.CECJJMKLEAK().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 1421f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.ADGHJOHKEHG().SetTexture("Authentication failed: '{0}' Code: {1}", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x0000420A File Offset: 0x0000240A
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load(",") as Texture2D);
		this.SCShader = Shader.Find("player.dragon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x000F945C File Offset: 0x000F765C
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
			this.NBPKMLMCHFN.SetFloat("_Near", this._Near);
			this.NBPKMLMCHFN.SetFloat("_Far", this._Far);
			this.NBPKMLMCHFN.SetColor("_ColorRGB", this.FogColor);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x000F9580 File Offset: 0x000F7780
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 31f;
			}
			this.CECJJMKLEAK().SetFloat("SetSunMaxSize", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("CameraFilterPack/Glasses_On", this.Fade);
			this.KEMAALEODNH().SetFloat("_Value4", this._Near);
			this.JLHLHKPHDFO().SetFloat("_ExtraColor", this._Far);
			this.FGENHBKMPDA().SetColor("HPToggle", this.FogColor);
			this.EMDFHOKEGNG().SetVector("tagElement", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1367f, 900f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.IIBLJCKLGFG().SetTexture("|", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x0000E821 File Offset: 0x0000CA21
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x0000E858 File Offset: 0x0000CA58
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x000F96A4 File Offset: 0x000F78A4
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 673f)
			{
				this.HBJJOCHGOPH = 943f;
			}
			this.IIBLJCKLGFG().SetFloat("\nCreated by Oxy949", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("BitsData", this.Fade);
			this.IIBLJCKLGFG().SetFloat(" (now: ", this._Near);
			this.CECJJMKLEAK().SetFloat("_Fade", this._Far);
			this.FKEOGPDLBDD().SetColor(",", this.FogColor);
			this.EMDFHOKEGNG().SetVector("DPADHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 338f, 1359f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.FKEOGPDLBDD().SetTexture("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x0000E88F File Offset: 0x0000CA8F
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x000F97C8 File Offset: 0x000F79C8
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 133f)
			{
				this.HBJJOCHGOPH = 803f;
			}
			this.FKEOGPDLBDD().SetFloat("_AdaptionSpeed", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("[PlayerController] ", this.Fade);
			this.MICHFGAOPKM().SetFloat("editorVolume", this._Near);
			this.IIJMIPBMMBF().SetFloat(": ", this._Far);
			this.CECJJMKLEAK().SetColor("GlassesColor", this.FogColor);
			this.FLOHGDECHHH().SetVector("settings.enablehitsoundsinnormal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1654f, 1379f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.EHDJJANLINB().SetTexture(".GoalProgress", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x0000E8C6 File Offset: 0x0000CAC6
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x0000E8FD File Offset: 0x0000CAFD
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/AAA_WaterDrop") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Colors_Threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x0000E936 File Offset: 0x0000CB36
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Shadow") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x0000E96F File Offset: 0x0000CB6F
	private void FMFNILJIEIA()
	{
		this.FPHEBLMINDA = (Resources.Load("shader.future") as Texture2D);
		this.SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x0000420A File Offset: 0x0000240A
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("player.currentrank") as Texture2D);
		this.SCShader = Shader.Find("VisionBlur");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x000F98EC File Offset: 0x000F7AEC
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1786f)
			{
				this.HBJJOCHGOPH = 1783f;
			}
			this.FLOHGDECHHH().SetFloat("?", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", this.Fade);
			this.NFMGLIKNOOC().SetFloat("maps.", this._Near);
			this.FGENHBKMPDA().SetFloat("#close", this._Far);
			this.EHDJJANLINB().SetColor("SpeedSlider", this.FogColor);
			this.NBMPPNFKFLB().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 175f, 249f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.IIBLJCKLGFG().SetTexture("Pop", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x000F9A10 File Offset: 0x000F7C10
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 340f)
			{
				this.HBJJOCHGOPH = 410f;
			}
			this.NBMPPNFKFLB().SetFloat("NetworkPeer broke!", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("EnableRankingToggle", this.Fade);
			this.OOMFJGPAOKL().SetFloat("offsets", this._Near);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Color_YUV", this._Far);
			this.EHDJJANLINB().SetColor("?", this.FogColor);
			this.NBMPPNFKFLB().SetVector("CameraFilterPack/Alien_Vision", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1419f, 1154f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.ADGHJOHKEHG().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x000F9B34 File Offset: 0x000F7D34
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 986f)
			{
				this.HBJJOCHGOPH = 631f;
			}
			this.MICHFGAOPKM().SetFloat("#EA4137", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_Value4", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Mouse0", this._Near);
			this.HNICHJCGJOC().SetFloat("ArcsDestroyDelaySlider", this._Far);
			this.JLHLHKPHDFO().SetColor("_TimeX", this.FogColor);
			this.FGENHBKMPDA().SetVector("SetPosition", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 683f, 1906f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.NBPKMLMCHFN.SetTexture("Screenshots only supported in PlayMode", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x0000E9E1 File Offset: 0x0000CBE1
	private void MMOKKAPFGAK()
	{
		this.FPHEBLMINDA = (Resources.Load("LoadMapCanvas") as Texture2D);
		this.SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x0000EA1A File Offset: 0x0000CC1A
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x000F9C58 File Offset: 0x000F7E58
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 640f)
			{
				this.HBJJOCHGOPH = 1287f;
			}
			this.JLHLHKPHDFO().SetFloat("#outdatedmap! Challenges will not work!", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("UseFinalGlassColor", this.Fade);
			this.NFMGLIKNOOC().SetFloat("Vertical", this._Near);
			this.EMDFHOKEGNG().SetFloat("_Value", this._Far);
			this.ADGHJOHKEHG().SetColor("EditMenu", this.FogColor);
			this.OOMFJGPAOKL().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 670f, 905f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.MICHFGAOPKM().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMADKINICIN()
	{
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x000F9D7C File Offset: 0x000F7F7C
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1365f)
			{
				this.HBJJOCHGOPH = 1174f;
			}
			this.IGKFMCPDNOI().SetFloat("open", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("Other", this.Fade);
			this.IIBLJCKLGFG().SetFloat("_AxialAberration", this._Near);
			this.FLOHGDECHHH().SetFloat("PUN-instantiated '", this._Far);
			this.NBMPPNFKFLB().SetColor("menu.enableselectormusic", this.FogColor);
			this.KEMAALEODNH().SetVector("_WhiteBalance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1939f, 1428f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.FGENHBKMPDA().SetTexture("NewIconFileSelector", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x000F9EA0 File Offset: 0x000F80A0
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 491f)
			{
				this.HBJJOCHGOPH = 1884f;
			}
			this.IIJMIPBMMBF().SetFloat("menu.relaxinfo", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("Hidden/Subpixel Morphological Anti-aliasing", this.Fade);
			this.IIBLJCKLGFG().SetFloat("Events Moved", this._Near);
			this.NFMGLIKNOOC().SetFloat("_Value", this._Far);
			this.KEMAALEODNH().SetColor("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.FogColor);
			this.IONHGBPGCHK().SetVector("IconFileSelector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1588f, 1533f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.JLHLHKPHDFO().SetTexture("[Down]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x0000EA51 File Offset: 0x0000CC51
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load(" has no method \"") as Texture2D);
		this.SCShader = Shader.Find("name");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x0000EA8A File Offset: 0x0000CC8A
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("SetSpeed") as Texture2D);
		this.SCShader = Shader.Find("SetParticlesEmission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x0000EAC3 File Offset: 0x0000CCC3
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x0000420A File Offset: 0x0000240A
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x0000420A File Offset: 0x0000240A
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x0000EAFA File Offset: 0x0000CCFA
	private void DFFKKLAPHCC()
	{
		this.FPHEBLMINDA = (Resources.Load("challenges.") as Texture2D);
		this.SCShader = Shader.Find("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x0000420A File Offset: 0x0000240A
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x0000EB33 File Offset: 0x0000CD33
	private void LFAFJKJAEEL()
	{
		this.FPHEBLMINDA = (Resources.Load("#done") as Texture2D);
		this.SCShader = Shader.Find("_OcclusionBlurTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x0000420A File Offset: 0x0000240A
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x0000EB6C File Offset: 0x0000CD6C
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("speed") as Texture2D);
		this.SCShader = Shader.Find("ConnectUsingSettings() disabled the offline mode. No longer offline.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x0000EBA5 File Offset: 0x0000CDA5
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("/GetNews/pinnednewsid") as Texture2D);
		this.SCShader = Shader.Find("_ExtraColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x0000420A File Offset: 0x0000240A
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x0000EBDE File Offset: 0x0000CDDE
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x000F9FC4 File Offset: 0x000F81C4
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1932f)
			{
				this.HBJJOCHGOPH = 936f;
			}
			this.OHKGGPFGLFD().SetFloat("/", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("OPEN", this.Fade);
			this.IIBLJCKLGFG().SetFloat("RecieveChatActionMessage", this._Near);
			this.IIBLJCKLGFG().SetFloat("_Distortion", this._Far);
			this.HNICHJCGJOC().SetColor("CameraFilterPack_Sweater", this.FogColor);
			this.IONHGBPGCHK().SetVector("Gameplay/Base", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 814f, 1613f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.EMDFHOKEGNG().SetTexture("ResourceIDInputField", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x0000EC15 File Offset: 0x0000CE15
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x0000EC4C File Offset: 0x0000CE4C
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x0000EC83 File Offset: 0x0000CE83
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x0000ECBA File Offset: 0x0000CEBA
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Size") as Texture2D);
		this.SCShader = Shader.Find("ScrollPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x0000ECF3 File Offset: 0x0000CEF3
	private void AKHCOBHHGJP()
	{
		this.FPHEBLMINDA = (Resources.Load(">") as Texture2D);
		this.SCShader = Shader.Find("SpectateButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0000ED2C File Offset: 0x0000CF2C
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x000FA0E8 File Offset: 0x000F82E8
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 1488f;
			}
			this.OHKGGPFGLFD().SetFloat("settings.shaders.bloomintencity", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("Can't set MaxPlayers when not in that room.", this.Fade);
			this.FGENHBKMPDA().SetFloat("_MainTex2", this._Near);
			this.EHDJJANLINB().SetFloat("Gameplay/Base", this._Far);
			this.FEAEGGCNIAA().SetColor("_Value3", this.FogColor);
			this.NLFJGMBCICG().SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1071f, 1755f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.NFMGLIKNOOC().SetTexture("?", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x000FA20C File Offset: 0x000F840C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1105f)
			{
				this.HBJJOCHGOPH = 1510f;
			}
			this.FKEOGPDLBDD().SetFloat("[PlayerBase] MapEnd error: ", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("</color>", this.Fade);
			this.FGENHBKMPDA().SetFloat("_Distortion", this._Near);
			this.CECJJMKLEAK().SetFloat("_Color2", this._Far);
			this.OOMFJGPAOKL().SetColor(" BETA", this.FogColor);
			this.FGENHBKMPDA().SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 819f, 1763f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.FKEOGPDLBDD().SetTexture(" key(s)", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0000ED63 File Offset: 0x0000CF63
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value5") as Texture2D);
		this.SCShader = Shader.Find("_SunThreshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x000FA330 File Offset: 0x000F8530
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 687f)
			{
				this.HBJJOCHGOPH = 934f;
			}
			this.OOMFJGPAOKL().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("resource", this.Fade);
			this.OOMFJGPAOKL().SetFloat("_MainTex2", this._Near);
			this.OHKGGPFGLFD().SetFloat("appid", this._Far);
			this.FKEOGPDLBDD().SetColor("CameraFilterPack_Glasses_On6", this.FogColor);
			this.ADGHJOHKEHG().SetVector("MenuRecordButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1542f, 417f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.DKNJGHFLAIF().SetTexture(": ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0000ED9C File Offset: 0x0000CF9C
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

	// Token: 0x06000DA6 RID: 3494 RVA: 0x0000EDD3 File Offset: 0x0000CFD3
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x000FA4A8 File Offset: 0x000F86A8
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1329f)
			{
				this.HBJJOCHGOPH = 121f;
			}
			this.IGKFMCPDNOI().SetFloat("_History4LumaTex", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this.Fade);
			this.NBMPPNFKFLB().SetFloat("_Value5", this._Near);
			this.FKEOGPDLBDD().SetFloat("_TimeX", this._Far);
			this.JLHLHKPHDFO().SetColor("_TimeX", this.FogColor);
			this.IIBLJCKLGFG().SetVector("CameraFilterPack/Color_Switching", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 526f, 123f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.FKEOGPDLBDD().SetTexture("_FixDistance", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x0000EE0A File Offset: 0x0000D00A
	private void MJEFMIPLFAB()
	{
		this.FPHEBLMINDA = (Resources.Load("_History3Weight") as Texture2D);
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x0000E5F3 File Offset: 0x0000C7F3
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x0000420A File Offset: 0x0000240A
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x0000420A File Offset: 0x0000240A
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x0000EE43 File Offset: 0x0000D043
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Fog");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x0000EE7C File Offset: 0x0000D07C
	private void FEKECCBFGMI()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x0000EEB5 File Offset: 0x0000D0B5
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x0000EEEC File Offset: 0x0000D0EC
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040001FC RID: 508
	public Shader SCShader;

	// Token: 0x040001FD RID: 509
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001FE RID: 510
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001FF RID: 511
	private Material BJFKDHHMLJH;

	// Token: 0x04000200 RID: 512
	[Range(0f, 1f)]
	public float _Near;

	// Token: 0x04000201 RID: 513
	[Range(0f, 1f)]
	public float _Far = 0.05f;

	// Token: 0x04000202 RID: 514
	public Color FogColor = new Color(0.4f, 0.4f, 0.4f, 1f);

	// Token: 0x04000203 RID: 515
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000204 RID: 516
	public static Color ChangeColorRGB;

	// Token: 0x04000205 RID: 517
	private Texture2D FPHEBLMINDA;
}
