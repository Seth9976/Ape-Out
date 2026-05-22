using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A5 RID: 165
	[StructLayout(2)]
	public struct ScreenshotRequested_t
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00004D5D File Offset: 0x00002F5D
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotRequested_t()
		{
			Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ScreenshotRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr);
			ScreenshotRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00004D96 File Offset: 0x00002F96
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0002C134 File Offset: 0x0002A334
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
