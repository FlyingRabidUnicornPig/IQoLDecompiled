/*
Purpose of this class: ClientState enum
*/

using System;

// Token: 0x020002FD RID: 765
public enum ClientState
{
	// Token: 0x04001469 RID: 5225
	Uninitialized,
	// Token: 0x0400146A RID: 5226
	PeerCreated,
	// Token: 0x0400146B RID: 5227
	Queued,
	// Token: 0x0400146C RID: 5228
	Authenticated,
	// Token: 0x0400146D RID: 5229
	JoinedLobby,
	// Token: 0x0400146E RID: 5230
	DisconnectingFromMasterserver,
	// Token: 0x0400146F RID: 5231
	ConnectingToGameserver,
	// Token: 0x04001470 RID: 5232
	ConnectedToGameserver,
	// Token: 0x04001471 RID: 5233
	Joining,
	// Token: 0x04001472 RID: 5234
	Joined,
	// Token: 0x04001473 RID: 5235
	Leaving,
	// Token: 0x04001474 RID: 5236
	DisconnectingFromGameserver,
	// Token: 0x04001475 RID: 5237
	ConnectingToMasterserver,
	// Token: 0x04001476 RID: 5238
	QueuedComingFromGameserver,
	// Token: 0x04001477 RID: 5239
	Disconnecting,
	// Token: 0x04001478 RID: 5240
	Disconnected,
	// Token: 0x04001479 RID: 5241
	ConnectedToMaster,
	// Token: 0x0400147A RID: 5242
	ConnectingToNameServer,
	// Token: 0x0400147B RID: 5243
	ConnectedToNameServer,
	// Token: 0x0400147C RID: 5244
	DisconnectingFromNameServer,
	// Token: 0x0400147D RID: 5245
	Authenticating
}
