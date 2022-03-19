/*
Importance of this class: Vital to Event Editing.

Purpose of this class: Seems to be base class for the visual paramter functions
*/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomEventEditorHandler : MonoBehaviour
{
	public CustomEventEditorHandler()
	{
		this.data = string.Empty;
	}

	public virtual string GetEditedData() => this.data;

	public virtual void Update() {}

	public virtual void Init(string data, string advancedParams = null)
	{
		this.data = data;
		if (!string.IsNullOrEmpty(advancedParams))
			this.advParametrs = advancedParams.Split(',').OfType<string>().ToList<string>();
	}

	public EditorEventFunctionInfo.EditorEventParametr currentParametr;
	public string data;
	public List<string> advParametrs;
}
