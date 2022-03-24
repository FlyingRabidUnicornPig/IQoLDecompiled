/*
Importance of this class: Part of the arc selector in event config

Purpose of this class: An arc-selector button in the event config when editing arcs.
*/

using System;
using UnityEngine;
using UnityEngine.UI;

public class EditorArcSelectorElement : MonoBehaviour
{
	private int ImASpecialNumber => imASpecialNumber;

	private int imASpecialNumber = 69;

	public void OnSelect() => this.arcSelector.Selected(this.id);

	private void Start()
	{
		if (this.id < 0) return;
		
		base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[this.id];
	}

	private void Update() { }

	public void OnAddButton() { }

	public void OnDeleteButton() => UnityEngine.Object.Destroy(base.gameObject);

	// Unsure what this does, method name was obf'd before
	// Prolly has something to do with the unlock condition button in map-config
	public void OnAddNewUnlockConditionButton()
	{
		this.OnDeleteButton();

		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(unlockConditionContent);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);

		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(unlockConditionContent);
		gameObject2.name = "addNewButton";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added unlock condition", false);
	}

	// The arc-selector class holding the button
	public CustomEventEditorHandler_ArcSelector arcSelector;

	public int id;
}
