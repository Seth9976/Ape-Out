using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200005A RID: 90
	[StructLayout(2)]
	public struct HTML_SetCursor_t
	{
		// Token: 0x060005EB RID: 1515 RVA: 0x00028D94 File Offset: 0x00026F94
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_SetCursor_t()
		{
			Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_SetCursor_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr);
			HTML_SetCursor_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "k_iCallback");
			HTML_SetCursor_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "unBrowserHandle");
			HTML_SetCursor_t.NativeFieldInfoPtr_eMouseCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "eMouseCursor");
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0000397E File Offset: 0x00001B7E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00028E00 File Offset: 0x00027000
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00003990 File Offset: 0x00001B90
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_SetCursor_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_SetCursor_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr_eMouseCursor;

		// Token: 0x04000532 RID: 1330
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000533 RID: 1331
		[FieldOffset(4)]
		public uint eMouseCursor;
	}
}
