/*
Importance of this class: Unsure. Seems unused.

Purpose of this class: Unsure, animated image, gif? idfk.

Deobf status: Awful
*/

using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000231 RID: 561
public class CreateAnimImage : MonoBehaviour
{
	// Token: 0x06008B90 RID: 35728 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void CCFEDENFNEF()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008B91 RID: 35729 RVA: 0x00341F24 File Offset: 0x00340124
	private void CBFFGNOMEAK()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008B92 RID: 35730 RVA: 0x00341F98 File Offset: 0x00340198
	public void OELGHOFHAGM()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008B93 RID: 35731 RVA: 0x00341FE0 File Offset: 0x003401E0
	private void EIIJCCJLNDD()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 786f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.OHDOCLGPIOE(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.JBEADLHMKMA();
			component.LMHFGDCFHOD();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008B94 RID: 35732 RVA: 0x00082393 File Offset: 0x00080593
	public void HHAPCIEKHKG()
	{
		this.ACEEIAIDHLC();
		this.JEHCPIHNKFM();
	}

	// Token: 0x06008B95 RID: 35733 RVA: 0x003420B0 File Offset: 0x003402B0
	public void MCMLDECJOPH()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].GIAJEMNMCDA();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008B96 RID: 35734 RVA: 0x000823A1 File Offset: 0x000805A1
	public void KAMOLLFOLHI()
	{
		this.KCCIJMNMADC();
		this.KNOFOFMEDOB();
	}

	// Token: 0x06008B97 RID: 35735 RVA: 0x00341F24 File Offset: 0x00340124
	private void KNMMNHEBMDI()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008B98 RID: 35736 RVA: 0x000823AF File Offset: 0x000805AF
	public void EENNPPGMDLL()
	{
		this.IKOJNDGFKGM();
		this.HFBDGAOLJFB();
	}

