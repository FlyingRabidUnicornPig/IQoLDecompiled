/*
Importance of this class: VERY IMPORTANT

Purpose of this class: The non-visual part of the EventEditor, changes events, builds the UI, etc.

Deobf status: Method param's need addressing
*/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x02000397 RID: 919
public class CustomEventEditor : MonoBehaviour
{
	public virtual void Start() {}
	public virtual void Update() {}

	public void StartEditing() => this.isEditing = true;
	public void StopEditing() => this.isEditing = false;

	public virtual void Apply()
	{
		List<string> list = GetDataFromCurrentEvent();

		// Modify current event from data
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		Singleton<UI>.Instance.ClearSelection();
	}

	public void OnEditedCustomEventFunction()
	{
		MapEditor editor = Singleton<MapEditor>.Instance;
		if (!editor.IsMapLoaded()) return;

		// Use the current id on the drop down to determine how to modify the event
		// TODO: fucking make the drop down a member of this class or something. Getter it, idc just stop wasting so much text to find it.
		this.ChangeEventFunction(editor.eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>().SelectedItem.ID, null);
	}

	private List<string> GetDataFromCurrentEvent()
	{
		List<string> list = new List<string>();
		list.Add(this.eventID);

		// Copy event data from EventEditor
		string text = string.Empty;
		foreach (CustomEventEditorHandler ceeh in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
			text += ceeh.GetEditedData() + ",";

		// Remove ending comma and add to list.
		if (!string.IsNullOrEmpty(text))
			list.Add(text.Remove(text.Length - 1));
		
		return list;
	}

	public virtual void CopyEvent() => this.data = GetDataFromCurrentEvent();

	public virtual void PasteEvent()
	{
		if (this.editorEvent != null) return;

		this.editorEvent.mapEvent.data = this.data;
		this.eventID = this.editorEvent.mapEvent.data[0];

		this.RebuildEditor(true);
	}

	public virtual void Load(EditorEvent evnt)
	{
		if (evnt != null) return;

		this.editorEvent = evnt;
		this.eventID = editorEvent.mapEvent.data[0];

		this.RebuildEditor(true);
	}

	public void ChangeEventFunction(string functionName, EditorEvent whyIsThisAThingFuck = null)
	{
		if (this.eventID == functionName) return;
		
		this.eventID = functionName;

		this.RebuildEditor(false);
	}

	public void RebuildEditor(bool fullRedraw = true)
	{
		Singleton<UI>.Instance.ClearSelection();

		// Reset everything
		for (int i = 0; i < this.content.transform.childCount; i++)
			UnityEngine.Object.Destroy(this.content.transform.GetChild(i).gameObject);

		EditorEventFunctionInfo eeFuncInfo = Helpers.eventsMap.Find(x => x.id == this.eventID);

		if (eeFuncInfo != null)
			RebuildEditor(eeFuncInfo);

		if (fullRedraw && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.editorEvent != null)
			DoFullRebuild();
			
	}

	// TODO: Store all possibilities in memory and retrieve from them so we only call this once per eventtype per editor-launch
	//       Rebuilding literally fucking every time is lazy and unoptimized and garbo.
	private void RebuildEditor(EditorEventFunctionInfo eeFuncInfo)
	{
		GameObject gameObject2 = null;
		
		// Draw event description
		if (eeFuncInfo.functionDescription != null)
		{
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-Text"), Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.content.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<Text>().text = eeFuncInfo.functionDescription;
			gameObject2.GetComponent<Text>().fontSize += 4;
			gameObject2.name = eeFuncInfo.functionName + "Description";
		}

		// Draw each parameter
		foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in eeFuncInfo.parameters)
		{
			// Draw Parameter name
			if (!string.IsNullOrEmpty(editorEventParametr.name))
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-Text"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(this.content.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + ":";
				gameObject2.name = editorEventParametr.name + "Text";
			}

			// Draw parameter (slider, text input, etc.)
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.content.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;

			// Name it (NameParameter)
			gameObject2.name = editorEventParametr.name + editorEventParametr.editor.ToString();

			// Init event
			try
			{
				string text = this.editorEvent.mapEvent.data[1];
				// Not sure what this if is for. Seems like it could complicate things /shrug
				// Does it need to be a loop adding every element 'sides the first?
				if (this.editorEvent.mapEvent.data.Count > 2)
					text += "," + this.editorEvent.mapEvent.data[2];

				// Find which one is the current parameter
				string needsHandling = text.Split(',')[eeFuncInfo.parameters.IndexOf(editorEventParameter)];
				if (!string.IsNullOrEmpty(needsHandling))
					gameObject2.GetComponent<CustomEventEditorHandler>().Init(needsHandling, editorEventParametr.data);
			}
			catch (Exception)
			{
				gameObject2.GetComponent<CustomEventEditorHandler>().Init(string.Empty, editorEventParametr.data);
			}

			// Add description
			if (!string.IsNullOrEmpty(editorEventParametr.description))
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-Text"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(this.content.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				gameObject2.name = editorEventParametr.name + "Description";
			}
		}
	}

	private void DoFullRebuild()
	{	
		// Reset dropdown
		DropDownList dropDown = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>();
		dropDown.Items.Clear();

		bool isStoryboard = Helpers.IsStoryboardEvent(this.editorEvent.mapEvent.data[0]);
		
		// Find events in same category
		List<EditorEventFunctionInfo> list =
			(from x in Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion)
			where IsIDInSameCategory(x.id)
			select x)
		.ToList<EditorEventFunctionInfo>();

		// Add each event to dropdown
		foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
		{
			dropDown.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
		}
		
		// Reset dropdown
		dropDown.SelectItem(0, true);
		dropDown.RebuildPanel();
		dropDown.RedrawPanel();
		dropDown.SelectItem(list.IndexOf(list.Find(x => x.id == this.editorEvent.mapEvent.data[0])), true);

		// Paste the time in the time box
		Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text = string.Empty + this.editorEvent.mapEvent.time;
	}

	// Used when finding what events to display in the drop down box.
	// TODO: Store the event lists somewhere. first time we run IsStoryboardEvent, just store all the events of each kind elsehwere.
	//       Put this note on IsStoryboardEvent() itself
	private bool IsIDInSameCategory(string id)
		=> Helpers.IsStoryboardEvent(id) == Helpers.IsStoryboardEvent(this.editorEvent.mapEvent.data[0]);

	public GameObject content;

	private EditorEvent editorEvent;
	private string eventID;
	private List<string> data;

	public bool isEditing;
}
