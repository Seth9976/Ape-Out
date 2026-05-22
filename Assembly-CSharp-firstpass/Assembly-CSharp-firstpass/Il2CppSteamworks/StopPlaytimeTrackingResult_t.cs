using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B0 RID: 176
	[StructLayout(2)]
	public struct StopPlaytimeTrackingResult_t
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		// Note: this type is marked as 'beforefieldinit'.
		static StopPlaytimeTrackingResult_t()
		{
			Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "StopPlaytimeTrackingResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr);
			StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, "k_iCallback");
			StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00004F48 File Offset: 0x00003148
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0002C818 File Offset: 0x0002AA18
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00004F5A File Offset: 0x0000315A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000706 RID: 1798
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
