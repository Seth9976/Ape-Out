using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002C RID: 44
	public sealed class UnsafeHashMapBase<TKey, TValue> : ValueType where TKey : new() where TValue : new()
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0000CA68 File Offset: 0x0000AC68
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeHashMapBase()
		{
			Il2CppClassPointerStore<UnsafeHashMapBase<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeHashMapBase`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeHashMapBase<TKey, TValue>>.NativeClassPtr);
			UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_Clear_Internal_Static_Void_ptr_UnsafeHashMapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapBase<TKey, TValue>>.NativeClassPtr, 100663637);
			UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Internal_Static_Boolean_ptr_UnsafeHashMapData_TKey_TValue_Boolean_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapBase<TKey, TValue>>.NativeClassPtr, 100663638);
			UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_TryGetFirstValueAtomic_Internal_Static_Boolean_ptr_UnsafeHashMapData_TKey_byref_TValue_byref_NativeMultiHashMapIterator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapBase<TKey, TValue>>.NativeClassPtr, 100663639);
			UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_TryGetNextValueAtomic_Internal_Static_Boolean_ptr_UnsafeHashMapData_byref_TValue_byref_NativeMultiHashMapIterator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapBase<TKey, TValue>>.NativeClassPtr, 100663640);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000CB38 File Offset: 0x0000AD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441320, XrefRangeEnd = 441324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(UnsafeHashMapData* data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_Clear_Internal_Static_Void_ptr_UnsafeHashMapData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441324, XrefRangeEnd = 441326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAdd(UnsafeHashMapData* data, TKey key, TValue item, bool isMultiHashMap, AllocatorManager.AllocatorHandle allocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TValue ptr7;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = item;
				if (!(tvalue is string))
				{
					ref TValue ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
				}
			}
			else
			{
				ptr7 = ref item;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMultiHashMap;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Internal_Static_Boolean_ptr_UnsafeHashMapData_TKey_TValue_Boolean_AllocatorHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000CC80 File Offset: 0x0000AE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441326, XrefRangeEnd = 441328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFirstValueAtomic(UnsafeHashMapData* data, TKey key, out TValue item, out NativeMultiHashMapIterator<TKey> it)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref item;
			}
			ptr5 = intPtr2;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr6 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_TryGetFirstValueAtomic_Internal_Static_Boolean_ptr_UnsafeHashMapData_TKey_byref_TValue_byref_NativeMultiHashMapIterator_1_TKey_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr;
				item = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			IntPtr intPtr7 = intPtr3;
			it = ((intPtr7 == 0) ? null : new NativeMultiHashMapIterator<TKey>(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441328, XrefRangeEnd = 441330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetNextValueAtomic(UnsafeHashMapData* data, out TValue item, ref NativeMultiHashMapIterator<TKey> it)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref item;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(it));
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapBase<TKey, TValue>.NativeMethodInfoPtr_TryGetNextValueAtomic_Internal_Static_Boolean_ptr_UnsafeHashMapData_byref_TValue_byref_NativeMultiHashMapIterator_1_TKey_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				item = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002902 File Offset: 0x00000B02
		public UnsafeHashMapBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000290B File Offset: 0x00000B0B
		public UnsafeHashMapBase()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeHashMapBase<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Static_Void_ptr_UnsafeHashMapData_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Internal_Static_Boolean_ptr_UnsafeHashMapData_TKey_TValue_Boolean_AllocatorHandle_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFirstValueAtomic_Internal_Static_Boolean_ptr_UnsafeHashMapData_TKey_byref_TValue_byref_NativeMultiHashMapIterator_1_TKey_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNextValueAtomic_Internal_Static_Boolean_ptr_UnsafeHashMapData_byref_TValue_byref_NativeMultiHashMapIterator_1_TKey_0;
	}
}
