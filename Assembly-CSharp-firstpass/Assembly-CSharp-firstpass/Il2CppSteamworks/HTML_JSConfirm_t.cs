using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000057 RID: 87
	public sealed class HTML_JSConfirm_t : ValueType
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x000289A4 File Offset: 0x00026BA4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_JSConfirm_t()
		{
			Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_JSConfirm_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr);
			HTML_JSConfirm_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "k_iCallback");
			HTML_JSConfirm_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "unBrowserHandle");
			HTML_JSConfirm_t.NativeFieldInfoPtr_pchMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "pchMessage");
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000037AF File Offset: 0x000019AF
		public HTML_JSConfirm_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000037B8 File Offset: 0x000019B8
		public HTML_JSConfirm_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00028A10 File Offset: 0x00026C10
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000037CA File Offset: 0x000019CA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_JSConfirm_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_JSConfirm_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00028A2C File Offset: 0x00026C2C
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x000037D8 File Offset: 0x000019D8
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00028A54 File Offset: 0x00026C54
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000037F3 File Offset: 0x000019F3
		public unsafe string pchMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_pchMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_pchMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr_pchMessage;
	}
}
