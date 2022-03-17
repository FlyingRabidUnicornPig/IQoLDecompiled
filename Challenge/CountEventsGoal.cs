/*
Importance of this class: Mild.

Purpose of this class: I assume this tracks progress of a certain "event" (map played, times played, idfk)

Deobf status: Fucking awful
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x02000382 RID: 898
public class CountEventsGoal : ChallengeGoal
{
	// Token: 0x0600C7AB RID: 51115 RVA: 0x000962D3 File Offset: 0x000944D3
	public override void PIKFPFLKBCG()
	{
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.IPGKJJJPLOL));
		base.PIKFPFLKBCG();
	}

	// Token: 0x0600C7AC RID: 51116 RVA: 0x000962F1 File Offset: 0x000944F1
	public virtual void OKJDCJIDGCH()
	{
		base.HEPLJACPKFO();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(base.KHILCMNLMOJ() + "open", 1, null);
		base.GoalProgress = this.LNACNNOIHMB();
	}

	// Token: 0x0600C7AD RID: 51117 RVA: 0x00096327 File Offset: 0x00094527
	public virtual void ICAAJACIAPH()
	{
		base.PPPFKGOCMLO();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(base.PHPLKBPIMIH() + "challenges.", 1, null);
		base.BNPNMCFLDNI(this.GICDHIHBFHI());
	}

	// Token: 0x0600C7AE RID: 51118 RVA: 0x0009635D File Offset: 0x0009455D
	public virtual void NMFBGKMIHFA()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= this.BOOHNLOCBDK;
		base.IOIAOIMIIMA();
	}

	// Token: 0x0600C7AF RID: 51119 RVA: 0x00472B90 File Offset: 0x00470D90
	public virtual void HLFLMNNEKBJ(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'e';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("CameraFilterPack/Blur_Radial", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.FIBINEJFAHF));
		Singleton<GameManager>.Instance.OnGameEvent += this.KJKPJNECCAA;
		this.EMDHDEGLPPF();
	}

	// Token: 0x0600C7B0 RID: 51120 RVA: 0x0009637B File Offset: 0x0009457B
	public virtual void BMMJGMKOBJL()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.CBLPBNNHFDF));
		base.ALGICFLJJBM();
	}

	// Token: 0x0600C7B1 RID: 51121 RVA: 0x00472C24 File Offset: 0x00470E24
	public virtual void AIAIAJFFBIN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KJJMJJJEGDB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-35;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_Blue_G", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.AJNMBKABIMO));
		Singleton<GameManager>.Instance.OnGameEvent += this.IPGKJJJPLOL;
		this.HEPLJACPKFO();
	}

	// Token: 0x0600C7B2 RID: 51122 RVA: 0x00096399 File Offset: 0x00094599
	public virtual void KIBIPGFCBKO()
	{
		base.LoadProgress();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(base.JLGGLIMFAFJ() + "_SSAO", 0, null);
		base.JKINKBKCGFP(this.LNACNNOIHMB());
	}

	// Token: 0x0600C7B3 RID: 51123 RVA: 0x00472CB8 File Offset: 0x00470EB8
	private void CGKBKHDGKNP(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.PPEBDMBKOBD());
		if (Singleton<LuaEnvironment>.Instance.NILOPHNEAIC(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.AHMNICEJLMF(this.CAOJDEFHMAG());
		}
	}

	// Token: 0x0600C7B4 RID: 51124 RVA: 0x000963CF File Offset: 0x000945CF
	public virtual void NGHGLCLLIMP()
	{
		base.AGCKLPAKDAK();
		Singleton<SaveSystem>.Instance.GBFBKFACPBI(base.KHILCMNLMOJ() + "_Value2", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7B5 RID: 51125 RVA: 0x000963F8 File Offset: 0x000945F8
	public virtual void ABFLIINAFLC()
	{
		base.OPDGBIPHKGC();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(base.JLGGLIMFAFJ() + "IconFileSelector", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7B6 RID: 51126 RVA: 0x00096421 File Offset: 0x00094621
	public virtual void LKGPOLEPAEG()
	{
		base.OPDGBIPHKGC();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(base.FJFFJLBABDI() + " at ", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7B7 RID: 51127 RVA: 0x0009644A File Offset: 0x0009464A
	public virtual void GOFMABPMLKF()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.FJFFJLBABDI() + "_ScreenResolution", null);
		base.IJHPPIHFFEA();
	}

	// Token: 0x0600C7B8 RID: 51128 RVA: 0x00472D04 File Offset: 0x00470F04
	private void NLPFNLACBHB(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.NHENNCOILPG(this.CEKIBLKIKEF());
		}
	}

	// Token: 0x0600C7B9 RID: 51129 RVA: 0x0009646D File Offset: 0x0009466D
	private float CDCIEIOFABB()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C7BB RID: 51131 RVA: 0x00096491 File Offset: 0x00094691
	public virtual void AODLIPCOIAK()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= this.OKLHDAEHLKC;
		base.ONLIHAEAHOJ();
	}

	// Token: 0x0600C7BC RID: 51132 RVA: 0x0009646D File Offset: 0x0009466D
	private float MBKDOOBIJJJ()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C7BD RID: 51133 RVA: 0x00472D50 File Offset: 0x00470F50
	private void KJKPJNECCAA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.BNPNMCFLDNI(this.GICDHIHBFHI());
		}
	}

	// Token: 0x0600C7BE RID: 51134 RVA: 0x0009646D File Offset: 0x0009466D
	private float OKMLICIEMEG()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C7BF RID: 51135 RVA: 0x00472D9C File Offset: 0x00470F9C
	public virtual void EAEAIFOBPHI(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'i';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("id", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.ANGLIEAGDOA));
		Singleton<GameManager>.Instance.AALMFLNJPDG(new GameManager.PlayerGameEvent(this.AJNMBKABIMO));
		this.HEPLJACPKFO();
	}

	// Token: 0x0600C7C0 RID: 51136 RVA: 0x0009646D File Offset: 0x0009466D
	private float CAOJDEFHMAG()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C7C1 RID: 51137 RVA: 0x000964AF File Offset: 0x000946AF
	public virtual void DOPPMCDLPBE()
	{
		base.FLEONCKOLNB();
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(base.PHPLKBPIMIH() + "CameraFilterPack/Colors_Adjust_ColorRGB", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7C2 RID: 51138 RVA: 0x000964D8 File Offset: 0x000946D8
	public virtual void HBEJAGDGJAI()
	{
		base.HOEHJFEELNJ();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(base.DNEPKKKEBEA() + "GlassColor", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7C3 RID: 51139 RVA: 0x00096501 File Offset: 0x00094701
	public virtual void DOKEOBBOHEL()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= this.ANGLIEAGDOA;
		base.KLEMLMOPEFE();
	}

	// Token: 0x0600C7C4 RID: 51140 RVA: 0x0009651F File Offset: 0x0009471F
	public virtual void BJHJCGJACEA()
	{
		Singleton<SaveSystem>.Instance.IOJKJDBACPC(base.KHILCMNLMOJ() + "_TimeX", null);
		base.CJPIGOKLKOA();
	}

	// Token: 0x0600C7C5 RID: 51141 RVA: 0x00096542 File Offset: 0x00094742
	public virtual void DEDANNMJNOC()
	{
		Singleton<SaveSystem>.Instance.IOJKJDBACPC(base.KHILCMNLMOJ() + ".r", null);
		base.Reset();
	}

	// Token: 0x0600C7C6 RID: 51142 RVA: 0x00472E30 File Offset: 0x00471030
	public virtual void MBLDJHOBIMG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NGLEHMAEEKL(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'z';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("Can not SetMasterClient(). Not in room or in offlineMode.", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.KCNNFCFHAHI));
		Singleton<GameManager>.Instance.AALMFLNJPDG(new GameManager.PlayerGameEvent(this.AJNMBKABIMO));
		this.HEPLJACPKFO();
	}

	// Token: 0x0600C7C7 RID: 51143 RVA: 0x00096565 File Offset: 0x00094765
	public virtual void CHMIIBGANOP()
	{
		base.EMDHDEGLPPF();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(base.BGOBKCLKJMD() + "Checkpoint", 0, null);
		base.GoalProgress = this.OKMLICIEMEG();
	}

	// Token: 0x0600C7C8 RID: 51144 RVA: 0x00472EC4 File Offset: 0x004710C4
	private void CBLPBNNHFDF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.ENBEECGHGLO(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.JKINKBKCGFP(this.LNACNNOIHMB());
		}
	}

	// Token: 0x0600C7C9 RID: 51145 RVA: 0x0009659B File Offset: 0x0009479B
	public virtual void AFGLHMCLJJN()
	{
		base.LoadProgress();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(base.DNEPKKKEBEA() + "_ScreenResolution", 1, null);
		base.AHMNICEJLMF(this.GICDHIHBFHI());
	}

	// Token: 0x0600C7CA RID: 51146 RVA: 0x000965D1 File Offset: 0x000947D1
	public virtual void PKFHBBCFEHG()
	{
		base.KANOEJEJAJN();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(base.BGOBKCLKJMD() + "Image", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7CB RID: 51147 RVA: 0x000965FA File Offset: 0x000947FA
	public virtual void JODHOODGJGP()
	{
		base.OMENGFPFDLL();
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(base.DNEPKKKEBEA() + "CameraFilterPack/Distortion_BlackHole", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7CC RID: 51148 RVA: 0x00472F10 File Offset: 0x00471110
	public virtual void BFJJMGFNGMN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KHMFEHEPGAM(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			(char)-59
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_ScreenResolution", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.None);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.NNFFNFNKFOF));
		Singleton<GameManager>.Instance.AALMFLNJPDG(new GameManager.PlayerGameEvent(this.KCNNFCFHAHI));
		this.HEPLJACPKFO();
	}

	// Token: 0x0600C7CD RID: 51149 RVA: 0x0009646D File Offset: 0x0009466D
	private float LNACNNOIHMB()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C7CE RID: 51150 RVA: 0x00472FA4 File Offset: 0x004711A4
	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			','
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join(",", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.OnGameEvent -= this.OKLHDAEHLKC;
		Singleton<GameManager>.Instance.OnGameEvent += this.OKLHDAEHLKC;
		this.LoadProgress();
	}

	// Token: 0x0600C7CF RID: 51151 RVA: 0x00096623 File Offset: 0x00094823
	public virtual void KIILJGKMPOA()
	{
		base.EMDHDEGLPPF();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(base.KHILCMNLMOJ() + " ", 1, null);
		base.BNPNMCFLDNI(this.CAOJDEFHMAG());
	}

	// Token: 0x0600C7D0 RID: 51152 RVA: 0x00473038 File Offset: 0x00471238
	public virtual void DMGIOKBHOBL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-33;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("Edited unlock conditions", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.KCNNFCFHAHI));
		Singleton<GameManager>.Instance.OnGameEvent += this.CGKBKHDGKNP;
		this.DFBDPJGHEEK();
	}

	// Token: 0x0600C7D1 RID: 51153 RVA: 0x00096659 File Offset: 0x00094859
	public virtual void DGNLHKLGAMC()
	{
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE(base.JLGGLIMFAFJ() + "Move environment object to the position", null);
		base.IJHPPIHFFEA();
	}

	// Token: 0x0600C7D2 RID: 51154 RVA: 0x0009667C File Offset: 0x0009487C
	public virtual void JADEDAEMLBN()
	{
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM(base.ADHHBPHLCJO() + "_Value", null);
		base.NHJBGDIEGPH();
	}

	// Token: 0x0600C7D3 RID: 51155 RVA: 0x0009669F File Offset: 0x0009489F
	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= this.OKLHDAEHLKC;
		base.OnCompleted();
	}

	// Token: 0x0600C7D4 RID: 51156 RVA: 0x004730CC File Offset: 0x004712CC
	public virtual void LJOEJPOJPGH(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DPIDHAFMFGG(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = (char)-96;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("OnPlayerGameMessage", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.OKLHDAEHLKC));
		Singleton<GameManager>.Instance.OnGameEvent += this.NLPFNLACBHB;
		this.HEPLJACPKFO();
	}

	// Token: 0x0600C7D5 RID: 51157 RVA: 0x00473160 File Offset: 0x00471360
	private void ANGLIEAGDOA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.GAFCMDALGPH(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.AHMNICEJLMF(this.LNACNNOIHMB());
		}
	}

	// Token: 0x0600C7D6 RID: 51158 RVA: 0x004731AC File Offset: 0x004713AC
	private void OKLHDAEHLKC(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.GoalProgress = this.CAOJDEFHMAG();
		}
	}

	// Token: 0x0600C7D7 RID: 51159 RVA: 0x0009646D File Offset: 0x0009466D
	private float CEKIBLKIKEF()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C7D8 RID: 51160 RVA: 0x000966BD File Offset: 0x000948BD
	public override void LoadProgress()
	{
		base.LoadProgress();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(base.PHPLKBPIMIH() + ".completedCount", 0, null);
		base.GoalProgress = this.CAOJDEFHMAG();
	}

	// Token: 0x0600C7D9 RID: 51161 RVA: 0x000966F3 File Offset: 0x000948F3
	public virtual void IOFDCAIPEGA()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.ICCPGBPICFP));
		base.OnCompleted();
	}

	// Token: 0x0600C7DA RID: 51162 RVA: 0x00096711 File Offset: 0x00094911
	public virtual void CPGAFFIOGCH()
	{
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE(base.ADHHBPHLCJO() + "player.blackwhite", null);
		base.CJPIGOKLKOA();
	}

	// Token: 0x0600C7DB RID: 51163 RVA: 0x004731F8 File Offset: 0x004713F8
	private void KCNNFCFHAHI(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.PPEBDMBKOBD());
		if (Singleton<LuaEnvironment>.Instance.GAFCMDALGPH(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.GoalProgress = this.GICDHIHBFHI();
		}
	}

	// Token: 0x0600C7DC RID: 51164 RVA: 0x00096734 File Offset: 0x00094934
	public virtual void LHIBPEGLPHM()
	{
		Singleton<SaveSystem>.Instance.AGDCACJJAMG(base.JLGGLIMFAFJ() + "0.00", null);
		base.COABGLMKACM();
	}

	// Token: 0x0600C7DD RID: 51165 RVA: 0x00096757 File Offset: 0x00094957
	public virtual void AFMPCOFDHJI()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.ANGLIEAGDOA));
		base.IOIAOIMIIMA();
	}

	// Token: 0x0600C7DE RID: 51166 RVA: 0x00473244 File Offset: 0x00471444
	public virtual void KGGEDALAKDA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.GKCOBIILKMA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = (char)-92;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("Delete events", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.BOOHNLOCBDK));
		Singleton<GameManager>.Instance.PLHPCLABBIA(new GameManager.PlayerGameEvent(this.IPGKJJJPLOL));
		this.LoadProgress();
	}

	// Token: 0x0600C7DF RID: 51167 RVA: 0x00096775 File Offset: 0x00094975
	public override void KBJAAOIAPCC()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.FIBINEJFAHF));
		base.JNLJADDKPAI();
	}

	// Token: 0x0600C7E0 RID: 51168 RVA: 0x004732D8 File Offset: 0x004714D8
	public virtual void FJMBAIAJIOC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			'\n'
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("CameraFilterPack/Blend2Camera_Overlay", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.ANGLIEAGDOA));
		Singleton<GameManager>.Instance.OnGameEvent += this.KJKPJNECCAA;
		this.HBLGNPFJGBF();
	}

	// Token: 0x0600C7E1 RID: 51169 RVA: 0x00096793 File Offset: 0x00094993
	public virtual void PGPMPNANPLM()
	{
		base.AGCKLPAKDAK();
		Singleton<SaveSystem>.Instance.SetInt(base.IKLKPAJBHGB() + "speed", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7E2 RID: 51170 RVA: 0x000967BC File Offset: 0x000949BC
	public virtual void KLBGGKHNLDD()
	{
		base.PPPFKGOCMLO();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(base.KOHBJKHPDGK() + "\" that takes ", 1, null);
		base.AHMNICEJLMF(this.CAOJDEFHMAG());
	}

	// Token: 0x0600C7E3 RID: 51171 RVA: 0x0047336C File Offset: 0x0047156C
	private void NNFFNFNKFOF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.NILOPHNEAIC(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.JKINKBKCGFP(this.CDCIEIOFABB());
		}
	}

	// Token: 0x0600C7E4 RID: 51172 RVA: 0x004733B8 File Offset: 0x004715B8
	public virtual void ILOBNHKDGPG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.MOOFNOAOAMF(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = ',';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("Received RPC \"", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.KCNNFCFHAHI));
		Singleton<GameManager>.Instance.OnGameEvent += this.IPGKJJJPLOL;
		this.EMDHDEGLPPF();
	}

	// Token: 0x0600C7E5 RID: 51173 RVA: 0x000967F2 File Offset: 0x000949F2
	public virtual void OGKGIAAACAD()
	{
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM(base.DNEPKKKEBEA() + "Other", null);
		base.HIGJLKBIEOK();
	}

	// Token: 0x0600C7E6 RID: 51174 RVA: 0x0047344C File Offset: 0x0047164C
	private void FIBINEJFAHF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.NHENNCOILPG(this.CEKIBLKIKEF());
		}
	}

	// Token: 0x0600C7E7 RID: 51175 RVA: 0x00473498 File Offset: 0x00471698
	private void IPGKJJJPLOL(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.DDGJFHBJMPK());
		if (Singleton<LuaEnvironment>.Instance.ENBEECGHGLO(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.NHENNCOILPG(this.LNACNNOIHMB());
		}
	}

	// Token: 0x0600C7E8 RID: 51176 RVA: 0x004734E4 File Offset: 0x004716E4
	public override void MOOFNOAOAMF(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NOFLEDOPHMO(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			(char)-111
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("GlassColor", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.KCNNFCFHAHI));
		Singleton<GameManager>.Instance.PLHPCLABBIA(new GameManager.PlayerGameEvent(this.IPGKJJJPLOL));
		this.HEPLJACPKFO();
	}

	// Token: 0x0600C7E9 RID: 51177 RVA: 0x00096815 File Offset: 0x00094A15
	public virtual void GENNDFFJJNH()
	{
		base.HEPLJACPKFO();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(base.PHPLKBPIMIH() + "ScreenResolutionPanel", 1, null);
		base.GoalProgress = this.CEKIBLKIKEF();
	}

	// Token: 0x0600C7EA RID: 51178 RVA: 0x0009646D File Offset: 0x0009466D
	private float GICDHIHBFHI()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C7EB RID: 51179 RVA: 0x0009684B File Offset: 0x00094A4B
	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetInt(base.PHPLKBPIMIH() + ".completedCount", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7EC RID: 51180 RVA: 0x00096874 File Offset: 0x00094A74
	public virtual void ADNFLLEGHGH()
	{
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.ICCPGBPICFP));
		base.OnCompleted();
	}

	// Token: 0x0600C7ED RID: 51181 RVA: 0x00096892 File Offset: 0x00094A92
	public virtual void GMPAPODODHM()
	{
		base.LoadProgress();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(base.PHPLKBPIMIH() + "PointsScoreText", 0, null);
		base.NHENNCOILPG(this.MBKDOOBIJJJ());
	}

	// Token: 0x0600C7EE RID: 51182 RVA: 0x000968C8 File Offset: 0x00094AC8
	public virtual void KOBJAEPJJJM()
	{
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM(base.IKLKPAJBHGB() + "SetSatelliteRotationSpeed", null);
		base.LAACNNJDKBI();
	}

	// Token: 0x0600C7EF RID: 51183 RVA: 0x000968EB File Offset: 0x00094AEB
	public virtual void LEPCANPAJFA()
	{
		base.HEPLJACPKFO();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(base.FJFFJLBABDI() + "ready", 0, null);
		base.NHENNCOILPG(this.GICDHIHBFHI());
	}

	// Token: 0x0600C7F0 RID: 51184 RVA: 0x00473578 File Offset: 0x00471778
	private void BOOHNLOCBDK(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.PPEBDMBKOBD());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.AHMNICEJLMF(this.MBKDOOBIJJJ());
		}
	}

	// Token: 0x0600C7F1 RID: 51185 RVA: 0x00096921 File Offset: 0x00094B21
	public virtual void FPMFLNFMDLN()
	{
		base.KANOEJEJAJN();
		Singleton<SaveSystem>.Instance.SetInt(base.KOHBJKHPDGK() + "_Value4", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7F2 RID: 51186 RVA: 0x004735C4 File Offset: 0x004717C4
	public virtual void FHFEHPCEMGI(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KJJMJJJEGDB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '5';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("_VelocityScale", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(new GameManager.PlayerGameEvent(this.NNFFNFNKFOF));
		Singleton<GameManager>.Instance.PLHPCLABBIA(new GameManager.PlayerGameEvent(this.KCNNFCFHAHI));
		this.EMDHDEGLPPF();
	}

	// Token: 0x0600C7F3 RID: 51187 RVA: 0x00473658 File Offset: 0x00471858
	private void AJNMBKABIMO(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.ENBEECGHGLO(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.BNPNMCFLDNI(this.GICDHIHBFHI());
		}
	}

	// Token: 0x0600C7F4 RID: 51188 RVA: 0x0009694A File Offset: 0x00094B4A
	public virtual void PCPDMGPGMEF()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.KJKPJNECCAA));
		base.KLEMLMOPEFE();
	}

	// Token: 0x0600C7F5 RID: 51189 RVA: 0x004736A4 File Offset: 0x004718A4
	private void ICCPGBPICFP(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EDIJMIINAGB());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.GoalProgress = this.CDCIEIOFABB();
		}
	}

	// Token: 0x0600C7F6 RID: 51190 RVA: 0x004736F0 File Offset: 0x004718F0
	public virtual void FHPDJMHPLJA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'f';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_Value4", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.OnGameEvent -= this.AJNMBKABIMO;
		Singleton<GameManager>.Instance.OnGameEvent += this.NLPFNLACBHB;
		this.PPPFKGOCMLO();
	}

	// Token: 0x0600C7F7 RID: 51191 RVA: 0x00096968 File Offset: 0x00094B68
	public virtual void DNNEPKGGCAO()
	{
		base.PPPFKGOCMLO();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(base.BGOBKCLKJMD() + "_Visualize", 1, null);
		base.AHMNICEJLMF(this.OKMLICIEMEG());
	}

	// Token: 0x0600C7F8 RID: 51192 RVA: 0x0009699E File Offset: 0x00094B9E
	public virtual void NNFMEADJLLM()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(new GameManager.PlayerGameEvent(this.OKLHDAEHLKC));
		base.OnCompleted();
	}

	// Token: 0x0600C7F9 RID: 51193 RVA: 0x000969BC File Offset: 0x00094BBC
	public virtual void OKFNEFJMLJI()
	{
		base.FLEONCKOLNB();
		Singleton<SaveSystem>.Instance.GBFBKFACPBI(base.PHPLKBPIMIH() + "Pop", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C7FA RID: 51194 RVA: 0x000969E5 File Offset: 0x00094BE5
	public override void Reset()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.PHPLKBPIMIH() + ".completedCount", null);
		base.Reset();
	}

	// Token: 0x0400174A RID: 5962
	private int MHLPNLMDILP;

	// Token: 0x0400174B RID: 5963
	private string CBMKNPLELGP = "true";

	// Token: 0x0400174C RID: 5964
	private int HGMKPHILBMM;
}
