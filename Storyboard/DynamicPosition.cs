/*
Important to Satellites
Purpose of this class: Dynamic positioning class based on audio frequency data
*/

using System;
using AudioVisualizer;
using UnityEngine;

public class DynamicPosition : MonoBehaviour
{
	private void Start()
	{
		this.satellite = base.GetComponentInParent<SatelliteController>();
		this.pBase = base.GetComponentInParent<PlayerBase>();
	}

	private void Update()
	{
		float volumeMulti = (this.sensitivity != 0f) ? (this.GrabVolData() * this.sensitivity) : 0f;
		Vector3 finalDestination = new Vector3(this.radius + 1f * volumeMulti, 0f, 0f);
		base.transform.localPosition = Helpers.Damp(base.transform.localPosition, finalDestination, this.lerpSpeed);
	}

	private float GrabVolData()
	{
		// We should prolly be using this in all cases
		if (this.pBase != null)
			// Remembers audio data this frame for other objects using dynamic positioning on this audio frequency range
			return AudioSampler.instance.GetFrequencyVolFor(
				this.audioSource, this.frequencyRange, this.pBase.gameScene.CurrentTime) * this.sensitivity;
		
		// Fallback, old method that doesn't remember anything
		return AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
	}

	public DynamicPosition()
	{
		this.frequencyRange = FrequencyRange.Decibal;
		this.sensitivity = 2f;
		this.lerpSpeed = 1f;
		this.radius = 2f;
	}

	public int audioSource;

	public FrequencyRange frequencyRange;

	public float sensitivity;
	public float lerpSpeed;
	public float radius;

	// Mod vars
	private SatelliteController satellite; // Unused
	private PlayerBase pBase;
}
