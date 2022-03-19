/*
Purpose of this class: Used to select arcs in EventEditor
*/

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CustomEventEditorHandler_ArcSelector : CustomEventEditorHandler
{
	public void UpdatePreview()
	{
		this.previewImage.sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[this.index]; // Store the sprites elsewhere?
	}

	public void Selected(int index)
	{
		this.index = index;
		this.UpdatePreview();
		this.ClosePanel();
	}

	public override string GetEditedData()
	{
		this.data = Helpers.patternsMap[this.index];
		return string.Empty + this.data;
	}

	public void OpenPanel()
	{
		this.selectorPanel.SetActive(true);
		this.MakeOtherShitVisible(false);
		this.CreateArcs();
	}

	public void ClosePanel()
	{
		this.selectorPanel.SetActive(false);
		this.MakeOtherShitVisible(true);
	}

	private void CreateArcs()
	{
		GameObject content = this.selectorPanelContent;

		// Reset
		for (int i = 0; i < content.transform.childCount; i++)
			UnityEngine.Object.Destroy(content.transform.GetChild(i).gameObject);

		for (int j = 0; j < Resources.LoadAll<Sprite>("LevelEditor/patterns").Count<Sprite>(); j++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.selectorPanelElement);
			gameObject2.name = "element";
			gameObject2.transform.SetParent(content.transform);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<EditorArcSelectorElement>().id = j;
			gameObject2.GetComponent<EditorArcSelectorElement>().arcSelector = this;
		}
	}

	public override void Init(string data, string advancedParams)
	{
		base.Init(data, advancedParams);
		
		// Mod: Setup better panel than vanilla
		this.selectorPanel.transform.localScale *= new Vector2(1f, 4f);
		this.selectorPanelContent.transform.localScale *= new Vector2(1f, 0.25f);
		
		this.index = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(x => x.Contains(data)));
		
		this.UpdatePreview();
	}

	// Mod: Hides/Reveals the text and slider for the hand selector. Allows the arc-selector to be large without shitty UI or a hard hack
	private void MakeOtherShitVisible(bool visible)
	{
		// Mod: Prep hand-selector if it's not ready yet
		if (this.sliderHack == null)
		{
			this.sliderHack = new GameObject[3];
			this.sliderHack[0] = base.transform.parent.Find("handText").gameObject;
			this.sliderHack[1] = base.transform.parent.Find("handSlider").gameObject;
			this.sliderHack[2] = base.transform.parent.Find("handDescription").gameObject;
		}

		for (int i = 0; i < this.sliderHack.Length; i++)
			this.sliderHack[i].SetActive(visible);
	}

	public Image previewImage;

	public GameObject selectorPanel;
	public GameObject selectorPanelContent;
	public GameObject selectorPanelElement;

	private int index;

	private GameObject[] sliderHack;
}
