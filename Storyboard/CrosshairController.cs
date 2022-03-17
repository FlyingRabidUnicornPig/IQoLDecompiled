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
		this.Renderers = base.GetComponentsInChildren<Renderer>();
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

		foreach (Renderer renderer in this.Renderers)
		{
			// FIX: If mapper wants to make a color fully transparent or back again it'll instantly snap to in/visible, bad.
			//      Vanilla code assumnes only user setting will change crosshair.
			//      Track current colors outside of forloop to fix?
			renderer.enabled = this.color.a != 0f;

			// If there is something of value to draw, draw the crosshair
			if (renderer.enabled)
			{
				// Lerp colors this frame
				Color lerpedColor = Helpers.Damp(renderer.material.GetColor("_Color"), this.color, this.colorLerp);
				renderer.material.SetColor("_Color", lerpedColor);

				lerpedColor = Helpers.Damp(renderer.material.GetColor("_EmissionColor"), this.color * (this.emission + 1f), this.colorLerp);
				renderer.material.SetColor("_EmissionColor", lerpedColor);
			}
		}
	}

	public override void Reset()
	{
		base.Reset();

		// Why do Reset()s and Constructors never match?
		this.color = new Color(0.5f, 0.5f, 0.5f, Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f, null));
		
		this.colorLerp = 10f;
		this.emission = 0f;
	}

	public void SetColor(Color newColor, float lerpSpeed)
	{
		// Mod: If the mapper hasn't defined a transparency, use the user's crosshair transparency setting.
		// NOTE: Mappers cannot use #FF for Alpha, need to use #FE, change implementation?
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
