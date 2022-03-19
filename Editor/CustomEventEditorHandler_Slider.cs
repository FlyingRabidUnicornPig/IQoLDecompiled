/*
Purpose of this class: The slider selector in the EventEditor (bad for most things oxy used it for...)
*/

using System;
using System.Globalization;
using UnityEngine.UI;

public class CustomEventEditorHandler_Slider : CustomEventEditorHandler
{
	public override void Init(string data, string advancedParams)
	{
		base.Init(data, advancedParams);
		
		// Find/set min/max and whether using whole/decimal
		float minValue = 0f;
		float.TryParse(this.advParametrs[0], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out minValue);
		this.input.minValue = minValue;

		float maxValue = 1f;
		float.TryParse(this.advParametrs[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out maxValue);
		this.input.maxValue = maxValue;

		bool wholeNumbers = false;
		bool.TryParse(this.advParametrs[2], out wholeNumbers);
		this.input.wholeNumbers = wholeNumbers;

		// Set cutformat
		string cutFormat = this.advParametrs.Count > 3 ? cutFormat = this.advParametrs[3] : "0.00";
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		
		// Find and set default value
		float value = 0f;
		float.TryParse(data, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	public override string GetEditedData() => "" + this.input.value;

	public Slider input;
}
