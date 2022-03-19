/*
Purpose of this class: The text box in the EventEditor
*/

using System;
using System.Globalization;
using UnityEngine.UI;

public class CustomEventEditorHandler_InputField : CustomEventEditorHandler
{
	public override void Init(string data, string advancedParams)
	{
		base.Init(data, advancedParams);
		if (!this.advParametrs.Contains("float"))
		{
			this.input.text = ((!string.IsNullOrEmpty(data)) ? data : advancedParams);
			return;
		}

		// If number-only box, make it so
		this.input.contentType = InputField.ContentType.DecimalNumber;

		// Find the default number then set it
		float num = float.Parse(this.advParametrs[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo);
		
		// Not sure what this is for tho
		if (!string.IsNullOrEmpty(data))
			float.TryParse(data, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out num);

		this.input.text = "" + num;
			
	}

	public override string GetEditedData() => this.input.text;

	public InputField input;
}
