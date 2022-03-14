/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Super Hexagon")]
public class CameraFilterPack_AAA_SuperHexagon : MonoBehaviour
{
	// Token: 0x06000BD9 RID: 3033 RVA: 0x000F3C0C File Offset: 0x000F1E0C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1632f)
			{
				this.HBJJOCHGOPH = 1703f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("PossibleMapPointsText", this.HexaSize);
			this.KGOLDDBHIFN().SetFloat("\nCreated by Oxy949", this.center.x);
			this.IONHGBPGCHK().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", this.center.y);
			this.IONHGBPGCHK().SetFloat("#{0:00}{1}{2}", this.Radius);
			this.IONHGBPGCHK().SetFloat("MessageText", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("_Blue_R", this._BorderColor);
			this.KGOLDDBHIFN().SetColor("StartButton", this._HexaColor);
			this.IONHGBPGCHK().SetFloat("_ScreenResolution", this._AlphaHexa);
			this.KGOLDDBHIFN().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", this._SpotSize);
			this.KGOLDDBHIFN().SetVector(".lastCheckpoint.playerdistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1426f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x0000CC00 File Offset: 0x0000AE00
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x0000CC00 File Offset: 0x0000AE00
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x000F3D84 File Offset: 0x000F1F84
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 73f)
			{
				this.HBJJOCHGOPH = 667f;
			}
			this.NBPKMLMCHFN.SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("VisionBlur", this.HexaSize);
			this.IONHGBPGCHK().SetFloat(": ", this.center.x);
			this.KGOLDDBHIFN().SetFloat("Left Click", this.center.y);
			this.NBPKMLMCHFN.SetFloat("SetEnvSpriteColor", this.Radius);
			this.NBPKMLMCHFN.SetFloat("11", this._BorderSize);
			this.KGOLDDBHIFN().SetColor("setAF", this._BorderColor);
			this.KGOLDDBHIFN().SetColor("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", this._HexaColor);
			this.KGOLDDBHIFN().SetFloat("ns.exitgames.com", this._AlphaHexa);
			this.IONHGBPGCHK().SetFloat("]", this._SpotSize);
			this.IONHGBPGCHK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1444f, 103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0000CC1D File Offset: 0x0000AE1D
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

	// Token: 0x06000BDE RID: 3038 RVA: 0x000F3EFC File Offset: 0x000F20FC
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 145f)
			{
				this.HBJJOCHGOPH = 1275f;
			}
			this.IONHGBPGCHK().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_FishEye", this.HexaSize);
			this.NBPKMLMCHFN.SetFloat("#,0.00", this.center.x);
			this.IONHGBPGCHK().SetFloat("_FixDistance", this.center.y);
			this.IONHGBPGCHK().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Radius);
			this.KGOLDDBHIFN().SetFloat("_BorderColor", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("_Blue_C", this._BorderColor);
			this.KGOLDDBHIFN().SetColor("_Value2", this._HexaColor);
			this.NBPKMLMCHFN.SetFloat("_Bloom", this._AlphaHexa);
			this.NBPKMLMCHFN.SetFloat("_Offsets", this._SpotSize);
			this.IONHGBPGCHK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 354f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x0000CC54 File Offset: 0x0000AE54
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Super_Hexagon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x0000CC78 File Offset: 0x0000AE78
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x000F4074 File Offset: 0x000F2274
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.HexaSize);
			this.NBPKMLMCHFN.SetFloat("_PositionX", this.center.x);
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.center.y);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Radius);
			this.NBPKMLMCHFN.SetFloat("_BorderSize", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("_BorderColor", this._BorderColor);
			this.NBPKMLMCHFN.SetColor("_HexaColor", this._HexaColor);
			this.NBPKMLMCHFN.SetFloat("_AlphaHexa", this._AlphaHexa);
			this.NBPKMLMCHFN.SetFloat("_SpotSize", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x0000CCAF File Offset: 0x0000AEAF
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x000F41EC File Offset: 0x000F23EC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 617f)
			{
				this.HBJJOCHGOPH = 1924f;
			}
			this.KGOLDDBHIFN().SetFloat("_Value", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("LeaderboardsButton", this.HexaSize);
			this.IONHGBPGCHK().SetFloat("SetScale", this.center.x);
			this.NBPKMLMCHFN.SetFloat("Color's hex value #RRGGBBAA", this.center.y);
			this.KGOLDDBHIFN().SetFloat("Source Object: ", this.Radius);
			this.KGOLDDBHIFN().SetFloat("_Value2", this._BorderSize);
			this.IONHGBPGCHK().SetColor("_Dist", this._BorderColor);
			this.NBPKMLMCHFN.SetColor(" methods \"", this._HexaColor);
			this.KGOLDDBHIFN().SetFloat("id", this._AlphaHexa);
			this.IONHGBPGCHK().SetFloat(" - {0}", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1678f, 431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x0000CC00 File Offset: 0x0000AE00
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x0000CC00 File Offset: 0x0000AE00
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x000F4364 File Offset: 0x000F2564
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 8f)
			{
				this.HBJJOCHGOPH = 1379f;
			}
			this.KGOLDDBHIFN().SetFloat("settings.showHP", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_Value4", this.HexaSize);
			this.IONHGBPGCHK().SetFloat(",", this.center.x);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.center.y);
			this.NBPKMLMCHFN.SetFloat("_FarCorner", this.Radius);
			this.KGOLDDBHIFN().SetFloat("request", this._BorderSize);
			this.KGOLDDBHIFN().SetColor("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", this._BorderColor);
			this.NBPKMLMCHFN.SetColor("_Amount", this._HexaColor);
			this.IONHGBPGCHK().SetFloat("yyyy", this._AlphaHexa);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack_Paper2", this._SpotSize);
			this.IONHGBPGCHK().SetVector(",viewkeys", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1801f, 1761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x0000CC00 File Offset: 0x0000AE00
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x0000CC00 File Offset: 0x0000AE00
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001D4 RID: 468
	public Shader SCShader;

	// Token: 0x040001D5 RID: 469
	[Range(0f, 1f)]
	public float _AlphaHexa = 1f;

	// Token: 0x040001D6 RID: 470
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001D7 RID: 471
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001D8 RID: 472
	private Material BJFKDHHMLJH;

	// Token: 0x040001D9 RID: 473
	[Range(0.2f, 10f)]
	public float HexaSize = 2.5f;

	// Token: 0x040001DA RID: 474
	public float _BorderSize = 1f;

	// Token: 0x040001DB RID: 475
	public Color _BorderColor = new Color(0.75f, 0.75f, 1f, 1f);

	// Token: 0x040001DC RID: 476
	public Color _HexaColor = new Color(0f, 0.5f, 1f, 1f);

	// Token: 0x040001DD RID: 477
	public float _SpotSize = 2.5f;

	// Token: 0x040001DE RID: 478
	public Vector2 center = new Vector2(0.5f, 0.5f);

	// Token: 0x040001DF RID: 479
	public float Radius = 0.25f;
}
