/*
Obfuscated as EGOPKJHICLK in vanilla.dll
Was previously named YAFECWOW.cs

Importance of this class: Compress strings for, nothing? Maybe look more into.

~~Yet another fucking encryption class why oxy, why?~~
 This isn't encryption you fucking moron it's compression
  I mean look at Crypto.cs you dipshit,
  it has a whole lot fucking more than just one line of code
 What you should be mad about is the fact it seems to serve
  no fucking purpose in anything. 
 It's just, "does something" but that something is never used,
  it was wasted (i think atleast)
*/

using System;
using System.Text;

internal static class StringCompressor
{
	public static string CompressString(string fuckYou) => Convert.ToBase64String(Encoding.UTF8.GetBytes(fuckYou));

	public static string DecompressString(string fuckYou) => Encoding.UTF8.GetString(Convert.FromBase64String(fuckYou));
}
