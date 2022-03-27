/*
Importance of this class: File Selector using Oxy's UI

Purpose of this class: Select files
*/

using System;
using System.Collections;
using System.IO;
using OxOD;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FileSelector : MonoBehaviour
{
	public void SelectFile() => base.StartCoroutine(this.Select(this.result));

	public IEnumerator Select(string path)
	{
		Debug.Log("[FileSelector] Starting file dialog");

		if (this.mode == FileDialog.FileDialogMode.Open)
			yield return base.StartCoroutine(
				this.dialog.Open(path, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		else
			yield return base.StartCoroutine(
				this.dialog.Save(path, this.extensions, "SAVE FILE", null, this.saveLastPath));

		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);

			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
			Debug.Log("[FileSelector] Dialog canceled");

		yield break;
	}

	public FileSelector()
	{
		this.maxSize = -1;
		this.saveLastPath = true;
	}

	[Header("OxOD Reference")]
	public FileDialog dialog;

	[Header("File Dialog Options")]
	public FileDialog.FileDialogMode mode;

	public string extensions;

	public int maxSize;

	public bool saveLastPath;

	[Header("Events")]
	public UnityEvent OnFileSelected;
	public FileSelector.StringEvent OnFileSelectedString;

	[Header("Internal References")]
	public InputField selectedFile;

	[HideInInspector]
	public string result;

	[Serializable]
	public class StringEvent : UnityEvent<string> { }
}
