using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000053 RID: 83
	[StructLayout(2)]
	public struct HTML_HorizontalScroll_t
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00028554 File Offset: 0x00026754
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_HorizontalScroll_t()
		{
			Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_HorizontalScroll_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr);
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "k_iCallback");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unBrowserHandle");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unScrollMax");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unScrollCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unScrollCurrent");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_flPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "flPageScale");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_bVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "bVisible");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unPageSize");
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000363D File Offset: 0x0000183D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00028610 File Offset: 0x00026810
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0000364F File Offset: 0x0000184F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_HorizontalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_HorizontalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_unScrollMax;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_unScrollCurrent;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_flPageScale;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_bVisible;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_unPageSize;

		// Token: 0x04000503 RID: 1283
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000504 RID: 1284
		[FieldOffset(4)]
		public uint unScrollMax;

		// Token: 0x04000505 RID: 1285
		[FieldOffset(8)]
		public uint unScrollCurrent;

		// Token: 0x04000506 RID: 1286
		[FieldOffset(12)]
		public float flPageScale;

		// Token: 0x04000507 RID: 1287
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool bVisible;

		// Token: 0x04000508 RID: 1288
		[FieldOffset(20)]
		public uint unPageSize;
	}
}
