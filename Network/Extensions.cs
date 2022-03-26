/*
Importance of this class: Third party shit uses this

Purpose of this class: Third party extensions for network/multiplayer shit

Deobf status: Method params
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using UnityEngine;

public static class Extensions
{
	public static ParameterInfo[] GetCachedParemeters(this MethodInfo HCGPGHJPJAM)
	{
		ParameterInfo[] parameters;
		if (!Extensions.ParametersOfMethods.TryGetValue(HCGPGHJPJAM, out parameters))
		{
			parameters = HCGPGHJPJAM.GetParameters();
			Extensions.ParametersOfMethods[HCGPGHJPJAM] = parameters;
		}
		return parameters;
	}

	public static PhotonView[] GetPhotonViewsInChildren(this GameObject OBFJPHLBFOL)
	{
		return OBFJPHLBFOL.GetComponentsInChildren<PhotonView>(true);
	}

	public static PhotonView GetPhotonView(this GameObject OBFJPHLBFOL)
	{
		return OBFJPHLBFOL.GetComponent<PhotonView>();
	}

	public static bool AlmostEquals(this Vector3 MPNMOONBMII, Vector3 BICCGCFNNLP, float ECINLPMCJFK)
	{
		return (MPNMOONBMII - BICCGCFNNLP).sqrMagnitude < ECINLPMCJFK;
	}

	public static bool AlmostEquals(this Vector2 MPNMOONBMII, Vector2 BICCGCFNNLP, float ECINLPMCJFK)
	{
		return (MPNMOONBMII - BICCGCFNNLP).sqrMagnitude < ECINLPMCJFK;
	}

	public static bool AlmostEquals(this Quaternion MPNMOONBMII, Quaternion BICCGCFNNLP, float MNAOJGNELDM)
	{
		return Quaternion.Angle(MPNMOONBMII, BICCGCFNNLP) < MNAOJGNELDM;
	}

	public static bool AlmostEquals(this float MPNMOONBMII, float BICCGCFNNLP, float OGODMIJJENE)
	{
		return Mathf.Abs(MPNMOONBMII - BICCGCFNNLP) < OGODMIJJENE;
	}

	public static void Merge(this IDictionary MPNMOONBMII, IDictionary PFLIKPMIGLK)
	{
		if (PFLIKPMIGLK == null || MPNMOONBMII.Equals(PFLIKPMIGLK))
		{
			return;
		}
		IEnumerator enumerator = PFLIKPMIGLK.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object key = enumerator.Current;
				MPNMOONBMII[key] = PFLIKPMIGLK[key];
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public static void MergeStringKeys(this IDictionary MPNMOONBMII, IDictionary PFLIKPMIGLK)
	{
		if (PFLIKPMIGLK == null || MPNMOONBMII.Equals(PFLIKPMIGLK))
		{
			return;
		}
		IEnumerator enumerator = PFLIKPMIGLK.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				if (obj is string)
				{
					MPNMOONBMII[obj] = PFLIKPMIGLK[obj];
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public static string ToStringFull(this IDictionary GEMDHBEGEFH)
	{
		return SupportClass.DictionaryToString(GEMDHBEGEFH, false);
	}

	public static string ToStringFull(this object[] NOJGGCLPPAM)
	{
		if (NOJGGCLPPAM == null)
		{
			return "null";
		}
		string[] array = new string[NOJGGCLPPAM.Length];
		for (int i = 0; i < NOJGGCLPPAM.Length; i++)
		{
			object obj = NOJGGCLPPAM[i];
			array[i] = ((obj == null) ? "null" : obj.ToString());
		}
		return string.Join(", ", array);
	}

	public static ExitGames.Client.Photon.Hashtable StripToStringKeys(this IDictionary LMHCHLAIMJH)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		if (LMHCHLAIMJH != null)
		{
			IEnumerator enumerator = LMHCHLAIMJH.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					if (obj is string)
					{
						hashtable[obj] = LMHCHLAIMJH[obj];
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		return hashtable;
	}

	public static void StripKeysWithNullValues(this IDictionary LMHCHLAIMJH)
	{
		object[] array = new object[LMHCHLAIMJH.Count];
		int num = 0;
		IEnumerator enumerator = LMHCHLAIMJH.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				array[num++] = obj;
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		foreach (object key in array)
		{
			if (LMHCHLAIMJH[key] == null)
			{
				LMHCHLAIMJH.Remove(key);
			}
		}
	}

	public static bool Contains(this int[] MPNMOONBMII, int FGBCKIIKMNC)
	{
		if (MPNMOONBMII == null)
		{
			return false;
		}
		for (int i = 0; i < MPNMOONBMII.Length; i++)
		{
			if (MPNMOONBMII[i] == FGBCKIIKMNC)
			{
				return true;
			}
		}
		return false;
	}

	public static Dictionary<MethodInfo, ParameterInfo[]> ParametersOfMethods = new Dictionary<MethodInfo, ParameterInfo[]>();
}
