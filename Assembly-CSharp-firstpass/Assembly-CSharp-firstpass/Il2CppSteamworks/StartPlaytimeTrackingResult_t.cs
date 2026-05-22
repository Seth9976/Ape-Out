using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000AF RID: 175
	[StructLayout(2)]
	public struct StartPlaytimeTrackingResult_t
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x0002C74C File Offset: 0x0002A94C
		// Note: this type is marked as 'beforefieldinit'.
		static StartPlaytimeTrackingResult_t()
		{
			Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "StartPlaytimeTrackingResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr);
			StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, "k_iCallback");
			StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00004F28 File Offset: 0x00003128
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002C7A4 File Offset: 0x0002A9A4
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00004F3A File Offset: 0x0000313A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000703 RID: 1795
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
