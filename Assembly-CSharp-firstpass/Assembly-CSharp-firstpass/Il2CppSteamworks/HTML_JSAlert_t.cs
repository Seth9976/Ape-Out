using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000056 RID: 86
	public sealed class HTML_JSAlert_t : ValueType
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x000288CC File Offset: 0x00026ACC
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_JSAlert_t()
		{
			Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_JSAlert_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr);
			HTML_JSAlert_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "k_iCallback");
			HTML_JSAlert_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "unBrowserHandle");
			HTML_JSAlert_t.NativeFieldInfoPtr_pchMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "pchMessage");
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000374C File Offset: 0x0000194C
		public HTML_JSAlert_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00003755 File Offset: 0x00001955
		public HTML_JSAlert_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00028938 File Offset: 0x00026B38
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00003767 File Offset: 0x00001967
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_JSAlert_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_JSAlert_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00028954 File Offset: 0x00026B54
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00003775 File Offset: 0x00001975
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0002897C File Offset: 0x00026B7C
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00003790 File Offset: 0x00001990
		public unsafe string pchMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_pchMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_pchMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_pchMessage;
	}
}
