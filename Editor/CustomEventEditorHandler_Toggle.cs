/*
Purpose of this class: The toggle selector in the EventEditor (on/off button)
*/

using System;
using UnityEngine.UI;

public class CustomEventEditorHandler_Toggle : CustomEventEditorHandler
{
	public override string GetEditedData() => "" + this.input.isOn;

	public override void Init(string data, string advancedParams)
	{
		base.Init(data, advancedParams);

		bool isOn = false;
		bool.TryParse(data, out isOn);
		this.input.isOn = isOn;

		if (this.advParametrs.Count > 0)
			base.GetComponentInChildren<Text>().text = this.advParametrs[0];
	}

	public Toggle input;
}
