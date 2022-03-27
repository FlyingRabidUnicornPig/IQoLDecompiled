/*
Importance of this class: Used by Unity.UI.Extensions.AccordionElement (wtf is this obfuscator).
CANNOT DELETE THIS CLASS (yet)

Purpose of this class: AccordianTween, i guess.

Deobf status: Method Params, Members
*/

using System;
using System.Collections;
using UnityEngine;

internal class FGHNFDBDDHM<T> where T : struct, Tween
{
	public void Init(MonoBehaviour IIKBNPGPICN) => this.KAKFICCIFEM = IIKBNPGPICN;

	public void StartTween(T DAGALCAILLN)
	{
		if (this.KAKFICCIFEM == null)
		{
			Debug.LogWarning("Coroutine container not configured... did you forget to call Init?");
			return;
		}
		if (this.KNFPOOFKLCB != null)
		{
			this.KAKFICCIFEM.StopCoroutine(this.KNFPOOFKLCB);
			this.KNFPOOFKLCB = null;
		}
		if (!this.KAKFICCIFEM.gameObject.activeInHierarchy)
		{
			DAGALCAILLN.TweenValue(1f);
			return;
		}
		this.KNFPOOFKLCB = FGHNFDBDDHM<T>.ThisIsNotAJunkMethod(DAGALCAILLN);
		this.KAKFICCIFEM.StartCoroutine(this.KNFPOOFKLCB);
	}

	private static IEnumerator ThisIsNotAJunkMethod(T LHNAHCPGCFH)
	{
		if (!LHNAHCPGCFH.ValidTarget())
		{
			yield break;
		}
		float num = 0f;
		while (num < LHNAHCPGCFH.duration)
		{
			num += ((!LHNAHCPGCFH.ignoreTimeScale) ? Time.deltaTime : Time.unscaledDeltaTime);
			float nmjbjaopjbp = Mathf.Clamp01(num / LHNAHCPGCFH.duration);
			LHNAHCPGCFH.TweenValue(nmjbjaopjbp);
			yield return null;
		}
		LHNAHCPGCFH.TweenValue(1f);
		LHNAHCPGCFH.Finished();
		yield break;
	}

	protected MonoBehaviour KAKFICCIFEM;

	protected IEnumerator KNFPOOFKLCB;
}
