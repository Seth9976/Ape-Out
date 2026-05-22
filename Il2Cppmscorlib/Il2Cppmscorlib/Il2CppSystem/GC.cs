using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem
{
	// Token: 0x020000A9 RID: 169
	public static class GC : Object
	{
		// Token: 0x06000BFF RID: 3071 RVA: 0x00059ADC File Offset: 0x00057CDC
		// Note: this type is marked as 'beforefieldinit'.
		static GC()
		{
			Il2CppClassPointerStore<GC>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "GC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GC>.NativeClassPtr);
			GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GC>.NativeClassPtr, "EPHEMERON_TOMBSTONE");
			GC.NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665327);
			GC.NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665328);
			GC.NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665329);
			GC.NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665330);
			GC.NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665331);
			GC.NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665332);
			GC.NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665333);
			GC.NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665334);
			GC.NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665335);
			GC.NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665336);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00059BE8 File Offset: 0x00057DE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00059C1C File Offset: 0x00057E1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void register_ephemeron_array(Il2CppReferenceArray<Ephemeron> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00059C54 File Offset: 0x00057E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154896, XrefRangeEnd = 154898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object get_ephemeron_tombstone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00059C88 File Offset: 0x00057E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154898, XrefRangeEnd = 154901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMemoryPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00059CBC File Offset: 0x00057EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154901, XrefRangeEnd = 154904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveMemoryPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00059CF0 File Offset: 0x00057EF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeepAlive(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00059D28 File Offset: 0x00057F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154904, XrefRangeEnd = 154912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SuppressFinalize(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00059D60 File Offset: 0x00057F60
		[CallerCount(159)]
		[CachedScanResults(RefRangeStart = 154923, RefRangeEnd = 155082, XrefRangeStart = 154912, XrefRangeEnd = 154923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SuppressFinalize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00059D98 File Offset: 0x00057F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155082, XrefRangeEnd = 155090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ReRegisterForFinalize(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00059DD0 File Offset: 0x00057FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155090, XrefRangeEnd = 155101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReRegisterForFinalize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00005130 File Offset: 0x00003330
		public GC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00059E08 File Offset: 0x00058008
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00005139 File Offset: 0x00003339
		public unsafe static Object EPHEMERON_TOMBSTONE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr_EPHEMERON_TOMBSTONE;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0;
	}
}
