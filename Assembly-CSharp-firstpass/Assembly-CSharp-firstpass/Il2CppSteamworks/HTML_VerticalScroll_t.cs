using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000054 RID: 84
	[StructLayout(2)]
	public struct HTML_VerticalScroll_t
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x0002862C File Offset: 0x0002682C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_VerticalScroll_t()
		{
			Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_VerticalScroll_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr);
			HTML_VerticalScroll_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "k_iCallback");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unBrowserHandle");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unScrollMax");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unScrollCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unScrollCurrent");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_flPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "flPageScale");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_bVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "bVisible");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unPageSize");
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000365D File Offset: 0x0000185D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000286E8 File Offset: 0x000268E8
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0000366F File Offset: 0x0000186F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_VerticalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_VerticalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_unScrollMax;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_unScrollCurrent;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeFieldInfoPtr_flPageScale;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeFieldInfoPtr_bVisible;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeFieldInfoPtr_unPageSize;

		// Token: 0x04000510 RID: 1296
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000511 RID: 1297
		[FieldOffset(4)]
		public uint unScrollMax;

		// Token: 0x04000512 RID: 1298
		[FieldOffset(8)]
		public uint unScrollCurrent;

		// Token: 0x04000513 RID: 1299
		[FieldOffset(12)]
		public float flPageScale;

		// Token: 0x04000514 RID: 1300
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool bVisible;

		// Token: 0x04000515 RID: 1301
		[FieldOffset(20)]
		public uint unPageSize;
	}
}
