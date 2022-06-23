/*
Plays logos after Unity splash/loading before main menu
I need to stop deleting classes I think are unused,
 this doesn't seemed used according to dnspy but it clearly is.
 Maybe I should save the vanilla .dll in the repo
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LogoAnimation : MonoBehaviour
{
	public void Init()
	{
		foreach (global::AnimationEvent animationEvent in this.events)
			base.StartCoroutine(this.PlayLogo(animationEvent.OnEvent, animationEvent.timeout));
	}

	private IEnumerator PlayLogo(UnityEvent animation, float animation)
	{
		yield return new WaitForSeconds(animation);
		animation.Invoke();
		yield break;
	}

	private void Update() { }

	public List<global::AnimationEvent> events;
}
