/*
Importance of this class: Seems to be unused, possibly previously used for menu copyright text?

Purpose of this class: Dynamic text? Why?
*/

using System;
using UnityEngine;
using UnityEngine.UI;

public class DynamicTextInfo : MonoBehaviour
{
	public DynamicTextInfo()
	{
		this.id = string.Empty;
	}

	private void Update() { }
	
	private void Start()
	{
		if (this.id == "menu.copyright")
		{
			Text component = base.GetComponent<Text>();
			component.text = component.text + "\n" + Helpers.GetGameVersion();
		}
	}

	public string id;
}
