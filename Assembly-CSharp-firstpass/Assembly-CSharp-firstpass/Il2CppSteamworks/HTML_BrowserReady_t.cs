using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000049 RID: 73
	[StructLayout(2)]
	public struct HTML_BrowserReady_t
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x00027BCC File Offset: 0x00025DCC
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_BrowserReady_t()
		{
			Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_BrowserReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr);
			HTML_BrowserReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, "k_iCallback");
			HTML_BrowserReady_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, "unBrowserHandle");
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000032C2 File Offset: 0x000014C2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00027C24 File Offset: 0x00025E24
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x000032D4 File Offset: 0x000014D4
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_BrowserReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_BrowserReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004BA RID: 1210
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;
	}
}
