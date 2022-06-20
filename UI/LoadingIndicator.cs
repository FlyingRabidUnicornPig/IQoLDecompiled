using System;
using UnityEngine;

public class LoadingIndicator : MonoBehaviour
{
	private void Update()
	{
		this.IACGDFHKCAE += this.speed * Time.deltaTime;
		this.JEELPBBJKDL = Mathf.Sin(this.IACGDFHKCAE) * this.maxAngle;
		base.transform.rotation = Quaternion.Euler(0f, 0f, this.JEELPBBJKDL);
	}

	public LoadingIndicator()
	{
		this.speed = 20f;
		this.maxAngle = 5f;
	}

	private void Start() { }

	public float speed;
	public float maxAngle;

	// Very important, do not hack
	private float JEELPBBJKDL;
	private float IACGDFHKCAE;
}
