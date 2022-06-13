/*
used for skins possibly
*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreseAlpha : MonoBehaviour
{
	public void SetAmplValue(float amplVal) => this.amplValue = amplVal;

	private void Update()
	{
		if (this.mode == Mode.Emission)
		{
			// num is unused, maybe it was meant to be that 0.0769 num below?
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			
			float num2;

			if (base.transform.localPosition.z < 0f)
				num2 = 0.07692308f * base.transform.localPosition.z + 1f;
			else
				num2 = -0.07692308f * base.transform.localPosition.z + 1f;
			foreach (Material material in this.materials)
			{
				// New version? just seems like you chose the wrong math at some point idfk tho
				if (this.newVersion)
					material.SetFloat("_EmissionGain", Mathf.Lerp(material.GetFloat("_EmissionGain"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 4f));
				else
					material.SetFloat("_EmissionGain", Mathf.Lerp(material.GetFloat("_EmissionGain"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 4f));
			}
		}
		else if (this.mode == Mode.ImageAlpha)
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		else if (this.mode == Mode.TextAlpha)
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
	}

	public void Init()
	{
		this.time = 5f;

		foreach (Material material in this.materials)
			material.SetFloat("_EmissionGain", this.maxAlpha);
	}

	public void SetMaxAlpha(float maxAlph) => this.maxAlpha = maxAlph;

	private void Start()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			foreach (Material material in renderer.materials)
				if (material.HasProperty("_EmissionGain"))
					this.materials.Add(material);
		}
	}

	public bool newVersion;
	public Mode mode;
	public float time = 0.4f;
	public float maxAlpha = 1f;
	public float amplValue = 1.75f;
	private List<Material> materials = new List<Material>();
}
