/*
Skin loader
*/

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadImageFromSkin : MonoBehaviour
{
	private void OnEnable()
	{
		if (!this.loadedSkin)
			base.StartCoroutine(this.LoadSkin());
	}

	private IEnumerator LoadSkin()
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + this.imageID, this.imageID, false));
		base.GetComponent<Image>().sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + this.imageID);

		this.loadedSkin = true;
		yield break;
	}

	public string imageID;
	private bool loadedSkin;
}
