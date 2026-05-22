using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200006F RID: 111
	[StructLayout(2)]
	public struct LobbyGameCreated_t
	{
		// Token: 0x06000653 RID: 1619 RVA: 0x00029B0C File Offset: 0x00027D0C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameCreated_t()
		{
			Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyGameCreated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr);
			LobbyGameCreated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "k_iCallback");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_ulSteamIDGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_ulSteamIDGameServer");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_unIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_unIP");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_usPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_usPort");
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00003D63 File Offset: 0x00001F63
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00029BA0 File Offset: 0x00027DA0
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00003D75 File Offset: 0x00001F75
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyGameCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyGameCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDGameServer;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr_m_unIP;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr_m_usPort;

		// Token: 0x040005B7 RID: 1463
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x040005B8 RID: 1464
		[FieldOffset(8)]
		public ulong m_ulSteamIDGameServer;

		// Token: 0x040005B9 RID: 1465
		[FieldOffset(16)]
		public uint m_unIP;

		// Token: 0x040005BA RID: 1466
		[FieldOffset(20)]
		public ushort m_usPort;
	}
}
