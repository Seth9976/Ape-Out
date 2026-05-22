using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000047 RID: 71
	[StructLayout(2)]
	public struct GSStatsStored_t
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x00027AD0 File Offset: 0x00025CD0
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsStored_t()
		{
			Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSStatsStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr);
			GSStatsStored_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "k_iCallback");
			GSStatsStored_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "m_eResult");
			GSStatsStored_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00003282 File Offset: 0x00001482
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00027B3C File Offset: 0x00025D3C
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00003294 File Offset: 0x00001494
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x040004B3 RID: 1203
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040004B4 RID: 1204
		[FieldOffset(4)]
		public CSteamID m_steamIDUser;
	}
}
