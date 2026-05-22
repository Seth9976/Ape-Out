using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200004E RID: 78
	public sealed class HTML_FinishedRequest_t : ValueType
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00028158 File Offset: 0x00026358
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_FinishedRequest_t()
		{
			Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_FinishedRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr);
			HTML_FinishedRequest_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "k_iCallback");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "unBrowserHandle");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "pchURL");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_pchPageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "pchPageTitle");
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000034B5 File Offset: 0x000016B5
		public HTML_FinishedRequest_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000034BE File Offset: 0x000016BE
		public HTML_FinishedRequest_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000281D8 File Offset: 0x000263D8
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000034D0 File Offset: 0x000016D0
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_FinishedRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_FinishedRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x000281F4 File Offset: 0x000263F4
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x000034DE File Offset: 0x000016DE
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0002821C File Offset: 0x0002641C
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x000034F9 File Offset: 0x000016F9
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00028244 File Offset: 0x00026444
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00003518 File Offset: 0x00001718
		public unsafe string pchPageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchPageTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchPageTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_pchPageTitle;
	}
}
