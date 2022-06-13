/*
Seems similar to editor code, old shit? Not sure if this is being used
*/

using System;
using UnityEngine;

public class InputToEvent : MonoBehaviour
{
	private void DragEnd(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject hoveredObject = this.GetHoveredObject(OPDCNOOGBIF);
			if (hoveredObject == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage("OnRelease", SendMessageOptions.DontRequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = false;
	}

	private GameObject GetHoveredObject(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 200f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	private void Start()
	{
		this.CMMMNLFGCJB = base.GetComponent<Camera>();
	}

	private void Update()
	{
		if (this.DetectPointedAtGameObject)
		{
			InputToEvent.goPointedAt = this.GetHoveredObject(Input.mousePosition);
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			this.GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				this.DragBegin(touch.position);
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				this.DragEnd(touch.position);
			}
			return;
		}
		this.GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			this.DragBegin(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			this.DragEnd(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			this.GGKIGGBGLOA = Input.mousePosition;
			this.AAEFEIGCJGG = this.GetHoveredObject(this.GGKIGGBGLOA);
			if (this.AAEFEIGCJGG != null)
			{
				this.AAEFEIGCJGG.SendMessage("OnPressRight", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public static GameObject goPointedAt { get; private set; }

	public Vector2 DragVector
	{
		get
		{
			return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
		}
	}

	private void DragBegin(Vector2 OPDCNOOGBIF)
	{
		this.GGKIGGBGLOA = OPDCNOOGBIF;
		this.Dragging = true;
		this.AAEFEIGCJGG = this.GetHoveredObject(OPDCNOOGBIF);
		if (this.AAEFEIGCJGG != null)
		{
			this.AAEFEIGCJGG.SendMessage("OnPress", SendMessageOptions.DontRequireReceiver);
		}
	}

	private GameObject AAEFEIGCJGG;

	public static Vector3 inputHitPos;

	public bool DetectPointedAtGameObject;

	private Vector2 GGKIGGBGLOA = Vector2.zero;
	private Vector2 GMMIPJMMMEI = Vector2.zero;

	public bool Dragging;

	private Camera CMMMNLFGCJB;
}
