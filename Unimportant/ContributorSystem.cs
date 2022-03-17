/*
Importance of this class: None atm (could turn this into a different system, whenifever I start doing server shit)

Purpose of this class: A bad attempt at stealing people's money and time.

Deobf status: wew got a fucking obfuscated sub class within a obfuscated subclass. Good thing this isn't used anymore.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContributorSystem : Singleton<ContributorSystem>
{
	public void ShowTicketsStore()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Write me to get one for testing :)", "Ok", null, true, false, 0f);
	}

	public IEnumerator ShowManager(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		ContributorSystem.BLELFKMMOBG.FHMOFKJOILN fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	public IEnumerator UseTicket(string EEBCDMFNKLH)
	{
		ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		WWW www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string textBox = "#failed: " + www.text;
					string button1Text = "#tryagain";
					UnityAction button1Action = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string button2Text = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(textBox, button1Text, button1Action, button2Text, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string textBox2 = "#failed: " + www.text;
				string button1Text2 = "#tryagain";
				UnityAction button1Action2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string button2Text2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(textBox2, button1Text2, button1Action2, button2Text2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	public IEnumerator LoadContributor(CSteamID JMMILEFMACB)
	{
		if (!this.scammed.ContainsKey(JMMILEFMACB))
		{
			WWWForm wwwform = new WWWForm();
			wwwform.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
			wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
			byte[] data = wwwform.data;
			string url = Singleton<GameManager>.Instance.CreateServerURL(this.checkContributorURL);
			WWW www = new WWW(url, data);
			yield return www;
			if (string.IsNullOrEmpty(www.error))
			{
				try
				{
					bool kjpahofpckd = int.Parse(www.text) == 1;
					this.CheckContributor(JMMILEFMACB, kjpahofpckd);
				}
				catch (Exception)
				{
				}
			}
		}
		yield break;
	}

	public bool IsContributor(CSteamID HFEFHOPOLIK)
	{
		return this.scammed.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.scammed[HFEFHOPOLIK];
	}

	public void CloseViewer()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, false, null, true, 0.2f, true));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, false, null, true, 0.2f, true));
	}

	public IEnumerator Init()
	{
		yield return base.StartCoroutine(this.LoadContributor(SteamUser.GetSteamID()));
		yield break;
	}

	public void HideTicketsStore() {}

	private void CheckContributor(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.scammed.ContainsKey(JMMILEFMACB))
		{
			this.scammed[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.scammed.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public ContributorSystem()
	{
		// These blanks mean that the actual URL is hidden in inaccessible somewhere. No worries easy to extract with other means.
		this.checkContributorURL = "?";
		this.redeemTicketURL = "?";
		this.scammed = new Dictionary<CSteamID, bool>();
	}

	public string checkContributorURL;
	public string redeemTicketURL;

	public Button buttonBack;

	public GameObject managerCanvas;
	public GameObject promoCanvas;

	private Dictionary<CSteamID, bool> scammed;
}
