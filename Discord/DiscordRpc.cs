/*
Purpose of this class: Seems to be a base RichPresence class, possibly by discord 'emselves

Deobf status: Method parameters
*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using AOT;

public class DiscordRpc
{
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
	public static extern void RunCallbacks();

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
	public static extern void Shutdown();

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
	public static extern void Initialize(string JPBEMOKPPHG, ref DiscordRpc.EventHandlers DEBDALGLNCD, bool CIBECHNCFMF, string PDIMPIHMKJE);

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_ClearPresence")]
	public static extern void ClearPresence();

	[MonoPInvokeCallback(typeof(DiscordRpc.OnErrorInfo))]
	public static void ErrorCallback(int PNCJHNNOAAP, string JKPJCEMPAGH) { }

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
	private static extern void Update(ref DiscordRpc.RichPresenceStruct LBKOCHOCABF);

	[MonoPInvokeCallback(typeof(DiscordRpc.OnSpectateInfo))]
	public static void SpectateCallback(string MJDPJLOCLIL) { }

	public static void UpdatePresence(DiscordRpc.RichPresence LBKOCHOCABF)
	{
		DiscordRpc.RichPresenceStruct richPresenceStruct = LBKOCHOCABF.CreateRPCStruct();
		DiscordRpc.Update(ref richPresenceStruct);
		LBKOCHOCABF.FreeMemory();
	}

	[MonoPInvokeCallback(typeof(DiscordRpc.OnDisconnectedInfo))]
	public static void DisconnectedCallback(int PNCJHNNOAAP, string JKPJCEMPAGH) { }

	[MonoPInvokeCallback(typeof(DiscordRpc.OnJoinInfo))]
	public static void JoinCallback(string MJDPJLOCLIL) { }

	[MonoPInvokeCallback(typeof(DiscordRpc.OnReadyInfo))]
	public static void ReadyCallback(ref DiscordRpc.DiscordUser OCGEBABNLAG) { }

	[MonoPInvokeCallback(typeof(DiscordRpc.OnRequestInfo))]
	public static void RequestCallback(ref DiscordRpc.DiscordUser GILCPIJNOKK) { }

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Respond")]
	public static extern void Respond(string DJACMLGPOJB, DiscordRpc.Reply GPDFCKMMIDI);

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdateHandlers")]
	public static extern void UpdateHandlers(ref DiscordRpc.EventHandlers DEBDALGLNCD);

	public delegate void OnReadyInfo(ref DiscordRpc.DiscordUser OCGEBABNLAG);

	public delegate void OnDisconnectedInfo(int PNCJHNNOAAP, string JKPJCEMPAGH);

	public delegate void OnErrorInfo(int PNCJHNNOAAP, string JKPJCEMPAGH);

	public delegate void OnJoinInfo(string MJDPJLOCLIL);

	public delegate void OnSpectateInfo(string MJDPJLOCLIL);

	public delegate void OnRequestInfo(ref DiscordRpc.DiscordUser GILCPIJNOKK);

	public struct EventHandlers
	{
		public DiscordRpc.OnReadyInfo readyCallback;
		public DiscordRpc.OnDisconnectedInfo disconnectedCallback;
		public DiscordRpc.OnErrorInfo errorCallback;
		public DiscordRpc.OnJoinInfo joinCallback;
		public DiscordRpc.OnSpectateInfo spectateCallback;
		public DiscordRpc.OnRequestInfo requestCallback;
	}

	[Serializable]
	public struct RichPresenceStruct
	{
		public IntPtr state;
		public IntPtr details;

		public long startTimestamp;
		public long endTimestamp;

		public IntPtr largeImageKey;
		public IntPtr largeImageText;
		public IntPtr smallImageKey;
		public IntPtr smallImageText;

		public IntPtr partyId;
		public int partySize;
		public int partyMax;

		public IntPtr matchSecret;
		public IntPtr joinSecret;
		public IntPtr spectateSecret;

		public bool instance;
	}

	[Serializable]
	public struct DiscordUser
	{
		public string userId;
		public string username;
		public string discriminator;
		public string avatar;
	}

	public enum Reply
	{
		No,
		Yes,
		Ignore
	}

	public class RichPresence
	{
		internal DiscordRpc.RichPresenceStruct CreateRPCStruct()
		{
			if (this.memorycounteridfk.Count > 0)
				this.FreeMemory();

			this.structCreation.state = this.EncodeIThink(this.state);
			this.structCreation.details = this.EncodeIThink(this.details);

			this.structCreation.startTimestamp = this.startTimestamp;
			this.structCreation.endTimestamp = this.endTimestamp;
			
			this.structCreation.largeImageKey = this.EncodeIThink(this.largeImageKey);
			this.structCreation.largeImageText = this.EncodeIThink(this.largeImageText);
			this.structCreation.smallImageKey = this.EncodeIThink(this.smallImageKey);
			this.structCreation.smallImageText = this.EncodeIThink(this.smallImageText);
			
			this.structCreation.partyId = this.EncodeIThink(this.partyId);
			this.structCreation.partySize = this.partySize;
			this.structCreation.partyMax = this.partyMax;
			
			this.structCreation.matchSecret = this.EncodeIThink(this.matchSecret);
			this.structCreation.joinSecret = this.EncodeIThink(this.joinSecret);
			this.structCreation.spectateSecret = this.EncodeIThink(this.spectateSecret);
			
			this.structCreation.instance = this.instance;
			return this.structCreation;
		}

		internal void FreeMemory()
		{
			for (int i = this.memorycounteridfk.Count - 1; i >= 0; i--)
			{
				Marshal.FreeHGlobal(this.memorycounteridfk[i]);
				this.memorycounteridfk.RemoveAt(i);
			}
		}

		public RichPresence()
		{
			this.memorycounteridfk = new List<IntPtr>(10);
		}

		private IntPtr EncodeIThink(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			this.memorycounteridfk.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private DiscordRpc.RichPresenceStruct structCreation;

		private readonly List<IntPtr> memorycounteridfk;

		public string state;
		public string details;

		public long startTimestamp;
		public long endTimestamp;

		public string largeImageKey;
		public string largeImageText;
		public string smallImageKey;
		public string smallImageText;

		public string partyId;
		public int partySize;
		public int partyMax;

		public string matchSecret;
		public string joinSecret;
		public string spectateSecret;

		public bool instance;
	}
}
