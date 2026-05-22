using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200005E RID: 94
	[StructLayout(2)]
	public struct HTML_HideToolTip_t
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x000290A4 File Offset: 0x000272A4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_HideToolTip_t()
		{
			Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_HideToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr);
			HTML_HideToolTip_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, "k_iCallback");
			HTML_HideToolTip_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, "unBrowserHandle");
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00003AC7 File Offset: 0x00001CC7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000290FC File Offset: 0x000272FC
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00003AD9 File Offset: 0x00001CD9
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_HideToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_HideToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x0400053F RID: 1343
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;
	}
}
