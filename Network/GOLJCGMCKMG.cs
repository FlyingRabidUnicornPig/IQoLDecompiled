// Used by Photon
// no deobf'd done idc rn

using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020002D9 RID: 729
internal static class GOLJCGMCKMG
{
	// Token: 0x0600AB9F RID: 43935 RVA: 0x003FC95C File Offset: 0x003FAB5C
	internal static void FJPBNMBIOHG()
	{
		Type typeFromHandle = typeof(Vector2);
		byte code = 87;
		if (GOLJCGMCKMG.BOGJGOAMCHK == null)
		{
			GOLJCGMCKMG.BOGJGOAMCHK = new SerializeStreamMethod(GOLJCGMCKMG.LCNMHEMBEFI);
		}
		SerializeStreamMethod bogjgoamchk = GOLJCGMCKMG.BOGJGOAMCHK;
		if (GOLJCGMCKMG.BDPNFNJNEFM == null)
		{
			GOLJCGMCKMG.BDPNFNJNEFM = new DeserializeStreamMethod(GOLJCGMCKMG.HANJLNGFAKP);
		}
		PhotonPeer.RegisterType(typeFromHandle, code, bogjgoamchk, GOLJCGMCKMG.BDPNFNJNEFM);
		Type typeFromHandle2 = typeof(Vector3);
		byte code2 = 86;
		if (GOLJCGMCKMG.MJKNAFJKDMG == null)
		{
			GOLJCGMCKMG.MJKNAFJKDMG = new SerializeStreamMethod(GOLJCGMCKMG.ANBBLBLNDBH);
		}
		SerializeStreamMethod mjknafjkdmg = GOLJCGMCKMG.MJKNAFJKDMG;
		if (GOLJCGMCKMG.JENGHDFDLII == null)
		{
			GOLJCGMCKMG.JENGHDFDLII = new DeserializeStreamMethod(GOLJCGMCKMG.BFLLDNIBMHP);
		}
		PhotonPeer.RegisterType(typeFromHandle2, code2, mjknafjkdmg, GOLJCGMCKMG.JENGHDFDLII);
		Type typeFromHandle3 = typeof(Quaternion);
		byte code3 = 81;
		if (GOLJCGMCKMG.BMJHMBNEACI == null)
		{
			GOLJCGMCKMG.BMJHMBNEACI = new SerializeStreamMethod(GOLJCGMCKMG.PKPCNJJBOJB);
		}
		SerializeStreamMethod bmjhmbneaci = GOLJCGMCKMG.BMJHMBNEACI;
		if (GOLJCGMCKMG.EPENHHMDDMB == null)
		{
			GOLJCGMCKMG.EPENHHMDDMB = new DeserializeStreamMethod(GOLJCGMCKMG.BNPJAGNEBPN);
		}
		PhotonPeer.RegisterType(typeFromHandle3, code3, bmjhmbneaci, GOLJCGMCKMG.EPENHHMDDMB);
		Type typeFromHandle4 = typeof(PhotonPlayer);
		byte code4 = 80;
		if (GOLJCGMCKMG.DNLDPCIINIC == null)
		{
			GOLJCGMCKMG.DNLDPCIINIC = new SerializeStreamMethod(GOLJCGMCKMG.AJKFOONFMDK);
		}
		SerializeStreamMethod dnldpciinic = GOLJCGMCKMG.DNLDPCIINIC;
		if (GOLJCGMCKMG.ILAKDECCIME == null)
		{
			GOLJCGMCKMG.ILAKDECCIME = new DeserializeStreamMethod(GOLJCGMCKMG.AEKFJLLFGFB);
		}
		PhotonPeer.RegisterType(typeFromHandle4, code4, dnldpciinic, GOLJCGMCKMG.ILAKDECCIME);
	}

