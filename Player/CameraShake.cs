/*
Importance of this class: Used when player loses life

Purpose of this class: Shakes the camera. Could reuse for mapper usage :D

Deobf status: Awful. 90%+ is likely junk methods. Most variables are obfd.
*/

using System;
using UnityEngine;

// Token: 0x02000418 RID: 1048
public class CameraShake : MonoBehaviour
{
	// Token: 0x0600EA32 RID: 59954 RVA: 0x0009CF30 File Offset: 0x0009B130
	public void NLKNJIOIEGF()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 602f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1195f;
		this.Shaking = false;
	}

	// Token: 0x0600EA34 RID: 59956 RVA: 0x0009CF8F File Offset: 0x0009B18F
	public void HPJLIGJEDCN()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1166f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1329f;
		this.Shaking = false;
	}

	// Token: 0x0600EA35 RID: 59957 RVA: 0x0009CFC1 File Offset: 0x0009B1C1
	private void FIKFJDFELIP()
	{
		this.AJPABMEPCDO = 1348f;
		this.Shaking = false;
	}

	// Token: 0x0600EA36 RID: 59958 RVA: 0x004FD7D0 File Offset: 0x004FB9D0
	private void Update()
	{
		if (this.CCBCCEGBOJP > 0f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600EA37 RID: 59959 RVA: 0x004FD880 File Offset: 0x004FBA80
	private void LCJHDLKJEOM()
	{
		if (this.CCBCCEGBOJP > 672f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600EA38 RID: 59960 RVA: 0x0009CFD5 File Offset: 0x0009B1D5
	private void KIMMMCJFMAB()
	{
		this.AJPABMEPCDO = 579f;
		this.Shaking = false;
	}

	// Token: 0x0600EA39 RID: 59961 RVA: 0x0009CFE9 File Offset: 0x0009B1E9
	private void KMCPMOGKDEH()
	{
		this.AJPABMEPCDO = 766f;
		this.Shaking = false;
	}

	// Token: 0x0600EA3A RID: 59962 RVA: 0x0009CFFD File Offset: 0x0009B1FD
	private void AGEJKLMJGDO()
	{
		this.AJPABMEPCDO = 526f;
		this.Shaking = true;
	}

	// Token: 0x0600EA3B RID: 59963 RVA: 0x004FD930 File Offset: 0x004FBB30
	private void FABKIGNFECE()
	{
		if (this.CCBCCEGBOJP > 10f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600EA3C RID: 59964 RVA: 0x0009D011 File Offset: 0x0009B211
	private void NNCCPEBIAKH()
	{
		this.AJPABMEPCDO = 1561f;
		this.Shaking = false;
	}

	// Token: 0x0600EA3D RID: 59965 RVA: 0x0009D025 File Offset: 0x0009B225
	private void MMMDPANNAIO()
	{
		this.AJPABMEPCDO = 15f;
		this.Shaking = false;
	}

	// Token: 0x0600EA3E RID: 59966 RVA: 0x004FD9E0 File Offset: 0x004FBBE0
	private void LLJLDLLNFBH()
	{
		if (this.CCBCCEGBOJP > 924f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600EA3F RID: 59967 RVA: 0x0009D039 File Offset: 0x0009B239
	public void FEIKJBMEHLD()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1271f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 726f;
		this.Shaking = false;
	}

	// Token: 0x0600EA40 RID: 59968 RVA: 0x0009D06B File Offset: 0x0009B26B
	public void HDAPEPPPOGG()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 516f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1911f;
		this.Shaking = true;
	}

	// Token: 0x0600EA41 RID: 59969 RVA: 0x0009D09D File Offset: 0x0009B29D
	private void EPEGAEGDJAM()
	{
		this.AJPABMEPCDO = 1135f;
		this.Shaking = true;
	}

	// Token: 0x0600EA42 RID: 59970 RVA: 0x004FDA90 File Offset: 0x004FBC90
	private void FBMDHDBELEK()
	{
		if (this.CCBCCEGBOJP > 600f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600EA43 RID: 59971 RVA: 0x0009D0B1 File Offset: 0x0009B2B1
	public void DoShake()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 0.1f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 0.01f;
		this.Shaking = true;
	}

	// Token: 0x0600EA44 RID: 59972 RVA: 0x0009D0E3 File Offset: 0x0009B2E3
	private void DLBODOFAJGM()
	{
		this.AJPABMEPCDO = 1188f;
		this.Shaking = false;
	}

	// Token: 0x0600EA45 RID: 59973 RVA: 0x004FDB40 File Offset: 0x004FBD40
	private void BMODOIJGIOO()
	{
		if (this.CCBCCEGBOJP > 1193f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600EA46 RID: 59974 RVA: 0x0009D0F7 File Offset: 0x0009B2F7
	private void KCCIEMBMOBA()
	{
		this.AJPABMEPCDO = 813f;
		this.Shaking = false;
	}

	// Token: 0x0600EA47 RID: 59975 RVA: 0x0009D10B File Offset: 0x0009B30B
	private void CIPKEPDELJB()
	{
		this.AJPABMEPCDO = 814f;
		this.Shaking = false;
	}

	// Token: 0x0600EA48 RID: 59976 RVA: 0x004FDBF0 File Offset: 0x004FBDF0
	private void NKLIHNJCHOG()
	{
		if (this.CCBCCEGBOJP > 366f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600EA49 RID: 59977 RVA: 0x004FDCA0 File Offset: 0x004FBEA0
	private void MMBPLGGLPDB()
	{
		if (this.CCBCCEGBOJP > 1706f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600EA4A RID: 59978 RVA: 0x0009D11F File Offset: 0x0009B31F
	private void FHPFJBFCOOF()
	{
		this.AJPABMEPCDO = 1109f;
		this.Shaking = true;
	}

	// Token: 0x0600EA4B RID: 59979 RVA: 0x0009D133 File Offset: 0x0009B333
	public void HBEEJAFHFCG()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 266f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1014f;
		this.Shaking = false;
	}

	// Token: 0x0600EA4C RID: 59980 RVA: 0x0009D165 File Offset: 0x0009B365
	private void NCNPAKFAFOE()
	{
		this.AJPABMEPCDO = 519f;
		this.Shaking = false;
	}

	// Token: 0x0600EA4D RID: 59981 RVA: 0x0009D179 File Offset: 0x0009B379
	private void JILOMOBDPIA()
	{
		this.AJPABMEPCDO = 23f;
		this.Shaking = true;
	}

	// Token: 0x0600EA4E RID: 59982 RVA: 0x0009D18D File Offset: 0x0009B38D
	private void Start()
	{
		this.AJPABMEPCDO = 1f;
		this.Shaking = false;
	}

	// Token: 0x0600EA4F RID: 59983 RVA: 0x0009D1A1 File Offset: 0x0009B3A1
	private void PAKPHKPDKGE()
	{
		this.AJPABMEPCDO = 206f;
		this.Shaking = true;
	}

	// Token: 0x0600EA50 RID: 59984 RVA: 0x004FDD50 File Offset: 0x004FBF50
	private void AGMJDGHLBMN()
	{
		if (this.CCBCCEGBOJP > 1605f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600EA51 RID: 59985 RVA: 0x0009D1B5 File Offset: 0x0009B3B5
	private void NBGIMIDICKE()
	{
		this.AJPABMEPCDO = 138f;
		this.Shaking = false;
	}

	// Token: 0x0600EA52 RID: 59986 RVA: 0x0009D1C9 File Offset: 0x0009B3C9
	public void IOAFNIKIDIJ()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1534f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1733f;
		this.Shaking = false;
	}

	// Token: 0x0600EA53 RID: 59987 RVA: 0x0009D1FB File Offset: 0x0009B3FB
	public void DCKGCKPGPII()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1236f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1059f;
		this.Shaking = false;
	}

	// Token: 0x0600EA54 RID: 59988 RVA: 0x0009D22D File Offset: 0x0009B42D
	private void CNGAJDBOCLJ()
	{
		this.AJPABMEPCDO = 189f;
		this.Shaking = true;
	}

	// Token: 0x0600EA55 RID: 59989 RVA: 0x0009D241 File Offset: 0x0009B441
	private void BEBNOKFLJPH()
	{
		this.AJPABMEPCDO = 401f;
		this.Shaking = false;
	}

	// Token: 0x0600EA56 RID: 59990 RVA: 0x004FDE00 File Offset: 0x004FC000
	private void FOMNCPKKCFN()
	{
		if (this.CCBCCEGBOJP > 228f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600EA57 RID: 59991 RVA: 0x0009D255 File Offset: 0x0009B455
	public void PCLJLDJLCKH()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 325f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 44f;
		this.Shaking = true;
	}

	// Token: 0x0600EA58 RID: 59992 RVA: 0x0009D287 File Offset: 0x0009B487
	private void NPLCENPNJBM()
	{
		this.AJPABMEPCDO = 1749f;
		this.Shaking = false;
	}

	// Token: 0x0600EA59 RID: 59993 RVA: 0x004FDEB0 File Offset: 0x004FC0B0
	private void IDIIELPAMCJ()
	{
		if (this.CCBCCEGBOJP > 393f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x04001AD5 RID: 6869
	public bool Shaking;

	// Token: 0x04001AD6 RID: 6870
	private float NGGFNGMNGAC;

	// Token: 0x04001AD7 RID: 6871
	private float CCBCCEGBOJP;

	// Token: 0x04001AD8 RID: 6872
	private float AJPABMEPCDO = 1f;

	// Token: 0x04001AD9 RID: 6873
	private Vector3 KCCFEAIFEHC;

	// Token: 0x04001ADA RID: 6874
	public Vector3 basePoition = new Vector3(0f, 0f, 0f);
}
