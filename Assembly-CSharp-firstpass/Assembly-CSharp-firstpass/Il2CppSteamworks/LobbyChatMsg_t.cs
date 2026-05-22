using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200006E RID: 110
	[StructLayout(2)]
	public struct LobbyChatMsg_t
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x00029A5C File Offset: 0x00027C5C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatMsg_t()
		{
			Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr);
			LobbyChatMsg_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "k_iCallback");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_ulSteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_ulSteamIDUser");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_eChatEntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_eChatEntryType");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_iChatID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_iChatID");
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00003D43 File Offset: 0x00001F43
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00029AF0 File Offset: 0x00027CF0
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00003D55 File Offset: 0x00001F55
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDUser;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_m_eChatEntryType;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_m_iChatID;

		// Token: 0x040005AE RID: 1454
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x040005AF RID: 1455
		[FieldOffset(8)]
		public ulong m_ulSteamIDUser;

		// Token: 0x040005B0 RID: 1456
		[FieldOffset(16)]
		public byte m_eChatEntryType;

		// Token: 0x040005B1 RID: 1457
		[FieldOffset(20)]
		public uint m_iChatID;
	}
}
