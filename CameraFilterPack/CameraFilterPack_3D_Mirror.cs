/*
Importance of this class: Unknown

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
[AddComponentMenu("Camera Filter Pack/3D/Mirror")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Mirror : MonoBehaviour
{
	// Token: 0x0600085E RID: 2142 RVA: 0x00008AE0 File Offset: 0x00006CE0
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00008B17 File Offset: 0x00006D17
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00008B4E File Offset: 0x00006D4E
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("JoinRoom failed. In offline mode you still have to leave a room to enter another.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x000E0108 File Offset: 0x000DE308
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1020f)
			{
				this.HBJJOCHGOPH = 1704f;
			}
			this.KBOPGONOCNP().SetFloat(" - GameWebCallback] - ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1908f)
				{
					this._Distance = 1116f;
				}
				if (this._Distance < 880f)
				{
					this._Distance = 555f;
				}
				this.MFHPKGICPIO().SetFloat("mapselector.filter.subscribedonly", this._Distance);
			}
			else
			{
				this.NLFJGMBCICG().SetFloat("event", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("menu.enableselectormusic", this._Size);
			this.EPCGJFCCAFH().SetFloat("z", this._FixDistance);
			this.ENKPNJMPDEB().SetFloat(": ", this.Fade);
			this.MFHPKGICPIO().SetFloat("22x1", this.Lightning);
			this.NLFJGMBCICG().SetFloat("Clear Environment", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EJDPNJAEAKJ().SetFloat("SetSatelliteRotationSpeed", 394f / farClipPlane);
			this.FKEOGPDLBDD().SetVector("LoadingStatusText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 610f, 604f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00008B72 File Offset: 0x00006D72
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x000E02E4 File Offset: 0x000DE4E4
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 522f)
			{
				this.HBJJOCHGOPH = 1229f;
			}
			this.MFHPKGICPIO().SetFloat("...", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 621f)
				{
					this._Distance = 679f;
				}
				if (this._Distance < 587f)
				{
					this._Distance = 167f;
				}
				this.FEAEGGCNIAA().SetFloat("GameScene", this._Distance);
			}
			else
			{
				this.FOOCJIDNGBB().SetFloat("LivesSlider", this._Distance);
			}
			this.FKEOGPDLBDD().SetFloat("_GlowColor", this._Size);
			this.BBIMPFGLDCP().SetFloat("Set Object Position", this._FixDistance);
			this.ABHDNGIHBKE().SetFloat("challengeid", this.Fade);
			this.FEAEGGCNIAA().SetFloat("y", this.Lightning);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Blend2Camera_HardMix", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NJDIODJNGGA().SetFloat("_VelocityScale", 57f / farClipPlane);
			this.LPCHMEKDCHI().SetVector("R2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 569f, 1414f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00008BC6 File Offset: 0x00006DC6
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x000E04C0 File Offset: 0x000DE6C0
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 232f;
			}
			this.FKEOGPDLBDD().SetFloat("EnvironmentSlider", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1503f)
				{
					this._Distance = 655f;
				}
				if (this._Distance < 77f)
				{
					this._Distance = 38f;
				}
				this.EPCGJFCCAFH().SetFloat("[ResourcesManager] Load text error: not found", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat(" not exist", this._Distance);
			}
			this.MMOODGIODPC().SetFloat("Print the list of scenes, avalable in game.", this._Size);
			this.FEAEGGCNIAA().SetFloat("_Value", this._FixDistance);
			this.HKGAONMOBMH().SetFloat("_Blue_R", this.Fade);
			this.LPCHMEKDCHI().SetFloat("event", this.Lightning);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ABHDNGIHBKE().SetFloat("ShowTitle", 1070f / farClipPlane);
			this.KHCLIAMBBNC().SetVector("SetSatelliteEmission", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1870f, 1571f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00008BFD File Offset: 0x00006DFD
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_ExposureAdjustment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00008C21 File Offset: 0x00006E21
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00008C58 File Offset: 0x00006E58
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00008C7C File Offset: 0x00006E7C
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x000E069C File Offset: 0x000DE89C
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1002f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1495f)
				{
					this._Distance = 603f;
				}
				if (this._Distance < 1036f)
				{
					this._Distance = 827f;
				}
				this.EOCCJGIGEGJ().SetFloat("#yes", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat(".lastCheckpoint.longestComboScore", this._Distance);
			}
			this.BBIMPFGLDCP().SetFloat("_Value2", this._Size);
			this.LNLKMDPHDCC().SetFloat("Crosshair1", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.Fade);
			this.MFHPKGICPIO().SetFloat("_DistortionLevel", this.Lightning);
			this.KEMJNOMIPHN().SetFloat("SpawnObj", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("hidden", 680f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 864f, 416f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00008CB3 File Offset: 0x00006EB3
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0000420A File Offset: 0x0000240A
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00008CD7 File Offset: 0x00006ED7
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("Left Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x0000420A File Offset: 0x0000240A
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00008CFB File Offset: 0x00006EFB
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00008D32 File Offset: 0x00006F32
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00008D69 File Offset: 0x00006F69
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00008DA0 File Offset: 0x00006FA0
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00008DC4 File Offset: 0x00006FC4
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00008DFB File Offset: 0x00006FFB
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("Down");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0000420A File Offset: 0x0000240A
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00008E1F File Offset: 0x0000701F
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x000E0878 File Offset: 0x000DEA78
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1152f)
			{
				this.HBJJOCHGOPH = 1118f;
			}
			this.KBOPGONOCNP().SetFloat("[SaveSystem] Init from ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1957f)
				{
					this._Distance = 579f;
				}
				if (this._Distance < 971f)
				{
					this._Distance = 1934f;
				}
				this.FOOCJIDNGBB().SetFloat("Could not execute RPC ", this._Distance);
			}
			else
			{
				this.ABHDNGIHBKE().SetFloat(" item(s) in inventory", this._Distance);
			}
			this.FEAEGGCNIAA().SetFloat("[MapEditor] Loaded music file: ", this._Size);
			this.MHBAIEKFBIJ().SetFloat("USE_CORNER_DETECTION", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("EnableRankedNotificationsToggle", this.Fade);
			this.HKGAONMOBMH().SetFloat("UpperMid", this.Lightning);
			this.EPCGJFCCAFH().SetFloat("float,1.5", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DOHGBNPMBKG().SetFloat("_Value", 1560f / farClipPlane);
			this.EPCGJFCCAFH().SetVector("_Red_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 584f, 589f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x000E0A54 File Offset: 0x000DEC54
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 854f)
			{
				this.HBJJOCHGOPH = 567f;
			}
			this.FEAEGGCNIAA().SetFloat("Parent object ID. Case-Sensitive", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 264f)
				{
					this._Distance = 1447f;
				}
				if (this._Distance < 718f)
				{
					this._Distance = 1808f;
				}
				this.NBPKMLMCHFN.SetFloat("?", this._Distance);
			}
			else
			{
				this.DOHGBNPMBKG().SetFloat("maps.", this._Distance);
			}
			this.NJDIODJNGGA().SetFloat("0,1,false", this._Size);
			this.NJDIODJNGGA().SetFloat("LoadingStatusText", this._FixDistance);
			this.ENKPNJMPDEB().SetFloat("Item ", this.Fade);
			this.NJDIODJNGGA().SetFloat("[PlayerController] ", this.Lightning);
			this.ABHDNGIHBKE().SetFloat("AddEnvironmentSprite", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("x", 321f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("Drop_Far", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 310f, 483f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x000E0C30 File Offset: 0x000DEE30
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 609f;
			}
			this.FKEOGPDLBDD().SetFloat("_Value2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 183f)
				{
					this._Distance = 530f;
				}
				if (this._Distance < 1357f)
				{
					this._Distance = 1737f;
				}
				this.LMLENGFLEBD().SetFloat(" (now: ", this._Distance);
			}
			else
			{
				this.OOMFJGPAOKL().SetFloat("Using constructor for new PingNativeDynamic()", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat("Joystick1Button3", this._Size);
			this.KEMJNOMIPHN().SetFloat("name", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat(": ", this.Fade);
			this.BBIMPFGLDCP().SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", this.Lightning);
			this.EOCCJGIGEGJ().SetFloat("Cant ask anyone else for PickupItem spawn times.", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("x", 356f / farClipPlane);
			this.BBIMPFGLDCP().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1988f, 1375f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00008E43 File Offset: 0x00007043
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00008E7A File Offset: 0x0000707A
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00008EB1 File Offset: 0x000070B1
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x0000420A File Offset: 0x0000240A
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0000420A File Offset: 0x0000240A
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00008ED5 File Offset: 0x000070D5
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_ChannelMixerRed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00008EF9 File Offset: 0x000070F9
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600088F RID: 2191 RVA: 0x00008F1D File Offset: 0x0000711D
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

	// Token: 0x06000890 RID: 2192 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0000420A File Offset: 0x0000240A
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x000E0E0C File Offset: 0x000DF00C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1317f)
			{
				this.HBJJOCHGOPH = 1858f;
			}
			this.LMLENGFLEBD().SetFloat("mapid", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 777f)
				{
					this._Distance = 1189f;
				}
				if (this._Distance < 1680f)
				{
					this._Distance = 324f;
				}
				this.KEMJNOMIPHN().SetFloat("_Offsets", this._Distance);
			}
			else
			{
				this.DOHGBNPMBKG().SetFloat("Mouse Y", this._Distance);
			}
			this.DOHGBNPMBKG().SetFloat("_Value6", this._Size);
			this.FEAEGGCNIAA().SetFloat("UseFinalGlassColor", this._FixDistance);
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack/Blend2Camera_Overlay", this.Fade);
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Glasses_On", this.Lightning);
			this.MFHPKGICPIO().SetFloat("#8E8E8EFF", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ENKPNJMPDEB().SetFloat("Item ", 253f / farClipPlane);
			this.ABHDNGIHBKE().SetVector("CameraFilterPack/Drawing_NewCellShading", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 678f, 411f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x000E0FE8 File Offset: 0x000DF1E8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1890f)
			{
				this.HBJJOCHGOPH = 1172f;
			}
			this.ABHDNGIHBKE().SetFloat("Fade", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 652f)
				{
					this._Distance = 123f;
				}
				if (this._Distance < 1742f)
				{
					this._Distance = 1787f;
				}
				this.KBOPGONOCNP().SetFloat("SetSatelliteRotationSpeed", this._Distance);
			}
			else
			{
				this.OOMFJGPAOKL().SetFloat("_Value", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("Received OnSerialization for view ID ", this._Size);
			this.FKEOGPDLBDD().SetFloat("_Value2", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("_Value4", this.Fade);
			this.ENKPNJMPDEB().SetFloat("_FarCamera", this.Lightning);
			this.NBPKMLMCHFN.SetFloat("BitsData", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KHCLIAMBBNC().SetFloat("_DotSize", 1764f / farClipPlane);
			this.FKEOGPDLBDD().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 587f, 868f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x000E11C4 File Offset: 0x000DF3C4
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 746f)
			{
				this.HBJJOCHGOPH = 1986f;
			}
			this.LPCHMEKDCHI().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1473f)
				{
					this._Distance = 1714f;
				}
				if (this._Distance < 757f)
				{
					this._Distance = 1502f;
				}
				this.KEMJNOMIPHN().SetFloat("PublishButton", this._Distance);
			}
			else
			{
				this.ENKPNJMPDEB().SetFloat("RecieveChatActionMessage", this._Distance);
			}
			this.MFHPKGICPIO().SetFloat("_Value2", this._Size);
			this.MMOODGIODPC().SetFloat("_TimeX", this._FixDistance);
			this.NLFJGMBCICG().SetFloat("_DotSize", this.Fade);
			this.HKGAONMOBMH().SetFloat("_Value5", this.Lightning);
			this.NBPKMLMCHFN.SetFloat("/", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", 336f / farClipPlane);
			this.LMLENGFLEBD().SetVector("Overlay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 870f, 1899f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0000420A File Offset: 0x0000240A
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x000E13A0 File Offset: 0x000DF5A0
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 205f)
			{
				this.HBJJOCHGOPH = 1864f;
			}
			this.MFHPKGICPIO().SetFloat("challenges.", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 177f)
				{
					this._Distance = 1914f;
				}
				if (this._Distance < 639f)
				{
					this._Distance = 966f;
				}
				this.OOMFJGPAOKL().SetFloat("mapselector.filter.rateduponly", this._Distance);
			}
			else
			{
				this.NLFJGMBCICG().SetFloat("_ScreenResolution", this._Distance);
			}
			this.HKGAONMOBMH().SetFloat(" with a prefix of ", this._Size);
			this.BBIMPFGLDCP().SetFloat("/", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("original.tutorial", this.Fade);
			this.HKGAONMOBMH().SetFloat("start", this.Lightning);
			this.ENKPNJMPDEB().SetFloat("duration", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KHCLIAMBBNC().SetFloat("colorC", 938f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("_CameraClipInfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1370f, 1165f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00008F54 File Offset: 0x00007154
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("Obtain test Item");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00008F78 File Offset: 0x00007178
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00008FAF File Offset: 0x000071AF
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("leave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0000420A File Offset: 0x0000240A
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00008FD3 File Offset: 0x000071D3
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x000E157C File Offset: 0x000DF77C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1328f)
			{
				this.HBJJOCHGOPH = 568f;
			}
			this.NJDIODJNGGA().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 463f)
				{
					this._Distance = 224f;
				}
				if (this._Distance < 1809f)
				{
					this._Distance = 1322f;
				}
				this.FKEOGPDLBDD().SetFloat("/config", this._Distance);
			}
			else
			{
				this.MHBAIEKFBIJ().SetFloat("_Value3", this._Distance);
			}
			this.EPCGJFCCAFH().SetFloat("z", this._Size);
			this.LNLKMDPHDCC().SetFloat("Items/", this._FixDistance);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/BlurHole", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Screenshots only supported in PlayMode", this.Lightning);
			this.LMLENGFLEBD().SetFloat("#restart", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("The region arrays from Name Server are not ok. Must be non-null and same length. ", 499f / farClipPlane);
			this.KHCLIAMBBNC().SetVector("_Green_B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 154f, 1525f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x0000900A File Offset: 0x0000720A
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x000E1758 File Offset: 0x000DF958
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 679f)
			{
				this.HBJJOCHGOPH = 1150f;
			}
			this.FEAEGGCNIAA().SetFloat("PossibleMapPointsText", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1398f)
				{
					this._Distance = 1609f;
				}
				if (this._Distance < 1071f)
				{
					this._Distance = 1104f;
				}
				this.LPCHMEKDCHI().SetFloat("EnableRankedNotificationsToggle", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("_DotSize", this._Distance);
			}
			this.DOHGBNPMBKG().SetFloat("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", this._Size);
			this.FEAEGGCNIAA().SetFloat("#scoresubmitionfailed: ", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("SpawnObj", this.Fade);
			this.LPCHMEKDCHI().SetFloat("AudioSampler", this.Lightning);
			this.EOCCJGIGEGJ().SetFloat(" PhotonNetwork.networkingPeer.AvailableRegions ", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ABHDNGIHBKE().SetFloat("Image", 1587f / farClipPlane);
			this.DOHGBNPMBKG().SetVector("Map already submited. Update?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 690f, 1094f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x000E1934 File Offset: 0x000DFB34
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 716f)
			{
				this.HBJJOCHGOPH = 1093f;
			}
			this.OOMFJGPAOKL().SetFloat("public", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 533f)
				{
					this._Distance = 944f;
				}
				if (this._Distance < 1519f)
				{
					this._Distance = 1134f;
				}
				this.KHCLIAMBBNC().SetFloat("colorA", this._Distance);
			}
			else
			{
				this.EPCGJFCCAFH().SetFloat("Failed to InstantiateSceneObject prefab: ", this._Distance);
			}
			this.MHBAIEKFBIJ().SetFloat("_Value2", this._Size);
			this.LPCHMEKDCHI().SetFloat("curScn", this._FixDistance);
			this.FKEOGPDLBDD().SetFloat("menutheme.deleted", this.Fade);
			this.NJDIODJNGGA().SetFloat("MapEnd", this.Lightning);
			this.KBOPGONOCNP().SetFloat("_Factor", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LMLENGFLEBD().SetFloat("_LensDirt", 33f / farClipPlane);
			this.MFHPKGICPIO().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1570f, 19f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x000E1B10 File Offset: 0x000DFD10
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1786f)
			{
				this.HBJJOCHGOPH = 790f;
			}
			this.DOHGBNPMBKG().SetFloat("remaining: {0:0.000}", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1936f)
				{
					this._Distance = 139f;
				}
				if (this._Distance < 1425f)
				{
					this._Distance = 1501f;
				}
				this.FEAEGGCNIAA().SetFloat("Tab1Content", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("[SERVER] Player ", this._Distance);
			}
			this.KHCLIAMBBNC().SetFloat("Jazz", this._Size);
			this.NJDIODJNGGA().SetFloat("#.##", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat("_Value3", this.Fade);
			this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this.Lightning);
			this.LNLKMDPHDCC().SetFloat("GlassesColor2", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("PointsScoreText", 957f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("float,10", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 123f, 945f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x0000902E File Offset: 0x0000722E
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("SingleplayerButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00009052 File Offset: 0x00007252
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x000E1CEC File Offset: 0x000DFEEC
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
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Lightning", this.Lightning);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
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

	// Token: 0x060008AB RID: 2219 RVA: 0x0000420A File Offset: 0x0000240A
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x000E1EC8 File Offset: 0x000E00C8
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1693f)
			{
				this.HBJJOCHGOPH = 896f;
			}
			this.LNLKMDPHDCC().SetFloat("Joystick1Button1", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 551f)
				{
					this._Distance = 891f;
				}
				if (this._Distance < 448f)
				{
					this._Distance = 258f;
				}
				this.CFEDGDGBCHE().SetFloat("_Value3", this._Distance);
			}
			else
			{
				this.MFHPKGICPIO().SetFloat("_BlurCoe", this._Distance);
			}
			this.FKEOGPDLBDD().SetFloat("AudioSampler", this._Size);
			this.NJDIODJNGGA().SetFloat("selector", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat("/icon", this.Fade);
			this.HKGAONMOBMH().SetFloat("SfxVolumeSlider", this.Lightning);
			this.KHCLIAMBBNC().SetFloat(" ", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LMLENGFLEBD().SetFloat("resource", 1225f / farClipPlane);
			this.LPCHMEKDCHI().SetVector("Network destroy Instantiated GO: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1579f, 117f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00008C58 File Offset: 0x00006E58
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x0000420A File Offset: 0x0000240A
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x00009089 File Offset: 0x00007289
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x000090C0 File Offset: 0x000072C0
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x000E20A4 File Offset: 0x000E02A4
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 37f)
			{
				this.HBJJOCHGOPH = 324f;
			}
			this.NLFJGMBCICG().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 727f)
				{
					this._Distance = 262f;
				}
				if (this._Distance < 1094f)
				{
					this._Distance = 1165f;
				}
				this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.KBOPGONOCNP().SetFloat("_Green_G", this._Distance);
			}
			this.LPCHMEKDCHI().SetFloat("Unsupported type: ", this._Size);
			this.MFHPKGICPIO().SetFloat("_Light", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("ResetButton", this.Fade);
			this.MFHPKGICPIO().SetFloat(".message", this.Lightning);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OOMFJGPAOKL().SetFloat("_VignettingDirt", 291f / farClipPlane);
			this.KBOPGONOCNP().SetVector("_FadeShield", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1638f, 249f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x000090E4 File Offset: 0x000072E4
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x0000911B File Offset: 0x0000731B
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x0000420A File Offset: 0x0000240A
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00009152 File Offset: 0x00007352
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00009176 File Offset: 0x00007376
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x000091AD File Offset: 0x000073AD
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("Source Object: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x000091D1 File Offset: 0x000073D1
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x000091F5 File Offset: 0x000073F5
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x0000420A File Offset: 0x0000240A
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x0000922C File Offset: 0x0000742C
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x000E22E0 File Offset: 0x000E04E0
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1951f)
			{
				this.HBJJOCHGOPH = 1147f;
			}
			this.FEAEGGCNIAA().SetFloat("-1", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1687f)
				{
					this._Distance = 209f;
				}
				if (this._Distance < 510f)
				{
					this._Distance = 1856f;
				}
				this.LPCHMEKDCHI().SetFloat("_Value2", this._Distance);
			}
			else
			{
				this.NLFJGMBCICG().SetFloat("Xbox Home", this._Distance);
			}
			this.EPCGJFCCAFH().SetFloat("Joystick1Button7", this._Size);
			this.OOMFJGPAOKL().SetFloat("/", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", this.Fade);
			this.EPCGJFCCAFH().SetFloat("1177138211", this.Lightning);
			this.LPCHMEKDCHI().SetFloat("RecordButton", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KBOPGONOCNP().SetFloat("ready", 1706f / farClipPlane);
			this.KBOPGONOCNP().SetVector("ResourceFileSelector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 717f, 1166f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x0000420A File Offset: 0x0000240A
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00009250 File Offset: 0x00007450
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("Start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x0000420A File Offset: 0x0000240A
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x0000420A File Offset: 0x0000240A
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00009274 File Offset: 0x00007474
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x000E24BC File Offset: 0x000E06BC
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 407f)
			{
				this.HBJJOCHGOPH = 1775f;
			}
			this.ABHDNGIHBKE().SetFloat("x", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 965f)
				{
					this._Distance = 1577f;
				}
				if (this._Distance < 1241f)
				{
					this._Distance = 1442f;
				}
				this.ABHDNGIHBKE().SetFloat("_Near", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat(" respawn: ", this._Distance);
			}
			this.DOHGBNPMBKG().SetFloat("DPADVER", this._Size);
			this.ABHDNGIHBKE().SetFloat("EndlessLoopsScoreText", this._FixDistance);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.Fade);
			this.KHCLIAMBBNC().SetFloat("scn", this.Lightning);
			this.OOMFJGPAOKL().SetFloat("maps.", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("OpChangeGroups()", 691f / farClipPlane);
			this.ENKPNJMPDEB().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 760f, 1509f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00009298 File Offset: 0x00007498
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0000420A File Offset: 0x0000240A
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x000092CF File Offset: 0x000074CF
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00009306 File Offset: 0x00007506
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x0000933D File Offset: 0x0000753D
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x0000420A File Offset: 0x0000240A
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x000E2698 File Offset: 0x000E0898
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1423f)
			{
				this.HBJJOCHGOPH = 1131f;
			}
			this.KHCLIAMBBNC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 877f)
				{
					this._Distance = 305f;
				}
				if (this._Distance < 464f)
				{
					this._Distance = 957f;
				}
				this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("SetCrosshairEmission", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("maps.", this._Size);
			this.BBIMPFGLDCP().SetFloat("_TimeX", this._FixDistance);
			this.KBOPGONOCNP().SetFloat("_Red_C", this.Fade);
			this.EPCGJFCCAFH().SetFloat("[Left]", this.Lightning);
			this.CFEDGDGBCHE().SetFloat("roomDescription", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("Anomaly_Far", 1062f / farClipPlane);
			this.MMOODGIODPC().SetVector("CameraFilterPack/Colors_Brightness", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 448f, 978f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x0000420A File Offset: 0x0000240A
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00008C58 File Offset: 0x00006E58
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00008BA9 File Offset: 0x00006DA9
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00009374 File Offset: 0x00007574
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x0000420A File Offset: 0x0000240A
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x0400014A RID: 330
	public Shader SCShader;

	// Token: 0x0400014B RID: 331
	public bool _Visualize;

	// Token: 0x0400014C RID: 332
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400014D RID: 333
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400014E RID: 334
	private Material BJFKDHHMLJH;

	// Token: 0x0400014F RID: 335
	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	// Token: 0x04000150 RID: 336
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	// Token: 0x04000151 RID: 337
	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	// Token: 0x04000152 RID: 338
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000153 RID: 339
	[Range(0f, 2f)]
	public float Lightning = 2f;

	// Token: 0x04000154 RID: 340
	public bool AutoAnimatedNear;

	// Token: 0x04000155 RID: 341
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000156 RID: 342
	public static Color ChangeColorRGB;
}
