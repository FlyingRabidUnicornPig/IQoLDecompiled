/*
Chat
*/

using System;
using System.Collections.Generic;
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class InRoomChat : Photon.MonoBehaviour
{
	public void OnGUI()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.KeypadEnter || Event.current.keyCode == KeyCode.Return))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				base.photonView.RPC("Chat", PhotonTargets.All, new object[]
				{
					this.LHMPNAANKMC
				});
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("ChatInput");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[0]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 1; i >= 0; i--)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[0]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("ChatInput");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		if (GUILayout.Button("Send", new GUILayoutOption[]
		{
			GUILayout.ExpandWidth(false)
		}))
		{
			base.photonView.RPC("Chat", PhotonTargets.All, new object[]
			{
				this.LHMPNAANKMC
			});
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void AddLine(string PDDLDFCMAOO)
	{
		this.messages.Add(PDDLDFCMAOO);
	}

	[PunRPC]
	public void Chat(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "anonymous";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "player " + MKLKGCPAPOC.sender.ID;
			}
		}
		this.messages.Add(str + ": " + PDDLDFCMAOO);
	}

	public void Start()
	{
		if (this.AlignBottom)
		{
			this.GuiRect.y = (float)Screen.height - this.GuiRect.height;
		}
	}

	public Rect GuiRect = new Rect(0f, 0f, 250f, 300f);

	public bool IsVisible = true;

	public bool AlignBottom;

	public List<string> messages = new List<string>();

	private string LHMPNAANKMC = string.Empty;

	private Vector2 BMHLPJCOMAA = Vector2.zero;

	public static readonly string ChatRPC = "Chat";
}
