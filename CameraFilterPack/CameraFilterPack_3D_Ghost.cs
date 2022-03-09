/*
Importance of this class: Unknown

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x02000022 RID: 34
[AddComponentMenu("Camera Filter Pack/3D/Ghost")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Ghost : MonoBehaviour
{
	// Token: 0x060006F0 RID: 1776 RVA: 0x0000420A File Offset: 0x0000240A
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x000D85BC File Offset: 0x000D67BC
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 392f)
			{
				this.HBJJOCHGOPH = 1303f;
			}
			this.FEAEGGCNIAA().SetFloat(".lastCheckpoint.playerdistance", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("Floating point textures aren't supported on this device ({0})", this.Intensity);
			this.BFGNMFCNDBC().SetFloat("[LevelEditorScene] Error: Timeout :S", this.GhostPosX);
			this.CFEDGDGBCHE().SetFloat("BitsData", this.GhostPosY);
			this.DKNJGHFLAIF().SetFloat("menu.tabid", this.GhostFade);
			this.KAFBNOBOIAJ().SetFloat("Operation failed: ", this.GhostFade2);
			this.BKKJJJGADLM().SetFloat("inventory.itemscash", this.GhostSize);
			this.BFGNMFCNDBC().SetFloat("ENABLE_DITHERING", (float)((!this._Visualize) ? 0 : 1));
			this.FAIFBBGFAIB().SetFloat("_ChangeRed", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat("Object ID. Case-Sensitive", this.Ghost_Near);
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/Drawing_Comics", this.Ghost_Far);
			this.BKKJJJGADLM().SetFloat("BitsData", this.GhostWithoutObject);
			this.MICHFGAOPKM().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 196f, 211f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00006DD7 File Offset: 0x00004FD7
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find(".png");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x0000420A File Offset: 0x0000240A
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00006DFB File Offset: 0x00004FFB
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00006E32 File Offset: 0x00005032
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Luminosity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00006E56 File Offset: 0x00005056
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x000D8770 File Offset: 0x000D6970
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 383f)
			{
				this.HBJJOCHGOPH = 1330f;
			}
			this.KAFBNOBOIAJ().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("_Value", this.Intensity);
			this.BKKJJJGADLM().SetFloat("[MapsEditor] Creating new item...", this.GhostPosX);
			this.LNLKMDPHDCC().SetFloat(".workshop.json", this.GhostPosY);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/Drawing_Manga_Flash", this.GhostFade);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Lut_PlayWith", this.GhostFade2);
			this.BFGNMFCNDBC().SetFloat("_SweaterSize", this.GhostSize);
			this.BKKJJJGADLM().SetFloat("_Distortion", (float)((!this._Visualize) ? 0 : 0));
			this.FAIFBBGFAIB().SetFloat(".workshop", this._FixDistance);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/Antialiasing_FXAA", this.Ghost_Near);
			this.IIJMIPBMMBF().SetFloat("_Value", this.Ghost_Far);
			this.FAIFBBGFAIB().SetFloat("note.4", this.GhostWithoutObject);
			this.HCGJCMDJPGD().SetVector("SUBMIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1750f, 789f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00006E8D File Offset: 0x0000508D
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("Anomaly_With_Obj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00006EB1 File Offset: 0x000050B1
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00006EE8 File Offset: 0x000050E8
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find(" SecondsBeforeRespawn: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00006F0C File Offset: 0x0000510C
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x000D8924 File Offset: 0x000D6B24
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 141f)
			{
				this.HBJJOCHGOPH = 315f;
			}
			this.OIMMPLPBLBK().SetFloat("win", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("Data/Localization", this.GhostPosX);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.GhostPosY);
			this.BKKJJJGADLM().SetFloat("Object ID. Case-Sensitive", this.GhostFade);
			this.OIMMPLPBLBK().SetFloat("_Green_G", this.GhostFade2);
			this.MMOODGIODPC().SetFloat("SupportLogger OnLeftRoom().", this.GhostSize);
			this.NBPKMLMCHFN.SetFloat("_NeighbourMaxTex", (float)((!this._Visualize) ? 0 : 0));
			this.KAFBNOBOIAJ().SetFloat(" b.", this._FixDistance);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Ghost_Near);
			this.HCGJCMDJPGD().SetFloat("ERROR", this.Ghost_Far);
			this.IIJMIPBMMBF().SetFloat("Reconnect() disabled the offline mode. No longer offline.", this.GhostWithoutObject);
			this.CFEDGDGBCHE().SetVector("EXCEPTION:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1761f, 42f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00006F43 File Offset: 0x00005143
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x000D8AD8 File Offset: 0x000D6CD8
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1409f)
			{
				this.HBJJOCHGOPH = 419f;
			}
			this.OIMMPLPBLBK().SetFloat("%", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", this.Intensity);
			this.MMOODGIODPC().SetFloat("_ScreenResolution", this.GhostPosX);
			this.NBPKMLMCHFN.SetFloat("LostAllLives", this.GhostPosY);
			this.NLFJGMBCICG().SetFloat("_MainTex2", this.GhostFade);
			this.MICHFGAOPKM().SetFloat("RedoButton", this.GhostFade2);
			this.BKKJJJGADLM().SetFloat("mapselector.filter.favoriteonly", this.GhostSize);
			this.NBPKMLMCHFN.SetFloat(" ", (float)((!this._Visualize) ? 1 : 1));
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Distortion_Aspiration", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("ViewID {0} {1}{2}", this.Ghost_Near);
			this.LNLKMDPHDCC().SetFloat("_VignetteColor", this.Ghost_Far);
			this.LNLKMDPHDCC().SetFloat("_Speed", this.GhostWithoutObject);
			this.NLFJGMBCICG().SetVector("#tryagain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1866f, 749f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x0000420A File Offset: 0x0000240A
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x0000420A File Offset: 0x0000240A
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x0000420A File Offset: 0x0000240A
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00006F7A File Offset: 0x0000517A
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00006FB1 File Offset: 0x000051B1
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x000D8C8C File Offset: 0x000D6E8C
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 1852f;
			}
			this.NLFJGMBCICG().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("[Right]", this.Intensity);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.GhostPosX);
			this.KGOLDDBHIFN().SetFloat("event", this.GhostPosY);
			this.NBPKMLMCHFN.SetFloat("player.redlifering", this.GhostFade);
			this.OIMMPLPBLBK().SetFloat("_Value2", this.GhostFade2);
			this.FAIFBBGFAIB().SetFloat("BadgeImage", this.GhostSize);
			this.KAFBNOBOIAJ().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 0));
			this.NLFJGMBCICG().SetFloat("_Glitch", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", this.Ghost_Near);
			this.IIJMIPBMMBF().SetFloat(".lastCheckpoint.lives", this.Ghost_Far);
			this.HCGJCMDJPGD().SetFloat("DPADHOR", this.GhostWithoutObject);
			this.FEAEGGCNIAA().SetVector("sounds/hit_normal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 707f, 477f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00006FE8 File Offset: 0x000051E8
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x0000700C File Offset: 0x0000520C
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("Updating...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x000D8E40 File Offset: 0x000D7040
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 281f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.KAFBNOBOIAJ().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat(" methods \"", this.Intensity);
			this.DKNJGHFLAIF().SetFloat("Checkpoint", this.GhostPosX);
			this.CFEDGDGBCHE().SetFloat("BadgeText", this.GhostPosY);
			this.HCGJCMDJPGD().SetFloat("_Smooth", this.GhostFade);
			this.ABHDNGIHBKE().SetFloat("Show image from resources by id at the center of the screen at foreground or background", this.GhostFade2);
			this.FAIFBBGFAIB().SetFloat("_Intensity", this.GhostSize);
			this.OIMMPLPBLBK().SetFloat("_Bullet_3", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat(" Time: ", this._FixDistance);
			this.DKNJGHFLAIF().SetFloat("Fade", this.Ghost_Near);
			this.HCGJCMDJPGD().SetFloat(", ", this.Ghost_Far);
			this.IIJMIPBMMBF().SetFloat("EnableRankedNotificationsToggle", this.GhostWithoutObject);
			this.IIJMIPBMMBF().SetVector("int", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 788f, 1644f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x000D8FF4 File Offset: 0x000D71F4
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 676f)
			{
				this.HBJJOCHGOPH = 1669f;
			}
			this.IIJMIPBMMBF().SetFloat("event", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("[NetworkManager] Exited", this.Intensity);
			this.OIMMPLPBLBK().SetFloat("0.00", this.GhostPosX);
			this.ABHDNGIHBKE().SetFloat("_Value2", this.GhostPosY);
			this.MMOODGIODPC().SetFloat("maps.", this.GhostFade);
			this.MMOODGIODPC().SetFloat("' ping: ", this.GhostFade2);
			this.OIMMPLPBLBK().SetFloat("\r\n", this.GhostSize);
			this.CFEDGDGBCHE().SetFloat("Items/", (float)((!this._Visualize) ? 0 : 0));
			this.MMOODGIODPC().SetFloat("init", this._FixDistance);
			this.MMOODGIODPC().SetFloat("_MainTex", this.Ghost_Near);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.Ghost_Far);
			this.BFGNMFCNDBC().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.GhostWithoutObject);
			this.ABHDNGIHBKE().SetVector("LevelEditor/CustomEventEditor-Text", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 936f, 1234f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x000D91A8 File Offset: 0x000D73A8
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1034f)
			{
				this.HBJJOCHGOPH = 1231f;
			}
			this.NLFJGMBCICG().SetFloat("_LightIntensity", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_ZCurve", this.Intensity);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/Blur_Steam", this.GhostPosX);
			this.ABHDNGIHBKE().SetFloat("[MapsData] Found ", this.GhostPosY);
			this.IIJMIPBMMBF().SetFloat("id", this.GhostFade);
			this.CFEDGDGBCHE().SetFloat("_MainTex2", this.GhostFade2);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.GhostSize);
			this.HCGJCMDJPGD().SetFloat("skin.no_hit", (float)((!this._Visualize) ? 1 : 1));
			this.MICHFGAOPKM().SetFloat("#,0.00", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat("FToA", this.Ghost_Near);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/NightVision_4", this.Ghost_Far);
			this.NLFJGMBCICG().SetFloat("s", this.GhostWithoutObject);
			this.OIMMPLPBLBK().SetVector("hitsounds:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1335f, 433f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x0000420A File Offset: 0x0000240A
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00007030 File Offset: 0x00005230
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Set EnvSprite Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00007054 File Offset: 0x00005254
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x0000708B File Offset: 0x0000528B
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x000070C2 File Offset: 0x000052C2
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x000070F9 File Offset: 0x000052F9
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x000D935C File Offset: 0x000D755C
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1051f)
			{
				this.HBJJOCHGOPH = 1835f;
			}
			this.BKKJJJGADLM().SetFloat("Right Stick Click", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("Mouse X", this.Intensity);
			this.MICHFGAOPKM().SetFloat("_LutTex", this.GhostPosX);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.GhostPosY);
			this.KGOLDDBHIFN().SetFloat("x", this.GhostFade);
			this.NLFJGMBCICG().SetFloat("Exit to Windows", this.GhostFade2);
			this.NLFJGMBCICG().SetFloat("SetSpeed", this.GhostSize);
			this.FAIFBBGFAIB().SetFloat("_FixDistance", (float)((!this._Visualize) ? 1 : 0));
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/BlurTiltShift_V", this._FixDistance);
			this.BFGNMFCNDBC().SetFloat("UseFinalGlassColor", this.Ghost_Near);
			this.DKNJGHFLAIF().SetFloat("saveGameName ", this.Ghost_Far);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.GhostWithoutObject);
			this.LNLKMDPHDCC().SetVector("_FarCamera", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1188f, 726f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00007130 File Offset: 0x00005330
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x000D9510 File Offset: 0x000D7710
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 893f)
			{
				this.HBJJOCHGOPH = 685f;
			}
			this.KAFBNOBOIAJ().SetFloat("maps.", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("LevelEditor/CustomEventEditor-Text", this.Intensity);
			this.HCGJCMDJPGD().SetFloat("_Axis", this.GhostPosX);
			this.CFEDGDGBCHE().SetFloat("OnDeserialize", this.GhostPosY);
			this.MMOODGIODPC().SetFloat("X", this.GhostFade);
			this.MMOODGIODPC().SetFloat("GridDataArcs", this.GhostFade2);
			this.BKKJJJGADLM().SetFloat("CameraFilterPack/Film_ColorPerfection", this.GhostSize);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/AAA_WaterDropPro", (float)((!this._Visualize) ? 1 : 0));
			this.FEAEGGCNIAA().SetFloat("_Value3", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("UpdateDownloadingProgress", this.Ghost_Near);
			this.KGOLDDBHIFN().SetFloat("Uploading content", this.Ghost_Far);
			this.MICHFGAOPKM().SetFloat("_MatrixSpeed", this.GhostWithoutObject);
			this.MMOODGIODPC().SetVector("CameraFilterPack/FX_DigitalMatrix", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1469f, 998f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000723 RID: 1827 RVA: 0x00007154 File Offset: 0x00005354
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

	// Token: 0x06000724 RID: 1828 RVA: 0x0000718B File Offset: 0x0000538B
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find(". The group number should be at least 1.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x000071AF File Offset: 0x000053AF
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x000071E6 File Offset: 0x000053E6
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("LostLive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x0000420A File Offset: 0x0000240A
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x0000720A File Offset: 0x0000540A
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x0000722E File Offset: 0x0000542E
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("Start Color's hex value #RRGGBBAA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00007252 File Offset: 0x00005452
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("InfoText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00007276 File Offset: 0x00005476
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("Brightness");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x0000729A File Offset: 0x0000549A
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Ghost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x000D9730 File Offset: 0x000D7930
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
			this.NBPKMLMCHFN.SetFloat("GhostPosX", this.GhostPosX);
			this.NBPKMLMCHFN.SetFloat("GhostPosY", this.GhostPosY);
			this.NBPKMLMCHFN.SetFloat("GhostFade", this.GhostFade);
			this.NBPKMLMCHFN.SetFloat("GhostFade2", this.GhostFade2);
			this.NBPKMLMCHFN.SetFloat("GhostSize", this.GhostSize);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Drop_Near", this.Ghost_Near);
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.Ghost_Far);
			this.NBPKMLMCHFN.SetFloat("Drop_With_Obj", this.GhostWithoutObject);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x000D98E4 File Offset: 0x000D7AE4
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1313f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("RateButton", this.GhostPosX);
			this.HCGJCMDJPGD().SetFloat("_Parameter", this.GhostPosY);
			this.DKNJGHFLAIF().SetFloat("closed", this.GhostFade);
			this.NBPKMLMCHFN.SetFloat("skin.", this.GhostFade2);
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.GhostSize);
			this.OIMMPLPBLBK().SetFloat("Preparing content...", (float)((!this._Visualize) ? 1 : 0));
			this.FEAEGGCNIAA().SetFloat("_Value", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat("[PlayerBase] SetPlayerDistance error: ", this.Ghost_Near);
			this.CFEDGDGBCHE().SetFloat("_EmissionColor", this.Ghost_Far);
			this.HCGJCMDJPGD().SetFloat("blue", this.GhostWithoutObject);
			this.ABHDNGIHBKE().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 434f, 1857f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x000D9A98 File Offset: 0x000D7C98
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 31f)
			{
				this.HBJJOCHGOPH = 478f;
			}
			this.LNLKMDPHDCC().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_TimeX", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("ClearEnvironment", this.GhostPosX);
			this.MICHFGAOPKM().SetFloat("_Value", this.GhostPosY);
			this.MMOODGIODPC().SetFloat("ResetSpeed", this.GhostFade);
			this.ABHDNGIHBKE().SetFloat("KickThePlayer", this.GhostFade2);
			this.KAFBNOBOIAJ().SetFloat("_Value2", this.GhostSize);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/TV_Posterize", (float)((!this._Visualize) ? 0 : 1));
			this.MMOODGIODPC().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", this._FixDistance);
			this.KAFBNOBOIAJ().SetFloat("\n", this.Ghost_Near);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.Ghost_Far);
			this.KAFBNOBOIAJ().SetFloat("sfxVolume", this.GhostWithoutObject);
			this.ABHDNGIHBKE().SetVector("_MidGrey", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 8f, 858f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x000072BE File Offset: 0x000054BE
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x0000420A File Offset: 0x0000240A
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x000072F5 File Offset: 0x000054F5
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x0000732C File Offset: 0x0000552C
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00006DBA File Offset: 0x00004FBA
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00007363 File Offset: 0x00005563
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x0000739A File Offset: 0x0000559A
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_PColor2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000122 RID: 290
	public Shader SCShader;

	// Token: 0x04000123 RID: 291
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000124 RID: 292
	public bool _Visualize;

	// Token: 0x04000125 RID: 293
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000126 RID: 294
	private Material BJFKDHHMLJH;

	// Token: 0x04000127 RID: 295
	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	// Token: 0x04000128 RID: 296
	[Range(-0.5f, 0.99f)]
	public float Ghost_Near = 0.08f;

	// Token: 0x04000129 RID: 297
	[Range(0f, 1f)]
	public float Ghost_Far = 0.55f;

	// Token: 0x0400012A RID: 298
	[Range(0f, 2f)]
	public float Intensity = 1f;

	// Token: 0x0400012B RID: 299
	[Range(0f, 1f)]
	public float GhostWithoutObject = 1f;

	// Token: 0x0400012C RID: 300
	[Range(-1f, 1f)]
	public float GhostPosX;

	// Token: 0x0400012D RID: 301
	[Range(-1f, 1f)]
	public float GhostPosY;

	// Token: 0x0400012E RID: 302
	[Range(0.1f, 8f)]
	public float GhostFade2 = 2f;

	// Token: 0x0400012F RID: 303
	[Range(-1f, 1f)]
	public float GhostFade;

	// Token: 0x04000130 RID: 304
	[Range(0.5f, 1.5f)]
	public float GhostSize = 0.9f;
}
