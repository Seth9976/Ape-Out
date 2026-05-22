using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000038 RID: 56
	public static class UnsafeUtility : Object
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0001891C File Offset: 0x00016B1C
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeUtility()
		{
			Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr);
			UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663393);
			UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663394);
			UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663395);
			UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663396);
			UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663397);
			UnsafeUtility.NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663398);
			UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663399);
			UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663400);
			UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663401);
			UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663402);
			UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663403);
			UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663404);
			UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663405);
			UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663406);
			UnsafeUtility.NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663407);
			UnsafeUtility.GetFieldOffsetInStructDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInStructDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInStruct");
			UnsafeUtility.GetFieldOffsetInClassDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInClassDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInClass");
			UnsafeUtility.PinSystemArrayAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemArrayAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemArrayAndGetAddress");
			UnsafeUtility.PinSystemObjectAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemObjectAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemObjectAndGetAddress");
			UnsafeUtility.ReleaseGCObjectDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ReleaseGCObjectDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ReleaseGCObject");
			UnsafeUtility.CopyObjectAddressToPtrDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CopyObjectAddressToPtrDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CopyObjectAddressToPtr");
			UnsafeUtility.MemCpyReplicateDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCpyReplicateDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyReplicate");
			UnsafeUtility.MemCpyStrideDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCpyStrideDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyStride");
			UnsafeUtility.MemMoveDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemMoveDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemMove");
			UnsafeUtility.SizeOfDelegateField = IL2CPP.ResolveICall<UnsafeUtility.SizeOfDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SizeOf");
			UnsafeUtility.IsBlittableDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsBlittableDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsBlittable");
			UnsafeUtility.IsUnmanagedDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsUnmanagedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged");
			UnsafeUtility.IsValidNativeContainerElementTypeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsValidNativeContainerElementTypeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsValidNativeContainerElementType");
			UnsafeUtility.LogErrorDelegateField = IL2CPP.ResolveICall<UnsafeUtility.LogErrorDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LogError");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00018B4C File Offset: 0x00016D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485904, RefRangeEnd = 485905, XrefRangeStart = 485900, XrefRangeEnd = 485904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00018B9C File Offset: 0x00016D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485909, RefRangeEnd = 485911, XrefRangeStart = 485905, XrefRangeEnd = 485909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free(void* memory, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = memory;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00018BDC File Offset: 0x00016DDC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 485915, RefRangeEnd = 485925, XrefRangeStart = 485911, XrefRangeEnd = 485915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00018C28 File Offset: 0x00016E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485925, XrefRangeEnd = 485929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00018C78 File Offset: 0x00016E78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 485933, RefRangeEnd = 485936, XrefRangeStart = 485929, XrefRangeEnd = 485933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemClear(void* destination, long size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00018CB8 File Offset: 0x00016EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485936, XrefRangeEnd = 485940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MemCmp(void* ptr1, void* ptr2, long size)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = ptr1;
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ptr2;
			ptr3[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00018D10 File Offset: 0x00016F10
		[CallerCount(0)]
		public unsafe static int AlignOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00018D40 File Offset: 0x00016F40
		[CallerCount(0)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00018D88 File Offset: 0x00016F88
		[CallerCount(0)]
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00018DE0 File Offset: 0x00016FE0
		[CallerCount(0)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00018E7C File Offset: 0x0001707C
		[CallerCount(0)]
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00018F28 File Offset: 0x00017128
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* AddressOf<T>(ref T output) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(output);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				output = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return intPtr2;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00018F78 File Offset: 0x00017178
		[CallerCount(0)]
		public unsafe static int SizeOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00018FA8 File Offset: 0x000171A8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T AsRef<T>(void* ptr) where T : new()
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00018FDC File Offset: 0x000171DC
		[CallerCount(0)]
		public unsafe static ref T ArrayElementAsRef<T>(void* ptr, int index) where T : new()
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002FE5 File Offset: 0x000011E5
		public UnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002FEE File Offset: 0x000011EE
		public static int GetFieldOffsetInStruct(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00003000 File Offset: 0x00001200
		public static int GetFieldOffsetInClass(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInClassDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001901C File Offset: 0x0001721C
		public static int GetFieldOffset(FieldInfo field)
		{
			bool isValueType = field.DeclaringType.IsValueType;
			int num;
			if (isValueType)
			{
				num = UnsafeUtility.GetFieldOffsetInStruct(field);
			}
			else
			{
				bool isClass = field.DeclaringType.IsClass;
				if (isClass)
				{
					num = UnsafeUtility.GetFieldOffsetInClass(field);
				}
				else
				{
					num = -1;
				}
			}
			return num;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00019060 File Offset: 0x00017260
		public unsafe static void* PinGCObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddress(target, out gcHandle);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001907C File Offset: 0x0001727C
		public unsafe static void* PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddress(target, out gcHandle);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003012 File Offset: 0x00001212
		public unsafe static void* PinSystemArrayAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003025 File Offset: 0x00001225
		public unsafe static void* PinSystemObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003038 File Offset: 0x00001238
		public static void ReleaseGCObject(ulong gcHandle)
		{
			UnsafeUtility.ReleaseGCObjectDelegateField(gcHandle);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003045 File Offset: 0x00001245
		public unsafe static void CopyObjectAddressToPtr(Object target, void* dstPtr)
		{
			UnsafeUtility.CopyObjectAddressToPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), dstPtr);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00019098 File Offset: 0x00017298
		public static bool IsBlittable<T>() where T : struct
		{
			return UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000190BC File Offset: 0x000172BC
		public static bool IsValidAllocator(Allocator allocator)
		{
			return allocator > Allocator.None;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003058 File Offset: 0x00001258
		public unsafe static void MemCpyReplicate(void* destination, void* source, int size, int count)
		{
			UnsafeUtility.MemCpyReplicateDelegateField(destination, source, size, count);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00003068 File Offset: 0x00001268
		public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
		{
			UnsafeUtility.MemCpyStrideDelegateField(destination, destinationStride, source, sourceStride, elementSize, count);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000307C File Offset: 0x0000127C
		public unsafe static void MemMove(void* destination, void* source, long size)
		{
			UnsafeUtility.MemMoveDelegateField(destination, source, size);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000308B File Offset: 0x0000128B
		public static int SizeOf(Type type)
		{
			return UnsafeUtility.SizeOfDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000309D File Offset: 0x0000129D
		public static bool IsBlittable(Type type)
		{
			return UnsafeUtility.IsBlittableDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000030AF File Offset: 0x000012AF
		public static bool IsUnmanaged(Type type)
		{
			return UnsafeUtility.IsUnmanagedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000030C1 File Offset: 0x000012C1
		public static bool IsValidNativeContainerElementType(Type type)
		{
			return UnsafeUtility.IsValidNativeContainerElementTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000030D3 File Offset: 0x000012D3
		public static void LogError(string msg, string filename, int linenumber)
		{
			UnsafeUtility.LogErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(msg), IL2CPP.ManagedStringToIl2Cpp(filename), linenumber);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000190D4 File Offset: 0x000172D4
		public static bool IsBlittableValueType(Type t)
		{
			return t.IsValueType && UnsafeUtility.IsBlittable(t);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000030EC File Offset: 0x000012EC
		public static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000190F8 File Offset: 0x000172F8
		public static bool IsArrayBlittable(Array arr)
		{
			return UnsafeUtility.IsBlittableValueType(arr.GetType().GetElementType());
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001911C File Offset: 0x0001731C
		public static bool IsGenericListBlittable<T>() where T : struct
		{
			return UnsafeUtility.IsBlittable<T>();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00019134 File Offset: 0x00017334
		public static string GetReasonForArrayNonBlittable(Array arr)
		{
			Type elementType = arr.GetType().GetElementType();
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(elementType, elementType.Name);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00019160 File Offset: 0x00017360
		public static string GetReasonForGenericListNonBlittable<T>() where T : struct
		{
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001918C File Offset: 0x0001738C
		public static string GetReasonForTypeNonBlittable(Type t)
		{
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(t, t.Name);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000191AC File Offset: 0x000173AC
		public static string GetReasonForValueTypeNonBlittable<T>() where T : struct
		{
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000030F9 File Offset: 0x000012F9
		public static bool IsUnmanaged<T>()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00003106 File Offset: 0x00001306
		public static bool IsValidNativeContainerElementType<T>()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00003113 File Offset: 0x00001313
		public unsafe static void CopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			UnsafeUtility.InternalCopyPtrToStructure<T>(ptr, out output);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000311E File Offset: 0x0000131E
		public unsafe static void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			output = *(T*)ptr;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000312C File Offset: 0x0000132C
		public unsafe static void CopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
			UnsafeUtility.InternalCopyStructureToPtr<T>(ref input, ptr);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00003137 File Offset: 0x00001337
		public unsafe static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
			*(T*)ptr = input;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00003145 File Offset: 0x00001345
		public static ref T As<U, T>(ref U from)
		{
			return ref from;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000191D8 File Offset: 0x000173D8
		public static int EnumToInt<T>(T enumValue) where T : struct, IConvertible
		{
			int num = 0;
			UnsafeUtility.InternalEnumToInt<T>(ref enumValue, ref num);
			return num;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00003148 File Offset: 0x00001348
		public static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
			intValue = enumValue;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000314E File Offset: 0x0000134E
		public static bool EnumEquals<T>(T lhs, T rhs) where T : struct, IConvertible
		{
			return lhs == rhs;
		}

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0;

		// Token: 0x040000FE RID: 254
		private static readonly UnsafeUtility.GetFieldOffsetInStructDelegate GetFieldOffsetInStructDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly UnsafeUtility.GetFieldOffsetInClassDelegate GetFieldOffsetInClassDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly UnsafeUtility.PinSystemArrayAndGetAddressDelegate PinSystemArrayAndGetAddressDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly UnsafeUtility.PinSystemObjectAndGetAddressDelegate PinSystemObjectAndGetAddressDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly UnsafeUtility.ReleaseGCObjectDelegate ReleaseGCObjectDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly UnsafeUtility.CopyObjectAddressToPtrDelegate CopyObjectAddressToPtrDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly UnsafeUtility.MemCpyReplicateDelegate MemCpyReplicateDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly UnsafeUtility.MemCpyStrideDelegate MemCpyStrideDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly UnsafeUtility.MemMoveDelegate MemMoveDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly UnsafeUtility.SizeOfDelegate SizeOfDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly UnsafeUtility.IsBlittableDelegate IsBlittableDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly UnsafeUtility.IsUnmanagedDelegate IsUnmanagedDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly UnsafeUtility.IsValidNativeContainerElementTypeDelegate IsValidNativeContainerElementTypeDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly UnsafeUtility.LogErrorDelegate LogErrorDelegateField;

		// Token: 0x02000316 RID: 790
		public sealed class AlignOfHelper<T> : ValueType where T : new()
		{
			// Token: 0x0600244A RID: 9290 RVA: 0x0007A3DC File Offset: 0x000785DC
			// Note: this type is marked as 'beforefieldinit'.
			static AlignOfHelper()
			{
				Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "AlignOfHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr);
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "dummy");
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "data");
			}

			// Token: 0x0600244B RID: 9291 RVA: 0x0001353A File Offset: 0x0001173A
			public AlignOfHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600244C RID: 9292 RVA: 0x00013543 File Offset: 0x00011743
			public AlignOfHelper()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x0600244D RID: 9293 RVA: 0x0007A46C File Offset: 0x0007866C
			// (set) Token: 0x0600244E RID: 9294 RVA: 0x00013555 File Offset: 0x00011755
			public unsafe byte dummy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy)) = value;
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x0600244F RID: 9295 RVA: 0x0007A494 File Offset: 0x00078694
			// (set) Token: 0x06002450 RID: 9296 RVA: 0x0007A4BC File Offset: 0x000786BC
			public unsafe T data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04001E78 RID: 7800
			private static readonly IntPtr NativeFieldInfoPtr_dummy;

			// Token: 0x04001E79 RID: 7801
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x02000317 RID: 791
		private sealed class MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04001E7A RID: 7802
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000318 RID: 792
		private sealed class MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04001E7B RID: 7803
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000319 RID: 793
		private sealed class MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>
		{
			// Token: 0x04001E7C RID: 7804
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031A RID: 794
		private sealed class MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>
		{
			// Token: 0x04001E7D RID: 7805
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031B RID: 795
		private sealed class MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>
		{
			// Token: 0x04001E7E RID: 7806
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031C RID: 796
		private sealed class MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04001E7F RID: 7807
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031D RID: 797
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04001E80 RID: 7808
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031E RID: 798
		private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>
		{
			// Token: 0x04001E81 RID: 7809
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200031F RID: 799
		private sealed class MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04001E82 RID: 7810
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000320 RID: 800
		// (Invoke) Token: 0x0600245B RID: 9307
		private delegate int GetFieldOffsetInStructDelegate(IntPtr field);

		// Token: 0x02000321 RID: 801
		// (Invoke) Token: 0x0600245D RID: 9309
		private delegate int GetFieldOffsetInClassDelegate(IntPtr field);

		// Token: 0x02000322 RID: 802
		// (Invoke) Token: 0x0600245F RID: 9311
		private delegate IntPtr PinSystemArrayAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x02000323 RID: 803
		// (Invoke) Token: 0x06002461 RID: 9313
		private delegate IntPtr PinSystemObjectAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x02000324 RID: 804
		// (Invoke) Token: 0x06002463 RID: 9315
		private delegate void ReleaseGCObjectDelegate(ulong gcHandle);

		// Token: 0x02000325 RID: 805
		// (Invoke) Token: 0x06002465 RID: 9317
		private delegate void CopyObjectAddressToPtrDelegate(IntPtr target, IntPtr dstPtr);

		// Token: 0x02000326 RID: 806
		// (Invoke) Token: 0x06002467 RID: 9319
		private delegate void MemCpyReplicateDelegate(IntPtr destination, IntPtr source, int size, int count);

		// Token: 0x02000327 RID: 807
		// (Invoke) Token: 0x06002469 RID: 9321
		private delegate void MemCpyStrideDelegate(IntPtr destination, int destinationStride, IntPtr source, int sourceStride, int elementSize, int count);

		// Token: 0x02000328 RID: 808
		// (Invoke) Token: 0x0600246B RID: 9323
		private delegate void MemMoveDelegate(IntPtr destination, IntPtr source, long size);

		// Token: 0x02000329 RID: 809
		// (Invoke) Token: 0x0600246D RID: 9325
		private delegate int SizeOfDelegate(IntPtr type);

		// Token: 0x0200032A RID: 810
		// (Invoke) Token: 0x0600246F RID: 9327
		private delegate bool IsBlittableDelegate(IntPtr type);

		// Token: 0x0200032B RID: 811
		// (Invoke) Token: 0x06002471 RID: 9329
		private delegate bool IsUnmanagedDelegate(IntPtr type);

		// Token: 0x0200032C RID: 812
		// (Invoke) Token: 0x06002473 RID: 9331
		private delegate bool IsValidNativeContainerElementTypeDelegate(IntPtr type);

		// Token: 0x0200032D RID: 813
		// (Invoke) Token: 0x06002475 RID: 9333
		private delegate void LogErrorDelegate(IntPtr msg, IntPtr filename, int linenumber);
	}
}
