/*
Importance of this class: Used by game scene.... Tell gamescene to use crypto or console instead fuck.

Purpose of this class: Yet another fucking encryption class why oxy, why?
*/

using System;
using System.Text;

internal static class YAFECWOW
{
	public static string CompressString(string fuckYou) => Convert.ToBase64String(Encoding.UTF8.GetBytes(fuckYou));

	public static string DecompressString(string fuckYou) => Encoding.UTF8.GetString(Convert.FromBase64String(fuckYou));
}
