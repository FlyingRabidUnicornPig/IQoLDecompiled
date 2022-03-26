/*
Purpose of this class: Handles the History of the Editor.

Other notes: Buggy as fucking shit
*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditorHistoryHandler : Singleton<EditorHistoryHandler>
{
	private void UpdateButtons()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.CanUndo();
		this.redoButton.interactable = this.CanRedo();

		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	private void OnUndo()
	{
		Singleton<MapEditor>.Instance.SetEditedData(this.history[this.state].data);

		this.UpdateButtons();
	}

	public void Undo()
	{
		if (this.CanUndo())
		{
			this.state--;
			this.OnUndo();
		}
	}

	public bool CanUndo() => this.state > 0;

	public string GetCurrentStateString()
	{
		string result = "";
		if (this.GetHistoryLength() > 0)
			result = "[" + this.history[this.state].time.ToString("HH:mm:ss") + "] " + this.history[this.state].comment;

		return result;
	}

	public void Clear()
	{
		this.state = 0;
		this.savedHistoryState = 0;

		this.history.Clear();

		this.UpdateButtons();
	}

	public void OnMapSaved()
	{
		this.savedHistoryState = this.state;
		
		this.UpdateButtons();
	}

	public EditorHistoryHandler()
	{
		this.history = new List<EditorHistoryHandler.HistoryStep>();
	}

	public void Redo()
	{
		if (this.CanRedo())
		{
			this.state++;
			this.OnUndo();
		}
	}

	public bool CanRedo() => this.GetHistoryLength() - 1 > this.state;

	public void Start() => this.Clear();

	public void SaveState(string comment = null, bool keepHistory = false)
	{
		if (keepHistory)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), comment));
		}
		else
		{
			if (this.state < this.history.Count - 1)
				this.history.RemoveRange(this.state + 1, this.history.Count - this.state - 1);

			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), comment));
			this.state++;
		}

		this.UpdateButtons();
	}

	public int GetHistoryLength() => this.history.Count;

	public int state;

	public int savedHistoryState;

	public List<EditorHistoryHandler.HistoryStep> history;

	[Header("UI")]
	public Button saveButton;
	public Button undoButton;
	public Button redoButton;

	[Serializable]
	public class HistoryStep
	{
		public HistoryStep(DateTime time, MapData mapData, string comment = null)
		{
			this.time = time;
			this.data = new MapData(mapData);
			this.comment = comment;
		}

		public DateTime time;

		[HideInInspector]
		public MapData data;

		public string comment;
	}
}
