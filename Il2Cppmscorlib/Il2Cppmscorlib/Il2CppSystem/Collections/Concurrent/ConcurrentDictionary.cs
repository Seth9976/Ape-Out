using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x0200048A RID: 1162
	[Serializable]
	public class ConcurrentDictionary<TKey, TValue> : Object
	{
		// Token: 0x060046D5 RID: 18133 RVA: 0x00145D34 File Offset: 0x00143F34
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentDictionary()
		{
			Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "ConcurrentDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr);
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_tables");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_comparer");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_growLockArray");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_budget");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "s_isValueWriteAtomic");
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673800);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673801);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673802);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673803);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673804);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673805);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673806);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673807);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673808);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673809);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673810);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673811);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673812);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673813);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673814);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673815);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673816);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673817);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673818);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNotFoundException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673819);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673820);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673821);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetCountInternal_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673822);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673823);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673824);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673825);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673826);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673827);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673828);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673829);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673830);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673831);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673832);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673833);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673834);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673835);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673836);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673837);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673838);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673839);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673840);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673841);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673842);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673843);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673844);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673845);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673846);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673847);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673848);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673849);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673850);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673851);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673852);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673853);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673854);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetValues_Private_ReadOnlyCollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673855);
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x00146278 File Offset: 0x00144478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230194, XrefRangeEnd = 230205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueWriteAtomic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x001462A8 File Offset: 0x001444A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230209, RefRangeEnd = 230210, XrefRangeStart = 230205, XrefRangeEnd = 230209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x001462E4 File Offset: 0x001444E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230210, XrefRangeEnd = 230226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref concurrencyLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growLockArray;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x0014635C File Offset: 0x0014455C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230226, XrefRangeEnd = 230228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd(TKey key, TValue value)
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
				TValue tvalue = value;
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
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x00146454 File Offset: 0x00144654
		[CallerCount(0)]
		public unsafe virtual bool ContainsKey(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x001464EC File Offset: 0x001446EC
		[CallerCount(0)]
		public unsafe bool TryRemove(TKey key, out TValue value)
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
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x001465D4 File Offset: 0x001447D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230228, XrefRangeEnd = 230249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchValue;
			IntPtr* ptr6 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TValue ptr8;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = oldValue;
				if (!(tvalue is string))
				{
					ref TValue ptr7 = (ptr8 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					if ((ref ptr7) != null)
					{
						ptr8 = ref ptr7;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr7)))
						{
							ptr8 = IL2CPP.il2cpp_object_unbox(ref ptr7);
						}
					}
				}
				else
				{
					ptr8 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
				}
			}
			else
			{
				ptr8 = ref oldValue;
			}
			*ptr6 = ref ptr8;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00146728 File Offset: 0x00144928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230249, XrefRangeEnd = 230251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(TKey key, out TValue value)
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
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00146810 File Offset: 0x00144A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230251, XrefRangeEnd = 230257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
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
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x00146908 File Offset: 0x00144B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230257, XrefRangeEnd = 230268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x0014693C File Offset: 0x00144B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230268, XrefRangeEnd = 230270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0014698C File Offset: 0x00144B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230276, RefRangeEnd = 230277, XrefRangeStart = 230270, XrefRangeEnd = 230276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<KeyValuePair<TKey, TValue>> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x001469CC File Offset: 0x00144BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230277, XrefRangeEnd = 230278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToPairs(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00146A1C File Offset: 0x00144C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230278, XrefRangeEnd = 230285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToEntries(Il2CppReferenceArray<DictionaryEntry> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00146A6C File Offset: 0x00144C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230285, XrefRangeEnd = 230290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToObjects(Il2CppReferenceArray<Object> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x00146ABC File Offset: 0x00144CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230290, XrefRangeEnd = 230292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x00146AFC File Offset: 0x00144CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230292, XrefRangeEnd = 230320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TValue ptr7;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
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
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateIfExists;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acquireLock;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref resultingValue;
			}
			ptr8 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				resultingValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x1700121E RID: 4638
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230320, XrefRangeEnd = 230324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230324, XrefRangeEnd = 230326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
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
					TValue tvalue = value;
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
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x00146DF0 File Offset: 0x00144FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230326, XrefRangeEnd = 230331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowKeyNotFoundException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNotFoundException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00146E18 File Offset: 0x00145018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230331, XrefRangeEnd = 230337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowKeyNullException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x00146E40 File Offset: 0x00145040
		public unsafe virtual int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 230338, RefRangeEnd = 230340, XrefRangeStart = 230337, XrefRangeEnd = 230338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x00146E7C File Offset: 0x0014507C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230340, XrefRangeEnd = 230341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCountInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetCountInternal_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00146EB8 File Offset: 0x001450B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230341, XrefRangeEnd = 230343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x00146F60 File Offset: 0x00145160
		public unsafe bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230343, XrefRangeEnd = 230346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x00146F9C File Offset: 0x0014519C
		[CallerCount(0)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_TKey_TValue_0(TKey key, TValue value)
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
				TValue tvalue = value;
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
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00147088 File Offset: 0x00145288
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_TKey_0(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x00147120 File Offset: 0x00145320
		public unsafe virtual ICollection<TKey> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230346, XrefRangeEnd = 230347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x00147160 File Offset: 0x00145360
		public unsafe virtual ICollection<TValue> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230347, XrefRangeEnd = 230348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x001471A0 File Offset: 0x001453A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230348, XrefRangeEnd = 230350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x001471E8 File Offset: 0x001453E8
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x0014723C File Offset: 0x0014543C
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x00147278 File Offset: 0x00145478
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x001472CC File Offset: 0x001454CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230350, XrefRangeEnd = 230351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x0014730C File Offset: 0x0014550C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230351, XrefRangeEnd = 230361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x00147360 File Offset: 0x00145560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230361, XrefRangeEnd = 230367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x001473B0 File Offset: 0x001455B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230367, XrefRangeEnd = 230369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x001473F0 File Offset: 0x001455F0
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x0014742C File Offset: 0x0014562C
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x00147468 File Offset: 0x00145668
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x001474A8 File Offset: 0x001456A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230369, XrefRangeEnd = 230376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x001474EC File Offset: 0x001456EC
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06004700 RID: 18176 RVA: 0x0014752C File Offset: 0x0014572C
		// (set) Token: 0x06004701 RID: 18177 RVA: 0x0014757C File Offset: 0x0014577C
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230376, XrefRangeEnd = 230385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230385, XrefRangeEnd = 230395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x001475D0 File Offset: 0x001457D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230395, XrefRangeEnd = 230408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x00147620 File Offset: 0x00145820
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x0014765C File Offset: 0x0014585C
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230408, XrefRangeEnd = 230414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x0014769C File Offset: 0x0014589C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230414, XrefRangeEnd = 230452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x001476E0 File Offset: 0x001458E0
		[CallerCount(0)]
		public unsafe static int GetBucket(int hashcode, int bucketCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x0014772C File Offset: 0x0014592C
		[CallerCount(0)]
		public unsafe static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bucketNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x00147798 File Offset: 0x00145998
		public unsafe static int DefaultConcurrencyLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230452, XrefRangeEnd = 230453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x001477C8 File Offset: 0x001459C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230453, XrefRangeEnd = 230460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireAllLocks(ref int locksAcquired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &locksAcquired;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00147808 File Offset: 0x00145A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230460, XrefRangeEnd = 230463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toExclusive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &locksAcquired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00147864 File Offset: 0x00145A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230463, XrefRangeEnd = 230464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseLocks(int fromInclusive, int toExclusive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x001478B0 File Offset: 0x00145AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230464, XrefRangeEnd = 230471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<TKey> GetKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TKey>>(intPtr3) : null;
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x001478F0 File Offset: 0x00145AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230471, XrefRangeEnd = 230478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<TValue> GetValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetValues_Private_ReadOnlyCollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TValue>>(intPtr3) : null;
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x0001ACF1 File Offset: 0x00018EF1
		public ConcurrentDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x00147930 File Offset: 0x00145B30
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x0001ACFA File Offset: 0x00018EFA
		public unsafe ConcurrentDictionary<TKey, TValue>.Tables _tables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Tables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x00147960 File Offset: 0x00145B60
		// (set) Token: 0x06004712 RID: 18194 RVA: 0x0001AD19 File Offset: 0x00018F19
		public unsafe IEqualityComparer<TKey> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x00147990 File Offset: 0x00145B90
		// (set) Token: 0x06004714 RID: 18196 RVA: 0x0001AD38 File Offset: 0x00018F38
		public unsafe bool _growLockArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray)) = value;
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x001479B8 File Offset: 0x00145BB8
		// (set) Token: 0x06004716 RID: 18198 RVA: 0x0001AD53 File Offset: 0x00018F53
		public unsafe int _budget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget)) = value;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x001479E0 File Offset: 0x00145BE0
		// (set) Token: 0x06004718 RID: 18200 RVA: 0x0001AD6E File Offset: 0x00018F6E
		public unsafe static bool s_isValueWriteAtomic
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic, (void*)(&value));
			}
		}

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeFieldInfoPtr__tables;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeFieldInfoPtr__growLockArray;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeFieldInfoPtr__budget;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeFieldInfoPtr_s_isValueWriteAtomic;

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0;

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0;

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x040039A6 RID: 14758
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x040039A7 RID: 14759
		private static readonly IntPtr NativeMethodInfoPtr_ThrowKeyNotFoundException_Private_Static_Void_0;

		// Token: 0x040039A8 RID: 14760
		private static readonly IntPtr NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0;

		// Token: 0x040039A9 RID: 14761
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040039AA RID: 14762
		private static readonly IntPtr NativeMethodInfoPtr_GetCountInternal_Private_Int32_0;

		// Token: 0x040039AB RID: 14763
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0;

		// Token: 0x040039AC RID: 14764
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x040039AD RID: 14765
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x040039AE RID: 14766
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x040039AF RID: 14767
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x040039B0 RID: 14768
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x040039B1 RID: 14769
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040039B2 RID: 14770
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040039B3 RID: 14771
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040039B4 RID: 14772
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x040039B5 RID: 14773
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040039B6 RID: 14774
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x040039B7 RID: 14775
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040039B8 RID: 14776
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x040039B9 RID: 14777
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x040039BA RID: 14778
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x040039BB RID: 14779
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x040039BC RID: 14780
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040039BD RID: 14781
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x040039BE RID: 14782
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x040039BF RID: 14783
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x040039C0 RID: 14784
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040039C1 RID: 14785
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x040039C2 RID: 14786
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040039C3 RID: 14787
		private static readonly IntPtr NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0;

		// Token: 0x040039C4 RID: 14788
		private static readonly IntPtr NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040039C5 RID: 14789
		private static readonly IntPtr NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0;

		// Token: 0x040039C6 RID: 14790
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0;

		// Token: 0x040039C7 RID: 14791
		private static readonly IntPtr NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0;

		// Token: 0x040039C8 RID: 14792
		private static readonly IntPtr NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0;

		// Token: 0x040039C9 RID: 14793
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0;

		// Token: 0x040039CA RID: 14794
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0;

		// Token: 0x040039CB RID: 14795
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Private_ReadOnlyCollection_1_TValue_0;

		// Token: 0x02000665 RID: 1637
		public sealed class Tables : Object
		{
			// Token: 0x060057C8 RID: 22472 RVA: 0x00186FB4 File Offset: 0x001851B4
			// Note: this type is marked as 'beforefieldinit'.
			static Tables()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "Tables"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_buckets");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_locks");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_countPerLock");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, 100673857);
			}

			// Token: 0x060057C9 RID: 22473 RVA: 0x0018707C File Offset: 0x0018527C
			[CallerCount(0)]
			public unsafe Tables(Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> buckets, Il2CppReferenceArray<Object> locks, Il2CppStructArray<int> countPerLock)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buckets);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locks);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(countPerLock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.Tables.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057CA RID: 22474 RVA: 0x00021733 File Offset: 0x0001F933
			public Tables(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016AD RID: 5805
			// (get) Token: 0x060057CB RID: 22475 RVA: 0x001870EC File Offset: 0x001852EC
			// (set) Token: 0x060057CC RID: 22476 RVA: 0x0002173C File Offset: 0x0001F93C
			public unsafe Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> _buckets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016AE RID: 5806
			// (get) Token: 0x060057CD RID: 22477 RVA: 0x0018711C File Offset: 0x0018531C
			// (set) Token: 0x060057CE RID: 22478 RVA: 0x0002175B File Offset: 0x0001F95B
			public unsafe Il2CppReferenceArray<Object> _locks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016AF RID: 5807
			// (get) Token: 0x060057CF RID: 22479 RVA: 0x0018714C File Offset: 0x0018534C
			// (set) Token: 0x060057D0 RID: 22480 RVA: 0x0002177A File Offset: 0x0001F97A
			public unsafe Il2CppStructArray<int> _countPerLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004674 RID: 18036
			private static readonly IntPtr NativeFieldInfoPtr__buckets;

			// Token: 0x04004675 RID: 18037
			private static readonly IntPtr NativeFieldInfoPtr__locks;

			// Token: 0x04004676 RID: 18038
			private static readonly IntPtr NativeFieldInfoPtr__countPerLock;

			// Token: 0x04004677 RID: 18039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x02000666 RID: 1638
		[Serializable]
		public sealed class Node : Object
		{
			// Token: 0x060057D1 RID: 22481 RVA: 0x0018717C File Offset: 0x0018537C
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_key");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_value");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_next");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_hashcode");
				ConcurrentDictionary<TKey, TValue>.Node.NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, 100673858);
			}

			// Token: 0x060057D2 RID: 22482 RVA: 0x00187258 File Offset: 0x00185458
			[CallerCount(0)]
			public unsafe Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
					TValue tvalue = value;
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
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.Node.NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057D3 RID: 22483 RVA: 0x00021799 File Offset: 0x0001F999
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016B0 RID: 5808
			// (get) Token: 0x060057D4 RID: 22484 RVA: 0x0018736C File Offset: 0x0018556C
			// (set) Token: 0x060057D5 RID: 22485 RVA: 0x00187394 File Offset: 0x00185594
			public unsafe TKey _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key);
					Type typeFromHandle = typeof(TKey);
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

			// Token: 0x170016B1 RID: 5809
			// (get) Token: 0x060057D6 RID: 22486 RVA: 0x0018743C File Offset: 0x0018563C
			// (set) Token: 0x060057D7 RID: 22487 RVA: 0x00187464 File Offset: 0x00185664
			public unsafe TValue _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value);
					Type typeFromHandle = typeof(TValue);
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

			// Token: 0x170016B2 RID: 5810
			// (get) Token: 0x060057D8 RID: 22488 RVA: 0x0018750C File Offset: 0x0018570C
			// (set) Token: 0x060057D9 RID: 22489 RVA: 0x000217A2 File Offset: 0x0001F9A2
			public unsafe ConcurrentDictionary<TKey, TValue>.Node _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016B3 RID: 5811
			// (get) Token: 0x060057DA RID: 22490 RVA: 0x0018753C File Offset: 0x0018573C
			// (set) Token: 0x060057DB RID: 22491 RVA: 0x000217C1 File Offset: 0x0001F9C1
			public unsafe int _hashcode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode)) = value;
				}
			}

			// Token: 0x04004678 RID: 18040
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04004679 RID: 18041
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x0400467A RID: 18042
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x0400467B RID: 18043
			private static readonly IntPtr NativeFieldInfoPtr__hashcode;

			// Token: 0x0400467C RID: 18044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0;
		}

		// Token: 0x02000667 RID: 1639
		[Serializable]
		public sealed class DictionaryEnumerator : Object
		{
			// Token: 0x060057DC RID: 22492 RVA: 0x00187564 File Offset: 0x00185764
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryEnumerator()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "DictionaryEnumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, "_enumerator");
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673859);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673860);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673861);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673862);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673863);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673864);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673865);
			}

			// Token: 0x060057DD RID: 22493 RVA: 0x0018767C File Offset: 0x0018587C
			[CallerCount(0)]
			public unsafe DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170016B5 RID: 5813
			// (get) Token: 0x060057DE RID: 22494 RVA: 0x001876C8 File Offset: 0x001858C8
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230150, XrefRangeEnd = 230159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170016B6 RID: 5814
			// (get) Token: 0x060057DF RID: 22495 RVA: 0x00187700 File Offset: 0x00185900
			public unsafe Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230159, XrefRangeEnd = 230163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170016B7 RID: 5815
			// (get) Token: 0x060057E0 RID: 22496 RVA: 0x00187740 File Offset: 0x00185940
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230163, XrefRangeEnd = 230167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170016B8 RID: 5816
			// (get) Token: 0x060057E1 RID: 22497 RVA: 0x00187780 File Offset: 0x00185980
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230167, XrefRangeEnd = 230170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060057E2 RID: 22498 RVA: 0x001877C0 File Offset: 0x001859C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230170, XrefRangeEnd = 230174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057E3 RID: 22499 RVA: 0x001877FC File Offset: 0x001859FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230174, XrefRangeEnd = 230185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057E4 RID: 22500 RVA: 0x000217DC File Offset: 0x0001F9DC
			public DictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016B4 RID: 5812
			// (get) Token: 0x060057E5 RID: 22501 RVA: 0x00187830 File Offset: 0x00185A30
			// (set) Token: 0x060057E6 RID: 22502 RVA: 0x000217E5 File Offset: 0x0001F9E5
			public unsafe IEnumerator<KeyValuePair<TKey, TValue>> _enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400467D RID: 18045
			private static readonly IntPtr NativeFieldInfoPtr__enumerator;

			// Token: 0x0400467E RID: 18046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0;

			// Token: 0x0400467F RID: 18047
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004680 RID: 18048
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004681 RID: 18049
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004682 RID: 18050
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004683 RID: 18051
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004684 RID: 18052
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000668 RID: 1640
		[ObfuscatedName("System.Collections.Concurrent.ConcurrentDictionary`2+<GetEnumerator>d__32")]
		public sealed class _GetEnumerator_d__32 : Object
		{
			// Token: 0x060057E7 RID: 22503 RVA: 0x00187860 File Offset: 0x00185A60
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__32()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "<GetEnumerator>d__32"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<>1__state");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<>2__current");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<>4__this");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__buckets_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<buckets>5__1");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__current_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<current>5__2");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<i>5__3");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673866);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673867);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673868);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673869);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673870);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673871);
			}

			// Token: 0x060057E8 RID: 22504 RVA: 0x001879C8 File Offset: 0x00185BC8
			[CallerCount(0)]
			public unsafe _GetEnumerator_d__32(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060057E9 RID: 22505 RVA: 0x00187A10 File Offset: 0x00185C10
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057EA RID: 22506 RVA: 0x00187A44 File Offset: 0x00185C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230185, XrefRangeEnd = 230187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170016BF RID: 5823
			// (get) Token: 0x060057EB RID: 22507 RVA: 0x00187A80 File Offset: 0x00185C80
			public unsafe KeyValuePair<TKey, TValue> prop_KeyValuePair_2_TKey_TValue_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x060057EC RID: 22508 RVA: 0x00187AB8 File Offset: 0x00185CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230187, XrefRangeEnd = 230192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016C0 RID: 5824
			// (get) Token: 0x060057ED RID: 22509 RVA: 0x00187AEC File Offset: 0x00185CEC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230192, XrefRangeEnd = 230194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060057EE RID: 22510 RVA: 0x00021804 File Offset: 0x0001FA04
			public _GetEnumerator_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016B9 RID: 5817
			// (get) Token: 0x060057EF RID: 22511 RVA: 0x00187B2C File Offset: 0x00185D2C
			// (set) Token: 0x060057F0 RID: 22512 RVA: 0x0002180D File Offset: 0x0001FA0D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170016BA RID: 5818
			// (get) Token: 0x060057F1 RID: 22513 RVA: 0x00187B54 File Offset: 0x00185D54
			// (set) Token: 0x060057F2 RID: 22514 RVA: 0x00021828 File Offset: 0x0001FA28
			public KeyValuePair<TKey, TValue> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170016BB RID: 5819
			// (get) Token: 0x060057F3 RID: 22515 RVA: 0x00187B84 File Offset: 0x00185D84
			// (set) Token: 0x060057F4 RID: 22516 RVA: 0x00021856 File Offset: 0x0001FA56
			public unsafe ConcurrentDictionary<TKey, TValue> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016BC RID: 5820
			// (get) Token: 0x060057F5 RID: 22517 RVA: 0x00187BB4 File Offset: 0x00185DB4
			// (set) Token: 0x060057F6 RID: 22518 RVA: 0x00021875 File Offset: 0x0001FA75
			public unsafe Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> _buckets_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__buckets_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__buckets_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016BD RID: 5821
			// (get) Token: 0x060057F7 RID: 22519 RVA: 0x00187BE4 File Offset: 0x00185DE4
			// (set) Token: 0x060057F8 RID: 22520 RVA: 0x00021894 File Offset: 0x0001FA94
			public unsafe ConcurrentDictionary<TKey, TValue>.Node _current_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__current_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__current_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016BE RID: 5822
			// (get) Token: 0x060057F9 RID: 22521 RVA: 0x00187C14 File Offset: 0x00185E14
			// (set) Token: 0x060057FA RID: 22522 RVA: 0x000218B3 File Offset: 0x0001FAB3
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04004685 RID: 18053
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004686 RID: 18054
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004687 RID: 18055
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004688 RID: 18056
			private static readonly IntPtr NativeFieldInfoPtr__buckets_5__1;

			// Token: 0x04004689 RID: 18057
			private static readonly IntPtr NativeFieldInfoPtr__current_5__2;

			// Token: 0x0400468A RID: 18058
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400468B RID: 18059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400468C RID: 18060
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400468D RID: 18061
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400468E RID: 18062
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x0400468F RID: 18063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004690 RID: 18064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
