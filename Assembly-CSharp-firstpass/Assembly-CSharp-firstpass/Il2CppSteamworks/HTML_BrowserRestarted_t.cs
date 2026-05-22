using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200005F RID: 95
	[StructLayout(2)]
	public struct HTML_BrowserRestarted_t
	{
		// Token: 0x0600060E RID: 1550 RVA: 0x00029118 File Offset: 0x00027318
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_BrowserRestarted_t()
		{
			Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_BrowserRestarted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr);
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "k_iCallback");
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "unBrowserHandle");
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_unOldBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "unOldBrowserHandle");
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00003AE7 File Offset: 0x00001CE7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00029184 File Offset: 0x00027384
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00003AF9 File Offset: 0x00001CF9
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_BrowserRestarted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_BrowserRestarted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_unOldBrowserHandle;

		// Token: 0x04000543 RID: 1347
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000544 RID: 1348
		[FieldOffset(4)]
		public HHTMLBrowser unOldBrowserHandle;
	}
}
