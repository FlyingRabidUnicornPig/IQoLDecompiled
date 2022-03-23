/*
Importance of this class:

Purpose of this class: Handles dragging events in editor
*/

using System;
using UnityEngine;

public class DragController : MonoBehaviour
{
	private void Update()
	{
		if (this.isDragging)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition) + this.currentPosition;
			vector.y = base.transform.localPosition.y;

			base.transform.position = new Vector3(this.SnapTimeToBPM(vector.x), vector.y, 0f);
		}
	}

	public void OnDragEnd()
	{
		this.isDragging = false;

		// EWWWWWWWWWW
		this.GetEditorEvent().mapEvent.time = this.SnapTimeToBPM(base.transform.localPosition.x);
		this.GetEditorEvent().UpdateEvent();

		// If we're done dragging a bpm event, update BPM grid to match
		if (this.GetEditorEvent().mapEvent.data[0].Equals("SetBPM"))
			Singleton<MapEditor>.Instance.UpdateBPM(true);
	}

	public void OnDragStart(Vector3 position)
	{
		this.currentPosition = base.transform.position - position;

		this.isDragging = true;
	}

	// EW EW EW EW EW EW EW EW EW EW EW
	// Fucking store the event somewhere.
	// This fucking calls every frame while dragging
	public EditorEvent GetEditorEvent() => base.GetComponent<EditorEvent>();

	// Token: 0x0600CCF4 RID: 52468 RVA: 0x000987C1 File Offset: 0x000969C1
	private float SnapTimeToBPM(float x)
	{
		// Hack that lets bpm events be dragged without snapping (useful for offset adjustments)
		if (this.GetEditorEvent().mapEvent.data[0].Equals("SetBPM"))
			return x;

		return Singleton<MapEditor>.Instance.SnapTimeToBPM(x);
	}

	// Token: 0x0400181E RID: 6174
	private Vector3 yourMomma;

	// Token: 0x0400181F RID: 6175
	private Vector3 currentPosition;

	// Token: 0x04001820 RID: 6176
	private bool isDragging;
}
