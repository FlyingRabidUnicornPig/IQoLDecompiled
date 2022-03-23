/*
Seems to be unused fuck this garbo.
Possibly previous version of crosshair movement or something else /shrug
*/

using System;
using UnityEngine;

public class DynamicHightZoom : MonoBehaviour
{
	private void Update()
	{
		base.transform.localScale = new Vector3(base.transform.localScale.x, Camera.main.orthographicSize * this.scale, base.transform.localScale.z);
	}

	private void Start() { }

	public DynamicHightZoom()
	{
		this.scale = 5f;
	}

	public float scale;
}
