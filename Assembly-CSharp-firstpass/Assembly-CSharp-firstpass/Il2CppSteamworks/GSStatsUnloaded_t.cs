using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000048 RID: 72
	[StructLayout(2)]
	public struct GSStatsUnloaded_t
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00027B58 File Offset: 0x00025D58
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsUnloaded_t()
		{
			Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSStatsUnloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr);
			GSStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, "k_iCallback");
			GSStatsUnloaded_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000032A2 File Offset: 0x000014A2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00027BB0 File Offset: 0x00025DB0
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x000032B4 File Offset: 0x000014B4
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x040004B7 RID: 1207
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;
	}
}
