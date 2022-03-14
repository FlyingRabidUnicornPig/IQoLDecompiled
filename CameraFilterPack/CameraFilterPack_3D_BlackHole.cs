/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200001E RID: 30
[AddComponentMenu("Camera Filter Pack/3D/BlackHole")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_BlackHole : MonoBehaviour
{
	// Token: 0x060005D9 RID: 1497 RVA: 0x0000550B File Offset: 0x0000370B
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0000550B File Offset: 0x0000370B
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x000D2BD8 File Offset: 0x000D0DD8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 117f)
			{
				this.HBJJOCHGOPH = 1626f;
			}
			this.HCGJCMDJPGD().SetFloat("[NetworkManager] Exited", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 532f)
				{
					this._Distance = 820f;
				}
				if (this._Distance < 1157f)
				{
					this._Distance = 1744f;
				}
				this.HCGJCMDJPGD().SetFloat("SetTrailZoomSpeed", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("w", this._Distance);
			}
			this.HCGJCMDJPGD().SetFloat("_Value4", this._Size);
			this.HKGAONMOBMH().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.DistortionLevel);
			this.ADGHJOHKEHG().SetFloat("[Left]", this.DistortionSize);
			this.HKGAONMOBMH().SetFloat("_MainTex", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EJDPNJAEAKJ().SetFloat("player.bluebat", 1080f / farClipPlane);
			this.MFHPKGICPIO().SetVector("Had to lookup view that wasn't in photonViewList: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 50f, 1835f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x000D2DB4 File Offset: 0x000D0FB4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 784f)
			{
				this.HBJJOCHGOPH = 266f;
			}
			this.HCGJCMDJPGD().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 873f)
				{
					this._Distance = 1541f;
				}
				if (this._Distance < 190f)
				{
					this._Distance = 1123f;
				}
				this.GHHPOGODBHB().SetFloat("21x3", this._Distance);
			}
			else
			{
				this.MFHPKGICPIO().SetFloat("_Parameter", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("_EdgeSharpness", this._Size);
			this.JFDGLLEOPGB().SetFloat("accuracy", this._FixDistance);
			this.MFHPKGICPIO().SetFloat(".lastCheckpoint.perfectHits", this.DistortionLevel);
			this.GHHPOGODBHB().SetFloat("_TimeX", this.DistortionSize);
			this.NBPKMLMCHFN.SetFloat("tagElement", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/TV_Distorted", 1006f / farClipPlane);
			this.HCGJCMDJPGD().SetVector("InfoCanvas", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 841f, 1123f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0000420A File Offset: 0x0000240A
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00005528 File Offset: 0x00003728
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x000D2F90 File Offset: 0x000D1190
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 322f)
			{
				this.HBJJOCHGOPH = 1971f;
			}
			this.HKGAONMOBMH().SetFloat("[LobbyPlayerElement] On ready click", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1539f)
				{
					this._Distance = 170f;
				}
				if (this._Distance < 1592f)
				{
					this._Distance = 1469f;
				}
				this.LPMLLJKMAMP().SetFloat("music", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("_Value2", this._Distance);
			}
			this.LDNADDJMIPK().SetFloat("restrictions\n\n#until: ", this._Size);
			this.JFDGLLEOPGB().SetFloat("\"x", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("float,0", this.DistortionLevel);
			this.LDNADDJMIPK().SetFloat("[PlayerBase] Reset", this.DistortionSize);
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("0.00", 1893f / farClipPlane);
			this.ADGHJOHKEHG().SetVector("DifficultyBG", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 225f, 209f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0000554C File Offset: 0x0000374C
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.powerupsScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00005570 File Offset: 0x00003770
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("Room: '{0}' {1},{2} {4}/{3} players.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0000550B File Offset: 0x0000370B
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0000420A File Offset: 0x0000240A
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0000550B File Offset: 0x0000370B
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0000550B File Offset: 0x0000370B
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0000420A File Offset: 0x0000240A
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0000550B File Offset: 0x0000370B
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x000D316C File Offset: 0x000D136C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1676f)
			{
				this.HBJJOCHGOPH = 1688f;
			}
			this.MMOODGIODPC().SetFloat("z", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1271f)
				{
					this._Distance = 361f;
				}
				if (this._Distance < 1291f)
				{
					this._Distance = 1192f;
				}
				this.EOCCJGIGEGJ().SetFloat("_DiffuseColor", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("player.circle", this._Distance);
			}
			this.KEMJNOMIPHN().SetFloat("Fade", this._Size);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Glow_Glow_Color", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("DPADHOR", this.DistortionLevel);
			this.GHHPOGODBHB().SetFloat(".lastCheckpoint.lives", this.DistortionSize);
			this.MFHPKGICPIO().SetFloat(" now: ", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat("_TimeX", 1254f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("threshold", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 890f, 1740f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x000D3348 File Offset: 0x000D1548
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1109f)
			{
				this.HBJJOCHGOPH = 780f;
			}
			this.ADGHJOHKEHG().SetFloat("Joystick1Button12", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1536f)
				{
					this._Distance = 1774f;
				}
				if (this._Distance < 288f)
				{
					this._Distance = 1607f;
				}
				this.PLBEJJIHFPB().SetFloat("PublishButton", this._Distance);
			}
			else
			{
				this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Blur_Noise", this._Distance);
			}
			this.ADGHJOHKEHG().SetFloat("Loading", this._Size);
			this.NBPKMLMCHFN.SetFloat("#C8C8C8FF", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("OpJoinRoom()", this.DistortionLevel);
			this.GHHPOGODBHB().SetFloat("Text", this.DistortionSize);
			this.ADGHJOHKEHG().SetFloat("#md5submitionfailed: ", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("Tab2Content", 1387f / farClipPlane);
			this.HCGJCMDJPGD().SetVector("VIGNETTE_BLUR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 340f, 1588f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x000D3524 File Offset: 0x000D1724
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1268f)
			{
				this.HBJJOCHGOPH = 1157f;
			}
			this.LDNADDJMIPK().SetFloat("BestRegion checks region: ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1365f)
				{
					this._Distance = 1674f;
				}
				if (this._Distance < 418f)
				{
					this._Distance = 587f;
				}
				this.ADGHJOHKEHG().SetFloat("_Value5", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("InfoButton", this._Distance);
			}
			this.LDNADDJMIPK().SetFloat("_Value4", this._Size);
			this.PLBEJJIHFPB().SetFloat("_EmissionColor", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("_Value2", this.DistortionLevel);
			this.EOCCJGIGEGJ().SetFloat("challenges/", this.DistortionSize);
			this.GHHPOGODBHB().SetFloat("_PrevViewProj", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("_DotSize", 1504f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("Set particles gravity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 517f, 304f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00005594 File Offset: 0x00003794
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x000055CB File Offset: 0x000037CB
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0000420A File Offset: 0x0000240A
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00005602 File Offset: 0x00003802
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00005626 File Offset: 0x00003826
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0000550B File Offset: 0x0000370B
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0000420A File Offset: 0x0000240A
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0000565D File Offset: 0x0000385D
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0000550B File Offset: 0x0000370B
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x000D3700 File Offset: 0x000D1900
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 807f)
			{
				this.HBJJOCHGOPH = 630f;
			}
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1083f)
				{
					this._Distance = 1187f;
				}
				if (this._Distance < 1437f)
				{
					this._Distance = 1853f;
				}
				this.LDNADDJMIPK().SetFloat("Edited unlock conditions", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("_SSRMultiplier", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat("Tab2Content", this._Size);
			this.PLBEJJIHFPB().SetFloat("EventData0DropDownList", this._FixDistance);
			this.PLBEJJIHFPB().SetFloat("HPText", this.DistortionLevel);
			this.LDNADDJMIPK().SetFloat("_DotSize", this.DistortionSize);
			this.GHHPOGODBHB().SetFloat("#ok", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_TimeX", 666f / farClipPlane);
			this.GHHPOGODBHB().SetVector(" By: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1703f, 1352f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x000D38DC File Offset: 0x000D1ADC
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
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize);
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

	// Token: 0x060005F9 RID: 1529 RVA: 0x00005694 File Offset: 0x00003894
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x000D3AB8 File Offset: 0x000D1CB8
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 930f)
			{
				this.HBJJOCHGOPH = 1316f;
			}
			this.MMOODGIODPC().SetFloat(".lastCheckpoint.playerdistance", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1415f)
				{
					this._Distance = 1565f;
				}
				if (this._Distance < 1296f)
				{
					this._Distance = 1872f;
				}
				this.EJDPNJAEAKJ().SetFloat("_MainTex2", this._Distance);
			}
			else
			{
				this.PLBEJJIHFPB().SetFloat("_Size", this._Distance);
			}
			this.LPMLLJKMAMP().SetFloat("finished", this._Size);
			this.LDNADDJMIPK().SetFloat(".lastCheckpoint.correctScore", this._FixDistance);
			this.MFHPKGICPIO().SetFloat("DPADVER", this.DistortionLevel);
			this.LDNADDJMIPK().SetFloat(" Message: ", this.DistortionSize);
			this.MMOODGIODPC().SetFloat("RB", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LDNADDJMIPK().SetFloat("_Threshhold", 486f / farClipPlane);
			this.MMOODGIODPC().SetVector("_MatrixSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 609f, 1468f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x000056CB File Offset: 0x000038CB
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("solo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0000550B File Offset: 0x0000370B
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x000D3C94 File Offset: 0x000D1E94
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1901f)
			{
				this.HBJJOCHGOPH = 1737f;
			}
			this.ADGHJOHKEHG().SetFloat("#", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 953f)
				{
					this._Distance = 739f;
				}
				if (this._Distance < 1433f)
				{
					this._Distance = 563f;
				}
				this.ADGHJOHKEHG().SetFloat(" ", this._Distance);
			}
			else
			{
				this.EOCCJGIGEGJ().SetFloat("workshop.", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat("speed", this._Size);
			this.JFDGLLEOPGB().SetFloat("_MatrixSize", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("SearchTex", this.DistortionLevel);
			this.EOCCJGIGEGJ().SetFloat("Anomaly_Near", this.DistortionSize);
			this.HKGAONMOBMH().SetFloat("float,1.5", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat("n/a", 248f / farClipPlane);
			this.LDNADDJMIPK().SetVector("#creatingnewitem", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1017f, 204f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x000D3E70 File Offset: 0x000D2070
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1501f)
			{
				this.HBJJOCHGOPH = 1370f;
			}
			this.JFDGLLEOPGB().SetFloat("fade out duration", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1536f)
				{
					this._Distance = 62f;
				}
				if (this._Distance < 1520f)
				{
					this._Distance = 72f;
				}
				this.GHHPOGODBHB().SetFloat("_Value7", this._Distance);
			}
			else
			{
				this.EJDPNJAEAKJ().SetFloat("/", this._Distance);
			}
			this.HKGAONMOBMH().SetFloat("_Value3", this._Size);
			this.KEMJNOMIPHN().SetFloat(" with a prefix of ", this._FixDistance);
			this.MFHPKGICPIO().SetFloat("ConfigVersionSlider", this.DistortionLevel);
			this.HKGAONMOBMH().SetFloat("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", this.DistortionSize);
			this.EOCCJGIGEGJ().SetFloat("Search: ", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("[GameScene] Events count: ", 344f / farClipPlane);
			this.HKGAONMOBMH().SetVector("IconFileSelector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1745f, 654f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x000056EF File Offset: 0x000038EF
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00005726 File Offset: 0x00003926
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0000575D File Offset: 0x0000395D
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x000D404C File Offset: 0x000D224C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 888f)
			{
				this.HBJJOCHGOPH = 1149f;
			}
			this.EOCCJGIGEGJ().SetFloat(".lastCheckpoint.perfectHits", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1880f)
				{
					this._Distance = 1817f;
				}
				if (this._Distance < 1729f)
				{
					this._Distance = 657f;
				}
				this.HKGAONMOBMH().SetFloat("#score", this._Distance);
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Value3", this._Size);
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this._FixDistance);
			this.ADGHJOHKEHG().SetFloat("_Red_C", this.DistortionLevel);
			this.MMOODGIODPC().SetFloat("SpawnObj", this.DistortionSize);
			this.HCGJCMDJPGD().SetFloat("Object ID. Case-Sensitive", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EJDPNJAEAKJ().SetFloat("Connected to NameServer.", 365f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/AAA_Blood_Plus", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1514f, 1504f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00005781 File Offset: 0x00003981
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("LivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0000550B File Offset: 0x0000370B
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0000420A File Offset: 0x0000240A
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x000057A5 File Offset: 0x000039A5
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x000057DC File Offset: 0x000039DC
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0000420A File Offset: 0x0000240A
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00005813 File Offset: 0x00003A13
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("powerup.0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x0000550B File Offset: 0x0000370B
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x000D4280 File Offset: 0x000D2480
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1119f)
			{
				this.HBJJOCHGOPH = 552f;
			}
			this.PLBEJJIHFPB().SetFloat(" ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 712f)
				{
					this._Distance = 844f;
				}
				if (this._Distance < 972f)
				{
					this._Distance = 78f;
				}
				this.LPMLLJKMAMP().SetFloat("CameraFilterPack/Light_Rainbow2", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("Mouse2", this._Distance);
			}
			this.HCGJCMDJPGD().SetFloat("GlassAberration", this._Size);
			this.HKGAONMOBMH().SetFloat("https://discord.gg/intralism", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("_SSAO", this.DistortionLevel);
			this.LDNADDJMIPK().SetFloat("X2", this.DistortionSize);
			this.MFHPKGICPIO().SetFloat("IconImage", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("DPADHOR", 745f / farClipPlane);
			this.MFHPKGICPIO().SetVector("float,1.5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1709f, 863f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0000550B File Offset: 0x0000370B
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00005837 File Offset: 0x00003A37
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0000550B File Offset: 0x0000370B
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0000420A File Offset: 0x0000240A
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0000586E File Offset: 0x00003A6E
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0000420A File Offset: 0x0000240A
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x000058A5 File Offset: 0x00003AA5
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("[EMPTY]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x000058C9 File Offset: 0x00003AC9
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x000D445C File Offset: 0x000D265C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 465f)
			{
				this.HBJJOCHGOPH = 840f;
			}
			this.GHHPOGODBHB().SetFloat("_ThirdTex", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 706f)
				{
					this._Distance = 288f;
				}
				if (this._Distance < 1217f)
				{
					this._Distance = 12f;
				}
				this.MFHPKGICPIO().SetFloat("[Up-Down]", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("s", this._Distance);
			}
			this.KEMJNOMIPHN().SetFloat("Hex value #RRGGBB", this._Size);
			this.GHHPOGODBHB().SetFloat("settings.volume.editor", this._FixDistance);
			this.MMOODGIODPC().SetFloat("_Offsets", this.DistortionLevel);
			this.LDNADDJMIPK().SetFloat("UpdateNewsTileStart", this.DistortionSize);
			this.LPMLLJKMAMP().SetFloat("Items/", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("menu.selectedlevelid", 212f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("CameraFilterPack/Blend2Camera_LinearBurn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 146f, 38f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00005900 File Offset: 0x00003B00
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_PrevViewProj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x00005924 File Offset: 0x00003B24
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

	// Token: 0x06000618 RID: 1560 RVA: 0x0000550B File Offset: 0x0000370B
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x0000550B File Offset: 0x0000370B
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x0000595B File Offset: 0x00003B5B
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x0000550B File Offset: 0x0000370B
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x0000550B File Offset: 0x0000370B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x0000550B File Offset: 0x0000370B
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x000D4638 File Offset: 0x000D2838
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 948f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			this.EOCCJGIGEGJ().SetFloat("[Up-Right-Down-Left]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 248f)
				{
					this._Distance = 977f;
				}
				if (this._Distance < 410f)
				{
					this._Distance = 1f;
				}
				this.KEMJNOMIPHN().SetFloat("workshop.", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("mapselector.filter.favoriteonly", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_BlurVector", this._Size);
			this.EJDPNJAEAKJ().SetFloat("ItemsUploader", this._FixDistance);
			this.EOCCJGIGEGJ().SetFloat("Texture2", this.DistortionLevel);
			this.GHHPOGODBHB().SetFloat("_Value3", this.DistortionSize);
			this.MMOODGIODPC().SetFloat("maps.", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LDNADDJMIPK().SetFloat("Status: ", 1002f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("MenuVolumeSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1272f, 575f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00005992 File Offset: 0x00003B92
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x0000420A File Offset: 0x0000240A
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x040000EB RID: 235
	public Shader SCShader;

	// Token: 0x040000EC RID: 236
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000ED RID: 237
	public bool _Visualize;

	// Token: 0x040000EE RID: 238
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000EF RID: 239
	private Material BJFKDHHMLJH;

	// Token: 0x040000F0 RID: 240
	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	// Token: 0x040000F1 RID: 241
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.05f;

	// Token: 0x040000F2 RID: 242
	[Range(0f, 1f)]
	public float _Size = 0.25f;

	// Token: 0x040000F3 RID: 243
	[Range(-2f, 2f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x040000F4 RID: 244
	[Range(0f, 1f)]
	public float DistortionSize;

	// Token: 0x040000F5 RID: 245
	public bool AutoAnimatedNear;

	// Token: 0x040000F6 RID: 246
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x040000F7 RID: 247
	public static Color ChangeColorRGB;
}
