// weird debug class?

using System;
using AudioVisualizer;
using UnityEngine;

public class LogOnTriggrEnter : MonoBehaviour
{
	private void OnTriggerEnter(Collider yoMomma)
	{
		Debug.Log(this.asampler.audioSources[1].time);
	}

	private void Start() { }
	private void Update() { }

	public AudioSampler asampler;
}
