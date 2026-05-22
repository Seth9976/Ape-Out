using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200005D RID: 93
	public sealed class HTML_UpdateToolTip_t : ValueType
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x00028FCC File Offset: 0x000271CC
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_UpdateToolTip_t()
		{
			Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_UpdateToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr);
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "k_iCallback");
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "unBrowserHandle");
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_pchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "pchMsg");
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00003A64 File Offset: 0x00001C64
		public HTML_UpdateToolTip_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00003A6D File Offset: 0x00001C6D
		public HTML_UpdateToolTip_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00029038 File Offset: 0x00027238
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00003A7F File Offset: 0x00001C7F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_UpdateToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_UpdateToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00029054 File Offset: 0x00027254
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00003A8D File Offset: 0x00001C8D
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0002907C File Offset: 0x0002727C
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public unsafe string pchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_pchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_pchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_pchMsg;
	}
}
