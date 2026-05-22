using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200006C RID: 108
	[StructLayout(2)]
	public struct LobbyDataUpdate_t
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x00029910 File Offset: 0x00027B10
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyDataUpdate_t()
		{
			Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyDataUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr);
			LobbyDataUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "k_iCallback");
			LobbyDataUpdate_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyDataUpdate_t.NativeFieldInfoPtr_m_ulSteamIDMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "m_ulSteamIDMember");
			LobbyDataUpdate_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "m_bSuccess");
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00003D03 File Offset: 0x00001F03
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00029990 File Offset: 0x00027B90
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00003D15 File Offset: 0x00001F15
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyDataUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyDataUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDMember;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x0400059D RID: 1437
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x0400059E RID: 1438
		[FieldOffset(8)]
		public ulong m_ulSteamIDMember;

		// Token: 0x0400059F RID: 1439
		[FieldOffset(16)]
		public byte m_bSuccess;
	}
}
