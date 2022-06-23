// Unsure if this is needed

using System;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
	private void OnDisable()
	{
		Application.RegisterLogCallback(null);
	}

	private void Queue(string idk, string unused, LogType unususedType)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + " - " + idk);
		if (global::Logger.IBNJECONNLP.Count > 5)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(0f, (float)(Screen.height - 140), (float)Screen.width, 140f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	private void OnEnable()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.Queue));
	}

	private static Queue<string> IBNJECONNLP = new Queue<string>(6);
}
