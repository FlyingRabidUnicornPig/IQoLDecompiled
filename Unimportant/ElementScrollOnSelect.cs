/*
Importance of this class: /shrug

Purpose of this class: unknown, can delete without crashing Intralism, may be fine to remove
*/

using System;
using UnityEngine;

public class ElementScrollOnSelect : MonoBehaviour
{
	public void Select()
	{
		ScrollRectScrollTo yourMum = base.GetComponentInParent<ScrollRectScrollTo>();
		if (yourMum != null)
			yourMum.CenterToItem(base.GetComponent<RectTransform>());
	}
}
