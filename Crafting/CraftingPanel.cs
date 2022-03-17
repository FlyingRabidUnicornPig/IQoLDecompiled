/*
Purpose of this class: A bad attempt at reducing market inflation. UI

Deobf status: Holy fuckballs this shit is awful.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003A8 RID: 936
public class CraftingPanel : MonoBehaviour
{
	// Token: 0x0600D0E1 RID: 53473 RVA: 0x000996F1 File Offset: 0x000978F1
	public void OHMHFFIJFMA()
	{
		base.StartCoroutine(this.CNLGHPNAACK(this.PJEFPBBEBEC()));
	}

	// Token: 0x0600D0E2 RID: 53474 RVA: 0x0048E4B8 File Offset: 0x0048C6B8
	public List<CraftingPanel.ItemRecipe> PGLLMJCEPFB()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			string[] array = keyValuePair.Value.Split(new char[]
			{
				(char)-56
			});
			for (int i = 0; i < array.Length; i += 0)
			{
				string text = array[i];
				char[] array2 = new char[0];
				array2[0] = (char)-63;
				string[] array3 = text.Split(array2);
				int hohoipheopn = 1;
				if (array3.Length > 0)
				{
					hohoipheopn = int.Parse(array3[0]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array3[0]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D0E3 RID: 53475 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator MONDLDKHNBK(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D0E4 RID: 53476 RVA: 0x00099706 File Offset: 0x00097906
	private bool GHEBOEGKCFJ(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D0E5 RID: 53477 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator LECPBBBBNHI(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D0E6 RID: 53478 RVA: 0x00099716 File Offset: 0x00097916
	public void LNELMBKPMJL()
	{
		base.StartCoroutine(this.CNLGHPNAACK(this.IFPDNDNHANM()));
	}

	// Token: 0x0600D0E7 RID: 53479 RVA: 0x0048E5C8 File Offset: 0x0048C7C8
	public void OFDKNCILJDE()
	{
		bool flag = false;
		bool flag2 = false;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.OOCIECPACOG())
		{
			if (this.JBAPDBNMGOC(itemRecipe.itemsInRecipe, this.JHJHABADOLN()))
			{
				this.BJKJFIIJLJA(itemRecipe.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = false;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.CDBHAGGKAFJ(1UL, false);
		}
	}

	// Token: 0x0600D0E8 RID: 53480 RVA: 0x0048E670 File Offset: 0x0048C870
	public void JAEBNIIMGHI()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1866f, 449f, 1778f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.NJDGKAHOMCA(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "skin.hit_wrong";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.DCKDKCKAHOJ(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[5];
				array[1] = text2;
				array[0] = "_FixDistance";
				array[2] = text;
				array[8] = "_ToneCurve";
				array[3] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_TimeX" + LocalizationService.Instance.GAAFIKGPNAO("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.") + "_TimeX";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.JNNKPEBBDEA("_ScreenResolution").ToUpper() : LocalizationService.Instance.HOFKLNAJGMK("Joystick1Button8").ToUpper());
	}

	// Token: 0x0600D0E9 RID: 53481 RVA: 0x0048E958 File Offset: 0x0048CB58
	private string DDDNMEKCHHD(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.GetTextByKey("randomdrop").ToUpper();
		}
		if (EEBCDMFNKLH == 1000UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("#random #common #item").ToUpper();
		}
		if (EEBCDMFNKLH == 2000UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("#random #rare #item").ToUpper();
		}
		if (EEBCDMFNKLH != 3000UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.GetLocalizatedText("#random #epic #item").ToUpper();
	}

	// Token: 0x0600D0EA RID: 53482 RVA: 0x0009972B File Offset: 0x0009792B
	private void BJKJFIIJLJA(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D0EB RID: 53483 RVA: 0x00099740 File Offset: 0x00097940
	public void IKHOPOLPFBL()
	{
		base.StartCoroutine(this.LICNEFGOKMN(this.ECCLHKHFBCN()));
	}

	// Token: 0x0600D0EC RID: 53484 RVA: 0x0048E9F0 File Offset: 0x0048CBF0
	public List<SteamInventoryItem> ECCLHKHFBCN()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D0ED RID: 53485 RVA: 0x0048EA34 File Offset: 0x0048CC34
	public List<CraftingPanel.ItemRecipe.ItemEntrance> JHJHABADOLN()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.ECCLHKHFBCN().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.KFNBKFELFLH)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.GKGIBPAHHMO()), 0));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.HCFLGKJFKFE)).count += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D0EE RID: 53486 RVA: 0x0048EAF4 File Offset: 0x0048CCF4
	public void JOPJFBHEIFC()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.OOCIECPACOG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1172f, 1788f, 383f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.AJBILCLAJKO(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "_SSAO";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.CIODGBGDOBB(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[3];
				array[0] = text2;
				array[0] = "EndlessLoopsScoreText";
				array[4] = text;
				array[4] = "SetParticlesEmission";
				array[7] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "[RanksSystem] Map hash: " + LocalizationService.Instance.FOOAGGCODAH("3") + "Object ID. Case-Sensitive";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP("GlassesColor2").ToUpper() : LocalizationService.Instance.JNNKPEBBDEA("maps.").ToUpper());
	}

	// Token: 0x0600D0EF RID: 53487 RVA: 0x0048EDDC File Offset: 0x0048CFDC
	public void EPGPJJFFNHN()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.AJNBFGJIFNP())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(829f, 50f, 403f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "[Up]";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.AJBILCLAJKO(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[0];
				array[1] = text2;
				array[0] = "_ScreenResolution";
				array[7] = text;
				array[5] = "maps.";
				array[7] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_DiffuseColor" + LocalizationService.Instance.PLFJBNAEKML("_Screen") + "_ColorBuffer";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP("maps.").ToUpper() : LocalizationService.Instance.GetTextByKey(".png").ToUpper());
	}

	// Token: 0x0600D0F0 RID: 53488 RVA: 0x0048F0C4 File Offset: 0x0048D2C4
	private string NJDGKAHOMCA(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.NDAPBHEDJFP("https://steamcommunity.com/sharedfiles/filedetails/?id=").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551592UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("_Colorisation").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551549UL)
		{
			return LocalizationService.Instance.GAAFIKGPNAO("settings.enablehitsoundsinnormal").ToUpper();
		}
		if (EEBCDMFNKLH != 19UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.GetLocalizatedText("_Vignetting").ToUpper();
	}

	// Token: 0x0600D0F1 RID: 53489 RVA: 0x0048F15C File Offset: 0x0048D35C
	private string CIODGBGDOBB(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.NDAPBHEDJFP("value").ToUpper();
		}
		if (EEBCDMFNKLH == 61UL)
		{
			return LocalizationService.Instance.GAAFIKGPNAO("tagElement").ToUpper();
		}
		if (EEBCDMFNKLH == 100UL)
		{
			return LocalizationService.Instance.PLFJBNAEKML("MaxLivesSlider").ToUpper();
		}
		if (EEBCDMFNKLH != 26UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.OJCHMJIMHHE("_ScreenResolution").ToUpper();
	}

	// Token: 0x0600D0F2 RID: 53490 RVA: 0x0000420A File Offset: 0x0000240A
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600D0F3 RID: 53491 RVA: 0x0048F1F4 File Offset: 0x0048D3F4
	public void JANBDCGIOOA()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(734f, 1530f, 1530f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.KFMFKEAHEMC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "Tab2Content";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.KFMFKEAHEMC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[6];
				array[0] = text2;
				array[1] = "PenaltyScoreText";
				array[7] = text;
				array[4] = "_Value4";
				array[3] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_FadeFX" + LocalizationService.Instance.FOOAGGCODAH("_PColor2") + "SSAARenderTargetCamera";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("_ScreenResolution").ToUpper() : LocalizationService.Instance.HOFKLNAJGMK("ItemTemplate").ToUpper());
	}

	// Token: 0x0600D0F4 RID: 53492 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator KJBABMAAKBG(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D0F5 RID: 53493 RVA: 0x0048F4DC File Offset: 0x0048D6DC
	private string AMAECAPOBGM(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.GetTextByKey(".mp3").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551600UL)
		{
			return LocalizationService.Instance.OJCHMJIMHHE("_MainTex2").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551494UL)
		{
			return LocalizationService.Instance.OJCHMJIMHHE("_Value2").ToUpper();
		}
		if (EEBCDMFNKLH != 45UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.GAAFIKGPNAO("ChatInput").ToUpper();
	}

	// Token: 0x0600D0F6 RID: 53494 RVA: 0x0048F574 File Offset: 0x0048D774
	public void ShowRecipes()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + ":\n";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				componentInChildren.text = string.Concat(new object[]
				{
					text2,
					"\"",
					text,
					"\"x",
					itemEntrance.count
				});
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + " " + LocalizationService.Instance.GetLocalizatedText("#or") + " ";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("recipes").ToUpper() : LocalizationService.Instance.GetTextByKey("close").ToUpper());
	}

	// Token: 0x0600D0F7 RID: 53495 RVA: 0x0009972B File Offset: 0x0009792B
	private void HGKKHDMLNDB(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D0F8 RID: 53496 RVA: 0x0048F85C File Offset: 0x0048DA5C
	private string DCKDKCKAHOJ(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.JNNKPEBBDEA("EditMenu").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551470UL)
		{
			return LocalizationService.Instance.DKECBIHCKJL("_Value").ToUpper();
		}
		if (EEBCDMFNKLH == 193UL)
		{
			return LocalizationService.Instance.POMBHCDEONC("Objects in List: ").ToUpper();
		}
		if (EEBCDMFNKLH != 71UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.EHOJEKMEKCB("#failed!").ToUpper();
	}

	// Token: 0x0600D0F9 RID: 53497 RVA: 0x0048F8F4 File Offset: 0x0048DAF4
	public List<SteamInventoryItem> KAMKBEOBMHJ()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D0FA RID: 53498 RVA: 0x0048F938 File Offset: 0x0048DB38
	public void CKJCPBPMBFF()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		Debug.Log("CameraFilterPack/AAA_Super_Computer");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(449f, 343f, 217f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.IOOIKCEOALD().Find(new Predicate<SteamInventoryItem>(this.EMEEAKNFCOA)), 0);
			gameObject2.GetComponent<Button>().enabled = false;
			this.lastCrafted = 1UL;
		}
		Singleton<MessageBoxPanel>.Instance.GIKJIFGFMFP(-1, null);
	}

	// Token: 0x0600D0FB RID: 53499 RVA: 0x0048FA6C File Offset: 0x0048DC6C
	public void PEIEJPMCODB()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.PGLLMJCEPFB())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1339f, 551f, 796f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.DCKDKCKAHOJ(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "player.dragon";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.AJBILCLAJKO(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[]
				{
					text2
				};
				array[0] = "hidden";
				array[5] = text;
				array[8] = "_TimeX";
				array[3] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_Parameter" + LocalizationService.Instance.KDBLEDDGCJK("FavoriteButton") + "CameraFilterPack/Blur_Radial_Fast";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("closed").ToUpper() : LocalizationService.Instance.EIJLFGIMNPC("/").ToUpper());
	}

	// Token: 0x0600D0FC RID: 53500 RVA: 0x0048FD54 File Offset: 0x0048DF54
	public List<CraftingPanel.ItemRecipe.ItemEntrance> LIIIPANFNLL()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.IFPDNDNHANM().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.GBKBDKHPLKG)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.IIELGFOOAND()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.ONEPCCGOEKI)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D0FD RID: 53501 RVA: 0x00099706 File Offset: 0x00097906
	private bool KNLEDOOJFKJ(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D0FE RID: 53502 RVA: 0x0048E9F0 File Offset: 0x0048CBF0
	public List<SteamInventoryItem> PJEFPBBEBEC()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D0FF RID: 53503 RVA: 0x0048FE14 File Offset: 0x0048E014
	public void ONLEOPBDMFC()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.PGLLMJCEPFB())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(230f, 1212f, 1317f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.IHFHOLABMJL(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "[LevelEditorScene] Error: You're not logged into Steam!";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.AJBILCLAJKO(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[5];
				array[1] = text2;
				array[1] = "Failed!";
				array[4] = text;
				array[6] = "_Value4";
				array[6] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + " This is not possible to be called for standalone input. Please check your platform and code where this is called" + LocalizationService.Instance.KDBLEDDGCJK("_Saturation") + "_Value2";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP("settings.gamemessagesduration").ToUpper() : LocalizationService.Instance.GetTextByKey(".progress").ToUpper());
	}

	// Token: 0x0600D100 RID: 53504 RVA: 0x004900FC File Offset: 0x0048E2FC
	public List<SteamInventoryItem> IFPDNDNHANM()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D101 RID: 53505 RVA: 0x00490140 File Offset: 0x0048E340
	public void KJDJDELGKMF()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.AJNBFGJIFNP())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(785f, 1254f, 1994f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.FDNFCENDNNA(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + ".lastCheckpoint.correctScore";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.AMAECAPOBGM(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[7];
				array[0] = text2;
				array[0] = "CameraFilterPack/Blend2Camera_Divide";
				array[3] = text;
				array[8] = ": ";
				array[7] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "#E14FFF" + LocalizationService.Instance.DKECBIHCKJL("UseScanLine") + "[PlayerBase] New highscore";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.JNNKPEBBDEA("ItemsCountText").ToUpper() : LocalizationService.Instance.MPHMJLAOHAB("DPADHOR").ToUpper());
	}

	// Token: 0x0600D102 RID: 53506 RVA: 0x00490428 File Offset: 0x0048E628
	public List<CraftingPanel.ItemRecipe> AJNBFGJIFNP()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			foreach (string text in keyValuePair.Value.Split(new char[]
			{
				(char)-2
			}))
			{
				char[] array2 = new char[0];
				array2[0] = 'N';
				string[] array3 = text.Split(array2);
				int hohoipheopn = 1;
				if (array3.Length > 1)
				{
					hohoipheopn = int.Parse(array3[0]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array3[1]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D103 RID: 53507 RVA: 0x00490514 File Offset: 0x0048E714
	public bool MHNKNNBGBEG(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D104 RID: 53508 RVA: 0x0000420A File Offset: 0x0000240A
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x0600D106 RID: 53510 RVA: 0x004905B0 File Offset: 0x0048E7B0
	public void FCEAOJNHCDF()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(848f, 1758f, 0f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.DCKDKCKAHOJ(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "#yes";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.IHFHOLABMJL(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[0];
				array[1] = text2;
				array[1] = "mapselector.filter.favoriteonly";
				array[2] = text;
				array[2] = "[DiscordController] Join request {0}#{1}: {2}";
				array[4] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + ".status" + LocalizationService.Instance.GetLocalizatedText("SetBGColor") + "Status: ";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ").ToUpper() : LocalizationService.Instance.JNNKPEBBDEA("_TimeX").ToUpper());
	}

	// Token: 0x0600D107 RID: 53511 RVA: 0x00490898 File Offset: 0x0048EA98
	public void AFCHAHBOBGJ()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.AJNBFGJIFNP())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1630f, 901f, 943f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.DCKDKCKAHOJ(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "LeaderboardsButton";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.AMAECAPOBGM(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[2];
				array[0] = text2;
				array[1] = "/";
				array[7] = text;
				array[5] = "connecting";
				array[5] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_Value" + LocalizationService.Instance.OJCHMJIMHHE("Network destroy Instantiated GO: ") + ".highscore";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("Failed to Destroy objects of playerId: ").ToUpper() : LocalizationService.Instance.MPHMJLAOHAB("roomDescription").ToUpper());
	}

	// Token: 0x0600D108 RID: 53512 RVA: 0x00490B80 File Offset: 0x0048ED80
	public bool OCPEGIKAOPN(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D109 RID: 53513 RVA: 0x00490C1C File Offset: 0x0048EE1C
	public void ELELIMNECEI()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.PGLLMJCEPFB())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(845f, 481f, 1609f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.KFMFKEAHEMC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "#checkpoint";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.CIODGBGDOBB(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[7];
				array[1] = text2;
				array[1] = "y";
				array[3] = text;
				array[8] = "_MatrixColor";
				array[6] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End" + LocalizationService.Instance.FOOAGGCODAH("_Value") + "Missing shader for image effect {0}";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("_TimeX").ToUpper() : LocalizationService.Instance.EIJLFGIMNPC("Item creation successful! Published Item ID: ").ToUpper());
	}

	// Token: 0x0600D10A RID: 53514 RVA: 0x00490F04 File Offset: 0x0048F104
	public void KBKLBPIONIP()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.OOCIECPACOG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1394f, 1479f, 363f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.KFMFKEAHEMC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "_Value5";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.FDNFCENDNNA(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[8];
				array[1] = text2;
				array[0] = "_Value5";
				array[2] = text;
				array[6] = "menu.resetlevelcheckpoint";
				array[6] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "There are {0} reported logs." + LocalizationService.Instance.DKECBIHCKJL("difficulty") + "_ScreenResolution";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP(": ").ToUpper() : LocalizationService.Instance.EIJLFGIMNPC("CheckpointsScoreText").ToUpper());
	}

	// Token: 0x0600D10B RID: 53515 RVA: 0x0000420A File Offset: 0x0000240A
	private void FMNPFCHBLJF()
	{
	}

	// Token: 0x0600D10C RID: 53516 RVA: 0x004911EC File Offset: 0x0048F3EC
	public List<CraftingPanel.ItemRecipe> OOCIECPACOG()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			string value = keyValuePair.Value;
			char[] array = new char[0];
			array[1] = (char)-83;
			string[] array2 = value.Split(array);
			for (int i = 1; i < array2.Length; i += 0)
			{
				string text = array2[i];
				char[] array3 = new char[0];
				array3[0] = (char)-30;
				string[] array4 = text.Split(array3);
				int hohoipheopn = 1;
				if (array4.Length > 1)
				{
					hohoipheopn = int.Parse(array4[0]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array4[0]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D10D RID: 53517 RVA: 0x004912D8 File Offset: 0x0048F4D8
	public bool FHDNDBNLOGJ(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D10E RID: 53518 RVA: 0x00491374 File Offset: 0x0048F574
	public bool DJAKDFFBECB(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D10F RID: 53519 RVA: 0x00099755 File Offset: 0x00097955
	public void LDAEAGHICHF()
	{
		base.StartCoroutine(this.KJBABMAAKBG(this.BGMDNNHCMMF()));
	}

	// Token: 0x0600D110 RID: 53520 RVA: 0x00099706 File Offset: 0x00097906
	private bool EMEEAKNFCOA(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D111 RID: 53521 RVA: 0x0000420A File Offset: 0x0000240A
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x0600D112 RID: 53522 RVA: 0x00491410 File Offset: 0x0048F610
	public void KCDGDPMNFEG()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.PGLLMJCEPFB())
		{
			if (this.FHDNDBNLOGJ(itemRecipe.itemsInRecipe, this.GetCurrentCraftRecipe()))
			{
				this.MAOGOJIBMJK(itemRecipe.itemID, true);
				if (!flag)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.CDBHAGGKAFJ(1UL, false);
		}
	}

	// Token: 0x0600D113 RID: 53523 RVA: 0x00099706 File Offset: 0x00097906
	private bool OCIOCHGMJOB(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D114 RID: 53524 RVA: 0x004914B8 File Offset: 0x0048F6B8
	public void DNENGEFBHEC()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1372f, 1187f, 1938f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.KFMFKEAHEMC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "Joystick1Button8";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.AJBILCLAJKO(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[6];
				array[1] = text2;
				array[0] = "_Strength";
				array[1] = text;
				array[5] = "color";
				array[4] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "z" + LocalizationService.Instance.FOOAGGCODAH("_MainTex2") + "_VelocityTex";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.JNNKPEBBDEA("CameraFilterPack/Drawing_CellShading2").ToUpper() : LocalizationService.Instance.NDAPBHEDJFP("GlassesColor2").ToUpper());
	}

	// Token: 0x0600D115 RID: 53525 RVA: 0x004917A0 File Offset: 0x0048F9A0
	public bool KJNDBMJIMLL(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D116 RID: 53526 RVA: 0x0049183C File Offset: 0x0048FA3C
	public List<SteamInventoryItem> DCFIBGOLAAB()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (InventoryListElementButton inventoryListElementButton in this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>())
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D117 RID: 53527 RVA: 0x00491880 File Offset: 0x0048FA80
	public List<CraftingPanel.ItemRecipe> GetAllRecipes()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			string[] array = keyValuePair.Value.Split(new char[]
			{
				';'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(new char[]
				{
					'x'
				});
				int hohoipheopn = 1;
				if (array2.Length > 1)
				{
					hohoipheopn = int.Parse(array2[1]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array2[0]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D118 RID: 53528 RVA: 0x0049196C File Offset: 0x0048FB6C
	public void HIBHDFPICFI()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.AJNBFGJIFNP())
		{
			if (this.IsRecipesEquals(itemRecipe.itemsInRecipe, this.LJDOIIJBGID()))
			{
				this.BJKJFIIJLJA(itemRecipe.itemID, true);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = false;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.MAOGOJIBMJK(0UL, true);
		}
	}

	// Token: 0x0600D119 RID: 53529 RVA: 0x00491A14 File Offset: 0x0048FC14
	public void Init()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("[CraftingPanel] Init");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().Find(new Predicate<SteamInventoryItem>(this.HLIPOKKEOHB)), 1);
			gameObject2.GetComponent<Button>().enabled = false;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
	}

	// Token: 0x0600D11A RID: 53530 RVA: 0x004900FC File Offset: 0x0048E2FC
	public List<SteamInventoryItem> NFICCKPIFMG()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D11B RID: 53531 RVA: 0x0009976A File Offset: 0x0009796A
	public void AOOOIMIBCBL()
	{
		base.StartCoroutine(this.KONPOPDLOHB(this.NFICCKPIFMG()));
	}

	// Token: 0x0600D11C RID: 53532 RVA: 0x0009977F File Offset: 0x0009797F
	public void ABMJGPBHFBA()
	{
		base.StartCoroutine(this.LECPBBBBNHI(this.IFPDNDNHANM()));
	}

	// Token: 0x0600D11D RID: 53533 RVA: 0x00491B48 File Offset: 0x0048FD48
	public bool JBAPDBNMGOC(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D11E RID: 53534 RVA: 0x0000420A File Offset: 0x0000240A
	private void JMEOGJHCONJ()
	{
	}

	// Token: 0x0600D11F RID: 53535 RVA: 0x00491BE4 File Offset: 0x0048FDE4
	private string KFMFKEAHEMC(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.NDAPBHEDJFP("_ScreenResolution").ToUpper();
		}
		if (EEBCDMFNKLH == 194UL)
		{
			return LocalizationService.Instance.FOOAGGCODAH("Error: Timeout :S").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551553UL)
		{
			return LocalizationService.Instance.DKECBIHCKJL("</color>").ToUpper();
		}
		if (EEBCDMFNKLH != 18446744073709551492UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.OJCHMJIMHHE("Mouse Y").ToUpper();
	}

	// Token: 0x0600D120 RID: 53536 RVA: 0x0009972B File Offset: 0x0009792B
	private void EECOLGCMKPN(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D121 RID: 53537 RVA: 0x00491C7C File Offset: 0x0048FE7C
	public void DPOELEBIAOE()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("[ItemsHandler] Inventory has changed");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.CPEKEEJKLPN(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1677f, 200f, 687f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().Find(new Predicate<SteamInventoryItem>(this.HLIPOKKEOHB)), 1);
			gameObject2.GetComponent<Button>().enabled = true;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.EOKFGEFEDBB(-1, null);
	}

	// Token: 0x0600D122 RID: 53538 RVA: 0x0009972B File Offset: 0x0009792B
	private void MAOGOJIBMJK(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D123 RID: 53539 RVA: 0x00099794 File Offset: 0x00097994
	public void JMIIKMFFJON()
	{
		base.StartCoroutine(this.MONDLDKHNBK(this.KAMKBEOBMHJ()));
	}

	// Token: 0x0600D124 RID: 53540 RVA: 0x00491DB0 File Offset: 0x0048FFB0
	private string MDIIEIKMDCE(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.JNNKPEBBDEA("_EdgeThresholdMin").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551516UL)
		{
			return LocalizationService.Instance.GAAFIKGPNAO("_MainTex").ToUpper();
		}
		if (EEBCDMFNKLH == 139UL)
		{
			return LocalizationService.Instance.EHOJEKMEKCB("PickupItemInit").ToUpper();
		}
		if (EEBCDMFNKLH != 173UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.DKECBIHCKJL("skin.hit_wrong").ToUpper();
	}

	// Token: 0x0600D125 RID: 53541 RVA: 0x0049183C File Offset: 0x0048FA3C
	public List<SteamInventoryItem> GetCurrentCraftngItems()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (InventoryListElementButton inventoryListElementButton in this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>())
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D126 RID: 53542 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator CNLGHPNAACK(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D127 RID: 53543 RVA: 0x00491E48 File Offset: 0x00490048
	public bool EPNFENHEJED(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D128 RID: 53544 RVA: 0x00491EE4 File Offset: 0x004900E4
	private string IBLEEPELAMF(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.NDAPBHEDJFP("hand").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551543UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("Gameplay/Base").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551594UL)
		{
			return LocalizationService.Instance.EHOJEKMEKCB("set id").ToUpper();
		}
		if (EEBCDMFNKLH != 0UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.PLFJBNAEKML("CameraFilterPack/Sharpen_Sharpen").ToUpper();
	}

	// Token: 0x0600D129 RID: 53545 RVA: 0x0000420A File Offset: 0x0000240A
	private void ECBILENEOOL()
	{
	}

	// Token: 0x0600D12A RID: 53546 RVA: 0x00491F7C File Offset: 0x0049017C
	public bool CNBFIMKNPLC(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D12B RID: 53547 RVA: 0x00492018 File Offset: 0x00490218
	public bool GBOOMNGMNNH(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D12C RID: 53548 RVA: 0x004920B4 File Offset: 0x004902B4
	public List<CraftingPanel.ItemRecipe.ItemEntrance> LJDOIIJBGID()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.PJEFPBBEBEC().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.DBFPGFHEGKA)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.HECDOKAIGEL()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.KFNPHCCAJFD)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D12D RID: 53549 RVA: 0x00492174 File Offset: 0x00490374
	public void ResolveRecipe()
	{
		bool flag = false;
		bool flag2 = false;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			if (this.IsRecipesEquals(itemRecipe.itemsInRecipe, this.GetCurrentCraftRecipe()))
			{
				this.CDBHAGGKAFJ(itemRecipe.itemID, true);
				if (!flag)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.CDBHAGGKAFJ(0UL, false);
		}
	}

	// Token: 0x0600D12E RID: 53550 RVA: 0x0000420A File Offset: 0x0000240A
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x0600D12F RID: 53551 RVA: 0x00099706 File Offset: 0x00097906
	private bool CGMAGHODJCA(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D130 RID: 53552 RVA: 0x0049221C File Offset: 0x0049041C
	public void JEFKEOFNKIM()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("CrosshairOpacitySlider");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.CPEKEEJKLPN(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, true);
			gameObject2.transform.localScale = new Vector3(610f, 957f, 79f);
			Singleton<ItemsHandler>.Instance.DNMGPHBIGIK(gameObject2, Singleton<ItemsHandler>.Instance.NLFEOBHGMJG().Find(new Predicate<SteamInventoryItem>(this.CGMAGHODJCA)), 0);
			gameObject2.GetComponent<Button>().enabled = false;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.JDAGGOPDHNM(-1, null);
	}

	// Token: 0x0600D131 RID: 53553 RVA: 0x00492350 File Offset: 0x00490550
	public void KOKDPAEJECC()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("offsets");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 1UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(378f, 399f, 67f);
			Singleton<ItemsHandler>.Instance.DNMGPHBIGIK(gameObject2, Singleton<ItemsHandler>.Instance.IOOIKCEOALD().Find(new Predicate<SteamInventoryItem>(this.GHEBOEGKCFJ)), 0);
			gameObject2.GetComponent<Button>().enabled = false;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.GIKJIFGFMFP(-1, null);
	}

	// Token: 0x0600D132 RID: 53554 RVA: 0x00492484 File Offset: 0x00490684
	public void BKLCHHKOMLD()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		Debug.Log("offsets");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.HJHEIBHBHKC(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, true);
			gameObject2.transform.localScale = new Vector3(555f, 1311f, 1182f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GJJBKJDDJEH().Find(new Predicate<SteamInventoryItem>(this.GPLLNOKEDDP)), 1);
			gameObject2.GetComponent<Button>().enabled = true;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.KPKNPMPPKPG(-1, null);
	}

	// Token: 0x0600D133 RID: 53555 RVA: 0x004925B8 File Offset: 0x004907B8
	private string IHFHOLABMJL(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.MPHMJLAOHAB("Messages (shift+tab)").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551557UL)
		{
			return LocalizationService.Instance.GAAFIKGPNAO("_Value").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551594UL)
		{
			return LocalizationService.Instance.PLFJBNAEKML("Ignored PU RPC, cause item is inactive. ").ToUpper();
		}
		if (EEBCDMFNKLH != 18446744073709551451UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.PLFJBNAEKML("_LensDirt").ToUpper();
	}

	// Token: 0x0600D134 RID: 53556 RVA: 0x0009972B File Offset: 0x0009792B
	private void NGJGBMMCDAO(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D135 RID: 53557 RVA: 0x000997A9 File Offset: 0x000979A9
	public void HIDAOOCCPPL()
	{
		base.StartCoroutine(this.MONDLDKHNBK(this.IFPDNDNHANM()));
	}

	// Token: 0x0600D136 RID: 53558 RVA: 0x0000420A File Offset: 0x0000240A
	private void Update()
	{
	}

	// Token: 0x0600D137 RID: 53559 RVA: 0x0009976A File Offset: 0x0009796A
	public void IKNCFKBEGIF()
	{
		base.StartCoroutine(this.KONPOPDLOHB(this.NFICCKPIFMG()));
	}

	// Token: 0x0600D138 RID: 53560 RVA: 0x00492650 File Offset: 0x00490850
	public bool ELBENDFGPGA(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D139 RID: 53561 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator LICNEFGOKMN(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D13A RID: 53562 RVA: 0x0000420A File Offset: 0x0000240A
	private void MMMDPANNAIO()
	{
	}

	// Token: 0x0600D13B RID: 53563 RVA: 0x0000420A File Offset: 0x0000240A
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x0600D13C RID: 53564 RVA: 0x0009972B File Offset: 0x0009792B
	private void CDBHAGGKAFJ(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D13D RID: 53565 RVA: 0x0000420A File Offset: 0x0000240A
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x0600D13E RID: 53566 RVA: 0x004926EC File Offset: 0x004908EC
	public List<CraftingPanel.ItemRecipe.ItemEntrance> GetCurrentCraftRecipe()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.GetCurrentCraftngItems().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.GBKBDKHPLKG)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.GetItemInventoryID()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.HMMBBDJNGGL)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D13F RID: 53567 RVA: 0x004927AC File Offset: 0x004909AC
	public bool KCIEPADBALN(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D140 RID: 53568 RVA: 0x0009972B File Offset: 0x0009792B
	private void AFPALIELBHG(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D141 RID: 53569 RVA: 0x00492848 File Offset: 0x00490A48
	public void FGHCHJJBONK()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.AJNBFGJIFNP())
		{
			if (this.IsRecipesEquals(itemRecipe.itemsInRecipe, this.LJDOIIJBGID()))
			{
				this.HLNAECCGOID(itemRecipe.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.CDBHAGGKAFJ(1UL, true);
		}
	}

	// Token: 0x0600D142 RID: 53570 RVA: 0x004928F0 File Offset: 0x00490AF0
	private string FDNFCENDNNA(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.MPHMJLAOHAB("Simulate").ToUpper();
		}
		if (EEBCDMFNKLH == 126UL)
		{
			return LocalizationService.Instance.DKECBIHCKJL("_Bullet_1").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551453UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("icon").ToUpper();
		}
		if (EEBCDMFNKLH != 98UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.GAAFIKGPNAO(".progress").ToUpper();
	}

	// Token: 0x0600D143 RID: 53571 RVA: 0x00099706 File Offset: 0x00097906
	private bool GPLLNOKEDDP(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D144 RID: 53572 RVA: 0x000997BE File Offset: 0x000979BE
	public void DLLECBHKHNP()
	{
		base.StartCoroutine(this.KJBABMAAKBG(this.NFICCKPIFMG()));
	}

	// Token: 0x0600D145 RID: 53573 RVA: 0x00492988 File Offset: 0x00490B88
	public void LPCIFHLAIDL()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.OOCIECPACOG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(905f, 1241f, 460f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.NJDGKAHOMCA(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "_Params1";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.AJBILCLAJKO(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[2];
				array[0] = text2;
				array[1] = "_Value3";
				array[3] = text;
				array[2] = "CameraFilterPack/Sharpen_Sharpen";
				array[8] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_ChromaticAberration" + LocalizationService.Instance.GAAFIKGPNAO("_PositionY") + "_TimeX";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("maps.").ToUpper() : LocalizationService.Instance.NDAPBHEDJFP("_ScreenResolution").ToUpper());
	}

	// Token: 0x0600D146 RID: 53574 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator FGNBAOEPFMC(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D147 RID: 53575 RVA: 0x0049183C File Offset: 0x0048FA3C
	public List<SteamInventoryItem> BGMDNNHCMMF()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (InventoryListElementButton inventoryListElementButton in this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>())
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D148 RID: 53576 RVA: 0x0049183C File Offset: 0x0048FA3C
	public List<SteamInventoryItem> DCLFLCMIEMG()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (InventoryListElementButton inventoryListElementButton in this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>())
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D149 RID: 53577 RVA: 0x000997D3 File Offset: 0x000979D3
	public void CraftItem()
	{
		base.StartCoroutine(this.CNLGHPNAACK(this.GetCurrentCraftngItems()));
	}

	// Token: 0x0600D14A RID: 53578 RVA: 0x00492C70 File Offset: 0x00490E70
	public bool LKOGDAHNAFE(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D14B RID: 53579 RVA: 0x00492D0C File Offset: 0x00490F0C
	public void JOEPHOFGNNN()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			if (this.LKOGDAHNAFE(itemRecipe.itemsInRecipe, this.LJDOIIJBGID()))
			{
				this.MAOGOJIBMJK(itemRecipe.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.HGKKHDMLNDB(0UL, false);
		}
	}

	// Token: 0x0600D14C RID: 53580 RVA: 0x00492DB4 File Offset: 0x00490FB4
	public bool AOOFKGMDHAI(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D14D RID: 53581 RVA: 0x00492E50 File Offset: 0x00491050
	public List<CraftingPanel.ItemRecipe.ItemEntrance> DKJIFNDFPLE()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.DCLFLCMIEMG().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.GBKBDKHPLKG)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.FCOOIFPMEAB()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.NLALPCHCOPE)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D14E RID: 53582 RVA: 0x0000420A File Offset: 0x0000240A
	private void Start()
	{
	}

	// Token: 0x0600D14F RID: 53583 RVA: 0x0000420A File Offset: 0x0000240A
	private void PKLOBJHKFEO()
	{
	}

	// Token: 0x0600D150 RID: 53584 RVA: 0x000997E8 File Offset: 0x000979E8
	public void NOLMIMIBGGE()
	{
		base.StartCoroutine(this.FGNBAOEPFMC(this.BGMDNNHCMMF()));
	}

	// Token: 0x0600D151 RID: 53585 RVA: 0x00492F10 File Offset: 0x00491110
	public void MIGFOIJJJNL()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		Debug.Log("PUNCloudBestRegion");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.HJHEIBHBHKC(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1351f, 14f, 1800f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().Find(new Predicate<SteamInventoryItem>(this.OCIOCHGMJOB)), 1);
			gameObject2.GetComponent<Button>().enabled = false;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.GIKJIFGFMFP(-1, null);
	}

	// Token: 0x0600D152 RID: 53586 RVA: 0x00099706 File Offset: 0x00097906
	private bool JJDDNNMENGP(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D153 RID: 53587 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator DPPDCCJKHLH(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D154 RID: 53588 RVA: 0x00099706 File Offset: 0x00097906
	private bool FGOBDIAFNBN(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D155 RID: 53589 RVA: 0x00493044 File Offset: 0x00491244
	private string AJBILCLAJKO(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.JNNKPEBBDEA("BlockCount").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551507UL)
		{
			return LocalizationService.Instance.FOOAGGCODAH("Object ID. Case-Sensitive").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551468UL)
		{
			return LocalizationService.Instance.PLFJBNAEKML("CameraFilterPack/Blend2Camera_LinearDodge").ToUpper();
		}
		if (EEBCDMFNKLH != 34UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.OJCHMJIMHHE("_Value").ToUpper();
	}

	// Token: 0x0600D156 RID: 53590 RVA: 0x0048E5A4 File Offset: 0x0048C7A4
	private IEnumerator KONPOPDLOHB(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D157 RID: 53591 RVA: 0x000997FD File Offset: 0x000979FD
	public void ILMPIBAGEIB()
	{
		base.StartCoroutine(this.FGNBAOEPFMC(this.IFPDNDNHANM()));
	}

	// Token: 0x0600D158 RID: 53592 RVA: 0x0000420A File Offset: 0x0000240A
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600D159 RID: 53593 RVA: 0x00099706 File Offset: 0x00097906
	[CompilerGenerated]
	private bool HLIPOKKEOHB(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D15A RID: 53594 RVA: 0x0009972B File Offset: 0x0009792B
	private void HLNAECCGOID(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D15B RID: 53595 RVA: 0x004930DC File Offset: 0x004912DC
	public bool IsRecipesEquals(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D15C RID: 53596 RVA: 0x0000420A File Offset: 0x0000240A
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x0600D15D RID: 53597 RVA: 0x0009972B File Offset: 0x0009792B
	private void KHGGOLDEFCF(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D15E RID: 53598 RVA: 0x0000420A File Offset: 0x0000240A
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0400180F RID: 6159
	public GameObject craftableItemsContent;

	// Token: 0x04001810 RID: 6160
	public GameObject inCraftingItemsContent;

	// Token: 0x04001811 RID: 6161
	public GameObject craftingItem;

	// Token: 0x04001812 RID: 6162
	public GameObject historyContent;

	// Token: 0x04001813 RID: 6163
	public GameObject recipesPanel;

	// Token: 0x04001814 RID: 6164
	public Text openRecipesButton;

	// Token: 0x04001815 RID: 6165
	public GameObject recipesContent;

	// Token: 0x04001816 RID: 6166
	public GameObject recipeElement;

	// Token: 0x04001817 RID: 6167
	public Button craftButton;

	// Token: 0x04001818 RID: 6168
	public ulong currentItem;

	// Token: 0x04001819 RID: 6169
	public ulong lastCrafted;

	// Token: 0x0400181A RID: 6170
	private SteamInventoryResult_t FNMADDPJCLB;

	// Token: 0x020003A9 RID: 937
	public class ItemRecipe
	{
		// Token: 0x0600D15F RID: 53599 RVA: 0x00099812 File Offset: 0x00097A12
		public ItemRecipe(ulong EEBCDMFNKLH)
		{
			this.itemID = EEBCDMFNKLH;
		}

		// Token: 0x0400181B RID: 6171
		public ulong itemID;

		// Token: 0x0400181C RID: 6172
		public List<CraftingPanel.ItemRecipe.ItemEntrance> itemsInRecipe = new List<CraftingPanel.ItemRecipe.ItemEntrance>();

		// Token: 0x020003AA RID: 938
		public class ItemEntrance
		{
			// Token: 0x0600D160 RID: 53600 RVA: 0x00493178 File Offset: 0x00491378
			public virtual bool HBGODDEKPII(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item != itemEntrance.item || this.count == itemEntrance.count;
			}

			// Token: 0x0600D161 RID: 53601 RVA: 0x00493178 File Offset: 0x00491378
			public virtual bool JHCGGHMMEDK(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item != itemEntrance.item || this.count == itemEntrance.count;
			}

			// Token: 0x0600D162 RID: 53602 RVA: 0x004931B0 File Offset: 0x004913B0
			public virtual bool DBGENFMEEMN(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D163 RID: 53603 RVA: 0x004931B0 File Offset: 0x004913B0
			public virtual bool FAEELIPGIBL(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D164 RID: 53604 RVA: 0x0009982C File Offset: 0x00097A2C
			public virtual int AONIGPABICN()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D165 RID: 53605 RVA: 0x00493178 File Offset: 0x00491378
			public virtual bool HELLBLOBANP(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item != itemEntrance.item || this.count == itemEntrance.count;
			}

			// Token: 0x0600D166 RID: 53606 RVA: 0x0009982C File Offset: 0x00097A2C
			public virtual int INMMLLMPKEK()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D167 RID: 53607 RVA: 0x0009982C File Offset: 0x00097A2C
			public virtual int APDIKIFPAEB()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D168 RID: 53608 RVA: 0x0009982C File Offset: 0x00097A2C
			public virtual int MKAMCNNMDIG()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D169 RID: 53609 RVA: 0x004931B0 File Offset: 0x004913B0
			public override bool Equals(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D16A RID: 53610 RVA: 0x0009982C File Offset: 0x00097A2C
			public virtual int KEGBMIIJELK()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D16B RID: 53611 RVA: 0x0009982C File Offset: 0x00097A2C
			public virtual int OFIPAKGBICP()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D16C RID: 53612 RVA: 0x0009982C File Offset: 0x00097A2C
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D16D RID: 53613 RVA: 0x00099834 File Offset: 0x00097A34
			public ItemEntrance(ulong DBIMJHMKHNK, int HOHOIPHEOPN)
			{
				this.item = DBIMJHMKHNK;
				this.count = HOHOIPHEOPN;
			}

			// Token: 0x0600D16E RID: 53614 RVA: 0x004931B0 File Offset: 0x004913B0
			public virtual bool IHNJHAMKCBL(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0400181D RID: 6173
			public ulong item;

			// Token: 0x0400181E RID: 6174
			public int count;
		}
	}

	// Token: 0x020003AB RID: 939
	[CompilerGenerated]
	private sealed class LEGBIGPINGP
	{
		// Token: 0x0600D16F RID: 53615 RVA: 0x0009984A File Offset: 0x00097A4A
		internal bool KFNBKFELFLH(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KHAKCOOFJIL();
		}

		// Token: 0x0600D170 RID: 53616 RVA: 0x00099865 File Offset: 0x00097A65
		internal bool OFHCGKJFGDI(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JAMGADDBEPG();
		}

		// Token: 0x0600D171 RID: 53617 RVA: 0x00099880 File Offset: 0x00097A80
		internal bool LLGBONGFMBH(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D173 RID: 53619 RVA: 0x0009989B File Offset: 0x00097A9B
		internal bool FBGMHPEEIFC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.DIJIPJOMFAK();
		}

		// Token: 0x0600D174 RID: 53620 RVA: 0x000998B6 File Offset: 0x00097AB6
		internal bool FIPCLHEKKCA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		// Token: 0x0600D175 RID: 53621 RVA: 0x000998D1 File Offset: 0x00097AD1
		internal bool DGDCNDCGPCP(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IIELGFOOAND();
		}

		// Token: 0x0600D176 RID: 53622 RVA: 0x000998EC File Offset: 0x00097AEC
		internal bool LLNDDFGPOPL(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.HECDOKAIGEL();
		}

		// Token: 0x0600D177 RID: 53623 RVA: 0x00099907 File Offset: 0x00097B07
		internal bool DBFPGFHEGKA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		// Token: 0x0600D178 RID: 53624 RVA: 0x000998D1 File Offset: 0x00097AD1
		internal bool BFEABMIFIEE(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IIELGFOOAND();
		}

		// Token: 0x0600D179 RID: 53625 RVA: 0x00099922 File Offset: 0x00097B22
		internal bool BDGDIDPDBHG(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.CCHGOBICNAD();
		}

		// Token: 0x0600D17A RID: 53626 RVA: 0x00099880 File Offset: 0x00097A80
		internal bool ONEPCCGOEKI(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x0009993D File Offset: 0x00097B3D
		internal bool MMJGKBNKFGM(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.BBALBMNJGMD();
		}

		// Token: 0x0600D17C RID: 53628 RVA: 0x00099958 File Offset: 0x00097B58
		internal bool DKGPCPBNDPK(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.OAKIKELAPIK();
		}

		// Token: 0x0600D17D RID: 53629 RVA: 0x00099907 File Offset: 0x00097B07
		internal bool HNMFCOHLALO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		// Token: 0x0600D17E RID: 53630 RVA: 0x00099973 File Offset: 0x00097B73
		internal bool EGKGJJGAPMN(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GELGKMKDHML();
		}

		// Token: 0x0600D17F RID: 53631 RVA: 0x0009998E File Offset: 0x00097B8E
		internal bool HCFLGKJFKFE(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.MPGLFKMEBAF();
		}

		// Token: 0x0600D180 RID: 53632 RVA: 0x00099922 File Offset: 0x00097B22
		internal bool FFEGPHJKMFK(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.CCHGOBICNAD();
		}

		// Token: 0x0600D181 RID: 53633 RVA: 0x0009993D File Offset: 0x00097B3D
		internal bool NLALPCHCOPE(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.BBALBMNJGMD();
		}

		// Token: 0x0600D182 RID: 53634 RVA: 0x000999A9 File Offset: 0x00097BA9
		internal bool HMMBBDJNGGL(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GetItemInventoryID();
		}

		// Token: 0x0600D183 RID: 53635 RVA: 0x00099922 File Offset: 0x00097B22
		internal bool KFNPHCCAJFD(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.CCHGOBICNAD();
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x000999C4 File Offset: 0x00097BC4
		internal bool HJKJAANIFLL(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x000999A9 File Offset: 0x00097BA9
		internal bool GBKBDKHPLKG(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GetItemInventoryID();
		}

		// Token: 0x0600D186 RID: 53638 RVA: 0x0009989B File Offset: 0x00097A9B
		internal bool MEMPOPNAEDN(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.DIJIPJOMFAK();
		}

		// Token: 0x0400181F RID: 6175
		internal SteamInventoryItem DBIMJHMKHNK;
	}
}
