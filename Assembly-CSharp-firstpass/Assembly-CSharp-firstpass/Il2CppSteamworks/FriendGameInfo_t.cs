using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200012B RID: 299
	[StructLayout(2)]
	public struct FriendGameInfo_t
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x0002FE4C File Offset: 0x0002E04C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameInfo_t()
		{
			Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendGameInfo_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr);
			FriendGameInfo_t.NativeFieldInfoPtr_m_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_gameID");
			FriendGameInfo_t.NativeFieldInfoPtr_m_unGameIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_unGameIP");
			FriendGameInfo_t.NativeFieldInfoPtr_m_usGamePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_usGamePort");
			FriendGameInfo_t.NativeFieldInfoPtr_m_usQueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_usQueryPort");
			FriendGameInfo_t.NativeFieldInfoPtr_m_steamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_steamIDLobby");
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000060B9 File Offset: 0x000042B9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeFieldInfoPtr_m_gameID;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeFieldInfoPtr_m_unGameIP;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeFieldInfoPtr_m_usGamePort;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeFieldInfoPtr_m_usQueryPort;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDLobby;

		// Token: 0x04000C8C RID: 3212
		[FieldOffset(0)]
		public CGameID m_gameID;

		// Token: 0x04000C8D RID: 3213
		[FieldOffset(8)]
		public uint m_unGameIP;

		// Token: 0x04000C8E RID: 3214
		[FieldOffset(12)]
		public ushort m_usGamePort;

		// Token: 0x04000C8F RID: 3215
		[FieldOffset(14)]
		public ushort m_usQueryPort;

		// Token: 0x04000C90 RID: 3216
		[FieldOffset(16)]
		public CSteamID m_steamIDLobby;
	}
}
