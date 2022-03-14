/*
Importance of this class: Challenges

Purpose of this class: Tell player they are the millionth visitor and have received an award (holy shit that's a
    really good easter egg idea actually. Millionth arc hit for a mod skin? hehehe, future project.)
*/

using System;
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class ChallengesMessage : Singleton<ChallengesMessage>
{
	public IEnumerator ShowMessage(Challenge challenge, string headerText, string challengeInfo)
	{
        // Grab skin icon from resources or online 
		if (!challenge.icon.StartsWith("http")) // From resources
		{
			string text = "challenges/" + challenge.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else // From online?
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challenge.id
                + ".icon", challenge.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challenge.id + ".icon");
		}

		// Set values
        this.progress.value = challenge.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(headerText);
		this.message.text = challengeInfo;

        // Show "Challenge Complete" overlay
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
        yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

    // Container
	public GameObject canvas;

    // Visible Shit
	public Image icon;
	public Slider progress;
	public Text header;
	public Text message;

	public float duration = 2f;
}
