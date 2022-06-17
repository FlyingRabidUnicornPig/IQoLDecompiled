/*
Pun Callback interface
*/

using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;

public interface IPunCallbacks
{
	void OnConnectedToPhoton();

	void OnLeftRoom();

	void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO);

	void OnPhotonCreateRoomFailed(object[] APELDCFFFOH);

	void OnPhotonJoinRoomFailed(object[] APELDCFFFOH);

	void OnCreatedRoom();

	void OnJoinedLobby();

	void OnLeftLobby();

	void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL);

	void OnConnectionFail(DisconnectCause BMDDEFBNHAL);

	void OnDisconnectedFromPhoton();

	void OnPhotonInstantiate(PhotonMessageInfo DAGALCAILLN);

	void OnReceivedRoomListUpdate();

	void OnJoinedRoom();

	void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM);

	void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ);

	void OnPhotonRandomJoinFailed(object[] APELDCFFFOH);

	void OnConnectedToMaster();

	void OnPhotonMaxCccuReached();

	void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK);

	void OnPhotonPlayerPropertiesChanged(object[] EMIPGAIEKMK);

	void OnUpdatedFriendList();

	void OnCustomAuthenticationFailed(string ONHDMMPKKFH);

	void OnCustomAuthenticationResponse(Dictionary<string, object> NOJGGCLPPAM);

	void OnWebRpcResponse(OperationResponse NEKOLHLOPCJ);

	void OnOwnershipRequest(object[] AHDLHDMNGMP);

	void OnLobbyStatisticsUpdate();

	void OnPhotonPlayerActivityChanged(PhotonPlayer MCDOIGNGJBJ);

	void OnOwnershipTransfered(object[] MMOAKBJOOHM);
}
