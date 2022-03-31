/*
Importance of this class: Used by PickupItemSimple (Photon)

Purpose of this class: /shrug
*/

using System;
using UnityEngine;

public static class GameObjectExtensions
{
	public static bool GetActive(this GameObject gameObject)
	{
		return gameObject.activeInHierarchy;
	}
}