	// Token: 0x06008B99 RID: 35737 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void JKBMKPDGCHG()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008B9A RID: 35738 RVA: 0x003420F8 File Offset: 0x003402F8
	public void GEPIEEJAEMK()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].OELGHOFHAGM();
			}
			this.APFJEOHIDNN();
		}
	}

	// Token: 0x06008B9B RID: 35739 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void JECMJNFGBGC()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008B9C RID: 35740 RVA: 0x00342144 File Offset: 0x00340344
	private void IKOJNDGFKGM()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1656f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.DJLKKODJHNP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008B9D RID: 35741 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void KNBJBNDGCIJ()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008B9E RID: 35742 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void EPEGAEGDJAM()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008B9F RID: 35743 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void ICILLMAKLMI()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BA0 RID: 35744 RVA: 0x000823BD File Offset: 0x000805BD
	public void NBLMHJKINBM()
	{
		this.LFKNLGCIDHA();
		this.DIDHCAKMLOB();
	}

	// Token: 0x06008BA1 RID: 35745 RVA: 0x00342214 File Offset: 0x00340414
	private void EHIHOHBPDMH()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1658f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.BIIIKDKNLHH();
			component.ODJBGKGFCOE();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BA2 RID: 35746 RVA: 0x003422E4 File Offset: 0x003404E4
	private void LFKNLGCIDHA()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 361f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.BBINADBINLO(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.PKICDNINIGD();
			component.BAGJNDODMCP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BA3 RID: 35747 RVA: 0x003423B4 File Offset: 0x003405B4
	public void JEDMPPOOBKC()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].LNPONHBGCJB();
			}
			this.EENNPPGMDLL();
		}
	}

	// Token: 0x06008BA4 RID: 35748 RVA: 0x00341F24 File Offset: 0x00340124
	private void JOKPKIKDPEJ()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BA5 RID: 35749 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void CIPKEPDELJB()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BA6 RID: 35750 RVA: 0x00342400 File Offset: 0x00340600
	public void CCJMDELIJDP()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].ODJBGKGFCOE();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BA7 RID: 35751 RVA: 0x00342448 File Offset: 0x00340648
	public void NECLICEIOKN()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].DJLKKODJHNP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BA8 RID: 35752 RVA: 0x00341F24 File Offset: 0x00340124
	private void HFECDNAKJGE()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BA9 RID: 35753 RVA: 0x00342490 File Offset: 0x00340690
	public void DCFKADMCJME()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].CADCBLBPNGD();
			}
			this.FCCLBLACJFK();
		}
	}

	// Token: 0x06008BAA RID: 35754 RVA: 0x003424DC File Offset: 0x003406DC
	public void CHPOBKBGJHJ()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].GIAJEMNMCDA();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BAB RID: 35755 RVA: 0x00342524 File Offset: 0x00340724
	private void CKABHECOIOL()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1890f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.JBEADLHMKMA();
			component.ODJBGKGFCOE();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BAC RID: 35756 RVA: 0x000823CB File Offset: 0x000805CB
	public void APFJEOHIDNN()
	{
		this.MAPMOEGANFP();
		this.JFILJNLFDJL();
	}

	// Token: 0x06008BAD RID: 35757 RVA: 0x00341F24 File Offset: 0x00340124
	private void LJAJGEDIJKC()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BAE RID: 35758 RVA: 0x000823D9 File Offset: 0x000805D9
	public void COBGLOPODPI()
	{
		this.EJKGAAIOAPA();
		this.HFECDNAKJGE();
	}

	// Token: 0x06008BAF RID: 35759 RVA: 0x003425F4 File Offset: 0x003407F4
	private void AFEOEMBNGOL()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 0f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BB0 RID: 35760 RVA: 0x00341F24 File Offset: 0x00340124
	private void HFBDGAOLJFB()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BB1 RID: 35761 RVA: 0x000823E7 File Offset: 0x000805E7
	public void POBMDIKPGGF()
	{
		this.ICDNPNAHCGA();
		this.JOKPKIKDPEJ();
	}

	// Token: 0x06008BB2 RID: 35762 RVA: 0x003426C4 File Offset: 0x003408C4
	public void PCGIJPAKBAE()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BB3 RID: 35763 RVA: 0x0034270C File Offset: 0x0034090C
	public void HGDHFKJNFHG()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].AILAMHCFDOB();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BB4 RID: 35764 RVA: 0x003420B0 File Offset: 0x003402B0
	public void OOIDPIKMFHJ()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].GIAJEMNMCDA();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BB5 RID: 35765 RVA: 0x00342754 File Offset: 0x00340954
	private void PPNFLGFIFAM()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 247f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.OHDOCLGPIOE(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.BAGJNDODMCP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BB6 RID: 35766 RVA: 0x000823F5 File Offset: 0x000805F5
	public void CreateButtons()
	{
		this.AFEOEMBNGOL();
		this.FGIIEGMMKND();
	}

	// Token: 0x06008BB7 RID: 35767 RVA: 0x00342824 File Offset: 0x00340A24
	public void APNJFAEHFFH()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].OOIDPIKMFHJ();
			}
			this.NBLMHJKINBM();
		}
	}

	// Token: 0x06008BB8 RID: 35768 RVA: 0x00342870 File Offset: 0x00340A70
	public void DLMMFHILKPL()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].NECLICEIOKN();
			}
			this.OLDKBAOMCLN();
		}
	}

	// Token: 0x06008BB9 RID: 35769 RVA: 0x003428BC File Offset: 0x00340ABC
	public void KNIPGEGIMOI()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].AILAMHCFDOB();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BBA RID: 35770 RVA: 0x00342904 File Offset: 0x00340B04
	public void EFODNPIDAMC()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].CCJMDELIJDP();
			}
			this.APFJEOHIDNN();
		}
	}

	// Token: 0x06008BBB RID: 35771 RVA: 0x00342950 File Offset: 0x00340B50
	private void BGAMEGDKEJB()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 85f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.PGOIEGKLAKO(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.PKICDNINIGD();
			component.ODJBGKGFCOE();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BBC RID: 35772 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void KHIGHFJKPFG()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BBD RID: 35773 RVA: 0x00082403 File Offset: 0x00080603
	public void PPBMBCKCJLH()
	{
		this.HIAILIFCMKK();
		this.HFECDNAKJGE();
	}

	// Token: 0x06008BBF RID: 35775 RVA: 0x00341F24 File Offset: 0x00340124
	private void DIDHCAKMLOB()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BC0 RID: 35776 RVA: 0x00342A20 File Offset: 0x00340C20
	public void LNDGEMEOFKL()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].NHGFAFFIACM();
			}
			this.OLDKBAOMCLN();
		}
	}

	// Token: 0x06008BC1 RID: 35777 RVA: 0x00342A6C File Offset: 0x00340C6C
	private void APILMONBJEN()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 68f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.HEGLICFNJCM(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.BIIIKDKNLHH();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BC2 RID: 35778 RVA: 0x00342B3C File Offset: 0x00340D3C
	public void JLDFAFAIBBB()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].MCMLDECJOPH();
			}
			this.COBGLOPODPI();
		}
	}

	// Token: 0x06008BC3 RID: 35779 RVA: 0x00342B88 File Offset: 0x00340D88
	public void LNPONHBGCJB()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].AILAMHCFDOB();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BC4 RID: 35780 RVA: 0x00342BD0 File Offset: 0x00340DD0
	private void ACEEIAIDHLC()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 77f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.BBINADBINLO(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.JBEADLHMKMA();
			component.BAGJNDODMCP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BC5 RID: 35781 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void OKLAJINHPAN()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BC6 RID: 35782 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void PAKPHKPDKGE()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BC7 RID: 35783 RVA: 0x00341F24 File Offset: 0x00340124
	private void KNOFOFMEDOB()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BC8 RID: 35784 RVA: 0x00342CA0 File Offset: 0x00340EA0
	public void MOPFHJNLMGP()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].EAODJGNIKJD();
			}
			this.OLDKBAOMCLN();
		}
	}

	// Token: 0x06008BC9 RID: 35785 RVA: 0x00342CEC File Offset: 0x00340EEC
	private void NNPKKIGLMCJ()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1631f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.JBEADLHMKMA();
			component.LMHFGDCFHOD();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BCA RID: 35786 RVA: 0x00082424 File Offset: 0x00080624
	public void LPEAGALOLKE()
	{
		this.LFKNLGCIDHA();
		this.KPKDKDIKNNK();
	}

	// Token: 0x06008BCB RID: 35787 RVA: 0x00082432 File Offset: 0x00080632
	public void OOPIFOGNBPF()
	{
		this.JDJBHBAOIOF();
		this.NKOHAIMNONI();
	}

	// Token: 0x06008BCC RID: 35788 RVA: 0x00342DBC File Offset: 0x00340FBC
	private void EJDMILHICDI()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1580f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.PKICDNINIGD();
			component.LMHFGDCFHOD();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BCD RID: 35789 RVA: 0x00342E8C File Offset: 0x0034108C
	public void IEJNFKIHOLG()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].BJKMBOFPNLD();
			}
			this.FCCLBLACJFK();
		}
	}

	// Token: 0x06008BCE RID: 35790 RVA: 0x00342ED8 File Offset: 0x003410D8
	private void CNHNKBMJEKH()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 273f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.PKICDNINIGD();
			component.ODJBGKGFCOE();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BCF RID: 35791 RVA: 0x00342FA8 File Offset: 0x003411A8
	public void BPIHDBDGJAF()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BD0 RID: 35792 RVA: 0x00082440 File Offset: 0x00080640
	public void BBKMIELOJJG()
	{
		this.ACEEIAIDHLC();
		this.KNOFOFMEDOB();
	}

	// Token: 0x06008BD1 RID: 35793 RVA: 0x00342FF0 File Offset: 0x003411F0
	public void JHGAIGNDPMK()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].DJLKKODJHNP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BD2 RID: 35794 RVA: 0x0008244E File Offset: 0x0008064E
	public void AFMMFPBEBGO()
	{
		this.ACEEIAIDHLC();
		this.ILFDGCEAIND();
	}

	// Token: 0x06008BD3 RID: 35795 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void ALNNIDLFILB()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BD4 RID: 35796 RVA: 0x00341F24 File Offset: 0x00340124
	private void CONGFBMFHPH()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BD5 RID: 35797 RVA: 0x00341F24 File Offset: 0x00340124
	private void LHAJEFLLLGL()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BD6 RID: 35798 RVA: 0x00343038 File Offset: 0x00341238
	public void BBMCKBJNMJA()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].FLPAOOGDPCA();
			}
			this.AFMMFPBEBGO();
		}
	}

	// Token: 0x06008BD7 RID: 35799 RVA: 0x00343084 File Offset: 0x00341284
	public void CallBack()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].DestroyButtons();
			}
			this.CreateButtons();
		}
	}

	// Token: 0x06008BD8 RID: 35800 RVA: 0x0008245C File Offset: 0x0008065C
	public void OLDKBAOMCLN()
	{
		this.IKOJNDGFKGM();
		this.ILFDGCEAIND();
	}

	// Token: 0x06008BD9 RID: 35801 RVA: 0x003430D0 File Offset: 0x003412D0
	public void FLPAOOGDPCA()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].ODJBGKGFCOE();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BDA RID: 35802 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void FEHCNJLLJMP()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BDB RID: 35803 RVA: 0x0008246A File Offset: 0x0008066A
	public void FCCLBLACJFK()
	{
		this.MAPMOEGANFP();
		this.KPKDKDIKNNK();
	}

	// Token: 0x06008BDC RID: 35804 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void CEDFFAOOPOG()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BDD RID: 35805 RVA: 0x00343118 File Offset: 0x00341318
	private void MAPMOEGANFP()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1448f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.PGOIEGKLAKO(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.DJLKKODJHNP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BDE RID: 35806 RVA: 0x00341F24 File Offset: 0x00340124
	private void JFILJNLFDJL()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BDF RID: 35807 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void LFAFJKJAEEL()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BE0 RID: 35808 RVA: 0x003431E8 File Offset: 0x003413E8
	public void KPIKCFHDMAF()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].DLPKOGJDOHA();
			}
			this.HHAPCIEKHKG();
		}
	}

	// Token: 0x06008BE1 RID: 35809 RVA: 0x00343234 File Offset: 0x00341434
	public void EIANKICJDII()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].DJLKKODJHNP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BE2 RID: 35810 RVA: 0x0034327C File Offset: 0x0034147C
	private void LCGPNMMCKOI()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1269f;
		for (int i = 1; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.PKICDNINIGD();
			component.AILAMHCFDOB();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BE3 RID: 35811 RVA: 0x00341F98 File Offset: 0x00340198
	public void DLPKOGJDOHA()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BE4 RID: 35812 RVA: 0x0034334C File Offset: 0x0034154C
	public void EKGBNNNCEFO()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BE5 RID: 35813 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void Start()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BE6 RID: 35814 RVA: 0x00343394 File Offset: 0x00341594
	private void DJLJHEBJHJI()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 143f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.OHDOCLGPIOE(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.JBEADLHMKMA();
			component.BAGJNDODMCP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BE7 RID: 35815 RVA: 0x00343464 File Offset: 0x00341664
	public void CADCBLBPNGD()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].ODJBGKGFCOE();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BE8 RID: 35816 RVA: 0x003434AC File Offset: 0x003416AC
	public void OHOLFBIPHGE()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].EKGBNNNCEFO();
			}
			this.CreateButtons();
		}
	}

	// Token: 0x06008BE9 RID: 35817 RVA: 0x003434F8 File Offset: 0x003416F8
	public void LNIGBLDBOIB()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].IMEENMOOCGA();
			}
			this.KAMOLLFOLHI();
		}
	}

	// Token: 0x06008BEA RID: 35818 RVA: 0x00343544 File Offset: 0x00341744
	private void EJKGAAIOAPA()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1219f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.BIIIKDKNLHH();
			component.LMHFGDCFHOD();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BEB RID: 35819 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void DKGBFNCOAEO()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BEC RID: 35820 RVA: 0x00341F24 File Offset: 0x00340124
	private void IHFOFPNHHHH()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BED RID: 35821 RVA: 0x00082478 File Offset: 0x00080678
	public void DHJPJIKAAIN()
	{
		this.EJDMILHICDI();
		this.NKOHAIMNONI();
	}

	// Token: 0x06008BEE RID: 35822 RVA: 0x00343614 File Offset: 0x00341814
	private void JAAGGBOMLBE()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 116f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.BIIIKDKNLHH();
			component.LMHFGDCFHOD();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BEF RID: 35823 RVA: 0x003436E4 File Offset: 0x003418E4
	public void BJKMBOFPNLD()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].LMHFGDCFHOD();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BF0 RID: 35824 RVA: 0x0034372C File Offset: 0x0034192C
	public void NPNIEHJLJJH()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].AJPBFHAIDGJ();
			}
			this.PPBMBCKCJLH();
		}
	}

	// Token: 0x06008BF1 RID: 35825 RVA: 0x00341F24 File Offset: 0x00340124
	private void PJKAKJJALNA()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BF2 RID: 35826 RVA: 0x00343778 File Offset: 0x00341978
	private void OMFPLLOBOMA()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1226f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.BBINADBINLO(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.PKICDNINIGD();
			component.BAGJNDODMCP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BF3 RID: 35827 RVA: 0x00082486 File Offset: 0x00080686
	public void BLBLIBINLEJ()
	{
		this.LHPJKIOJIOD();
		this.LJAJGEDIJKC();
	}

	// Token: 0x06008BF4 RID: 35828 RVA: 0x00343848 File Offset: 0x00341A48
	public void FGLCDLJEPHF()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].OELGHOFHAGM();
			}
			this.KAMOLLFOLHI();
		}
	}

	// Token: 0x06008BF5 RID: 35829 RVA: 0x00343894 File Offset: 0x00341A94
	public void CKIBBEJOPDK()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].JGDJDGDDEBA();
			}
			this.LPEAGALOLKE();
		}
	}

	// Token: 0x06008BF6 RID: 35830 RVA: 0x003438E0 File Offset: 0x00341AE0
	public void NBOAJDADMLA()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].EAODJGNIKJD();
			}
			this.DHJPJIKAAIN();
		}
	}

	// Token: 0x06008BF7 RID: 35831 RVA: 0x00082494 File Offset: 0x00080694
	public void MEJFIPAIHJD()
	{
		this.PPNFLGFIFAM();
		this.JOKPKIKDPEJ();
	}

	// Token: 0x06008BF8 RID: 35832 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void JKFDDNMPOJH()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BF9 RID: 35833 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void CGDMLHLJIDK()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008BFA RID: 35834 RVA: 0x0034334C File Offset: 0x0034154C
	public void JGDJDGDDEBA()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008BFB RID: 35835 RVA: 0x0034392C File Offset: 0x00341B2C
	private void CJMNMCEPAAI()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1894f;
		for (int i = 1; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008BFC RID: 35836 RVA: 0x003439FC File Offset: 0x00341BFC
	public void ANMCBHIIKKH()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].EIANKICJDII();
			}
			this.FCCLBLACJFK();
		}
	}

	// Token: 0x06008BFD RID: 35837 RVA: 0x00341F24 File Offset: 0x00340124
	private void IBLMFILAIIJ()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008BFE RID: 35838 RVA: 0x000824A2 File Offset: 0x000806A2
	public void EHDNOMNPMJI()
	{
		this.ACEEIAIDHLC();
		this.IHFOFPNHHHH();
	}

	// Token: 0x06008BFF RID: 35839 RVA: 0x00343A48 File Offset: 0x00341C48
	private void KCCIJMNMADC()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1418f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.HEGLICFNJCM(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.JBEADLHMKMA();
			component.DMMEHNCIKDG();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008C00 RID: 35840 RVA: 0x00341F24 File Offset: 0x00340124
	private void FGIIEGMMKND()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008C01 RID: 35841 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void GLEJGFLCLPJ()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008C02 RID: 35842 RVA: 0x00343B18 File Offset: 0x00341D18
	public void EAODJGNIKJD()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].DMMEHNCIKDG();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008C03 RID: 35843 RVA: 0x00343B60 File Offset: 0x00341D60
	private void JDJBHBAOIOF()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 3f;
		for (int i = 1; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.BBINADBINLO(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.BIIIKDKNLHH();
			component.DMMEHNCIKDG();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008C04 RID: 35844 RVA: 0x00343C30 File Offset: 0x00341E30
	public void FKHBLFKDFPB()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008C05 RID: 35845 RVA: 0x00343C78 File Offset: 0x00341E78
	public void IMEENMOOCGA()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].DMMEHNCIKDG();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008C06 RID: 35846 RVA: 0x00343CC0 File Offset: 0x00341EC0
	public void NECPFJELGCK()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].PCGIJPAKBAE();
			}
			this.MEJFIPAIHJD();
		}
	}

	// Token: 0x06008C07 RID: 35847 RVA: 0x00343D0C File Offset: 0x00341F0C
	public void FJKAIDCJJFF()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].NECLICEIOKN();
			}
			this.AFMMFPBEBGO();
		}
	}

	// Token: 0x06008C08 RID: 35848 RVA: 0x00343D58 File Offset: 0x00341F58
	private void LHPJKIOJIOD()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1611f;
		for (int i = 1; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.PKICDNINIGD();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008C09 RID: 35849 RVA: 0x00343E28 File Offset: 0x00342028
	public void KFDPIFBEMNC()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].BJKMBOFPNLD();
			}
			this.MEJFIPAIHJD();
		}
	}

	// Token: 0x06008C0A RID: 35850 RVA: 0x00341F24 File Offset: 0x00340124
	private void ILFDGCEAIND()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008C0B RID: 35851 RVA: 0x00343E74 File Offset: 0x00342074
	private void HIAILIFCMKK()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1123f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.PGOIEGKLAKO(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.AILAMHCFDOB();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008C0C RID: 35852 RVA: 0x00343F44 File Offset: 0x00342144
	public void FLINHIJFCBP()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].NECLICEIOKN();
			}
			this.POBMDIKPGGF();
		}
	}

	// Token: 0x06008C0D RID: 35853 RVA: 0x00341F24 File Offset: 0x00340124
	private void NKOHAIMNONI()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008C0E RID: 35854 RVA: 0x000824B0 File Offset: 0x000806B0
	public void ICEDPAHNPHM()
	{
		this.EJKGAAIOAPA();
		this.IHFOFPNHHHH();
	}

	// Token: 0x06008C0F RID: 35855 RVA: 0x00341F24 File Offset: 0x00340124
	private void BKOBFHGNPME()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008C10 RID: 35856 RVA: 0x00341F98 File Offset: 0x00340198
	public void NHGFAFFIACM()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008C11 RID: 35857 RVA: 0x00343F90 File Offset: 0x00342190
	public void HHHGINCHPFL()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].CHPOBKBGJHJ();
			}
			this.EENNPPGMDLL();
		}
	}

	// Token: 0x06008C12 RID: 35858 RVA: 0x000824BE File Offset: 0x000806BE
	public void GILAHDKGGIG()
	{
		this.BGAMEGDKEJB();
		this.HFBDGAOLJFB();
	}

	// Token: 0x06008C13 RID: 35859 RVA: 0x00341F24 File Offset: 0x00340124
	private void AADOOOHJBAJ()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008C14 RID: 35860 RVA: 0x00343FDC File Offset: 0x003421DC
	public void HPGHMACPOAL()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].OOIDPIKMFHJ();
			}
			this.EENNPPGMDLL();
		}
	}

	// Token: 0x06008C15 RID: 35861 RVA: 0x00344028 File Offset: 0x00342228
	private void ICDNPNAHCGA()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 836f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.JBEADLHMKMA();
			component.DJLKKODJHNP();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008C16 RID: 35862 RVA: 0x00341F24 File Offset: 0x00340124
	private void OCOOBKKNKBF()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008C17 RID: 35863 RVA: 0x003440F8 File Offset: 0x003422F8
	public void AJPBFHAIDGJ()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].LMHFGDCFHOD();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008C18 RID: 35864 RVA: 0x00344140 File Offset: 0x00342340
	public void DestroyButtons()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008C19 RID: 35865 RVA: 0x00341EE4 File Offset: 0x003400E4
	private void IMCKJCHKMKB()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008C1A RID: 35866 RVA: 0x00341F24 File Offset: 0x00340124
	private void KPKDKDIKNNK()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008C1B RID: 35867 RVA: 0x000824CC File Offset: 0x000806CC
	public void CIJGPGLOLLK()
	{
		this.AFEOEMBNGOL();
		this.OCOOBKKNKBF();
	}

	// Token: 0x06008C1C RID: 35868 RVA: 0x00343B18 File Offset: 0x00341D18
	public void NEFJICPJFHC()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].DMMEHNCIKDG();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008C1D RID: 35869 RVA: 0x00344188 File Offset: 0x00342388
	public void LGEEHOAPJLL()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].NEFJICPJFHC();
			}
			this.FCCLBLACJFK();
		}
	}

	// Token: 0x06008C1E RID: 35870 RVA: 0x00341F24 File Offset: 0x00340124
	private void JEHCPIHNKFM()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x04000FC2 RID: 4034
	public CreateAnimImage[] createImageOtherReference;

	// Token: 0x04000FC3 RID: 4035
	public GameObject CreateInstance;

	// Token: 0x04000FC4 RID: 4036
	public int HowManyButtons;

	// Token: 0x04000FC5 RID: 4037
	public Vector3 StartAnim;

	// Token: 0x04000FC6 RID: 4038
	public Vector3 EndAnim;

	// Token: 0x04000FC7 RID: 4039
	public float Offset;

	// Token: 0x04000FC8 RID: 4040
	public AnimationCurve EnterAnim;

	// Token: 0x04000FC9 RID: 4041
	public AnimationCurve ExitAnim;

	// Token: 0x04000FCA RID: 4042
	public RectTransform RootRect;

	// Token: 0x04000FCB RID: 4043
	public RectTransform RootCanvas;

	// Token: 0x04000FCC RID: 4044
	private List<EasyTween> ABIMNKKBBKF = new List<EasyTween>();

	// Token: 0x04000FCD RID: 4045
	private Vector2 AFBJLGGJPEG;

	// Token: 0x04000FCE RID: 4046
	private float GDDJIOHEJGI;
}
