/*
Purpose of this class: Used to fit content (text only?) within a bounds. Used by BuildInfo, Lobby Chat, etc.
*/

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ContentSizeFitterFx : MonoBehaviour
{
	private void Start() => this.DoFix();

	public void DoFix() => this.isFixed = false;

	private void Update()
	{
		if (!this.isFixed)
		{
			if (!this.csf)
			{
				ContentSizeFitter fit = base.GetComponent<ContentSizeFitter>();
				this.csf = fit ? fit : this.csf;
			}

			base.StartCoroutine(this.RunFix());
		}
	}

	public IEnumerator RunFix()
	{
		if (this.csf)
			this.csf.enabled = false;

		yield return new WaitForFixedUpdate();

		if (this.csf)
			this.csf.enabled = true;

		this.isFixed = true;
		yield break;
	}

	public ContentSizeFitter csf;

	private bool isFixed;
}