/*
Importance of this class:

Purpose of this class:

Deobf status:
*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditorEvent : MonoBehaviour
{
	public void UpdatePositionFromData()
	{
		float audioLength = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;

		// Keep time within range (i may get rid of this, i kinda want to have events before or after)
		this.mapEvent.time = this.mapEvent.time < 0f          ? 0f
		                   : this.mapEvent.time > audioLength ? audioLength 
		                   : this.mapEvent.time;

		base.transform.localPosition = new Vector3(this.mapEvent.time, this.FindYPosition());
	}

	private void Awake() => this.IsSelected = false;

	public void Deselect()
	{
		this.IsSelected = false;
		this.UpdateIcon();
	}

	public void Update()
	{
		// If not on screen, turn off and stop updating
		if (!this.IsVisible())
		{
			this.MakeVisible(false);
			return;
		}

		// Turn on just in case
		// If the data had changed since last frame we will run the whole method to update our imageActive bool vars
		this.MakeVisible(true, this.lastData != this.mapEvent.data);
		this.lastData = this.mapEvent.data;

		// If we're visible and the zoom has changed or its our first visible frame, update
		if (this.bitObj.active && (!this.ranOnce || Camera.main.orthographicSize != MapEditor.lastZoom))
		{
			this.ranOnce = true; // Make sure we run this the first frame to set scale and other bs. Otherwise stay optimized.

			float y = this.mapEvent.data.Contains("SpawnObj") ? 0.5f : 1f; // Changes the y scaling if an arc, makes arc events smaller

			if (this.bitObj != null && this.bitObj.activeSelf)
				this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 50f, y, this.scaleMult.z);

			if (this.iconSprite != null && this.iconSprite.activeSelf)
				this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 5f, Camera.main.orthographicSize / 5f, 1f);
		}
	}

	public void UpdateEvent()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			this.UpdatePositionFromData();
			this.UpdateIcon();
			this.Update();
		}
	}

	public EditorEvent()
	{
		this.scaleMult = new Vector3(1f, 1f, 1f);

		this.iconSpriteActive = false;
		this.imageRightActive = false;
		this.imageCenterActive = false;
	}

	public bool IsSelected
	{
		get => this.selected;
		set
		{
			this.selected = value;
			this.selectedMarker.SetActive(this.selected);
		}
	}

	public void Select()
	{
		this.IsSelected = true;
		this.UpdateIcon();
	}

	public void UpdateIcon()
	{
		if (this.mapEvent.data != null)
		{
			this.iconSpriteActive = false;
			this.imageRightActive = false;
			this.imageCenterActive = false;

			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				SetColor(new Color(0f, 0.7f, 0f)); // Set color to mild Green

				// What extra mods are we supposed to make to this Event?
				switch (this.mapEvent.data[0])
				{
					case "SetBGColor":
						this.SetUpForBG();
						break;
					case "checkpoint":
						this.SetUpForCheckpoint();
						break;
					case "ShowSprite":
						this.SetUpForSprite();
						break;
					case "SpawnObj":
						this.SetUpForArc();
						break;
					case "ShowTitle":
						this.SetUpForTitle();
						break;
					default:
						break;
				}
			}
			else
			{
				SetColor(new Color(1f, 0f, 0f)); // Set color to red, something's wrong
			}
		}
	}

	private float FindYPosition()
	{
		// Whenever we have more than 2 tracks, we will need to track the Track the event is tracking
		if (Singleton<MapEditor>.Instance.eventsCanvases.Count != 2)
			return Singleton<MapEditor>.Instance.eventsCanvases[this.TrackID].grid.position.y;

		// otherwise check if storyboard event, if yes, use y position of storyboard track, otherwise use gameplay track's y position
		bool isStoryboard = Helpers.IsStoryboardEvent(this.mapEvent.data[0]);
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(
			x => x.forType == isStoryboard ? MapEditor.EventType.Storyboard : MapEditor.EventType.Gameplay).grid.position.y;
	}

	private bool IsVisible()
	{
		Vector3 vector = Camera.main.WorldToScreenPoint(base.transform.position);

		// Is your mom (arc pattern sprite) fat (uses left or right arcs)?
		float arcMod = EditorEvent.yourMomIsSoFat.Contains(this.yourMom) ? 100f : 50f;
		float spriteMod = this.imageRightActive ? 200f : 0f;

		// Am I on screen?
		return vector.x >= -arcMod - spriteMod
		    && vector.x <= (float)Screen.width + (this.imageRightActive ? 0f : arcMod)
			&& vector.y >= 0f
			&& vector.y <= (float)Screen.height;
	}

	private void MakeVisible(bool visible) => this.MakeVisible(visible, false);

	private void MakeVisible(bool visible, bool overrideOptimization = true)
	{
		// Only update if last frame's visible status is different than this, or if told to override
		if (overrideOptimization || visible != this.lastVisible)
		{
			this.bitObj.GetComponent<Renderer>().enabled = visible;

			this.iconSprite.SetActive(this.iconSpriteActive && visible);

			if (this.imageCenter.gameObject != null)
				this.imageCenter.gameObject.SetActive(this.imageCenterActive && visible);

			if (this.imageRight.gameObject != null)
				this.imageRight.gameObject.SetActive(this.imageRightActive && visible);

			this.lastVisible = visible;
		}
	}

	private void SetUpForBG()
	{
		try
		{
			this.imageRight.sprite = Resources.LoadAll<Sprite>("LevelEditor/icons")[0]; // blank color background image
			this.imageRight.color = Helpers.StringToColor(this.mapEvent.data[1]); // color it
			this.iconSpriteActive = true; // turn on image
			this.imageRightActive = true; // The right one specifically (pokes out of right side of bit)
		}
		catch (Exception ex)
		{
			Debug.Log("[EditorEvent] Exception: " + ex.Message);
		}
	}

	private void SetUpForCheckpoint()
	{
		this.scaleMult.y = 2.5f; // Enlarge
		
		try
		{
			SetColor(new Color(0.7f, 0.7f, 0f)); // Color it yellow
		}
		catch (Exception ex)
		{
			Debug.Log("[EditorEvent] Exception: " + ex.Message);
		}
	}

	private void SetUpForSprite()
	{
		try
		{
			string[] array = this.mapEvent.data[1].Split(',');

			if (array.Length != 0)
			{
				this.imageRight.color = Color.white;

				FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID());

				if (mapData.mapData.levelResources.Exists(x => x.name == array[0]))
				{
					this.imageRight.sprite = (Sprite)mapData.resources[array[0]];
				}
				else
				{
					this.imageRight.sprite = null;
					this.imageRight.color = new Color(1f, 0f, 1f);
				}

				this.iconSpriteActive = true;
				this.imageRightActive = true;
			}
		}
		catch (Exception ex)
		{
			Debug.Log("[EditorEvent] Exception: " + ex.Message);
		}
	}

	private void SetUpForArc()
	{
		try
		{
			if (this.mapEvent.data[1].Split(',').Length == 1)
				this.yourMom = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(x => x.Contains(this.mapEvent.data[1])));
			else
				this.yourMom = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(x => x.Contains(this.mapEvent.data[1].Split(',')[0])));
			
			this.imageCenter.sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[this.yourMom];
			this.imageCenter.color = Color.white;

			this.iconSpriteActive = true;
			this.imageCenterActive = true;
		}
		catch (Exception ex)
		{
			Debug.Log("[EditorEvent] Exception: " + ex.Message);
		}
	}

	private void SetUpForTitle()
	{
		try
		{
			this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("LevelEditor/icons")[2];
			this.imageCenter.GetComponentInChildren<Image>().color = Color.white;

			this.iconSpriteActive = true;
			this.imageCenterActive = true;
		}
		catch (Exception ex)
		{
			Debug.Log("[EditorEvent] Exception: " + ex.Message);
		}
	}

	public int TrackID
	{
		get => this.trackID;
		set => this.trackID = value;
	}

	public void SetColor(Color color)
	{
		this.bitObj.GetComponent<Renderer>().material.SetColor("_Color", color);
		this.bitObj.GetComponent<Renderer>().material.SetColor("_EmissionColor", color);
	}

	private bool selected;

	[HideInInspector]
	public MapEvent mapEvent;

	public GameObject bitObj;
	public GameObject selectedMarker;
	public GameObject iconSprite;

	// I feel like this could be a memory/optimization issue
	// we only need one image yet we have 2 and then the iconSprite gameObject...
	// We aren't going to use both imageRight and imageCenter, nor will we use iconSprite while using the others.
	public Image imageRight;
	public Image imageCenter;

	[HideInInspector]
	public Vector3 scaleMult;

	[HideInInspector]
	public int lastDataCount;

	public DragController dragController;

	private bool ranOnce;
	private bool lastVisible;

	private bool iconSpriteActive;
	private bool imageRightActive;
	private bool imageCenterActive;

	// Optimization vars
	private List<string> lastData;
	// Stores pattern index of arcs for optimization rules
	private int yourMom;
	// Contains every arc pattern index that would benefit from a tweak in optimization
	// (everything with a left or right arc that seemingly "pop" out of existance on edges when using normal opt)
	private static int[] yourMomIsSoFat = new int[]
	{
		1,
		3,
		4,
		5,
		6,
		7,
		8,
		10,
		12,
		13,
		14,
		15
	};

	private int trackID;
}
