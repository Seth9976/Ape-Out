using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000059 RID: 89
	public sealed class HTML_NewWindow_t : ValueType
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x00028B90 File Offset: 0x00026D90
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_NewWindow_t()
		{
			Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_NewWindow_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr);
			HTML_NewWindow_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "k_iCallback");
			HTML_NewWindow_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unBrowserHandle");
			HTML_NewWindow_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "pchURL");
			HTML_NewWindow_t.NativeFieldInfoPtr_unX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unX");
			HTML_NewWindow_t.NativeFieldInfoPtr_unY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unY");
			HTML_NewWindow_t.NativeFieldInfoPtr_unWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unWide");
			HTML_NewWindow_t.NativeFieldInfoPtr_unTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unTall");
			HTML_NewWindow_t.NativeFieldInfoPtr_unNewWindow_BrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unNewWindow_BrowserHandle");
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00003894 File Offset: 0x00001A94
		public HTML_NewWindow_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000389D File Offset: 0x00001A9D
		public HTML_NewWindow_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00028C60 File Offset: 0x00026E60
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x000038AF File Offset: 0x00001AAF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_NewWindow_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_NewWindow_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00028C7C File Offset: 0x00026E7C
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000038BD File Offset: 0x00001ABD
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00028CA4 File Offset: 0x00026EA4
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000038D8 File Offset: 0x00001AD8
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00028CCC File Offset: 0x00026ECC
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000038F7 File Offset: 0x00001AF7
		public unsafe uint unX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unX)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00028CF4 File Offset: 0x00026EF4
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00003912 File Offset: 0x00001B12
		public unsafe uint unY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unY)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00028D1C File Offset: 0x00026F1C
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0000392D File Offset: 0x00001B2D
		public unsafe uint unWide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unWide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unWide)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00028D44 File Offset: 0x00026F44
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00003948 File Offset: 0x00001B48
		public unsafe uint unTall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unTall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unTall)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00028D6C File Offset: 0x00026F6C
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00003963 File Offset: 0x00001B63
		public unsafe HHTMLBrowser unNewWindow_BrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unNewWindow_BrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unNewWindow_BrowserHandle)) = value;
			}
		}

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeFieldInfoPtr_unX;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr_unY;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeFieldInfoPtr_unWide;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr_unTall;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_unNewWindow_BrowserHandle;
	}
}
