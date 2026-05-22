using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200005C RID: 92
	public sealed class HTML_ShowToolTip_t : ValueType
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00028EF4 File Offset: 0x000270F4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_ShowToolTip_t()
		{
			Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_ShowToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr);
			HTML_ShowToolTip_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "k_iCallback");
			HTML_ShowToolTip_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "unBrowserHandle");
			HTML_ShowToolTip_t.NativeFieldInfoPtr_pchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "pchMsg");
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00003A01 File Offset: 0x00001C01
		public HTML_ShowToolTip_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00003A0A File Offset: 0x00001C0A
		public HTML_ShowToolTip_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00028F60 File Offset: 0x00027160
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00003A1C File Offset: 0x00001C1C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_ShowToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_ShowToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00028F7C File Offset: 0x0002717C
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00003A2A File Offset: 0x00001C2A
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00028FA4 File Offset: 0x000271A4
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00003A45 File Offset: 0x00001C45
		public unsafe string pchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_pchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_pchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_pchMsg;
	}
}
