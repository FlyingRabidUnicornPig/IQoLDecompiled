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
		bool mouseRelease = Input.GetMouseButtonUp(0);
		bool isPointerOverObject = !mouseRelease && EventSystem.current.IsPointerOverGameObject();
		bool didNotClickObject = !mouseRelease && Input.GetMouseButtonDown(0) && !isPointerOverObject;
		bool raycastHit = mouseRelease || didNotClickObject 
			? Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.AreYouWinningSon, 100f, this.arcsLayerMask)
			: false;
		EditorEvent hoveredEvent = !raycastHit ? null : AreYouWinningSon.transform.gameObject.GetComponentInParent<EditorEvent>();

		this.MousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (didNotClickObject)
		{
			if (!this.IsSelecting)
			{
				// If we didn't click on a selected object, start selecting
				if (!raycastHit)
				{
					this.IsSelecting = true;
					this.selectionBoxPanel.sizeDelta = new Vector2(0f, 0f);
					this.ResetSelectionBoxAnimation();
				}
				// If we click on an already selected object, start dragging wait shouldn't this be impossible? (it is if you do hoveredEvent != null at start /shrug)
				else if (hoveredEvent.IsSelected && !IsModButtonPressed)
				{
					this.IsDraggingObj = true;

					for (int i = 0; i < this.selectedunits.Count; i++)
						this.selectedunits[i].GetComponent<EditorEvent>().dragController.OnDragStart(this.MousePositionInWorld);
				}
			}

			this.WorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			// if not dragging (only clicking)
			if (!this.IsDraggingObj)
			{
				// We need to get rid of this garbage. Why are we removing every event and reselecting them every frame fucking garbage
				if (!IsControlPressed)
					ResetCurrentSelection();

				// If not pressing alt, add the most recent collider to the selected units
				if (raycastHit && !IsAltPressed)
				{
					hoveredEvent.IsSelected = true;
					this.selectedunits.Add(hoveredEvent.gameObject);
				}
			}
		}
		// Else if the frame we release the mouse
		else if (mouseRelease)
		{
			// If we were drag-selecting arcs, add them to selected units list
			if (this.IsSelecting)
			{
				this.PutUnitsFromDragIntoSelectedUnits();
				this.IsSelecting = false;
				ResetSelectionBoxAnimation();
			}

			// If pressing alt, unselect hovered event
			if (IsAltPressed && raycastHit && this.selectedunits.Contains(hoveredEvent.gameObject))
			{
				this.selectedunits.Remove(hoveredEvent.gameObject);
				hoveredEvent.IsSelected = false;
			}

			// If dragging, stop dragging
			if (this.IsDraggingObj)
			{
				this.IsDraggingObj = false;

				for (int l = 0; l < this.selectedunits.Count; l++)
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();

				Singleton<MapEditor>.Instance.FindNearestEvent(true);

				Singleton<EditorHistoryHandler>.Instance.SaveState("Events Moved", false);
			}
		}
		// If we're selecting, figure out bounds of box
		else if (this.IsSelecting && !this.IsDraggingObj)
			FigureOutBoundsOfSelectionBox();
		
		// Draw the box *this frame* (was on a single frame delay before by being first line of this method)
		this.DrawSelectionBox();
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
					
		this.StartPoint = new Vector2(this.MousePosition.x + Math.Abs(this.ScreenPointX), this.MousePosition.y - Math.Abs(this.ScreenPointY));
				
	}

	// Adds all arcs to selected list
	private void LateUpdate()
	{
		bool lastWithin = false;
		bool outside = false;
		for (int i = 0; this.IsSelecting && i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
		{
			GameObject unit = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;

			bool withinBounds = this.UnitWithinDrag(Camera.main.WorldToScreenPoint(unit.transform.position));

			// optimization shit, figuring out if we've iterated out of the bounds (after iterating into them)
			outside = !withinBounds && lastWithin;
			EditorEvent fuckYou = unit.GetComponent<EditorEvent>();

			if (outside && !fuckYou.IsSelected) break; // Mod: Shitty stop, better performance earlier in the map than later, bad bad
			                                           // At best, next to no penalty while dragging (we want this all the time) at worst, same fps drops as before
			// Within bounds? add it
			if (!outside && withinBounds)
			{
				fuckYou.IsSelected = !IsAltPressed;

				if (!IsAltPressed && !this.UnitInDrag.Contains(unit))
					this.UnitInDrag.Add(unit);
			}
			// Otherwise unadd it
			else if (!IsControlPressed)
			{
				fuckYou.IsSelected = false;
				this.UnitInDrag.Remove(unit);
			}
			
			lastWithin = withinBounds || outside;
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
			gameObject.GetComponent<EditorEvent>().IsSelected = true;
		}
		
		Singleton<EditorHistoryHandler>.Instance.SaveState("Paste events", false);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	public void SelectAll()
	{		
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			gameObject.GetComponent<EditorEvent>().IsSelected = true;
			if (!selectedunits.Contains(gameObject))
				this.selectedunits.Add(gameObject);
		}
	}
	public EditorArcsSelector()
	{
		this.selectedunits = new List<GameObject>();
		this.UnitInDrag = new List<GameObject>();
	}

	public bool UnitWithinScreenSpace(Vector2 unit)
	{
		return unit.x < (float)Screen.width && unit.y < (float)Screen.height && unit.x > 0f && unit.y > 0f;
	}

	public bool UnitWithinDrag(Vector2 unit)
	{
		return unit.x > this.MousePosition.x && unit.y < this.MousePosition.y && unit.x < this.StartPoint.x && unit.y > this.StartPoint.y;
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
		for (int i = 0; i < this.UnitInDrag.Count; i++)
			if (!this.selectedunits.Contains(this.UnitInDrag[i]))
				this.selectedunits.Add(this.UnitInDrag[i]);

		this.UnitInDrag.Clear();
	}

	public void SaveSelectedToMemory()
	{
		this.savedEvents.Clear();
		
		for (int i = 0; i < this.selectedunits.Count; i++)
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
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
			this.selectedunits[i].GetComponent<EditorEvent>().IsSelected = false;
		
		this.selectedunits.Clear();
	}

	private void ResetSelectionBoxAnimation()
	{
		if (this.SelectionBoxAnimation != null)
			base.StopCoroutine(this.SelectionBoxAnimation);

		this.SelectionBoxAnimation =
			base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 0.2f, true));
	}

	public List<MapEvent> savedEvents;

	public RectTransform selectionBoxPanel;

	public LayerMask arcsLayerMask;

	public List<GameObject> selectedunits;
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
	private Vector2 StartPoint;

	// Unused
	public List<GameObject> UnitsOnScreenSpace;
	public List<GameObject> UnitInDrag;

	private Coroutine SelectionBoxAnimation;
}
