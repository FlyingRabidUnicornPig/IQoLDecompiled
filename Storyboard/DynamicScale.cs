/*
Importance of this class: To Suns

Purpose of this class: Automatic scaling of suns based on volume data.
*/

using System;
using AudioVisualizer;
using UnityEngine;

public class DynamicScale : MonoBehaviour
{
	public void Reset()
	{
		this.preScale = 0f;
		this.baseScale = new Vector3(1f, 1f, 1f);
		this.minSize = new Vector3(0f, 0f, 0f);
		this.maxSize = new Vector3(1.5f, 1.5f, 1.5f);

		this.sensitivity = 50f;
		this.lerpSpeed = 1f;

		this.frequencyRange = FrequencyRange.LowMidrange;
		
		this.sun = base.GetComponent<SunController>();
		this.pBase = base.GetComponentInParent<PlayerBase>();
	}

	// Start as small as possible
	private void Start() => base.gameObject.transform.localScale = this.minSize;

	private void Update()
	{
		this.preScale = ((this.sensitivity != 0f) ? this.FindPreScale() : 0f);
		this.FindPostScale();

		if (this.pBase != null)
			this.currentOverflow = this.pBase.comboTimer; // What is combo timer?

		if (this.sun != null)
		{
			this.sun.SetScale(this.postScale);
			return;
		}
		
		// Oh shit you weren't supposed to reach here, uh, just snap to the scale we need to go to
		base.gameObject.transform.localScale = this.postScale;
	}
	public DynamicScale()
	{
		this.baseScale = new Vector3(1f, 1f, 1f);
		this.postScale = default(Vector3);
		this.maxSize = new Vector3(1.5f, 1.5f, 1.5f);
		this.minSize = new Vector3(0f, 0f, 0f);

		this.sensitivity = 50f;
		this.lerpSpeed = 1f;

		this.frequencyRange = FrequencyRange.LowMidrange;
	}

	private float FindPreScale()
	{
		float freqVolume;

		// We should prolly be using this in all cases
		if (this.pBase != null)
		{
			freqVolume = AudioSampler.instance.GetFrequencyVolFor(
				this.audioSource,
				this.frequencyRange,
				this.pBase.gameScene.CurrentTime);
			freqVolume *= sensitivity * this.pBase.GetLifesProgress();
		}
		// Fallback
		else
			freqVolume = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * sensitivity;

		// Limit between 0 and 2.2 scale?
		float finalDestination = Mathf.Clamp(freqVolume, 0f, 2.2f);

		return Helpers.Damp(this.preScale, finalDestination, this.lerpSpeed);
	}

	private void FindPostScale()
	{
		float num = 1f; // Maximum size mod
		float num2 = 0.2f; // Minimum size mod
		Vector3 currentOverflow = new Vector3(this.currentOverflow, this.currentOverflow, this.currentOverflow); // What is overflow?

		this.postScale = Helpers.Clamp(currentOverflow * num2 + this.baseScale * this.preScale, this.minSize, this.maxSize * num);
	}

	public Vector3 maxSize;
	public Vector3 minSize;

	public int audioSource;
	public FrequencyRange frequencyRange;

	public float sensitivity;
	public float lerpSpeed;

	public Vector3 baseScale;
	private float preScale;
	private Vector3 postScale;

	[HideInInspector]
	public float currentOverflow;

	private SunController sun;

	private PlayerBase pBase;
}
