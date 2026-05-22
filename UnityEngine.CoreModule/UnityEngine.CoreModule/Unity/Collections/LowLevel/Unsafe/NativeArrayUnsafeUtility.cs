using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000037 RID: 55
	public static class NativeArrayUnsafeUtility : Object
	{
		// Token: 0x06000175 RID: 373 RVA: 0x000187D8 File Offset: 0x000169D8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayUnsafeUtility()
		{
			Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeArrayUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663391);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663392);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00018830 File Offset: 0x00016A30
		[CallerCount(0)]
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dataPointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>(intPtr);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00018884 File Offset: 0x00016A84
		[CallerCount(0)]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T> nativeArray) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002FDC File Offset: 0x000011DC
		public NativeArrayUnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000188C0 File Offset: 0x00016AC0
		public static void CheckConvertArguments<T>(int length, Allocator allocator) where T : struct
		{
			bool flag = length < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
			}
			NativeArray<T>.IsUnmanagedAndThrow();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000188EC File Offset: 0x00016AEC
		public unsafe static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) where T : struct
		{
			return nativeArray.m_Buffer;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00018904 File Offset: 0x00016B04
		public unsafe static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) where T : struct
		{
			return nativeArray.m_Buffer;
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x02000314 RID: 788
		private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>
		{
			// Token: 0x04001E76 RID: 7798
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000315 RID: 789
		private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04001E77 RID: 7799
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
