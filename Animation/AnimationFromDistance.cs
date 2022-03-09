/*
Importance of this class: unknown. Signs point to unused code.

Purpose of this class: Likely animation related. Could be outdated code?

Deobf status: Horrible Junk methods, every variable is obf'd, intra-method vars obf'd too. Ugh.
Easy to find junk methods tho. Named methods are probably the right ones. Unsure if this class is used, by anything.
*/

using System;
using UnityEngine;

// Token: 0x020003A6 RID: 934
public class AnimationFromDistance : MonoBehaviour
{
	// Token: 0x0600D0B4 RID: 53428 RVA: 0x00098EC8 File Offset: 0x000970C8
	public void LLNGFJLNGPH()
	{
		AnimationFromDistance.LGILGCGIHHM = 294f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0B5 RID: 53429 RVA: 0x00098EDB File Offset: 0x000970DB
	private void POHMFMNEPKK()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.FGAPIOELJCG();
	}

	// Token: 0x0600D0B6 RID: 53430 RVA: 0x0048FDB0 File Offset: 0x0048DFB0
	private void KIEJKBNBHMD()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1794f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1713f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("Uploading content", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1999f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1244f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 143f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("SfxVolumeSlider", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0B7 RID: 53431 RVA: 0x00098F05 File Offset: 0x00097105
	private void DEJEBOGKMJO()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.HELAPIIFLCC();
	}

	// Token: 0x0600D0B8 RID: 53432 RVA: 0x00098F2F File Offset: 0x0009712F
	private void NFMDNEJAGLB()
	{
		this.EFGKBEHNOBH.SetFloat("_Extra2", 1986f);
		this.OLBDFLPFFHP = 1899f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 3f;
	}

	// Token: 0x0600D0B9 RID: 53433 RVA: 0x00098F62 File Offset: 0x00097162
	public void AMADKKLPCBI()
	{
		AnimationFromDistance.LGILGCGIHHM = 28f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0BA RID: 53434 RVA: 0x00098F75 File Offset: 0x00097175
	public void ABFGBBGNPGO()
	{
		AnimationFromDistance.LGILGCGIHHM = 961f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0BB RID: 53435 RVA: 0x0048FEC4 File Offset: 0x0048E0C4
	private void LBIOIEANMGI()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 133f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1412f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("Blues", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 62f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (966f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1596f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Value3", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0BC RID: 53436 RVA: 0x0048FFD8 File Offset: 0x0048E1D8
	private void EGEGNHLODAA()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1079f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1991f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("CameraFilterPack/3D_Myst", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1501f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (492f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1222f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("0,7,true,0", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0BD RID: 53437 RVA: 0x00098F88 File Offset: 0x00097188
	private void HBFLDGHLMBJ()
	{
		this.EFGKBEHNOBH.SetFloat("CameraFilterPack/Drawing_Curve", 1971f);
		this.OLBDFLPFFHP = 523f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1765f;
	}

	// Token: 0x0600D0BE RID: 53438 RVA: 0x00098FBB File Offset: 0x000971BB
	private void IPJENEAMGBP()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.PMLPJADKFMG();
	}

	// Token: 0x0600D0BF RID: 53439 RVA: 0x004900EC File Offset: 0x0048E2EC
	private void HLDFOJMHKNL()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 749f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1123f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1398f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (888f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 394f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("player.dragon", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0C0 RID: 53440 RVA: 0x00098FE5 File Offset: 0x000971E5
	private void Reset()
	{
		this.EFGKBEHNOBH.SetFloat("time", 0f);
		this.OLBDFLPFFHP = 0f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 0f;
	}

	// Token: 0x0600D0C1 RID: 53441 RVA: 0x00099018 File Offset: 0x00097218
	public void CAILBNIDHHI()
	{
		AnimationFromDistance.LGILGCGIHHM = 836f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0C2 RID: 53442 RVA: 0x0009902B File Offset: 0x0009722B
	public void COFBCDEMIDI()
	{
		AnimationFromDistance.LGILGCGIHHM = 945f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0C3 RID: 53443 RVA: 0x0009903E File Offset: 0x0009723E
	private void HFFAJNCOJNB()
	{
		this.EFGKBEHNOBH.SetFloat("Failed to Destroy objects of playerId: ", 2f);
		this.OLBDFLPFFHP = 1618f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1368f;
	}

	// Token: 0x0600D0C4 RID: 53444 RVA: 0x00490200 File Offset: 0x0048E400
	private void PHJJHFBLICM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1310f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 499f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Value4", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 512f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1698f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1445f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("3d text", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0C5 RID: 53445 RVA: 0x00099071 File Offset: 0x00097271
	private void FGAPIOELJCG()
	{
		this.EFGKBEHNOBH.SetFloat("MainCamera", 1436f);
		this.OLBDFLPFFHP = 27f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 679f;
	}

	// Token: 0x0600D0C6 RID: 53446 RVA: 0x000990A4 File Offset: 0x000972A4
	public AnimationFromDistance()
	{
	}

	// Token: 0x0600D0C7 RID: 53447 RVA: 0x000990C2 File Offset: 0x000972C2
	private void LOKKIADJAFE()
	{
		this.EFGKBEHNOBH.SetFloat("RecieveChatActionMessage", 1084f);
		this.OLBDFLPFFHP = 928f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1689f;
	}

	// Token: 0x0600D0C8 RID: 53448 RVA: 0x000990F5 File Offset: 0x000972F5
	private void OEMJNJALGAC()
	{
		this.EFGKBEHNOBH.SetFloat("FinalScoreSmallText", 1597f);
		this.OLBDFLPFFHP = 85f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1907f;
	}

	// Token: 0x0600D0C9 RID: 53449 RVA: 0x00490314 File Offset: 0x0048E514
	private void IIFCIDDJHPM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 905f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1356f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Value4", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 176f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (857f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1004f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("&search=", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0CA RID: 53450 RVA: 0x00099128 File Offset: 0x00097328
	private void HELAPIIFLCC()
	{
		this.EFGKBEHNOBH.SetFloat("_Value3", 1988f);
		this.OLBDFLPFFHP = 1969f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1585f;
	}

	// Token: 0x0600D0CB RID: 53451 RVA: 0x00098EDB File Offset: 0x000970DB
	private void HHJBBHEBJCJ()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.FGAPIOELJCG();
	}

	// Token: 0x0600D0CC RID: 53452 RVA: 0x0009915B File Offset: 0x0009735B
	public void NBBDMPCBKAM()
	{
		AnimationFromDistance.LGILGCGIHHM = 505f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0CD RID: 53453 RVA: 0x0009916E File Offset: 0x0009736E
	public void FAFAPJOEHLC()
	{
		AnimationFromDistance.LGILGCGIHHM = 1097f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0CE RID: 53454 RVA: 0x00099181 File Offset: 0x00097381
	private void EIFCCFBJKOO()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.BJKJEJJOPLC();
	}

	// Token: 0x0600D0CF RID: 53455 RVA: 0x00490428 File Offset: 0x0048E628
	private void KCDOMIJBFLL()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1410f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1633f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("[Singleton] Using instance of '", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1044f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (947f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1543f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat(",", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0D0 RID: 53456 RVA: 0x000991AB File Offset: 0x000973AB
	private void EMANBHKAONB()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.FMAIMMNHLHK();
	}

	// Token: 0x0600D0D1 RID: 53457 RVA: 0x000991D5 File Offset: 0x000973D5
	private void JIJPHEDDIHC()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.IAPOBEGCHLG();
	}

	// Token: 0x0600D0D2 RID: 53458 RVA: 0x000991FF File Offset: 0x000973FF
	private void PPCGJBIIFAO()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.JHPDFCAGCHC();
	}

	// Token: 0x0600D0D3 RID: 53459 RVA: 0x00099229 File Offset: 0x00097429
	private void JEKEBJCHOHO()
	{
		this.EFGKBEHNOBH.SetFloat("https://twitch.tv/intralism", 1426f);
		this.OLBDFLPFFHP = 1708f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 49f;
	}

	// Token: 0x0600D0D4 RID: 53460 RVA: 0x0049053C File Offset: 0x0048E73C
	private void AEEGKLABFLN()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1722f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1915f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Value3", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 668f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (94f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1577f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("th", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0D5 RID: 53461 RVA: 0x00098EDB File Offset: 0x000970DB
	private void DMIKIDGJEFC()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.FGAPIOELJCG();
	}

	// Token: 0x0600D0D6 RID: 53462 RVA: 0x0009925C File Offset: 0x0009745C
	private void CPGAFFIOGCH()
	{
		this.EFGKBEHNOBH.SetFloat("PerfectHitsScoreText", 463f);
		this.OLBDFLPFFHP = 1134f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1120f;
	}

	// Token: 0x0600D0D7 RID: 53463 RVA: 0x00490650 File Offset: 0x0048E850
	private void KMEONPMCNJG()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 578f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1923f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("settings.enableranking", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 50f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (577f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1793f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("ShowTitle", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0D8 RID: 53464 RVA: 0x00490764 File Offset: 0x0048E964
	private void JBCNIPJDPJB()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1721f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 381f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Value4", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1701f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1397f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1588f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Value2", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0D9 RID: 53465 RVA: 0x0009928F File Offset: 0x0009748F
	public void BAAAOIHDFPA()
	{
		AnimationFromDistance.LGILGCGIHHM = 1094f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0DA RID: 53466 RVA: 0x000992A2 File Offset: 0x000974A2
	private void Awake()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.Reset();
	}

	// Token: 0x0600D0DB RID: 53467 RVA: 0x000992CC File Offset: 0x000974CC
	public void OOFHLADJHHK()
	{
		AnimationFromDistance.LGILGCGIHHM = 1473f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0DC RID: 53468 RVA: 0x000992DF File Offset: 0x000974DF
	public void GOAMJNAHLMP()
	{
		AnimationFromDistance.LGILGCGIHHM = 1417f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0DD RID: 53469 RVA: 0x000992F2 File Offset: 0x000974F2
	public void NFNBBGEAFPJ()
	{
		AnimationFromDistance.LGILGCGIHHM = 1157f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0DE RID: 53470 RVA: 0x000991D5 File Offset: 0x000973D5
	private void GLGOLEOAFOD()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.IAPOBEGCHLG();
	}

	// Token: 0x0600D0DF RID: 53471 RVA: 0x00099305 File Offset: 0x00097505
	public void LODJJNAJLPL()
	{
		AnimationFromDistance.LGILGCGIHHM = 271f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0E0 RID: 53472 RVA: 0x00099318 File Offset: 0x00097518
	private void JGKICMKMOKO()
	{
		this.EFGKBEHNOBH.SetFloat("received</b>\n#reason: ", 1488f);
		this.OLBDFLPFFHP = 1271f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1781f;
	}

	// Token: 0x0600D0E1 RID: 53473 RVA: 0x0009934B File Offset: 0x0009754B
	private void NBOKAGMABPN()
	{
		this.EFGKBEHNOBH.SetFloat("[MapsData] User's maps was loaded", 215f);
		this.OLBDFLPFFHP = 753f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1934f;
	}

	// Token: 0x0600D0E2 RID: 53474 RVA: 0x0009937E File Offset: 0x0009757E
	private void KGMCGGIEPDE()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.CHDIPOPHGCP();
	}

	// Token: 0x0600D0E3 RID: 53475 RVA: 0x000993A8 File Offset: 0x000975A8
	public void DFAPKHJCBOC()
	{
		AnimationFromDistance.LGILGCGIHHM = 1399f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0E4 RID: 53476 RVA: 0x000993BB File Offset: 0x000975BB
	private void GBNOIKAPBBO()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.ABDHDGNIHHI();
	}

	// Token: 0x0600D0E5 RID: 53477 RVA: 0x000993E5 File Offset: 0x000975E5
	public void Blow()
	{
		AnimationFromDistance.LGILGCGIHHM = 0f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0E6 RID: 53478 RVA: 0x00490878 File Offset: 0x0048EA78
	private void DPIPGGDNGHN()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 385f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1347f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("DPADHOR", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1343f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (187f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1046f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("closed", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0E7 RID: 53479 RVA: 0x000993F8 File Offset: 0x000975F8
	private void IOFCBLHLCBB()
	{
		this.EFGKBEHNOBH.SetFloat("event", 1479f);
		this.OLBDFLPFFHP = 1091f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 694f;
	}

	// Token: 0x0600D0E8 RID: 53480 RVA: 0x0049098C File Offset: 0x0048EB8C
	private void EJFJENFKLND()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 84f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1388f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("Text", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1276f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (688f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 579f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("Simulate", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0E9 RID: 53481 RVA: 0x0009942B File Offset: 0x0009762B
	private void CHDIPOPHGCP()
	{
		this.EFGKBEHNOBH.SetFloat("Received RPC: ", 1352f);
		this.OLBDFLPFFHP = 684f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1282f;
	}

	// Token: 0x0600D0EA RID: 53482 RVA: 0x000993BB File Offset: 0x000975BB
	private void PMBIKIBOHOF()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.ABDHDGNIHHI();
	}

	// Token: 0x0600D0EB RID: 53483 RVA: 0x0009945E File Offset: 0x0009765E
	public void EKKFKELDHGD()
	{
		AnimationFromDistance.LGILGCGIHHM = 1392f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0EC RID: 53484 RVA: 0x00099471 File Offset: 0x00097671
	private void MCIEAOAMOIG()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.OEMJNJALGAC();
	}

	// Token: 0x0600D0ED RID: 53485 RVA: 0x00098FBB File Offset: 0x000971BB
	private void JBIFKBNPHJE()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.PMLPJADKFMG();
	}

	// Token: 0x0600D0EE RID: 53486 RVA: 0x00490AA0 File Offset: 0x0048ECA0
	private void LEAHIBJDMBI()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1120f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1514f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("#", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 856f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1865f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 409f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("EventTimeInputField", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0EF RID: 53487 RVA: 0x0009949B File Offset: 0x0009769B
	public void GIIMPPGJLNB()
	{
		AnimationFromDistance.LGILGCGIHHM = 284f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0F0 RID: 53488 RVA: 0x000994AE File Offset: 0x000976AE
	private void NKHLPNAMBEH()
	{
		this.EFGKBEHNOBH.SetFloat("EventSystem", 1791f);
		this.OLBDFLPFFHP = 616f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 200f;
	}

	// Token: 0x0600D0F1 RID: 53489 RVA: 0x000994E1 File Offset: 0x000976E1
	private void FEAPMDENLBN()
	{
		this.EFGKBEHNOBH.SetFloat("CameraFilterPack_WaterDrop", 1847f);
		this.OLBDFLPFFHP = 1628f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 767f;
	}

	// Token: 0x0600D0F2 RID: 53490 RVA: 0x00099514 File Offset: 0x00097714
	public void BIBAKFKFPPM()
	{
		AnimationFromDistance.LGILGCGIHHM = 687f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0F3 RID: 53491 RVA: 0x00490BB4 File Offset: 0x0048EDB4
	private void JOACBIEHHCE()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1727f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1338f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("2;13;14;15;16", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 146f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (353f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1940f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat(" ", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0F4 RID: 53492 RVA: 0x00099527 File Offset: 0x00097727
	public void PNDKCDPIGAL()
	{
		AnimationFromDistance.LGILGCGIHHM = 1106f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0F5 RID: 53493 RVA: 0x0009953A File Offset: 0x0009773A
	private void BJKJEJJOPLC()
	{
		this.EFGKBEHNOBH.SetFloat("Remove Environment Object", 707f);
		this.OLBDFLPFFHP = 730f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 297f;
	}

	// Token: 0x0600D0F6 RID: 53494 RVA: 0x00490CC8 File Offset: 0x0048EEC8
	private void LMBDNPLDGIJ()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 90f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 702f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat(".status", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 230f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1970f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1010f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Value6", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0F7 RID: 53495 RVA: 0x00490DDC File Offset: 0x0048EFDC
	private void GMELGGJOPBB()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1886f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 44f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_AdaptTex", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1672f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (23f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1109f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("achievements.21.progress", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0F8 RID: 53496 RVA: 0x00098EDB File Offset: 0x000970DB
	private void LJEFMGOBKGE()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.FGAPIOELJCG();
	}

	// Token: 0x0600D0F9 RID: 53497 RVA: 0x00490EF0 File Offset: 0x0048F0F0
	private void FJHFOBHJEHL()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1699f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1568f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("Done!", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 827f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1544f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1083f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("settings.gamemessagesduration", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FA RID: 53498 RVA: 0x00491004 File Offset: 0x0048F204
	private void Update()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("time", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 0.4f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 0f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("time", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FB RID: 53499 RVA: 0x00098F05 File Offset: 0x00097105
	private void CCDNJPNLGBN()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.HELAPIIFLCC();
	}

	// Token: 0x0600D0FC RID: 53500 RVA: 0x0009956D File Offset: 0x0009776D
	private void IAPOBEGCHLG()
	{
		this.EFGKBEHNOBH.SetFloat("Set particles count per one beat", 1703f);
		this.OLBDFLPFFHP = 692f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 379f;
	}

	// Token: 0x0600D0FD RID: 53501 RVA: 0x00491118 File Offset: 0x0048F318
	private void BGFJOEPFOPM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 35f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 688f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("Committing changes...", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 14f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1017f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1277f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("seconds", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FE RID: 53502 RVA: 0x0049122C File Offset: 0x0048F42C
	private void MDCFIHDPLIG()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 486f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 362f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_ExposureAdjustment", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1792f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1851f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1762f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("MaxLivesSlider", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FF RID: 53503 RVA: 0x000995A0 File Offset: 0x000977A0
	public void CEEJCAJFJFL()
	{
		AnimationFromDistance.LGILGCGIHHM = 663f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D100 RID: 53504 RVA: 0x00491340 File Offset: 0x0048F540
	private void HNDNDPECBPL()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1341f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1259f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Offsets", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1779f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1849f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1653f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_FadeFX", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D101 RID: 53505 RVA: 0x00491454 File Offset: 0x0048F654
	private void POJFHDFJOPE()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 779f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 397f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat(".lastCheckpoint.correctScore", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1295f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1309f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1294f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("InfoCanvas", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D102 RID: 53506 RVA: 0x00491568 File Offset: 0x0048F768
	private void AGMJDGHLBMN()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 331f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 559f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("<b><i>Map's Stats:</i></b>", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1692f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (649f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1654f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("CameraFilterPack/Blend2Camera_Hue", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D103 RID: 53507 RVA: 0x0049167C File Offset: 0x0048F87C
	private void HDDECCMEJKA()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 145f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 661f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Color", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 214f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (356f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1871f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D104 RID: 53508 RVA: 0x000995B3 File Offset: 0x000977B3
	public void LBNJBBKMKIE()
	{
		AnimationFromDistance.LGILGCGIHHM = 1695f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D105 RID: 53509 RVA: 0x00491790 File Offset: 0x0048F990
	private void KFACDBHDAOD()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 854f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1754f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("[PlayerController] ", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 219f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (856f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1763f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("id", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D106 RID: 53510 RVA: 0x000995C6 File Offset: 0x000977C6
	private void JHPDFCAGCHC()
	{
		this.EFGKBEHNOBH.SetFloat("_MainTex2", 17f);
		this.OLBDFLPFFHP = 685f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 460f;
	}

	// Token: 0x0600D107 RID: 53511 RVA: 0x000995F9 File Offset: 0x000977F9
	private void ABDHDGNIHHI()
	{
		this.EFGKBEHNOBH.SetFloat("_TimeX", 405f);
		this.OLBDFLPFFHP = 1058f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1130f;
	}

	// Token: 0x0600D108 RID: 53512 RVA: 0x000993BB File Offset: 0x000975BB
	private void BFFHPJMMGHD()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.ABDHDGNIHHI();
	}

	// Token: 0x0600D109 RID: 53513 RVA: 0x0009962C File Offset: 0x0009782C
	public void BAGCNPNMBMH()
	{
		AnimationFromDistance.LGILGCGIHHM = 945f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D10A RID: 53514 RVA: 0x0009963F File Offset: 0x0009783F
	public void ICOFJDNIFHM()
	{
		AnimationFromDistance.LGILGCGIHHM = 1830f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D10B RID: 53515 RVA: 0x00099652 File Offset: 0x00097852
	public void IMIOENPJAAB()
	{
		AnimationFromDistance.LGILGCGIHHM = 542f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D10C RID: 53516 RVA: 0x00099665 File Offset: 0x00097865
	private void PMLPJADKFMG()
	{
		this.EFGKBEHNOBH.SetFloat("SaveButton", 133f);
		this.OLBDFLPFFHP = 911f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 414f;
	}

	// Token: 0x0600D10D RID: 53517 RVA: 0x00099471 File Offset: 0x00097671
	private void HBPLJMJAAHK()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.OEMJNJALGAC();
	}

	// Token: 0x0600D10E RID: 53518 RVA: 0x00099698 File Offset: 0x00097898
	public void NOPGKGNKECG()
	{
		AnimationFromDistance.LGILGCGIHHM = 1170f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D10F RID: 53519 RVA: 0x0000420A File Offset: 0x0000240A
	// Note: this type is marked as 'beforefieldinit'.
	static AnimationFromDistance()
	{
	}

	// Token: 0x0600D110 RID: 53520 RVA: 0x000996AB File Offset: 0x000978AB
	private void FMAIMMNHLHK()
	{
		this.EFGKBEHNOBH.SetFloat("_LutTex", 1225f);
		this.OLBDFLPFFHP = 84f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1929f;
	}

	// Token: 0x0600D111 RID: 53521 RVA: 0x004918A4 File Offset: 0x0048FAA4
	private void CGBHOELMAOC()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1767f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 211f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("Ok", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 777f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1805f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 387f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Green_R", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x04001809 RID: 6153
	private float MPNMOONBMII = 5f;

	// Token: 0x0400180A RID: 6154
	private float IIFGDPMOKOO = 10f;

	// Token: 0x0400180B RID: 6155
	private Animator EFGKBEHNOBH;

	// Token: 0x0400180C RID: 6156
	private Transform OJICGBOIKNA;

	// Token: 0x0400180D RID: 6157
	private bool CFCECAPJCOM;

	// Token: 0x0400180E RID: 6158
	private static float LGILGCGIHHM;

	// Token: 0x0400180F RID: 6159
	private float OLBDFLPFFHP;
}
