/*
Importance of this class: Pretty important, defines an event in the event config editor

Purpose of this class: Defines the strcture of EditorEvent config editor functions.
*/

using System;
using System.Collections.Generic;

public class EditorEventFunctionInfo
{
	public EditorEventFunctionInfo(
		string id,
		string functionName,
		List<EditorEventFunctionInfo.EditorEventParametr> parameters,
		string functionDescription,
		int minConfigVersion = 1,
		int maxConfigVersion = -1,
		// NOTE: may want to make a eventTypeless version, in anticipation of the multitrack update
		EditorEventFunctionInfo.EditorEventType eventType = EditorEventFunctionInfo.EditorEventType.Storyboard)
	{
		this.eventType = EditorEventFunctionInfo.EditorEventType.Storyboard;
		this.id = id;
		this.functionName = functionName;
		this.parameters = parameters;
		this.functionDescription = functionDescription;
		this.minConfigVersion = minConfigVersion;
		this.maxConfigVersion = maxConfigVersion;
		this.eventType = eventType;
	}

	public List<EditorEventFunctionInfo.EditorEventParametr> parameters;

	public string id;

	public string functionName;
	public string functionDescription;

	public int minConfigVersion;
	public int maxConfigVersion;

	public EditorEventFunctionInfo.EditorEventType eventType;

	// ToAdd: Color Selector, Image Cropper, Shader Selector, Skin Selector (could be inputfield tbh)
	public enum EditorEventParametrType
	{
		InputField, // Text box
		Slider, // Slider
		Toggle, // Checkbox
		ArcSelector // Arc Selector
	}

	// Note: may want to edit this in anticipation of multitrack update, a Custom/Other?
	public enum EditorEventType
	{
		Arcs,
		Storyboard
	}

	public class EditorEventParametr
	{
		public EditorEventParametr(string name, EditorEventFunctionInfo.EditorEventParametrType editor, string description, string data = null)
		{
			this.name = name;
			this.editor = editor;
			this.description = description;
			this.data = data;
		}

		public EditorEventFunctionInfo.EditorEventParametrType editor;

		public string name;
		public string description;
		public string data;
	}
}
