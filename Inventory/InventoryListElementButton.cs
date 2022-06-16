using System;
using AudioVisualizer;
using UnityEngine;

public class InventoryListElementButton : MonoBehaviour
{
	public void OnClick()
	{
		if (this.itemData.item.type == InventoryItemType.Ticket)
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + this.itemData.steamid));
		
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Ticket)
		{
			this.isSelected = true;
			
			this.UpdateBadge();

			if (this.itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip audioClip = Resources.Load<AudioClip>("Items/" + this.itemData.item.id + "/theme");
				GameObject.Find("AudioSampler").GetComponent<AudioSampler>().Init(audioClip, 0f, true);
			}

			if (this.itemData.item.type == InventoryItemType.Shader)
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().Init();
		}
	}

	private void RefreshSelected()
	{
		if (this.selectedBadge != null)
			this.selectedBadge.SetActive(this.isSelected);
	}

	public void UpdateBadge()
	{
		if (this.isSelected)
			Singleton<ItemsHandler>.Instance.EnquipItem(this.itemData.item.type, this.itemData.steamid);

		RefreshSelected();
	}

	public void Update()
	{
		if (this.itemData != null && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Ticket)
			this.isSelected = (Singleton<ItemsHandler>.Instance.EnquippedItem(this.itemData.item.type) == this.itemData.steamid);

		RefreshSelected();
	}

	public void ToggleInfo()
	{
		if (this.infoCanvas != null)
			this.infoCanvas.SetActive(!this.infoCanvas.activeSelf);
	}

	public SteamInventoryItem itemData;
	public GameObject infoCanvas;
	public GameObject selectedBadge;
	public bool isSelected;
}
