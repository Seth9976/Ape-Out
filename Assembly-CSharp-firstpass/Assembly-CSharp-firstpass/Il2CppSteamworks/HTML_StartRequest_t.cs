using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200004B RID: 75
	public sealed class HTML_StartRequest_t : ValueType
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x00027D90 File Offset: 0x00025F90
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_StartRequest_t()
		{
			Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_StartRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr);
			HTML_StartRequest_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "k_iCallback");
			HTML_StartRequest_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "unBrowserHandle");
			HTML_StartRequest_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "pchURL");
			HTML_StartRequest_t.NativeFieldInfoPtr_pchTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "pchTarget");
			HTML_StartRequest_t.NativeFieldInfoPtr_pchPostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "pchPostData");
			HTML_StartRequest_t.NativeFieldInfoPtr_bIsRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "bIsRedirect");
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003302 File Offset: 0x00001502
		public HTML_StartRequest_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000330B File Offset: 0x0000150B
		public HTML_StartRequest_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00027E38 File Offset: 0x00026038
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0000331D File Offset: 0x0000151D
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_StartRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_StartRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00027E54 File Offset: 0x00026054
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0000332B File Offset: 0x0000152B
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00027E7C File Offset: 0x0002607C
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00003346 File Offset: 0x00001546
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00027EA4 File Offset: 0x000260A4
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00003365 File Offset: 0x00001565
		public unsafe string pchTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00027ECC File Offset: 0x000260CC
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00003384 File Offset: 0x00001584
		public unsafe string pchPostData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchPostData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchPostData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00027EF4 File Offset: 0x000260F4
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000033A3 File Offset: 0x000015A3
		public unsafe bool bIsRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_bIsRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_bIsRedirect)) = value;
			}
		}

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_pchTarget;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_pchPostData;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr_bIsRedirect;
	}
}
