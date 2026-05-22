using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200004D RID: 77
	public sealed class HTML_URLChanged_t : ValueType
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x00027F90 File Offset: 0x00026190
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_URLChanged_t()
		{
			Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_URLChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr);
			HTML_URLChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "k_iCallback");
			HTML_URLChanged_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "unBrowserHandle");
			HTML_URLChanged_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "pchURL");
			HTML_URLChanged_t.NativeFieldInfoPtr_pchPostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "pchPostData");
			HTML_URLChanged_t.NativeFieldInfoPtr_bIsRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "bIsRedirect");
			HTML_URLChanged_t.NativeFieldInfoPtr_pchPageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "pchPageTitle");
			HTML_URLChanged_t.NativeFieldInfoPtr_bNewNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "bNewNavigation");
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000033DE File Offset: 0x000015DE
		public HTML_URLChanged_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000033E7 File Offset: 0x000015E7
		public HTML_URLChanged_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0002804C File Offset: 0x0002624C
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x000033F9 File Offset: 0x000015F9
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_URLChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_URLChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00028068 File Offset: 0x00026268
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00003407 File Offset: 0x00001607
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00028090 File Offset: 0x00026290
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00003422 File Offset: 0x00001622
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000280B8 File Offset: 0x000262B8
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00003441 File Offset: 0x00001641
		public unsafe string pchPostData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPostData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPostData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000280E0 File Offset: 0x000262E0
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00003460 File Offset: 0x00001660
		public unsafe bool bIsRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bIsRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bIsRedirect)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00028108 File Offset: 0x00026308
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0000347B File Offset: 0x0000167B
		public unsafe string pchPageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPageTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPageTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00028130 File Offset: 0x00026330
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0000349A File Offset: 0x0000169A
		public unsafe bool bNewNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bNewNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bNewNavigation)) = value;
			}
		}

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr_pchPostData;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_bIsRedirect;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr_pchPageTitle;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_bNewNavigation;
	}
}
