/*
Timer
*/

using System;
using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomRoundTimer : MonoBehaviour
{
	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("st"))
		{
			Debug.Log("The new master starts a new round, cause we didn't start yet.");
			this.CheckTimeIThink();
		}
	}

	public void OnJoinedRoom()
	{
		if (PhotonNetwork.isMasterClient)
			this.CheckTimeIThink();
		else
			Debug.Log("StartTime already set: " + PhotonNetwork.room.customProperties.ContainsKey("st"));
	}

	private void Update()
	{
		if (this.DBHJOONLNJE)
			this.CheckTimeIThink();
	}

	private void CheckTimeIThink()
	{
		this.DBHJOONLNJE = PhotonNetwork.time < 9.999999747378752E-05;
		
		if (this.DBHJOONLNJE) return;

		Hashtable hashtable = new Hashtable();
		hashtable["st"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	public void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("st"))
			this.StartTime = (double)DGIHEPAHAJK["st"];
	}

	public void OnGUI()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("elapsed: {0:0.000}", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("remaining: {0:0.000}", num2), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("turn: {0:0}", num3), new GUILayoutOption[0]);
		if (GUILayout.Button("new round", new GUILayoutOption[0]))
			this.CheckTimeIThink();
		GUILayout.EndArea();
	}

	public int SecondsPerTurn = 5;

	public double StartTime;

	public Rect TextPos = new Rect(0f, 80f, 150f, 300f);

	private bool DBHJOONLNJE;

	// Prolly not referenced cause compiler a bitch
	private const string JJDHAIONGKL = "st";
}
