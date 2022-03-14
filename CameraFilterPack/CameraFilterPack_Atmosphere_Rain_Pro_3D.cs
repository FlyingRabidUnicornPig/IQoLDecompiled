/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000037 RID: 55
[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro_3D")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Rain_Pro_3D : MonoBehaviour
{
	// Token: 0x06000E9A RID: 3738 RVA: 0x00010352 File Offset: 0x0000E552
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x000FF478 File Offset: 0x000FD678
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 608f)
			{
				this.HBJJOCHGOPH = 1249f;
			}
			this.IONHGBPGCHK().SetFloat("Save level before uploading?", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_Value", this.Fade);
			this.HFBJAOFLCJI().SetFloat("SettingsCanvas", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 85f && z < 550f)
				{
					this.HFBJAOFLCJI().SetFloat("couldn't be found!", z);
				}
				if (z < 1563f)
				{
					this.HKGAONMOBMH().SetFloat(" not exist", z);
				}
			}
			else
			{
				this.AELJLBOJAIL().SetFloat("LevelEditor/patterns", this.DirectionX);
			}
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Edge_Sigmoid", this.Speed);
			this.AELJLBOJAIL().SetFloat("Clears the console and prints the logs in the specified range", this.Size);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.StormFlashOnOff);
			this.EPCGJFCCAFH().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", this.DropOnOff);
			this.JFDGLLEOPGB().SetFloat("_MainTex2", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("Edited unlock conditions", (float)((!this._Visualize) ? 0 : 0));
			this.ADGHJOHKEHG().SetFloat("_TimeX", this.Drop_Near);
			this.BFGNMFCNDBC().SetFloat("settings.enableranking", this.Drop_Far);
			this.IONHGBPGCHK().SetFloat("Set crosshair color", 859f - this.Drop_With_Obj);
			this.IONHGBPGCHK().SetFloat("[PlayerBase] SetSpeed error: ", this.Myst);
			this.JFDGLLEOPGB().SetColor("InfoCanvas", this.Myst_Color);
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.Drop_Floor_Fluid);
			this.HEHKGPKLAKK().SetVector("Please specify either t or f.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1642f, 969f));
			this.DNLMFEGJJDD().SetTexture("Missing shader in ", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x0001036F File Offset: 0x0000E56F
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("ScrollPanel") as Texture2D);
		this.SCShader = Shader.Find("icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x000103A8 File Offset: 0x0000E5A8
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00010352 File Offset: 0x0000E552
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x0000420A File Offset: 0x0000240A
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00010352 File Offset: 0x0000E552
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x000103DF File Offset: 0x0000E5DF
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x0000420A File Offset: 0x0000240A
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x000FF720 File Offset: 0x000FD920
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 276f)
			{
				this.HBJJOCHGOPH = 1626f;
			}
			this.JFDGLLEOPGB().SetFloat("Default UI Material", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_Value", this.Fade);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/FX_ZebraColor", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 648f && z < 1636f)
				{
					this.BFGNMFCNDBC().SetFloat("_Radius", z);
				}
				if (z < 313f)
				{
					this.BFGNMFCNDBC().SetFloat("InfoCanvas", z);
				}
			}
			else
			{
				this.HEHKGPKLAKK().SetFloat("OpJoinRandomRoom()", this.DirectionX);
			}
			this.EPCGJFCCAFH().SetFloat("_Offsets", this.Speed);
			this.EPCGJFCCAFH().SetFloat("_Value4", this.Size);
			this.BFGNMFCNDBC().SetFloat("_Glitch", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Red_G", this.StormFlashOnOff);
			this.ADGHJOHKEHG().SetFloat("_ScreenResolution", this.DropOnOff);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Gradients_Tech", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("_Green_C", (float)((!this._Visualize) ? 0 : 1));
			this.HKGAONMOBMH().SetFloat("#done", this.Drop_Near);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack_Broken_Screen1", this.Drop_Far);
			this.BFGNMFCNDBC().SetFloat("_Dist", 1534f - this.Drop_With_Obj);
			this.JFDGLLEOPGB().SetFloat("_Value4", this.Myst);
			this.PGPEMMBJOOG().SetColor(" ", this.Myst_Color);
			this.BFGNMFCNDBC().SetFloat("GraphicsQualitySlider", this.Drop_Floor_Fluid);
			this.AELJLBOJAIL().SetVector("ScreenResolutionPanel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 851f, 396f));
			this.DNLMFEGJJDD().SetTexture("_TimeX", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x000FF9C8 File Offset: 0x000FDBC8
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 599f)
			{
				this.HBJJOCHGOPH = 600f;
			}
			this.IONHGBPGCHK().SetFloat("_MatrixColor", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Set Particles Emission", this.Fade);
			this.BFGNMFCNDBC().SetFloat("_BlurVector", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1850f && z < 737f)
				{
					this.AELJLBOJAIL().SetFloat("USE_CORNER_DETECTION", z);
				}
				if (z < 1491f)
				{
					this.JFDGLLEOPGB().SetFloat(". The RPC has been ignored.", z);
				}
			}
			else
			{
				this.IONHGBPGCHK().SetFloat("_ScreenResolution", this.DirectionX);
			}
			this.HFBJAOFLCJI().SetFloat("[DiscordController] Init", this.Speed);
			this.HEHKGPKLAKK().SetFloat("_MaxVelocity", this.Size);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button4", this.Distortion);
			this.IONHGBPGCHK().SetFloat("_DistAmount", this.StormFlashOnOff);
			this.LDNADDJMIPK().SetFloat("_Value4", this.DropOnOff);
			this.IONHGBPGCHK().SetFloat("[PlayerController] ", this._FixDistance);
			this.HKGAONMOBMH().SetFloat("turn: {0:0}", (float)((!this._Visualize) ? 1 : 1));
			this.HKGAONMOBMH().SetFloat("_MainTex2", this.Drop_Near);
			this.DNLMFEGJJDD().SetFloat("isVisible", this.Drop_Far);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", 1774f - this.Drop_With_Obj);
			this.NBPKMLMCHFN.SetFloat(".sav", this.Myst);
			this.NBPKMLMCHFN.SetColor("[PlayerBase] Loaded music", this.Myst_Color);
			this.HKGAONMOBMH().SetFloat("CheckpointsScoreText", this.Drop_Floor_Fluid);
			this.DNLMFEGJJDD().SetVector("score", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1895f, 1425f));
			this.JFDGLLEOPGB().SetTexture("_Distortion", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x000FFC70 File Offset: 0x000FDE70
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 700f)
			{
				this.HBJJOCHGOPH = 1602f;
			}
			this.JFDGLLEOPGB().SetFloat("_DepthLevel", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("_Blend", this.Fade);
			this.BFGNMFCNDBC().SetFloat("ViewMenu", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1005f && z < 1962f)
				{
					this.EPCGJFCCAFH().SetFloat("_ColorLevel", z);
				}
				if (z < 1572f)
				{
					this.HEHKGPKLAKK().SetFloat("Reload Steam Inventory", z);
				}
			}
			else
			{
				this.HEHKGPKLAKK().SetFloat("_ScreenResolution", this.DirectionX);
			}
			this.BFGNMFCNDBC().SetFloat("curScn", this.Speed);
			this.HEHKGPKLAKK().SetFloat("menu.enableselectormusic", this.Size);
			this.IONHGBPGCHK().SetFloat("#mapalreadyexistupdate", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("LobbyCanvas", this.StormFlashOnOff);
			this.ADGHJOHKEHG().SetFloat("_TimeX", this.DropOnOff);
			this.BFGNMFCNDBC().SetFloat("Set satellite radius (offset)", this._FixDistance);
			this.HKGAONMOBMH().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 0));
			this.NBPKMLMCHFN.SetFloat("event", this.Drop_Near);
			this.BFGNMFCNDBC().SetFloat("HandsCountSlider", this.Drop_Far);
			this.EPCGJFCCAFH().SetFloat("maps.", 581f - this.Drop_With_Obj);
			this.IONHGBPGCHK().SetFloat("_RGB", this.Myst);
			this.IONHGBPGCHK().SetColor("[PlayerController] ", this.Myst_Color);
			this.HFBJAOFLCJI().SetFloat("RarityImage", this.Drop_Floor_Fluid);
			this.BFGNMFCNDBC().SetVector("JoinButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1981f, 109f));
			this.PGPEMMBJOOG().SetTexture("/", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x000FFF18 File Offset: 0x000FE118
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1350f)
			{
				this.HBJJOCHGOPH = 1407f;
			}
			this.ADGHJOHKEHG().SetFloat("HandsCountSlider", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("move", this.Fade);
			this.DNLMFEGJJDD().SetFloat("CheckpointsScoreText", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1724f && z < 1024f)
				{
					this.HEHKGPKLAKK().SetFloat(" does not exist!", z);
				}
				if (z < 1040f)
				{
					this.EPCGJFCCAFH().SetFloat("_ToPrevViewProjCombined", z);
				}
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("_MainTex2", this.DirectionX);
			}
			this.HEHKGPKLAKK().SetFloat("ConfigVersionSlider", this.Speed);
			this.BFGNMFCNDBC().SetFloat("_Value2", this.Size);
			this.BFGNMFCNDBC().SetFloat(",0", this.Distortion);
			this.HFBJAOFLCJI().SetFloat("/theme", this.StormFlashOnOff);
			this.DNLMFEGJJDD().SetFloat("id", this.DropOnOff);
			this.ADGHJOHKEHG().SetFloat("_Value3", this._FixDistance);
			this.EPCGJFCCAFH().SetFloat("_Value2", (float)((!this._Visualize) ? 1 : 0));
			this.EPCGJFCCAFH().SetFloat("_Y", this.Drop_Near);
			this.DNLMFEGJJDD().SetFloat("Rtt:{0,4} +/-{1,3}", this.Drop_Far);
			this.JFDGLLEOPGB().SetFloat("menu.enableselectormusic", 1653f - this.Drop_With_Obj);
			this.LDNADDJMIPK().SetFloat("GetGameList failed: ", this.Myst);
			this.HKGAONMOBMH().SetColor("Can't set MaxPlayers when not in that room.", this.Myst_Color);
			this.AELJLBOJAIL().SetFloat("Tab1Content", this.Drop_Floor_Fluid);
			this.ADGHJOHKEHG().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 668f, 1363f));
			this.HKGAONMOBMH().SetTexture("SlidingArea", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00010418 File Offset: 0x0000E618
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x0000420A File Offset: 0x0000240A
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x0001044F File Offset: 0x0000E64F
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00010486 File Offset: 0x0000E686
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load(" Time: ") as Texture2D);
		this.SCShader = Shader.Find("note.3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x001001C0 File Offset: 0x000FE3C0
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1170f)
			{
				this.HBJJOCHGOPH = 1539f;
			}
			this.HFBJAOFLCJI().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_SpherePositionX", this.Fade);
			this.HKGAONMOBMH().SetFloat("Fade", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1970f && z < 35f)
				{
					this.IONHGBPGCHK().SetFloat(".lastCheckpoint.powerupsScore", z);
				}
				if (z < 1460f)
				{
					this.AELJLBOJAIL().SetFloat("curScn", z);
				}
			}
			else
			{
				this.IONHGBPGCHK().SetFloat("CameraFilterPack/Distortion_Twist_Square", this.DirectionX);
			}
			this.IONHGBPGCHK().SetFloat("Ok", this.Speed);
			this.AELJLBOJAIL().SetFloat("{0:0} day{1}, ", this.Size);
			this.IONHGBPGCHK().SetFloat("VisionBlur", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("_Offsets", this.StormFlashOnOff);
			this.HFBJAOFLCJI().SetFloat("[RanksSystem] Init", this.DropOnOff);
			this.IONHGBPGCHK().SetFloat("SetParticlesGravity", this._FixDistance);
			this.DNLMFEGJJDD().SetFloat(",", (float)((!this._Visualize) ? 0 : 1));
			this.DNLMFEGJJDD().SetFloat("RPCs can only be sent in rooms. Call of \"", this.Drop_Near);
			this.NBPKMLMCHFN.SetFloat("_Visualize", this.Drop_Far);
			this.AELJLBOJAIL().SetFloat("_Size", 279f - this.Drop_With_Obj);
			this.HEHKGPKLAKK().SetFloat("<color=white>PhotonView Group: ", this.Myst);
			this.DNLMFEGJJDD().SetColor("_Value2", this.Myst_Color);
			this.JFDGLLEOPGB().SetFloat("_DepthLevel", this.Drop_Floor_Fluid);
			this.JFDGLLEOPGB().SetVector("#alreadyexist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1f, 356f));
			this.AELJLBOJAIL().SetTexture("bool", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x000104BF File Offset: 0x0000E6BF
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("PunRespawn") as Texture2D);
		this.SCShader = Shader.Find("Set Particles Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00100468 File Offset: 0x000FE668
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1395f)
			{
				this.HBJJOCHGOPH = 1665f;
			}
			this.DNLMFEGJJDD().SetFloat(" id: ", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.Fade);
			this.HEHKGPKLAKK().SetFloat("StartRound", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1798f && z < 295f)
				{
					this.AELJLBOJAIL().SetFloat("score", z);
				}
				if (z < 793f)
				{
					this.ADGHJOHKEHG().SetFloat("Joystick1Button6", z);
				}
			}
			else
			{
				this.HEHKGPKLAKK().SetFloat("skins", this.DirectionX);
			}
			this.JFDGLLEOPGB().SetFloat("SetScale", this.Speed);
			this.EPCGJFCCAFH().SetFloat("ENABLE_DITHERING", this.Size);
			this.DNLMFEGJJDD().SetFloat("local CheckCondition = function()", this.Distortion);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Blend2Camera_VividLight", this.StormFlashOnOff);
			this.HEHKGPKLAKK().SetFloat("/", this.DropOnOff);
			this.IONHGBPGCHK().SetFloat("LevelEditor/CustomEventEditor-Text", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("A", (float)((!this._Visualize) ? 1 : 0));
			this.HFBJAOFLCJI().SetFloat("Instrumental", this.Drop_Near);
			this.HFBJAOFLCJI().SetFloat("GameModeText", this.Drop_Far);
			this.HEHKGPKLAKK().SetFloat("\\\"", 321f - this.Drop_With_Obj);
			this.ADGHJOHKEHG().SetFloat("InventoryContent", this.Myst);
			this.HKGAONMOBMH().SetColor(".played", this.Myst_Color);
			this.PGPEMMBJOOG().SetFloat("_Value", this.Drop_Floor_Fluid);
			this.IONHGBPGCHK().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 58f, 787f));
			this.PGPEMMBJOOG().SetTexture("#reward: ", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00100710 File Offset: 0x000FE910
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 646f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.AELJLBOJAIL().SetFloat("/", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("MapEnd", this.Fade);
			this.AELJLBOJAIL().SetFloat("/", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1558f && z < 981f)
				{
					this.DNLMFEGJJDD().SetFloat("_CenterY", z);
				}
				if (z < 1067f)
				{
					this.HEHKGPKLAKK().SetFloat("_Value", z);
				}
			}
			else
			{
				this.ADGHJOHKEHG().SetFloat("menutheme.idunno", this.DirectionX);
			}
			this.HEHKGPKLAKK().SetFloat("_Red_B", this.Speed);
			this.EPCGJFCCAFH().SetFloat("GameScene", this.Size);
			this.ADGHJOHKEHG().SetFloat(" not exist", this.Distortion);
			this.JFDGLLEOPGB().SetFloat("achievements.21.progress", this.StormFlashOnOff);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/TV_VHS", this.DropOnOff);
			this.PGPEMMBJOOG().SetFloat("_Value4", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("[ResourcesManager] Load text error: not found", (float)((!this._Visualize) ? 0 : 0));
			this.HEHKGPKLAKK().SetFloat("_ScreenResolution", this.Drop_Near);
			this.NBPKMLMCHFN.SetFloat("_CenterRadius", this.Drop_Far);
			this.HKGAONMOBMH().SetFloat("Joined room ", 1497f - this.Drop_With_Obj);
			this.ADGHJOHKEHG().SetFloat("achievements.21.completed.", this.Myst);
			this.IONHGBPGCHK().SetColor("_MainTex2", this.Myst_Color);
			this.AELJLBOJAIL().SetFloat("_ConsoleSettings", this.Drop_Floor_Fluid);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1938f, 131f));
			this.IONHGBPGCHK().SetTexture("InfoCanvas", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00010352 File Offset: 0x0000E552
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x000104F8 File Offset: 0x0000E6F8
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain_Pro_3D");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00010352 File Offset: 0x0000E552
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00010531 File Offset: 0x0000E731
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x001009B8 File Offset: 0x000FEBB8
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 423f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.ADGHJOHKEHG().SetFloat("float,0", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", this.Fade);
			this.IONHGBPGCHK().SetFloat("RarityImage", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1202f && z < 1086f)
				{
					this.IONHGBPGCHK().SetFloat("RecordButton", z);
				}
				if (z < 585f)
				{
					this.PGPEMMBJOOG().SetFloat("z", z);
				}
			}
			else
			{
				this.LDNADDJMIPK().SetFloat("_Skybox", this.DirectionX);
			}
			this.NBPKMLMCHFN.SetFloat("The given 2D texture ", this.Speed);
			this.DNLMFEGJJDD().SetFloat("[PlayerBase] Starting game from: ", this.Size);
			this.EPCGJFCCAFH().SetFloat(" - {0}", this.Distortion);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Sharpen_Sharpen", this.StormFlashOnOff);
			this.IONHGBPGCHK().SetFloat("SpawnObj", this.DropOnOff);
			this.IONHGBPGCHK().SetFloat("YES", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("id", (float)((!this._Visualize) ? 1 : 0));
			this.HEHKGPKLAKK().SetFloat("[ResourcesManager] Load text error: not found", this.Drop_Near);
			this.ADGHJOHKEHG().SetFloat("colorA", this.Drop_Far);
			this.BFGNMFCNDBC().SetFloat("\"x", 1355f - this.Drop_With_Obj);
			this.HEHKGPKLAKK().SetFloat("_Green_R", this.Myst);
			this.AELJLBOJAIL().SetColor("_Parameter", this.Myst_Color);
			this.EPCGJFCCAFH().SetFloat(".g", this.Drop_Floor_Fluid);
			this.EPCGJFCCAFH().SetVector("0,7,true,0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 91f, 1715f));
			this.EPCGJFCCAFH().SetTexture("Init", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00010568 File Offset: 0x0000E768
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x0000420A File Offset: 0x0000240A
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00100C60 File Offset: 0x000FEE60
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1540f)
			{
				this.HBJJOCHGOPH = 15f;
			}
			this.PGPEMMBJOOG().SetFloat(".lastCheckpoint.bgcolor", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Tab1Content", this.Fade);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 629f && z < 537f)
				{
					this.IONHGBPGCHK().SetFloat("_FgOverlap", z);
				}
				if (z < 1790f)
				{
					this.NBPKMLMCHFN.SetFloat(" to: ", z);
				}
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("player.lollipop", this.DirectionX);
			}
			this.HKGAONMOBMH().SetFloat("[PlayerBase] Highscore: ", this.Speed);
			this.PGPEMMBJOOG().SetFloat("DPADHOR", this.Size);
			this.HKGAONMOBMH().SetFloat("_Value2", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("OnStatusChanged: {0} current State: {1}", this.StormFlashOnOff);
			this.BFGNMFCNDBC().SetFloat("/icon", this.DropOnOff);
			this.EPCGJFCCAFH().SetFloat(": ", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] Loading checkpoint data", (float)((!this._Visualize) ? 0 : 1));
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Blend2Camera_Screen", this.Drop_Near);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Drop_Far);
			this.NBPKMLMCHFN.SetFloat("ArcsHitsoundTimeDelaySlider", 1986f - this.Drop_With_Obj);
			this.HFBJAOFLCJI().SetFloat(".", this.Myst);
			this.NBPKMLMCHFN.SetColor("\" that takes ", this.Myst_Color);
			this.JFDGLLEOPGB().SetFloat("_TapHigh", this.Drop_Floor_Fluid);
			this.ADGHJOHKEHG().SetVector("FinalScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1392f, 1891f));
			this.IONHGBPGCHK().SetTexture("Oct", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x0001059F File Offset: 0x0000E79F
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("DPADVER") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000105D8 File Offset: 0x0000E7D8
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

	// Token: 0x06000EBD RID: 3773 RVA: 0x0001060F File Offset: 0x0000E80F
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00010646 File Offset: 0x0000E846
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00010352 File Offset: 0x0000E552
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00100F08 File Offset: 0x000FF108
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 442f)
			{
				this.HBJJOCHGOPH = 116f;
			}
			this.IONHGBPGCHK().SetFloat("Data/Editor/leveltemplate", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("_Value3", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1791f && z < 1985f)
				{
					this.PGPEMMBJOOG().SetFloat("_Value2", z);
				}
				if (z < 1838f)
				{
					this.JFDGLLEOPGB().SetFloat("RPC can't be sent to target PhotonPlayer being null! Did not send \"", z);
				}
			}
			else
			{
				this.BFGNMFCNDBC().SetFloat("Items", this.DirectionX);
			}
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.Speed);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/TV_Distorted", this.Size);
			this.IONHGBPGCHK().SetFloat("The given 2D texture ", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("checkpoint", this.StormFlashOnOff);
			this.IONHGBPGCHK().SetFloat(". Name: ", this.DropOnOff);
			this.NBPKMLMCHFN.SetFloat("_Offsets", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("{0:0} minute{1}, ", (float)((!this._Visualize) ? 1 : 1));
			this.BFGNMFCNDBC().SetFloat("2", this.Drop_Near);
			this.HFBJAOFLCJI().SetFloat("time", this.Drop_Far);
			this.DNLMFEGJJDD().SetFloat(". The group number should be at least 1.", 41f - this.Drop_With_Obj);
			this.JFDGLLEOPGB().SetFloat("mapselector.filter.rateduponly", this.Myst);
			this.IONHGBPGCHK().SetColor(".completed", this.Myst_Color);
			this.LDNADDJMIPK().SetFloat("#tryagain", this.Drop_Floor_Fluid);
			this.BFGNMFCNDBC().SetVector("<i>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 41f, 23f));
			this.HFBJAOFLCJI().SetTexture("input", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x0001067D File Offset: 0x0000E87D
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x000106B4 File Offset: 0x0000E8B4
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x001011B0 File Offset: 0x000FF3B0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 956f)
			{
				this.HBJJOCHGOPH = 402f;
			}
			this.AELJLBOJAIL().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("_EmissionColor", this.Fade);
			this.PGPEMMBJOOG().SetFloat("GlassDistortion", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1567f && z < 1586f)
				{
					this.HFBJAOFLCJI().SetFloat("mapselector.filter.rateduponly", z);
				}
				if (z < 554f)
				{
					this.JFDGLLEOPGB().SetFloat("_Value2", z);
				}
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("other.dust0", this.DirectionX);
			}
			this.HEHKGPKLAKK().SetFloat("_Value", this.Speed);
			this.LDNADDJMIPK().SetFloat("SUCCESS! Item submitted! :D :D :D", this.Size);
			this.EPCGJFCCAFH().SetFloat("SubBass", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.StormFlashOnOff);
			this.HEHKGPKLAKK().SetFloat("_ScreenResolution", this.DropOnOff);
			this.HKGAONMOBMH().SetFloat("maps.", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("/", (float)((!this._Visualize) ? 0 : 0));
			this.HFBJAOFLCJI().SetFloat("menu.selectedlevelid", this.Drop_Near);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.Drop_Far);
			this.PGPEMMBJOOG().SetFloat("[GameScene] Checkpoints count: ", 1032f - this.Drop_With_Obj);
			this.IONHGBPGCHK().SetFloat("_Value4", this.Myst);
			this.HKGAONMOBMH().SetColor("player.circle", this.Myst_Color);
			this.PGPEMMBJOOG().SetFloat("[LevelEditorScene] Error: Timeout :S", this.Drop_Floor_Fluid);
			this.HFBJAOFLCJI().SetVector("{0}{1}{2}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 163f, 1195f));
			this.LDNADDJMIPK().SetTexture("CameraFilterPack/Color_BrightContrastSaturation", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x000106EB File Offset: 0x0000E8EB
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x0000420A File Offset: 0x0000240A
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00010722 File Offset: 0x0000E922
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00010759 File Offset: 0x0000E959
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("CurrentTimeLabel") as Texture2D);
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x0000420A File Offset: 0x0000240A
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x0000420A File Offset: 0x0000240A
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00010352 File Offset: 0x0000E552
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00010352 File Offset: 0x0000E552
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00010352 File Offset: 0x0000E552
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x0010151C File Offset: 0x000FF71C
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 70f)
			{
				this.HBJJOCHGOPH = 1076f;
			}
			this.PGPEMMBJOOG().SetFloat("sfxVolume", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("win", this.Fade);
			this.DNLMFEGJJDD().SetFloat("UseScanLine", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1964f && z < 1854f)
				{
					this.EPCGJFCCAFH().SetFloat("_Threshhold", z);
				}
				if (z < 311f)
				{
					this.ADGHJOHKEHG().SetFloat(" Owner called.", z);
				}
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Value1", this.DirectionX);
			}
			this.LDNADDJMIPK().SetFloat("PunRespawn", this.Speed);
			this.EPCGJFCCAFH().SetFloat("{0}", this.Size);
			this.DNLMFEGJJDD().SetFloat("[MapEditor] Openning ", this.Distortion);
			this.HEHKGPKLAKK().SetFloat("FinalScoreText", this.StormFlashOnOff);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.DropOnOff);
			this.HEHKGPKLAKK().SetFloat("NewIconFileSelector", this._FixDistance);
			this.EPCGJFCCAFH().SetFloat("RoomNameText", (float)((!this._Visualize) ? 1 : 1));
			this.JFDGLLEOPGB().SetFloat("Right", this.Drop_Near);
			this.DNLMFEGJJDD().SetFloat("HightScoreMaxPointsText", this.Drop_Far);
			this.HEHKGPKLAKK().SetFloat("_FarCamera", 1983f - this.Drop_With_Obj);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/BlurTiltShift", this.Myst);
			this.LDNADDJMIPK().SetColor("_Value2", this.Myst_Color);
			this.PGPEMMBJOOG().SetFloat("Bad parameters for getstring! Use <key> <value>", this.Drop_Floor_Fluid);
			this.ADGHJOHKEHG().SetVector("LevelEditor/icons", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 382f, 1302f));
			this.DNLMFEGJJDD().SetTexture("float,10", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x0000420A File Offset: 0x0000240A
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00010792 File Offset: 0x0000E992
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("-help") as Texture2D);
		this.SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x001017C4 File Offset: 0x000FF9C4
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 499f)
			{
				this.HBJJOCHGOPH = 750f;
			}
			this.ADGHJOHKEHG().SetFloat("local CheckCondition = function()", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.Fade);
			this.ADGHJOHKEHG().SetFloat("achievements.26.progress", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 493f && z < 593f)
				{
					this.DNLMFEGJJDD().SetFloat("steamid", z);
				}
				if (z < 953f)
				{
					this.EPCGJFCCAFH().SetFloat("ENABLE_EYE_ADAPTATION", z);
				}
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat(" at ", this.DirectionX);
			}
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.Speed);
			this.BFGNMFCNDBC().SetFloat("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", this.Size);
			this.EPCGJFCCAFH().SetFloat("th", this.Distortion);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/FX_Screens", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.DropOnOff);
			this.LDNADDJMIPK().SetFloat(": ", this._FixDistance);
			this.HKGAONMOBMH().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			this.EPCGJFCCAFH().SetFloat("ReplyMatch is false! ", this.Drop_Near);
			this.HKGAONMOBMH().SetFloat("id", this.Drop_Far);
			this.ADGHJOHKEHG().SetFloat("_TimeX", 557f - this.Drop_With_Obj);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Myst);
			this.BFGNMFCNDBC().SetColor("_Value", this.Myst_Color);
			this.HEHKGPKLAKK().SetFloat("default", this.Drop_Floor_Fluid);
			this.HEHKGPKLAKK().SetVector("To {0} at Index {1} \n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 506f, 1378f));
			this.PGPEMMBJOOG().SetTexture("player.goldcrystal", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00101A6C File Offset: 0x000FFC6C
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
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 0f && z < 360f)
				{
					this.NBPKMLMCHFN.SetFloat("_Value3", z);
				}
				if (z < 0f)
				{
					this.NBPKMLMCHFN.SetFloat("_Value3", z);
				}
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			}
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("_Value8", this.DropOnOff);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("Drop_Near", this.Drop_Near);
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.Drop_Far);
			this.NBPKMLMCHFN.SetFloat("Drop_With_Obj", 1f - this.Drop_With_Obj);
			this.NBPKMLMCHFN.SetFloat("Myst", this.Myst);
			this.NBPKMLMCHFN.SetColor("Myst_Color", this.Myst_Color);
			this.NBPKMLMCHFN.SetFloat("Drop_Floor_Fluid", this.Drop_Floor_Fluid);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x000107CB File Offset: 0x0000E9CB
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400021F RID: 543
	public Shader SCShader;

	// Token: 0x04000220 RID: 544
	public bool _Visualize;

	// Token: 0x04000221 RID: 545
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000222 RID: 546
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000223 RID: 547
	private Material BJFKDHHMLJH;

	// Token: 0x04000224 RID: 548
	[Range(0f, 100f)]
	public float _FixDistance = 3f;

	// Token: 0x04000225 RID: 549
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000226 RID: 550
	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	// Token: 0x04000227 RID: 551
	public bool DirectionFollowCameraZ;

	// Token: 0x04000228 RID: 552
	[Range(-0.45f, 0.45f)]
	public float DirectionX = 0.12f;

	// Token: 0x04000229 RID: 553
	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	// Token: 0x0400022A RID: 554
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x0400022B RID: 555
	[Range(0f, 0.5f)]
	public float Distortion = 0.025f;

	// Token: 0x0400022C RID: 556
	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	// Token: 0x0400022D RID: 557
	[Range(0f, 1f)]
	public float DropOnOff = 1f;

	// Token: 0x0400022E RID: 558
	[Range(-0.5f, 0.99f)]
	public float Drop_Near;

	// Token: 0x0400022F RID: 559
	[Range(0f, 1f)]
	public float Drop_Far = 0.5f;

	// Token: 0x04000230 RID: 560
	[Range(0f, 1f)]
	public float Drop_With_Obj = 0.2f;

	// Token: 0x04000231 RID: 561
	[Range(0f, 1f)]
	public float Myst = 0.1f;

	// Token: 0x04000232 RID: 562
	[Range(0f, 1f)]
	public float Drop_Floor_Fluid;

	// Token: 0x04000233 RID: 563
	public Color Myst_Color = new Color(0.5f, 0.5f, 0.5f, 1f);

	// Token: 0x04000234 RID: 564
	private Texture2D FPHEBLMINDA;
}
