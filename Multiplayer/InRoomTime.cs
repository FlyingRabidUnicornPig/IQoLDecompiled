/*
more time
*/

using System;
using System.Collections;
using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomTime : MonoBehaviour
{
	public void OnJoinedRoom()
	{
		base.StartCoroutine("CAMFLJLDDPH");
	}

	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("CAMFLJLDDPH");
	}

	public bool IsRoomTimeSet
	{
		get
		{
			return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("#rt");
		}
	}

	public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("#rt"))
		{
			this.LOMGHAIPHJK = (int)DGIHEPAHAJK["#rt"];
		}
	}

	public int RoomTimestamp
	{
		get
		{
			return (!PhotonNetwork.inRoom) ? 0 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
		}
	}

	public double RoomTime
	{
		get
		{
			uint roomTimestamp = (uint)this.RoomTimestamp;
			double num = roomTimestamp;
			return num / 1000.0;
		}
	}

	internal IEnumerator SetUpTimeIThink()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	private int LOMGHAIPHJK;

	private const string JJDHAIONGKL = "#rt";
}
