/*
Importance of this class: Important to Challenges.

Purpose of this class: More specific challenge manager? ehh

Deobf status: L
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

// Token: 0x02000385 RID: 901
public class ChallengesManager : Singleton<ChallengesManager>
{
	// Token: 0x0600C854 RID: 51284 RVA: 0x00096B7C File Offset: 0x00094D7C
	public void OFCPEKECFMC(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.NNIMFGIDOKG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.DINKBGAFKAH() == "BadgeText")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C855 RID: 51285 RVA: 0x00474678 File Offset: 0x00472878
	public void LIOPPCKCLDE()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.ShowMessage(this.GetChallengeByID(jmmilefmacb), "CameraFilterPack/Blend2Camera_ColorKey", this.IKKPBLDLFKH(jmmilefmacb).info));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C856 RID: 51286 RVA: 0x00474704 File Offset: 0x00472904
	public void NHMHNDIMKFE(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("SettingsCanvas" + BFLLKFPPAAB.ENDOGIJIIMN() + "_Green_G", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.SetBool("[UI] " + BFLLKFPPAAB.OFGNFACIGIL() + "UI Extensions/UISoftAdditive", true, null);
		}
	}

	// Token: 0x0600C857 RID: 51287 RVA: 0x00474774 File Offset: 0x00472974
	private void KDDOGHOJBFJ(string[] BDGDDFKKGGA)
	{
		/*
An exception occurred when decompiling this method (0600C857)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ChallengesManager::KDDOGHOJBFJ(System.String[])

 ---> System.Exception: Inconsistent stack size at IL_156
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.<>c__DisplayClass90_0.<AddMethodBody>b__0() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1528
*/;
	}

	// Token: 0x0600C858 RID: 51288 RVA: 0x00096BAD File Offset: 0x00094DAD
	public bool AHPJBCMFFHA()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C859 RID: 51289 RVA: 0x004748EC File Offset: 0x00472AEC
	public Challenge GetChallengeByID(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.GBKBDKHPLKG));
	}

	// Token: 0x0600C85A RID: 51290 RVA: 0x00474924 File Offset: 0x00472B24
	public void KKAHIHFGODN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("[NetworkManager] Connection failed: " + BFLLKFPPAAB.OFGNFACIGIL() + "CameraFilterPack/Blend2Camera_Screen", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.ENDOGIJIIMN());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("Obtain test Item" + BFLLKFPPAAB.OFGNFACIGIL() + "CameraFilterPack/Alien_Vision", true, null);
		}
	}

	// Token: 0x0600C85B RID: 51291 RVA: 0x00474994 File Offset: 0x00472B94
	public void IMPMODGKJPD(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("\n" + BFLLKFPPAAB.BGIOHLIFHND() + "Changed config", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("mapselector.filter.subscribedonly" + BFLLKFPPAAB.OFGNFACIGIL() + "Tab1Content", true, null);
		}
	}

	// Token: 0x0600C85C RID: 51292 RVA: 0x00474A04 File Offset: 0x00472C04
	public void NHCKOOHGIBN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("_Value6" + BFLLKFPPAAB.ENDOGIJIIMN() + "BadgeImage", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.BHLOCFLKPPN("Can't set Room.MaxPlayers to: " + BFLLKFPPAAB.id + "SupportLogger ", true, null);
		}
	}

	// Token: 0x0600C85D RID: 51293 RVA: 0x00096BBD File Offset: 0x00094DBD
	public bool JDOAHMPPCCB()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C85E RID: 51294 RVA: 0x00474A74 File Offset: 0x00472C74
	public void FKMBPEGKILO(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		/*
An exception occurred when decompiling this method (0600C85E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ChallengesManager::FKMBPEGKILO(Challenge,System.Boolean)

 ---> System.Exception: Inconsistent stack size at IL_2A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.<>c__DisplayClass90_0.<AddMethodBody>b__0() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1528
*/;
	}

	// Token: 0x0600C85F RID: 51295 RVA: 0x00474AB0 File Offset: 0x00472CB0
	public void PIHPLADMPHI(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("] to be droppable" + BFLLKFPPAAB.BGIOHLIFHND() + "_Visualize", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.ENDOGIJIIMN());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_DepthLevel" + BFLLKFPPAAB.OFGNFACIGIL() + "ResetButton", false, null);
		}
	}

	// Token: 0x0600C860 RID: 51296 RVA: 0x00474B20 File Offset: 0x00472D20
	public IEnumerator ENEONGMIMAJ(ulong DDFGKDFMPNL)
	{
		ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		byte[] data = wwwform.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		string text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string textBox = "#getrewardfailed: " + unityWebRequest.error;
			string button1Text = "#tryagain";
			UnityAction button1Action = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string button2Text = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(textBox, button1Text, button1Action, button2Text, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string textBox2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string button1Text2 = "#tryagain";
			UnityAction button1Action2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string button2Text2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(textBox2, button1Text2, button1Action2, button2Text2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C861 RID: 51297 RVA: 0x00096BBD File Offset: 0x00094DBD
	public bool HasProgress()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C862 RID: 51298 RVA: 0x00096BCD File Offset: 0x00094DCD
	public void EOGLBNCHOIO(ulong CENMLCAACBF)
	{
		if (this.IKKPBLDLFKH(CENMLCAACBF).OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted)
		{
			base.StartCoroutine(this.PLNGNEDBKJL(CENMLCAACBF));
		}
	}

	// Token: 0x0600C863 RID: 51299 RVA: 0x00096BEF File Offset: 0x00094DEF
	public void BIKHHEKODCK(ulong CENMLCAACBF)
	{
		if (this.GetChallengeByID(CENMLCAACBF).EFOKGOMPFIO() == Challenge.CurrentStatus.InProgress)
		{
			base.StartCoroutine(this.PLNGNEDBKJL(CENMLCAACBF));
		}
	}

	// Token: 0x0600C864 RID: 51300 RVA: 0x00474B44 File Offset: 0x00472D44
	public long ToUnixTimeSeconds(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	// Token: 0x0600C865 RID: 51301 RVA: 0x00474B70 File Offset: 0x00472D70
	public void KPFKCDIFHKG(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("masterSteamID" + BFLLKFPPAAB.id + "_TapLowForeground", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("mapselector.filter.rateduponly" + BFLLKFPPAAB.ENDOGIJIIMN() + "_Extra2", true, null);
		}
	}

	// Token: 0x0600C866 RID: 51302 RVA: 0x00474BE0 File Offset: 0x00472DE0
	public void PMBBDPNMGHK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		/*
An exception occurred when decompiling this method (0600C866)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ChallengesManager::PMBBDPNMGHK(Challenge,System.Boolean)

 ---> System.Exception: Inconsistent stack size at IL_2A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.<>c__DisplayClass90_0.<AddMethodBody>b__0() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1528
*/;
	}

	// Token: 0x0600C867 RID: 51303 RVA: 0x00474C1C File Offset: 0x00472E1C
	public void DKEIOCOHFFB(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("Joystick1Button11" + BFLLKFPPAAB.OFGNFACIGIL() + "UI/Particles/Hidden", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("Operation " + BFLLKFPPAAB.OFGNFACIGIL() + "_ScreenResolution", false, null);
		}
	}

	// Token: 0x0600C868 RID: 51304 RVA: 0x00474C8C File Offset: 0x00472E8C
	private void FINNJIMFAPB(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 2)
		{
			Debug.LogError("Please specify a map name or buildID");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 0UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[1], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.GBKBDKHPLKG));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("Working commands:\nreset <challengeid>\nresetall");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 2)
		{
			if (lmibfckloaf.BDGDDFKKGGA[1] == "resetall")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.Reset();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[1] == "reset")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for reset! Use \"reset <challengeid>\"");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.HMMBBDJNGGL)).Reset();
			}
		}
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C869 RID: 51305 RVA: 0x00474E04 File Offset: 0x00473004
	public Challenge IKKPBLDLFKH(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BKNHHGBPLGH));
	}

	// Token: 0x0600C86A RID: 51306 RVA: 0x00474E3C File Offset: 0x0047303C
	public void MACGEHPMGCA()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.IJFDCPFAPBP(this.JIPIKLINJOF(jmmilefmacb), "CameraFilterPack/Retro_Loading", this.IKKPBLDLFKH(jmmilefmacb).GPBAIPHOIKN()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C86B RID: 51307 RVA: 0x00474EC8 File Offset: 0x004730C8
	public void Init(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.AddCommand("challenges", new DebugCommands.DebugCommand(this.FINNJIMFAPB), "Commands for challenges", "<command>", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(3.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.startDateTime, CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.endDateTime, CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey("challenges." + challenge.id + ".status", null) && t >= t2 && t <= t3)
			{
				this.AcceptChallenge(challenge, false);
			}
		}
	}

	// Token: 0x0600C86C RID: 51308 RVA: 0x00474FE8 File Offset: 0x004731E8
	private void NFKKELPADIB(string[] BDGDDFKKGGA)
	{
		/*
An exception occurred when decompiling this method (0600C86C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ChallengesManager::NFKKELPADIB(System.String[])

 ---> System.Exception: Inconsistent stack size at IL_156
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.<>c__DisplayClass90_0.<AddMethodBody>b__0() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1528
*/;
	}

	// Token: 0x0600C86D RID: 51309 RVA: 0x00096C11 File Offset: 0x00094E11
	public void OCOJEBKMIEJ(ulong CENMLCAACBF)
	{
		if (this.JIPIKLINJOF(CENMLCAACBF).PlayerStatus == Challenge.CurrentStatus.InProgress)
		{
			base.StartCoroutine(this.GetReward(CENMLCAACBF));
		}
	}

	// Token: 0x0600C86E RID: 51310 RVA: 0x00096BAD File Offset: 0x00094DAD
	public bool LFGEKLNBDAD()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C86F RID: 51311 RVA: 0x00475160 File Offset: 0x00473360
	public void JEALJMLENKL(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("_ScreenResolution" + BFLLKFPPAAB.id + "CameraFilterPack/BlurTiltShift", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("CameraFilterPack/Blend2Camera_Lighten" + BFLLKFPPAAB.BGIOHLIFHND() + "_Value2", true, null);
		}
	}

	// Token: 0x0600C870 RID: 51312 RVA: 0x004751D0 File Offset: 0x004733D0
	public void IJNDNNGHOCM(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("0.00" + BFLLKFPPAAB.ENDOGIJIIMN() + "/", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("_Amount" + BFLLKFPPAAB.ENDOGIJIIMN() + "_PosX", false, null);
		}
	}

	// Token: 0x0600C871 RID: 51313 RVA: 0x00474B20 File Offset: 0x00472D20
	public IEnumerator PLNGNEDBKJL(ulong DDFGKDFMPNL)
	{
		ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		byte[] data = wwwform.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		string text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string textBox = "#getrewardfailed: " + unityWebRequest.error;
			string button1Text = "#tryagain";
			UnityAction button1Action = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string button2Text = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(textBox, button1Text, button1Action, button2Text, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string textBox2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string button1Text2 = "#tryagain";
			UnityAction button1Action2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string button2Text2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(textBox2, button1Text2, button1Action2, button2Text2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C872 RID: 51314 RVA: 0x00475240 File Offset: 0x00473440
	public void GBENDPNJDHK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		/*
An exception occurred when decompiling this method (0600C872)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ChallengesManager::GBENDPNJDHK(Challenge,System.Boolean)

 ---> System.Exception: Inconsistent stack size at IL_2A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.<>c__DisplayClass90_0.<AddMethodBody>b__0() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1528
*/;
	}

	// Token: 0x0600C873 RID: 51315 RVA: 0x00096C33 File Offset: 0x00094E33
	public void TryGetReward(ulong CENMLCAACBF)
	{
		if (this.GetChallengeByID(CENMLCAACBF).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			base.StartCoroutine(this.GetReward(CENMLCAACBF));
		}
	}

	// Token: 0x0600C874 RID: 51316 RVA: 0x0047527C File Offset: 0x0047347C
	public Challenge JIPIKLINJOF(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.LOEAMHGMMPK));
	}

	// Token: 0x0600C875 RID: 51317 RVA: 0x004752B4 File Offset: 0x004734B4
	public void ONAAJPPJILB(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("00" + BFLLKFPPAAB.id + "_Level", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.BHLOCFLKPPN("ItemNameText" + BFLLKFPPAAB.BGIOHLIFHND() + "&search=", true, null);
		}
	}

	// Token: 0x0600C876 RID: 51318 RVA: 0x00475324 File Offset: 0x00473524
	public void RewardsReadyNotification()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.ShowMessage(this.GetChallengeByID(jmmilefmacb), "#challengecomplete", this.GetChallengeByID(jmmilefmacb).info));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C877 RID: 51319 RVA: 0x00096C55 File Offset: 0x00094E55
	public void KCEHNEPHBPH(ulong CENMLCAACBF)
	{
		if (this.JIPIKLINJOF(CENMLCAACBF).HCPDNILLJEJ() == (Challenge.CurrentStatus)5)
		{
			base.StartCoroutine(this.PLNGNEDBKJL(CENMLCAACBF));
		}
	}

	// Token: 0x0600C878 RID: 51320 RVA: 0x004753B0 File Offset: 0x004735B0
	public void PGKKNFMKAEC()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.BKLEAFCFGIF(this.PBOAKKCBNFB(jmmilefmacb), "_MainTex2", this.IKKPBLDLFKH(jmmilefmacb).HCEHDFKNGKB()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C879 RID: 51321 RVA: 0x00096C77 File Offset: 0x00094E77
	public void KCKLDEBDNFB(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.EFKJBLMEPBA(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.IIPMMNJPGMA() == "SetPosition")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C87A RID: 51322 RVA: 0x00096CA8 File Offset: 0x00094EA8
	public void LNMNGPIDLCN(ulong CENMLCAACBF)
	{
		if (this.GetChallengeByID(CENMLCAACBF).JNEKHPIOHIK() == (Challenge.CurrentStatus)8)
		{
			base.StartCoroutine(this.ENEONGMIMAJ(CENMLCAACBF));
		}
	}

	// Token: 0x0600C87B RID: 51323 RVA: 0x0047543C File Offset: 0x0047363C
	public void OBPBHCBIHCJ(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("No Dispatcher exists in the scene. Actions will not be invoked!" + BFLLKFPPAAB.id + "_EdgeSize", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.BGIOHLIFHND());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_Red_B" + BFLLKFPPAAB.BGIOHLIFHND() + "_DistortionSize", false, null);
		}
	}

	// Token: 0x0600C87C RID: 51324 RVA: 0x004754AC File Offset: 0x004736AC
	public void FECMEIJGLJI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.FAGEJPPIDOL().JAFPBHCJCGE("_TimeX", new DebugCommands.DebugCommand(this.NFKKELPADIB), "mapselector.filter.favoriteonly", "_ToneCurveRange", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1575.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.DNCDAFPLBIA(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.endDateTime, CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.OHIBODCDDKB("/C tasklist" + challenge.BGIOHLIFHND() + "Tried to Initialize the SteamAPI twice in one session!", null) && t >= t2 && t <= t3)
			{
				this.CDDLPAHMHHJ(challenge, false);
			}
		}
	}

	// Token: 0x0600C87D RID: 51325 RVA: 0x004755CC File Offset: 0x004737CC
	public Challenge PBOAKKCBNFB(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BDGDIDPDBHG));
	}

	// Token: 0x0600C87E RID: 51326 RVA: 0x00475604 File Offset: 0x00473804
	public void CHAJHAOEIKF(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO(" " + BFLLKFPPAAB.OFGNFACIGIL() + "grid", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.ENDOGIJIIMN());
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("_TimeX" + BFLLKFPPAAB.id + "Left ", false, null);
		}
	}

	// Token: 0x0600C87F RID: 51327 RVA: 0x00475674 File Offset: 0x00473874
	public void CDDLPAHMHHJ(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		/*
An exception occurred when decompiling this method (0600C87F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ChallengesManager::CDDLPAHMHHJ(Challenge,System.Boolean)

 ---> System.Exception: Inconsistent stack size at IL_2A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.<>c__DisplayClass90_0.<AddMethodBody>b__0() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1528
*/;
	}

	// Token: 0x0600C880 RID: 51328 RVA: 0x004756B0 File Offset: 0x004738B0
	public void GKFIEBJAILE()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.FPKCOIJLBLN(this.IKKPBLDLFKH(jmmilefmacb), "_Red_R", this.PBOAKKCBNFB(jmmilefmacb).info));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C881 RID: 51329 RVA: 0x00096BAD File Offset: 0x00094DAD
	public bool FEBLIDAIGAG()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C882 RID: 51330 RVA: 0x00096CCA File Offset: 0x00094ECA
	public void AcceptChallenge(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C884 RID: 51332 RVA: 0x0047573C File Offset: 0x0047393C
	private void GBCPMNOJGDJ(string[] BDGDDFKKGGA)
	{
		/*
An exception occurred when decompiling this method (0600C884)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ChallengesManager::GBCPMNOJGDJ(System.String[])

 ---> System.Exception: Inconsistent stack size at IL_156
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.<>c__DisplayClass90_0.<AddMethodBody>b__0() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1528
*/;
	}

	// Token: 0x0600C885 RID: 51333 RVA: 0x004758B4 File Offset: 0x00473AB4
	public long AHCHPPGMLEI(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-78, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	// Token: 0x0600C886 RID: 51334 RVA: 0x004758E0 File Offset: 0x00473AE0
	public void CompleteChallenge(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("challenges." + BFLLKFPPAAB.id + ".message", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.SetBool("challenges." + BFLLKFPPAAB.id + ".message", true, null);
		}
	}

	// Token: 0x0600C887 RID: 51335 RVA: 0x00475950 File Offset: 0x00473B50
	public void PCBHFLCFPIO()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.FPCHLDCNODE(this.JIPIKLINJOF(jmmilefmacb), "maps.", this.IKKPBLDLFKH(jmmilefmacb).GPBAIPHOIKN()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C888 RID: 51336 RVA: 0x00474B20 File Offset: 0x00472D20
	public IEnumerator GetReward(ulong DDFGKDFMPNL)
	{
		ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		byte[] data = wwwform.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		string text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string textBox = "#getrewardfailed: " + unityWebRequest.error;
			string button1Text = "#tryagain";
			UnityAction button1Action = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string button2Text = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(textBox, button1Text, button1Action, button2Text, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string textBox2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string button1Text2 = "#tryagain";
			UnityAction button1Action2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string button2Text2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(textBox2, button1Text2, button1Action2, button2Text2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C889 RID: 51337 RVA: 0x004759DC File Offset: 0x00473BDC
	public void ABJOHBOOJPG()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.EOAALFEALFB(this.JIPIKLINJOF(jmmilefmacb), "\" gets executed locally only, if at all.", this.GetChallengeByID(jmmilefmacb).HCEHDFKNGKB()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C88A RID: 51338 RVA: 0x00475A68 File Offset: 0x00473C68
	public long NHBOHPPIALG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-43, 0, 0, 0, 1, 0)).TotalSeconds;
	}

	// Token: 0x0400175C RID: 5980
	public string getRewardUrl = "???";

	// Token: 0x0400175D RID: 5981
	public List<Challenge> challengesList;

	// Token: 0x0400175E RID: 5982
	private List<ulong> ODNDAPINPLB;

	// Token: 0x02000386 RID: 902
	[CompilerGenerated]
	private sealed class LMIBFCKLOAF
	{
		// Token: 0x0600C88B RID: 51339 RVA: 0x00096D0E File Offset: 0x00094F0E
		internal bool NLALPCHCOPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.BDGDDFKKGGA[4]);
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x00096D25 File Offset: 0x00094F25
		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.DBBLOPNANJE;
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x00096D25 File Offset: 0x00094F25
		internal bool PBCAHKDLFPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.DBBLOPNANJE;
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x00096D35 File Offset: 0x00094F35
		internal bool BFEABMIFIEE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x00096D45 File Offset: 0x00094F45
		internal bool MEMPOPNAEDN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x00096D55 File Offset: 0x00094F55
		internal bool KFNPHCCAJFD(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == ulong.Parse(this.BDGDDFKKGGA[4]);
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x00096D25 File Offset: 0x00094F25
		internal bool BKNHHGBPLGH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.DBBLOPNANJE;
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x00096D6C File Offset: 0x00094F6C
		internal bool HMMBBDJNGGL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.BDGDDFKKGGA[2]);
		}

		// Token: 0x0600C894 RID: 51348 RVA: 0x00096D83 File Offset: 0x00094F83
		internal bool HJKJAANIFLL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == ulong.Parse(this.BDGDDFKKGGA[1]);
		}

		// Token: 0x0600C895 RID: 51349 RVA: 0x00096D9A File Offset: 0x00094F9A
		internal bool LGKMMLGKBEF(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == ulong.Parse(this.BDGDDFKKGGA[2]);
		}

		// Token: 0x0600C896 RID: 51350 RVA: 0x00096D35 File Offset: 0x00094F35
		internal bool KFNBKFELFLH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x00096DB1 File Offset: 0x00094FB1
		internal bool ONEPCCGOEKI(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == ulong.Parse(this.BDGDDFKKGGA[6]);
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x00096DC8 File Offset: 0x00094FC8
		internal bool BDGDIDPDBHG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x00096D0E File Offset: 0x00094F0E
		internal bool LLGBONGFMBH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.BDGDDFKKGGA[4]);
		}

		// Token: 0x0600C89A RID: 51354 RVA: 0x00096D45 File Offset: 0x00094F45
		internal bool OLIGLEMPFOP(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C89B RID: 51355 RVA: 0x00096D35 File Offset: 0x00094F35
		internal bool DBFPGFHEGKA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == this.DBBLOPNANJE;
		}

		// Token: 0x0400175F RID: 5983
		internal ulong DBBLOPNANJE;

		// Token: 0x04001760 RID: 5984
		internal string[] BDGDDFKKGGA;
	}

	// Token: 0x02000387 RID: 903
	[CompilerGenerated]
	private sealed class EBMHMNGGEJM
	{
		// Token: 0x0600C89C RID: 51356 RVA: 0x00096DD8 File Offset: 0x00094FD8
		internal bool KFNBKFELFLH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == this.JMMILEFMACB;
		}

		// Token: 0x0600C89D RID: 51357 RVA: 0x00096DE8 File Offset: 0x00094FE8
		internal bool BFEABMIFIEE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600C89E RID: 51358 RVA: 0x00096DF8 File Offset: 0x00094FF8
		internal bool BDGDIDPDBHG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == this.JMMILEFMACB;
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x00096DD8 File Offset: 0x00094FD8
		internal bool EKHOOPGPPGE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x00096E08 File Offset: 0x00095008
		internal bool JKEDCEOCPJO(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x00096DE8 File Offset: 0x00094FE8
		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A2 RID: 51362 RVA: 0x00096DF8 File Offset: 0x00094FF8
		internal bool LLNDDFGPOPL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x00096DD8 File Offset: 0x00094FD8
		internal bool AEINPAGJFME(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x00096DD8 File Offset: 0x00094FD8
		internal bool BKNHHGBPLGH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x00096DD8 File Offset: 0x00094FD8
		internal bool LOEAMHGMMPK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x00096DE8 File Offset: 0x00094FE8
		internal bool OLIGLEMPFOP(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A8 RID: 51368 RVA: 0x00096DF8 File Offset: 0x00094FF8
		internal bool LNDGINDKPFA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A9 RID: 51369 RVA: 0x00096E08 File Offset: 0x00095008
		internal bool PBCAHKDLFPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8AA RID: 51370 RVA: 0x00096DE8 File Offset: 0x00094FE8
		internal bool MEMPOPNAEDN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600C8AB RID: 51371 RVA: 0x00096DE8 File Offset: 0x00094FE8
		internal bool DBFPGFHEGKA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x04001761 RID: 5985
		internal ulong JMMILEFMACB;
	}
}
