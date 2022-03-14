/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000021 RID: 33
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Fog_Smoke")]
public class CameraFilterPack_3D_Fog_Smoke : MonoBehaviour
{
	// Token: 0x060006AB RID: 1707 RVA: 0x00006746 File Offset: 0x00004946
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load(".sav") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x0000677F File Offset: 0x0000497F
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x000D7470 File Offset: 0x000D5670
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1318f)
			{
				this.HBJJOCHGOPH = 841f;
			}
			this.NBPKMLMCHFN.SetFloat("#,0.00", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1182f)
				{
					this._Distance = 1046f;
				}
				if (this._Distance < 987f)
				{
					this._Distance = 1652f;
				}
				this.GCDFNHMJMIP().SetFloat("InstantiateRpc", this._Distance);
			}
			else
			{
				this.ADBKPGFMNKO().SetFloat("ItemNameText", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("#ok", this._Size);
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/3D_Mirror", (float)((!this._Visualize) ? 1 : 0));
			this.EFDEIFCDAFG().SetFloat("_Value", this._FixDistance);
			this.HHIAIGCAHDA().SetFloat("Set sun audio input", this.DistortionLevel * 1672f);
			this.HCGJCMDJPGD().SetFloat("PublishButton", this.DistortionSize * 1147f);
			this.NDMPCDHADMJ().SetFloat("_BokehParams", this.LightIntensity * 221f);
			this.KAFBNOBOIAJ().SetTexture("VIGNETTE_BLUR", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("_Val2", 1475f / farClipPlane);
			this.AELJLBOJAIL().SetVector("achievements.21.progress", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 807f, 1651f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x0000677F File Offset: 0x0000497F
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x0000679C File Offset: 0x0000499C
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x000067D3 File Offset: 0x000049D3
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x0000420A File Offset: 0x0000240A
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x0000680A File Offset: 0x00004A0A
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x0000677F File Offset: 0x0000497F
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x0000677F File Offset: 0x0000497F
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x0000677F File Offset: 0x0000497F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00006841 File Offset: 0x00004A41
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00006878 File Offset: 0x00004A78
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x0000677F File Offset: 0x0000497F
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x000068AF File Offset: 0x00004AAF
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x000D76F8 File Offset: 0x000D58F8
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 299f)
			{
				this.HBJJOCHGOPH = 1115f;
			}
			this.EFDEIFCDAFG().SetFloat("getfloat", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1604f)
				{
					this._Distance = 207f;
				}
				if (this._Distance < 1563f)
				{
					this._Distance = 20f;
				}
				this.JIBOKBCPDLC().SetFloat("_AdaptationSpeed", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("_Value2", this._Distance);
			}
			this.JIBOKBCPDLC().SetFloat("-1", this._Size);
			this.LPMLLJKMAMP().SetFloat("/", (float)((!this._Visualize) ? 0 : 0));
			this.NBPKMLMCHFN.SetFloat("_Value", this._FixDistance);
			this.HCGJCMDJPGD().SetFloat("X", this.DistortionLevel * 166f);
			this.GCDFNHMJMIP().SetFloat("Left Stick Click", this.DistortionSize * 508f);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack_3D_Myst1", this.LightIntensity * 397f);
			this.HCGJCMDJPGD().SetTexture("CameraFilterPack/Deep_OilPaintHQ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KAFBNOBOIAJ().SetFloat("cancel", 1013f / farClipPlane);
			this.KAFBNOBOIAJ().SetVector("' ping: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 400f, 1463f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x000068E8 File Offset: 0x00004AE8
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Myst1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x0000677F File Offset: 0x0000497F
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00006921 File Offset: 0x00004B21
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("Connected to NameServer.") as Texture2D);
		this.SCShader = Shader.Find("#status");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x0000695A File Offset: 0x00004B5A
	private void KLILJHJNICK()
	{
		this.FPHEBLMINDA = (Resources.Load("[") as Texture2D);
		this.SCShader = Shader.Find("player.goldlollipop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00006993 File Offset: 0x00004B93
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060006C4 RID: 1732 RVA: 0x000069CA File Offset: 0x00004BCA
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

	// Token: 0x060006C5 RID: 1733 RVA: 0x0000420A File Offset: 0x0000240A
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0000420A File Offset: 0x0000240A
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x0000420A File Offset: 0x0000240A
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00006A01 File Offset: 0x00004C01
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x0000677F File Offset: 0x0000497F
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x000D7914 File Offset: 0x000D5B14
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1499f)
			{
				this.HBJJOCHGOPH = 250f;
			}
			this.EPCGJFCCAFH().SetFloat("winter2020", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 883f)
				{
					this._Distance = 1666f;
				}
				if (this._Distance < 893f)
				{
					this._Distance = 168f;
				}
				this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this._Distance);
			}
			else
			{
				this.HCGJCMDJPGD().SetFloat("_ChangeBlue", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("offsets", this._Size);
			this.KAFBNOBOIAJ().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 1));
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/TV_Distorted", this._FixDistance);
			this.JIBOKBCPDLC().SetFloat(" not exist", this.DistortionLevel * 1185f);
			this.NBPKMLMCHFN.SetFloat("Hex value #RRGGBB", this.DistortionSize * 1955f);
			this.NBPKMLMCHFN.SetFloat(": ", this.LightIntensity * 748f);
			this.HCGJCMDJPGD().SetTexture("GameMessagesDurationSlider", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("PunRespawn", 1131f / farClipPlane);
			this.JIBOKBCPDLC().SetVector("[MenuScene] Error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 75f, 1002f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x0000420A File Offset: 0x0000240A
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x0000420A File Offset: 0x0000240A
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x000D7B30 File Offset: 0x000D5D30
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 635f)
			{
				this.HBJJOCHGOPH = 94f;
			}
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack_Paper2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 446f)
				{
					this._Distance = 547f;
				}
				if (this._Distance < 608f)
				{
					this._Distance = 1430f;
				}
				this.JIBOKBCPDLC().SetFloat("_ReflectionBufferSize", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("Cancel", this._Distance);
			}
			this.AELJLBOJAIL().SetFloat("#accuracy", this._Size);
			this.IIJMIPBMMBF().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 0));
			this.ACHNOHCLGOO().SetFloat("[EditorEvent] Exception: ", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("stretchWidth", this.DistortionLevel * 1884f);
			this.NBPKMLMCHFN.SetFloat("sounds/hit_perfect", this.DistortionSize * 327f);
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", this.LightIntensity * 1614f);
			this.LPMLLJKMAMP().SetTexture("CHROMATIC_ABERRATION", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("_BilateralUpsampling", 1480f / farClipPlane);
			this.KAFBNOBOIAJ().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 629f, 1827f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x0000677F File Offset: 0x0000497F
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00006A38 File Offset: 0x00004C38
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("{0}{1}{2}") as Texture2D);
		this.SCShader = Shader.Find("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x0000420A File Offset: 0x0000240A
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x0000677F File Offset: 0x0000497F
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x0000677F File Offset: 0x0000497F
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00006A71 File Offset: 0x00004C71
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00006AAA File Offset: 0x00004CAA
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00006AE1 File Offset: 0x00004CE1
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x000D7D4C File Offset: 0x000D5F4C
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
				{
					this._Distance = 1f;
				}
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel * 28f);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize * 16f);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
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

	// Token: 0x060006D9 RID: 1753 RVA: 0x00006B18 File Offset: 0x00004D18
	private void FBPHNEJBDJN()
	{
		this.FPHEBLMINDA = (Resources.Load("challenges.") as Texture2D);
		this.SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00006841 File Offset: 0x00004A41
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x000D7F68 File Offset: 0x000D6168
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 855f)
			{
				this.HBJJOCHGOPH = 1234f;
			}
			this.HHIAIGCAHDA().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1265f)
				{
					this._Distance = 1921f;
				}
				if (this._Distance < 531f)
				{
					this._Distance = 1921f;
				}
				this.GCDFNHMJMIP().SetFloat("player.xp", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("r", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat(":</b> ", this._Size);
			this.ADBKPGFMNKO().SetFloat("input", (float)((!this._Visualize) ? 1 : 0));
			this.HFBJAOFLCJI().SetFloat("/music", this._FixDistance);
			this.KAFBNOBOIAJ().SetFloat("colorC", this.DistortionLevel * 68f);
			this.ADBKPGFMNKO().SetFloat(": ", this.DistortionSize * 1145f);
			this.MMOODGIODPC().SetFloat("maps.", this.LightIntensity * 262f);
			this.HCGJCMDJPGD().SetTexture("z", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("[Left]", 1279f / farClipPlane);
			this.AELJLBOJAIL().SetVector("EXCEPTION:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 155f, 418f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00006B51 File Offset: 0x00004D51
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("float,0") as Texture2D);
		this.SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00006B8A File Offset: 0x00004D8A
	private void DKGBFNCOAEO()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.playedpage") as Texture2D);
		this.SCShader = Shader.Find("NetworkScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00006BC3 File Offset: 0x00004DC3
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("Mouse ") as Texture2D);
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x0000420A File Offset: 0x0000240A
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00006BFC File Offset: 0x00004DFC
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00006C33 File Offset: 0x00004E33
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("FileMenu") as Texture2D);
		this.SCShader = Shader.Find(" isInactive: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x0000677F File Offset: 0x0000497F
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x0000677F File Offset: 0x0000497F
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x000D8184 File Offset: 0x000D6384
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 462f)
			{
				this.HBJJOCHGOPH = 1010f;
			}
			this.ACHNOHCLGOO().SetFloat("/", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 623f)
				{
					this._Distance = 1106f;
				}
				if (this._Distance < 76f)
				{
					this._Distance = 801f;
				}
				this.EPCGJFCCAFH().SetFloat("</size>", this._Distance);
			}
			else
			{
				this.EFDEIFCDAFG().SetFloat("position", this._Distance);
			}
			this.JIBOKBCPDLC().SetFloat("settings_bindings_sec_", this._Size);
			this.LPMLLJKMAMP().SetFloat("_ReflectionTexture0", (float)((!this._Visualize) ? 0 : 0));
			this.HHIAIGCAHDA().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this._FixDistance);
			this.HHIAIGCAHDA().SetFloat("Drop_With_Obj", this.DistortionLevel * 1282f);
			this.MMOODGIODPC().SetFloat("_EmissionColor", this.DistortionSize * 656f);
			this.HCGJCMDJPGD().SetFloat("menu.hardcoreinfo", this.LightIntensity * 690f);
			this.ACHNOHCLGOO().SetTexture("_FixDistance", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", 1887f / farClipPlane);
			this.GCDFNHMJMIP().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 720f, 887f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x0000420A File Offset: 0x0000240A
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x000D83A0 File Offset: 0x000D65A0
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 766f)
			{
				this.HBJJOCHGOPH = 1905f;
			}
			this.EFDEIFCDAFG().SetFloat("Editor/", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 604f)
				{
					this._Distance = 4f;
				}
				if (this._Distance < 810f)
				{
					this._Distance = 366f;
				}
				this.ADBKPGFMNKO().SetFloat("_MainTex2", this._Distance);
			}
			else
			{
				this.ADBKPGFMNKO().SetFloat(".r", this._Distance);
			}
			this.EFDEIFCDAFG().SetFloat("_TimeX", this._Size);
			this.ACHNOHCLGOO().SetFloat(".lastCheckpoint.time", (float)((!this._Visualize) ? 1 : 1));
			this.ADBKPGFMNKO().SetFloat("SAVE FILE", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("#close", this.DistortionLevel * 334f);
			this.HHIAIGCAHDA().SetFloat("/", this.DistortionSize * 874f);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Color_GrayScale", this.LightIntensity * 1891f);
			this.EPCGJFCCAFH().SetTexture(". Check if the server is available.", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("settings.fps", 471f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("_Radius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 23f, 604f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00006C6C File Offset: 0x00004E6C
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00006CA3 File Offset: 0x00004EA3
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x0000420A File Offset: 0x0000240A
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00006CDA File Offset: 0x00004EDA
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("Clears the console and prints the logs in the specified range") as Texture2D);
		this.SCShader = Shader.Find("SupportLogger OnJoinedLobby(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00006D13 File Offset: 0x00004F13
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x0000677F File Offset: 0x0000497F
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00006D4A File Offset: 0x00004F4A
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load(".highscore") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00006D83 File Offset: 0x00004F83
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000113 RID: 275
	public Shader SCShader;

	// Token: 0x04000114 RID: 276
	public bool _Visualize;

	// Token: 0x04000115 RID: 277
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000116 RID: 278
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000117 RID: 279
	private Material BJFKDHHMLJH;

	// Token: 0x04000118 RID: 280
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x04000119 RID: 281
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	// Token: 0x0400011A RID: 282
	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	// Token: 0x0400011B RID: 283
	[Range(0f, 10f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x0400011C RID: 284
	[Range(0.1f, 10f)]
	public float DistortionSize = 1.4f;

	// Token: 0x0400011D RID: 285
	[Range(-2f, 4f)]
	public float LightIntensity = 0.08f;

	// Token: 0x0400011E RID: 286
	public bool AutoAnimatedNear;

	// Token: 0x0400011F RID: 287
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000120 RID: 288
	private Texture2D FPHEBLMINDA;

	// Token: 0x04000121 RID: 289
	public static Color ChangeColorRGB;
}
