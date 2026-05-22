using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200006A RID: 106
	[StructLayout(2)]
	public struct LobbyInvite_t
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x000297C4 File Offset: 0x000279C4
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyInvite_t()
		{
			Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyInvite_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr);
			LobbyInvite_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "k_iCallback");
			LobbyInvite_t.NativeFieldInfoPtr_m_ulSteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "m_ulSteamIDUser");
			LobbyInvite_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyInvite_t.NativeFieldInfoPtr_m_ulGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "m_ulGameID");
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00003CC3 File Offset: 0x00001EC3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00029844 File Offset: 0x00027A44
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00003CD5 File Offset: 0x00001ED5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyInvite_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyInvite_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDUser;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_m_ulGameID;

		// Token: 0x0400058D RID: 1421
		[FieldOffset(0)]
		public ulong m_ulSteamIDUser;

		// Token: 0x0400058E RID: 1422
		[FieldOffset(8)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x0400058F RID: 1423
		[FieldOffset(16)]
		public ulong m_ulGameID;
	}
}
