using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C4 RID: 196
	[StructLayout(2)]
	public struct UserStatsStored_t
	{
		// Token: 0x06000840 RID: 2112 RVA: 0x0002D334 File Offset: 0x0002B534
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsStored_t()
		{
			Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserStatsStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr);
			UserStatsStored_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "k_iCallback");
			UserStatsStored_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "m_nGameID");
			UserStatsStored_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0000531E File Offset: 0x0000351E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00005330 File Offset: 0x00003530
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400076A RID: 1898
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x0400076B RID: 1899
		[FieldOffset(8)]
		public EResult m_eResult;
	}
}
