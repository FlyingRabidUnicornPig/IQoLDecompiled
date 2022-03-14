/*
Importance of this class: Unknown. This feels like some C# base or extension class.

Purpose of this class: Unknown, Type checker?

Deobf status: No Junk methods. Everything is obf'd.
*/

using System;
using System.Collections.Generic;

// Token: 0x020002CD RID: 717
internal static class CFGKBDICDIH
{
	// Token: 0x0600AE29 RID: 44585 RVA: 0x0040C054 File Offset: 0x0040A254
	internal static Type LEMHLODODPL(Type ANFOJNABFFJ)
	{
		Type type = CFGKBDICDIH.BNNBDLGMAIE(ANFOJNABFFJ);
		if (type == null)
		{
			return ANFOJNABFFJ;
		}
		return type.GetGenericArguments()[0];
	}

	// Token: 0x0600AE2A RID: 44586 RVA: 0x0040C078 File Offset: 0x0040A278
	private static Type BNNBDLGMAIE(Type ANFOJNABFFJ)
	{
		if (ANFOJNABFFJ == null || ANFOJNABFFJ == typeof(string))
		{
			return null;
		}
		if (ANFOJNABFFJ.IsArray)
		{
			return typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				ANFOJNABFFJ.GetElementType()
			});
		}
		if (ANFOJNABFFJ.IsGenericType)
		{
			foreach (Type type in ANFOJNABFFJ.GetGenericArguments())
			{
				Type type2 = typeof(IEnumerable<>).MakeGenericType(new Type[]
				{
					type
				});
				if (type2.IsAssignableFrom(ANFOJNABFFJ))
				{
					return type2;
				}
			}
		}
		Type[] interfaces = ANFOJNABFFJ.GetInterfaces();
		if (interfaces != null && interfaces.Length > 0)
		{
			foreach (Type anfojnabffj in interfaces)
			{
				Type type3 = CFGKBDICDIH.BNNBDLGMAIE(anfojnabffj);
				if (type3 != null)
				{
					return type3;
				}
			}
		}
		if (ANFOJNABFFJ.BaseType != null && ANFOJNABFFJ.BaseType != typeof(object))
		{
			return CFGKBDICDIH.BNNBDLGMAIE(ANFOJNABFFJ.BaseType);
		}
		return null;
	}

	// Token: 0x0600AE2B RID: 44587 RVA: 0x0008A671 File Offset: 0x00088871
	public static bool IsEnumerableType(Type HMGBJCGOLMI)
	{
		return HMGBJCGOLMI.GetInterface("IEnumerable") != null;
	}

	// Token: 0x0600AE2C RID: 44588 RVA: 0x0008A684 File Offset: 0x00088884
	public static bool IsCollectionType(Type HMGBJCGOLMI)
	{
		return HMGBJCGOLMI.GetInterface("ICollection") != null;
	}
}
