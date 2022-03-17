/*
Purpose of this class: Used to fit content (text only?) within a bounds. Used by BuildInfo, Lobby Chat, etc.
                       It's basically Unity's ContentSizeFitter with an extra bit that stops it constantly fitting- for some reason...
*/

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ContentSizeFitterFx : MonoBehaviour
{
	private void Start() => this.RequestFix();

	public void RequestFix() => this.isFixed = false;

	private void Update()
	{
		// If a fix is requested, do the fix
		if (!this.isFixed)
			base.StartCoroutine(this.RunFix());
	}

	// Not entirely sure what this does. Seems it disables the content fitter to reset it?
	public IEnumerator RunFix()
	{
		// Oxy coulda made csf local, but no, he had to split up this code over multiple methods...
		// It is optimized for the second call tho, which is only done by chat messages (actually chat maybe why this class exists)
		if (!this.csf)
			csf = base.GetComponent<ContentSizeFitter>();

		// Disable
		if (this.csf)
			this.csf.enabled = false;

		// Wait a frame
		yield return new WaitForFixedUpdate();
		
		// Reenable, reset
		if (this.csf)
			this.csf.enabled = true;

		this.isFixed = true;
		yield break;
	}

	public ContentSizeFitter csf;

	private bool isFixed;
}