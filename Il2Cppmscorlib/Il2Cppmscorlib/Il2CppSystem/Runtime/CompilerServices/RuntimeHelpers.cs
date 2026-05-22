using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200043B RID: 1083
	public static class RuntimeHelpers : Object
	{
		// Token: 0x06004396 RID: 17302 RVA: 0x00138BA0 File Offset: 0x00136DA0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeHelpers()
		{
			Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr);
			RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100673163);
			RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100673164);
			RuntimeHelpers.NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100673165);
			RuntimeHelpers.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100673166);
			RuntimeHelpers.NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100673167);
			RuntimeHelpers.NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100673168);
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x00138C48 File Offset: 0x00136E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226705, XrefRangeEnd = 226717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeArray(Array array, IntPtr fldHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fldHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x00138C8C File Offset: 0x00136E8C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 226735, RefRangeEnd = 226785, XrefRangeStart = 226717, XrefRangeEnd = 226735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fldHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x00138CD0 File Offset: 0x00136ED0
		public unsafe static int OffsetToStringData
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00138D00 File Offset: 0x00136F00
		[CallerCount(0)]
		public unsafe static int GetHashCode(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00138D44 File Offset: 0x00136F44
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareConstrainedRegions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00138D6C File Offset: 0x00136F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226785, XrefRangeEnd = 226790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsReferenceOrContainsReferences<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00019ADE File Offset: 0x00017CDE
		public RuntimeHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0;

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0;

		// Token: 0x040036E0 RID: 14048
		private static readonly IntPtr NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0;

		// Token: 0x02000648 RID: 1608
		private sealed class MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>
		{
			// Token: 0x04004595 RID: 17813
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeHelpers.NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0, Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
