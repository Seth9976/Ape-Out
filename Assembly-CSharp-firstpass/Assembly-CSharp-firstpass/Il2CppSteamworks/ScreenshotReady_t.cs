using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A4 RID: 164
	[StructLayout(2)]
	public struct ScreenshotReady_t
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x0002C0AC File Offset: 0x0002A2AC
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotReady_t()
		{
			Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ScreenshotReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr);
			ScreenshotReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "k_iCallback");
			ScreenshotReady_t.NativeFieldInfoPtr_m_hLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "m_hLocal");
			ScreenshotReady_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00004D3D File Offset: 0x00002F3D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0002C118 File Offset: 0x0002A318
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x00004D4F File Offset: 0x00002F4F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_m_hLocal;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006BD RID: 1725
		[FieldOffset(0)]
		public ScreenshotHandle m_hLocal;

		// Token: 0x040006BE RID: 1726
		[FieldOffset(4)]
		public EResult m_eResult;
	}
}
