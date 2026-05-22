using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000046 RID: 70
	[StructLayout(2)]
	public struct GSStatsReceived_t
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00027A48 File Offset: 0x00025C48
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsReceived_t()
		{
			Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr);
			GSStatsReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "k_iCallback");
			GSStatsReceived_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "m_eResult");
			GSStatsReceived_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00003262 File Offset: 0x00001462
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00027AB4 File Offset: 0x00025CB4
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00003274 File Offset: 0x00001474
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x040004AE RID: 1198
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040004AF RID: 1199
		[FieldOffset(4)]
		public CSteamID m_steamIDUser;
	}
}
