using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000071 RID: 113
	[StructLayout(2)]
	public struct LobbyKicked_t
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00029C30 File Offset: 0x00027E30
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyKicked_t()
		{
			Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyKicked_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr);
			LobbyKicked_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "k_iCallback");
			LobbyKicked_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyKicked_t.NativeFieldInfoPtr_m_ulSteamIDAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "m_ulSteamIDAdmin");
			LobbyKicked_t.NativeFieldInfoPtr_m_bKickedDueToDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "m_bKickedDueToDisconnect");
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00003DA3 File Offset: 0x00001FA3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00029CB0 File Offset: 0x00027EB0
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00003DB5 File Offset: 0x00001FB5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyKicked_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyKicked_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDAdmin;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_m_bKickedDueToDisconnect;

		// Token: 0x040005C2 RID: 1474
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x040005C3 RID: 1475
		[FieldOffset(8)]
		public ulong m_ulSteamIDAdmin;

		// Token: 0x040005C4 RID: 1476
		[FieldOffset(16)]
		public byte m_bKickedDueToDisconnect;
	}
}
