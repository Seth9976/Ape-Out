using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002E RID: 46
	[DefaultMember("Item")]
	public sealed class UnsafeHashMap<TKey, TValue> : ValueType where TKey : new() where TValue : new()
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x0000CF60 File Offset: 0x0000B160
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeHashMap()
		{
			Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeHashMap`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr);
			UnsafeHashMap<TKey, TValue>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, "m_Buffer");
			UnsafeHashMap<TKey, TValue>.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, "m_AllocatorLabel");
			UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, 100663641);
			UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, 100663642);
			UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, 100663643);
			UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, 100663644);
			UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, 100663645);
			UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValue_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, 100663646);
			UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr, 100663647);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000D094 File Offset: 0x0000B294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441330, XrefRangeEnd = 441334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsafeHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_AllocatorHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441334, XrefRangeEnd = 441336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000D128 File Offset: 0x0000B328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441336, XrefRangeEnd = 441338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd(TKey key, TValue item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
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
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000D224 File Offset: 0x0000B424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441338, XrefRangeEnd = 441340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(TKey key, out TValue item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
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
			}
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				item = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000D310 File Offset: 0x0000B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441340, XrefRangeEnd = 441344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000D348 File Offset: 0x0000B548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441344, XrefRangeEnd = 441349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<KeyValue<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValue_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValue_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValue<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000D38C File Offset: 0x0000B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441349, XrefRangeEnd = 441354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMap<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002989 File Offset: 0x00000B89
		public UnsafeHashMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002992 File Offset: 0x00000B92
		public UnsafeHashMap()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeHashMap<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000029A4 File Offset: 0x00000BA4
		public unsafe UnsafeHashMapData* m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeHashMap<TKey, TValue>.NativeFieldInfoPtr_m_Buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeHashMap<TKey, TValue>.NativeFieldInfoPtr_m_Buffer)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000029BF File Offset: 0x00000BBF
		public unsafe AllocatorManager.AllocatorHandle m_AllocatorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeHashMap<TKey, TValue>.NativeFieldInfoPtr_m_AllocatorLabel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeHashMap<TKey, TValue>.NativeFieldInfoPtr_m_AllocatorLabel)) = value;
			}
		}

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_AllocatorHandle_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValue_2_TKey_TValue_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}
}
