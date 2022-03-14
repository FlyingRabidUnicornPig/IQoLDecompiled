/*
Importance of this class: Not used currently but important.

Purpose of this class: I believe this is the general Challenge manager/handler.

Deobf status: Lots of junk, lot's obf'd pretty bad shape.
*/

using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000383 RID: 899
public class Challenge
{
	// Token: 0x1700030D RID: 781
	// (get) Token: 0x0600C835 RID: 51253 RVA: 0x00096A55 File Offset: 0x00094C55
	// (set) Token: 0x0600C7FB RID: 51195 RVA: 0x00096A08 File Offset: 0x00094C08
	public ulong id { get; set; }

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x0600C82C RID: 51244 RVA: 0x00096A45 File Offset: 0x00094C45
	// (set) Token: 0x0600C7FC RID: 51196 RVA: 0x00096A11 File Offset: 0x00094C11
	public Challenge.CurrentStatus PlayerStatus
	{
		get
		{
			return this.IEKFDAJHBCN;
		}
		set
		{
			this.IEKFDAJHBCN = value;
			Singleton<SaveSystem>.Instance.SetInt("challenges." + this.id + ".status", (int)this.IEKFDAJHBCN, null);
		}
	}

	// Token: 0x0600C7FD RID: 51197 RVA: 0x00096A45 File Offset: 0x00094C45
	public Challenge.CurrentStatus EFOKGOMPFIO()
	{
		return this.IEKFDAJHBCN;
	}

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x00096A4D File Offset: 0x00094C4D
	// (set) Token: 0x0600C847 RID: 51271 RVA: 0x00096AC4 File Offset: 0x00094CC4
	public string info { get; set; }

	// Token: 0x0600C7FF RID: 51199 RVA: 0x00096A55 File Offset: 0x00094C55
	public ulong ENDOGIJIIMN()
	{
		return this.<EACCOCFNPIG>k__BackingField;
	}

