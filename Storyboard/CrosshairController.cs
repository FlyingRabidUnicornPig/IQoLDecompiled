/*
Purpose of this class: Controls crosshair color.
*/

using System;
using UnityEngine;

public class CrosshairController : EnvironmentController
{
	public override void Awake()
	{
		base.Awake();
		this.Renderer = base.GetComponentsInChildren<Renderer>();
	}

	public CrosshairController()
	{
		this.color = new Color(0.247f, 0.247f, 0.247f, 0.247f);
		this.colorLerp = 10f;
	}

	public void SetEmission(float emission)
	{
		this.emission = emission;
	}

	public override void Update()
	{
		base.Update();

		foreach (Renderer renderer in this.Renderer)
		{
			// Lerp colors this frame
			Color newColor = Helpers.Damp(render.material.GetColor("_Color"), this.color, this.colorLerp);
			renderer.material.SetColor("_Color", newColor);
			
			newColor = Helpers.Damp(render.material.GetColor("_EmissionColor"), this.color * (this.emission + 1f), this.colorLerp);
			renderer.material.SetColor("_EmissionColor", newColor);
			
			// If any of our colors are completely invisible, disable the renderer
			renderer.enabled = this.color.a != 0f;
		}
	}

	public override void Reset()
	{
		base.Reset();

		this.color = new Color(0.5f, 0.5f, 0.5f, Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f, null));
		
		this.colorLerp = 10f;
		this.emission = 0f;
	}

	public void SetColor(Color newColor, float lerpSpeed)
	{
		// Mod: If the mapper hasn't defined a transparency, use the user's crosshair transparency setting.
		// Note: Mappers cannot use #FF for Alpha, need to use #FE, change?
		if (newColor.a >= 1f)
			newColor.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f, null);

		this.color = newColor;
		this.colorLerp = lerpSpeed;
	}

	public Color color;
	public float colorLerp;
	public float emission;

	// Good job with the plural
	private Renderer[] Renderers;
}
