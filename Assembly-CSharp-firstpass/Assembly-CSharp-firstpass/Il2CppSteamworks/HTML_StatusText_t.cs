using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200005B RID: 91
	public sealed class HTML_StatusText_t : ValueType
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x00028E1C File Offset: 0x0002701C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_StatusText_t()
		{
			Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_StatusText_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr);
			HTML_StatusText_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "k_iCallback");
			HTML_StatusText_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "unBrowserHandle");
			HTML_StatusText_t.NativeFieldInfoPtr_pchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "pchMsg");
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000399E File Offset: 0x00001B9E
		public HTML_StatusText_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000039A7 File Offset: 0x00001BA7
		public HTML_StatusText_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00028E88 File Offset: 0x00027088
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x000039B9 File Offset: 0x00001BB9
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_StatusText_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_StatusText_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00028EA4 File Offset: 0x000270A4
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x000039C7 File Offset: 0x00001BC7
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00028ECC File Offset: 0x000270CC
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x000039E2 File Offset: 0x00001BE2
		public unsafe string pchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_pchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_pchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_pchMsg;
	}
}