	// Token: 0x0600ABA0 RID: 43936 RVA: 0x003FCA9C File Offset: 0x003FAC9C
	private static short ANBBLBLNDBH(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Vector3 vector = (Vector3)CCKPKLEKCFF;
		int num = 0;
		object obj = GOLJCGMCKMG.memVector3;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memVector3;
			Protocol.Serialize(vector.x, array, ref num);
			Protocol.Serialize(vector.y, array, ref num);
			Protocol.Serialize(vector.z, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 12);
		}
		return 12;
	}

	// Token: 0x0600ABA1 RID: 43937 RVA: 0x003FCB1C File Offset: 0x003FAD1C
	private static object BFLLDNIBMHP(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Vector3 vector = default(Vector3);
		object obj = GOLJCGMCKMG.memVector3;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memVector3, 0, 12);
			int num = 0;
			Protocol.Deserialize(out vector.x, GOLJCGMCKMG.memVector3, ref num);
			Protocol.Deserialize(out vector.y, GOLJCGMCKMG.memVector3, ref num);
			Protocol.Deserialize(out vector.z, GOLJCGMCKMG.memVector3, ref num);
		}
		return vector;
	}

	// Token: 0x0600ABA2 RID: 43938 RVA: 0x003FCBAC File Offset: 0x003FADAC
	private static short LCNMHEMBEFI(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Vector2 vector = (Vector2)CCKPKLEKCFF;
		object obj = GOLJCGMCKMG.memVector2;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memVector2;
			int num = 0;
			Protocol.Serialize(vector.x, array, ref num);
			Protocol.Serialize(vector.y, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 8);
		}
		return 8;
	}

	// Token: 0x0600ABA3 RID: 43939 RVA: 0x003FCC18 File Offset: 0x003FAE18
	private static object HANJLNGFAKP(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Vector2 vector = default(Vector2);
		object obj = GOLJCGMCKMG.memVector2;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memVector2, 0, 8);
			int num = 0;
			Protocol.Deserialize(out vector.x, GOLJCGMCKMG.memVector2, ref num);
			Protocol.Deserialize(out vector.y, GOLJCGMCKMG.memVector2, ref num);
		}
		return vector;
	}

	// Token: 0x0600ABA4 RID: 43940 RVA: 0x003FCC94 File Offset: 0x003FAE94
	private static short PKPCNJJBOJB(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Quaternion quaternion = (Quaternion)CCKPKLEKCFF;
		object obj = GOLJCGMCKMG.memQuarternion;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memQuarternion;
			int num = 0;
			Protocol.Serialize(quaternion.w, array, ref num);
			Protocol.Serialize(quaternion.x, array, ref num);
			Protocol.Serialize(quaternion.y, array, ref num);
			Protocol.Serialize(quaternion.z, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 16);
		}
		return 16;
	}

	// Token: 0x0600ABA5 RID: 43941 RVA: 0x003FCD20 File Offset: 0x003FAF20
	private static object BNPJAGNEBPN(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Quaternion quaternion = default(Quaternion);
		object obj = GOLJCGMCKMG.memQuarternion;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memQuarternion, 0, 16);
			int num = 0;
			Protocol.Deserialize(out quaternion.w, GOLJCGMCKMG.memQuarternion, ref num);
			Protocol.Deserialize(out quaternion.x, GOLJCGMCKMG.memQuarternion, ref num);
			Protocol.Deserialize(out quaternion.y, GOLJCGMCKMG.memQuarternion, ref num);
			Protocol.Deserialize(out quaternion.z, GOLJCGMCKMG.memQuarternion, ref num);
		}
		return quaternion;
	}

	// Token: 0x0600ABA6 RID: 43942 RVA: 0x003FCDC0 File Offset: 0x003FAFC0
	private static short AJKFOONFMDK(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		int id = ((PhotonPlayer)CCKPKLEKCFF).ID;
		object obj = GOLJCGMCKMG.memPlayer;
		short result;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memPlayer;
			int num = 0;
			Protocol.Serialize(id, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 4);
			result = 4;
		}
		return result;
	}

	// Token: 0x0600ABA7 RID: 43943 RVA: 0x003FCE20 File Offset: 0x003FB020
	private static object AEKFJLLFGFB(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		object obj = GOLJCGMCKMG.memPlayer;
		int key;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memPlayer, 0, (int)NIEADDJOIEG);
			int num = 0;
			Protocol.Deserialize(out key, GOLJCGMCKMG.memPlayer, ref num);
		}
		if (PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(key))
		{
			return PhotonNetwork.JNJJAMNLOHA.mActors[key];
		}
		return null;
	}

	// Token: 0x04001304 RID: 4868
	public static readonly byte[] memVector3 = new byte[12];

	// Token: 0x04001305 RID: 4869
	public static readonly byte[] memVector2 = new byte[8];

	// Token: 0x04001306 RID: 4870
	public static readonly byte[] memQuarternion = new byte[16];

	// Token: 0x04001307 RID: 4871
	public static readonly byte[] memPlayer = new byte[4];

	// Token: 0x04001308 RID: 4872
	[CompilerGenerated]
	private static SerializeStreamMethod BOGJGOAMCHK;

	// Token: 0x04001309 RID: 4873
	[CompilerGenerated]
	private static DeserializeStreamMethod BDPNFNJNEFM;

	// Token: 0x0400130A RID: 4874
	[CompilerGenerated]
	private static SerializeStreamMethod MJKNAFJKDMG;

	// Token: 0x0400130B RID: 4875
	[CompilerGenerated]
	private static DeserializeStreamMethod JENGHDFDLII;

	// Token: 0x0400130C RID: 4876
	[CompilerGenerated]
	private static SerializeStreamMethod BMJHMBNEACI;

	// Token: 0x0400130D RID: 4877
	[CompilerGenerated]
	private static DeserializeStreamMethod EPENHHMDDMB;

	// Token: 0x0400130E RID: 4878
	[CompilerGenerated]
	private static SerializeStreamMethod DNLDPCIINIC;

	// Token: 0x0400130F RID: 4879
	[CompilerGenerated]
	private static DeserializeStreamMethod ILAKDECCIME;
}
