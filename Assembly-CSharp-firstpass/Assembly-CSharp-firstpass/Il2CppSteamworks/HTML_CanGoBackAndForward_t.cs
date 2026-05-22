using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000052 RID: 82
	[StructLayout(2)]
	public struct HTML_CanGoBackAndForward_t
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x000284B8 File Offset: 0x000266B8
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_CanGoBackAndForward_t()
		{
			Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_CanGoBackAndForward_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr);
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "k_iCallback");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "unBrowserHandle");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_bCanGoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "bCanGoBack");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_bCanGoForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "bCanGoForward");
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000361D File Offset: 0x0000181D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00028538 File Offset: 0x00026738
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0000362F File Offset: 0x0000182F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_bCanGoBack;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_bCanGoForward;

		// Token: 0x040004F9 RID: 1273
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040004FA RID: 1274
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool bCanGoBack;

		// Token: 0x040004FB RID: 1275
		[FieldOffset(5)]
		[MarshalAs(4)]
		public bool bCanGoForward;
	}
}
