using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C3 RID: 195
	[StructLayout(2)]
	public struct UserStatsReceived_t
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x0002D298 File Offset: 0x0002B498
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsReceived_t()
		{
			Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr);
			UserStatsReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "k_iCallback");
			UserStatsReceived_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "m_nGameID");
			UserStatsReceived_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "m_eResult");
			UserStatsReceived_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000052FE File Offset: 0x000034FE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0002D318 File Offset: 0x0002B518
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00005310 File Offset: 0x00003510
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04000764 RID: 1892
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x04000765 RID: 1893
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04000766 RID: 1894
		[FieldOffset(12)]
		public CSteamID m_steamIDUser;
	}
}
