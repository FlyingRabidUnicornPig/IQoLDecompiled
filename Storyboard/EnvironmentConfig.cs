/*
Importance of this class: Used by a single line in PlayerBase.Update() and it maybe overriden by something else now...

Purpose of this class: To turn suns red when they lose color. Idunno if this is used by suns anymore, idon't think so.
*/

using System;
using UnityEngine;

public class EnvironmentConfig : MonoBehaviour
{
	public Color maxLivesColor = new Color(0.654902f, 0.8784314f, 0.9843137f);

	public Color zeroLivesColor = new Color(1f, 0f, 0f);
}
