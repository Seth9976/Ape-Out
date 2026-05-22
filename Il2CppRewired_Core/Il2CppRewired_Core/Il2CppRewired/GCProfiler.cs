using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x020000C5 RID: 197
	public static class GCProfiler : Object
	{
		// Token: 0x0600181B RID: 6171 RVA: 0x00089CFC File Offset: 0x00087EFC
		// Note: this type is marked as 'beforefieldinit'.
		static GCProfiler()
		{
			Il2CppClassPointerStore<GCProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "GCProfiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCProfiler>.NativeClassPtr);
			GCProfiler.NativeMethodInfoPtr_Begin_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCProfiler>.NativeClassPtr, 100669186);
			GCProfiler.NativeMethodInfoPtr_End_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCProfiler>.NativeClassPtr, 100669187);
			GCProfiler.NativeMethodInfoPtr_LogReport_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCProfiler>.NativeClassPtr, 100669188);
			GCProfiler.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCProfiler>.NativeClassPtr, 100669189);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00089D7C File Offset: 0x00087F7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCProfiler.NativeMethodInfoPtr_Begin_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00089DB4 File Offset: 0x00087FB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCProfiler.NativeMethodInfoPtr_End_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00089DDC File Offset: 0x00087FDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogReport()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCProfiler.NativeMethodInfoPtr_LogReport_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00089E04 File Offset: 0x00088004
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCProfiler.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0000A0D3 File Offset: 0x000082D3
		public GCProfiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_String_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_Void_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_LogReport_Public_Static_Void_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;
	}
}
