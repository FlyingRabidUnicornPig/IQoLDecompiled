/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000029 RID: 41
[AddComponentMenu("Camera Filter Pack/3D/Snow")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Snow : MonoBehaviour
{
	// Token: 0x06000A65 RID: 2661 RVA: 0x000ECB68 File Offset: 0x000EAD68
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1783f)
			{
				this.HBJJOCHGOPH = 815f;
			}
			this.IGKFMCPDNOI().SetFloat("]", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("Joystick1Button12", this.Fade);
			this.CECJJMKLEAK().SetFloat("Changed config", this.Intensity);
			this.ADBKPGFMNKO().SetFloat("_Distortion", this.Speed * 957f);
			this.LMLENGFLEBD().SetFloat("System.Int32", this.Size);
			this.HFBJAOFLCJI().SetFloat("Tab2Content", (float)((!this._Visualize) ? 0 : 0));
			this.LMLENGFLEBD().SetFloat("CameraFilterPack/Color_YUV", this._FixDistance);
			this.MCDGIILBNIF().SetFloat("#ok", this.Snow_Near);
			this.HFBJAOFLCJI().SetFloat("ticket", this.Snow_Far);
			this.NBPKMLMCHFN.SetFloat("shader.pixel", this.SnowWithoutObject);
			this.NDMPCDHADMJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1989f, 1905f));
			this.ILKALHDJBFE().SetTexture("_Radius2", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x0000420A File Offset: 0x0000240A
	private void Start()
	{
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x0000420A File Offset: 0x0000240A
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x0000420A File Offset: 0x0000240A
	private void CNGAJDBOCLJ()
	{
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x0000420A File Offset: 0x0000240A
	private void JKBMKPDGCHG()
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKLOBJHKFEO()
	{
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x0000420A File Offset: 0x0000240A
	private void PAKPHKPDKGE()
	{
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x0000B460 File Offset: 0x00009660
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x000ECD84 File Offset: 0x000EAF84
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 907f)
			{
				this.HBJJOCHGOPH = 1210f;
			}
			this.LPPEPKGFOEM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NKBIEMJBCBM().SetFloat("_ScreenResolution", this.Fade);
			this.OCHJIMJNEMO().SetFloat("SetSpeed", this.Intensity);
			this.BKKJJJGADLM().SetFloat("_EdgeSize", this.Speed * 1813f);
			this.IGKFMCPDNOI().SetFloat("Joined room ", this.Size);
			this.MMOODGIODPC().SetFloat("PunSupportLogger", (float)((!this._Visualize) ? 1 : 1));
			this.IOHHLNAPGMA().SetFloat(": ", this._FixDistance);
			this.MMOODGIODPC().SetFloat("_TimeX", this.Snow_Near);
			this.MMOODGIODPC().SetFloat("_TimeX", this.Snow_Far);
			this.KLKILLCHJHO().SetFloat("_EmissionColor", this.SnowWithoutObject);
			this.DOHGBNPMBKG().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 159f, 1657f));
			this.LPPEPKGFOEM().SetTexture(" ", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x0000B497 File Offset: 0x00009697
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x000ECF28 File Offset: 0x000EB128
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 9f)
			{
				this.HBJJOCHGOPH = 502f;
			}
			this.IGKFMCPDNOI().SetFloat("settings.enablerankingnotifications", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("{0:0} minute{1}, ", this.Fade);
			this.HHIFMIPPMPF().SetFloat("GlassAberration", this.Intensity);
			this.FEAEGGCNIAA().SetFloat("Tab1Content", this.Speed * 24f);
			this.ILKALHDJBFE().SetFloat("_TimeX", this.Size);
			this.KLKILLCHJHO().SetFloat("_VignetteBlur", (float)((!this._Visualize) ? 1 : 0));
			this.ADBKPGFMNKO().SetFloat("ItemNameBGImage", this._FixDistance);
			this.NDMPCDHADMJ().SetFloat("_TimeX", this.Snow_Near);
			this.INOBFNCKFGK().SetFloat("Spawn ark to be pressed at this time", this.Snow_Far);
			this.LMLENGFLEBD().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", this.SnowWithoutObject);
			this.MCDGIILBNIF().SetVector("Oct", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1974f, 1079f));
			this.LMLENGFLEBD().SetTexture("_Red_G", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x0000420A File Offset: 0x0000240A
	private void DAHFFNNIGML()
	{
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x000ED0CC File Offset: 0x000EB2CC
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1010f)
			{
				this.HBJJOCHGOPH = 213f;
			}
			this.FAIFBBGFAIB().SetFloat("_ChannelMixerRed", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_Value2", this.Fade);
			this.NDMPCDHADMJ().SetFloat("menu.resetlevelcheckpoint", this.Intensity);
			this.HHIAIGCAHDA().SetFloat("Please wait..", this.Speed * 305f);
			this.BAGICADFBAB().SetFloat("_Far", this.Size);
			this.ACHNOHCLGOO().SetFloat("_FarCamera", (float)((!this._Visualize) ? 0 : 1));
			this.HFBJAOFLCJI().SetFloat("master", this._FixDistance);
			this.MMOODGIODPC().SetFloat("_Bullet_8", this.Snow_Near);
			this.HKHBBBFLGJH().SetFloat("/", this.Snow_Far);
			this.MMOODGIODPC().SetFloat(" GameServer:", this.SnowWithoutObject);
			this.FAIFBBGFAIB().SetVector("#forever", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1524f, 1059f));
			this.LMLENGFLEBD().SetTexture("Tab1Content", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x0000420A File Offset: 0x0000240A
	private void NKFDNIAKGEO()
	{
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x0000420A File Offset: 0x0000240A
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x0000420A File Offset: 0x0000240A
	private void AGEJKLMJGDO()
	{
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x000ED270 File Offset: 0x000EB470
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed * 6f);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Drop_Near", this.Snow_Near);
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.Snow_Far);
			this.NBPKMLMCHFN.SetFloat("Drop_With_Obj", this.SnowWithoutObject);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x0000B4EB File Offset: 0x000096EB
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x0000420A File Offset: 0x0000240A
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x0000420A File Offset: 0x0000240A
	private void MGMAOBPPOBJ()
	{
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x0000420A File Offset: 0x0000240A
	private void DKOPKPBLDHH()
	{
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x0000B522 File Offset: 0x00009722
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x0000B559 File Offset: 0x00009759
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x000ED414 File Offset: 0x000EB614
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 152f)
			{
				this.HBJJOCHGOPH = 1664f;
			}
			this.HFBJAOFLCJI().SetFloat("[SteamManager] Connecting to server", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("System.Int32", this.Fade);
			this.NDMPCDHADMJ().SetFloat("InfoCanvas", this.Intensity);
			this.NFMGLIKNOOC().SetFloat("custom", this.Speed * 1739f);
			this.HKHBBBFLGJH().SetFloat(":", this.Size);
			this.HHIFMIPPMPF().SetFloat("_Distortion", (float)((!this._Visualize) ? 1 : 0));
			this.HKHBBBFLGJH().SetFloat("SetSatelliteLerpSpeed", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("/?player=", this.Snow_Near);
			this.KLKILLCHJHO().SetFloat("_TimeX", this.Snow_Far);
			this.BAGICADFBAB().SetFloat("_Val", this.SnowWithoutObject);
			this.NDMPCDHADMJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 321f, 36f));
			this.DOHGBNPMBKG().SetTexture("Exit to Windows", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x0000B590 File Offset: 0x00009790
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x0000420A File Offset: 0x0000240A
	private void FANADGBGCPI()
	{
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x0000420A File Offset: 0x0000240A
	private void EFJDNLGNACH()
	{
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x0000420A File Offset: 0x0000240A
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x0000420A File Offset: 0x0000240A
	private void JKFDDNMPOJH()
	{
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x0000420A File Offset: 0x0000240A
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x0000420A File Offset: 0x0000240A
	private void HMKBLLMIKAB()
	{
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x0000420A File Offset: 0x0000240A
	private void IKDNLHLBHID()
	{
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0000420A File Offset: 0x0000240A
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0000420A File Offset: 0x0000240A
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0000420A File Offset: 0x0000240A
	private void JECMJNFGBGC()
	{
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x000ED5B8 File Offset: 0x000EB7B8
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1029f)
			{
				this.HBJJOCHGOPH = 1245f;
			}
			this.NDMPCDHADMJ().SetFloat("english", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("bool", this.Fade);
			this.NBPKMLMCHFN.SetFloat("local CheckCondition = function()", this.Intensity);
			this.MMOODGIODPC().SetFloat("ok", this.Speed * 1279f);
			this.MMOODGIODPC().SetFloat("_Amount", this.Size);
			this.IOHHLNAPGMA().SetFloat("Joystick1Button3", (float)((!this._Visualize) ? 0 : 0));
			this.HFBJAOFLCJI().SetFloat("id", this._FixDistance);
			this.OCHJIMJNEMO().SetFloat("_TimeX", this.Snow_Near);
			this.HHIFMIPPMPF().SetFloat("_Value", this.Snow_Far);
			this.ADAFMBOGPLN().SetFloat(".GoalProgress", this.SnowWithoutObject);
			this.HHIAIGCAHDA().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 772f, 1965f));
			this.CECJJMKLEAK().SetTexture("_ScreenResolution", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x000ED75C File Offset: 0x000EB95C
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1621f)
			{
				this.HBJJOCHGOPH = 1424f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("_Green_C", this.Fade);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", this.Intensity);
			this.HHIAIGCAHDA().SetFloat("#score", this.Speed * 1565f);
			this.IOHHLNAPGMA().SetFloat("Fade", this.Size);
			this.BKKJJJGADLM().SetFloat("[Right]", (float)((!this._Visualize) ? 0 : 0));
			this.MCDGIILBNIF().SetFloat("offline", this._FixDistance);
			this.DOHGBNPMBKG().SetFloat("[Singleton] An instance of '", this.Snow_Near);
			this.MCDGIILBNIF().SetFloat("_TimeX", this.Snow_Far);
			this.HHIAIGCAHDA().SetFloat("_TimeX", this.SnowWithoutObject);
			this.NKBIEMJBCBM().SetVector("_Axis", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1763f, 679f));
			this.IGKFMCPDNOI().SetTexture("workshop.", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x000ED900 File Offset: 0x000EBB00
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 227f)
			{
				this.HBJJOCHGOPH = 1425f;
			}
			this.ADBKPGFMNKO().SetFloat("_DiffuseColor", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("Failed to InstantiateSceneObject prefab: ", this.Fade);
			this.IOHHLNAPGMA().SetFloat("_MainTex", this.Intensity);
			this.HHIFMIPPMPF().SetFloat("SpawnObj", this.Speed * 1250f);
			this.LMLENGFLEBD().SetFloat("_Value2", this.Size);
			this.DOHGBNPMBKG().SetFloat("/", (float)((!this._Visualize) ? 0 : 1));
			this.DOHGBNPMBKG().SetFloat("Editor/", this._FixDistance);
			this.DOHGBNPMBKG().SetFloat("LevelNameInputField", this.Snow_Near);
			this.CECJJMKLEAK().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", this.Snow_Far);
			this.FAIFBBGFAIB().SetFloat("_Value7", this.SnowWithoutObject);
			this.FEAEGGCNIAA().SetVector("InfoButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1107f, 27f));
			this.DOHGBNPMBKG().SetTexture(" (inactive)", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x0000420A File Offset: 0x0000240A
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x000EDAA4 File Offset: 0x000EBCA4
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 807f)
			{
				this.HBJJOCHGOPH = 1876f;
			}
			this.NBPKMLMCHFN.SetFloat("0,7,true,0", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat(".sav", this.Fade);
			this.KLKILLCHJHO().SetFloat("_TimeX", this.Intensity);
			this.CECJJMKLEAK().SetFloat("#yes", this.Speed * 1042f);
			this.FEAEGGCNIAA().SetFloat("Set particles audio input", this.Size);
			this.BKKJJJGADLM().SetFloat("_CenterY", (float)((!this._Visualize) ? 1 : 1));
			this.NDMPCDHADMJ().SetFloat("_ScreenResolution", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("X2", this.Snow_Near);
			this.IGKFMCPDNOI().SetFloat("Lerp speed. Recomended 10", this.Snow_Far);
			this.NKBIEMJBCBM().SetFloat("Down", this.SnowWithoutObject);
			this.FEAEGGCNIAA().SetVector("EditMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 16f, 1744f));
			this.NBPKMLMCHFN.SetTexture("/", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0000B5C7 File Offset: 0x000097C7
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x000EDC48 File Offset: 0x000EBE48
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1524f)
			{
				this.HBJJOCHGOPH = 157f;
			}
			this.BKKJJJGADLM().SetFloat("Ev OwnershipRequest ", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("FPSToggle", this.Fade);
			this.KLKILLCHJHO().SetFloat("MusicFileSelector", this.Intensity);
			this.ILKALHDJBFE().SetFloat("_Value4", this.Speed * 1159f);
			this.MCDGIILBNIF().SetFloat("IconImage", this.Size);
			this.NFMGLIKNOOC().SetFloat("#checkpoint", (float)((!this._Visualize) ? 0 : 0));
			this.ILKALHDJBFE().SetFloat("id", this._FixDistance);
			this.BKKJJJGADLM().SetFloat("_DiffuseColor", this.Snow_Near);
			this.DOHGBNPMBKG().SetFloat("UsernameText", this.Snow_Far);
			this.IOHHLNAPGMA().SetFloat("maps.", this.SnowWithoutObject);
			this.BKKJJJGADLM().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1f, 212f));
			this.HHIAIGCAHDA().SetTexture("_SprTex", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x0000B5FE File Offset: 0x000097FE
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x000EDDEC File Offset: 0x000EBFEC
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 570f)
			{
				this.HBJJOCHGOPH = 897f;
			}
			this.KLKILLCHJHO().SetFloat("#91CCFF", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("_TimeX", this.Fade);
			this.INOBFNCKFGK().SetFloat("#", this.Intensity);
			this.NKBIEMJBCBM().SetFloat("_Value", this.Speed * 536f);
			this.ILKALHDJBFE().SetFloat("CameraFilterPack/Blizzard", this.Size);
			this.KLKILLCHJHO().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", (float)((!this._Visualize) ? 1 : 1));
			this.NFMGLIKNOOC().SetFloat("menu.tabid", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("SaveButton", this.Snow_Near);
			this.HFBJAOFLCJI().SetFloat("_Red_B", this.Snow_Far);
			this.FEAEGGCNIAA().SetFloat("_Value", this.SnowWithoutObject);
			this.KLKILLCHJHO().SetVector(".highscore", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 721f, 1021f));
			this.LMLENGFLEBD().SetTexture("_Radius2", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x0000420A File Offset: 0x0000240A
	private void MKOMIDCPCDC()
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x0000420A File Offset: 0x0000240A
	private void JABNHMIHBHC()
	{
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x000EDF90 File Offset: 0x000EC190
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1060f)
			{
				this.HBJJOCHGOPH = 955f;
			}
			this.MMOODGIODPC().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("action", this.Fade);
			this.IGKFMCPDNOI().SetFloat("SetSatelliteRadius", this.Intensity);
			this.DOHGBNPMBKG().SetFloat("Tab2Content", this.Speed * 1948f);
			this.HHIFMIPPMPF().SetFloat("_Value3", this.Size);
			this.DOHGBNPMBKG().SetFloat("_Red_C", (float)((!this._Visualize) ? 0 : 1));
			this.NDMPCDHADMJ().SetFloat("0 - background, 1 - foreground", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("player.xp", this.Snow_Near);
			this.LPPEPKGFOEM().SetFloat("loadscene", this.Snow_Far);
			this.BAGICADFBAB().SetFloat("#obtained", this.SnowWithoutObject);
			this.HFBJAOFLCJI().SetVector("_CenterRadius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1682f, 1863f));
			this.BKKJJJGADLM().SetTexture(" ownership transfered to: ", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x0000B635 File Offset: 0x00009835
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0000420A File Offset: 0x0000240A
	private void ODBNMPGBCGO()
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x000EE134 File Offset: 0x000EC334
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1711f)
			{
				this.HBJJOCHGOPH = 5f;
			}
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Chromatical", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("Fill Area", this.Fade);
			this.ACHNOHCLGOO().SetFloat("_Amount", this.Intensity);
			this.BAGICADFBAB().SetFloat("StartButton", this.Speed * 1390f);
			this.ACHNOHCLGOO().SetFloat("ScrollPanel", this.Size);
			this.NFMGLIKNOOC().SetFloat("_EdgeThresholdMin", (float)((!this._Visualize) ? 1 : 1));
			this.ILKALHDJBFE().SetFloat("_LightIntensity", this._FixDistance);
			this.INOBFNCKFGK().SetFloat("menutheme.idunno", this.Snow_Near);
			this.LPPEPKGFOEM().SetFloat("CameraFilterPack/Distortion_Heat", this.Snow_Far);
			this.IOHHLNAPGMA().SetFloat("GameScene", this.SnowWithoutObject);
			this.IGKFMCPDNOI().SetVector("_BlurVector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 510f, 1867f));
			this.FEAEGGCNIAA().SetTexture("_ScreenResolution", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x0000420A File Offset: 0x0000240A
	private void DPLLKHHLDBB()
	{
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x0000420A File Offset: 0x0000240A
	private void HJPCJGOEKMF()
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x0000B66C File Offset: 0x0000986C
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0000B6A3 File Offset: 0x000098A3
	private Material NKBIEMJBCBM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x0000420A File Offset: 0x0000240A
	private void HMPGIFBJFIK()
	{
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0000B6DA File Offset: 0x000098DA
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x000EE2D8 File Offset: 0x000EC4D8
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1927f)
			{
				this.HBJJOCHGOPH = 1608f;
			}
			this.ACHNOHCLGOO().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_Value5", this.Fade);
			this.FAIFBBGFAIB().SetFloat("#getrewardfailed: ", this.Intensity);
			this.FEAEGGCNIAA().SetFloat("_Params1", this.Speed * 133f);
			this.DOHGBNPMBKG().SetFloat("SpawnObj", this.Size);
			this.IGKFMCPDNOI().SetFloat("?", (float)((!this._Visualize) ? 0 : 0));
			this.EFMCNLELMDO().SetFloat("_TimeX", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("Arc", this.Snow_Near);
			this.OCHJIMJNEMO().SetFloat("R:", this.Snow_Far);
			this.LMLENGFLEBD().SetFloat("id", this.SnowWithoutObject);
			this.IGKFMCPDNOI().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1474f, 1234f));
			this.NBPKMLMCHFN.SetTexture("SelectorMusicToggle", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x0000B711 File Offset: 0x00009911
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x0000B748 File Offset: 0x00009948
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x0000B77F File Offset: 0x0000997F
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0000420A File Offset: 0x0000240A
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x0000420A File Offset: 0x0000240A
	private void EIMNPCMHJLJ()
	{
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x0000420A File Offset: 0x0000240A
	private void GNJDKAECPKA()
	{
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x000EE47C File Offset: 0x000EC67C
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 771f)
			{
				this.HBJJOCHGOPH = 556f;
			}
			this.MCDGIILBNIF().SetFloat("RecieveChatActionMessage", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("CameraFilterPack/Edge_BlackLine", this.Fade);
			this.IOHHLNAPGMA().SetFloat("Please attach component to a Graphical UI component", this.Intensity);
			this.HKHBBBFLGJH().SetFloat("_Value2", this.Speed * 1476f);
			this.HKHBBBFLGJH().SetFloat("SpawnObj", this.Size);
			this.HKHBBBFLGJH().SetFloat("event", (float)((!this._Visualize) ? 1 : 0));
			this.HKHBBBFLGJH().SetFloat("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", this._FixDistance);
			this.IGKFMCPDNOI().SetFloat("_BlurRadius", this.Snow_Near);
			this.CECJJMKLEAK().SetFloat("Fade", this.Snow_Far);
			this.HKHBBBFLGJH().SetFloat("_Bullet_10", this.SnowWithoutObject);
			this.BKKJJJGADLM().SetVector("ResetButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1462f, 890f));
			this.HHIFMIPPMPF().SetTexture("_FadeFX", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x0000420A File Offset: 0x0000240A
	private void CEDFFAOOPOG()
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x0000B7B6 File Offset: 0x000099B6
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x0000B7ED File Offset: 0x000099ED
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x000EE620 File Offset: 0x000EC820
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 179f)
			{
				this.HBJJOCHGOPH = 787f;
			}
			this.FAIFBBGFAIB().SetFloat(".lastCheckpoint.maxLongestCombo", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("isVisible", this.Fade);
			this.CECJJMKLEAK().SetFloat("_TimeX", this.Intensity);
			this.ADBKPGFMNKO().SetFloat("SetCrosshairColor", this.Speed * 545f);
			this.ADBKPGFMNKO().SetFloat("HiddenToggle", this.Size);
			this.CECJJMKLEAK().SetFloat("#getrewardfailed: ", (float)((!this._Visualize) ? 0 : 1));
			this.FEAEGGCNIAA().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", this._FixDistance);
			this.NFMGLIKNOOC().SetFloat("BitsData", this.Snow_Near);
			this.ACHNOHCLGOO().SetFloat("Set Background Color", this.Snow_Far);
			this.BKKJJJGADLM().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.SnowWithoutObject);
			this.NKBIEMJBCBM().SetVector("Mouse X", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1505f, 817f));
			this.ACHNOHCLGOO().SetTexture(".completed", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x0000420A File Offset: 0x0000240A
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0000420A File Offset: 0x0000240A
	private void ICILLMAKLMI()
	{
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x0000420A File Offset: 0x0000240A
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x0000420A File Offset: 0x0000240A
	private void KDMANOEMOCA()
	{
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x0000B824 File Offset: 0x00009A24
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x0000420A File Offset: 0x0000240A
	private void NCNPAKFAFOE()
	{
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x0000B85B File Offset: 0x00009A5B
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMADKINICIN()
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x0000420A File Offset: 0x0000240A
	private void LIBGAKMKHJJ()
	{
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOHOFNKJDEB()
	{
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x0000420A File Offset: 0x0000240A
	private void DIPDEHOOBPG()
	{
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x0000B892 File Offset: 0x00009A92
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x0000420A File Offset: 0x0000240A
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x0000420A File Offset: 0x0000240A
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x000EE7C4 File Offset: 0x000EC9C4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 556f)
			{
				this.HBJJOCHGOPH = 472f;
			}
			this.ILKALHDJBFE().SetFloat("_Value", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Error: I/O Failure! :(", this.Fade);
			this.MMOODGIODPC().SetFloat("RarityImage", this.Intensity);
			this.CECJJMKLEAK().SetFloat("SetSatelliteRadius", this.Speed * 87f);
			this.OCHJIMJNEMO().SetFloat("Can't set open when not in that room.", this.Size);
			this.KLKILLCHJHO().SetFloat("#submit", (float)((!this._Visualize) ? 1 : 1));
			this.LPPEPKGFOEM().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", this._FixDistance);
			this.HHIAIGCAHDA().SetFloat("_Value", this.Snow_Near);
			this.ACHNOHCLGOO().SetFloat("-", this.Snow_Far);
			this.HFBJAOFLCJI().SetFloat("_Distortion", this.SnowWithoutObject);
			this.ADBKPGFMNKO().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 721f, 193f));
			this.ADBKPGFMNKO().SetTexture("[PlayerBase] Starting game from: ", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x0000B8C9 File Offset: 0x00009AC9
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x0000420A File Offset: 0x0000240A
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x0000B900 File Offset: 0x00009B00
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x000EE968 File Offset: 0x000ECB68
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 243f)
			{
				this.HBJJOCHGOPH = 217f;
			}
			this.FAIFBBGFAIB().SetFloat("#timeuntilchallenge: ", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.Fade);
			this.BKKJJJGADLM().SetFloat("SetSatelliteTrailMinVertexDistance", this.Intensity);
			this.FAIFBBGFAIB().SetFloat("#ok", this.Speed * 786f);
			this.FEAEGGCNIAA().SetFloat("mapselector.filter.subscribedonly", this.Size);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Gradients_Ansi", (float)((!this._Visualize) ? 1 : 1));
			this.MMOODGIODPC().SetFloat("_Value5", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("_Params1", this.Snow_Near);
			this.HHIAIGCAHDA().SetFloat("_VelTex", this.Snow_Far);
			this.MMOODGIODPC().SetFloat("STOP [R]", this.SnowWithoutObject);
			this.HFBJAOFLCJI().SetVector("\"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1653f, 1787f));
			this.NFMGLIKNOOC().SetTexture(" Server: ", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x000EEB0C File Offset: 0x000ECD0C
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1235f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.MCDGIILBNIF().SetFloat("speed", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("VIGNETTE_DESAT", this.Fade);
			this.ADBKPGFMNKO().SetFloat("CountEventsGoal", this.Intensity);
			this.IOHHLNAPGMA().SetFloat("UnityEngine.MonoBehaviour", this.Speed * 666f);
			this.HHIFMIPPMPF().SetFloat("turn", this.Size);
			this.MMOODGIODPC().SetFloat("bad", (float)((!this._Visualize) ? 0 : 0));
			this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this._FixDistance);
			this.BAGICADFBAB().SetFloat("menu.selectedplaymode", this.Snow_Near);
			this.NFMGLIKNOOC().SetFloat("ticket.ticket1", this.Snow_Far);
			this.FAIFBBGFAIB().SetFloat("Failed to 'network-remove' GameObject because has no PhotonView components: ", this.SnowWithoutObject);
			this.CECJJMKLEAK().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 448f, 384f));
			this.LPPEPKGFOEM().SetTexture("_Blue_R", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x000EECB0 File Offset: 0x000ECEB0
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1115f)
			{
				this.HBJJOCHGOPH = 1601f;
			}
			this.IGKFMCPDNOI().SetFloat("_CameraWS", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("editor.", this.Fade);
			this.ILKALHDJBFE().SetFloat("_ColorBuffer", this.Intensity);
			this.NKBIEMJBCBM().SetFloat("Moved event", this.Speed * 1981f);
			this.BKKJJJGADLM().SetFloat("907198288", this.Size);
			this.LPPEPKGFOEM().SetFloat("Drop_Far", (float)((!this._Visualize) ? 0 : 1));
			this.MMOODGIODPC().SetFloat("IconImage", this._FixDistance);
			this.DOHGBNPMBKG().SetFloat("https://steamcommunity.com/app/513510/workshop/", this.Snow_Near);
			this.NFMGLIKNOOC().SetFloat("Can't set open when not in that room.", this.Snow_Far);
			this.BAGICADFBAB().SetFloat("ItemNameText", this.SnowWithoutObject);
			this.CECJJMKLEAK().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1335f, 1780f));
			this.NFMGLIKNOOC().SetTexture("_Value", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0000420A File Offset: 0x0000240A
	private void COOHIILCOCO()
	{
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x0000420A File Offset: 0x0000240A
	private void OGJJDKENBNC()
	{
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x000EEE54 File Offset: 0x000ED054
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1066f)
			{
				this.HBJJOCHGOPH = 1700f;
			}
			this.IOHHLNAPGMA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("menu.hardcoreinfo", this.Fade);
			this.NFMGLIKNOOC().SetFloat("_Value6", this.Intensity);
			this.LPPEPKGFOEM().SetFloat("_TimeX", this.Speed * 1933f);
			this.HHIFMIPPMPF().SetFloat("_Radius", this.Size);
			this.EFMCNLELMDO().SetFloat("PLAY [SPACE]", (float)((!this._Visualize) ? 1 : 1));
			this.MMOODGIODPC().SetFloat("CameraFilterPack/TV_BrokenGlass2", this._FixDistance);
			this.MMOODGIODPC().SetFloat("LivesSlider", this.Snow_Near);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_DarkColor", this.Snow_Far);
			this.DOHGBNPMBKG().SetFloat("mapid", this.SnowWithoutObject);
			this.BAGICADFBAB().SetVector("GroupNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 419f, 1717f));
			this.ADBKPGFMNKO().SetTexture("Joystick1Button2", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0000B937 File Offset: 0x00009B37
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

	// Token: 0x06000ADC RID: 2780 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x0000420A File Offset: 0x0000240A
	private void JONGNKNLLND()
	{
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x000EEFF8 File Offset: 0x000ED1F8
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 38f)
			{
				this.HBJJOCHGOPH = 80f;
			}
			this.NFMGLIKNOOC().SetFloat("Classical", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack_AAA_Blood2", this.Fade);
			this.HFBJAOFLCJI().SetFloat("Editor/", this.Intensity);
			this.EFMCNLELMDO().SetFloat("yes", this.Speed * 1255f);
			this.KLKILLCHJHO().SetFloat("ResetSpeed", this.Size);
			this.FEAEGGCNIAA().SetFloat("ns", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_Color_G", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("EventConfigButton", this.Snow_Near);
			this.OCHJIMJNEMO().SetFloat("OnStatusChanged: {0} current State: {1}", this.Snow_Far);
			this.CECJJMKLEAK().SetFloat("[MapsData] Workshop maps was loaded", this.SnowWithoutObject);
			this.IGKFMCPDNOI().SetVector("_Value1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1874f, 903f));
			this.BAGICADFBAB().SetTexture("1 Kb", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0000420A File Offset: 0x0000240A
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0000420A File Offset: 0x0000240A
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0000B96E File Offset: 0x00009B6E
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x000EF19C File Offset: 0x000ED39C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1425f)
			{
				this.HBJJOCHGOPH = 624f;
			}
			this.HHIAIGCAHDA().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("float,50", this.Fade);
			this.EFMCNLELMDO().SetFloat("ArcsNoHitsoundTimeDelaySlider", this.Intensity);
			this.ILKALHDJBFE().SetFloat("Editor/", this.Speed * 1912f);
			this.IGKFMCPDNOI().SetFloat("OpGetGameList()", this.Size);
			this.IOHHLNAPGMA().SetFloat("D-Pad Down", (float)((!this._Visualize) ? 0 : 0));
			this.HHIAIGCAHDA().SetFloat("GameScene", this._FixDistance);
			this.ILKALHDJBFE().SetFloat("#pleasewait", this.Snow_Near);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.Snow_Far);
			this.EFMCNLELMDO().SetFloat(" GameServer:", this.SnowWithoutObject);
			this.INOBFNCKFGK().SetVector("1087340967", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 24f, 319f));
			this.INOBFNCKFGK().SetTexture("AddEnvironmentObject", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0000B9A5 File Offset: 0x00009BA5
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x000EF340 File Offset: 0x000ED540
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1102f)
			{
				this.HBJJOCHGOPH = 1651f;
			}
			this.CECJJMKLEAK().SetFloat(" ", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("Set satellite clockwise rotattion speed", this.Fade);
			this.LMLENGFLEBD().SetFloat("#creatingnewitem", this.Intensity);
			this.MCDGIILBNIF().SetFloat("HiddenToggle", this.Speed * 51f);
			this.KLKILLCHJHO().SetFloat("_Threshhold", this.Size);
			this.LMLENGFLEBD().SetFloat("MapEnd", (float)((!this._Visualize) ? 1 : 1));
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Blend2Camera_VividLight", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("[SaveSystem] Outdated savefile found", this.Snow_Near);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Snow_Far);
			this.FEAEGGCNIAA().SetFloat("Texture2", this.SnowWithoutObject);
			this.LMLENGFLEBD().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 593f, 524f));
			this.NKBIEMJBCBM().SetTexture("_Value2", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x000EF4E4 File Offset: 0x000ED6E4
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 231f)
			{
				this.HBJJOCHGOPH = 1726f;
			}
			this.LPPEPKGFOEM().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("z", this.Fade);
			this.NBPKMLMCHFN.SetFloat("DPADVER", this.Intensity);
			this.BAGICADFBAB().SetFloat("_Value11", this.Speed * 211f);
			this.ILKALHDJBFE().SetFloat("setint", this.Size);
			this.BKKJJJGADLM().SetFloat("maps.", (float)((!this._Visualize) ? 1 : 1));
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this._FixDistance);
			this.OCHJIMJNEMO().SetFloat("DisableStoryboardToggle", this.Snow_Near);
			this.HFBJAOFLCJI().SetFloat("_Parasite", this.Snow_Far);
			this.ACHNOHCLGOO().SetFloat("Creating awesome maps", this.SnowWithoutObject);
			this.IOHHLNAPGMA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1968f, 1995f));
			this.ADAFMBOGPLN().SetTexture("steamid", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0000420A File Offset: 0x0000240A
	private void BMOFEBKGLFI()
	{
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x000EF688 File Offset: 0x000ED888
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1784f)
			{
				this.HBJJOCHGOPH = 1888f;
			}
			this.HKHBBBFLGJH().SetFloat("0 seconds", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("IconFileSelector", this.Fade);
			this.INOBFNCKFGK().SetFloat("_MainTex2", this.Intensity);
			this.KLKILLCHJHO().SetFloat("settings.gamemessagesduration", this.Speed * 1268f);
			this.MMOODGIODPC().SetFloat("Type of observed is unknown when receiving.", this.Size);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 1));
			this.FAIFBBGFAIB().SetFloat("ticket", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat("_Value3", this.Snow_Near);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.Snow_Far);
			this.ADBKPGFMNKO().SetFloat("SpawnObj", this.SnowWithoutObject);
			this.ILKALHDJBFE().SetVector("COMPLETED", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 612f, 1586f));
			this.NKBIEMJBCBM().SetTexture("AvatarImage", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0000420A File Offset: 0x0000240A
	private void FEKECCBFGMI()
	{
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x0000420A File Offset: 0x0000240A
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x0000B9DC File Offset: 0x00009BDC
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x0000420A File Offset: 0x0000240A
	private void FIKFJDFELIP()
	{
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x000EF82C File Offset: 0x000EDA2C
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 629f)
			{
				this.HBJJOCHGOPH = 451f;
			}
			this.HKHBBBFLGJH().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat(">", this.Fade);
			this.MMOODGIODPC().SetFloat("</color>", this.Intensity);
			this.DOHGBNPMBKG().SetFloat("SpawnObj", this.Speed * 35f);
			this.DOHGBNPMBKG().SetFloat("_Amount", this.Size);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/Light_Water", (float)((!this._Visualize) ? 0 : 0));
			this.NKBIEMJBCBM().SetFloat("#discord{0}joinrequest", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("L2", this.Snow_Near);
			this.HHIFMIPPMPF().SetFloat("Creating awesome map", this.Snow_Far);
			this.NFMGLIKNOOC().SetFloat("MenuScene", this.SnowWithoutObject);
			this.ACHNOHCLGOO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 480f, 70f));
			this.EFMCNLELMDO().SetTexture("Spawn ark to be pressed at this time", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0000420A File Offset: 0x0000240A
	private void LBAJLLFMMMP()
	{
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0000420A File Offset: 0x0000240A
	private void BKIGIIINEDH()
	{
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0000420A File Offset: 0x0000240A
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0000B4CE File Offset: 0x000096CE
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x0000BA13 File Offset: 0x00009C13
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0000BA4A File Offset: 0x00009C4A
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0000420A File Offset: 0x0000240A
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x04000185 RID: 389
	public Shader SCShader;

	// Token: 0x04000186 RID: 390
	public bool _Visualize;

	// Token: 0x04000187 RID: 391
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000188 RID: 392
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000189 RID: 393
	private Material BJFKDHHMLJH;

	// Token: 0x0400018A RID: 394
	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	// Token: 0x0400018B RID: 395
	[Range(-0.5f, 0.99f)]
	public float Snow_Near = 0.08f;

	// Token: 0x0400018C RID: 396
	[Range(0f, 1f)]
	public float Snow_Far = 0.55f;

	// Token: 0x0400018D RID: 397
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400018E RID: 398
	[Range(0f, 2f)]
	public float Intensity = 1f;

	// Token: 0x0400018F RID: 399
	[Range(0f, 2f)]
	public float Size = 1f;

	// Token: 0x04000190 RID: 400
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x04000191 RID: 401
	[Range(0f, 1f)]
	public float SnowWithoutObject = 1f;

	// Token: 0x04000192 RID: 402
	public Texture2D Texture2;
}
