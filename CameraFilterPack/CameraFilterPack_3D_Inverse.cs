/*
Importance of this class: Unknown

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000023 RID: 35
[AddComponentMenu("Camera Filter Pack/3D/Inverse")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Inverse : MonoBehaviour
{
	// Token: 0x0600073F RID: 1855 RVA: 0x000073BE File Offset: 0x000055BE
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x000073DB File Offset: 0x000055DB
	private Material HBLDMJCOAHA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x0000420A File Offset: 0x0000240A
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00007412 File Offset: 0x00005612
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00007449 File Offset: 0x00005649
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("RateButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x000073BE File Offset: 0x000055BE
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x0000746D File Offset: 0x0000566D
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x000073BE File Offset: 0x000055BE
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x0000420A File Offset: 0x0000240A
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x000D9C4C File Offset: 0x000D7E4C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1245f)
			{
				this.HBJJOCHGOPH = 1541f;
			}
			this.FNAFGEMJBDA().SetFloat("_Value", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 480f)
				{
					this._Distance = 1384f;
				}
				if (this._Distance < 387f)
				{
					this._Distance = 1830f;
				}
				this.EFDEIFCDAFG().SetFloat("CameraFilterPack/AAA_Blood_Plus", this._Distance);
			}
			else
			{
				this.EFDEIFCDAFG().SetFloat("_Value2", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("Texture2", this._Size);
			this.OLHDPICFBOF().SetFloat("Data/Localization", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat("LivesSlider", this.LightIntensity);
			this.BBIMPFGLDCP().SetFloat("#pleasewait", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CFEDGDGBCHE().SetFloat("[DiscordController] Join ({0})", 1195f / farClipPlane);
			this.MALMMJNPILJ().SetVector("[MapsData] Caching ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 35f, 1294f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x000D9E14 File Offset: 0x000D8014
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 750f)
			{
				this.HBJJOCHGOPH = 782f;
			}
			this.HBLDMJCOAHA().SetFloat("#yes", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1303f)
				{
					this._Distance = 1141f;
				}
				if (this._Distance < 545f)
				{
					this._Distance = 1552f;
				}
				this.OIMMPLPBLBK().SetFloat("VIGNETTE_FILMIC", this._Distance);
			}
			else
			{
				this.MALMMJNPILJ().SetFloat("_Blend", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("skin.hit_perfect", this._Size);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/Edge_Sigmoid", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", this.LightIntensity);
			this.MCDGIILBNIF().SetFloat("0.00", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LONNIJMNKFB().SetFloat(" ", 518f / farClipPlane);
			this.MALMMJNPILJ().SetVector(";", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1749f, 1436f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x000073BE File Offset: 0x000055BE
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00007491 File Offset: 0x00005691
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x000074C8 File Offset: 0x000056C8
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("Cancel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x0000420A File Offset: 0x0000240A
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x0000420A File Offset: 0x0000240A
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x000074EC File Offset: 0x000056EC
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find(" Also make sure to disable sprite packing for this sprite.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00007510 File Offset: 0x00005710
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x000073BE File Offset: 0x000055BE
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00007547 File Offset: 0x00005747
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_AllowBackwardsRays");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0000756B File Offset: 0x0000576B
	private void IBJIBLHJKMG()
	{
		this.SCShader = Shader.Find("player.redlifering");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x0000758F File Offset: 0x0000578F
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("_BgFade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x000075B3 File Offset: 0x000057B3
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_Circle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x000075D7 File Offset: 0x000057D7
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000075FB File Offset: 0x000057FB
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x000073BE File Offset: 0x000055BE
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00007632 File Offset: 0x00005832
	private void DKEHGPPOKEA()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x000073BE File Offset: 0x000055BE
	private void JAFOCEDILNK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00007656 File Offset: 0x00005856
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[MapEditor] Updating map assets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x0000767A File Offset: 0x0000587A
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Inverse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x0000769E File Offset: 0x0000589E
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x000D9FDC File Offset: 0x000D81DC
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1853f)
			{
				this.HBJJOCHGOPH = 1392f;
			}
			this.LELKBCALFCF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1365f)
				{
					this._Distance = 770f;
				}
				if (this._Distance < 159f)
				{
					this._Distance = 666f;
				}
				this.GCDFNHMJMIP().SetFloat(".progress", this._Distance);
			}
			else
			{
				this.MALMMJNPILJ().SetFloat("LoadingStatusText", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("#ok", this._Size);
			this.EJDPNJAEAKJ().SetFloat("Tab2Content", this._FixDistance);
			this.CEKJODEAMGB().SetFloat("_LightIntensity", this.LightIntensity);
			this.FAIFBBGFAIB().SetFloat("NewIconFileSelector", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MMOODGIODPC().SetFloat("_MaxRadiusOrKInPaper", 915f / farClipPlane);
			this.LPMLLJKMAMP().SetVector("OnPress", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 78f, 616f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x000073BE File Offset: 0x000055BE
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x0000420A File Offset: 0x0000240A
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x000DA1A4 File Offset: 0x000D83A4
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1756f)
			{
				this.HBJJOCHGOPH = 1330f;
			}
			this.FEAEGGCNIAA().SetFloat(" cannot be used as a 3D LUT.", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1160f)
				{
					this._Distance = 1553f;
				}
				if (this._Distance < 1351f)
				{
					this._Distance = 1153f;
				}
				this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/FX_Glitch2", this._Distance);
			}
			else
			{
				this.FLGPDBBKAIP().SetFloat(" base map(s)", this._Distance);
			}
			this.LONNIJMNKFB().SetFloat("EnableRankingToggle", this._Size);
			this.BBIMPFGLDCP().SetFloat(":</b> ", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("_Glitch", this.LightIntensity);
			this.OLHDPICFBOF().SetFloat("Cant ask anyone else for PickupItem spawn times.", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OLHDPICFBOF().SetFloat("BloodAlternative1", 1939f / farClipPlane);
			this.LONNIJMNKFB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 304f, 59f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x000073BE File Offset: 0x000055BE
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x0000420A File Offset: 0x0000240A
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0000420A File Offset: 0x0000240A
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0000420A File Offset: 0x0000240A
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x000076D5 File Offset: 0x000058D5
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_ForceYSwap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x000076F9 File Offset: 0x000058F9
	private void FEGJMDDIDIC()
	{
		this.SCShader = Shader.Find("couldn't be found!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x000DA36C File Offset: 0x000D856C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 917f)
			{
				this.HBJJOCHGOPH = 1851f;
			}
			this.LELKBCALFCF().SetFloat("LoadingStatusText", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1870f)
				{
					this._Distance = 1996f;
				}
				if (this._Distance < 125f)
				{
					this._Distance = 1612f;
				}
				this.OIIDAKBILMI().SetFloat("bool", this._Distance);
			}
			else
			{
				this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("y", this._Size);
			this.HHIAIGCAHDA().SetFloat("PlayersScrollRectContent", this._FixDistance);
			this.ADGHJOHKEHG().SetFloat("/icon", this.LightIntensity);
			this.OLHDPICFBOF().SetFloat("AudioSampler", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MMOODGIODPC().SetFloat(" ", 15f / farClipPlane);
			this.LPMLLJKMAMP().SetVector("<b>Speed</b>:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1949f, 1322f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x0000771D File Offset: 0x0000591D
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x0000420A File Offset: 0x0000240A
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00007741 File Offset: 0x00005941
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("settings.arcsdestroydelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x000073BE File Offset: 0x000055BE
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x0000420A File Offset: 0x0000240A
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00007765 File Offset: 0x00005965
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00007789 File Offset: 0x00005989
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x000073BE File Offset: 0x000055BE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x000077AD File Offset: 0x000059AD
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("[PlayerBase] Loading checkpoint data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x000073BE File Offset: 0x000055BE
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x000077D1 File Offset: 0x000059D1
	private Material FNAFGEMJBDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00007808 File Offset: 0x00005A08
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Map submitted!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x0000782C File Offset: 0x00005A2C
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000DA534 File Offset: 0x000D8734
	private void KODKKCOKEPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1490f)
			{
				this.HBJJOCHGOPH = 330f;
			}
			this.JFDGLLEOPGB().SetFloat("Run a command for the Localization Servise", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1263f)
				{
					this._Distance = 1874f;
				}
				if (this._Distance < 1978f)
				{
					this._Distance = 1469f;
				}
				this.EFDEIFCDAFG().SetFloat("mapselector.filter.subscribedonly", this._Distance);
			}
			else
			{
				this.LPPEPKGFOEM().SetFloat("color", this._Distance);
			}
			this.HHIAIGCAHDA().SetFloat("_NeighbourMaxTex", this._Size);
			this.OIIDAKBILMI().SetFloat("_TimeX", this._FixDistance);
			this.ADGHJOHKEHG().SetFloat("_ScreenResolution", this.LightIntensity);
			this.CFEDGDGBCHE().SetFloat("EventSystem", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("input", 1551f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("_Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 274f, 1406f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x0000420A File Offset: 0x0000240A
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x000073BE File Offset: 0x000055BE
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x0000420A File Offset: 0x0000240A
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000073BE File Offset: 0x000055BE
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00007863 File Offset: 0x00005A63
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x000DA6FC File Offset: 0x000D88FC
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1402f)
			{
				this.HBJJOCHGOPH = 582f;
			}
			this.HHIAIGCAHDA().SetFloat("Start", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 858f)
				{
					this._Distance = 1511f;
				}
				if (this._Distance < 26f)
				{
					this._Distance = 144f;
				}
				this.BBIMPFGLDCP().SetFloat("mapselector.orderby", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this._Distance);
			}
			this.FEAEGGCNIAA().SetFloat("</color>", this._Size);
			this.EFDEIFCDAFG().SetFloat("Right", this._FixDistance);
			this.CEKJODEAMGB().SetFloat("Horizontal", this.LightIntensity);
			this.OIMMPLPBLBK().SetFloat(".lastCheckpoint.isMapCompleted", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OLHDPICFBOF().SetFloat("/", 1878f / farClipPlane);
			this.CEKJODEAMGB().SetVector("_CenterX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 542f, 1182f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00007887 File Offset: 0x00005A87
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x000078BE File Offset: 0x00005ABE
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x000078E2 File Offset: 0x00005AE2
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("Source: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x000073BE File Offset: 0x000055BE
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x0000420A File Offset: 0x0000240A
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x000073BE File Offset: 0x000055BE
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00007906 File Offset: 0x00005B06
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("{0:0.0} ms ({1:0.} fps)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0000792A File Offset: 0x00005B2A
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00007961 File Offset: 0x00005B61
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x000DA8C4 File Offset: 0x000D8AC4
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1328f)
			{
				this.HBJJOCHGOPH = 758f;
			}
			this.IGIAPKPKGPK().SetFloat("0,1,false", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1963f)
				{
					this._Distance = 255f;
				}
				if (this._Distance < 712f)
				{
					this._Distance = 1609f;
				}
				this.OIIDAKBILMI().SetFloat("_Bloom0", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("_Value2", this._Distance);
			}
			this.OLHDPICFBOF().SetFloat("_Red_B", this._Size);
			this.FAIFBBGFAIB().SetFloat("unsubscribemap", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("_TimeX", this.LightIntensity);
			this.EJDPNJAEAKJ().SetFloat("menu.enableselectormusic", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPPEPKGFOEM().SetFloat("_TapMedium", 1921f / farClipPlane);
			this.FLGPDBBKAIP().SetVector("_Threshhold", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 273f, 768f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x000DAA8C File Offset: 0x000D8C8C
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1173f)
			{
				this.HBJJOCHGOPH = 856f;
			}
			this.EFDEIFCDAFG().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 852f)
				{
					this._Distance = 1226f;
				}
				if (this._Distance < 1568f)
				{
					this._Distance = 1311f;
				}
				this.CFEDGDGBCHE().SetFloat("{0:0} hour{1}, ", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat(" canvas not found", this._Distance);
			}
			this.FAIFBBGFAIB().SetFloat("#restart", this._Size);
			this.FEAEGGCNIAA().SetFloat(" has been disabled as it's not supported on the current platform.", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.LightIntensity);
			this.FAIFBBGFAIB().SetFloat("_Value4", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat("_Bullet_9", 1462f / farClipPlane);
			this.LPPEPKGFOEM().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 900f, 727f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x000073BE File Offset: 0x000055BE
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600078E RID: 1934 RVA: 0x0000782C File Offset: 0x00005A2C
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

	// Token: 0x0600078F RID: 1935 RVA: 0x00007998 File Offset: 0x00005B98
	private void DOFDGBGEDFI()
	{
		this.SCShader = Shader.Find("ready");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x000073BE File Offset: 0x000055BE
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x000079BC File Offset: 0x00005BBC
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x000DACAC File Offset: 0x000D8EAC
	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 677f)
			{
				this.HBJJOCHGOPH = 777f;
			}
			this.MMOODGIODPC().SetFloat("cancel", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 220f)
				{
					this._Distance = 1576f;
				}
				if (this._Distance < 1439f)
				{
					this._Distance = 1179f;
				}
				this.IGKFMCPDNOI().SetFloat("_CameraToWorldMatrix", this._Distance);
			}
			else
			{
				this.CIAFLBFJLEJ().SetFloat("_Value3", this._Distance);
			}
			this.LONNIJMNKFB().SetFloat("/", this._Size);
			this.LPPEPKGFOEM().SetFloat("_Distortion", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat("#8E8E8EFF", this.LightIntensity);
			this.OLHDPICFBOF().SetFloat("ConfigVersionSlider", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLGPDBBKAIP().SetFloat("_Gamma", 1459f / farClipPlane);
			this.BBIMPFGLDCP().SetVector("selector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 887f, 1498f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x000073BE File Offset: 0x000055BE
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0000420A File Offset: 0x0000240A
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x000DAE74 File Offset: 0x000D9074
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 286f)
			{
				this.HBJJOCHGOPH = 448f;
			}
			this.EFDEIFCDAFG().SetFloat("time", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1219f)
				{
					this._Distance = 1303f;
				}
				if (this._Distance < 794f)
				{
					this._Distance = 484f;
				}
				this.OLHDPICFBOF().SetFloat(".lastCheckpoint.lives", this._Distance);
			}
			else
			{
				this.CEKJODEAMGB().SetFloat("player.licenceaccepted", this._Distance);
			}
			this.EFDEIFCDAFG().SetFloat("_Threshold", this._Size);
			this.HHLFDHNEIAH().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", this._FixDistance);
			this.LELKBCALFCF().SetFloat("#tryagain", this.LightIntensity);
			this.ADBKPGFMNKO().SetFloat("#outdatedmap! Challenges will not work!", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ELBMIEOIABA().SetFloat("float,10", 48f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("settings.gamemessagesduration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1395f, 1845f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x000DB03C File Offset: 0x000D923C
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1017f)
			{
				this.HBJJOCHGOPH = 1609f;
			}
			this.IGKFMCPDNOI().SetFloat("SaveButton", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1271f)
				{
					this._Distance = 1303f;
				}
				if (this._Distance < 859f)
				{
					this._Distance = 224f;
				}
				this.HHLFDHNEIAH().SetFloat("[PlayerController] ", this._Distance);
			}
			else
			{
				this.BBIMPFGLDCP().SetFloat("downloading", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("_EmissionGain", this._Size);
			this.MCDGIILBNIF().SetFloat("_ScreenResolution", this._FixDistance);
			this.HHLFDHNEIAH().SetFloat("/", this.LightIntensity);
			this.FNAFGEMJBDA().SetFloat("_Value5", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat("[DiscordController] Sectate ({0})", 776f / farClipPlane);
			this.GCDFNHMJMIP().SetVector("GridDataStoryboard", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 554f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0000420A File Offset: 0x0000240A
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x000073BE File Offset: 0x000055BE
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x000DB204 File Offset: 0x000D9404
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1327f)
			{
				this.HBJJOCHGOPH = 1799f;
			}
			this.LPPEPKGFOEM().SetFloat("MenuScene", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1911f)
				{
					this._Distance = 395f;
				}
				if (this._Distance < 1383f)
				{
					this._Distance = 1858f;
				}
				this.LDNADDJMIPK().SetFloat(" cannot be used as a 3D LUT.", this._Distance);
			}
			else
			{
				this.HHIAIGCAHDA().SetFloat("id", this._Distance);
			}
			this.FNAFGEMJBDA().SetFloat("_Saturation", this._Size);
			this.LELKBCALFCF().SetFloat("CameraFilterPack/Color_Chromatic_Plus", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("Run a command for the Localization Servise", this.LightIntensity);
			this.MALMMJNPILJ().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHLFDHNEIAH().SetFloat("PAUSE [SPACE]", 1998f / farClipPlane);
			this.HHLFDHNEIAH().SetVector("CameraFilterPack_AAA_Blood2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1738f, 1842f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x000079F3 File Offset: 0x00005BF3
	private void HPFIHLMKIPF()
	{
		this.SCShader = Shader.Find("_LensDirt");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x000073BE File Offset: 0x000055BE
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x000DB3CC File Offset: 0x000D95CC
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 770f)
			{
				this.HBJJOCHGOPH = 1257f;
			}
			this.NBPKMLMCHFN.SetFloat(". Client should be in a room. Current connectionStateDetailed: ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1387f)
				{
					this._Distance = 428f;
				}
				if (this._Distance < 1485f)
				{
					this._Distance = 143f;
				}
				this.MMOODGIODPC().SetFloat(": ", this._Distance);
			}
			else
			{
				this.IGIAPKPKGPK().SetFloat("editorVolume", this._Distance);
			}
			this.BBIMPFGLDCP().SetFloat("CameraFilterPack/Drawing_NewCellShading", this._Size);
			this.LONNIJMNKFB().SetFloat("BitsData", this._FixDistance);
			this.ELBMIEOIABA().SetFloat("blue", this.LightIntensity);
			this.EJDPNJAEAKJ().SetFloat("skin.", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIMMPLPBLBK().SetFloat("OK", 1862f / farClipPlane);
			this.HHIAIGCAHDA().SetVector("Aug", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1371f, 1265f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00007A17 File Offset: 0x00005C17
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("settings.arcsdestroydelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00007A3B File Offset: 0x00005C3B
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00007A72 File Offset: 0x00005C72
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00007AA9 File Offset: 0x00005CA9
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x000073BE File Offset: 0x000055BE
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00007AE0 File Offset: 0x00005CE0
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x000DB594 File Offset: 0x000D9794
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
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity);
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

	// Token: 0x060007A4 RID: 1956 RVA: 0x00007B04 File Offset: 0x00005D04
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_ChromaticAberration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00007B28 File Offset: 0x00005D28
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00007B5F File Offset: 0x00005D5F
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x000DB75C File Offset: 0x000D995C
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1911f)
			{
				this.HBJJOCHGOPH = 778f;
			}
			this.LDNADDJMIPK().SetFloat("misses", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1444f)
				{
					this._Distance = 1110f;
				}
				if (this._Distance < 983f)
				{
					this._Distance = 606f;
				}
				this.ADBKPGFMNKO().SetFloat("OK", this._Distance);
			}
			else
			{
				this.LONNIJMNKFB().SetFloat("DisableStoryboardToggle", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("PunPickupSimple", this._Size);
			this.OIIDAKBILMI().SetFloat("/", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this.LightIntensity);
			this.ELBMIEOIABA().SetFloat("set environment id", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LELKBCALFCF().SetFloat("_Value2", 1096f / farClipPlane);
			this.LELKBCALFCF().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 306f, 23f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x000DB924 File Offset: 0x000D9B24
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 488f)
			{
				this.HBJJOCHGOPH = 699f;
			}
			this.LPPEPKGFOEM().SetFloat("_DotSize", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 283f)
				{
					this._Distance = 143f;
				}
				if (this._Distance < 1122f)
				{
					this._Distance = 1244f;
				}
				this.IGIAPKPKGPK().SetFloat("{0}{1}{2}={3}", this._Distance);
			}
			else
			{
				this.EJDPNJAEAKJ().SetFloat("_Distortion", this._Distance);
			}
			this.OLHDPICFBOF().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this._Size);
			this.CIAFLBFJLEJ().SetFloat("0.00", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat("Editor/", this.LightIntensity);
			this.HBLDMJCOAHA().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHLFDHNEIAH().SetFloat(" cannot be used as a 3D LUT.", 117f / farClipPlane);
			this.CIAFLBFJLEJ().SetVector("offline", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1579f, 437f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00007B83 File Offset: 0x00005D83
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00007BBA File Offset: 0x00005DBA
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00007BF1 File Offset: 0x00005DF1
	private void MODENHKMKOC()
	{
		this.SCShader = Shader.Find("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00007C15 File Offset: 0x00005E15
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x000073BE File Offset: 0x000055BE
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x000073BE File Offset: 0x000055BE
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x0000420A File Offset: 0x0000240A
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00007C4C File Offset: 0x00005E4C
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00007C70 File Offset: 0x00005E70
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x000DBAEC File Offset: 0x000D9CEC
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1335f)
			{
				this.HBJJOCHGOPH = 589f;
			}
			this.LELKBCALFCF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1762f)
				{
					this._Distance = 1850f;
				}
				if (this._Distance < 1902f)
				{
					this._Distance = 113f;
				}
				this.MCDGIILBNIF().SetFloat("CameraFilterPack/3D_Scan_Scene", this._Distance);
			}
			else
			{
				this.CFEDGDGBCHE().SetFloat("/", this._Distance);
			}
			this.BBIMPFGLDCP().SetFloat("Updated!", this._Size);
			this.ADGHJOHKEHG().SetFloat(",", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat("inventory.selected.", this.LightIntensity);
			this.ELBMIEOIABA().SetFloat("CameraFilterPack/Blur_Blurry", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IGKFMCPDNOI().SetFloat("float,1", 692f / farClipPlane);
			this.HHIAIGCAHDA().SetVector("0.00/0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1100f, 1624f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x000DBCB4 File Offset: 0x000D9EB4
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1606f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			this.MALMMJNPILJ().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1884f)
				{
					this._Distance = 1411f;
				}
				if (this._Distance < 347f)
				{
					this._Distance = 612f;
				}
				this.LELKBCALFCF().SetFloat("settings.gamemessagesduration", this._Distance);
			}
			else
			{
				this.LELKBCALFCF().SetFloat("The observed monobehaviour (", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("[PlayerBase] Game mode: ", this._Size);
			this.IGKFMCPDNOI().SetFloat("_Red_B", this._FixDistance);
			this.CEKJODEAMGB().SetFloat("#FFFFFFFF", this.LightIntensity);
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("In Main Menu", 499f / farClipPlane);
			this.ADGHJOHKEHG().SetVector("GhostSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1239f, 759f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00007CA7 File Offset: 0x00005EA7
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00007CDE File Offset: 0x00005EDE
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x000DBE7C File Offset: 0x000DA07C
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 468f)
			{
				this.HBJJOCHGOPH = 123f;
			}
			this.GCDFNHMJMIP().SetFloat("settings.shaders", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 470f)
				{
					this._Distance = 1325f;
				}
				if (this._Distance < 161f)
				{
					this._Distance = 1970f;
				}
				this.IGKFMCPDNOI().SetFloat("Circle", this._Distance);
			}
			else
			{
				this.LELKBCALFCF().SetFloat("0 - background, 1 - foreground", this._Distance);
			}
			this.MMOODGIODPC().SetFloat("GetGameList failed: ", this._Size);
			this.FAIFBBGFAIB().SetFloat("float,0", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat("no lives color", this.LightIntensity);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/Distortion_Heat", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHLFDHNEIAH().SetFloat("[MapsData] Caching ", 757f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("settings.arcshitsoundtimedelay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1508f, 1127f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00007D15 File Offset: 0x00005F15
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00007D4C File Offset: 0x00005F4C
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x000073BE File Offset: 0x000055BE
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x000073BE File Offset: 0x000055BE
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x000073BE File Offset: 0x000055BE
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x0000420A File Offset: 0x0000240A
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x0000420A File Offset: 0x0000240A
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x000DC044 File Offset: 0x000DA244
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 651f)
			{
				this.HBJJOCHGOPH = 901f;
			}
			this.EFDEIFCDAFG().SetFloat("_Value13", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1840f)
				{
					this._Distance = 108f;
				}
				if (this._Distance < 83f)
				{
					this._Distance = 1149f;
				}
				this.FEAEGGCNIAA().SetFloat(":\n", this._Distance);
			}
			else
			{
				this.HHIAIGCAHDA().SetFloat("turn", this._Distance);
			}
			this.HHIAIGCAHDA().SetFloat("_TimeX", this._Size);
			this.IGKFMCPDNOI().SetFloat("settings.shaders", this._FixDistance);
			this.CIAFLBFJLEJ().SetFloat(" ", this.LightIntensity);
			this.HBLDMJCOAHA().SetFloat("_PrevViewProj", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ELBMIEOIABA().SetFloat("menutheme.27thfloor", 879f / farClipPlane);
			this.LPMLLJKMAMP().SetVector("CameraFilterPack/Blur_Noise", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1174f, 787f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00007D83 File Offset: 0x00005F83
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x000DC20C File Offset: 0x000DA40C
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 526f)
			{
				this.HBJJOCHGOPH = 822f;
			}
			this.MALMMJNPILJ().SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1631f)
				{
					this._Distance = 1920f;
				}
				if (this._Distance < 885f)
				{
					this._Distance = 748f;
				}
				this.HHLFDHNEIAH().SetFloat("_TimeX", this._Distance);
			}
			else
			{
				this.CIAFLBFJLEJ().SetFloat("_BaseTex", this._Distance);
			}
			this.MALMMJNPILJ().SetFloat("_MainTex2", this._Size);
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("_Value3", this.LightIntensity);
			this.LPPEPKGFOEM().SetFloat("_PositionX", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("GlassesColor", 1084f / farClipPlane);
			this.OIMMPLPBLBK().SetVector("_DiffuseColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 539f, 46f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00007DBA File Offset: 0x00005FBA
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x0000420A File Offset: 0x0000240A
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00007DF1 File Offset: 0x00005FF1
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x000DC3D4 File Offset: 0x000DA5D4
	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1006f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			this.LPPEPKGFOEM().SetFloat("#{0}", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 286f)
				{
					this._Distance = 1497f;
				}
				if (this._Distance < 876f)
				{
					this._Distance = 1492f;
				}
				this.LPMLLJKMAMP().SetFloat("OK", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("_Value3", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("/", this._Size);
			this.ADBKPGFMNKO().SetFloat("NEW_ACHIEVEMENT_1_26", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("GhostPosX", this.LightIntensity);
			this.GCDFNHMJMIP().SetFloat("\n", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("_Intensity", 217f / farClipPlane);
			this.LDNADDJMIPK().SetVector("SetSunMaxSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1426f, 1624f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x000DC59C File Offset: 0x000DA79C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 667f)
			{
				this.HBJJOCHGOPH = 766f;
			}
			this.JFDGLLEOPGB().SetFloat("_CurrentMipLevel", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1429f)
				{
					this._Distance = 1180f;
				}
				if (this._Distance < 1060f)
				{
					this._Distance = 1128f;
				}
				this.FLGPDBBKAIP().SetFloat("_Value2", this._Distance);
			}
			else
			{
				this.EJDPNJAEAKJ().SetFloat(" left", this._Distance);
			}
			this.EFDEIFCDAFG().SetFloat("g", this._Size);
			this.CFEDGDGBCHE().SetFloat("_SpotSize", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.LightIntensity);
			this.OLHDPICFBOF().SetFloat("23x3", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MALMMJNPILJ().SetFloat("\n", 1196f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("CameraFilterPack/Blend2Camera_Overlay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 993f, 934f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00007E28 File Offset: 0x00006028
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x000073BE File Offset: 0x000055BE
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00007E5F File Offset: 0x0000605F
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x000DC764 File Offset: 0x000DA964
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1996f)
			{
				this.HBJJOCHGOPH = 1689f;
			}
			this.CEKJODEAMGB().SetFloat("{0}", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1569f)
				{
					this._Distance = 1754f;
				}
				if (this._Distance < 1976f)
				{
					this._Distance = 833f;
				}
				this.CFEDGDGBCHE().SetFloat("inventory.selected.", this._Distance);
			}
			else
			{
				this.HBLDMJCOAHA().SetFloat("#kicked", this._Distance);
			}
			this.IGIAPKPKGPK().SetFloat("Year_", this._Size);
			this.MALMMJNPILJ().SetFloat("value", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", this.LightIntensity);
			this.EFDEIFCDAFG().SetFloat("player.dragon", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FNAFGEMJBDA().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", 742f / farClipPlane);
			this.OLHDPICFBOF().SetVector("Gameplay/particles", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1046f, 929f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x0000420A File Offset: 0x0000240A
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00007E96 File Offset: 0x00006096
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00007ECD File Offset: 0x000060CD
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("CrosshairOpacitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x000DC92C File Offset: 0x000DAB2C
	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1001f)
			{
				this.HBJJOCHGOPH = 499f;
			}
			this.IGKFMCPDNOI().SetFloat("_BlurParams", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 602f)
				{
					this._Distance = 447f;
				}
				if (this._Distance < 1686f)
				{
					this._Distance = 434f;
				}
				this.LELKBCALFCF().SetFloat("_RangeScale", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("Joystick1Button2", this._Distance);
			}
			this.CEKJODEAMGB().SetFloat("steamid", this._Size);
			this.HBLDMJCOAHA().SetFloat("Done!", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat("_Value2", this.LightIntensity);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/OldFilm_Cutting1", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MCDGIILBNIF().SetFloat("NEW_ACHIEVEMENT_1_", 817f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("[MenuScene] Error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 13f, 1885f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x000DCAF4 File Offset: 0x000DACF4
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1466f)
			{
				this.HBJJOCHGOPH = 1822f;
			}
			this.FAIFBBGFAIB().SetFloat("maps.", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 142f)
				{
					this._Distance = 1054f;
				}
				if (this._Distance < 1933f)
				{
					this._Distance = 79f;
				}
				this.ADGHJOHKEHG().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("PopulateMapsList", this._Distance);
			}
			this.FEAEGGCNIAA().SetFloat("lobby '{0}'[{1}]", this._Size);
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/Drawing_Crosshatch", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("_Value", this.LightIntensity);
			this.HHLFDHNEIAH().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("00", 121f / farClipPlane);
			this.GCDFNHMJMIP().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1241f, 325f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MALMMJNPILJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x000DCCBC File Offset: 0x000DAEBC
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 117f)
			{
				this.HBJJOCHGOPH = 943f;
			}
			this.ADBKPGFMNKO().SetFloat("UI Extensions/UI Image Crop", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1166f)
				{
					this._Distance = 1657f;
				}
				if (this._Distance < 793f)
				{
					this._Distance = 757f;
				}
				this.HHLFDHNEIAH().SetFloat("Achievement 21 progress reseted", this._Distance);
			}
			else
			{
				this.LDNADDJMIPK().SetFloat("powerup.1", this._Distance);
			}
			this.IGIAPKPKGPK().SetFloat("_TimeX", this._Size);
			this.HHLFDHNEIAH().SetFloat("Electronic", this._FixDistance);
			this.HHLFDHNEIAH().SetFloat("z", this.LightIntensity);
			this.MMOODGIODPC().SetFloat("/", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IGKFMCPDNOI().SetFloat("(scene)", 504f / farClipPlane);
			this.MCDGIILBNIF().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1847f, 1775f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x0000420A File Offset: 0x0000240A
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x000DCE84 File Offset: 0x000DB084
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 808f)
			{
				this.HBJJOCHGOPH = 1105f;
			}
			this.MCDGIILBNIF().SetFloat("setstring", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 474f)
				{
					this._Distance = 1004f;
				}
				if (this._Distance < 1859f)
				{
					this._Distance = 1050f;
				}
				this.LPMLLJKMAMP().SetFloat("Set Satellite Emission", this._Distance);
			}
			else
			{
				this.LDNADDJMIPK().SetFloat("_Value", this._Distance);
			}
			this.FAIFBBGFAIB().SetFloat("float,2", this._Size);
			this.CIAFLBFJLEJ().SetFloat("_Value", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("shader.sunny", this.LightIntensity);
			this.FEAEGGCNIAA().SetFloat("Received RPC \"", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FAIFBBGFAIB().SetFloat("Editor/", 1395f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("UseFinalGlassColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1972f, 150f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00007EF1 File Offset: 0x000060F1
	private Material MALMMJNPILJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0000420A File Offset: 0x0000240A
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x04000131 RID: 305
	public Shader SCShader;

	// Token: 0x04000132 RID: 306
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000133 RID: 307
	public bool _Visualize;

	// Token: 0x04000134 RID: 308
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000135 RID: 309
	private Material BJFKDHHMLJH;

	// Token: 0x04000136 RID: 310
	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	// Token: 0x04000137 RID: 311
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	// Token: 0x04000138 RID: 312
	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	// Token: 0x04000139 RID: 313
	[Range(0f, 1f)]
	public float LightIntensity = 1f;

	// Token: 0x0400013A RID: 314
	public bool AutoAnimatedNear;

	// Token: 0x0400013B RID: 315
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x0400013C RID: 316
	public static Color ChangeColorRGB;
}
