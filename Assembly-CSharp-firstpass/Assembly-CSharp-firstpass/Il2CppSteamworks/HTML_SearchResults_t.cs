using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000051 RID: 81
	[StructLayout(2)]
	public struct HTML_SearchResults_t
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x0002841C File Offset: 0x0002661C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_SearchResults_t()
		{
			Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_SearchResults_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr);
			HTML_SearchResults_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "k_iCallback");
			HTML_SearchResults_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "unBrowserHandle");
			HTML_SearchResults_t.NativeFieldInfoPtr_unResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "unResults");
			HTML_SearchResults_t.NativeFieldInfoPtr_unCurrentMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "unCurrentMatch");
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000035FD File Offset: 0x000017FD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0002849C File Offset: 0x0002669C
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0000360F File Offset: 0x0000180F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_SearchResults_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_SearchResults_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_unResults;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_unCurrentMatch;

		// Token: 0x040004F2 RID: 1266
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040004F3 RID: 1267
		[FieldOffset(4)]
		public uint unResults;

		// Token: 0x040004F4 RID: 1268
		[FieldOffset(8)]
		public uint unCurrentMatch;
	}
}
