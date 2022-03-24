/*
Purpose of this class: The arc selector in map/track editor, not config editor

Deobf status: Update() needs more cleaning in readability, make more methods
*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EditorArcsSelector : Singleton<EditorArcsSelector>
{
	private bool IsAltPressed       => Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);
	private bool IsControlPressed   => Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
	private bool IsModButtonPressed => IsAltPressed || IsControlPressed;

	private void Update()
	{
		this.DrawSelectionBox();
		
		bool isPointerOverObject = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !isPointerOverObject && !this.IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.AreYouWinningSon, 100f, this.arcsLayerMask))
			{
				this.IsSelecting = true;
				this.selectionBoxPanel.sizeDelta = new Vector2(0f, 0f);
				this.ResetSelectionBoxAnimation();
			}
			else if (this.AreYouWinningSon.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !IsModButtonPressed)
			{
				this.IsDraggingObj = true;

				for (int i = 0; i < this.selectedunits.Count; i++)
					this.selectedunits[i].GetComponent<EditorEvent>().dragController.OnDragStart(this.MousePositionInWorld);
			}
		}

		if (this.IsSelecting && Input.GetMouseButtonUp(0))
		{
			this.PutUnitsFromDragIntoSelectedUnits();
			this.IsSelecting = false;
			ResetSelectionBoxAnimation();
		}

		// If we're not currently dragging
		if (!this.IsDraggingObj)
		{
			// If the mouse clicked and not on an object
			if (Input.GetMouseButtonDown(0) && !isPointerOverObject)
			{
				this.WorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				SelectArcs();
			}

			// This confuses me
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.AreYouWinningSon, 100f, this.arcsLayerMask) && this.AreYouWinningSon.transform.gameObject.GetComponentInParent<EditorEvent>() && IsAltPressed && this.selectedunits.Contains(this.AreYouWinningSon.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				this.selectedunits.Remove(this.AreYouWinningSon.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				this.AreYouWinningSon.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected = false;
			}

			this.MousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			// Not sure why these are all members and not local vars
			if (this.IsSelecting)
				FigureOutBoundsOfSelectionBox();
		}
		// If we're dragging objects, maybe? Idfk i hate this class
		else
		{
			this.MousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if (Input.GetMouseButtonDown(0) && !isPointerOverObject)
				this.WorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				
			if (Input.GetMouseButtonUp(0))
			{
				this.IsDraggingObj = false;

				for (int l = 0; l < this.selectedunits.Count; l++)
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();

				Singleton<MapEditor>.Instance.FindNearestEvent(true);

				Singleton<EditorHistoryHandler>.Instance.SaveState("Events Moved", false);
			}
		}
	}

	private void FigureOutBoundsOfSelectionBox()
	{
		this.ScreenPointX = Camera.main.WorldToScreenPoint(this.WorldPoint).x - Camera.main.WorldToScreenPoint(this.MousePositionInWorld).x;
		this.ScreenPointY = Camera.main.WorldToScreenPoint(this.WorldPoint).y - Camera.main.WorldToScreenPoint(this.MousePositionInWorld).y;
			
		this.MousePositionX = Input.mousePosition.x;
		this.MousePositionY = (float)Screen.height - Input.mousePosition.y - this.ScreenPointY;

		this.MousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

		if (this.ScreenPointX < 0f)
			this.MousePosition.x += this.ScreenPointX;
		if (this.ScreenPointY > 0f)
			this.MousePosition.y += this.ScreenPointY;
					
		this.CombinedMouseAndScreenIDFK = new Vector2(this.MousePosition.x + Math.Abs(this.ScreenPointX), this.MousePosition.y - Math.Abs(this.ScreenPointY));
				
	}

	private void SelectArcs()
	{
		// We need to get rid of this garbage. Why are we removing every event and reselecting them every frame fucking garbage
		if (!IsControlPressed)
			ResetCurrentSelection();

		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.AreYouWinningSon, 100f, this.arcsLayerMask))
		{
			// If not pressing alt, add the most recent collider to the selected units
			if (!IsAltPressed)
			{
				this.selectedunits.Add(this.AreYouWinningSon.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				this.selectedunits[this.selectedunits.Count - 1].GetComponent<EditorEvent>().isSelected = true;
			}
		}
	}

	private void LateUpdate()
	{
		this.UnitInDrag.Clear();
		for (int i = 0; this.IsSelecting && i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			
			if (!this.UnitInDrag.Contains(gameObject))
			{
				if (this.UnitWithinDrag(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
				{
					gameObject.GetComponent<EditorEvent>().isSelected = !IsAltPressed;
					if (!IsAltPressed)
						this.UnitInDrag.Add(gameObject);
				}
				else if (!IsControlPressed)
				{
					gameObject.GetComponent<EditorEvent>().isSelected = false;
				}
			}
		}
	}

	public void PasteFromMemory(float currentTime)
	{
		this.ClearSelection();

		if (this.savedEvents == null || this.savedEvents.Count <= 0) return;
		
		float time = this.savedEvents[0].time;

		foreach (MapEvent mapEvent2 in this.savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(currentTime + (mapEvent2.time - time), mapEvent2.data, false);
			this.selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().isSelected = true;
		}
		
		Singleton<EditorHistoryHandler>.Instance.SaveState("Paste events", false);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	public void SelectAll()
	{
		this.ClearSelection();
		
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			gameObject.GetComponent<EditorEvent>().isSelected = true;
			this.selectedunits.Add(gameObject);
		}
	}

	public bool UnitWithinScreenSpace(Vector2 unit)
	{
		return unit.x < (float)Screen.width && unit.y < (float)Screen.height && unit.x > 0f && unit.y > 0f;
	}

	public bool UnitWithinDrag(Vector2 unit)
	{
		return unit.x > this.MousePosition.x && unit.y < this.MousePosition.y && unit.x < this.CombinedMouseAndScreenIDFK.x && unit.y > this.CombinedMouseAndScreenIDFK.y;
	}

	private void DrawSelectionBox()
	{
		if (this.IsSelecting)
		{
			Vector2 vector = new Vector2(this.MousePositionX, -this.MousePositionY);
			Vector2 vector2 = new Vector2(this.MousePositionX + this.ScreenPointX, -this.MousePositionY - this.ScreenPointY);
			float x = (vector.x >= vector2.x) ? vector2.x : vector.x;
			float y = (vector.y <= vector2.y) ? vector2.y : vector.y;
			float x2 = Mathf.Abs(this.ScreenPointX);
			float y2 = Mathf.Abs(this.ScreenPointY);
			this.selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			this.selectionBoxPanel.anchorMin = new Vector2(0f, 1f);
			this.selectionBoxPanel.anchorMax = new Vector2(0f, 1f);
			this.selectionBoxPanel.pivot = new Vector2(0f, 1f);
			this.selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public void PutUnitsFromDragIntoSelectedUnits()
	{
		if (this.UnitInDrag.Count > 0)
		{
			for (int i = 0; i < this.UnitInDrag.Count; i++)
			{
				if (!this.selectedunits.Contains(this.UnitInDrag[i]))
				{
					this.selectedunits.Add(this.UnitInDrag[i]);
				}
			}
		}
		this.UnitInDrag.Clear();
	}

	public void SaveSelectedToMemory()
	{
		this.savedEvents.Clear();
		for (int i = 0; i < this.selectedunits.Count; i++)
		{
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void ClearSelection()
	{
		this.IsSelecting = false;
		this.ResetSelectionBoxAnimation();
		this.IsDraggingObj = false;
		this.PutUnitsFromDragIntoSelectedUnits();
		ResetCurrentSelection();
	}

	public void ResetCurrentSelection()
	{
		for (int i = 0; i < this.selectedunits.Count; i++)
			this.selectedunits[i].GetComponent<EditorEvent>().isSelected = false;
		
		this.selectedunits.Clear();
	}

	private void ResetSelectionBoxAnimation()
	{
		if (this.SelectionBoxAnimation != null)
		{
			base.StopCoroutine(this.SelectionBoxAnimation);
		}
		this.SelectionBoxAnimation = base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 0.2f, true));
	}

	public List<MapEvent> savedEvents;

	public RectTransform selectionBoxPanel;

	public LayerMask arcsLayerMask;

	public List<GameObject> selectedunits = new List<GameObject>();
	private RaycastHit AreYouWinningSon;

	private Vector3 WorldPoint;
	private Vector3 MousePositionInWorld;

	public bool IsSelecting;
	public bool IsDraggingObj;

	private float ScreenPointX;
	private float ScreenPointY;
	private float MousePositionX;
	private float MousePositionY;
	private Vector2 MousePosition;
	private Vector2 CombinedMouseAndScreenIDFK;

	public List<GameObject> UnitsOnScreenSpace = new List<GameObject>();
	public List<GameObject> UnitInDrag = new List<GameObject>();

	private Coroutine SelectionBoxAnimation;
}