	// Token: 0x0600C800 RID: 51200 RVA: 0x00096A5D File Offset: 0x00094C5D
	public void CFJAADKGIBI(List<string> DPNHODJHGJL)
	{
		this.<LDFMMDOEKMN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x0600C801 RID: 51201 RVA: 0x00096A66 File Offset: 0x00094C66
	// (set) Token: 0x0600C81C RID: 51228 RVA: 0x00096B1D File Offset: 0x00094D1D
	public string startDateTime { get; set; }

	// Token: 0x0600C802 RID: 51202 RVA: 0x00096A6E File Offset: 0x00094C6E
	public void JCGPDAHKPPI(string DPNHODJHGJL)
	{
		this.<JPABICKLLEP>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C803 RID: 51203 RVA: 0x00096A45 File Offset: 0x00094C45
	public Challenge.CurrentStatus BBLDABFGDFF()
	{
		return this.IEKFDAJHBCN;
	}

	// Token: 0x0600C804 RID: 51204 RVA: 0x00096A77 File Offset: 0x00094C77
	public string GJONOJPJGAO()
	{
		return this.<ALHGHAEJDNC>k__BackingField;
	}

	// Token: 0x0600C805 RID: 51205 RVA: 0x0047381C File Offset: 0x00471A1C
	public float KCMBMLFLEOK()
	{
		if (this.HCPDNILLJEJ() == Challenge.CurrentStatus.NotStarted)
		{
			return 1145f;
		}
		if (this.JNEKHPIOHIK() > Challenge.CurrentStatus.NotStarted)
		{
			return 1199f;
		}
		if (this.EGPOPHEAAAF.Count > 1)
		{
			float num = 139f;
			foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
			{
				num += challengeGoal.FBEFEPECHBM();
			}
			return num / (float)this.EGPOPHEAAAF.Count;
		}
		return 1490f;
	}

	// Token: 0x0600C806 RID: 51206 RVA: 0x00096A77 File Offset: 0x00094C77
	public string CGDEMHHGAON()
	{
		return this.<ALHGHAEJDNC>k__BackingField;
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x0600C84F RID: 51279 RVA: 0x00096B2F File Offset: 0x00094D2F
	// (set) Token: 0x0600C807 RID: 51207 RVA: 0x00096A7F File Offset: 0x00094C7F
	public string icon { get; set; }

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x0600C808 RID: 51208 RVA: 0x00096A77 File Offset: 0x00094C77
	// (set) Token: 0x0600C820 RID: 51232 RVA: 0x00096B26 File Offset: 0x00094D26
	public string reward { get; set; }

	// Token: 0x0600C809 RID: 51209 RVA: 0x00096A88 File Offset: 0x00094C88
	public string LACOFOPCNBG()
	{
		return this.<DIABBLCFCKJ>k__BackingField;
	}

	// Token: 0x0600C80A RID: 51210 RVA: 0x00096A55 File Offset: 0x00094C55
	public ulong OFGNFACIGIL()
	{
		return this.<EACCOCFNPIG>k__BackingField;
	}

	// Token: 0x0600C80B RID: 51211 RVA: 0x00096A66 File Offset: 0x00094C66
	public string MHNLMDPIGLB()
	{
		return this.<IBJENJNAKBB>k__BackingField;
	}

	// Token: 0x0600C80C RID: 51212 RVA: 0x00096A08 File Offset: 0x00094C08
	public void ABNFDKBNAGF(ulong DPNHODJHGJL)
	{
		this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C80D RID: 51213 RVA: 0x004738CC File Offset: 0x00471ACC
	public float GIMMCHBOAPA()
	{
		if (this.PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			return 364f;
		}
		if (this.BBLDABFGDFF() > Challenge.CurrentStatus.NotStarted)
		{
			return 987f;
		}
		if (this.EGPOPHEAAAF.Count > 0)
		{
			float num = 1160f;
			foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
			{
				num += challengeGoal.GoalProgress;
			}
			return num / (float)this.EGPOPHEAAAF.Count;
		}
		return 1101f;
	}

	// Token: 0x0600C80E RID: 51214 RVA: 0x00096A6E File Offset: 0x00094C6E
	public void PIDFBEGCHAD(string DPNHODJHGJL)
	{
		this.<JPABICKLLEP>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C80F RID: 51215 RVA: 0x00096A90 File Offset: 0x00094C90
	public void JNMHFODNBLM(Challenge.CurrentStatus DPNHODJHGJL)
	{
		this.IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("Menu" + this.OFGNFACIGIL() + "PublishButton", (int)this.IEKFDAJHBCN, null);
	}

	// Token: 0x0600C810 RID: 51216 RVA: 0x00096AC4 File Offset: 0x00094CC4
	public void CPIGIHCADCF(string DPNHODJHGJL)
	{
		this.<DPBCOACKKHB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x0600C811 RID: 51217 RVA: 0x00096ACD File Offset: 0x00094CCD
	// (set) Token: 0x0600C852 RID: 51282 RVA: 0x00096A5D File Offset: 0x00094C5D
	public List<string> goalsText { get; set; }

	// Token: 0x0600C812 RID: 51218 RVA: 0x0047397C File Offset: 0x00471B7C
	public void EFKJBLMEPBA(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			this.IJOPEKABIKM((Challenge.CurrentStatus)Singleton<SaveSystem>.Instance.HHBIEPMBICO("_TimeX" + this.id + " beatThreshold: ", 0, null));
		}
		else
		{
			this.JNMHFODNBLM(Challenge.CurrentStatus.InProgress);
		}
		if (this.OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted)
		{
			this.CPMIGJFKCOH();
		}
		if (this.EFOKGOMPFIO() > Challenge.CurrentStatus.NotStarted && this.HCPDNILLJEJ() < (Challenge.CurrentStatus)5)
		{
			Singleton<ChallengesManager>.Instance.CHAJHAOEIKF(this);
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x0600C813 RID: 51219 RVA: 0x00096A88 File Offset: 0x00094C88
	// (set) Token: 0x0600C844 RID: 51268 RVA: 0x00096B3F File Offset: 0x00094D3F
	public string endDateTime { get; set; }

	// Token: 0x0600C814 RID: 51220 RVA: 0x00096AD5 File Offset: 0x00094CD5
	public void DCFPGOMGBFK()
	{
		if (this.ADKFDALFMAE() >= 1909f)
		{
			this.JNMHFODNBLM(Challenge.CurrentStatus.InProgress);
			Singleton<ChallengesManager>.Instance.CHAJHAOEIKF(this);
		}
	}

	// Token: 0x0600C815 RID: 51221 RVA: 0x004739FC File Offset: 0x00471BFC
	public float DCHBAIPFOMK()
	{
		if (this.OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted)
		{
			return 987f;
		}
		if (this.EBJMABMHEEO() > Challenge.CurrentStatus.InProgress)
		{
			return 471f;
		}
		if (this.EGPOPHEAAAF.Count > 1)
		{
			float num = 1996f;
			foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
			{
				num += challengeGoal.GHDFDFBCJNB();
			}
			return num / (float)this.EGPOPHEAAAF.Count;
		}
		return 359f;
	}

	// Token: 0x0600C816 RID: 51222 RVA: 0x00096A7F File Offset: 0x00094C7F
	public void JKHDAIKDKPF(string DPNHODJHGJL)
	{
		this.<EALCJLBAFGO>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C817 RID: 51223 RVA: 0x00473AAC File Offset: 0x00471CAC
	public void AIFAGDOHAGD()
	{
		this.CPMIGJFKCOH();
		foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
		{
			challengeGoal.PIKFPFLKBCG();
			challengeGoal.NKHLPNAMBEH();
		}
		this.JNMHFODNBLM(Challenge.CurrentStatus.InProgress);
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE(": " + this.BGIOHLIFHND() + "CameraFilterPack/TV_Noise", null);
	}

	// Token: 0x0600C818 RID: 51224 RVA: 0x00096A4D File Offset: 0x00094C4D
	public string GPBAIPHOIKN()
	{
		return this.<DPBCOACKKHB>k__BackingField;
	}

	// Token: 0x0600C819 RID: 51225 RVA: 0x00473B40 File Offset: 0x00471D40
	private void PJNGEJMJENJ()
	{
		this.EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string text in this.goalsText)
		{
			try
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = '(';
				string[] array2 = text2.Split(array);
				string a = array2[0];
				List<string> list = array2.ToList<string>();
				list.RemoveAt(1);
				string nojggclppam = string.Join("0", list.ToArray());
				if (a == "Tried to Initialize the SteamAPI twice in one session!")
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					this.EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.HAPELGDNDFN(this.ENDOGIJIIMN(), num, nojggclppam);
				}
				else if (a == "_ScreenResolution")
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					this.EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.LPGHCNKDCKD(this.OFGNFACIGIL(), num, nojggclppam);
				}
				else if (a == "_HrDepthTex")
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					this.EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.NOFLEDOPHMO(this.id, num, nojggclppam);
				}
			}
			catch (Exception ex)
			{
			}
			num++;
		}
	}

	// Token: 0x0600C81A RID: 51226 RVA: 0x00096ACD File Offset: 0x00094CCD
	public List<string> PNOFLPNCLEK()
	{
		return this.<LDFMMDOEKMN>k__BackingField;
	}

	// Token: 0x0600C81B RID: 51227 RVA: 0x00096AF9 File Offset: 0x00094CF9
	public void CheckState()
	{
		if (this.GetProgress() >= 1f)
		{
			this.PlayerStatus = Challenge.CurrentStatus.Complete;
			Singleton<ChallengesManager>.Instance.CompleteChallenge(this);
		}
	}

	// Token: 0x0600C81E RID: 51230 RVA: 0x00096A45 File Offset: 0x00094C45
	public Challenge.CurrentStatus EBJMABMHEEO()
	{
		return this.IEKFDAJHBCN;
	}

	// Token: 0x0600C81F RID: 51231 RVA: 0x00473CC0 File Offset: 0x00471EC0
	public void AcceptChallenge(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			this.PlayerStatus = (Challenge.CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("challenges." + this.id + ".status", 1, null);
		}
		else
		{
			this.PlayerStatus = Challenge.CurrentStatus.InProgress;
		}
		if (this.PlayerStatus == Challenge.CurrentStatus.InProgress)
		{
			this.MPKMIAKILEH();
		}
		if (this.PlayerStatus > Challenge.CurrentStatus.InProgress && this.PlayerStatus < Challenge.CurrentStatus.ObtainedReward)
		{
			Singleton<ChallengesManager>.Instance.CompleteChallenge(this);
		}
	}

	// Token: 0x0600C821 RID: 51233 RVA: 0x00096A45 File Offset: 0x00094C45
	public Challenge.CurrentStatus HCPDNILLJEJ()
	{
		return this.IEKFDAJHBCN;
	}

	// Token: 0x0600C822 RID: 51234 RVA: 0x00473D40 File Offset: 0x00471F40
	public float GetProgress()
	{
		if (this.PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			return 0f;
		}
		if (this.PlayerStatus > Challenge.CurrentStatus.InProgress)
		{
			return 1f;
		}
		if (this.EGPOPHEAAAF.Count > 0)
		{
			float num = 0f;
			foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
			{
				num += challengeGoal.GoalProgress;
			}
			return num / (float)this.EGPOPHEAAAF.Count;
		}
		return 0f;
	}

	// Token: 0x0600C823 RID: 51235 RVA: 0x00096A5D File Offset: 0x00094C5D
	public void LOMAELCENDL(List<string> DPNHODJHGJL)
	{
		this.<LDFMMDOEKMN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C824 RID: 51236 RVA: 0x00473DF0 File Offset: 0x00471FF0
	public void OINNDMKBIAF(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			this.JNMHFODNBLM((Challenge.CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("resetach21" + this.OFGNFACIGIL() + "_ForegroundBlurExtrude", 1, null));
		}
		else
		{
			this.IJOPEKABIKM(Challenge.CurrentStatus.InProgress);
		}
		if (this.JNEKHPIOHIK() == Challenge.CurrentStatus.InProgress)
		{
			this.PJNGEJMJENJ();
		}
		if (this.EBJMABMHEEO() > Challenge.CurrentStatus.InProgress && this.BBLDABFGDFF() < (Challenge.CurrentStatus)8)
		{
			Singleton<ChallengesManager>.Instance.JEALJMLENKL(this);
		}
	}

	// Token: 0x0600C825 RID: 51237 RVA: 0x00096B2F File Offset: 0x00094D2F
	public string FCMFHKDBPJP()
	{
		return this.<EALCJLBAFGO>k__BackingField;
	}

	// Token: 0x0600C826 RID: 51238 RVA: 0x00096ACD File Offset: 0x00094CCD
	public List<string> EIENOHKPFCM()
	{
		return this.<LDFMMDOEKMN>k__BackingField;
	}

	// Token: 0x0600C827 RID: 51239 RVA: 0x00096A5D File Offset: 0x00094C5D
	public void JDIFAKFPODF(List<string> DPNHODJHGJL)
	{
		this.<LDFMMDOEKMN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C828 RID: 51240 RVA: 0x00473E70 File Offset: 0x00472070
	private void MCNJPECILKM()
	{
		this.EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string text in this.goalsText)
		{
			try
			{
				string[] array = text.Split(new char[]
				{
					'Y'
				});
				string a = array[1];
				List<string> list = array.ToList<string>();
				list.RemoveAt(0);
				string nojggclppam = string.Join("DPADVER", list.ToArray());
				if (a == "player.greenlifering")
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					this.EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.HAPELGDNDFN(this.BGIOHLIFHND(), num, nojggclppam);
				}
				else if (a == "FToA")
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					this.EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.KHMFEHEPGAM(this.BGIOHLIFHND(), num, nojggclppam);
				}
				else if (a == "_Value2")
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					this.EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.OnAccept(this.ENDOGIJIIMN(), num, nojggclppam);
				}
			}
			catch (Exception ex)
			{
			}
			num++;
		}
	}

	// Token: 0x0600C829 RID: 51241 RVA: 0x00096B26 File Offset: 0x00094D26
	public void BIGCNPCIENO(string DPNHODJHGJL)
	{
		this.<ALHGHAEJDNC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C82A RID: 51242 RVA: 0x00096A6E File Offset: 0x00094C6E
	public void LHNMNKCPPKO(string DPNHODJHGJL)
	{
		this.<JPABICKLLEP>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C82B RID: 51243 RVA: 0x00473FF0 File Offset: 0x004721F0
	public float HNPOFLFPCPI()
	{
		if (this.PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			return 1443f;
		}
		if (this.EFOKGOMPFIO() > Challenge.CurrentStatus.NotStarted)
		{
			return 777f;
		}
		if (this.EGPOPHEAAAF.Count > 1)
		{
			float num = 1605f;
			foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
			{
				num += challengeGoal.KMBFINBONIB();
			}
			return num / (float)this.EGPOPHEAAAF.Count;
		}
		return 572f;
	}

	// Token: 0x0600C82D RID: 51245 RVA: 0x00096A45 File Offset: 0x00094C45
	public Challenge.CurrentStatus JNEKHPIOHIK()
	{
		return this.IEKFDAJHBCN;
	}

	// Token: 0x0600C82E RID: 51246 RVA: 0x00096A4D File Offset: 0x00094C4D
	public string HCEHDFKNGKB()
	{
		return this.<DPBCOACKKHB>k__BackingField;
	}

	// Token: 0x0600C82F RID: 51247 RVA: 0x00096A88 File Offset: 0x00094C88
	public string GGKDIJKNMHL()
	{
		return this.<DIABBLCFCKJ>k__BackingField;
	}

	// Token: 0x0600C830 RID: 51248 RVA: 0x004740A0 File Offset: 0x004722A0
	public void AFAJGOKBOBE(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			this.PlayerStatus = (Challenge.CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("_SpawnHeuristic" + this.id + "CameraFilterPack/Blur_Focus", 1, null);
		}
		else
		{
			this.PlayerStatus = Challenge.CurrentStatus.InProgress;
		}
		if (this.BBLDABFGDFF() == Challenge.CurrentStatus.NotStarted)
		{
			this.CPMIGJFKCOH();
		}
		if (this.BBLDABFGDFF() > Challenge.CurrentStatus.InProgress && this.HCPDNILLJEJ() < (Challenge.CurrentStatus)7)
		{
			Singleton<ChallengesManager>.Instance.JEALJMLENKL(this);
		}
	}

	// Token: 0x0600C831 RID: 51249 RVA: 0x00474120 File Offset: 0x00472320
	public void Reset()
	{
		this.MPKMIAKILEH();
		foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
		{
			challengeGoal.OnCompleted();
			challengeGoal.Reset();
		}
		this.PlayerStatus = Challenge.CurrentStatus.NotStarted;
		Singleton<SaveSystem>.Instance.DeleteKey("challenges." + this.id + ".status", null);
	}

	// Token: 0x0600C832 RID: 51250 RVA: 0x00096A5D File Offset: 0x00094C5D
	public void HIGFEGHGFHD(List<string> DPNHODJHGJL)
	{
		this.<LDFMMDOEKMN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C833 RID: 51251 RVA: 0x00096B26 File Offset: 0x00094D26
	public void IKBJJGLBENN(string DPNHODJHGJL)
	{
		this.<ALHGHAEJDNC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C834 RID: 51252 RVA: 0x00096A6E File Offset: 0x00094C6E
	public void FAFJKOFLFOJ(string DPNHODJHGJL)
	{
		this.<JPABICKLLEP>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x0600C836 RID: 51254 RVA: 0x00096B37 File Offset: 0x00094D37
	// (set) Token: 0x0600C83A RID: 51258 RVA: 0x00096A6E File Offset: 0x00094C6E
	public string unlockCondition { get; set; }

	// Token: 0x0600C837 RID: 51255 RVA: 0x00096A88 File Offset: 0x00094C88
	public string BDKJGGONHEL()
	{
		return this.<DIABBLCFCKJ>k__BackingField;
	}

	// Token: 0x0600C838 RID: 51256 RVA: 0x004741B4 File Offset: 0x004723B4
	public void NNIMFGIDOKG(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			this.JNMHFODNBLM((Challenge.CurrentStatus)Singleton<SaveSystem>.Instance.HHBIEPMBICO("shader.frost" + this.id + "LoadingStatusText", 1, null));
		}
		else
		{
			this.IJOPEKABIKM(Challenge.CurrentStatus.InProgress);
		}
		if (this.BBLDABFGDFF() == Challenge.CurrentStatus.NotStarted)
		{
			this.MCNJPECILKM();
		}
		if (this.PlayerStatus > Challenge.CurrentStatus.InProgress && this.HCPDNILLJEJ() < (Challenge.CurrentStatus)4)
		{
			Singleton<ChallengesManager>.Instance.CompleteChallenge(this);
		}
	}

	// Token: 0x0600C839 RID: 51257 RVA: 0x00096A66 File Offset: 0x00094C66
	public string DNCDAFPLBIA()
	{
		return this.<IBJENJNAKBB>k__BackingField;
	}

	// Token: 0x0600C83B RID: 51259 RVA: 0x00096A6E File Offset: 0x00094C6E
	public void DPENCHIOHFM(string DPNHODJHGJL)
	{
		this.<JPABICKLLEP>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C83C RID: 51260 RVA: 0x00096A66 File Offset: 0x00094C66
	public string GBJMBBBHCKI()
	{
		return this.<IBJENJNAKBB>k__BackingField;
	}

	// Token: 0x0600C83D RID: 51261 RVA: 0x00096B3F File Offset: 0x00094D3F
	public void PLALGEEPHON(string DPNHODJHGJL)
	{
		this.<DIABBLCFCKJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C83E RID: 51262 RVA: 0x00096AC4 File Offset: 0x00094CC4
	public void NCBCMDNDNLO(string DPNHODJHGJL)
	{
		this.<DPBCOACKKHB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C83F RID: 51263 RVA: 0x00096B3F File Offset: 0x00094D3F
	public void DGOLCHFJDAB(string DPNHODJHGJL)
	{
		this.<DIABBLCFCKJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C840 RID: 51264 RVA: 0x00096A45 File Offset: 0x00094C45
	public Challenge.CurrentStatus OFPNJBGNLDH()
	{
		return this.IEKFDAJHBCN;
	}

	// Token: 0x0600C841 RID: 51265 RVA: 0x00096AC4 File Offset: 0x00094CC4
	public void BIPIDNLLCNA(string DPNHODJHGJL)
	{
		this.<DPBCOACKKHB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C842 RID: 51266 RVA: 0x00096A55 File Offset: 0x00094C55
	public ulong BGIOHLIFHND()
	{
		return this.<EACCOCFNPIG>k__BackingField;
	}

	// Token: 0x0600C843 RID: 51267 RVA: 0x00096A77 File Offset: 0x00094C77
	public string JGNCPNIJLOM()
	{
		return this.<ALHGHAEJDNC>k__BackingField;
	}

	// Token: 0x0600C845 RID: 51269 RVA: 0x00474234 File Offset: 0x00472434
	public float ADKFDALFMAE()
	{
		if (this.JNEKHPIOHIK() == Challenge.CurrentStatus.NotStarted)
		{
			return 746f;
		}
		if (this.PlayerStatus > Challenge.CurrentStatus.InProgress)
		{
			return 1379f;
		}
		if (this.EGPOPHEAAAF.Count > 1)
		{
			float num = 1797f;
			foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
			{
				num += challengeGoal.CLLOGPOMPGE();
			}
			return num / (float)this.EGPOPHEAAAF.Count;
		}
		return 922f;
	}

	// Token: 0x0600C846 RID: 51270 RVA: 0x004742E4 File Offset: 0x004724E4
	private void MPKMIAKILEH()
	{
		this.EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string text in this.goalsText)
		{
			try
			{
				string[] array = text.Split(new char[]
				{
					','
				});
				string a = array[0];
				List<string> list = array.ToList<string>();
				list.RemoveAt(0);
				string nojggclppam = string.Join(",", list.ToArray());
				if (a == "PlayMapGoal")
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					this.EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.OnAccept(this.id, num, nojggclppam);
				}
				else if (a == "PlayMapsSeriesGoal")
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					this.EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.OnAccept(this.id, num, nojggclppam);
				}
				else if (a == "CountEventsGoal")
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					this.EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.OnAccept(this.id, num, nojggclppam);
				}
			}
			catch (Exception ex)
			{
			}
			num++;
		}
	}

	// Token: 0x0600C848 RID: 51272 RVA: 0x00096A88 File Offset: 0x00094C88
	public string BAMLANAIFEO()
	{
		return this.<DIABBLCFCKJ>k__BackingField;
	}

	// Token: 0x0600C849 RID: 51273 RVA: 0x00474464 File Offset: 0x00472664
	private void CPMIGJFKCOH()
	{
		this.EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 1;
		foreach (string text in this.PNOFLPNCLEK())
		{
			try
			{
				string text2 = text;
				char[] array = new char[1];
				array[1] = (char)-15;
				string[] array2 = text2.Split(array);
				string a = array2[0];
				List<string> list = array2.ToList<string>();
				list.RemoveAt(1);
				string nojggclppam = string.Join("CameraFilterPack_Glasses_On2", list.ToArray());
				if (a == "menu.tabid")
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					this.EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.MOOFNOAOAMF(this.OFGNFACIGIL(), num, nojggclppam);
				}
				else if (a == "_Value")
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					this.EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.KJJMJJJEGDB(this.OFGNFACIGIL(), num, nojggclppam);
				}
				else if (a == "init")
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					this.EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.KJJMJJJEGDB(this.OFGNFACIGIL(), num, nojggclppam);
				}
			}
			catch (Exception ex)
			{
			}
			num++;
		}
	}

	// Token: 0x0600C84A RID: 51274 RVA: 0x00096B37 File Offset: 0x00094D37
	public string CCCHEABDHMH()
	{
		return this.<JPABICKLLEP>k__BackingField;
	}

	// Token: 0x0600C84B RID: 51275 RVA: 0x00096A7F File Offset: 0x00094C7F
	public void IBEEDNMCPFL(string DPNHODJHGJL)
	{
		this.<EALCJLBAFGO>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C84C RID: 51276 RVA: 0x00096A77 File Offset: 0x00094C77
	public string KJOKBLAMHLN()
	{
		return this.<ALHGHAEJDNC>k__BackingField;
	}

	// Token: 0x0600C84D RID: 51277 RVA: 0x00096B26 File Offset: 0x00094D26
	public void ALMELFBHKOP(string DPNHODJHGJL)
	{
		this.<ALHGHAEJDNC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C84E RID: 51278 RVA: 0x00096B48 File Offset: 0x00094D48
	public void IJOPEKABIKM(Challenge.CurrentStatus DPNHODJHGJL)
	{
		this.IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.SetInt("quit" + this.BGIOHLIFHND() + "Set Particles Speed", (int)this.IEKFDAJHBCN, null);
	}

	// Token: 0x0600C850 RID: 51280 RVA: 0x00096B26 File Offset: 0x00094D26
	public void EFNOJHOHFGB(string DPNHODJHGJL)
	{
		this.<ALHGHAEJDNC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600C851 RID: 51281 RVA: 0x004745E4 File Offset: 0x004727E4
	public void JAIMCPINONG()
	{
		this.PJNGEJMJENJ();
		foreach (ChallengeGoal challengeGoal in this.EGPOPHEAAAF)
		{
			challengeGoal.PIKFPFLKBCG();
			challengeGoal.LAACNNJDKBI();
		}
		this.PlayerStatus = Challenge.CurrentStatus.NotStarted;
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("mapselector.filter.favoriteonly" + this.ENDOGIJIIMN() + "Operation failed: ", null);
	}

	// Token: 0x0600C853 RID: 51283 RVA: 0x00096A5D File Offset: 0x00094C5D
	public void GNJIKFDDEPG(List<string> DPNHODJHGJL)
	{
		this.<LDFMMDOEKMN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x04001755 RID: 5973
	private List<ChallengeGoal> EGPOPHEAAAF;

	// Token: 0x04001756 RID: 5974
	private Challenge.CurrentStatus IEKFDAJHBCN;

	// Token: 0x02000384 RID: 900
	public enum CurrentStatus
	{
		// Token: 0x04001758 RID: 5976
		NotStarted,
		// Token: 0x04001759 RID: 5977
		InProgress,
		// Token: 0x0400175A RID: 5978
		Complete,
		// Token: 0x0400175B RID: 5979
		ObtainedReward
	}
}
