/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200002C RID: 44
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Blood_Plus")]
public class CameraFilterPack_AAA_Blood_Plus : MonoBehaviour
{
	// Token: 0x06000B49 RID: 2889 RVA: 0x0000C0C1 File Offset: 0x0000A2C1
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0000C12F File Offset: 0x0000A32F
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

	// Token: 0x06000B4C RID: 2892 RVA: 0x0000420A File Offset: 0x0000240A
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x000F129C File Offset: 0x000EF49C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 594f)
			{
				this.HBJJOCHGOPH = 885f;
			}
			this.GCDFNHMJMIP().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("AudioSampler", this.LightReflect);
			this.PDEAHJPOMEF().SetFloat("SetSatelliteTrailWidth", Mathf.Clamp(this.Blood_1, 1514f, 1579f));
			this.KGOLDDBHIFN().SetFloat("_Value5", Mathf.Clamp(this.Blood_2, 1463f, 188f));
			this.NFMGLIKNOOC().SetFloat("_Curve", Mathf.Clamp(this.Blood_3, 442f, 723f));
			this.GCDFNHMJMIP().SetFloat("StartTime already set: ", Mathf.Clamp(this.Blood_4, 70f, 1842f));
			this.GCDFNHMJMIP().SetFloat("_MatrixSize", Mathf.Clamp(this.Blood_5, 775f, 1100f));
			this.NFMGLIKNOOC().SetFloat("y", Mathf.Clamp(this.Blood_6, 1821f, 1251f));
			this.GCDFNHMJMIP().SetFloat("Use ticket: ", Mathf.Clamp(this.Blood_7, 680f, 1603f));
			this.EFDEIFCDAFG().SetFloat("DISTORT", Mathf.Clamp(this.Blood_8, 198f, 280f));
			this.GCDFNHMJMIP().SetFloat("Preparing content...", Mathf.Clamp(this.Blood_9, 166f, 1739f));
			this.EFDEIFCDAFG().SetFloat("Hidden/DepthOfField/DepthOfField", Mathf.Clamp(this.Blood_10, 1006f, 1579f));
			this.PGPEMMBJOOG().SetFloat("#close", Mathf.Clamp(this.Blood_11, 1564f, 920f));
			this.PDEAHJPOMEF().SetFloat("_Value3", Mathf.Clamp(this.Blood_12, 664f, 219f));
			this.HNICHJCGJOC().SetTexture("ConfigVersionSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x0000C166 File Offset: 0x0000A366
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x0000C166 File Offset: 0x0000A366
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x0000420A File Offset: 0x0000240A
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x000F1500 File Offset: 0x000EF700
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(this.Blood_1, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(this.Blood_2, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Blood_3, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(this.Blood_4, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value6", Mathf.Clamp(this.Blood_5, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value7", Mathf.Clamp(this.Blood_6, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value8", Mathf.Clamp(this.Blood_7, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value9", Mathf.Clamp(this.Blood_8, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value10", Mathf.Clamp(this.Blood_9, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value11", Mathf.Clamp(this.Blood_10, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value12", Mathf.Clamp(this.Blood_11, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value13", Mathf.Clamp(this.Blood_12, 0f, 1f));
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0000C1AC File Offset: 0x0000A3AC
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x0000C166 File Offset: 0x0000A366
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x000F1764 File Offset: 0x000EF964
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1750f)
			{
				this.HBJJOCHGOPH = 809f;
			}
			this.NBPKMLMCHFN.SetFloat("Year_", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("_Value5", this.LightReflect);
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack/Antialiasing_FXAA", Mathf.Clamp(this.Blood_1, 246f, 1429f));
			this.GCDFNHMJMIP().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Mathf.Clamp(this.Blood_2, 1765f, 1951f));
			this.EFDEIFCDAFG().SetFloat("MapperNameText", Mathf.Clamp(this.Blood_3, 1912f, 258f));
			this.GCDFNHMJMIP().SetFloat("_ScreenResolution", Mathf.Clamp(this.Blood_4, 965f, 1795f));
			this.GCDFNHMJMIP().SetFloat("SfxVolumeSlider", Mathf.Clamp(this.Blood_5, 1932f, 1149f));
			this.HNICHJCGJOC().SetFloat("RespawnAfter", Mathf.Clamp(this.Blood_6, 1233f, 1515f));
			this.GCDFNHMJMIP().SetFloat("SetCrosshairEmission", Mathf.Clamp(this.Blood_7, 1520f, 1533f));
			this.HNICHJCGJOC().SetFloat("[PlayerController] ", Mathf.Clamp(this.Blood_8, 1924f, 223f));
			this.EFDEIFCDAFG().SetFloat("ZoomFade", Mathf.Clamp(this.Blood_9, 725f, 1417f));
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Mathf.Clamp(this.Blood_10, 1972f, 329f));
			this.IONHGBPGCHK().SetFloat("settings.customdataskin", Mathf.Clamp(this.Blood_11, 1669f, 1893f));
			this.PGPEMMBJOOG().SetFloat("id", Mathf.Clamp(this.Blood_12, 152f, 1384f));
			this.IONHGBPGCHK().SetTexture("maps.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x0000C1E3 File Offset: 0x0000A3E3
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x0000C21A File Offset: 0x0000A41A
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x0000420A File Offset: 0x0000240A
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0000C251 File Offset: 0x0000A451
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button1") as Texture2D);
		this.SCShader = Shader.Find("In Network lobby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x0000C28A File Offset: 0x0000A48A
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("mapselector.filter.favoriteonly") as Texture2D);
		this.SCShader = Shader.Find("Options");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0000420A File Offset: 0x0000240A
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x0000420A File Offset: 0x0000240A
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x0000C2C3 File Offset: 0x0000A4C3
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0000C166 File Offset: 0x0000A366
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x000F19C8 File Offset: 0x000EFBC8
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1091f)
			{
				this.HBJJOCHGOPH = 1627f;
			}
			this.IONHGBPGCHK().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("HightScoreMaxPointsText", this.LightReflect);
			this.NFMGLIKNOOC().SetFloat("duration", Mathf.Clamp(this.Blood_1, 312f, 966f));
			this.NFMGLIKNOOC().SetFloat("float,1.5", Mathf.Clamp(this.Blood_2, 1158f, 721f));
			this.EFDEIFCDAFG().SetFloat(" not exist", Mathf.Clamp(this.Blood_3, 1525f, 1828f));
			this.NFMGLIKNOOC().SetFloat("Alpha", Mathf.Clamp(this.Blood_4, 75f, 289f));
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] SetSpeed error: ", Mathf.Clamp(this.Blood_5, 642f, 1649f));
			this.GCDFNHMJMIP().SetFloat("_Vignette", Mathf.Clamp(this.Blood_6, 465f, 1730f));
			this.NBPKMLMCHFN.SetFloat("#alreadystarted", Mathf.Clamp(this.Blood_7, 1388f, 1332f));
			this.EFDEIFCDAFG().SetFloat("PunPickup", Mathf.Clamp(this.Blood_8, 1531f, 198f));
			this.EFDEIFCDAFG().SetFloat("mapselector.filter.favoriteonly", Mathf.Clamp(this.Blood_9, 744f, 1425f));
			this.PDEAHJPOMEF().SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", Mathf.Clamp(this.Blood_10, 1680f, 1319f));
			this.NFMGLIKNOOC().SetFloat("SetSunEmission", Mathf.Clamp(this.Blood_11, 469f, 1767f));
			this.PGPEMMBJOOG().SetFloat("OnMastedChangeScene", Mathf.Clamp(this.Blood_12, 7f, 1644f));
			this.KGOLDDBHIFN().SetTexture("[Right]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0000C2FC File Offset: 0x0000A4FC
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0000C335 File Offset: 0x0000A535
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x0000C166 File Offset: 0x0000A366
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x0000C166 File Offset: 0x0000A366
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0000C166 File Offset: 0x0000A366
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x0000C36E File Offset: 0x0000A56E
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_Blood2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Plus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x0000C3A7 File Offset: 0x0000A5A7
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x000F1C2C File Offset: 0x000EFE2C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1109f)
			{
				this.HBJJOCHGOPH = 611f;
			}
			this.NFMGLIKNOOC().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("EditMenu", this.LightReflect);
			this.EFDEIFCDAFG().SetFloat("Lag ", Mathf.Clamp(this.Blood_1, 1438f, 1599f));
			this.EFDEIFCDAFG().SetFloat("ENABLE_COLOR_GRADING", Mathf.Clamp(this.Blood_2, 547f, 511f));
			this.IONHGBPGCHK().SetFloat("_ScreenResolution", Mathf.Clamp(this.Blood_3, 353f, 54f));
			this.HNICHJCGJOC().SetFloat("Tried to Initialize the SteamAPI twice in one session!", Mathf.Clamp(this.Blood_4, 380f, 424f));
			this.PGPEMMBJOOG().SetFloat("[TextSaver] Text saved to ", Mathf.Clamp(this.Blood_5, 1702f, 5f));
			this.NFMGLIKNOOC().SetFloat("<color=white>PhotonView Group: ", Mathf.Clamp(this.Blood_6, 1057f, 392f));
			this.PDEAHJPOMEF().SetFloat("_TimeX", Mathf.Clamp(this.Blood_7, 839f, 40f));
			this.PDEAHJPOMEF().SetFloat("_TimeX", Mathf.Clamp(this.Blood_8, 1995f, 1596f));
			this.NFMGLIKNOOC().SetFloat("_Vignette_Alpha", Mathf.Clamp(this.Blood_9, 82f, 1933f));
			this.PDEAHJPOMEF().SetFloat("_MainTex2", Mathf.Clamp(this.Blood_10, 1377f, 1711f));
			this.NFMGLIKNOOC().SetFloat("_TimeX", Mathf.Clamp(this.Blood_11, 371f, 1362f));
			this.EFDEIFCDAFG().SetFloat("received</b>\n#reason: ", Mathf.Clamp(this.Blood_12, 1591f, 1904f));
			this.IONHGBPGCHK().SetTexture("Default UI Material", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x000F1E90 File Offset: 0x000F0090
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1534f)
			{
				this.HBJJOCHGOPH = 1654f;
			}
			this.PGPEMMBJOOG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Set particles count per one beat", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("SaveButton", Mathf.Clamp(this.Blood_1, 1075f, 1367f));
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Noise_TV", Mathf.Clamp(this.Blood_2, 1251f, 926f));
			this.NBPKMLMCHFN.SetFloat("PlayButton", Mathf.Clamp(this.Blood_3, 558f, 1372f));
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blur_Movie", Mathf.Clamp(this.Blood_4, 364f, 890f));
			this.IONHGBPGCHK().SetFloat("OpSetPropertiesOfRoom()", Mathf.Clamp(this.Blood_5, 1039f, 751f));
			this.IONHGBPGCHK().SetFloat("_Value2", Mathf.Clamp(this.Blood_6, 853f, 1004f));
			this.GCDFNHMJMIP().SetFloat("_MainTex2", Mathf.Clamp(this.Blood_7, 1948f, 498f));
			this.NFMGLIKNOOC().SetFloat("_Value4", Mathf.Clamp(this.Blood_8, 226f, 43f));
			this.KGOLDDBHIFN().SetFloat("EventMenu", Mathf.Clamp(this.Blood_9, 168f, 1193f));
			this.PGPEMMBJOOG().SetFloat("LevelEditor/icons", Mathf.Clamp(this.Blood_10, 658f, 1627f));
			this.PDEAHJPOMEF().SetFloat("_TileMaxOffs", Mathf.Clamp(this.Blood_11, 190f, 1771f));
			this.HNICHJCGJOC().SetFloat("_Value", Mathf.Clamp(this.Blood_12, 325f, 389f));
			this.IONHGBPGCHK().SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x0000C3DE File Offset: 0x0000A5DE
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x0000C415 File Offset: 0x0000A615
	private void BEBNOKFLJPH()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0000C166 File Offset: 0x0000A366
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x000F20F4 File Offset: 0x000F02F4
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 532f)
			{
				this.HBJJOCHGOPH = 170f;
			}
			this.HNICHJCGJOC().SetFloat("GlassAberration", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("SetSpeed", this.LightReflect);
			this.PGPEMMBJOOG().SetFloat("_BlurVector", Mathf.Clamp(this.Blood_1, 1754f, 85f));
			this.NBPKMLMCHFN.SetFloat("achievements.26.progress", Mathf.Clamp(this.Blood_2, 151f, 1286f));
			this.EFDEIFCDAFG().SetFloat("_TimeX", Mathf.Clamp(this.Blood_3, 1780f, 1111f));
			this.PDEAHJPOMEF().SetFloat("LevelInfoInputField", Mathf.Clamp(this.Blood_4, 1879f, 966f));
			this.IONHGBPGCHK().SetFloat("_Visualize", Mathf.Clamp(this.Blood_5, 1853f, 593f));
			this.HNICHJCGJOC().SetFloat("RarityImage", Mathf.Clamp(this.Blood_6, 1834f, 1244f));
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Vision_Psycho", Mathf.Clamp(this.Blood_7, 1577f, 1910f));
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", Mathf.Clamp(this.Blood_8, 660f, 749f));
			this.PDEAHJPOMEF().SetFloat("_EmissionGain", Mathf.Clamp(this.Blood_9, 259f, 689f));
			this.KGOLDDBHIFN().SetFloat("#scoresubmitionfailed: ", Mathf.Clamp(this.Blood_10, 1243f, 534f));
			this.HNICHJCGJOC().SetFloat("_Offsets", Mathf.Clamp(this.Blood_11, 1326f, 1569f));
			this.IONHGBPGCHK().SetFloat("ready", Mathf.Clamp(this.Blood_12, 929f, 1232f));
			this.HNICHJCGJOC().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x0000C166 File Offset: 0x0000A366
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x0000C44E File Offset: 0x0000A64E
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x0000C166 File Offset: 0x0000A366
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x0000C166 File Offset: 0x0000A366
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001AD RID: 429
	public Shader SCShader;

	// Token: 0x040001AE RID: 430
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001AF RID: 431
	[Range(0f, 1f)]
	public float Blood_1 = 1f;

	// Token: 0x040001B0 RID: 432
	[Range(0f, 1f)]
	public float Blood_2;

	// Token: 0x040001B1 RID: 433
	[Range(0f, 1f)]
	public float Blood_3;

	// Token: 0x040001B2 RID: 434
	[Range(0f, 1f)]
	public float Blood_4;

	// Token: 0x040001B3 RID: 435
	[Range(0f, 1f)]
	public float Blood_5;

	// Token: 0x040001B4 RID: 436
	[Range(0f, 1f)]
	public float Blood_6;

	// Token: 0x040001B5 RID: 437
	[Range(0f, 1f)]
	public float Blood_7;

	// Token: 0x040001B6 RID: 438
	[Range(0f, 1f)]
	public float Blood_8;

	// Token: 0x040001B7 RID: 439
	[Range(0f, 1f)]
	public float Blood_9;

	// Token: 0x040001B8 RID: 440
	[Range(0f, 1f)]
	public float Blood_10;

	// Token: 0x040001B9 RID: 441
	[Range(0f, 1f)]
	public float Blood_11;

	// Token: 0x040001BA RID: 442
	[Range(0f, 1f)]
	public float Blood_12;

	// Token: 0x040001BB RID: 443
	[Range(0f, 1f)]
	public float LightReflect = 0.5f;

	// Token: 0x040001BC RID: 444
	private Material BJFKDHHMLJH;

	// Token: 0x040001BD RID: 445
	private Texture2D FPHEBLMINDA;
}
