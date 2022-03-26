/*
No one uses this anymore.

I want to rework recording functionality to modify arcs not just add arcs
*/

using System;

public class EditorKeyBindHandler : Singleton<EditorKeyBindHandler>
{
	private void Start()
	{
		this.up.Init("[Up]", null);
		this.right.Init("[Right]", null);
		this.down.Init("[Down]", null);
		this.left.Init("[Left]", null);
	}

	private void Update() { }

	public CustomEventEditorHandler_ArcSelector up;
	public CustomEventEditorHandler_ArcSelector right;
	public CustomEventEditorHandler_ArcSelector down;
	public CustomEventEditorHandler_ArcSelector left;
}
