/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
[AddComponentMenu("Camera Filter Pack/AAA/Blood_Hit")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood_Hit : MonoBehaviour
{
	// Token: 0x06000B37 RID: 2871 RVA: 0x000F06A8 File Offset: 0x000EE8A8
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 844f)
			{
				this.HBJJOCHGOPH = 907f;
			}
			this.NBPKMLMCHFN.SetFloat("IntraSig", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Zoom speed. Base 1.5", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("Value", Mathf.Clamp(this.Hit_Left, 1403f, 1910f));
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_superDot", Mathf.Clamp(this.Hit_Up, 1337f, 1740f));
			this.ADBKPGFMNKO().SetFloat("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", Mathf.Clamp(this.Hit_Right, 683f, 1702f));
			this.ACHNOHCLGOO().SetFloat("New SaveGame", Mathf.Clamp(this.Hit_Down, 546f, 1156f));
			this.ACHNOHCLGOO().SetFloat("offsets", Mathf.Clamp(this.Blood_Hit_Left, 1668f, 397f));
			this.NBPKMLMCHFN.SetFloat("ShowSprite", Mathf.Clamp(this.Blood_Hit_Up, 110f, 945f));
			this.ACHNOHCLGOO().SetFloat("SetCrosshairColor", Mathf.Clamp(this.Blood_Hit_Right, 1549f, 1272f));
			this.NBPKMLMCHFN.SetFloat("ItemNameText", Mathf.Clamp(this.Blood_Hit_Down, 986f, 390f));
			this.NBPKMLMCHFN.SetFloat("Joystick1Button0", Mathf.Clamp(this.Hit_Full, 971f, 558f));
			this.ACHNOHCLGOO().SetFloat("inventory.selected.", Mathf.Clamp(this.Blood_Hit_Full_1, 1594f, 693f));
			this.ACHNOHCLGOO().SetFloat("settings.disablestoryboard", Mathf.Clamp(this.Blood_Hit_Full_2, 1137f, 375f));
			this.ADBKPGFMNKO().SetFloat("Connection error: ", Mathf.Clamp(this.Blood_Hit_Full_3, 35f, 800f));
			this.ADBKPGFMNKO().SetTexture("CameraFilterPack/Drawing_Curve", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0000BF2B File Offset: 0x0000A12B
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

	// Token: 0x06000B39 RID: 2873 RVA: 0x0000BF62 File Offset: 0x0000A162
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x0000BF7F File Offset: 0x0000A17F
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x000F090C File Offset: 0x000EEB0C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1142f)
			{
				this.HBJJOCHGOPH = 682f;
			}
			this.NBPKMLMCHFN.SetFloat("Scene", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_History1Weight", this.LightReflect);
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", Mathf.Clamp(this.Hit_Left, 1976f, 85f));
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack_Glasses_On3", Mathf.Clamp(this.Hit_Up, 1857f, 559f));
			this.NBPKMLMCHFN.SetFloat("_BlurPass", Mathf.Clamp(this.Hit_Right, 227f, 1204f));
			this.ACHNOHCLGOO().SetFloat("_Distortion", Mathf.Clamp(this.Hit_Down, 1874f, 1836f));
			this.ADBKPGFMNKO().SetFloat("_Value2", Mathf.Clamp(this.Blood_Hit_Left, 1811f, 817f));
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(this.Blood_Hit_Up, 785f, 1489f));
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(this.Blood_Hit_Right, 873f, 1431f));
			this.ACHNOHCLGOO().SetFloat("sfxVolume", Mathf.Clamp(this.Blood_Hit_Down, 752f, 972f));
			this.NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Clamp(this.Hit_Full, 1029f, 1264f));
			this.ACHNOHCLGOO().SetFloat("GlassDistortion", Mathf.Clamp(this.Blood_Hit_Full_1, 817f, 1427f));
			this.ADBKPGFMNKO().SetFloat("_BlurVector", Mathf.Clamp(this.Blood_Hit_Full_2, 1839f, 1711f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Blood_Hit_Full_3, 1786f, 1482f));
			this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Atmosphere_Rain", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0000BF62 File Offset: 0x0000A162
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x000F0B70 File Offset: 0x000EED70
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
			this.NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(this.Hit_Left, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(this.Hit_Up, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Hit_Right, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(this.Hit_Down, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value6", Mathf.Clamp(this.Blood_Hit_Left, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value7", Mathf.Clamp(this.Blood_Hit_Up, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value8", Mathf.Clamp(this.Blood_Hit_Right, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value9", Mathf.Clamp(this.Blood_Hit_Down, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value10", Mathf.Clamp(this.Hit_Full, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value11", Mathf.Clamp(this.Blood_Hit_Full_1, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value12", Mathf.Clamp(this.Blood_Hit_Full_2, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value13", Mathf.Clamp(this.Blood_Hit_Full_3, 0f, 1f));
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x000F0DD4 File Offset: 0x000EEFD4
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1294f)
			{
				this.HBJJOCHGOPH = 770f;
			}
			this.NBPKMLMCHFN.SetFloat("#", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_FadeShield", this.LightReflect);
			this.ADBKPGFMNKO().SetFloat("\t", Mathf.Clamp(this.Hit_Left, 149f, 1229f));
			this.NBPKMLMCHFN.SetFloat("UI Extensions/UIAdditive", Mathf.Clamp(this.Hit_Up, 995f, 523f));
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Clamp(this.Hit_Right, 1971f, 1618f));
			this.NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", Mathf.Clamp(this.Hit_Down, 1864f, 507f));
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/Blend2Camera_Darken", Mathf.Clamp(this.Blood_Hit_Left, 477f, 264f));
			this.NBPKMLMCHFN.SetFloat("\n", Mathf.Clamp(this.Blood_Hit_Up, 589f, 374f));
			this.ACHNOHCLGOO().SetFloat("_Near", Mathf.Clamp(this.Blood_Hit_Right, 1854f, 932f));
			this.NBPKMLMCHFN.SetFloat("_Blue_G", Mathf.Clamp(this.Blood_Hit_Down, 962f, 1821f));
			this.ACHNOHCLGOO().SetFloat("_BorderColor", Mathf.Clamp(this.Hit_Full, 179f, 582f));
			this.NBPKMLMCHFN.SetFloat("settings.showHP", Mathf.Clamp(this.Blood_Hit_Full_1, 1030f, 262f));
			this.ACHNOHCLGOO().SetFloat("RemoveEnvironmentObject", Mathf.Clamp(this.Blood_Hit_Full_2, 54f, 1254f));
			this.ADBKPGFMNKO().SetFloat("[FileSelector] Dialog canceled", Mathf.Clamp(this.Blood_Hit_Full_3, 1703f, 244f));
			this.NBPKMLMCHFN.SetTexture(" ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0000BFB6 File Offset: 0x0000A1B6
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("InfoText") as Texture2D);
		this.SCShader = Shader.Find("PenaltyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x0000BF62 File Offset: 0x0000A162
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x0000BF62 File Offset: 0x0000A162
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0000BFEF File Offset: 0x0000A1EF
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_Blood_Hit1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x000F1038 File Offset: 0x000EF238
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 977f)
			{
				this.HBJJOCHGOPH = 1572f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value3", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat(" beatThreshold: ", this.LightReflect);
			this.ADBKPGFMNKO().SetFloat("_GreenAmplifier", Mathf.Clamp(this.Hit_Left, 1417f, 1620f));
			this.ADBKPGFMNKO().SetFloat("hand", Mathf.Clamp(this.Hit_Up, 471f, 1245f));
			this.ADBKPGFMNKO().SetFloat(" : ", Mathf.Clamp(this.Hit_Right, 281f, 1810f));
			this.ACHNOHCLGOO().SetFloat("wss://", Mathf.Clamp(this.Hit_Down, 1756f, 574f));
			this.NBPKMLMCHFN.SetFloat("_Distortion", Mathf.Clamp(this.Blood_Hit_Left, 688f, 1789f));
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/TV_Old_Movie", Mathf.Clamp(this.Blood_Hit_Up, 1005f, 1349f));
			this.ACHNOHCLGOO().SetFloat("offsets", Mathf.Clamp(this.Blood_Hit_Right, 674f, 1987f));
			this.ACHNOHCLGOO().SetFloat("NameInfoText", Mathf.Clamp(this.Blood_Hit_Down, 66f, 916f));
			this.ACHNOHCLGOO().SetFloat("_Value3", Mathf.Clamp(this.Hit_Full, 1661f, 1318f));
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Light_Rainbow2", Mathf.Clamp(this.Blood_Hit_Full_1, 764f, 112f));
			this.ADBKPGFMNKO().SetFloat("_BlurRadius4", Mathf.Clamp(this.Blood_Hit_Full_2, 68f, 1542f));
			this.ACHNOHCLGOO().SetFloat("Playing ", Mathf.Clamp(this.Blood_Hit_Full_3, 1022f, 660f));
			this.ACHNOHCLGOO().SetTexture(" cannot be used as a 3D LUT.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x0000C051 File Offset: 0x0000A251
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0000C088 File Offset: 0x0000A288
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ") as Texture2D);
		this.SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0400019C RID: 412
	public Shader SCShader;

	// Token: 0x0400019D RID: 413
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400019E RID: 414
	[Range(0f, 1f)]
	public float Hit_Left = 1f;

	// Token: 0x0400019F RID: 415
	[Range(0f, 1f)]
	public float Hit_Up;

	// Token: 0x040001A0 RID: 416
	[Range(0f, 1f)]
	public float Hit_Right;

	// Token: 0x040001A1 RID: 417
	[Range(0f, 1f)]
	public float Hit_Down;

	// Token: 0x040001A2 RID: 418
	[Range(0f, 1f)]
	public float Blood_Hit_Left;

	// Token: 0x040001A3 RID: 419
	[Range(0f, 1f)]
	public float Blood_Hit_Up;

	// Token: 0x040001A4 RID: 420
	[Range(0f, 1f)]
	public float Blood_Hit_Right;

	// Token: 0x040001A5 RID: 421
	[Range(0f, 1f)]
	public float Blood_Hit_Down;

	// Token: 0x040001A6 RID: 422
	[Range(0f, 1f)]
	public float Hit_Full;

	// Token: 0x040001A7 RID: 423
	[Range(0f, 1f)]
	public float Blood_Hit_Full_1;

	// Token: 0x040001A8 RID: 424
	[Range(0f, 1f)]
	public float Blood_Hit_Full_2;

	// Token: 0x040001A9 RID: 425
	[Range(0f, 1f)]
	public float Blood_Hit_Full_3;

	// Token: 0x040001AA RID: 426
	[Range(0f, 1f)]
	public float LightReflect = 0.5f;

	// Token: 0x040001AB RID: 427
	private Material BJFKDHHMLJH;

	// Token: 0x040001AC RID: 428
	private Texture2D FPHEBLMINDA;
}
