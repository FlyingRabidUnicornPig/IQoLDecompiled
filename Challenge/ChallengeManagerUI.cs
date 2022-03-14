/*
Importance of this class: Important for challenge.

Purpose of this class: Display challenge shit to user prolly idfk.

Deobf status: Fuck me
*/

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200038A RID: 906
public class ChallengesManagerUI : Singleton<ChallengesManagerUI>
{
	// Token: 0x0600C949 RID: 51529 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator CGAKGPGFAAH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C94A RID: 51530 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator LPJDKNPGGJN(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C94B RID: 51531 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator PHKIFFJAGCL(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C94C RID: 51532 RVA: 0x00096ED9 File Offset: 0x000950D9
	public void FLEILMCOLPH()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(this.canvas, true, null, true, 1127f, false));
	}

	// Token: 0x0600C94D RID: 51533 RVA: 0x00096F02 File Offset: 0x00095102
	public void GAMJJIBMFBG()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.canvas, true, null, true, 1655f, false));
	}

	// Token: 0x0600C94E RID: 51534 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator DisplayViewer(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C94F RID: 51535 RVA: 0x00096F2B File Offset: 0x0009512B
	public void CJIPCEEFIGP()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.canvas, false, null, false, 655f, true));
	}

	// Token: 0x0600C950 RID: 51536 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator HOPMPKEKJCJ(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C951 RID: 51537 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator FANLNIPGEII(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C952 RID: 51538 RVA: 0x00096F54 File Offset: 0x00095154
	public void GAGNJOFDAHF()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, false, 21f, false));
	}

	// Token: 0x0600C953 RID: 51539 RVA: 0x00096F7D File Offset: 0x0009517D
	public void NEBBDIHMOLM()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(this.canvas, true, null, false, 460f, false));
	}

	// Token: 0x0600C954 RID: 51540 RVA: 0x00096FA6 File Offset: 0x000951A6
	public void GEPGLFMJJDI()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, false, 1092f, false));
	}

	// Token: 0x0600C955 RID: 51541 RVA: 0x00096FCF File Offset: 0x000951CF
	public void AIOEGPBMFIO()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, false, 179f, true));
	}

	// Token: 0x0600C956 RID: 51542 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator KILGJIBFBDL(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C957 RID: 51543 RVA: 0x00096FF8 File Offset: 0x000951F8
	public void FEFAHOMMICK()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.canvas, true, null, false, 475f, true));
	}

	// Token: 0x0600C958 RID: 51544 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator NGLEIIHHKCD(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C959 RID: 51545 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator MIIAHMOFFEH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C95A RID: 51546 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator AEJKNCLEFNN(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C95B RID: 51547 RVA: 0x00097021 File Offset: 0x00095221
	public void PJCFOHKLHEN()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(this.canvas, false, null, true, 1895f, false));
	}

	// Token: 0x0600C95C RID: 51548 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator CIGLEJADFDL(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C95D RID: 51549 RVA: 0x0009704A File Offset: 0x0009524A
	public void PFPAPFMHBDA()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(this.canvas, true, null, false, 15f, false));
	}

	// Token: 0x0600C95E RID: 51550 RVA: 0x00097073 File Offset: 0x00095273
	public void HNDBMNLDILD()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(this.canvas, true, null, true, 454f, false));
	}

	// Token: 0x0600C95F RID: 51551 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator IDGAGPEPBGO(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C960 RID: 51552 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator KDBNKDAOLOB(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C961 RID: 51553 RVA: 0x0009709C File Offset: 0x0009529C
	public void MIKDILPAOOI()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(this.canvas, false, null, false, 1832f, false));
	}

	// Token: 0x0600C962 RID: 51554 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator LHCEHBGEGED(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C963 RID: 51555 RVA: 0x000970C5 File Offset: 0x000952C5
	public void FGDIBNNJCLK()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(this.canvas, true, null, true, 1725f, false));
	}

	// Token: 0x0600C964 RID: 51556 RVA: 0x000970EE File Offset: 0x000952EE
	public void DAJOCCFPEPJ()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(this.canvas, true, null, false, 1033f, false));
	}

	// Token: 0x0600C965 RID: 51557 RVA: 0x00097117 File Offset: 0x00095317
	public void DHJILJCJJCG()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(this.canvas, true, null, false, 520f, false));
	}

	// Token: 0x0600C966 RID: 51558 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator HGFGMCIMHHA(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C967 RID: 51559 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator PHLLLNPPPEO(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C968 RID: 51560 RVA: 0x00097140 File Offset: 0x00095340
	public void IGEAFKKFMBO()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(this.canvas, true, null, true, 539f, true));
	}

	// Token: 0x0600C969 RID: 51561 RVA: 0x00097169 File Offset: 0x00095369
	public void EOEOMBKLLPF()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(this.canvas, false, null, true, 1432f, true));
	}

	// Token: 0x0600C96A RID: 51562 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator KOBBDINKNFM(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C96B RID: 51563 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator JCCPLKDFGIJ(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C96C RID: 51564 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator DOHCPHEEGJJ(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C96D RID: 51565 RVA: 0x00097192 File Offset: 0x00095392
	public void CloseViewer()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
	}

	// Token: 0x0600C96E RID: 51566 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator CMMDPOBFLAC(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C96F RID: 51567 RVA: 0x000971BB File Offset: 0x000953BB
	public void FGBBFBOBILD()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(this.canvas, false, null, true, 519f, true));
	}

	// Token: 0x0600C970 RID: 51568 RVA: 0x000971E4 File Offset: 0x000953E4
	public void IADJGEBPENF()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.canvas, true, null, false, 1510f, false));
	}

	// Token: 0x0600C971 RID: 51569 RVA: 0x0009720D File Offset: 0x0009540D
	public void EELFFPJDBFB()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(this.canvas, true, null, true, 1106f, false));
	}

	// Token: 0x0600C972 RID: 51570 RVA: 0x00097236 File Offset: 0x00095436
	public void IKHNDOCFOLN()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(this.canvas, true, null, true, 1633f, true));
	}

	// Token: 0x0600C973 RID: 51571 RVA: 0x0009725F File Offset: 0x0009545F
	public void PEEBPAIOEHM()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(this.canvas, false, null, true, 112f, true));
	}

	// Token: 0x0600C974 RID: 51572 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator BEOOPPNPBBH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C975 RID: 51573 RVA: 0x00097288 File Offset: 0x00095488
	public void LFILBMDGBBI()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(this.canvas, false, null, false, 771f, true));
	}

	// Token: 0x0600C977 RID: 51575 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator PAHCAKAJLAH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C978 RID: 51576 RVA: 0x000972B9 File Offset: 0x000954B9
	public void KOJJMLMCPKP()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(this.canvas, true, null, false, 1927f, true));
	}

	// Token: 0x0600C979 RID: 51577 RVA: 0x000972E2 File Offset: 0x000954E2
	public void FOBIAAOHIIC()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(this.canvas, true, null, true, 538f, true));
	}

	// Token: 0x0600C97A RID: 51578 RVA: 0x0009730B File Offset: 0x0009550B
	public void CMMJOOGMPOP()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(this.canvas, true, null, true, 931f, false));
	}

	// Token: 0x0600C97B RID: 51579 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator NBGGKHGOKIF(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C97C RID: 51580 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator GAHDLFHKILG(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C97D RID: 51581 RVA: 0x00097334 File Offset: 0x00095534
	public void IGFMOEFLHCF()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(this.canvas, false, null, true, 1931f, true));
	}

	// Token: 0x0600C97E RID: 51582 RVA: 0x0009735D File Offset: 0x0009555D
	public void GDMBKNLAMEH()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(this.canvas, false, null, true, 1235f, false));
	}

	// Token: 0x0600C97F RID: 51583 RVA: 0x00097386 File Offset: 0x00095586
	public void CKKGGBFFHHC()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.canvas, false, null, false, 82f, true));
	}

	// Token: 0x0600C980 RID: 51584 RVA: 0x00477A54 File Offset: 0x00475C54
	public IEnumerator IMGADBAGEMK(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x04001772 RID: 6002
	public GameObject canvas;

	// Token: 0x04001773 RID: 6003
	public Text infoText;

	// Token: 0x04001774 RID: 6004
	public Button buttonBack;

	// Token: 0x04001775 RID: 6005
	public GameObject challengeListContent;

	// Token: 0x04001776 RID: 6006
	public GameObject challengeListElementPrefab;

	// Token: 0x04001777 RID: 6007
	private bool NNMBIFEBFGD;
}
