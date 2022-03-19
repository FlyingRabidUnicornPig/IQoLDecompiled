/*
Purpose of this class: CustomAuthenticationType enum
*/

using System;

public enum CustomAuthenticationType : byte
{
	Custom,
	Steam,
	Facebook,
	Oculus,
	PlayStation,
	Xbox,
	None = 255
}
