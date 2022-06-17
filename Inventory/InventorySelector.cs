/*
Inventory Menu
TODO: Console window pops up *behind* the Inventory
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySelector : Singleton<InventorySelector>
{
	public void UpdateInventoryItem(GameObject gameObject, SteamInventoryItem inventoryItem, int itemCount = 1)
	{
		gameObject.GetComponent<InventoryListElementButton>().itemData = inventoryItem;
		
		Transform trans = gameObject.transform.Find("ItemNameText");
		if (trans != null)
			trans.GetComponent<Text>().text = inventoryItem.item.name;

		trans = gameObject.transform.Find("ItemsCountText");
		if (trans != null)
		{
			if (itemCount > 1)
				trans.GetComponent<Text>().text = "x" + itemCount;
			else
				trans.GetComponent<Text>().text = string.Empty;
		}

		trans = gameObject.transform.Find("InfoCanvas");
		if (trans)
		{
			trans.transform.Find("InfoText").GetComponent<Text>().text = string.Concat(new string[]
			{
				inventoryItem.item.description,
				"\n\n• ",
				LocalizationService.Instance.GetTextByKey("rarity").ToUpper(),
				":\n",
				LocalizationService.Instance.GetTextByKey(inventoryItem.item.rarity.ToString().ToLower()).ToUpper()
			});
		}
		
		Color color = Color.white;
		Color color2 = Color.black;
		trans = gameObject.transform.Find("RarityImage");
		if (trans != null)
		{
			switch (inventoryItem.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("#91CCFF");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1f, 0.84f, 0f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(0.88f, 0.31f, 1f);
				color2 = Color.white;
				break;
			}
			trans.GetComponent<Image>().color = color;
		}

		trans = gameObject.transform.Find("ItemNameText");
		if (trans != null)
			trans.GetComponent<Text>().color = color2;

		trans = gameObject.transform.Find("ItemNameBGImage");
		if (trans != null)
			trans.GetComponent<Image>().color = color;
		
		trans = gameObject.transform.Find("ItemNameBGImage").Find("IconImage");
		if (trans != null && !string.IsNullOrEmpty(inventoryItem.item.id) && inventoryItem.item.icon != null)
			trans.GetComponent<Image>().sprite = inventoryItem.item.icon;

		gameObject.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	// NOTE: Don't fix this name, the misspelling is engrained somewhere we can't edit
	public void SwichCategory(int category)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		
		if (category >= 0)
			this.currentCategory = (InventoryItemType)category;

		this.AddInventoryItemsToList(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	public IEnumerator DisplayInventory(UnityAction action = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		
		if (action != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(action);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(this.CloseInventory));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		
		yield return true;
		yield break;
	}

	public void CloseInventory()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, false, null, true, 0.2f, true));
	}

	public void AddInventoryItemsToList(InventoryItemType itemType, GameObject itemElement, GameObject itemContent)
	{
		this.SetSelectedTab();

		for (int i = 0; i < itemContent.transform.childCount; i++)
			UnityEngine.Object.Destroy(itemContent.transform.GetChild(i).gameObject);

		// Sort user's inventory by rarity (thenby id to prevent dupes)
		List<SteamInventoryItem> inventory = Singleton<ItemsHandler>.Instance.userItems.OrderBy(x => x.item.rarity).ThenBy(x => x.item.id).ToList();
		SteamInventoryItem lastItemChecked = inventory[0];
		int itemCount = 0;

		// Go through every item in the user's inventory
		foreach (SteamInventoryItem steamInvItem in inventory)
		{
			// If we're done with counting this item
			if (lastItemChecked.item.id != steamInvItem.item.id)
			{
				// If the item is part of the currently selected category, add it to UI
				if (lastItemChecked.item.type == itemType)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(itemElement, Vector3.zero, Quaternion.identity);
					gameObject.transform.SetParent(itemContent.transform, true);
					this.UpdateInventoryItem(gameObject, lastItemChecked, itemCount);
				}

				// Reset values
				lastItemChecked = steamInvItem;
				itemCount = 0;
			}

			// Count
			itemCount++;
		}
	}

	// Token: 0x0600F406 RID: 62470 RVA: 0x0050C0E4 File Offset: 0x0050A2E4
	private void SetSelectedTab()
	{
		foreach (GameObject gameObject in this.tabs)
			gameObject.GetComponent<UITab>().IsSelected = (this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
	}

	// Token: 0x0600F411 RID: 62481 RVA: 0x000A045B File Offset: 0x0009E65B
	public bool IsActive() => this.inventoryCanvas.activeSelf;

	// Token: 0x04001F6E RID: 8046
	public Button buttonBack;

	// Token: 0x04001F6F RID: 8047
	public GameObject inventoryCanvas;

	// Token: 0x04001F70 RID: 8048
	public List<GameObject> tabs;

	// Token: 0x04001F71 RID: 8049
	public GameObject inventoryContent;

	// Token: 0x04001F72 RID: 8050
	public GameObject inventoryItemElement;

	// Token: 0x04001F73 RID: 8051
	public InventoryItemType currentCategory;
}
