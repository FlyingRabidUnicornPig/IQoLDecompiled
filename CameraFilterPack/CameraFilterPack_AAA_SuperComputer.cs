/*
Importance of this class: Unknown. Only a few filters are used by default and through shaders.
TODO: Give Users access to this shit lol.

Purpose of this class: Part of camera filter pack

Deobf status: Lots of junk methods, some vars obf'd
*/

using System;
using UnityEngine;

// Token: 0x0200002E RID: 46
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Super Computer")]
public class CameraFilterPack_AAA_SuperComputer : MonoBehaviour
{
	// Token: 0x06000B92 RID: 2962 RVA: 0x0000C742 File Offset: 0x0000A942
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x0000C779 File Offset: 0x0000A979
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("https://www.youtube.com/watch?v=cDVXukrKo74");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x000F2678 File Offset: 0x000F0878
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1110f;
			if (this.HBJJOCHGOPH > 340f)
			{
				this.HBJJOCHGOPH = 1760f;
			}
			this.EFDEIFCDAFG().SetFloat("_NeutralTonemapperParams1", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", this.ShapeFormula);
			this.NFMGLIKNOOC().SetFloat(" methods \"", this.Shape);
			this.EJDPNJAEAKJ().SetFloat("master", this.center.x);
			this.NFMGLIKNOOC().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", this.center.y);
			this.EJDPNJAEAKJ().SetFloat("PointerExit ", this.Radius);
			this.KEMJNOMIPHN().SetFloat("MenuScene", this._BorderSize);
			this.DOHGBNPMBKG().SetColor("ICollection", this._BorderColor);
			this.HKHBBBFLGJH().SetFloat("string", this._AlphaHexa);
			this.ABHDNGIHBKE().SetFloat("OPEN", this._SpotSize);
			this.ABHDNGIHBKE().SetVector("Connection error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 343f, 753f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x0000C79D File Offset: 0x0000A99D
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("DifficultyBG");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x0000C7DE File Offset: 0x0000A9DE
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("2;13;14;15;16");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x0000420A File Offset: 0x0000240A
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0000C802 File Offset: 0x0000AA02
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x000F27F8 File Offset: 0x000F09F8
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1823f;
			if (this.HBJJOCHGOPH > 6f)
			{
				this.HBJJOCHGOPH = 1669f;
			}
			this.KEMJNOMIPHN().SetFloat("help", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("#8E8E8EFF", this.ShapeFormula);
			this.NFMGLIKNOOC().SetFloat("Right", this.Shape);
			this.HNICHJCGJOC().SetFloat("Type of observed is unknown when receiving.", this.center.x);
			this.KEMJNOMIPHN().SetFloat("In Main Menu", this.center.y);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/TV_BrokenGlass2", this.Radius);
			this.HKHBBBFLGJH().SetFloat("[LocalizationService] Error: ", this._BorderSize);
			this.HHIAIGCAHDA().SetColor(" player(s)", this._BorderColor);
			this.CFCPHFMKHII().SetFloat("_Red_C", this._AlphaHexa);
			this.EJDPNJAEAKJ().SetFloat("pointBuffer", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1129f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x000F2978 File Offset: 0x000F0B78
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 765f;
			if (this.HBJJOCHGOPH > 140f)
			{
				this.HBJJOCHGOPH = 46f;
			}
			this.HNICHJCGJOC().SetFloat("#failed!", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("SetRotation", this.ShapeFormula);
			this.CFCPHFMKHII().SetFloat("Source: ", this.Shape);
			this.EJDPNJAEAKJ().SetFloat("0.00", this.center.x);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this.center.y);
			this.ABHDNGIHBKE().SetFloat("UseScanLineSize", this.Radius);
			this.PDEAHJPOMEF().SetFloat("Triangle", this._BorderSize);
			this.ABHDNGIHBKE().SetColor("#task", this._BorderColor);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blur_DitherOffset", this._AlphaHexa);
			this.OGMEGHKECAH().SetFloat("getfloat", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("Save", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 553f, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x000F2AF8 File Offset: 0x000F0CF8
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 4f;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.ShapeFormula);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Shape);
			this.NBPKMLMCHFN.SetFloat("_PositionX", this.center.x);
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.center.y);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Radius);
			this.NBPKMLMCHFN.SetFloat("_BorderSize", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("_BorderColor", this._BorderColor);
			this.NBPKMLMCHFN.SetFloat("_AlphaHexa", this._AlphaHexa);
			this.NBPKMLMCHFN.SetFloat("_SpotSize", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x0000C839 File Offset: 0x0000AA39
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0000420A File Offset: 0x0000240A
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x0000C870 File Offset: 0x0000AA70
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x0000C8A7 File Offset: 0x0000AAA7
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x0000C8CB File Offset: 0x0000AACB
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0000C902 File Offset: 0x0000AB02
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x000F2C78 File Offset: 0x000F0E78
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 138f;
			if (this.HBJJOCHGOPH > 721f)
			{
				this.HBJJOCHGOPH = 836f;
			}
			this.NFMGLIKNOOC().SetFloat("PUNCloudBestRegion", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("menu.enableselectormusic", this.ShapeFormula);
			this.HHIAIGCAHDA().SetFloat("_VelTex", this.Shape);
			this.OGMEGHKECAH().SetFloat("Gameplay/sun", this.center.x);
			this.KEMJNOMIPHN().SetFloat("Reset All", this.center.y);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", this.Radius);
			this.EFDEIFCDAFG().SetFloat("InfoCanvas", this._BorderSize);
			this.HNICHJCGJOC().SetColor("SetParticlesCountPerBeat", this._BorderColor);
			this.KEMJNOMIPHN().SetFloat("Tab2Content", this._AlphaHexa);
			this.KEMJNOMIPHN().SetFloat("_History3LumaTex", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1731f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x0000420A File Offset: 0x0000240A
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x000F2DF8 File Offset: 0x000F0FF8
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1243f;
			if (this.HBJJOCHGOPH > 154f)
			{
				this.HBJJOCHGOPH = 1305f;
			}
			this.HHIAIGCAHDA().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("#mapmustbecompletebeforesubmit", this.ShapeFormula);
			this.HNICHJCGJOC().SetFloat("SpectatingUserInfo", this.Shape);
			this.DOHGBNPMBKG().SetFloat("BitsData", this.center.x);
			this.GJHLADDCMFF().SetFloat("_Speed", this.center.y);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.Radius);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this._BorderSize);
			this.ABHDNGIHBKE().SetColor("Texture2", this._BorderColor);
			this.GJHLADDCMFF().SetFloat("{0:0}", this._AlphaHexa);
			this.EJDPNJAEAKJ().SetFloat("[PlayerBase] ShowTitle error: ", this._SpotSize);
			this.EJDPNJAEAKJ().SetVector("CameraFilterPack/FX_Drunk", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1572f, 1466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x0000C926 File Offset: 0x0000AB26
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("513510");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x0000C94A File Offset: 0x0000AB4A
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x0000420A File Offset: 0x0000240A
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x0000C981 File Offset: 0x0000AB81
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x000F2F78 File Offset: 0x000F1178
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1803f;
			if (this.HBJJOCHGOPH > 435f)
			{
				this.HBJJOCHGOPH = 77f;
			}
			this.CFCPHFMKHII().SetFloat("FPSToggle", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("[PlayerController] ", this.ShapeFormula);
			this.HHIAIGCAHDA().SetFloat("Tab1Content", this.Shape);
			this.EFDEIFCDAFG().SetFloat("id", this.center.x);
			this.NFMGLIKNOOC().SetFloat("OnPlayerGameMessage", this.center.y);
			this.PDEAHJPOMEF().SetFloat("GhostPosY", this.Radius);
			this.IGKFMCPDNOI().SetFloat("[Right-Down-Left]", this._BorderSize);
			this.EFDEIFCDAFG().SetColor("EnvironmentSlider", this._BorderColor);
			this.GJHLADDCMFF().SetFloat("#91CCFF", this._AlphaHexa);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this._SpotSize);
			this.DOHGBNPMBKG().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 191f, 1113f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("win");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x0000420A File Offset: 0x0000240A
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x0000C9DC File Offset: 0x0000ABDC
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x0000420A File Offset: 0x0000240A
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x0000420A File Offset: 0x0000240A
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x0000420A File Offset: 0x0000240A
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x0000CA13 File Offset: 0x0000AC13
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x0000420A File Offset: 0x0000240A
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x000F30F8 File Offset: 0x000F12F8
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 627f;
			if (this.HBJJOCHGOPH > 377f)
			{
				this.HBJJOCHGOPH = 553f;
			}
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("X2", this.ShapeFormula);
			this.DOHGBNPMBKG().SetFloat("Blues", this.Shape);
			this.HNICHJCGJOC().SetFloat("_Value2", this.center.x);
			this.NBPKMLMCHFN.SetFloat("GroupNameText", this.center.y);
			this.GJHLADDCMFF().SetFloat("_FixDistance", this.Radius);
			this.OGMEGHKECAH().SetFloat("TotalTimeLabel", this._BorderSize);
			this.HKHBBBFLGJH().SetColor("BlockSize", this._BorderColor);
			this.ABHDNGIHBKE().SetFloat("Editor/", this._AlphaHexa);
			this.HHIAIGCAHDA().SetFloat("settings.enablehitsoundsinrelax", this._SpotSize);
			this.CFCPHFMKHII().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 1002f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x0000CA4A File Offset: 0x0000AC4A
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("Cannot send messages when not connected. Either connect to Photon OR use offline mode!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x000F3278 File Offset: 0x000F1478
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 22f;
			if (this.HBJJOCHGOPH > 179f)
			{
				this.HBJJOCHGOPH = 685f;
			}
			this.EFDEIFCDAFG().SetFloat("Player", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("/files/editor_manual.pdf", this.ShapeFormula);
			this.ABHDNGIHBKE().SetFloat("Connection error: ", this.Shape);
			this.HNICHJCGJOC().SetFloat("float,2", this.center.x);
			this.GJHLADDCMFF().SetFloat("Jump", this.center.y);
			this.NBPKMLMCHFN.SetFloat("Case-Sensitive", this.Radius);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this._BorderSize);
			this.HKHBBBFLGJH().SetColor("_NoiseScale", this._BorderColor);
			this.NBPKMLMCHFN.SetFloat("#onrankchangeuptext", this._AlphaHexa);
			this.EFDEIFCDAFG().SetFloat("_MainTex2", this._SpotSize);
			this.NFMGLIKNOOC().SetVector("CameraFilterPack/Vision_Warp", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 437f, 1077f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0000420A File Offset: 0x0000240A
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x000F33F8 File Offset: 0x000F15F8
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1360f;
			if (this.HBJJOCHGOPH > 433f)
			{
				this.HBJJOCHGOPH = 1475f;
			}
			this.OGMEGHKECAH().SetFloat(": ", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("player.gamecompleted", this.ShapeFormula);
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack_AAA_Blood_Hit1", this.Shape);
			this.EJDPNJAEAKJ().SetFloat("_Value3", this.center.x);
			this.CFCPHFMKHII().SetFloat("steamid", this.center.y);
			this.GJHLADDCMFF().SetFloat("DifficultyBG", this.Radius);
			this.DOHGBNPMBKG().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", this._BorderSize);
			this.HNICHJCGJOC().SetColor(".", this._BorderColor);
			this.PDEAHJPOMEF().SetFloat("[PlayerBase] Game mode: ", this._AlphaHexa);
			this.ABHDNGIHBKE().SetFloat("masterSteamID", this._SpotSize);
			this.DOHGBNPMBKG().SetVector("(\\[ */ *quote *\\])", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1577f, 1309f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x000F3578 File Offset: 0x000F1778
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1432f;
			if (this.HBJJOCHGOPH > 1637f)
			{
				this.HBJJOCHGOPH = 682f;
			}
			this.HNICHJCGJOC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("<color=white>PhotonView Group: ", this.ShapeFormula);
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.Shape);
			this.CFCPHFMKHII().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.center.x);
			this.OGMEGHKECAH().SetFloat("ViewMenu", this.center.y);
			this.PDEAHJPOMEF().SetFloat("anonymous", this.Radius);
			this.IGKFMCPDNOI().SetFloat("SelectorMapsCountSlider", this._BorderSize);
			this.KEMJNOMIPHN().SetColor("\n", this._BorderColor);
			this.IGKFMCPDNOI().SetFloat("_QualitySettings", this._AlphaHexa);
			this.KEMJNOMIPHN().SetFloat("Version 1.0", this._SpotSize);
			this.HHIAIGCAHDA().SetVector("CameraFilterPack_AAA_Blood2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 85f, 166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0000CA6E File Offset: 0x0000AC6E
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x000F36F8 File Offset: 0x000F18F8
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1658f;
			if (this.HBJJOCHGOPH > 1639f)
			{
				this.HBJJOCHGOPH = 1615f;
			}
			this.DOHGBNPMBKG().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("EventConfigButton", this.ShapeFormula);
			this.PDEAHJPOMEF().SetFloat("InputField", this.Shape);
			this.DOHGBNPMBKG().SetFloat("_Noise", this.center.x);
			this.HKHBBBFLGJH().SetFloat("OxOD.lastPath", this.center.y);
			this.CFCPHFMKHII().SetFloat("_Glitch", this.Radius);
			this.KEMJNOMIPHN().SetFloat("_TimeX", this._BorderSize);
			this.OGMEGHKECAH().SetColor("</color>", this._BorderColor);
			this.CFCPHFMKHII().SetFloat("reset", this._AlphaHexa);
			this.KEMJNOMIPHN().SetFloat("workshop.", this._SpotSize);
			this.HNICHJCGJOC().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1777f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x0000420A File Offset: 0x0000240A
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0000420A File Offset: 0x0000240A
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0000CAA5 File Offset: 0x0000ACA5
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x0000420A File Offset: 0x0000240A
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x0000CADC File Offset: 0x0000ACDC
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x000F3878 File Offset: 0x000F1A78
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1525f;
			if (this.HBJJOCHGOPH > 269f)
			{
				this.HBJJOCHGOPH = 601f;
			}
			this.OGMEGHKECAH().SetFloat("Playing ", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("[Right]", this.ShapeFormula);
			this.PDEAHJPOMEF().SetFloat("Joystick", this.Shape);
			this.NFMGLIKNOOC().SetFloat("[NetworkManager] Connection failed: ", this.center.x);
			this.NBPKMLMCHFN.SetFloat("_TintColor", this.center.y);
			this.DOHGBNPMBKG().SetFloat("player.licenceaccepted", this.Radius);
			this.EJDPNJAEAKJ().SetFloat("offsets", this._BorderSize);
			this.NFMGLIKNOOC().SetColor("Selection Box", this._BorderColor);
			this.OGMEGHKECAH().SetFloat("turn", this._AlphaHexa);
			this.NBPKMLMCHFN.SetFloat(".lastCheckpoint.penaltyScore", this._SpotSize);
			this.NFMGLIKNOOC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1466f, 1663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x0000420A File Offset: 0x0000240A
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x0000420A File Offset: 0x0000240A
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x000F39F8 File Offset: 0x000F1BF8
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 955f;
			if (this.HBJJOCHGOPH > 45f)
			{
				this.HBJJOCHGOPH = 710f;
			}
			this.NFMGLIKNOOC().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("UpperMid", this.ShapeFormula);
			this.EFDEIFCDAFG().SetFloat("_Near", this.Shape);
			this.CFCPHFMKHII().SetFloat("ViewMenu", this.center.x);
			this.HNICHJCGJOC().SetFloat("] ", this.center.y);
			this.NBPKMLMCHFN.SetFloat("Intensity", this.Radius);
			this.CFCPHFMKHII().SetFloat("Failed to Destroy objects of playerId: ", this._BorderSize);
			this.DOHGBNPMBKG().SetColor("settings.fps", this._BorderColor);
			this.IGKFMCPDNOI().SetFloat("_dec.json", this._AlphaHexa);
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this._SpotSize);
			this.HKHBBBFLGJH().SetVector("0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1333f, 293f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x0000CB13 File Offset: 0x0000AD13
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x0000CB4A File Offset: 0x0000AD4A
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x0000420A File Offset: 0x0000240A
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x0000420A File Offset: 0x0000240A
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0000CB6E File Offset: 0x0000AD6E
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
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

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0000CBDC File Offset: 0x0000ADDC
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Super_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040001C8 RID: 456
	public Shader SCShader;

	// Token: 0x040001C9 RID: 457
	[Range(0f, 1f)]
	public float _AlphaHexa = 1f;

	// Token: 0x040001CA RID: 458
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001CB RID: 459
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001CC RID: 460
	private Material BJFKDHHMLJH;

	// Token: 0x040001CD RID: 461
	[Range(-20f, 20f)]
	public float ShapeFormula = 10f;

	// Token: 0x040001CE RID: 462
	[Range(0f, 6f)]
	public float Shape = 1f;

	// Token: 0x040001CF RID: 463
	[Range(-4f, 4f)]
	public float _BorderSize = 1f;

	// Token: 0x040001D0 RID: 464
	public Color _BorderColor = new Color(0f, 0.2f, 1f, 1f);

	// Token: 0x040001D1 RID: 465
	public float _SpotSize = 2.5f;

	// Token: 0x040001D2 RID: 466
	public Vector2 center = new Vector2(0f, 0f);

	// Token: 0x040001D3 RID: 467
	public float Radius = 0.77f;
}
