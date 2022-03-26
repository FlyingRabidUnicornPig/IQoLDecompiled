/*
Importance of this class: The base storyboard object class

Purpose of this class: All storyboard objects inherit from this class.
                       Includes basic functions, scale, rotation, position, reset, enable/disable
*/

using System;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
	public virtual void Awake() { }

	public void OnEnable()
	{
		if (this.resetOnStart)
			this.Reset();
	}
	// ^
	// | They're the same method...
	// v
	public void OnDisable()
	{
		if (this.resetOnStart)
			this.Reset();
	}

	public virtual Transform GetChild() => base.transform;

	public virtual void Reset()
	{
		this.targetPosition = new Vector3(0f, 0f, 0f);
		this.targetRotation = new Vector3(0f, 0f, 0f);
		this.targetScale = new Vector3(1f, 1f, 1f);

		this.positionLerpSpeed = 10f;
		this.rotationLerpSpeed = 10f;
		this.scaleLerpSpeed = 10f;
		
		base.transform.localPosition = this.targetPosition;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
		base.transform.localScale = this.targetScale;
	}

	public virtual void SetPosition(Vector3 position) => this.targetPosition = position;

	public virtual void SetRotation(Vector3 rotation) => this.targetRotation = rotation;

	public virtual void SetScale(Vector3 scale) => this.targetScale = scale;

	public EnvironmentController()
	{
		this.resetOnStart = true;

		this.targetPosition = new Vector3(0f, 0f, 0f);
		this.targetRotation = new Vector3(0f, 0f, 0f);
		this.targetScale = new Vector3(1f, 1f, 1f);

		this.positionLerpSpeed = 10f;
		this.rotationLerpSpeed = 10f;
		this.scaleLerpSpeed = 10f;
	}

	public virtual void Update()
	{
		if (base.transform.localPosition != this.targetPosition)
			base.transform.localPosition = Helpers.Damp(base.transform.localPosition, this.targetPosition, this.positionLerpSpeed, Time.deltaTime);

		if (base.transform.localRotation != Quaternion.Euler(this.targetRotation))
			base.transform.localRotation = Helpers.Damp(base.transform.localRotation, Quaternion.Euler(this.targetRotation), this.rotationLerpSpeed, Time.deltaTime);

		if (base.transform.localScale != this.targetScale)
			base.transform.localScale = Helpers.Damp(base.transform.localScale, this.targetScale, this.scaleLerpSpeed, Time.deltaTime);
	}

	public bool resetOnStart;

	public Vector3 targetPosition;
	public Vector3 targetRotation;
	public Vector3 targetScale;

	public float positionLerpSpeed;
	public float rotationLerpSpeed;
	public float scaleLerpSpeed;
}
