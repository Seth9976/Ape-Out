using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000CA RID: 202
	[StructLayout(2)]
	public struct UserStatsUnloaded_t
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x0002D7CC File Offset: 0x0002B9CC
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsUnloaded_t()
		{
			Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserStatsUnloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr);
			UserStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, "k_iCallback");
			UserStatsUnloaded_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00005472 File Offset: 0x00003672
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0002D824 File Offset: 0x0002BA24
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00005484 File Offset: 0x00003684
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04000792 RID: 1938
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;
	}
}
