using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class InventoryItemData
{
	public InventoryItemData()
	{
		this.name = "No Name";
		this.description = "No Description";
	}

	public InventoryItemData(string id)
	{
		this.name = "No Name";
		this.description = "No Description";
		InventoryItemData inventoryItemData = JsonConvert.DeserializeObject<InventoryItemData>(Resources.Load<TextAsset>("Items/" + id + "/config").text);
		this.id = inventoryItemData.id;
		this.name = inventoryItemData.name;
		this.description = inventoryItemData.description;
		this.type = inventoryItemData.type;
		this.rarity = inventoryItemData.rarity;
		this.icon = Resources.Load<Sprite>("Items/" + id + "/icon");
	}

	public int GetItemInventoryID() =>
		Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex((string x) => x == this.id);

	public string id;
	public string name;
	public string description;
	public Sprite icon;
	public InventoryItemType type;
	public InventoryItemRarity rarity;
}
