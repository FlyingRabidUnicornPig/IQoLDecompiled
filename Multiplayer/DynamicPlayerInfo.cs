/*
Importance of this class: Decently Important to multiplayer

Purpose of this class: Displays a player and their score/place in a multiplayer game
*/

using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020006A4 RID: 1700
public class DynamicPlayerInfo : MonoBehaviour
{
	public DynamicPlayerInfo()
	{
		// Unlikely to get on first hit. If you do, well ok nerd.
		this.lastScore = -69;
	}

	// Token: 0x060117C3 RID: 71619
	private void Update()
	{
		if (this.updateInfo)
			this.UpdateScore();
	}

	// Token: 0x060117D6 RID: 71638
	private void UpdateScore()
	{
		this.currentScore = this.player.GetScore();

		// Mod: Only update when scores change (does this really change anything? idk if this actually optimizes things)
		if (this.lastScore == this.currentScore) return;

		this.scoreText.text = "" + this.currentScore;
		this.lastScore = this.currentScore;
	}

	public bool updateInfo;

	public Text scoreText;
	public PhotonPlayer player;
	public Image icon;

	public int currentScore;
	// Mod
	private int lastScore;
}
