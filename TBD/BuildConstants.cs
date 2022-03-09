/*
Importance of this class: Not very important. releaseType may determine console behavior. Currently console only shows warnings and errors.
Set to ReleaseType.Debug may allow low-level prints to come through.

Purpose of this class: Constants that describe the current build of the game.
*/

using System;

public static class BuildConstants
{
	public static readonly DateTime buildDate = new DateTime(637172875801193637L);

	// Unused since Helpers.GetGameVersion() changed to return "Intralism QoL Mod"
	public const string version = "5.5.0.3492";

	// Changing to "Debug" may allow non-warning/error console prints
	public const BuildConstants.ReleaseType releaseType = BuildConstants.ReleaseType.Release;
	
	public const BuildConstants.Platform platform = BuildConstants.Platform.PC;

	public const BuildConstants.Architecture architecture = BuildConstants.Architecture.Windows_x64;

	public const BuildConstants.Distribution distribution = BuildConstants.Distribution.None;

	public enum ReleaseType
	{
		None,
		Debug,
		Release
	}

	public enum Platform
	{
		None,
		Linux,
		OSX,
		PC
	}

	public enum Architecture
	{
		None,
		Linux_Universal,
		OSX_Universal,
		Windows_x86,
		Windows_x64
	}

	public enum Distribution
	{
		None
	}
}
