using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000120 RID: 288
	public static class KnownTerminals : Object
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x00083530 File Offset: 0x00081730
		// Note: this type is marked as 'beforefieldinit'.
		static KnownTerminals()
		{
			Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "KnownTerminals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr);
			KnownTerminals.NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100666910);
			KnownTerminals.NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100666911);
			KnownTerminals.NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100666912);
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x0008359C File Offset: 0x0008179C
		public unsafe static Il2CppStructArray<byte> linux
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175595, XrefRangeEnd = 175601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000835D0 File Offset: 0x000817D0
		public unsafe static Il2CppStructArray<byte> xterm
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175601, XrefRangeEnd = 175607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00083604 File Offset: 0x00081804
		public unsafe static Il2CppStructArray<byte> ansi
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175607, XrefRangeEnd = 175613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000071F2 File Offset: 0x000053F2
		public KnownTerminals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0;
	}
}
