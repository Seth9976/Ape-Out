using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200006D RID: 109
	[StructLayout(2)]
	public struct LobbyChatUpdate_t
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x000299AC File Offset: 0x00027BAC
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatUpdate_t()
		{
			Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyChatUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr);
			LobbyChatUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "k_iCallback");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_ulSteamIDUserChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_ulSteamIDUserChanged");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_ulSteamIDMakingChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_ulSteamIDMakingChange");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_rgfChatMemberStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_rgfChatMemberStateChange");
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00003D23 File Offset: 0x00001F23
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00029A40 File Offset: 0x00027C40
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00003D35 File Offset: 0x00001F35
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyChatUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyChatUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDUserChanged;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDMakingChange;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_m_rgfChatMemberStateChange;

		// Token: 0x040005A5 RID: 1445
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x040005A6 RID: 1446
		[FieldOffset(8)]
		public ulong m_ulSteamIDUserChanged;

		// Token: 0x040005A7 RID: 1447
		[FieldOffset(16)]
		public ulong m_ulSteamIDMakingChange;

		// Token: 0x040005A8 RID: 1448
		[FieldOffset(24)]
		public uint m_rgfChatMemberStateChange;
	}
}
