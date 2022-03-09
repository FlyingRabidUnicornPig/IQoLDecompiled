/*
Importance of this class: Potentially Important.

Purpose of this class: Likely animation related. I think this is the base Animation class oxy uses.
*/

using System;
using UnityEngine.Events;

[Serializable]
public class AnimationEvent
{
	public float timeout = 1f;

	public UnityEvent OnEvent;
}
