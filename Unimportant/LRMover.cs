// I think this may be a remnant from Linea?

using System;
using UnityEngine;

public class LRMover : MonoBehaviour
{
	public LRMover()
	{
		this.multiply = 3f;
		this.mspeed = 50f;
		this.lrspeed = 1f;
		this.axis = "X";
	}

	private void Start()
	{
		this.position = base.transform.localPosition;

		this.axis = this.axis.ToUpper();
		
		if (this.useRandomSpeed)
			this.lrspeed = UnityEngine.Random.Range(0.1f, 5f);
		if (this.useRandomDirection && UnityEngine.Random.Range(0f, 1f) >= 0.5f)
			this.lrspeed = -this.lrspeed;
	}

	private void Update()
	{
		this.speedThisFrame += Time.deltaTime * this.lrspeed;
		foreach (char c in this.axis.ToCharArray())
		{
			if (c == 'X')
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(0f, 0f, -1f) * this.mspeed + new Vector3(this.position.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 0f, 0f), Time.deltaTime);
			else if (c == 'Y')
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(0f, 0f, -1f) * this.mspeed + new Vector3(0f, this.position.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 0f), Time.deltaTime);
			else if (c == 'Z')
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.position.x, this.position.y, this.position.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
			return; // I'm assuming only X, Y, or Z is being inputted into axis, unlike vanilla code, wait why am i fixing this shit?
		}

		// Should this be above the return?
		if (this.speedThisFrame >= 6.2831855f)
			this.speedThisFrame = 0f;
	}

	private float speedThisFrame;

	public float multiply;

	public float mspeed;

	public float lrspeed;

	public bool useRandomDirection;

	public bool useRandomSpeed;

	public string axis;

	private Vector3 position;
}
