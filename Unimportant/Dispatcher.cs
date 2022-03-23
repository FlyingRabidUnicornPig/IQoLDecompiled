/*
Importance of this class: Seems like none

Purpose of this class: Seems to be an action-buffer class or something idfk

Deobf status: Garbo
*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x0200041E RID: 1054
public class Dispatcher : Singleton<Dispatcher>
{
	// Token: 0x0600E56E RID: 58734 RVA: 0x004E6F98 File Offset: 0x004E5198
	public static void ANPCJGGANFO(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_AdditiveReflection");
			return;
		}
		if (Dispatcher.FNOCLKKLONC())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E570 RID: 58736 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool FNOCLKKLONC()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E571 RID: 58737 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public void FIABIKEIEKH()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x0600E572 RID: 58738 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool isMainThread
	{
		get
		{
			return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
		}
	}

	// Token: 0x0600E573 RID: 58739 RVA: 0x004E7004 File Offset: 0x004E5204
	public static void OMCBCHKCHIA(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_Offsets");
			return;
		}
		if (Dispatcher.FNOCLKKLONC())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E574 RID: 58740 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public new void BFIOIDMHPPL()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E575 RID: 58741 RVA: 0x004E7070 File Offset: 0x004E5270
	public static void JKODLHNFMOL(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.JPAIOEFLIFM(new Action(cjalpjdiljh.LHHFJBIAHCN));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	// Token: 0x0600E576 RID: 58742 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void AEEGKLABFLN()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E577 RID: 58743 RVA: 0x004E712C File Offset: 0x004E532C
	public static void FPAPACDLACP(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("\r");
			return;
		}
		if (Dispatcher.BKHPPLGLLJM())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E578 RID: 58744 RVA: 0x004E7198 File Offset: 0x004E5398
	public static void LIDGMBGIILI(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("{0}");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.HBPBILKHFFL(new Action(cjalpjdiljh.FJDBPPKABJE));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(6);
		}
	}

	// Token: 0x0600E579 RID: 58745 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void EPCGHAAONLN()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E57A RID: 58746 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void POHMFMNEPKK()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E57B RID: 58747 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void LEAHIBJDMBI()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E57C RID: 58748 RVA: 0x004E7254 File Offset: 0x004E5454
	public static void ICCEOOEHNLE(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("maps.");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.NCOCLAMOJED(new Action(cjalpjdiljh.OFHCGKJFGDI));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(2);
		}
	}

	// Token: 0x0600E57D RID: 58749 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool GBMDODCJLFD()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E57E RID: 58750 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void PPCGJBIIFAO()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E57F RID: 58751 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public void PHHOMLJECOJ()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E580 RID: 58752 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void IIFCIDDJHPM()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E581 RID: 58753 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void Awake()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E582 RID: 58754 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public new void JPJNECPABBG()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E583 RID: 58755 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool KGHDOIHLEAD()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E584 RID: 58756 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool LDJKLFNIOKE()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E585 RID: 58757 RVA: 0x004E72B4 File Offset: 0x004E54B4
	public static void CCHMBDINIEC(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_ToneCurve");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.IGKOMOLHGEN(new Action(cjalpjdiljh.FHFECFLBHMA));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(2);
		}
	}

	// Token: 0x0600E586 RID: 58758 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void HDDECCMEJKA()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E587 RID: 58759 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void PBEPCAPAKLG()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E588 RID: 58760 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void LPMINJJPDCH()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E589 RID: 58761 RVA: 0x004E7314 File Offset: 0x004E5514
	public static void JAJALNLEJMI(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			return;
		}
		if (Dispatcher.JCBLMAGEAGC())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E58A RID: 58762 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public new void CJHMHIMKILB()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E58B RID: 58763 RVA: 0x004E7380 File Offset: 0x004E5580
	public static void IGKOMOLHGEN(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("workshop.");
			return;
		}
		if (Dispatcher.HDLBAAKDJHD())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E58C RID: 58764 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void IIPMEPPIFCK()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E58D RID: 58765 RVA: 0x004E73EC File Offset: 0x004E55EC
	public static void ILCCFDANNGP(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError(" SphereWaveform.cs");
			return;
		}
		if (Dispatcher.isMainThread)
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E58E RID: 58766 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void MMPOJCFOGJJ()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E58F RID: 58767 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool ECNKEEBLBLF()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E590 RID: 58768 RVA: 0x004E7458 File Offset: 0x004E5658
	public static void NCDKHAOCPGN(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		if (Dispatcher.KGHDOIHLEAD())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E591 RID: 58769 RVA: 0x004E74C4 File Offset: 0x004E56C4
	public static void Invoke(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("No Dispatcher exists in the scene. Actions will not be invoked!");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.InvokeAsync(new Action(cjalpjdiljh.GBKBDKHPLKG));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(5);
		}
	}

	// Token: 0x0600E592 RID: 58770 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool AMAIMMDNNMG()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E593 RID: 58771 RVA: 0x004E7524 File Offset: 0x004E5724
	public static void OIEAKCKFDKN(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_PColor2");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.ONDAOGKDPKD(new Action(cjalpjdiljh.OFHCGKJFGDI));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	// Token: 0x0600E594 RID: 58772 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public void MFIMFMCMADK()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E595 RID: 58773 RVA: 0x004E7584 File Offset: 0x004E5784
	public static void InvokeAsync(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("No Dispatcher exists in the scene. Actions will not be invoked!");
			return;
		}
		if (Dispatcher.isMainThread)
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E596 RID: 58774 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool IFEIIJKFLIO()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E597 RID: 58775 RVA: 0x004E75F0 File Offset: 0x004E57F0
	public static void FKINAAOKLOG(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("colorD");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.NCDKHAOCPGN(new Action(cjalpjdiljh.BFEABMIFIEE));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(6);
		}
	}

	// Token: 0x0600E598 RID: 58776 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void GEGFJJBCHPE()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E599 RID: 58777 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void POJFHDFJOPE()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E59B RID: 58779 RVA: 0x004E7650 File Offset: 0x004E5850
	public static void HBPBILKHFFL(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("b");
			return;
		}
		if (Dispatcher.JLALELOKADM())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E59C RID: 58780 RVA: 0x004E76BC File Offset: 0x004E58BC
	public static void HICEPDEKBDH(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("SfxVolumeSlider");
			return;
		}
		if (Dispatcher.JCBLMAGEAGC())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E59D RID: 58781 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void MECJHOJPODB()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E59E RID: 58782 RVA: 0x004E7728 File Offset: 0x004E5928
	public static void JPAIOEFLIFM(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Added GameObject to prefabDictionary: ");
			return;
		}
		if (Dispatcher.isMainThread)
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E59F RID: 58783 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool JLALELOKADM()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E5A0 RID: 58784 RVA: 0x004E7794 File Offset: 0x004E5994
	public static void IOANLDNAKDG(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Value");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.JPAIOEFLIFM(new Action(cjalpjdiljh.OFHCGKJFGDI));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(3);
		}
	}

	// Token: 0x0600E5A1 RID: 58785 RVA: 0x004E77F4 File Offset: 0x004E59F4
	public static void NCOCLAMOJED(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError(":");
			return;
		}
		if (Dispatcher.FLICABCFBKL())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E5A2 RID: 58786 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool DIEOPCMPAJI()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E5A3 RID: 58787 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void IICACFLHBCP()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E5A4 RID: 58788 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void FABMDEHEDNO()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5A5 RID: 58789 RVA: 0x004E7860 File Offset: 0x004E5A60
	public static void JLFNHFANGIO(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("No Dispatcher exists in the scene. Actions will not be invoked!");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.FPAPACDLACP(new Action(cjalpjdiljh.EFAPFFFGOOA));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(3);
		}
	}

	// Token: 0x0600E5A6 RID: 58790 RVA: 0x004E78C0 File Offset: 0x004E5AC0
	public static void DOMMPHGEAAB(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("High");
			return;
		}
		if (Dispatcher.FNOCLKKLONC())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E5A7 RID: 58791 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void JDGFCEPDKAJ()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5A8 RID: 58792 RVA: 0x004E792C File Offset: 0x004E5B2C
	public static void EEKAGEDJFDK(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("The given 2D texture ");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.NCOCLAMOJED(new Action(cjalpjdiljh.OMBHIBNMFNB));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(4);
		}
	}

	// Token: 0x0600E5A9 RID: 58793 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool FLICABCFBKL()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E5AA RID: 58794 RVA: 0x004E798C File Offset: 0x004E5B8C
	public static void OLKPCONEIJI(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.JPAIOEFLIFM(new Action(cjalpjdiljh.PCDFLCEIHFF));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(7);
		}
	}

	// Token: 0x0600E5AB RID: 58795 RVA: 0x004E79EC File Offset: 0x004E5BEC
	public static void EAFBOLCDEON(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("[MapsData] Base maps loaded");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.OHIGJAODANN(new Action(cjalpjdiljh.HBJFIOJFBHC));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	// Token: 0x0600E5AC RID: 58796 RVA: 0x004E7A4C File Offset: 0x004E5C4C
	public static void CBPHBANODKI(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("QuickSave");
			return;
		}
		if (Dispatcher.DIEOPCMPAJI())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E5AD RID: 58797 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void CGBHOELMAOC()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5AE RID: 58798 RVA: 0x004E7AB8 File Offset: 0x004E5CB8
	public static void HEDGLIAJKAE(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Editor/");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.HICEPDEKBDH(new Action(cjalpjdiljh.BKNHHGBPLGH));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(3);
		}
	}

	// Token: 0x0600E5AF RID: 58799 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public new void GCDNONIKKLI()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E5B0 RID: 58800 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool KKALDMNKMIL()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E5B1 RID: 58801 RVA: 0x004E7B18 File Offset: 0x004E5D18
	public static void BHJADCPCCGH(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("id");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.HEEBNNAPNJO(new Action(cjalpjdiljh.FMIHBNPKEEO));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(4);
		}
	}

	// Token: 0x0600E5B2 RID: 58802 RVA: 0x004E7B78 File Offset: 0x004E5D78
	public static void OHIGJAODANN(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError(" : ");
			return;
		}
		if (Dispatcher.BKHPPLGLLJM())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E5B3 RID: 58803 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void IDIIELPAMCJ()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5B4 RID: 58804 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void NLNAJMCBNDC()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E5B5 RID: 58805 RVA: 0x004E7BE4 File Offset: 0x004E5DE4
	public static void LAJCDPBGHBO(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Uploading preview image");
			return;
		}
		if (Dispatcher.JLALELOKADM())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E5B6 RID: 58806 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool JCBLMAGEAGC()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E5B7 RID: 58807 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public new void KACPCCMPAHA()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E5B8 RID: 58808 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void DGCGGKMNPLD()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5B9 RID: 58809 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void IPJENEAMGBP()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E5BA RID: 58810 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	public new void KGMCGGIEPDE()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600E5BB RID: 58811 RVA: 0x004E7C50 File Offset: 0x004E5E50
	public static void CPPCBNOIBGG(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Items/");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.HICEPDEKBDH(new Action(cjalpjdiljh.JBAJEMGOPDL));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(8);
		}
	}

	// Token: 0x0600E5BC RID: 58812 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void KIEJKBNBHMD()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5BD RID: 58813 RVA: 0x0009C0C2 File Offset: 0x0009A2C2
	public new void JHPKLGGMCBL()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600E5BE RID: 58814 RVA: 0x004E70D0 File Offset: 0x004E52D0
	private void Update()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5BF RID: 58815 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool HDLBAAKDJHD()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E5C0 RID: 58816 RVA: 0x004E71F8 File Offset: 0x004E53F8
	private void HNDNDPECBPL()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600E5C1 RID: 58817 RVA: 0x004E7CB0 File Offset: 0x004E5EB0
	public static void ONDAOGKDPKD(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		if (Dispatcher.GBMDODCJLFD())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E5C2 RID: 58818 RVA: 0x004E7D1C File Offset: 0x004E5F1C
	public static void HEEBNNAPNJO(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Failed to Destroy objects of playerId: ");
			return;
		}
		if (Dispatcher.FNOCLKKLONC())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600E5C3 RID: 58819 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
	public static bool BKHPPLGLLJM()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600E5C4 RID: 58820 RVA: 0x004E7D88 File Offset: 0x004E5F88
	public static void LAOGGPDOLGP(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Depth textures aren't supported on this device ({0})");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.ILCCFDANNGP(new Action(cjalpjdiljh.LHHFJBIAHCN));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	// Token: 0x04001ADD RID: 6877
	private static bool EEHBMEEHKBM;

	// Token: 0x04001ADE RID: 6878
	private static Thread CEIHDHEOFJE;

	// Token: 0x04001ADF RID: 6879
	private static object BMHFFLILJHN = new object();

	// Token: 0x04001AE0 RID: 6880
	private static readonly Queue<Action> GACAEIAGHDK = new Queue<Action>();

	// Token: 0x0200041F RID: 1055
	[CompilerGenerated]
	private sealed class CJALPJDILJH
	{
		// Token: 0x0600E5C5 RID: 58821 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void AEIFJLBBKBP()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5C6 RID: 58822 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void MPGGBMMPNDH()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5C7 RID: 58823 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void KFNBKFELFLH()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void MAGEPMCPGOC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5C9 RID: 58825 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void BDGDIDPDBHG()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5CA RID: 58826 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void FDAIFOAGDLA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5CB RID: 58827 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void FJDBPPKABJE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5CC RID: 58828 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void HBJFIOJFBHC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5CD RID: 58829 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void EDGAPOPEIJF()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5CE RID: 58830 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void AEINPAGJFME()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5CF RID: 58831 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void PCDFLCEIHFF()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void FHIJCPPECHA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5D1 RID: 58833 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void JBAJEMGOPDL()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5D2 RID: 58834 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void IGFOBPKFCDJ()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5D3 RID: 58835 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void LOEAMHGMMPK()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5D4 RID: 58836 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void GBKBDKHPLKG()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5D5 RID: 58837 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void EFAPFFFGOOA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5D6 RID: 58838 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void JKEDCEOCPJO()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5D7 RID: 58839 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void AGFDCBCBAGI()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5D8 RID: 58840 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void BKNHHGBPLGH()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5D9 RID: 58841 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void EKHOOPGPPGE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5DA RID: 58842 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void DKGPCPBNDPK()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5DB RID: 58843 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void FHFECFLBHMA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5DC RID: 58844 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void LLNDDFGPOPL()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void MGENGAEDACG()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void DNIMHEKGJHB()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void OLIGLEMPFOP()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void FIPCLHEKKCA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5E1 RID: 58849 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void LHHFJBIAHCN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5E2 RID: 58850 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void FFEGPHJKMFK()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5E3 RID: 58851 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void BJMAIJDIKCN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5E4 RID: 58852 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void LNDGINDKPFA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5E5 RID: 58853 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void BBIADFAPKDL()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5E6 RID: 58854 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void DBFPGFHEGKA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5E7 RID: 58855 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void EGKGJJGAPMN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5E8 RID: 58856 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void BFEABMIFIEE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5E9 RID: 58857 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void OFLDIMDDLHM()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5EA RID: 58858 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void OFHCGKJFGDI()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5EB RID: 58859 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void MEMPOPNAEDN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5EC RID: 58860 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void JBCHBMKPDAJ()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5ED RID: 58861 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void INHOEMCLAAP()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5EE RID: 58862 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void PKAPLCFHDOC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void PIJAOCFAPKC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void JDELIMPGFDJ()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5F1 RID: 58865 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void OMBHIBNMFNB()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5F2 RID: 58866 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void AKDOOLPMPMG()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void FCAGEDLBBHD()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void KGKMOLCPDIH()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5F5 RID: 58869 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void BEBAENEJFLD()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void AGJKEBOPIOC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void FMIHBNPKEEO()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5F8 RID: 58872 RVA: 0x0009C0FA File Offset: 0x0009A2FA
		internal void BMAOCLKPNNC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600E5FA RID: 58874 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void PBCAHKDLFPE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600E5FB RID: 58875 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		internal void LJDLIIIPIIJ()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x04001AE1 RID: 6881
		internal Action LHCIHJOHGEJ;

		// Token: 0x04001AE2 RID: 6882
		internal bool GIPNPIABCOM;
	}
}
