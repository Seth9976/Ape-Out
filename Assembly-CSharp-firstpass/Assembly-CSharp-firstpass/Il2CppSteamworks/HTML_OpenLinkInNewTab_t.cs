using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200004F RID: 79
	public sealed class HTML_OpenLinkInNewTab_t : ValueType
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x0002826C File Offset: 0x0002646C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_OpenLinkInNewTab_t()
		{
			Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_OpenLinkInNewTab_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr);
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "k_iCallback");
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "unBrowserHandle");
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "pchURL");
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00003537 File Offset: 0x00001737
		public HTML_OpenLinkInNewTab_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00003540 File Offset: 0x00001740
		public HTML_OpenLinkInNewTab_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x000282D8 File Offset: 0x000264D8
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00003552 File Offset: 0x00001752
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x000282F4 File Offset: 0x000264F4
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003560 File Offset: 0x00001760
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0002831C File Offset: 0x0002651C
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0000357B File Offset: 0x0000177B
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;
	}
}
