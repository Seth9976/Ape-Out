using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000CE RID: 206
	[StructLayout(2)]
	public struct GlobalStatsReceived_t
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x0002DAA0 File Offset: 0x0002BCA0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalStatsReceived_t()
		{
			Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GlobalStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr);
			GlobalStatsReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "k_iCallback");
			GlobalStatsReceived_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "m_nGameID");
			GlobalStatsReceived_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0000556B File Offset: 0x0000376B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x0000557D File Offset: 0x0000377D
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GlobalStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040007A5 RID: 1957
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x040007A6 RID: 1958
		[FieldOffset(8)]
		public EResult m_eResult;
	}
}
