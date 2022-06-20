/*
Hopefully I didn't break anything (important) with this one, it was a huge obfuscated file.

TODO: Fix enumerator bs and make them list loops or whatever for readability
TODO: Can probably remove duplicant methods, from InventorySelector
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class ItemsHandler : Singleton<ItemsHandler>
{
	public InventoryItemData GetItemData(string itemId) => this.itemsData.Find(x => x.id == itemId);

	private void GetOfflineItems()
	{
		this.userItems.Add(new SteamInventoryItem(0UL, this.itemsData[0], true));
		this.userItems.Add(new SteamInventoryItem(1UL, this.itemsData[1], true));
		this.userItems.Add(new SteamInventoryItem(17UL, this.itemsData[17], true));
	}

	public List<string> GetItemsID() => this.itemDictionary.Values.ToList<string>();

	public void ShowNewItems()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem sii in this.newItemsNotifications)
			list.Add(new SteamInventoryItem(sii));

		base.StartCoroutine(this.UpdateItemsIThink(list));
		this.newItemsNotifications.Clear();
	}

	public void CheckReward(string itemId) {}

	private IEnumerator LoadItems()
	{
		Debug.Log("[ItemsHandler] Found " + this.itemDictionary.Count + " in-game items");
		
		foreach (KeyValuePair<int, string> keyValuePair in this.itemDictionary)
		{
			Debug.Log("[ItemsHandler] Loading " + keyValuePair.Value);
			this.itemsData.Add(new InventoryItemData(keyValuePair.Value));
		}

		Debug.Log("[ItemsHandler] All in-game items loaded");
		yield break;
	}

	public void DeleteItem(ulong MOANAJGGPLK)
	{
		this.requestType = 3;
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.ConsumeItem(out steamInventoryResult_t, (SteamItemInstanceID_t)MOANAJGGPLK, 1U);
	}

	public void Initializate() => base.StartCoroutine(this.Init());

	public void CloseNewItems()
	{
		Singleton<SaveSystem>.Instance.Flush();
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, false, null, true, 0.2f, true));
	}

	public void AddSteamInventoryItemsToList(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);

		foreach (SteamInventoryItem sii in Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().OrderBy(x=>x.item.rarity))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			this.UpdateInventoryItem(gameObject, sii, 1);
		}
	}

	public List<InventoryItemType> GetAllTypes()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		using (List<InventoryItemData>.Enumerator enumerator = this.itemsData.GetEnumerator())
		{
			while (enumerator.MoveNext())
				if (!list.Exists(x => x == enumerator.Current.type))
					list.Add(enumerator.Current.type);
		}

		return list;
	}

	private void Update() {}

	public void OnEnable()
	{
		this.steamInventoryResultReadyCallback = Callback<SteamInventoryResultReady_t>.Create(new Callback<SteamInventoryResultReady_t>.DispatchDelegate(this.OnSteamInventoryResultsReady));
		this.steamInventoryFullUpdateCallback = Callback<SteamInventoryFullUpdate_t>.Create(new Callback<SteamInventoryFullUpdate_t>.DispatchDelegate(this.OnSteamInventoryFullUpdate));
		this.steamInventoryDefUpdateCallback = Callback<SteamInventoryDefinitionUpdate_t>.Create(new Callback<SteamInventoryDefinitionUpdate_t>.DispatchDelegate(this.OnSteamInventoryDefinitionUpdate));
		this.steamInventoryResult = SteamInventoryResult_t.Invalid;
		this.steamDetails = null;
	}

	public bool IsItemInInventory(ulong itemSteamId)
	{
		foreach (SteamInventoryItem steamInventoryItem in this.userItems)
			if (steamInventoryItem.steamid == itemSteamId)
				return true;

		return false;
	}

	public ItemsHandler()
	{
		this.requestType = -1;

		this.itemsData = new List<InventoryItemData>();
		this.userItems = new List<SteamInventoryItem>();
		this.newItemsNotifications = new List<SteamInventoryItem>();

		this.itemDictionary = new Dictionary<int, string>
		{
			{ 0, "player.redarc" },
			{ 1, "menutheme.fragout" },
			{ 2, "player.greenarc" },
			{ 3, "player.bluearc" },
			{ 4, "player.arrow" },
			{ 5, "player.goldarc" },
			{ 6, "player.dragon" },
			{ 7, "player.linea" },
			{ 8, "player.deleted" },
			{ 9, "menutheme.idunno" },
			{ 10, "menutheme.melancholicose" },
			{ 11, "menutheme.jamaicanorcdub" },
			{ 12, "menutheme.deleted" },
			{ 13, "player.orangearc" },
			{ 14, "player.yellowarc" },
			{ 15, "player.violetarc" },
			{ 16, "menutheme.coldheat" },
			{ 17, "shader.none" },
			{ 18, "shader.invert" },
			{ 19, "shader.future" },
			{ 20, "shader.pixel" },
			{ 21, "other.dust0" },
			{ 22, "other.dust1" },
			{ 23, "other.dust2" },
			{ 24, "player.lollipop" },
			{ 25, "player.greenlollipop" },
			{ 26, "player.goldlollipop" },
			{ 27, "menutheme.letitbe" },
			{ 28, "shader.frost" },
			{ 29, "player.bat" },
			{ 30, "player.bluebat" },
			{ 31, "player.goldbat" },
			{ 32, "menutheme.hunter" },
			{ 33, "shader.ghost" },
			{ 34, "player.slash" },
			{ 35, "player.redlifering" },
			{ 36, "player.bluelifering" },
			{ 37, "player.greenlifering" },
			{ 38, "player.orangelifering" },
			{ 39, "menutheme.summerbreeze" },
			{ 40, "shader.sunny" },
			{ 41, "player.watermelon" },
			{ 42, "player.goldwatermelon" },
			{ 43, "player.russia" },
			{ 44, "ticket.ticket1" },
			{ 100, "player.mysteryitem" },
			{ 200, "player.mysteryitem" },
			{ 1827589449, "player.neon" },
			{ 1868789888, "player.quantum" },
			{ 1866580677, "player.rgb" },
			{ 1839047562, "player.abstract" },
			{ 1892383279, "player.goldabstract" },
			{ 1892390583, "player.redabstract" },
			{ 1839728983, "player.egglipszerotwo" },
			{ 1889690103, "player.blackwhite" },
			{ 1890098134, "menutheme.27thfloor" },
			{ 1939835450, "player.circle" },
			{ 1937478462, "player.crystal" },
			{ 45, "player.goldcrystal" },
			{ 46, "shader.crispwinter" },
			// MOD: The following 2 arcs are in vanilla, but weren't in this list, don't think it'll hurt to add them
			{ 1941333581, "player.ice" },
			{ 2025747682, "player.fire" }
		};

		this.getRewardURL = "???";
		this.exchangeItemURL = "???";

		this.isLoadeding = true; // USE ALL THE TENSES
	}

	public IEnumerator Init()
	{
		this.itemsData.Clear();
		this.isLoaded = false;

		yield return base.StartCoroutine(this.LoadItems());

		this.UpdatePlayerInventory();
		yield break;
	}

	public int GetInventoryChanges()
		=> this.userItems.Count - Singleton<SaveSystem>.Instance.GetInt("inventory.lastitemscount", 0, null);

	public void TriggerItemDrop()
	{
		this.requestType = 1;
		SteamInventory.TriggerItemDrop(out this.steamInventoryResult, (SteamItemDef_t)0);
	}

	// Deja Vu
	public void UpdateInventoryItem(GameObject inventoryObject, SteamInventoryItem steamInvItem, int itemCount = 1)
	{
		inventoryObject.GetComponent<InventoryListElementButton>().itemData = steamInvItem;
		Transform trans = inventoryObject.transform.Find("ItemNameText");
		if (trans != null)
			trans.GetComponent<Text>().text = steamInvItem.item.name;
		
		trans = inventoryObject.transform.Find("ItemsCountText");
		if (trans != null)
		{
			if (itemCount > 1)
				trans.GetComponent<Text>().text = "x" + itemCount;
			else
				trans.GetComponent<Text>().text = "";
		}

		trans = inventoryObject.transform.Find("InfoCanvas");
		if (trans != null)
		{
			trans.transform.Find("InfoText").GetComponent<Text>().text = string.Concat(new string[]
			{
				steamInvItem.item.description,
				"\n\n• ",
				LocalizationService.Instance.GetTextByKey("rarity").ToUpper(),
				":\n",
				LocalizationService.Instance.GetTextByKey(steamInvItem.item.rarity.ToString().ToLower()).ToUpper()
			});
		}

		Color white = Color.white;
		Color color = Color.black;

		trans = inventoryObject.transform.Find("RarityImage");
		if (trans != null)
		{
			switch (steamInvItem.item.rarity)
			{
				case InventoryItemRarity.Common:
					white = Color.white;
					color = Color.black;
					break;
				case InventoryItemRarity.Rare:
					white = new Color(0.57f, 0.8f, 1f);
					color = Color.white;
					break;
				case InventoryItemRarity.Epic:
					white = new Color(1f, 0.84f, 0f);
					color = Color.white;
					break;
				case InventoryItemRarity.Legendary:
					white = new Color(0.88f, 0.31f, 1f);
					color = Color.white;
					break;
			}
		}
		trans.GetComponent<Image>().color = white;

		trans = inventoryObject.transform.Find("ItemNameText");
		if (trans != null)
			trans.GetComponent<Text>().color = color;
		
		trans = inventoryObject.transform.Find("ItemNameBGImage");
		if (trans != null)
			trans.GetComponent<Image>().color = white;

		trans = inventoryObject.transform.Find("IconImage");
		if (trans != null && !string.IsNullOrEmpty(steamInvItem.item.id) && steamInvItem.item.icon)
			trans.GetComponent<Image>().sprite = steamInvItem.item.icon;

		if (Singleton<SaveSystem>.Instance.GetString("inventory.selected." + steamInvItem.item.type.ToString().ToLower(), "", null) == steamInvItem.item.id)
			inventoryObject.GetComponent<InventoryListElementButton>().isSelected = true;

		inventoryObject.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	private void OnSteamInventoryResultsReady(SteamInventoryResultReady_t invResultReady)
	{
		this.steamInventoryResult = invResultReady.m_handle;

		if (this.requestType == 0)
		{
			if (SteamInventory.GetResultStatus(this.steamInventoryResult) == EResult.k_EResultOK)
			{
				this.requestType = -1;
				uint num = 0U;

				if (SteamInventory.GetResultItems(this.steamInventoryResult, null, ref num))
				{
					this.userItems.Clear();
					this.steamDetails = new SteamItemDetails_t[num];

					SteamInventory.GetResultItems(this.steamInventoryResult, this.steamDetails, ref num);

					this.GetOfflineItems();
					UnityEngine.Debug.Log("[ItemsHandler] Found " + num + " item(s) in inventory");

					List<string> list = new List<string>();
					int i = 0;
					while ((long)i < (long)((ulong)num)) // o_O
					{
						try
						{
							List<SteamInventoryItem> list2 = this.userItems;
							ulong steamItemInstanceID = this.steamDetails[i].m_itemId.m_SteamItemInstanceID;
							List<InventoryItemData> list3 = this.itemsData;
							list2.Add(new SteamInventoryItem(steamItemInstanceID, list3.Find(((InventoryItemData x) => x.id == this.itemDictionary[this.steamDetails[i].m_iDefinition.m_SteamItemDef])), false));
							list.Add(this.steamDetails[i].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							UnityEngine.Debug.LogError("[ItemsHandler] Item not found:" + this.steamDetails[i].m_iDefinition);
						}

						i++;
					}

					string text = string.Join("|", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.GetString("inventory.itemscash", "", null))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("inventory.itemscash", null)))
							Singleton<SaveSystem>.Instance.SetString("inventory.itemscash", text, null);
						else
						{
							UnityEngine.Debug.Log("[ItemsHandler] Inventory has changed");
							try
							{
								List<string> second = Singleton<SaveSystem>.Instance.GetString("inventory.itemscash", null).Split('|').ToList<string>();
								using (List<string>.Enumerator enumerator = list.Except(second).ToList<string>().GetEnumerator())
								{
									while (enumerator.MoveNext())
										this.newItemsNotifications.Add(this.userItems.Find((SteamInventoryItem x) => x.steamid == ulong.Parse(enumerator.Current)));
								}
							}
							catch (Exception) { }

							Singleton<SaveSystem>.Instance.SetString("inventory.itemscash", text, null);
						}
					}
					else
						UnityEngine.Debug.Log("[ItemsHandler] Inventory not changed");
						
					this.isLoadeding = false;
				}
			}
			else
			{
				UnityEngine.Debug.Log("[ItemsHandler] No connection to item server: " + SteamInventory.GetResultStatus(this.steamInventoryResult).ToString());
				this.UpdateLoadingInfo("No connection to item server!");
				this.GetOfflineItems();
				this.isLoadeding = false;
			}

			this.DestroyAllResultsIThink();
			this.CheckInventory();

			this.isLoaded = true;
		}

		if (SteamInventory.GetResultStatus(this.steamInventoryResult) == EResult.k_EResultOK && this.requestType == 1)
		{
			this.requestType = -1;
			uint num2 = 0U;
			
			if (SteamInventory.GetResultItems(this.steamInventoryResult, null, ref num2) && num2 > 0U)
			{
				this.steamDetails = new SteamItemDetails_t[num2];
				SteamInventory.GetResultItems(this.steamInventoryResult, this.steamDetails, ref num2);
				
				this.GetOfflineItems();
				this.UpdatePlayerInventory();
			}
		}
		if (SteamInventory.GetResultStatus(this.steamInventoryResult) == EResult.k_EResultOK && (this.requestType == 2 || this.requestType == 3))
		{
			this.requestType = -1;
			this.UpdatePlayerInventory();
		}
	}

	public void ObtainPromoItems() => base.StartCoroutine(this.CheckForPromoItems());

	public void CheckInventory()
	{
		// This feels, wrong?
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), null))
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), "" + 0, null);

		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), null))
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), "" + 1, null);

		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), null))
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), "" + 17, null);

		string @string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), "" + 0, null);
		if (!this.IsItemInInventory(ulong.Parse(@string)))
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), "" + 0, null);

		@string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), "" + 1, null);
		if (!this.IsItemInInventory(ulong.Parse(@string)))
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), "" + 1, null);

		@string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), "" + 17, null);
		if (!this.IsItemInInventory(ulong.Parse(@string)))
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), "" + 17, null);

		bool common = false;
		bool rare = false;
		bool epic = false;
		foreach (InventoryItemData inventoryItemData in this.itemsData)
		{
			if (inventoryItemData.rarity == InventoryItemRarity.Common)
			{
				common = true;
			}
			else if (inventoryItemData.rarity == InventoryItemRarity.Rare)
			{
				rare = true;
			}
			else if (inventoryItemData.rarity == InventoryItemRarity.Epic)
			{
				epic = true;
			}
			
			if (common && rare && epic)
			{
				Helpers.ObtainAchievement(14);
				break;
			}
		}

		if (Singleton<Scene>.Instance.id == "MenuScene" && UnityEngine.Object.FindObjectOfType<CraftingPanel>())
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().Init();
	}

	private void DestroyAllResultsIThink()
	{
		if (this.steamInventoryResult != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(this.steamInventoryResult);
			this.steamInventoryResult = SteamInventoryResult_t.Invalid;
		}
	}

	public IEnumerator TryGetReward(int rewardIdIThink)
	{
		string text = "" + SteamUser.GetSteamID();
		string value = "" + rewardIdIThink;

		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", text);
		Debug.Log(text);
		wwwform.AddField("itemdefid[0]", value);

		byte[] data = wwwform.data;
		string url = this.getRewardURL;

		WWW www = new WWW(url, data);
		yield return www;

		if (!www.text.ToUpper().Contains("ERROR") && www.error == null)
		{
			string text2 = www.text;
			WebAPIResponse.ItemJson itemJson = null;
			try
			{
				WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
				webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
				webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
				itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
			}
			catch (Exception) { }

			if (itemJson != null && itemJson.items.Count > 0)
			{
				yield return new WaitForSeconds(3f);
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}

			string text3 = www.text;
		}
		else
		{
			Debug.Log(www.text);
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string textBox = "This is broken but you shouldn't be seeing this\n-Dust"; // Original: "Unable to get a reward! Try again?"
			string button1Text = "Yes";
			string button2Text = "No";
			base.StartCoroutine(instance.DisplayDialog(textBox, button1Text, null, button2Text, null)); // Original used obfuscated methods that "didn't exist" in place of these nulls
		}

		yield break;
	}

	public void AddInventoryItemsToList(GameObject tabObjectsIThink, GameObject invItemObjectIThink, GameObject containerProlly)
	{
		Singleton<SaveSystem>.Instance.SetInt("inventory.lastitemscount", Singleton<ItemsHandler>.Instance.userItems.Count, null);
		this.CheckInventory();

		for (int i = 0; i < containerProlly.transform.childCount; i++)
			UnityEngine.Object.Destroy(containerProlly.transform.GetChild(i).gameObject);

		using (List<InventoryItemType>.Enumerator enumerator = this.GetAllTypes().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (this.userItems.Find((SteamInventoryItem x) => x.item.type == enumerator.Current) != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(tabObjectsIThink, Vector3.zero, Quaternion.identity);
					gameObject.transform.SetParent(containerProlly.transform, true);
					gameObject.transform.localScale = new Vector3(1f, 1f, 1f);

					Transform groupNameText = gameObject.transform.Find("Image").Find("GroupNameText");
					if (groupNameText)
					{
						switch (enumerator.Current)
						{
							case InventoryItemType.Player:
								groupNameText.GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("skins").ToUpper();
								break;
							case InventoryItemType.MenuTheme:
								groupNameText.GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("menuthemes").ToUpper();
								break;
							case InventoryItemType.Shader:
								groupNameText.GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("shaders").ToUpper();
								break;
							default:
								groupNameText.GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("other").ToUpper();
								break;
						}
					}

					GameObject gameObject2 = gameObject.transform.Find("InventoryGrid").Find("InventoryContent").gameObject;
					for (int j = 0; j < gameObject2.transform.childCount; j++)
						UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);

					// DEJA VU I FIXED THIS SOMEWHERE ELSE LMFAO
					// This probably means we can remove a bunch of methods from this class, ok. Ima stop cleaning up familiar code then
					Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
					Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
					foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
					{
						if (dictionary.ContainsKey(steamInventoryItem.item.id))
						{
							Dictionary<string, int> dictionary3;
							string id;
							(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 1;
						}
						else
						{
							dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
							dictionary2.Add(steamInventoryItem.item.id, 1);
						}
					}
					foreach (SteamInventoryItem steamInventoryItem2 in from x in dictionary.Values
					orderby x.item.rarity
					select x)
					{
						if (steamInventoryItem2.item.type == enumerator.Current)
						{
							GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(invItemObjectIThink, Vector3.zero, Quaternion.identity);
							gameObject3.transform.SetParent(gameObject2.transform, true);
							gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
							this.UpdateInventoryItem(gameObject3, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
						}
					}
				}
			}
		}
	}

	public ulong EnquippedItem(InventoryItemType inventoryItemType)
	{
		ulong num = 0UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.GetString("inventory.selected." + inventoryItemType.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
			return num;

		if (inventoryItemType != InventoryItemType.Player)
		{
			if (inventoryItemType != InventoryItemType.MenuTheme)
				if (inventoryItemType == InventoryItemType.Shader)
					num = 17UL;
			else
				num = 1UL;
		}
		else
			num = 0UL;

		this.EnquipItem(inventoryItemType, num);

		return num;
	}

	private void OnSteamInventoryDefinitionUpdate(SteamInventoryDefinitionUpdate_t IAFAANLMOAG) { }

	private IEnumerator UpdateItemsIThink(List<SteamInventoryItem> steamInvItems)
	{
		yield return new WaitForSeconds(1f);
		GameObject gameObject = this.newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);

		foreach (SteamInventoryItem inventoryItem in steamInvItems)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.inventoryItemElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, inventoryItem, 1);
		}

		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, true, null, true, 0.2f, true));
		yield break;
	}

	public string GetItemNameByID(int EEBCDMFNKLH)
	{
		return (from x in this.itemDictionary
		where x.Key == EEBCDMFNKLH
		select x).First<KeyValuePair<int, string>>().Value;
	}

	private IEnumerator CheckForPromoItems()
	{
		while (this.requestType != -1)
			yield return new WaitForSeconds(0.1f);

		this.requestType = 2;
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.GrantPromoItems(out steamInventoryResult_t);
		yield break;
	}

	public void UpdateLoadingInfo(string NOJGGCLPPAM)
	{
		GameObject yourMomma = GameObject.Find("LoadingStatusText");
		if (yourMomma != null)
			yourMomma.GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
	}

	public void UpdatePlayerInventory()
	{
		Debug.Log("[ItemsHandler] Loading Steam inventory");
		this.isLoadeding = true;
		try
		{
			this.requestType = 0;
			SteamInventory.GetAllItems(out this.steamInventoryResult);
		}
		catch (Exception)
		{
			this.GetOfflineItems();
			this.isLoaded = true;
		}
	}

	public SteamInventoryItem GetItemBySteamId(ulong itemSteamId)
		=> this.userItems.Find((SteamInventoryItem x) => x.steamid == itemSteamId);

	public List<SteamInventoryItem> GetOnlySteamItemsList()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
			if (!steamInventoryItem.isLocal)
				list.Add(steamInventoryItem);

		return list;
	}

	public void ObtainItem(InventoryItemData invItemData)
	{
		this.requestType = 2;
		
		SteamItemDef_t[] array = new SteamItemDef_t[]
		{
			(SteamItemDef_t)this.itemsData.IndexOf(invItemData)
		};

		SteamInventoryResult_t steamInventoryResult_t;
		
		SteamInventory.GenerateItems(out steamInventoryResult_t, array, null, (uint)array.Length);
	}

	private void OnSteamInventoryFullUpdate(SteamInventoryFullUpdate_t IAFAANLMOAG)
		=> this.steamInventoryResult = IAFAANLMOAG.m_handle;

	public void EnquipItem(InventoryItemType inventoryItemType, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.SetString("inventory.selected." + inventoryItemType.ToString().ToLower(), MOANAJGGPLK.ToString(), null);
		Singleton<SaveSystem>.Instance.Flush();
	}

	[Header("UI")]
	public GameObject newItemsCanvas;
	public GameObject newItemsListContent;

	[Header("References")]
	public GameObject inventoryItemElement;

	private SteamInventoryResult_t steamInventoryResult;
	private SteamItemDetails_t[] steamDetails;

	[HideInInspector]
	public int requestType;

	protected Callback<SteamInventoryResultReady_t> steamInventoryResultReadyCallback;
	protected Callback<SteamInventoryFullUpdate_t> steamInventoryFullUpdateCallback;
	protected Callback<SteamInventoryDefinitionUpdate_t> steamInventoryDefUpdateCallback;

	public List<InventoryItemData> itemsData;
	public List<SteamInventoryItem> userItems;
	public List<SteamInventoryItem> newItemsNotifications;

	private Dictionary<int, string> itemDictionary;
	public static Dictionary<ulong, string> craftRecipes = new Dictionary<ulong, string>
	{
		{
			0UL,
			"22x1"
		},
		{
			1000UL,
			"21x3"
		},
		{
			2000UL,
			"22x3"
		},
		{
			3000UL,
			"23x3"
		},
		{
			21UL,
			"2;13;14;15;16"
		},
		{
			22UL,
			"3;4;9;10;21x6"
		},
		{
			23UL,
			"5;6;7;8;11;12;18;19;20;22x6;44x1"
		}
	};

	public string getRewardURL;
	public string exchangeItemURL;

	public bool isLoaded;

	[HideInInspector]
	public bool isLoadeding;
}
