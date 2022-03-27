/*
Purpose of this class: FPS Counter on the top left
*/

using System;
using UnityEngine;

public class FPSSettings : MonoBehaviour
{
	public void EnableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 1, null);
		this.InitFPS();
	}

	public void SetFPSEnabled(bool enable)
	{
		if (!enable)
			this.DisableFPS();
		else
			this.EnableFPS();
	}

	private void OnGUI()
	{
		if (this.showFPS)
		{
			int width = Screen.width;
			int height = Screen.height;
			Rect position = new Rect(0f, 0f, (float)width, (float)(height * 2 / 100));

			GUIStyle guistyle = new GUIStyle();
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = height * 2 / 100;
			guistyle.normal.textColor = new Color(1f, 1f, 1f, 1f);

			float num = this.frameTime * 1000f;
			float num2 = 1f / this.frameTime;
			string text = string.Format("{0:0.0} ms ({1:0.} fps)", num, num2);

			GUI.Label(position, text, guistyle);
		}
	}

	private void Start() => this.InitFPS();

	public void ToggleFPS()
	{
		if (this.IsFPSEnabled())
			this.DisableFPS();
		else
			this.EnableFPS();
	}

	public bool IsFPSEnabled()
	{
		bool result = false;

		if (Singleton<SaveSystem>.Instance.HasKey("settings.fps", null))
			result = (Singleton<SaveSystem>.Instance.GetInt("settings.fps", null) == 1);
		else
			Singleton<SaveSystem>.Instance.SetInt("settings.fps", 0, null);

		return result;
	}

	public void InitFPS() => this.showFPS = this.IsFPSEnabled();

	private void Update()
	{
		if (this.showFPS)
			this.frameTime += (Time.deltaTime - this.frameTime) * 0.1f;
	}

	public void DisableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 0, null);
		this.InitFPS();
	}

	public bool showFPS;

	private float frameTime;
}
