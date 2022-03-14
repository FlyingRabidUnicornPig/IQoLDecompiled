/*
Importance of this class: Mild Importance. Has been modified a few times. 

Purpose of this class: The object used by the main menu to display credits and copyright.
*/

using System;
using UnityEngine;
using UnityEngine.UI;

public class BuildInfo : MonoBehaviour
{
	private void Update() {}

	private void Start()
	{
		// Find values
		this.GameVersion = Helpers.GetGameVersion();
		Text buildText = base.GetComponent<Text>();

		// New Menu-Text
		buildText.text = 
			// Fix copyright
			buildText.text.Replace("2019", "2020") +
			// Add credit
			"\nDust 2020-2022\n" +
			// Game ver
			this.GameVersion;

		// Digging through GameObjects like your doctor dug through your asshole to extract that thing you knew you shouldn't have put up there.
		((GameObject)base.GetComponent<Button>().onClick.GetPersistentTarget(0)).GetComponentInChildren<Text>().text = 
			"Code, design:\n• Oxy949 (Konstantin Kustov)\n• Dust\n\nMaps difficulty algorithm:\n• Dekolator" +
			"\n• Nikl\n\nSpecial thanks:\n• Dymchick1\n• Darina.Wolf\n• English Intralism Team\n\nThanks for playing!\n\nkick a dog";
		
		// Fit text
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public BuildInfo()
	{
		this.GameVersion = string.Empty;
	}

	// Required variable! Intralism cannot load the main menu without this!
	private string GameVersion;
}
