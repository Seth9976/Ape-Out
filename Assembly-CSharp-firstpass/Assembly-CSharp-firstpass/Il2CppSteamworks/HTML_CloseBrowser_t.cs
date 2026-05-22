using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200004C RID: 76
	[StructLayout(2)]
	public struct HTML_CloseBrowser_t
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00027F1C File Offset: 0x0002611C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_CloseBrowser_t()
		{
			Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_CloseBrowser_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr);
			HTML_CloseBrowser_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, "k_iCallback");
			HTML_CloseBrowser_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, "unBrowserHandle");
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000033BE File Offset: 0x000015BE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00027F74 File Offset: 0x00026174
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000033D0 File Offset: 0x000015D0
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_CloseBrowser_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_CloseBrowser_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004DC RID: 1244
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;
	}
}
