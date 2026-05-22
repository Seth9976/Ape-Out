using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000050 RID: 80
	public sealed class HTML_ChangedTitle_t : ValueType
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x00028344 File Offset: 0x00026544
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_ChangedTitle_t()
		{
			Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_ChangedTitle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr);
			HTML_ChangedTitle_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "k_iCallback");
			HTML_ChangedTitle_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "unBrowserHandle");
			HTML_ChangedTitle_t.NativeFieldInfoPtr_pchTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "pchTitle");
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000359A File Offset: 0x0000179A
		public HTML_ChangedTitle_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000035A3 File Offset: 0x000017A3
		public HTML_ChangedTitle_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000283B0 File Offset: 0x000265B0
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000035B5 File Offset: 0x000017B5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_ChangedTitle_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_ChangedTitle_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x000283CC File Offset: 0x000265CC
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x000035C3 File Offset: 0x000017C3
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x000283F4 File Offset: 0x000265F4
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x000035DE File Offset: 0x000017DE
		public unsafe string pchTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_pchTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_pchTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_pchTitle;
	}
}
