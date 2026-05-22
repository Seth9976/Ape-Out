using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200006B RID: 107
	[StructLayout(2)]
	public struct LobbyEnter_t
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x00029860 File Offset: 0x00027A60
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyEnter_t()
		{
			Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyEnter_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr);
			LobbyEnter_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "k_iCallback");
			LobbyEnter_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyEnter_t.NativeFieldInfoPtr_m_rgfChatPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_rgfChatPermissions");
			LobbyEnter_t.NativeFieldInfoPtr_m_bLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_bLocked");
			LobbyEnter_t.NativeFieldInfoPtr_m_EChatRoomEnterResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_EChatRoomEnterResponse");
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00003CE3 File Offset: 0x00001EE3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000298F4 File Offset: 0x00027AF4
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00003CF5 File Offset: 0x00001EF5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyEnter_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyEnter_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_m_rgfChatPermissions;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_m_bLocked;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_m_EChatRoomEnterResponse;

		// Token: 0x04000595 RID: 1429
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000596 RID: 1430
		[FieldOffset(8)]
		public uint m_rgfChatPermissions;

		// Token: 0x04000597 RID: 1431
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bLocked;

		// Token: 0x04000598 RID: 1432
		[FieldOffset(16)]
		public uint m_EChatRoomEnterResponse;
	}
}
