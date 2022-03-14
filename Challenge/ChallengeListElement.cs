/*
Importance of this class: Very Important to challenges.

Purpose of this class: Challenge Display object.

Deobf status: Awful.
*/

using System;
using System.Collections;
using System.Globalization;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200037D RID: 893
public class ChallengeListElement : MonoBehaviour
{
	// Token: 0x0600C5EB RID: 50667 RVA: 0x0046DFE8 File Offset: 0x0046C1E8
	public void FHPNIFPJKCK()
	{
		DateTime t = DateTime.UtcNow.AddHours(1299.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).EFOKGOMPFIO() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.CDDLPAHMHHJ(Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ), true);
				this.OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).BBLDABFGDFF() == Challenge.CurrentStatus.InProgress && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = false;
				this.AFILPDENJAC();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C5EC RID: 50668 RVA: 0x0046E0CC File Offset: 0x0046C2CC
	public void PFMJPIJONIP(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.ENDOGIJIIMN();
		this.HJJFKFJFKLJ();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.DNCDAFPLBIA(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.LACOFOPCNBG(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.DCHBAIPFOMK();
		this.CAPPGMDHJEN();
	}

	// Token: 0x0600C5ED RID: 50669 RVA: 0x0046E130 File Offset: 0x0046C330
	public IEnumerator FIKFJDFELIP()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C5EE RID: 50670 RVA: 0x0046E14C File Offset: 0x0046C34C
	public void LKEPIEEIMAE(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.OFGNFACIGIL();
		this.OEFGNIAHHNH();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MHNLMDPIGLB(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BDKJGGONHEL(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.ADKFDALFMAE();
		this.PKNEKFHMCOJ();
	}

	// Token: 0x0600C5EF RID: 50671 RVA: 0x0046E1B0 File Offset: 0x0046C3B0
	public void NKLIHNJCHOG()
	{
		if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.EHOJEKMEKCB("0.00").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GAAFIKGPNAO("maps.").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.FOOAGGCODAH("VoteDownToggle").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).EBJMABMHEEO() == (Challenge.CurrentStatus)8)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.OJCHMJIMHHE("VisionBlur").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).JNEKHPIOHIK() == (Challenge.CurrentStatus)5)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Failed to Destroy objects of playerId: ").ToUpper();
		}
	}

	// Token: 0x0600C5F0 RID: 50672 RVA: 0x0046E348 File Offset: 0x0046C548
	private void OEFGNIAHHNH()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("[#clicktoacceptchallenge]").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("[#clicktogetreward]").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		this.infoText.text = string.Concat(new string[]
		{
			"<b>",
			LocalizationService.Instance.GetLocalizatedText("#task"),
			":</b> ",
			challengeByID.info,
			Environment.NewLine,
			Environment.NewLine,
			"<b>",
			LocalizationService.Instance.GetLocalizatedText("#status"),
			":</b> ",
			LocalizationService.Instance.GetLocalizatedText("#" + challengeByID.PlayerStatus.ToString().ToLower())
		});
		string reward = challengeByID.reward;
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("#reward: ").ToUpper() + reward;
		this.MIBKLDAKMLF();
	}

	// Token: 0x0600C5F1 RID: 50673 RVA: 0x0046E130 File Offset: 0x0046C330
	public IEnumerator IMCKJCHKMKB()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C5F2 RID: 50674 RVA: 0x0046E4F0 File Offset: 0x0046C6F0
	public void FFBDGOBNNCO(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.BGIOHLIFHND();
		this.AFILPDENJAC();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.DNCDAFPLBIA(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BDKJGGONHEL(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.KCMBMLFLEOK();
		this.CAPPGMDHJEN();
	}

	// Token: 0x0600C5F3 RID: 50675 RVA: 0x0046E554 File Offset: 0x0046C754
	private void NKODDACKFKI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C5F4 RID: 50676 RVA: 0x0046E5C8 File Offset: 0x0046C7C8
	public void HBKEHHCMMBN(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.id;
		this.OEFGNIAHHNH();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MHNLMDPIGLB(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BDKJGGONHEL(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.ADKFDALFMAE();
		this.LNCDNKGHOHJ();
	}

	// Token: 0x0600C5F5 RID: 50677 RVA: 0x0046E62C File Offset: 0x0046C82C
	public void OnClick()
	{
		DateTime t = DateTime.UtcNow.AddHours(3.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.AcceptChallenge(Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ), true);
				this.OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.OEFGNIAHHNH();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.TryGetReward(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C5F6 RID: 50678 RVA: 0x0046E710 File Offset: 0x0046C910
	private void PKNEKFHMCOJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C5F7 RID: 50679 RVA: 0x0046E130 File Offset: 0x0046C330
	public IEnumerator Start()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C5F8 RID: 50680 RVA: 0x0046E784 File Offset: 0x0046C984
	private void CAPPGMDHJEN()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(this.DLNONMLNOJJ).CCCHEABDHMH()))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C5F9 RID: 50681 RVA: 0x0046E7F8 File Offset: 0x0046C9F8
	private void INLBJELNLAL()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).CCCHEABDHMH()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C5FA RID: 50682 RVA: 0x0046E86C File Offset: 0x0046CA6C
	public void GDNMIEHNGBL()
	{
		DateTime t = DateTime.UtcNow.AddHours(950.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).HCPDNILLJEJ() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.AcceptChallenge(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ), false);
				this.AFILPDENJAC();
			}
			if (Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(this.DLNONMLNOJJ).JNEKHPIOHIK() == Challenge.CurrentStatus.ObtainedReward && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = false;
				this.AFILPDENJAC();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C5FB RID: 50683 RVA: 0x0046E950 File Offset: 0x0046CB50
	public void LAOCNFBGEDE()
	{
		DateTime t = DateTime.UtcNow.AddHours(435.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.PMBBDPNMGHK(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ), true);
				this.HJJFKFJFKLJ();
			}
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.AFILPDENJAC();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.OCOJEBKMIEJ(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C5FC RID: 50684 RVA: 0x0046EA34 File Offset: 0x0046CC34
	public void JPNOHODALMI()
	{
		DateTime t = DateTime.UtcNow.AddHours(1979.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).BBLDABFGDFF() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.KCKLDEBDNFB(Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ), false);
				this.OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).BBLDABFGDFF() == (Challenge.CurrentStatus)8 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.AFILPDENJAC();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.KCEHNEPHBPH(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C5FD RID: 50685 RVA: 0x0046EB18 File Offset: 0x0046CD18
	public void CJBCKPEOOGI()
	{
		DateTime t = DateTime.UtcNow.AddHours(1610.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(this.DLNONMLNOJJ).OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.FKMBPEGKILO(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ), true);
				this.OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).EBJMABMHEEO() == Challenge.CurrentStatus.ObtainedReward && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.AFILPDENJAC();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C5FE RID: 50686 RVA: 0x0046EBFC File Offset: 0x0046CDFC
	public void GHILDCBCDJI()
	{
		if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).EBJMABMHEEO() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.KDBLEDDGCJK("(\\[ */ *quote *\\])").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.POMBHCDEONC("_TimeX").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Joystick1Button9").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).HCPDNILLJEJ() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.EHOJEKMEKCB("_Color_B").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).HCPDNILLJEJ() == Challenge.CurrentStatus.ObtainedReward)
		{
			this.timeText.text = LocalizationService.Instance.PLFJBNAEKML("_ScreenResolution").ToUpper();
		}
	}

	// Token: 0x0600C5FF RID: 50687 RVA: 0x0046ED94 File Offset: 0x0046CF94
	public void DBDCIAIJOKG()
	{
		DateTime t = DateTime.UtcNow.AddHours(1194.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(this.DLNONMLNOJJ).EFOKGOMPFIO() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.AcceptChallenge(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ), false);
				this.AFILPDENJAC();
			}
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).EFOKGOMPFIO() == (Challenge.CurrentStatus)7 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.AFILPDENJAC();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C600 RID: 50688 RVA: 0x0046EE78 File Offset: 0x0046D078
	public void Update()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#timeuntilend: ").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#timeuntilchallenge: ").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#finished").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#getrewardnow ").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.ObtainedReward)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#obtained").ToUpper();
		}
	}

	// Token: 0x0600C601 RID: 50689 RVA: 0x0046F010 File Offset: 0x0046D210
	private void LNCDNKGHOHJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).CCCHEABDHMH()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(true);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C602 RID: 50690 RVA: 0x0046E130 File Offset: 0x0046C330
	public IEnumerator NPLCENPNJBM()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C603 RID: 50691 RVA: 0x0046F084 File Offset: 0x0046D284
	private void AFILPDENJAC()
	{
		if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.DKECBIHCKJL("_MainTex2").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).EBJMABMHEEO() == (Challenge.CurrentStatus)4)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.EHOJEKMEKCB("_ScreenResolution").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[83];
		array[1] = "_Red_G";
		array[0] = LocalizationService.Instance.GAAFIKGPNAO("Scrollbar");
		array[0] = "Freq: ";
		array[8] = challenge.info;
		array[4] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[7] = "CameraFilterPack/Blend2Camera_Saturation";
		array[8] = LocalizationService.Instance.EHOJEKMEKCB("(\\[ */ *h1 *\\])");
		array[6] = "CameraFilterPack/FX_Grid";
		array[21] = LocalizationService.Instance.EHOJEKMEKCB(" (" + challenge.JNEKHPIOHIK().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.KJOKBLAMHLN();
		this.rewardText.text = LocalizationService.Instance.OJCHMJIMHHE("#useticket").ToUpper() + str;
		this.NKODDACKFKI();
	}

	// Token: 0x0600C604 RID: 50692 RVA: 0x0046F22C File Offset: 0x0046D42C
	private void MIBKLDAKMLF()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C605 RID: 50693 RVA: 0x0046E130 File Offset: 0x0046C330
	public IEnumerator CCLNNLCOPBL()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C606 RID: 50694 RVA: 0x0046F2A0 File Offset: 0x0046D4A0
	public void Init(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.id;
		this.OEFGNIAHHNH();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.GetProgress();
		this.MIBKLDAKMLF();
	}

	// Token: 0x0600C608 RID: 50696 RVA: 0x0046F304 File Offset: 0x0046D504
	public void LNMKDFDKFPF(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.ENDOGIJIIMN();
		this.OEFGNIAHHNH();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MHNLMDPIGLB(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BAMLANAIFEO(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.ADKFDALFMAE();
		this.INLBJELNLAL();
	}

	// Token: 0x0600C609 RID: 50697 RVA: 0x0046F368 File Offset: 0x0046D568
	private void HJJFKFJFKLJ()
	{
		if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GAAFIKGPNAO("DataText").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)6)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.POMBHCDEONC("PublishButton").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.JIPIKLINJOF(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-32];
		array[1] = "USE_PREDICATION";
		array[0] = LocalizationService.Instance.PLFJBNAEKML("#close");
		array[4] = "_ColoredChange";
		array[3] = challenge.GPBAIPHOIKN();
		array[3] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[0] = "RoomNameText";
		array[7] = LocalizationService.Instance.KDBLEDDGCJK("STICKRVER");
		array[2] = "menu.tabid";
		array[34] = LocalizationService.Instance.FOOAGGCODAH("1278033234" + challenge.EFOKGOMPFIO().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		this.rewardText.text = LocalizationService.Instance.PLFJBNAEKML("_MainTex2").ToUpper() + reward;
		this.NKODDACKFKI();
	}

	// Token: 0x0600C60A RID: 50698 RVA: 0x0046E130 File Offset: 0x0046C330
	public IEnumerator FEHCNJLLJMP()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x04001732 RID: 5938
	public Text infoText;

	// Token: 0x04001733 RID: 5939
	public Text timeText;

	// Token: 0x04001734 RID: 5940
	public Text rewardText;

	// Token: 0x04001735 RID: 5941
	public Image bg;

	// Token: 0x04001736 RID: 5942
	public Slider progressBar;

	// Token: 0x04001737 RID: 5943
	public GameObject lockedCanvas;

	// Token: 0x04001738 RID: 5944
	public Text actionText;

	// Token: 0x04001739 RID: 5945
	private ulong DLNONMLNOJJ;

	// Token: 0x0400173A RID: 5946
	private DateTime DKJCKNPNPAB;

	// Token: 0x0400173B RID: 5947
	private DateTime BLKCBHFNLGB;

	// Token: 0x0400173C RID: 5948
	private bool IHEDNJNCIPM;
}
