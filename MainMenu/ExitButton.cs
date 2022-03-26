/*
Did you know the arcs don't have a class in vanilla? Even the exit button has more code dedicated to it (OOP style at least) than arcs.
*/

using System;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
	public void OnClick() => Application.Quit();
}
