/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200001C RID: 28
[AddComponentMenu("Camera Filter Pack/3D/Anomaly")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Anomaly : MonoBehaviour
{
	// Token: 0x06000513 RID: 1299 RVA: 0x00004556 File Offset: 0x00002756
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("Search: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0000457A File Offset: 0x0000277A
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x000045B1 File Offset: 0x000027B1
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x000045D5 File Offset: 0x000027D5
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x000045F9 File Offset: 0x000027F9
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x000CEA94 File Offset: 0x000CCC94
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1136f)
			{
				this.HBJJOCHGOPH = 597f;
			}
			this.OJMHIMIPKME().SetFloat("[Left]", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("LoadMapCanvas", this.Intensity);
			this.KDMBOKLMADJ().SetFloat("[NetworkScene] Exited", this.Anomaly_Distortion);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Broken_Screen", this.Anomaly_Distortion_Size);
			this.IIBLJCKLGFG().SetFloat("[Right]", this.Anomaly_Intensity);
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack/Blur_Focus", (float)((!this._Visualize) ? 0 : 1));
			this.MMOODGIODPC().SetFloat("_Value", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("SetSatelliteRotationSpeed", this.Anomaly_Near);
			this.KEMAALEODNH().SetFloat("Set satellite trail width", this.Anomaly_Far);
			this.NBPKMLMCHFN.SetFloat("FileMenu", this.AnomalyWithoutObject);
			this.LPMLLJKMAMP().SetVector("_NormalAndRoughnessTexture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 777f, 287f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x000CEC1C File Offset: 0x000CCE1C
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 977f)
			{
				this.HBJJOCHGOPH = 637f;
			}
			this.LONNIJMNKFB().SetFloat("Using Stopwatch as precision timer for PUN.", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("_Fade", this.Intensity);
			this.LPCHMEKDCHI().SetFloat("_Value2", this.Anomaly_Distortion);
			this.CIAFLBFJLEJ().SetFloat("maps.", this.Anomaly_Distortion_Size);
			this.NBPKMLMCHFN.SetFloat("Bass", this.Anomaly_Intensity);
			this.KBOPGONOCNP().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.NBPKMLMCHFN.SetFloat("skin.", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("D-Pad Up", this.Anomaly_Near);
			this.MMOODGIODPC().SetFloat("float,0", this.Anomaly_Far);
			this.NFMGLIKNOOC().SetFloat("0.00", this.AnomalyWithoutObject);
			this.KGOLDDBHIFN().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1451f, 1539f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00004616 File Offset: 0x00002816
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0000463A File Offset: 0x0000283A
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0000420A File Offset: 0x0000240A
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x000CEDA4 File Offset: 0x000CCFA4
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1398f)
			{
				this.HBJJOCHGOPH = 1073f;
			}
			this.LPCHMEKDCHI().SetFloat(": ", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("NEW_ACHIEVEMENT_1_", this.Intensity);
			this.NFMGLIKNOOC().SetFloat("Left Stick Click", this.Anomaly_Distortion);
			this.KBOPGONOCNP().SetFloat("NO", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("mapselector.filter.rateduponly", this.Anomaly_Intensity);
			this.MMOODGIODPC().SetFloat("Tab2Content", (float)((!this._Visualize) ? 1 : 0));
			this.KEMJNOMIPHN().SetFloat("X", this._FixDistance);
			this.KEMAALEODNH().SetFloat(":\n", this.Anomaly_Near);
			this.KGOLDDBHIFN().SetFloat("shader.ghost", this.Anomaly_Far);
			this.OJMHIMIPKME().SetFloat("score", this.AnomalyWithoutObject);
			this.KBOPGONOCNP().SetVector("input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 90f, 1711f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0000465E File Offset: 0x0000285E
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x000CEF2C File Offset: 0x000CD12C
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1014f)
			{
				this.HBJJOCHGOPH = 1243f;
			}
			this.LPMLLJKMAMP().SetFloat("_Near", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.Intensity);
			this.LONNIJMNKFB().SetFloat("note.5", this.Anomaly_Distortion);
			this.KEMJNOMIPHN().SetFloat("_Value3", this.Anomaly_Distortion_Size);
			this.KEMJNOMIPHN().SetFloat("shader.frost", this.Anomaly_Intensity);
			this.KDMBOKLMADJ().SetFloat("#ok", (float)((!this._Visualize) ? 0 : 0));
			this.DBOLLHHMKKN().SetFloat("_Radius", this._FixDistance);
			this.KEMAALEODNH().SetFloat("#timeuntilend: ", this.Anomaly_Near);
			this.DBOLLHHMKKN().SetFloat("score", this.Anomaly_Far);
			this.LPCHMEKDCHI().SetFloat("a year ago", this.AnomalyWithoutObject);
			this.IIBLJCKLGFG().SetVector("_HitPointTexture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1316f, 1817f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00004695 File Offset: 0x00002895
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0000420A File Offset: 0x0000240A
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x000045F9 File Offset: 0x000027F9
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x000046B9 File Offset: 0x000028B9
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0000420A File Offset: 0x0000240A
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x000046F0 File Offset: 0x000028F0
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x000CF0B4 File Offset: 0x000CD2B4
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1086f)
			{
				this.HBJJOCHGOPH = 1200f;
			}
			this.DBOLLHHMKKN().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("[PlayerController] ", this.Intensity);
			this.MMOODGIODPC().SetFloat("settings.enablehitsoundsinnormal", this.Anomaly_Distortion);
			this.DBOLLHHMKKN().SetFloat("View ({3}){0} on {1} {2}", this.Anomaly_Distortion_Size);
			this.LPMLLJKMAMP().SetFloat("_Value2", this.Anomaly_Intensity);
			this.KBOPGONOCNP().SetFloat("PointsScoreText", (float)((!this._Visualize) ? 1 : 1));
			this.LPMLLJKMAMP().SetFloat("Need to specify a start index and end index.", this._FixDistance);
			this.LPCHMEKDCHI().SetFloat("Scene", this.Anomaly_Near);
			this.CIAFLBFJLEJ().SetFloat("Encryption wasn't established: ", this.Anomaly_Far);
			this.NFMGLIKNOOC().SetFloat("/icon", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 709f, 596f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x000CF23C File Offset: 0x000CD43C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1407f)
			{
				this.HBJJOCHGOPH = 699f;
			}
			this.KGOLDDBHIFN().SetFloat("Error: you cannot read this stream that you are writing!", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_Value3", this.Intensity);
			this.DBOLLHHMKKN().SetFloat("_Value2", this.Anomaly_Distortion);
			this.MMOODGIODPC().SetFloat("LoadPlayerEnvironment", this.Anomaly_Distortion_Size);
			this.NFMGLIKNOOC().SetFloat("1", this.Anomaly_Intensity);
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 1));
			this.DBOLLHHMKKN().SetFloat("_InvScreenSize", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.Anomaly_Near);
			this.MMOODGIODPC().SetFloat("StartButton", this.Anomaly_Far);
			this.KDMBOKLMADJ().SetFloat("time", this.AnomalyWithoutObject);
			this.OJMHIMIPKME().SetVector("set", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1903f, 1410f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x000045F9 File Offset: 0x000027F9
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00004727 File Offset: 0x00002927
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("'{0}' \t{1}ms \t{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x000045F9 File Offset: 0x000027F9
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0000474B File Offset: 0x0000294B
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00004782 File Offset: 0x00002982
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x000045F9 File Offset: 0x000027F9
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x000047B9 File Offset: 0x000029B9
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x000047F0 File Offset: 0x000029F0
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00004814 File Offset: 0x00002A14
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x000CF3C4 File Offset: 0x000CD5C4
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1797f)
			{
				this.HBJJOCHGOPH = 1156f;
			}
			this.IIBLJCKLGFG().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("ResetButton", this.Intensity);
			this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this.Anomaly_Distortion);
			this.LONNIJMNKFB().SetFloat("_Offsets", this.Anomaly_Distortion_Size);
			this.NBPKMLMCHFN.SetFloat(" ", this.Anomaly_Intensity);
			this.CIAFLBFJLEJ().SetFloat("AudioSampler", (float)((!this._Visualize) ? 0 : 0));
			this.LPCHMEKDCHI().SetFloat("Set Satellite Sensitivity", this._FixDistance);
			this.KEMAALEODNH().SetFloat("r", this.Anomaly_Near);
			this.CIAFLBFJLEJ().SetFloat("_FarCamera", this.Anomaly_Far);
			this.NBPKMLMCHFN.SetFloat("yyyy", this.AnomalyWithoutObject);
			this.NFMGLIKNOOC().SetVector("player.deleted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1952f, 1130f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x000045F9 File Offset: 0x000027F9
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00004838 File Offset: 0x00002A38
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x000045F9 File Offset: 0x000027F9
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0000486F File Offset: 0x00002A6F
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x000045F9 File Offset: 0x000027F9
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00004893 File Offset: 0x00002A93
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x000CF54C File Offset: 0x000CD74C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 528f)
			{
				this.HBJJOCHGOPH = 863f;
			}
			this.LONNIJMNKFB().SetFloat("SUBMIT '{0}' FILES", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.Intensity);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.Anomaly_Distortion);
			this.LPCHMEKDCHI().SetFloat("downloading", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("/?page=ranks", this.Anomaly_Intensity);
			this.KBOPGONOCNP().SetFloat("Bad parameters for set! Use <language>", (float)((!this._Visualize) ? 0 : 0));
			this.KDMBOKLMADJ().SetFloat("DPADVER", this._FixDistance);
			this.MMOODGIODPC().SetFloat("_EmissionGain", this.Anomaly_Near);
			this.OJMHIMIPKME().SetFloat("_LensDirtIntensity", this.Anomaly_Far);
			this.NFMGLIKNOOC().SetFloat("_Value4", this.AnomalyWithoutObject);
			this.KBOPGONOCNP().SetVector("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 435f, 1479f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x000048B7 File Offset: 0x00002AB7
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x000048EE File Offset: 0x00002AEE
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00004912 File Offset: 0x00002B12
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00004949 File Offset: 0x00002B49
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Anomaly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0000420A File Offset: 0x0000240A
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0000420A File Offset: 0x0000240A
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x000CF6D4 File Offset: 0x000CD8D4
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 873f)
			{
				this.HBJJOCHGOPH = 30f;
			}
			this.LONNIJMNKFB().SetFloat("gold", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("value", this.Intensity);
			this.LDNADDJMIPK().SetFloat("SetSunEmission", this.Anomaly_Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Anomaly_Distortion_Size);
			this.IIBLJCKLGFG().SetFloat("_MainTex", this.Anomaly_Intensity);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			this.CIAFLBFJLEJ().SetFloat("PlayButton", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/TV_MovieNoise", this.Anomaly_Near);
			this.KGOLDDBHIFN().SetFloat("CameraMovementSlider", this.Anomaly_Far);
			this.MMOODGIODPC().SetFloat("Preparing content", this.AnomalyWithoutObject);
			this.IIBLJCKLGFG().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1988f, 640f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x000045F9 File Offset: 0x000027F9
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0000420A File Offset: 0x0000240A
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x000045F9 File Offset: 0x000027F9
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0000496D File Offset: 0x00002B6D
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0000420A File Offset: 0x0000240A
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x000CF85C File Offset: 0x000CDA5C
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1699f)
			{
				this.HBJJOCHGOPH = 1565f;
			}
			this.IIBLJCKLGFG().SetFloat("LowMid", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("_AdaptionSpeed", this.Intensity);
			this.IIBLJCKLGFG().SetFloat(" not exist", this.Anomaly_Distortion);
			this.LONNIJMNKFB().SetFloat(" not exist", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("CameraFilterPack_VHS2", this.Anomaly_Intensity);
			this.LPMLLJKMAMP().SetFloat("#E14FFF", (float)((!this._Visualize) ? 0 : 1));
			this.KDMBOKLMADJ().SetFloat("maps.", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("#accuracy", this.Anomaly_Near);
			this.KGOLDDBHIFN().SetFloat("_History3LumaTex", this.Anomaly_Far);
			this.NFMGLIKNOOC().SetFloat("settings.cameramovements", this.AnomalyWithoutObject);
			this.CIAFLBFJLEJ().SetVector("UsernameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 310f, 1452f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x000045F9 File Offset: 0x000027F9
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x000049A4 File Offset: 0x00002BA4
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x000049C8 File Offset: 0x00002BC8
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x000045F9 File Offset: 0x000027F9
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600054D RID: 1357 RVA: 0x000049FF File Offset: 0x00002BFF
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

	// Token: 0x0600054E RID: 1358 RVA: 0x00004A36 File Offset: 0x00002C36
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("#failed!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00004A5A File Offset: 0x00002C5A
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00004A91 File Offset: 0x00002C91
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find(", ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x000045F9 File Offset: 0x000027F9
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x000045F9 File Offset: 0x000027F9
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x00004AB5 File Offset: 0x00002CB5
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Axis");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00004AD9 File Offset: 0x00002CD9
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("Set Object Position");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x000045F9 File Offset: 0x000027F9
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0000420A File Offset: 0x0000240A
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x000045F9 File Offset: 0x000027F9
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0000420A File Offset: 0x0000240A
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00004AFD File Offset: 0x00002CFD
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("VoteDownToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x000CFA5C File Offset: 0x000CDC5C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1791f)
			{
				this.HBJJOCHGOPH = 30f;
			}
			this.KDMBOKLMADJ().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("PerfectHitsScoreText", this.Intensity);
			this.CIAFLBFJLEJ().SetFloat("Object ID. Case-Sensitive", this.Anomaly_Distortion);
			this.KDMBOKLMADJ().SetFloat("menutheme", this.Anomaly_Distortion_Size);
			this.OJMHIMIPKME().SetFloat("_ScreenResolution", this.Anomaly_Intensity);
			this.OJMHIMIPKME().SetFloat("CameraFilterPack/OldFilm_Cutting2", (float)((!this._Visualize) ? 1 : 1));
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this._FixDistance);
			this.HKIMAANBGMJ().SetFloat("gameVolume", this.Anomaly_Near);
			this.KDMBOKLMADJ().SetFloat("Joystick1Button4", this.Anomaly_Far);
			this.LDNADDJMIPK().SetFloat("inventory.selected.", this.AnomalyWithoutObject);
			this.DBOLLHHMKKN().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1948f, 1469f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x000CFBE4 File Offset: 0x000CDDE4
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1222f)
			{
				this.HBJJOCHGOPH = 1900f;
			}
			this.DBOLLHHMKKN().SetFloat("StopMusic", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("_Red_C", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("OpLeaveLobby()", this.Anomaly_Distortion);
			this.KEMJNOMIPHN().SetFloat("masterSteamID", this.Anomaly_Distortion_Size);
			this.CIAFLBFJLEJ().SetFloat("_AllowBackwardsRays", this.Anomaly_Intensity);
			this.CIAFLBFJLEJ().SetFloat("VIGNETTE_FILMIC", (float)((!this._Visualize) ? 0 : 0));
			this.MMOODGIODPC().SetFloat("_Value5", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("{0:x2}", this.Anomaly_Near);
			this.KEMAALEODNH().SetFloat("image", this.Anomaly_Far);
			this.OJMHIMIPKME().SetFloat("_TimeX", this.AnomalyWithoutObject);
			this.NFMGLIKNOOC().SetVector("_DotSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 803f, 506f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00004B21 File Offset: 0x00002D21
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("OnSerialize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x000045F9 File Offset: 0x000027F9
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x000045F9 File Offset: 0x000027F9
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x000045F9 File Offset: 0x000027F9
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x000045F9 File Offset: 0x000027F9
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x000045F9 File Offset: 0x000027F9
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x000CFD6C File Offset: 0x000CDF6C
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 135f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.KEMAALEODNH().SetFloat("_Y", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_Glitch", this.Intensity);
			this.CIAFLBFJLEJ().SetFloat("CheckpointsScoreText", this.Anomaly_Distortion);
			this.HKIMAANBGMJ().SetFloat("menu.selectedplaymode", this.Anomaly_Distortion_Size);
			this.MMOODGIODPC().SetFloat("[PlayerBase] Starting game from: ", this.Anomaly_Intensity);
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/Blend2Camera_Subtract", (float)((!this._Visualize) ? 1 : 1));
			this.KBOPGONOCNP().SetFloat("HitVariationSlider", this._FixDistance);
			this.LPCHMEKDCHI().SetFloat("player.russia", this.Anomaly_Near);
			this.OJMHIMIPKME().SetFloat("Month_", this.Anomaly_Far);
			this.LONNIJMNKFB().SetFloat("[NetworkManager] Connection failed: ", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("VIGNETTE_DESAT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1267f, 1539f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x000045F9 File Offset: 0x000027F9
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMADKINICIN()
	{
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x000045F9 File Offset: 0x000027F9
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x000CFEF4 File Offset: 0x000CE0F4
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1756f)
			{
				this.HBJJOCHGOPH = 196f;
			}
			this.HKIMAANBGMJ().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("RarityImage", this.Intensity);
			this.LONNIJMNKFB().SetFloat("_TintColor", this.Anomaly_Distortion);
			this.KEMAALEODNH().SetFloat("ticket", this.Anomaly_Distortion_Size);
			this.OJMHIMIPKME().SetFloat("</color>", this.Anomaly_Intensity);
			this.LPMLLJKMAMP().SetFloat("Preparing content", (float)((!this._Visualize) ? 0 : 1));
			this.KBOPGONOCNP().SetFloat("_Green_R", this._FixDistance);
			this.OJMHIMIPKME().SetFloat("_TimeX", this.Anomaly_Near);
			this.KEMAALEODNH().SetFloat("_Bullet_8", this.Anomaly_Far);
			this.DBOLLHHMKKN().SetFloat("icon_border", this.AnomalyWithoutObject);
			this.HKIMAANBGMJ().SetVector("JoystickButton13", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1554f, 540f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x000D007C File Offset: 0x000CE27C
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 1971f;
			}
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("ItemNameText", this.Intensity);
			this.LDNADDJMIPK().SetFloat("_SizeX", this.Anomaly_Distortion);
			this.NBPKMLMCHFN.SetFloat("MouseX", this.Anomaly_Distortion_Size);
			this.CIAFLBFJLEJ().SetFloat("MenuVolumeSlider", this.Anomaly_Intensity);
			this.NBPKMLMCHFN.SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Vision_Psycho", this._FixDistance);
			this.DBOLLHHMKKN().SetFloat("_Value2", this.Anomaly_Near);
			this.LPCHMEKDCHI().SetFloat("_ScreenResolution", this.Anomaly_Far);
			this.DBOLLHHMKKN().SetFloat("0.00", this.AnomalyWithoutObject);
			this.OJMHIMIPKME().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1807f, 1165f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00004B45 File Offset: 0x00002D45
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x000045F9 File Offset: 0x000027F9
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x000D0204 File Offset: 0x000CE404
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 301f)
			{
				this.HBJJOCHGOPH = 1112f;
			}
			this.KDMBOKLMADJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.Intensity);
			this.DBOLLHHMKKN().SetFloat("PossibleMapMaxScoreText", this.Anomaly_Distortion);
			this.KEMAALEODNH().SetFloat("/icon", this.Anomaly_Distortion_Size);
			this.DBOLLHHMKKN().SetFloat("Updated!", this.Anomaly_Intensity);
			this.LDNADDJMIPK().SetFloat("SetSunMaxSize", (float)((!this._Visualize) ? 0 : 1));
			this.LPMLLJKMAMP().SetFloat("System.Boolean", this._FixDistance);
			this.IIBLJCKLGFG().SetFloat("_ChangeRed", this.Anomaly_Near);
			this.HKIMAANBGMJ().SetFloat("ItemsCountText", this.Anomaly_Far);
			this.OJMHIMIPKME().SetFloat("_Value2", this.AnomalyWithoutObject);
			this.DBOLLHHMKKN().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1565f, 1504f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00004B7C File Offset: 0x00002D7C
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00004BB3 File Offset: 0x00002DB3
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("move");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x000045F9 File Offset: 0x000027F9
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x000D038C File Offset: 0x000CE58C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 777f)
			{
				this.HBJJOCHGOPH = 1644f;
			}
			this.LPCHMEKDCHI().SetFloat("_Parasite", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", this.Intensity);
			this.OJMHIMIPKME().SetFloat("_TimeX", this.Anomaly_Distortion);
			this.CIAFLBFJLEJ().SetFloat("curScn", this.Anomaly_Distortion_Size);
			this.IIBLJCKLGFG().SetFloat("[PlayerController] ", this.Anomaly_Intensity);
			this.LONNIJMNKFB().SetFloat("rd", (float)((!this._Visualize) ? 1 : 0));
			this.DBOLLHHMKKN().SetFloat("Description goes here", this._FixDistance);
			this.LONNIJMNKFB().SetFloat(": ", this.Anomaly_Near);
			this.NFMGLIKNOOC().SetFloat("11", this.Anomaly_Far);
			this.DBOLLHHMKKN().SetFloat(".status", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("CameraFilterPack/Colors_BleachBypass", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 965f, 1566f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x000D0514 File Offset: 0x000CE714
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1022f)
			{
				this.HBJJOCHGOPH = 1709f;
			}
			this.KEMAALEODNH().SetFloat("StartButton", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("BitsData", this.Intensity);
			this.KBOPGONOCNP().SetFloat("-1", this.Anomaly_Distortion);
			this.LDNADDJMIPK().SetFloat("settings.fps", this.Anomaly_Distortion_Size);
			this.LDNADDJMIPK().SetFloat("EnvironmentSlider", this.Anomaly_Intensity);
			this.LPMLLJKMAMP().SetFloat("Text", (float)((!this._Visualize) ? 0 : 0));
			this.LDNADDJMIPK().SetFloat("AccuracyScoreText", this._FixDistance);
			this.IIBLJCKLGFG().SetFloat("_Bullet_2", this.Anomaly_Near);
			this.KGOLDDBHIFN().SetFloat("Start index must in an integer.", this.Anomaly_Far);
			this.DBOLLHHMKKN().SetFloat("IconImage", this.AnomalyWithoutObject);
			this.CIAFLBFJLEJ().SetVector("<color=#{0}>{1}</color>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1425f, 1763f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00004BD7 File Offset: 0x00002DD7
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("Set sun min/max size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x000D069C File Offset: 0x000CE89C
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Distortion", this.Anomaly_Distortion);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Distortion_Size", this.Anomaly_Distortion_Size);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Intensity", this.Anomaly_Intensity);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Near", this.Anomaly_Near);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Far", this.Anomaly_Far);
			this.NBPKMLMCHFN.SetFloat("Anomaly_With_Obj", this.AnomalyWithoutObject);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00004BFB File Offset: 0x00002DFB
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0000420A File Offset: 0x0000240A
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x000045F9 File Offset: 0x000027F9
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0000420A File Offset: 0x0000240A
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x0000420A File Offset: 0x0000240A
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x000045F9 File Offset: 0x000027F9
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x000D0824 File Offset: 0x000CEA24
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1058f)
			{
				this.HBJJOCHGOPH = 1475f;
			}
			this.NFMGLIKNOOC().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("seconds", this.Intensity);
			this.LPCHMEKDCHI().SetFloat("_Distortion", this.Anomaly_Distortion);
			this.KEMJNOMIPHN().SetFloat("A", this.Anomaly_Distortion_Size);
			this.KBOPGONOCNP().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.Anomaly_Intensity);
			this.DBOLLHHMKKN().SetFloat("_GreenAmplifier", (float)((!this._Visualize) ? 1 : 1));
			this.NBPKMLMCHFN.SetFloat("...", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("_Value", this.Anomaly_Near);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", this.Anomaly_Far);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/Color_Sepia", this.AnomalyWithoutObject);
			this.NBPKMLMCHFN.SetVector("_Params2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 786f, 189f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x000045F9 File Offset: 0x000027F9
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040000D0 RID: 208
	public Shader SCShader;

	// Token: 0x040000D1 RID: 209
	public bool _Visualize;

	// Token: 0x040000D2 RID: 210
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000D3 RID: 211
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000D4 RID: 212
	private Material BJFKDHHMLJH;

	// Token: 0x040000D5 RID: 213
	[Range(0f, 100f)]
	public float _FixDistance = 23f;

	// Token: 0x040000D6 RID: 214
	[Range(-0.5f, 0.99f)]
	public float Anomaly_Near = 0.045f;

	// Token: 0x040000D7 RID: 215
	[Range(0f, 1f)]
	public float Anomaly_Far = 0.11f;

	// Token: 0x040000D8 RID: 216
	[Range(0f, 2f)]
	public float Intensity = 1f;

	// Token: 0x040000D9 RID: 217
	[Range(0f, 1f)]
	public float AnomalyWithoutObject = 1f;

	// Token: 0x040000DA RID: 218
	[Range(0.1f, 1f)]
	public float Anomaly_Distortion = 0.25f;

	// Token: 0x040000DB RID: 219
	[Range(4f, 64f)]
	public float Anomaly_Distortion_Size = 12f;

	// Token: 0x040000DC RID: 220
	[Range(-4f, 8f)]
	public float Anomaly_Intensity = 2f;
}
