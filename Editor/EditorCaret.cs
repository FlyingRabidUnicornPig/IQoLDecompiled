/*
Importance of this class: Marks the time in the place on the editor

Purpose of this class: Editor Caret
*/

using System;
using UnityEngine;

public class EditorCaret : MonoBehaviour
{
	private void Start()
	{
		this.Editor = Singleton<MapEditor>.Instance;
		this.size = base.transform.localScale;
	}
	public EditorCaret()
	{
		this.lerpSpeed = 5f;
		this.useScale = true;
		this.scaleSize = 1f;
	}

	// Now without asinine if-trees that give the same fruit
	private void Update()
	{
		// Will turn invisible without this? These ifs are wack
		if (this.useScale)
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 30f * this.scaleSize, this.size.y, this.size.z);

		// Idk this needed, is lerpSpeed being modulated like crazy or something? If you don't do this then the caret will spaz out ahead before the camera.
		if (this.lerpSpeed > 0f)
			base.transform.position = new Vector3(this.Editor.currentTime, (float)((this.Editor.currentEventsCanvasId != 0) ? 2 : -2), this.z);
	}

	private MapEditor Editor;

	private Vector3 size;
	public float z;
	public float lerpSpeed;

	public int asourceid;

	public bool moveOnlyWhenPlaying;
	public bool forcePosition;

	public bool useScale;
	public float scaleSize;
	
	// Unused inside joke
	private float stop;
}
