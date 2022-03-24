/*
Importance of this class: Messages, Chat, and potentially other objects use this to fade in/out

Purpose of this class: Simple in-out animation class

Deobf status: Method Params need deobf, need cleanup
*/

using System;
using UITween;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000235 RID: 565
[Serializable]
public class EasyTween : MonoBehaviour
{
	// Token: 0x06008A1C RID: 35356 RVA: 0x00082061 File Offset: 0x00080261
	public void SetAnimationProperties(AnimationParts KEMAFNIOEFC)
	{
		this.animationParts = KEMAFNIOEFC;
		this.currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	// Token: 0x06008A1F RID: 35359 RVA: 0x00082096 File Offset: 0x00080296
	private void Update()
	{
		this.currentAnimationGoing.AnimationFrame(this.rectTransform);
	}

	// Token: 0x06008A22 RID: 35362 RVA: 0x00082053 File Offset: 0x00080253
	public void SetFade(bool FOJONHLNAOM)
	{
		this.currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	// Token: 0x06008A25 RID: 35365 RVA: 0x000820DE File Offset: 0x000802DE
	public void OpenCloseObjectAnimation()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.CloseOpenAnimation();
	}

	// Token: 0x06008A2A RID: 35370 RVA: 0x000820F7 File Offset: 0x000802F7
	public void SetAnimationRotation(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x06008A31 RID: 35377 RVA: 0x00082157 File Offset: 0x00080357
	public void CloseObjectAnimation()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.currentAnimationGoing.PlayCloseAnimations();
	}

	// Token: 0x06008A38 RID: 35384 RVA: 0x000821BC File Offset: 0x000803BC
	public void SetUnscaledTimeAnimation(bool HCAIOLGHFNN)
	{
		this.animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	// Token: 0x06008A3F RID: 35391
	public EasyTween()
	{
		this.animationParts = new AnimationParts(AnimationParts.State.CLOSE, false, false, false, AnimationParts.EndTweenClose.DEACTIVATE, AnimationParts.CallbackCall.NOTHING, new UnityEvent(), new UnityEvent());
		this.Init();
	}

	// Token: 0x06008A47 RID: 35399 RVA: 0x00082089 File Offset: 0x00080289
	public bool IsObjectOpened()
	{
		return this.currentAnimationGoing.IsObjectOpened();
	}

	// Token: 0x06008A4F RID: 35407 RVA: 0x000820A9 File Offset: 0x000802A9
	public void SetAnimationScale(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x06008A62 RID: 35426
	private void CloseOpenAnimation()
	{
		if (!this.currentAnimationGoing.IsObjectOpened())
		{
			this.currentAnimationGoing.PlayOpenAnimations();
		}
		else
		{
			this.currentAnimationGoing.PlayCloseAnimations();
		}
	}

	// Token: 0x06008A69 RID: 35433 RVA: 0x00082388 File Offset: 0x00080588
	private void Start()
	{
		AnimationParts.OnDisableOrDestroy += this.OnDisableOrDestroy;
	}

	// Token: 0x06008A6A RID: 35434 RVA: 0x00082144 File Offset: 0x00080344
	private void LateUpdate()
	{
		this.currentAnimationGoing.LateAnimationFrame(this.rectTransform);
	}

	// Token: 0x06008A6D RID: 35437
	private void OnDisableOrDestroy(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != this.animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			this.rectTransform.gameObject.SetActive(false);
		}
		else
		{
			if (base.gameObject && !this.rectTransform.gameObject == base.gameObject)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			UnityEngine.Object.DestroyImmediate(this.rectTransform.gameObject);
		}
	}

	// Token: 0x06008A73 RID: 35443 RVA: 0x0008229D File Offset: 0x0008049D
	public void SetAnimationPosition(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationPos(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, this.rectTransform);
	}

	// Token: 0x06008A74 RID: 35444 RVA: 0x00082046 File Offset: 0x00080246
	public float GetAnimationDuration()
	{
		return this.currentAnimationGoing.GetAnimationDuration();
	}

	// Token: 0x06008A76 RID: 35446 RVA: 0x000823B9 File Offset: 0x000805B9
	public void SetFadeStartEndValues(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		this.currentAnimationGoing.SetFadeValuesStartEnd(NGHFGPKHIPP, HHABIDFFNCK);
	}

	// Token: 0x06008A7B RID: 35451 RVA: 0x000823DB File Offset: 0x000805DB
	private void OnDestroy()
	{
		AnimationParts.OnDisableOrDestroy -= this.OnDisableOrDestroy;
	}

	// Token: 0x06008A87 RID: 35463 RVA: 0x0008232F File Offset: 0x0008052F
	public void OpenObjectAnimation()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.currentAnimationGoing.PlayOpenAnimations();
	}

	// Token: 0x06008A8D RID: 35469 RVA: 0x00082465 File Offset: 0x00080665
	public void SetAnimatioDuration(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 0f)
		{
			this.currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			this.currentAnimationGoing.SetAniamtioDuration(0.01f);
		}
	}

	// Token: 0x06008AA0 RID: 35488
	private void Init()
	{
		if (this.currentAnimationGoing == null)
		{
			this.SetAnimationProperties(this.animationParts);
		}
	}

	// Token: 0x06008AA3 RID: 35491 RVA: 0x0008242A File Offset: 0x0008062A
	public void SetFade()
	{
		this.currentAnimationGoing.SetFade(false);
	}

	// Token: 0x06008AA8 RID: 35496 RVA: 0x0008237A File Offset: 0x0008057A
	public void ChangeSetState(bool CIOKILFKPHF)
	{
		this.currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	// Token: 0x04000FCA RID: 4042
	public RectTransform rectTransform;

	// Token: 0x04000FCB RID: 4043
	public AnimationParts animationParts;

	// Token: 0x04000FCC RID: 4044
	private CurrentAnimation currentAnimationGoing;
}
