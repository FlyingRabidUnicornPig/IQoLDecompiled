/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/



using System;
using UnityEngine;

// Token: 0x02000030 RID: 48
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/WaterDrop")]
public class CameraFilterPack_AAA_WaterDrop : MonoBehaviour
{
	// Token: 0x06000BEB RID: 3051 RVA: 0x000F4584 File Offset: 0x000F2784
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 352f)
			{
				this.HBJJOCHGOPH = 1859f;
			}
			this.GHHPOGODBHB().SetFloat("(\\[ *i *\\])", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_Value2", this.Distortion);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack_WaterDrop", this.SizeX);
			this.KBOPGONOCNP().SetFloat("PossibleMapPointsText", this.SizeY);
			this.HKHBBBFLGJH().SetFloat("Set EnvSprite Image", this.Speed);
			this.IONHGBPGCHK().SetTexture("colorD", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x0000420A File Offset: 0x0000240A
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x0000CCE6 File Offset: 0x0000AEE6
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("DifficultyBG") as Texture2D);
		this.SCShader = Shader.Find("_Green_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x000F466C File Offset: 0x000F286C
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1683f)
			{
				this.HBJJOCHGOPH = 725f;
			}
			this.CFEDGDGBCHE().SetFloat("_Blue_R", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Value", this.Distortion);
			this.IONHGBPGCHK().SetFloat("Tab1Content", this.SizeX);
			this.DOMEEFLPEPJ().SetFloat("status", this.SizeY);
			this.IIBLJCKLGFG().SetFloat(" - StoreAuthURLResponse] - ", this.Speed);
			this.HCGJCMDJPGD().SetTexture("HandsCountSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x000F4754 File Offset: 0x000F2954
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 183f)
			{
				this.HBJJOCHGOPH = 465f;
			}
			this.FKEOGPDLBDD().SetFloat("maps.", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("CrosshairOpacitySlider", this.Distortion);
			this.DKNJGHFLAIF().SetFloat("ReconnectAndRejoin() with AuthValues == null is not correct!", this.SizeX);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.SizeY);
			this.NLFJGMBCICG().SetFloat("ShowTitle", this.Speed);
			this.FEAEGGCNIAA().SetTexture("#pleasewait", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x000F483C File Offset: 0x000F2A3C
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1629f)
			{
				this.HBJJOCHGOPH = 460f;
			}
			this.NBPKMLMCHFN.SetFloat("GhostFade2", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat(": ", this.Distortion);
			this.HHIFMIPPMPF().SetFloat("settings_bindings_controller_type", this.SizeX);
			this.OOMFJGPAOKL().SetFloat("offsets", this.SizeY);
			this.DKNJGHFLAIF().SetFloat("[Right]", this.Speed);
			this.ECCPAOBFDKP().SetTexture("EventTimeInputField", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x0000CD1F File Offset: 0x0000AF1F
	private void DOKAKEMDALN()
	{
		this.FPHEBLMINDA = (Resources.Load("float,10") as Texture2D);
		this.SCShader = Shader.Find("_ReflectionBlur");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x0000CD58 File Offset: 0x0000AF58
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x0000CDAC File Offset: 0x0000AFAC
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x000F4924 File Offset: 0x000F2B24
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1257f)
			{
				this.HBJJOCHGOPH = 1149f;
			}
			this.FGENHBKMPDA().SetFloat("settings.arcshitsoundtimedelay", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("#yes", this.Distortion);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.SizeX);
			this.LPCHMEKDCHI().SetFloat("_ScreenResolution", this.SizeY);
			this.KEMAALEODNH().SetFloat("shader.invert", this.Speed);
			this.HFBJAOFLCJI().SetTexture("Preparing content", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0000CDE3 File Offset: 0x0000AFE3
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0000CE1A File Offset: 0x0000B01A
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x0000420A File Offset: 0x0000240A
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x000F4A0C File Offset: 0x000F2C0C
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1376f)
			{
				this.HBJJOCHGOPH = 1718f;
			}
			this.HKHBBBFLGJH().SetFloat("OK", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Scene", this.Distortion);
			this.ABHDNGIHBKE().SetFloat("Set Satellite Sensitivity", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("_TapMedium", this.SizeY);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_ColorKey", this.Speed);
			this.KBOPGONOCNP().SetTexture("GridDataStoryboard", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x0000CE51 File Offset: 0x0000B051
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x0000CE88 File Offset: 0x0000B088
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x000F4AF4 File Offset: 0x000F2CF4
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 587f)
			{
				this.HBJJOCHGOPH = 326f;
			}
			this.FKEOGPDLBDD().SetFloat("hitsounds:", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("maps.", this.Distortion);
			this.OOMFJGPAOKL().SetFloat("owner: ", this.SizeX);
			this.OOMFJGPAOKL().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", this.SizeY);
			this.DOMEEFLPEPJ().SetFloat("threshold", this.Speed);
			this.HCGJCMDJPGD().SetTexture("NEW", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x000F4BDC File Offset: 0x000F2DDC
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1047f)
			{
				this.HBJJOCHGOPH = 513f;
			}
			this.FGENHBKMPDA().SetFloat("UseScanLineSize", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("[NetworkMenu] Joining ", this.Distortion);
			this.FKEOGPDLBDD().SetFloat("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", this.SizeX);
			this.LPCHMEKDCHI().SetFloat("#exit", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_VHS1", this.Speed);
			this.FGENHBKMPDA().SetTexture("MaxLivesSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x000F4CC4 File Offset: 0x000F2EC4
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 323f)
			{
				this.HBJJOCHGOPH = 313f;
			}
			this.FEAEGGCNIAA().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_BlurredColor", this.Distortion);
			this.IIBLJCKLGFG().SetFloat(" By: ", this.SizeX);
			this.DKNJGHFLAIF().SetFloat("#failed: ", this.SizeY);
			this.ECCPAOBFDKP().SetFloat("/", this.Speed);
			this.DOMEEFLPEPJ().SetTexture("_FgOverlap", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0000420A File Offset: 0x0000240A
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x000F4DAC File Offset: 0x000F2FAC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 326f;
			}
			this.NDMPCDHADMJ().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("shader.pixel", this.Distortion);
			this.GKILCDHJFEG().SetFloat("#ok", this.SizeX);
			this.JCPDCGIJKJD().SetFloat("_Level", this.SizeY);
			this.IIBLJCKLGFG().SetFloat("#onfirstranktext", this.Speed);
			this.HCGJCMDJPGD().SetTexture("#later", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0000CEBF File Offset: 0x0000B0BF
	private void ALJEJJCIMJN()
	{
		this.FPHEBLMINDA = (Resources.Load("0.00") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
	private void NDBPCNICGLC()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button6") as Texture2D);
		this.SCShader = Shader.Find("HPToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x0000CF31 File Offset: 0x0000B131
	private void JKBMKPDGCHG()
	{
		this.FPHEBLMINDA = (Resources.Load("The number of players playing your game: ") as Texture2D);
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x0000420A File Offset: 0x0000240A
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x0000420A File Offset: 0x0000240A
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x000F4E94 File Offset: 0x000F3094
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1172f)
			{
				this.HBJJOCHGOPH = 923f;
			}
			this.FEAEGGCNIAA().SetFloat("settings.cameramovements", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("rarity", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("_Value", this.SizeX);
			this.JCPDCGIJKJD().SetFloat("WARNING: rotation axis set to 0 on ", this.SizeY);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/EyesVision_1", this.Speed);
			this.ADAFMBOGPLN().SetTexture("_Value3", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x0000CF6A File Offset: 0x0000B16A
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x000F4F7C File Offset: 0x000F317C
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 332f)
			{
				this.HBJJOCHGOPH = 550f;
			}
			this.GKILCDHJFEG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("#highscore", this.Distortion);
			this.HKGAONMOBMH().SetFloat("inventory.selected.", this.SizeX);
			this.OOMFJGPAOKL().SetFloat("_Bullet_8", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed);
			this.NLFJGMBCICG().SetTexture("Error; Only the MasterClient can call RemoveRPCs for other players.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("MultiplayerButton") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Tunnel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x0000D019 File Offset: 0x0000B219
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x0000420A File Offset: 0x0000240A
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x0000D050 File Offset: 0x0000B250
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x000F5064 File Offset: 0x000F3264
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1375f)
			{
				this.HBJJOCHGOPH = 1936f;
			}
			this.IIBLJCKLGFG().SetFloat("/Assets/MyImage", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("s", this.Distortion);
			this.IIBLJCKLGFG().SetFloat("_CenterX", this.SizeX);
			this.DKNJGHFLAIF().SetFloat("</color>", this.SizeY);
			this.JCPDCGIJKJD().SetFloat("float,10", this.Speed);
			this.DOHGBNPMBKG().SetTexture("[#clicktoacceptchallenge]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x0000D087 File Offset: 0x0000B287
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_WaterDrop") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_WaterDrop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x0000D0F7 File Offset: 0x0000B2F7
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("float,0") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x000F514C File Offset: 0x000F334C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 919f)
			{
				this.HBJJOCHGOPH = 548f;
			}
			this.ECCPAOBFDKP().SetFloat("MainButton", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("_EmissionColor", this.Distortion);
			this.ECCPAOBFDKP().SetFloat("settings.volume.menu", this.SizeX);
			this.ABHDNGIHBKE().SetFloat("Mouse Wheel Down", this.SizeY);
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack/Gradients_FireGradient", this.Speed);
			this.FGENHBKMPDA().SetTexture("\n\n#", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x0000420A File Offset: 0x0000240A
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x000F5234 File Offset: 0x000F3434
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1469f)
			{
				this.HBJJOCHGOPH = 42f;
			}
			this.KBOPGONOCNP().SetFloat("_Distortion2", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("steamid", this.Distortion);
			this.IONHGBPGCHK().SetFloat("_MainTex2", this.SizeX);
			this.GKILCDHJFEG().SetFloat("#failed: ", this.SizeY);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/Light_Water2", this.Speed);
			this.CFEDGDGBCHE().SetTexture("ConfigVersionSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x000F531C File Offset: 0x000F351C
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 560f)
			{
				this.HBJJOCHGOPH = 182f;
			}
			this.KEMAALEODNH().SetFloat("player.goldbat", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat(": ", this.Distortion);
			this.KEMAALEODNH().SetFloat("KickThePlayer", this.SizeX);
			this.NDMPCDHADMJ().SetFloat("sounds/hit_wrong", this.SizeY);
			this.JCPDCGIJKJD().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.Speed);
			this.CFEDGDGBCHE().SetTexture("[Up]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x0000D130 File Offset: 0x0000B330
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("#failed!") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x0000D169 File Offset: 0x0000B369
	private void MDNHCLKNCLE()
	{
		this.FPHEBLMINDA = (Resources.Load("win") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x000F5404 File Offset: 0x000F3604
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1743f)
			{
				this.HBJJOCHGOPH = 424f;
			}
			this.JCPDCGIJKJD().SetFloat("Tab1Content", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("Operation ", this.Distortion);
			this.HNICHJCGJOC().SetFloat("/", this.SizeX);
			this.EHDJJANLINB().SetFloat("CameraFilterPack_Glasses_On6", this.SizeY);
			this.JCPDCGIJKJD().SetFloat("settings.fps", this.Speed);
			this.HKHBBBFLGJH().SetTexture(".lastCheckpoint.comboScore", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x0000D1A2 File Offset: 0x0000B3A2
	private void KOFAMEKHHGD()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/TV_ARCADE") as Texture2D);
		this.SCShader = Shader.Find("no lives color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x0000420A File Offset: 0x0000240A
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x0000D1DB File Offset: 0x0000B3DB
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x0000D212 File Offset: 0x0000B412
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x0000D249 File Offset: 0x0000B449
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x000F54EC File Offset: 0x000F36EC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1554f)
			{
				this.HBJJOCHGOPH = 1288f;
			}
			this.FEAEGGCNIAA().SetFloat("Speed", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("mapselector.tags.", this.Distortion);
			this.EHDJJANLINB().SetFloat("_OcclusionTexture", this.SizeX);
			this.DOMEEFLPEPJ().SetFloat("settings.crosshairopacity", this.SizeY);
			this.KEMAALEODNH().SetFloat("menu.playedpage", this.Speed);
			this.DOHGBNPMBKG().SetTexture("MapEnd", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0000420A File Offset: 0x0000240A
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x000F55D4 File Offset: 0x000F37D4
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

	// Token: 0x06000C2D RID: 3117 RVA: 0x0000D280 File Offset: 0x0000B480
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x0000D2B7 File Offset: 0x0000B4B7
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0000420A File Offset: 0x0000240A
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x000F56BC File Offset: 0x000F38BC
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1399f)
			{
				this.HBJJOCHGOPH = 1644f;
			}
			this.KBOPGONOCNP().SetFloat("maps.", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("?", this.Distortion);
			this.OIBHFCLJKDB().SetFloat("_Near", this.SizeX);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack_eyes_vision_2", this.SizeY);
			this.HKHBBBFLGJH().SetFloat("_Value6", this.Speed);
			this.EHDJJANLINB().SetTexture("inventory.selected.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0000420A File Offset: 0x0000240A
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x0000D2EE File Offset: 0x0000B4EE
	private void ADPLHDFJFID()
	{
		this.FPHEBLMINDA = (Resources.Load("OnPickedUp") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x000F57A4 File Offset: 0x000F39A4
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 553f)
			{
				this.HBJJOCHGOPH = 1628f;
			}
			this.HKGAONMOBMH().SetFloat("Created", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Value2", this.Distortion);
			this.HCGJCMDJPGD().SetFloat("MenuVolumeSlider", this.SizeX);
			this.LDNADDJMIPK().SetFloat("ERROR: Make sure your mod contains at leats one file!", this.SizeY);
			this.NDMPCDHADMJ().SetFloat(".lastCheckpoint.incorrectScore", this.Speed);
			this.HKGAONMOBMH().SetTexture("#score", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x0000D327 File Offset: 0x0000B527
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x0000D35E File Offset: 0x0000B55E
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load("</color>") as Texture2D);
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x000F588C File Offset: 0x000F3A8C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 515f)
			{
				this.HBJJOCHGOPH = 422f;
			}
			this.OCMBHMLNCEK().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("EventMenu", this.Distortion);
			this.KEMAALEODNH().SetFloat("open", this.SizeX);
			this.KEMAALEODNH().SetFloat("#000000", this.SizeY);
			this.HNICHJCGJOC().SetFloat("VoteDownToggle", this.Speed);
			this.HKGAONMOBMH().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x0000420A File Offset: 0x0000240A
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x000F5974 File Offset: 0x000F3B74
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1893f)
			{
				this.HBJJOCHGOPH = 1682f;
			}
			this.FEAEGGCNIAA().SetFloat("_BlurVector", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("GlassesColor2", this.Distortion);
			this.LPCHMEKDCHI().SetFloat("\\", this.SizeX);
			this.ECCPAOBFDKP().SetFloat("public", this.SizeY);
			this.FKEOGPDLBDD().SetFloat("UseFinalGlassColor", this.Speed);
			this.DOHGBNPMBKG().SetTexture("_Saturation", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C3A RID: 3130 RVA: 0x0000D397 File Offset: 0x0000B597
	private void FMNPFCHBLJF()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_LinearBurn") as Texture2D);
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
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

	// Token: 0x06000C3C RID: 3132 RVA: 0x0000420A File Offset: 0x0000240A
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x0000D407 File Offset: 0x0000B607
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x0000420A File Offset: 0x0000240A
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x000F5A5C File Offset: 0x000F3C5C
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 219f)
			{
				this.HBJJOCHGOPH = 459f;
			}
			this.JCPDCGIJKJD().SetFloat("NEW_ACHIEVEMENT_1_", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_BlurredColor", this.Distortion);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.SizeX);
			this.ADAFMBOGPLN().SetFloat("InfoText", this.SizeY);
			this.OCMBHMLNCEK().SetFloat("y", this.Speed);
			this.NDMPCDHADMJ().SetTexture("steamid", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x0000420A File Offset: 0x0000240A
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x0000D43E File Offset: 0x0000B63E
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("SetSunColors");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x000F5B44 File Offset: 0x000F3D44
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 841f)
			{
				this.HBJJOCHGOPH = 1018f;
			}
			this.ADAFMBOGPLN().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("_Value4", this.Distortion);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.SizeX);
			this.DEFBJOCJJKF().SetFloat("menu.relaxinfo", this.SizeY);
			this.OIBHFCLJKDB().SetFloat("help", this.Speed);
			this.HCGJCMDJPGD().SetTexture("AddEnvironmentObject", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x0000D477 File Offset: 0x0000B677
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x0000D4AE File Offset: 0x0000B6AE
	private void OGJJDKENBNC()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("Texture3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x0000D4E7 File Offset: 0x0000B6E7
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x000F5C2C File Offset: 0x000F3E2C
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 632f)
			{
				this.HBJJOCHGOPH = 1209f;
			}
			this.ABHDNGIHBKE().SetFloat("RoomNameText", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_MainTex2", this.Distortion);
			this.IONHGBPGCHK().SetFloat("_ScreenResolution", this.SizeX);
			this.KEMAALEODNH().SetFloat("Set satellite trail width", this.SizeY);
			this.HCGJCMDJPGD().SetFloat("menu.enableselectormusic", this.Speed);
			this.DOMEEFLPEPJ().SetTexture("GroupNameText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x000F5D14 File Offset: 0x000F3F14
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 312f)
			{
				this.HBJJOCHGOPH = 1755f;
			}
			this.GHHPOGODBHB().SetFloat("/Segment-[Up]", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("UI Extensions/SoftMaskShaderText", this.Distortion);
			this.KBOPGONOCNP().SetFloat("MaxLivesSlider", this.SizeX);
			this.HHIFMIPPMPF().SetFloat("<b>#", this.SizeY);
			this.EHDJJANLINB().SetFloat("Set Satellite Emission", this.Speed);
			this.HNICHJCGJOC().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x0000D51E File Offset: 0x0000B71E
	private void NKFDNIAKGEO()
	{
		this.FPHEBLMINDA = (Resources.Load(".status") as Texture2D);
		this.SCShader = Shader.Find("_Red_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x0000420A File Offset: 0x0000240A
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x0000D557 File Offset: 0x0000B757
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x0000D58E File Offset: 0x0000B78E
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x000F5DFC File Offset: 0x000F3FFC
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 411f)
			{
				this.HBJJOCHGOPH = 1750f;
			}
			this.GHHPOGODBHB().SetFloat(" (now: ", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("_Distortion", this.Distortion);
			this.ECCPAOBFDKP().SetFloat("SetSpeed", this.SizeX);
			this.FGENHBKMPDA().SetFloat("Depth textures aren't supported on this device ({0})", this.SizeY);
			this.ECCPAOBFDKP().SetFloat("AreaTex", this.Speed);
			this.LPCHMEKDCHI().SetTexture("player.greenarc", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x0000D5C5 File Offset: 0x0000B7C5
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x000F5EE4 File Offset: 0x000F40E4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1089f)
			{
				this.HBJJOCHGOPH = 1259f;
			}
			this.JCPDCGIJKJD().SetFloat("CameraFilterPack/Oculus_ThermaVision", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("[ERROR KEY {0}]", this.Distortion);
			this.FKEOGPDLBDD().SetFloat("ItemTemplate", this.SizeX);
			this.HKGAONMOBMH().SetFloat("maps.", this.SizeY);
			this.ADAFMBOGPLN().SetFloat("_BlurVector", this.Speed);
			this.GHHPOGODBHB().SetTexture("LevelEditor/patterns", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x0000D280 File Offset: 0x0000B480
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x000F5FCC File Offset: 0x000F41CC
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1752f)
			{
				this.HBJJOCHGOPH = 945f;
			}
			this.GHHPOGODBHB().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.Distortion);
			this.OCMBHMLNCEK().SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", this.SizeX);
			this.ADAFMBOGPLN().SetFloat("_ScreenResolution", this.SizeY);
			this.KBOPGONOCNP().SetFloat("settings.disablestoryboard", this.Speed);
			this.IONHGBPGCHK().SetTexture("_Value4", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x000F60B4 File Offset: 0x000F42B4
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1752f)
			{
				this.HBJJOCHGOPH = 649f;
			}
			this.DKNJGHFLAIF().SetFloat("MultiplayerButton", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("_Value6", this.Distortion);
			this.LDNADDJMIPK().SetFloat("settings.disablestoryboard", this.SizeX);
			this.IONHGBPGCHK().SetFloat("setAF", this.SizeY);
			this.DKNJGHFLAIF().SetFloat("_FgOverlap", this.Speed);
			this.DOHGBNPMBKG().SetTexture("ns", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x0000D5FC File Offset: 0x0000B7FC
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x000F619C File Offset: 0x000F439C
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1727f)
			{
				this.HBJJOCHGOPH = 327f;
			}
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack_Paper4", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("IDInputField", this.Distortion);
			this.DOMEEFLPEPJ().SetFloat("_Near", this.SizeX);
			this.ABHDNGIHBKE().SetFloat("Scrollbar", this.SizeY);
			this.ECCPAOBFDKP().SetFloat("_MatrixColor", this.Speed);
			this.FKEOGPDLBDD().SetTexture("OK", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0000D633 File Offset: 0x0000B833
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x0000420A File Offset: 0x0000240A
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x0000D66A File Offset: 0x0000B86A
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0000D6A1 File Offset: 0x0000B8A1
	private void IKDNLHLBHID()
	{
		this.FPHEBLMINDA = (Resources.Load("Chat") as Texture2D);
		this.SCShader = Shader.Find("GameModeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x0000D6DA File Offset: 0x0000B8DA
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x0000420A File Offset: 0x0000240A
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0000D711 File Offset: 0x0000B911
	private void FIJHDKIPENG()
	{
		this.FPHEBLMINDA = (Resources.Load("Connection failed: ") as Texture2D);
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x000F6284 File Offset: 0x000F4484
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 259f)
			{
				this.HBJJOCHGOPH = 590f;
			}
			this.LPCHMEKDCHI().SetFloat("<b>HP</b>:", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_RangeScale", this.Distortion);
			this.HFBJAOFLCJI().SetFloat("maps.", this.SizeX);
			this.FGENHBKMPDA().SetFloat("Drop_Near", this.SizeY);
			this.NLFJGMBCICG().SetFloat("_Value2", this.Speed);
			this.GHHPOGODBHB().SetTexture("In Main Menu", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x000F636C File Offset: 0x000F456C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1697f)
			{
				this.HBJJOCHGOPH = 1011f;
			}
			this.LPCHMEKDCHI().SetFloat("Bad parameters for setbool! Use <key> <value>", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("menu.resetlevelcheckpoint", this.Distortion);
			this.KBOPGONOCNP().SetFloat("settings.arcshitsoundtimedelay", this.SizeX);
			this.DOHGBNPMBKG().SetFloat("_PColor2", this.SizeY);
			this.JCPDCGIJKJD().SetFloat("NEW_ACHIEVEMENT_1_21", this.Speed);
			this.FGENHBKMPDA().SetTexture("maps.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x0000D74A File Offset: 0x0000B94A
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0000420A File Offset: 0x0000240A
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0000420A File Offset: 0x0000240A
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x0000D781 File Offset: 0x0000B981
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x0000D7EF File Offset: 0x0000B9EF
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0000D826 File Offset: 0x0000BA26
	private void AEOLJEIDMDB()
	{
		this.FPHEBLMINDA = (Resources.Load("_Red_C") as Texture2D);
		this.SCShader = Shader.Find("USE_PREDICATION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040001E0 RID: 480
	public Shader SCShader;

	// Token: 0x040001E1 RID: 481
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001E2 RID: 482
	[Range(8f, 64f)]
	public float Distortion = 8f;

	// Token: 0x040001E3 RID: 483
	[Range(0f, 7f)]
	public float SizeX = 1f;

	// Token: 0x040001E4 RID: 484
	[Range(0f, 7f)]
	public float SizeY = 0.5f;

	// Token: 0x040001E5 RID: 485
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x040001E6 RID: 486
	private Material BJFKDHHMLJH;

	// Token: 0x040001E7 RID: 487
	private Texture2D FPHEBLMINDA;
}
