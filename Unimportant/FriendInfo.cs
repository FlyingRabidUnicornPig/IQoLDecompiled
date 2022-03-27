/*
Importance of this class: Used by bngighbhpeph, may be unimportant

Purpose of this class: friend info
*/

using System;

public class FriendInfo
{
	public string Name { get; protected internal set; }

	public bool IsOnline { get; protected internal set; }

	public override string ToString()
		=> string.Format("{0}\t is: {1}",
		   this.Name,
		   this.IsOnline ? (!this.IsInRoom ? "on master" : "playing") : "offline");

	public string Room { get; protected internal set; }

	public bool IsInRoom => this.IsOnline && !string.IsNullOrEmpty(this.Room);
}
