/*
Importance of this class: Potentially important to multiplayer (likely why the classname itself is obfuscated).

Purpose of this class: Almost certainly related to multiplayer room.
Obfuscated title insuinuates this is important, but it seems to be a simple data-storage class.

Deobf status: None except for title. I feel like there may be hidden code not decompiled.
This may be irreversible/uneditable.
*/

using System;
using ExitGames.Client.Photon;

internal class AKBOPCNHFFJ
{
	public string RoomName;

	public RoomOptions RoomOptions;

	public TypedLobby Lobby;

	public Hashtable PlayerProperties;

	public bool OnGameServer = true;

	public bool CreateIfNotExists;

	public bool RejoinOnly;

	public string[] ExpectedUsers;
}
