/*
Importance of this class: Pretty important for editor. Button that opens drop-down on click.

Purpose of this class: Drop Down Menu

Deobf status: Stuck with 3 methods that basically do the same thing cause good game dev.
              The event assign
*/

using System;
using UnityEngine;

public class DropdownMenuButton : MonoBehaviour
{
	// Unsure if needed, keeping in case. Was the exact same code as ToggleSubmenu(bool).
	public void SetActive(bool active) => ToggleSubmenu(active);

	// Used when opening dropdown afaik
	public void ToggleSubmenu() => this.submenuCanvas.SetActive(!this.submenuCanvas.activeSelf);

	// Used when closing dropdown afaik
	public void ToggleSubmenu(bool active)
	{
		this.submenuCanvas.SetActive(active);

		if (!active)
			Singleton<UI>.Instance.ClearSelection();
	}

	private void Start() { }

	private void Update() { }

	public GameObject submenuCanvas;
}
