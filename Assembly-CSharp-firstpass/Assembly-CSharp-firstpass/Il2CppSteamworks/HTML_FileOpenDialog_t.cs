using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000058 RID: 88
	public sealed class HTML_FileOpenDialog_t : ValueType
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00028A7C File Offset: 0x00026C7C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_FileOpenDialog_t()
		{
			Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_FileOpenDialog_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr);
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "k_iCallback");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "unBrowserHandle");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "pchTitle");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchInitialFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "pchInitialFile");
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00003812 File Offset: 0x00001A12
		public HTML_FileOpenDialog_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000381B File Offset: 0x00001A1B
		public HTML_FileOpenDialog_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00028AFC File Offset: 0x00026CFC
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0000382D File Offset: 0x00001A2D
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_FileOpenDialog_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_FileOpenDialog_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00028B18 File Offset: 0x00026D18
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0000383B File Offset: 0x00001A3B
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00028B40 File Offset: 0x00026D40
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00003856 File Offset: 0x00001A56
		public unsafe string pchTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00028B68 File Offset: 0x00026D68
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00003875 File Offset: 0x00001A75
		public unsafe string pchInitialFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchInitialFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchInitialFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeFieldInfoPtr_pchTitle;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr_pchInitialFile;
	}
}
