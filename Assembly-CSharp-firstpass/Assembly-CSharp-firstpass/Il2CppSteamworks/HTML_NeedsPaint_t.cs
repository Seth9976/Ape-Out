using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200004A RID: 74
	[StructLayout(2)]
	public struct HTML_NeedsPaint_t
	{
		// Token: 0x06000555 RID: 1365 RVA: 0x00027C40 File Offset: 0x00025E40
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_NeedsPaint_t()
		{
			Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_NeedsPaint_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr);
			HTML_NeedsPaint_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "k_iCallback");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unBrowserHandle");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_pBGRA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "pBGRA");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unWide");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unTall");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateX");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateY");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateWide");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateTall");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unScrollX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unScrollX");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unScrollY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unScrollY");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_flPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "flPageScale");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unPageSerial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unPageSerial");
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000032E2 File Offset: 0x000014E2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00027D74 File Offset: 0x00025F74
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x000032F4 File Offset: 0x000014F4
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_NeedsPaint_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_NeedsPaint_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_pBGRA;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_unWide;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_unTall;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateX;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateY;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateWide;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateTall;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_unScrollX;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_unScrollY;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_flPageScale;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_unPageSerial;

		// Token: 0x040004C8 RID: 1224
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040004C9 RID: 1225
		[FieldOffset(8)]
		public IntPtr pBGRA;

		// Token: 0x040004CA RID: 1226
		[FieldOffset(16)]
		public uint unWide;

		// Token: 0x040004CB RID: 1227
		[FieldOffset(20)]
		public uint unTall;

		// Token: 0x040004CC RID: 1228
		[FieldOffset(24)]
		public uint unUpdateX;

		// Token: 0x040004CD RID: 1229
		[FieldOffset(28)]
		public uint unUpdateY;

		// Token: 0x040004CE RID: 1230
		[FieldOffset(32)]
		public uint unUpdateWide;

		// Token: 0x040004CF RID: 1231
		[FieldOffset(36)]
		public uint unUpdateTall;

		// Token: 0x040004D0 RID: 1232
		[FieldOffset(40)]
		public uint unScrollX;

		// Token: 0x040004D1 RID: 1233
		[FieldOffset(44)]
		public uint unScrollY;

		// Token: 0x040004D2 RID: 1234
		[FieldOffset(48)]
		public float flPageScale;

		// Token: 0x040004D3 RID: 1235
		[FieldOffset(52)]
		public uint unPageSerial;
	}
}
