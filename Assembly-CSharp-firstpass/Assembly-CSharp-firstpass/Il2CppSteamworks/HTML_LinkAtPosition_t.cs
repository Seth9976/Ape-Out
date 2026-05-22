using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000055 RID: 85
	public sealed class HTML_LinkAtPosition_t : ValueType
	{
		// Token: 0x060005AA RID: 1450 RVA: 0x00028704 File Offset: 0x00026904
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_LinkAtPosition_t()
		{
			Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_LinkAtPosition_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr);
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "k_iCallback");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "unBrowserHandle");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "x");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "y");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "pchURL");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_bInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "bInput");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_bLiveLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "bLiveLink");
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000367D File Offset: 0x0000187D
		public HTML_LinkAtPosition_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00003686 File Offset: 0x00001886
		public HTML_LinkAtPosition_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000287C0 File Offset: 0x000269C0
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00003698 File Offset: 0x00001898
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_LinkAtPosition_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_LinkAtPosition_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x000287DC File Offset: 0x000269DC
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x000036A6 File Offset: 0x000018A6
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00028804 File Offset: 0x00026A04
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x000036C1 File Offset: 0x000018C1
		public unsafe uint x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0002882C File Offset: 0x00026A2C
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000036DC File Offset: 0x000018DC
		public unsafe uint y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00028854 File Offset: 0x00026A54
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x000036F7 File Offset: 0x000018F7
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0002887C File Offset: 0x00026A7C
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00003716 File Offset: 0x00001916
		public unsafe bool bInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bInput)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x000288A4 File Offset: 0x00026AA4
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00003731 File Offset: 0x00001931
		public unsafe bool bLiveLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bLiveLink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bLiveLink)) = value;
			}
		}

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeFieldInfoPtr_bInput;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr_bLiveLink;
	}
}
