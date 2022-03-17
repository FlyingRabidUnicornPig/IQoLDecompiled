/*
Importance of this class: Probably none

Purpose of this class: Unused Mouse-related animation? Nothing references this idc

Deobf status: Fuck this
*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200022D RID: 557
public class ClickedWaveAnimation : MonoBehaviour
{
	// Token: 0x06008A3E RID: 35390 RVA: 0x0033E128 File Offset: 0x0033C328
	public GameObject AOAAAAIFIHP()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A3F RID: 35391 RVA: 0x0008211F File Offset: 0x0008031F
	private void ECBILENEOOL()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.GFGDPNACMBG(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A40 RID: 35392 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject ECNLNGCMIDG()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A41 RID: 35393 RVA: 0x00082149 File Offset: 0x00080349
	private void FDNONDCGGCG()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.INPIOKFFDND(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A42 RID: 35394 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject MHBKFIMMOJP()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A43 RID: 35395 RVA: 0x0033E268 File Offset: 0x0033C468
	private void LLDHEJIEDHO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.AHLOGMPKGHL();
			if (gameObject)
			{
				this.GPIOEIOMOHA(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A44 RID: 35396 RVA: 0x0033E2A0 File Offset: 0x0033C4A0
	private void MENMHCBMHJD(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.LIFAHJFIOMO();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(676f, 1764f, 1967f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1925f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1748f;
			a.z = 70f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	// Token: 0x06008A45 RID: 35397 RVA: 0x0033E3AC File Offset: 0x0033C5AC
	private void IKIDIJLIGOH()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.KMMJOPLLPLK();
			if (gameObject)
			{
				this.BOJJNHOLFIF(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A46 RID: 35398 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject CMFDFPDOCCD()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A47 RID: 35399 RVA: 0x0033E484 File Offset: 0x0033C684
	private void DPIPGGDNGHN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.NJJPKMBOMHJ();
			if (gameObject)
			{
				this.EJGENEGGPME(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A48 RID: 35400 RVA: 0x0033E4BC File Offset: 0x0033C6BC
	private void BGFJOEPFOPM()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.ILGGAMKKFMK();
			if (gameObject)
			{
				this.FLCPKLOHAMB(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A49 RID: 35401 RVA: 0x0033E4F4 File Offset: 0x0033C6F4
	private void GPIOEIOMOHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.OJLOOIEONGI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1362f, 789f, 1029f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 642f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 937f;
			a.z = 779f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	// Token: 0x06008A4A RID: 35402 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject LIDGJHMNAPK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A4B RID: 35403 RVA: 0x0033E600 File Offset: 0x0033C800
	private void DEEPMOLMGED()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.MDMAPECMEBL();
			if (gameObject)
			{
				this.GGFBMANAJJL(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A4C RID: 35404 RVA: 0x0033E638 File Offset: 0x0033C838
	private void NDMHMHMDHHJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.PHCHNMBHCNC();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1817f, 25f, 224f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 113f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 423f;
			a.z = 1635f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	// Token: 0x06008A4D RID: 35405 RVA: 0x00082173 File Offset: 0x00080373
	private void LIBGAKMKHJJ()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.CreatePool(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A4E RID: 35406 RVA: 0x0033E744 File Offset: 0x0033C944
	private void JAAJECBCCFM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.MIBCACOOKOK();
			if (gameObject)
			{
				this.CDIJAMDPAJB(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A4F RID: 35407 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject FCJEPGJIPAB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A50 RID: 35408 RVA: 0x0033E128 File Offset: 0x0033C328
	public GameObject NJJPKMBOMHJ()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A51 RID: 35409 RVA: 0x0033E77C File Offset: 0x0033C97C
	private void OBAEDJJDCPN()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.PPIPLPMEFJK();
			if (gameObject)
			{
				this.PFOKPJMHNOH(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A52 RID: 35410 RVA: 0x00082173 File Offset: 0x00080373
	private void CGDMLHLJIDK()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.CreatePool(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A53 RID: 35411 RVA: 0x0033E7B4 File Offset: 0x0033C9B4
	private void EJGENEGGPME(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.HDNMHMBPICA();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(389f, 571f, 920f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1734f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1449f;
			a.z = 781f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	// Token: 0x06008A54 RID: 35412 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject AFGDGMALKDA()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A55 RID: 35413 RVA: 0x00082149 File Offset: 0x00080349
	private void JDKHBGDEONK()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.INPIOKFFDND(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A56 RID: 35414 RVA: 0x0008219D File Offset: 0x0008039D
	private void DBLILJGKGHJ()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.IKGMFIAMHNL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A57 RID: 35415 RVA: 0x0008211F File Offset: 0x0008031F
	private void ICILLMAKLMI()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.GFGDPNACMBG(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A58 RID: 35416 RVA: 0x0033E8C0 File Offset: 0x0033CAC0
	private void FCNBDNMMAML(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.PODGFKFAFBN();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1622f, 1058f, 1684f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 813f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 37f;
			a.z = 458f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	// Token: 0x06008A59 RID: 35417 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject UiHitted()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A5A RID: 35418 RVA: 0x000821C7 File Offset: 0x000803C7
	private void JONGNKNLLND()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.EPINJLOBFJD(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A5B RID: 35419 RVA: 0x0033E9CC File Offset: 0x0033CBCC
	private void OEENOOGEEHD()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.AJBBGJBDGIN();
			if (gameObject)
			{
				this.CEODKENENEC(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A5C RID: 35420 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject AHLOGMPKGHL()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A5D RID: 35421 RVA: 0x0033EA04 File Offset: 0x0033CC04
	private void EPJJDKJEDMM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.PFFGHBKALAD();
			if (gameObject)
			{
				this.DHCDCDAILLM(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A5E RID: 35422 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject EHABLMNLLBD()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A5F RID: 35423 RVA: 0x000821F1 File Offset: 0x000803F1
	private void AEOLJEIDMDB()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.NJAEONDJHCD(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A60 RID: 35424 RVA: 0x0008211F File Offset: 0x0008031F
	private void KLILJHJNICK()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.GFGDPNACMBG(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A61 RID: 35425 RVA: 0x0008221B File Offset: 0x0008041B
	private void HPFOFGJPNCI()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.DOPLKFDBGAM(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A62 RID: 35426 RVA: 0x0033EA3C File Offset: 0x0033CC3C
	private void DEDEFDBGOFH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.LIFAHJFIOMO();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(330f, 1234f, 3f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1576f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1564f;
			a.z = 1391f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008A63 RID: 35427 RVA: 0x000821F1 File Offset: 0x000803F1
	private void NNFMIAFHMJM()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.NJAEONDJHCD(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A64 RID: 35428 RVA: 0x0033EB48 File Offset: 0x0033CD48
	private void DNENFLNCIJP()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.AHLOGMPKGHL();
			if (gameObject)
			{
				this.BOJJNHOLFIF(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A65 RID: 35429 RVA: 0x00082245 File Offset: 0x00080445
	private void NPLCENPNJBM()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.ABBHFBOBILM(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A66 RID: 35430 RVA: 0x0033EB80 File Offset: 0x0033CD80
	private void IOFBEKPNMAM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.LPIBIMBHPKB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(920f, 1225f, 784f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1253f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1967f;
			a.z = 219f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	// Token: 0x06008A67 RID: 35431 RVA: 0x0033EC8C File Offset: 0x0033CE8C
	private void CDIJAMDPAJB(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.HDJPELJGKGO();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(813f, 741f, 1512f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 473f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1249f;
			a.z = 311f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	// Token: 0x06008A68 RID: 35432 RVA: 0x0033ED98 File Offset: 0x0033CF98
	private void CEODKENENEC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.ODGKJOMBBPJ();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1240f, 209f, 834f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 50f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1419f;
			a.z = 1557f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	// Token: 0x06008A69 RID: 35433 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject AJBBGJBDGIN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A6A RID: 35434 RVA: 0x0033EEA4 File Offset: 0x0033D0A4
	private void HMNLHMLILKD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.HOJGGMNNCDA();
			if (gameObject)
			{
				this.JPGCKMEEGCP(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A6B RID: 35435 RVA: 0x0033EEDC File Offset: 0x0033D0DC
	private void PFOKPJMHNOH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.KABEIEDMAJK();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1101f, 1323f, 586f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 728f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1930f;
			a.z = 1945f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	// Token: 0x06008A6C RID: 35436 RVA: 0x0033EFE8 File Offset: 0x0033D1E8
	private void LKJMIODJGCM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.MIFCGKMPJIL();
			if (gameObject)
			{
				this.FCNBDNMMAML(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A6D RID: 35437 RVA: 0x0008219D File Offset: 0x0008039D
	private void DKEHGPPOKEA()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.IKGMFIAMHNL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A6E RID: 35438 RVA: 0x00082173 File Offset: 0x00080373
	private void AEMGPJDJGBJ()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.CreatePool(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A6F RID: 35439 RVA: 0x0033F020 File Offset: 0x0033D220
	private void FLCPKLOHAMB(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.MFONOACAODI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1934f, 1228f, 1144f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1690f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 962f;
			a.z = 1692f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	// Token: 0x06008A70 RID: 35440 RVA: 0x0033F12C File Offset: 0x0033D32C
	private void DBBHOGGMMCC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.NNMEAEKODCB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1869f, 568f, 1412f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 381f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1567f;
			a.z = 1122f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	// Token: 0x06008A71 RID: 35441 RVA: 0x0008226F File Offset: 0x0008046F
	private void IKDNLHLBHID()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.OBPKKILBADL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A72 RID: 35442 RVA: 0x00082299 File Offset: 0x00080499
	private void FIJHDKIPENG()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.JBNMLKGMFFA(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A73 RID: 35443 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject PCAEILIIEAK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A74 RID: 35444 RVA: 0x0033F238 File Offset: 0x0033D438
	public GameObject EKOHHBHAMND()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A75 RID: 35445 RVA: 0x0033F2D8 File Offset: 0x0033D4D8
	private void JBNPEHMDCMI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.ECNLNGCMIDG();
			if (gameObject)
			{
				this.JMMABGLJNMF(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A76 RID: 35446 RVA: 0x0033F310 File Offset: 0x0033D510
	private void NFEDLAOPHML()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.LIDGJHMNAPK();
			if (gameObject)
			{
				this.OMKBADJMDMJ(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A77 RID: 35447 RVA: 0x000822C3 File Offset: 0x000804C3
	private void KDMANOEMOCA()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.AJMEEHEFDLL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A78 RID: 35448 RVA: 0x0033F348 File Offset: 0x0033D548
	private void HEEOBEGPJGO(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.KABEIEDMAJK();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(834f, 961f, 1041f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 847f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1937f;
			a.z = 1494f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	// Token: 0x06008A79 RID: 35449 RVA: 0x000822ED File Offset: 0x000804ED
	private void CNGAJDBOCLJ()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.OCIHAKKPJOE(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A7A RID: 35450 RVA: 0x0033E128 File Offset: 0x0033C328
	public GameObject MIBCACOOKOK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A7B RID: 35451 RVA: 0x0033F454 File Offset: 0x0033D654
	private void OMKBADJMDMJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.KBKMDALIBJC();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(252f, 1736f, 842f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1687f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1291f;
			a.z = 851f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().BAGJNDODMCP();
		}
	}

	// Token: 0x06008A7C RID: 35452 RVA: 0x0033F560 File Offset: 0x0033D760
	private void AEIJFLJEABG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.PNJMNJPHDAM();
			if (gameObject)
			{
				this.HEEOBEGPJGO(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A7D RID: 35453 RVA: 0x0033F598 File Offset: 0x0033D798
	private void GPFJMKCGHGB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.LIDGJHMNAPK();
			if (gameObject)
			{
				this.GGFBMANAJJL(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A7E RID: 35454 RVA: 0x0033F5D0 File Offset: 0x0033D7D0
	private void JHPOIOELNCG()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.KMMJOPLLPLK();
			if (gameObject)
			{
				this.DEDEFDBGOFH(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A7F RID: 35455 RVA: 0x0033F608 File Offset: 0x0033D808
	private void JMMABGLJNMF(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.JLLHOBJBDNN();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(657f, 1372f, 872f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 400f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1097f;
			a.z = 4f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	// Token: 0x06008A80 RID: 35456 RVA: 0x0033F714 File Offset: 0x0033D914
	private void FLNBKOEMOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.OJLOOIEONGI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(271f, 1195f, 1904f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 631f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 110f;
			a.z = 128f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	// Token: 0x06008A81 RID: 35457 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject BMBAHHBCLBE()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A82 RID: 35458 RVA: 0x0033F820 File Offset: 0x0033DA20
	private void DAMEGFHBCIO(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.NNMEAEKODCB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(470f, 77f, 1333f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1780f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 459f;
			a.z = 585f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	// Token: 0x06008A83 RID: 35459 RVA: 0x000821C7 File Offset: 0x000803C7
	private void LFAFJKJAEEL()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.EPINJLOBFJD(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A84 RID: 35460 RVA: 0x0008219D File Offset: 0x0008039D
	private void OGJJDKENBNC()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.IKGMFIAMHNL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A85 RID: 35461 RVA: 0x0033F92C File Offset: 0x0033DB2C
	private void AIJGAJIOJDJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.HGLKKJAIFDL();
			if (gameObject)
			{
				this.MPLCLOFBIOD(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A86 RID: 35462 RVA: 0x0033F964 File Offset: 0x0033DB64
	private void BBEMGNBAFIN(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.PBCCDPILANO();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1613f, 1768f, 1672f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 943f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 962f;
			a.z = 1666f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	// Token: 0x06008A87 RID: 35463 RVA: 0x0033FA70 File Offset: 0x0033DC70
	private void BOJJNHOLFIF(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.NNMEAEKODCB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(960f, 287f, 641f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1107f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 921f;
			a.z = 1874f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008A88 RID: 35464 RVA: 0x00082299 File Offset: 0x00080499
	private void EGEPLFGKGLI()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.JBNMLKGMFFA(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A89 RID: 35465 RVA: 0x0008219D File Offset: 0x0008039D
	private void KOJKBFDNGDK()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.IKGMFIAMHNL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A8A RID: 35466 RVA: 0x0033FB7C File Offset: 0x0033DD7C
	private void JBMBNKOOENB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.LICGBCCDGFP();
			if (gameObject)
			{
				this.CEODKENENEC(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A8B RID: 35467 RVA: 0x0033F238 File Offset: 0x0033D438
	public GameObject MDMAPECMEBL()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A8C RID: 35468 RVA: 0x0033E128 File Offset: 0x0033C328
	public GameObject IENDGLFEIHP()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A8D RID: 35469 RVA: 0x0033E128 File Offset: 0x0033C328
	public GameObject HAKDALCNHDN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A8E RID: 35470 RVA: 0x0008226F File Offset: 0x0008046F
	private void DOFDGBGEDFI()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.OBPKKILBADL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A8F RID: 35471 RVA: 0x0033FBB4 File Offset: 0x0033DDB4
	private void HDDECCMEJKA()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.ECNLNGCMIDG();
			if (gameObject)
			{
				this.EJGENEGGPME(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A90 RID: 35472 RVA: 0x0033E128 File Offset: 0x0033C328
	public GameObject PJHFIEFCHOB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A91 RID: 35473 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject MIFCGKMPJIL()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A92 RID: 35474 RVA: 0x0033FBEC File Offset: 0x0033DDEC
	private void MFMIODIAKNI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.HGLKKJAIFDL();
			if (gameObject)
			{
				this.PDGFFPLDPJJ(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A93 RID: 35475 RVA: 0x0033FC24 File Offset: 0x0033DE24
	private void MPLCLOFBIOD(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.ODGKJOMBBPJ();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(172f, 1033f, 771f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 256f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1893f;
			a.z = 833f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	// Token: 0x06008A94 RID: 35476 RVA: 0x0033FD30 File Offset: 0x0033DF30
	private void DHCDCDAILLM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.CKLALLEDMOB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1693f, 627f, 925f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1224f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1875f;
			a.z = 722f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().BAGJNDODMCP();
		}
	}

	// Token: 0x06008A95 RID: 35477 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject PPIPLPMEFJK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A96 RID: 35478 RVA: 0x0033F238 File Offset: 0x0033D438
	public GameObject PNJMNJPHDAM()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A97 RID: 35479 RVA: 0x00082173 File Offset: 0x00080373
	private void Start()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.CreatePool(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A98 RID: 35480 RVA: 0x0033FE3C File Offset: 0x0033E03C
	private void PDGFFPLDPJJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.MHCCLBBHNPP();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(716f, 1570f, 910f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 974f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 830f;
			a.z = 473f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	// Token: 0x06008A99 RID: 35481 RVA: 0x00082299 File Offset: 0x00080499
	private void OKLAJINHPAN()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.JBNMLKGMFFA(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008A9A RID: 35482 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject CGJLBMLJBLJ()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008A9B RID: 35483 RVA: 0x0033FF48 File Offset: 0x0033E148
	private void GGFBMANAJJL(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.HDNMHMBPICA();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(656f, 1893f, 761f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 630f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1649f;
			a.z = 572f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	// Token: 0x06008A9C RID: 35484 RVA: 0x00340054 File Offset: 0x0033E254
	private void BGDONBMDPGM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.OJOEOIHAKOC();
			if (gameObject)
			{
				this.FCNBDNMMAML(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A9D RID: 35485 RVA: 0x0034008C File Offset: 0x0033E28C
	private void LCJHDLKJEOM()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.HGLKKJAIFDL();
			if (gameObject)
			{
				this.JPGCKMEEGCP(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A9E RID: 35486 RVA: 0x003400C4 File Offset: 0x0033E2C4
	private void LCHBFNIPBHB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.EKOHHBHAMND();
			if (gameObject)
			{
				this.GGFBMANAJJL(gameObject.transform);
			}
		}
	}

	// Token: 0x06008A9F RID: 35487 RVA: 0x003400FC File Offset: 0x0033E2FC
	private void AEEGKLABFLN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.IENDGLFEIHP();
			if (gameObject)
			{
				this.FLCPKLOHAMB(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AA0 RID: 35488 RVA: 0x00082317 File Offset: 0x00080517
	private void JABNHMIHBHC()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.MJKODGBPPJI(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AA1 RID: 35489 RVA: 0x00340134 File Offset: 0x0033E334
	private void BMNOHLNANIP()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.EKOHHBHAMND();
			if (gameObject)
			{
				this.LNBJBGFCBLC(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AA2 RID: 35490 RVA: 0x00082341 File Offset: 0x00080541
	private void MODENHKMKOC()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.LHKJCDGPEKD(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AA3 RID: 35491 RVA: 0x0008226F File Offset: 0x0008046F
	private void DBEMDAJDDDA()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.OBPKKILBADL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AA4 RID: 35492 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject OJOEOIHAKOC()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AA5 RID: 35493 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject HGLKKJAIFDL()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AA6 RID: 35494 RVA: 0x0034016C File Offset: 0x0033E36C
	private void IPMGONDHOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.OGLLBBOGIIE();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(151f, 1809f, 805f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1118f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1322f;
			a.z = 582f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().BAGJNDODMCP();
		}
	}

	// Token: 0x06008AA7 RID: 35495 RVA: 0x00340278 File Offset: 0x0033E478
	private void LNBJBGFCBLC(Transform KFHEOLKCAJK)
	{
		GameObject @object = this.MHCIODHIFGG.GetObject();
		if (@object)
		{
			@object.transform.SetParent(this.CanvasMain.transform);
			@object.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(0.1f, 0.1f, 0.1f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 2f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 2f;
			a.z = 0f;
			@object.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			@object.transform.SetParent(KFHEOLKCAJK);
			@object.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008AA8 RID: 35496 RVA: 0x00340384 File Offset: 0x0033E584
	private void MECJHOJPODB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.OJOEOIHAKOC();
			if (gameObject)
			{
				this.MENMHCBMHJD(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AA9 RID: 35497 RVA: 0x00082173 File Offset: 0x00080373
	private void FHGKIOOMMOH()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.CreatePool(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AAA RID: 35498 RVA: 0x0008221B File Offset: 0x0008041B
	private void JECMJNFGBGC()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.DOPLKFDBGAM(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AAB RID: 35499 RVA: 0x0033F238 File Offset: 0x0033D438
	public GameObject KJNENFBPHOB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AAC RID: 35500 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject AAJGEJPGDPI()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AAD RID: 35501 RVA: 0x0033F238 File Offset: 0x0033D438
	public GameObject KMMJOPLLPLK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AAE RID: 35502 RVA: 0x00082317 File Offset: 0x00080517
	private void AEDDNDHCLNN()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.MJKODGBPPJI(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AAF RID: 35503 RVA: 0x000822ED File Offset: 0x000804ED
	private void GLEJGFLCLPJ()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.OCIHAKKPJOE(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AB0 RID: 35504 RVA: 0x003403BC File Offset: 0x0033E5BC
	private void OBMOANGBJOG(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.HDNMHMBPICA();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(857f, 750f, 733f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 239f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 701f;
			a.z = 1729f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DMMEHNCIKDG();
		}
	}

	// Token: 0x06008AB1 RID: 35505 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject LICGBCCDGFP()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AB2 RID: 35506 RVA: 0x003404C8 File Offset: 0x0033E6C8
	private void HLDFOJMHKNL()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.CMFDFPDOCCD();
			if (gameObject)
			{
				this.MENMHCBMHJD(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AB3 RID: 35507 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject HOJGGMNNCDA()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AB4 RID: 35508 RVA: 0x00340500 File Offset: 0x0033E700
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.UiHitted();
			if (gameObject)
			{
				this.LNBJBGFCBLC(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AB5 RID: 35509 RVA: 0x00340538 File Offset: 0x0033E738
	private void EDDPLJGKLKJ()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.KMMJOPLLPLK();
			if (gameObject)
			{
				this.FLNBKOEMOIP(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AB6 RID: 35510 RVA: 0x000821F1 File Offset: 0x000803F1
	private void ADPLHDFJFID()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.NJAEONDJHCD(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AB7 RID: 35511 RVA: 0x00340570 File Offset: 0x0033E770
	private void GICHJOJPCOC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.MFONOACAODI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1206f, 824f, 529f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1600f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 447f;
			a.z = 471f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	// Token: 0x06008AB8 RID: 35512 RVA: 0x0034067C File Offset: 0x0033E87C
	private void EJFJENFKLND()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.AOAAAAIFIHP();
			if (gameObject)
			{
				this.FANJBDGCKNM(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AB9 RID: 35513 RVA: 0x003406B4 File Offset: 0x0033E8B4
	private void JFMIDILENDO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.UiHitted();
			if (gameObject)
			{
				this.GICHJOJPCOC(gameObject.transform);
			}
		}
	}

	// Token: 0x06008ABA RID: 35514 RVA: 0x003406EC File Offset: 0x0033E8EC
	private void ICFFEEHGAMN(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.OJLOOIEONGI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1319f, 841f, 370f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 394f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 957f;
			a.z = 722f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	// Token: 0x06008ABB RID: 35515 RVA: 0x003407F8 File Offset: 0x0033E9F8
	private void OIBMHPIFAKK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.MHBKFIMMOJP();
			if (gameObject)
			{
				this.DHCDCDAILLM(gameObject.transform);
			}
		}
	}

	// Token: 0x06008ABC RID: 35516 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject ILGGAMKKFMK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008ABD RID: 35517 RVA: 0x00340830 File Offset: 0x0033EA30
	private void BIOOPKPNKPM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.OJLOOIEONGI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1016f, 1844f, 1833f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 842f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1271f;
			a.z = 1953f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	// Token: 0x06008ABE RID: 35518 RVA: 0x00082149 File Offset: 0x00080349
	private void DKGBFNCOAEO()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.INPIOKFFDND(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008ABF RID: 35519 RVA: 0x000821F1 File Offset: 0x000803F1
	private void BGDPIHMAACO()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.NJAEONDJHCD(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AC0 RID: 35520 RVA: 0x0034093C File Offset: 0x0033EB3C
	private void JPGCKMEEGCP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.KBKMDALIBJC();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1280f, 1075f, 275f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1516f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 928f;
			a.z = 64f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	// Token: 0x06008AC1 RID: 35521 RVA: 0x00340A48 File Offset: 0x0033EC48
	private void FANJBDGCKNM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.JLLHOBJBDNN();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1916f, 1581f, 1275f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 198f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 447f;
			a.z = 1221f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	// Token: 0x06008AC2 RID: 35522 RVA: 0x0008226F File Offset: 0x0008046F
	private void GNJDKAECPKA()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.OBPKKILBADL(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008AC4 RID: 35524 RVA: 0x0033E128 File Offset: 0x0033C328
	public GameObject PFFGHBKALAD()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AC5 RID: 35525 RVA: 0x00340B54 File Offset: 0x0033ED54
	private void EFLDOJLPBHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.MFONOACAODI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1614f, 496f, 1732f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 52f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 719f;
			a.z = 1242f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008AC6 RID: 35526 RVA: 0x00340C60 File Offset: 0x0033EE60
	private void ODCJJFBJJNF()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.UiHitted();
			if (gameObject)
			{
				this.IPMGONDHOIP(gameObject.transform);
			}
		}
	}

	// Token: 0x06008AC7 RID: 35527 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
	public GameObject GIIOLDPLHBB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008AC8 RID: 35528 RVA: 0x0033E1C8 File Offset: 0x0033C3C8
	public GameObject JGHJFAJAJON()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x04000FB7 RID: 4023
	public GameObject WaveObject;

	// Token: 0x04000FB8 RID: 4024
	public GameObject CanvasMain;

	// Token: 0x04000FB9 RID: 4025
	public int PoolSize;

	// Token: 0x04000FBA RID: 4026
	private Pool MHCIODHIFGG;
}
