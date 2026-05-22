using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000493 RID: 1171
	[Serializable]
	public class Dictionary<TKey, TValue> : Object
	{
		// Token: 0x0600474F RID: 18255 RVA: 0x00148F80 File Offset: 0x00147180
		// Note: this type is marked as 'beforefieldinit'.
		static Dictionary()
		{
			Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Dictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr);
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "buckets");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "entries");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "count");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "version");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "freeList");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "freeCount");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "comparer");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "keys");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "values");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_syncRoot");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "VersionName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "HashSizeName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "KeyValuePairsName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "ComparerName");
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673905);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673906);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673907);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673908);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673909);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673910);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673911);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673912);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673913);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673914);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673915);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673916);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673917);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673918);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673919);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673920);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673921);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673922);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673923);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673924);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673925);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673926);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673927);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673928);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673929);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673930);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673931);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Initialize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673932);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673933);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673934);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673935);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673936);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673937);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673938);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673939);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673940);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673941);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673942);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673943);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673944);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673945);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673946);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673947);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673948);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673949);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673950);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673951);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673952);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673953);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673954);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673955);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x00149514 File Offset: 0x00147714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230783, XrefRangeEnd = 230784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00149550 File Offset: 0x00147750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x00149598 File Offset: 0x00147798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230784, XrefRangeEnd = 230785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x001495E4 File Offset: 0x001477E4
		[CallerCount(0)]
		public unsafe Dictionary(int capacity, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00149640 File Offset: 0x00147840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230785, XrefRangeEnd = 230810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0014968C File Offset: 0x0014788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230810, XrefRangeEnd = 230834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x001496EC File Offset: 0x001478EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230834, XrefRangeEnd = 230842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x00149750 File Offset: 0x00147950
		public unsafe IEqualityComparer<TKey> Comparer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x00149790 File Offset: 0x00147990
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x001497CC File Offset: 0x001479CC
		public unsafe Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 230845, RefRangeEnd = 230853, XrefRangeStart = 230842, XrefRangeEnd = 230845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.KeyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x0014980C File Offset: 0x00147A0C
		public unsafe virtual ICollection<TKey> prop_ICollection_1_TKey_0
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 230845, RefRangeEnd = 230853, XrefRangeStart = 230845, XrefRangeEnd = 230853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x0014984C File Offset: 0x00147A4C
		public unsafe Dictionary<TKey, TValue>.ValueCollection Values
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 230856, RefRangeEnd = 230873, XrefRangeStart = 230853, XrefRangeEnd = 230856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.ValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x0014988C File Offset: 0x00147A8C
		public unsafe virtual ICollection<TValue> prop_ICollection_1_TValue_0
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 230856, RefRangeEnd = 230873, XrefRangeStart = 230856, XrefRangeEnd = 230873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x17001246 RID: 4678
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 230873, RefRangeEnd = 230875, XrefRangeStart = 230873, XrefRangeEnd = 230873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x00149A50 File Offset: 0x00147C50
		[CallerCount(0)]
		public unsafe virtual void Add(TKey key, TValue value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x00149B3C File Offset: 0x00147D3C
		[CallerCount(0)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x00149B84 File Offset: 0x00147D84
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x00149BD8 File Offset: 0x00147DD8
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x00149C2C File Offset: 0x00147E2C
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 230877, RefRangeEnd = 230922, XrefRangeStart = 230875, XrefRangeEnd = 230877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x00149C60 File Offset: 0x00147E60
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x00149CF8 File Offset: 0x00147EF8
		[CallerCount(0)]
		public unsafe bool ContainsValue(TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TValue ptr4;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					if (!(tvalue is string))
					{
						ref TValue ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x00149D90 File Offset: 0x00147F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230922, XrefRangeEnd = 230923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x00149DE0 File Offset: 0x00147FE0
		[CallerCount(0)]
		public unsafe Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Dictionary<TKey, TValue>.Enumerator(intPtr);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x00149E18 File Offset: 0x00148018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230923, XrefRangeEnd = 230925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x00149E58 File Offset: 0x00148058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230925, XrefRangeEnd = 230947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x00149EBC File Offset: 0x001480BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230947, XrefRangeEnd = 230951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindEntry(TKey key)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x00149F54 File Offset: 0x00148154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230951, XrefRangeEnd = 230961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Initialize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x00149F94 File Offset: 0x00148194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230961, XrefRangeEnd = 230970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x0014A098 File Offset: 0x00148298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230970, XrefRangeEnd = 231002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x0014A0E8 File Offset: 0x001482E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231002, XrefRangeEnd = 231006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x0014A11C File Offset: 0x0014831C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231006, XrefRangeEnd = 231015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int newSize, bool forceNewHashCodes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceNewHashCodes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x0014A168 File Offset: 0x00148368
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 231019, RefRangeEnd = 231043, XrefRangeStart = 231015, XrefRangeEnd = 231019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(TKey key)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x0014A200 File Offset: 0x00148400
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 231043, RefRangeEnd = 231061, XrefRangeStart = 231043, XrefRangeEnd = 231043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x0014A2E8 File Offset: 0x001484E8
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x0014A324 File Offset: 0x00148524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231061, XrefRangeEnd = 231084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x0014A374 File Offset: 0x00148574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231084, XrefRangeEnd = 231106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x0014A3C4 File Offset: 0x001485C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x0014A404 File Offset: 0x00148604
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x0014A440 File Offset: 0x00148640
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231106, XrefRangeEnd = 231109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x0014A480 File Offset: 0x00148680
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06004779 RID: 18297 RVA: 0x0014A4BC File Offset: 0x001486BC
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x0014A4F8 File Offset: 0x001486F8
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231109, XrefRangeEnd = 231110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x0014A538 File Offset: 0x00148738
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231110, XrefRangeEnd = 231113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x0014A578 File Offset: 0x00148778
		// (set) Token: 0x0600477D RID: 18301 RVA: 0x0014A5C8 File Offset: 0x001487C8
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231113, XrefRangeEnd = 231115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231115, XrefRangeEnd = 231118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x0014A61C File Offset: 0x0014881C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231118, XrefRangeEnd = 231121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleKey(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x0014A660 File Offset: 0x00148860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231121, XrefRangeEnd = 231124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x0014A6B4 File Offset: 0x001488B4
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0014A704 File Offset: 0x00148904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231124, XrefRangeEnd = 231126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0014A744 File Offset: 0x00148944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231126, XrefRangeEnd = 231127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0001AE18 File Offset: 0x00019018
		public Dictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x0014A788 File Offset: 0x00148988
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x0001AE21 File Offset: 0x00019021
		public unsafe Il2CppStructArray<int> buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x0014A7B8 File Offset: 0x001489B8
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x0001AE40 File Offset: 0x00019040
		public unsafe Il2CppReferenceArray<Dictionary<TKey, TValue>.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Dictionary<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x0014A7E8 File Offset: 0x001489E8
		// (set) Token: 0x06004789 RID: 18313 RVA: 0x0001AE5F File Offset: 0x0001905F
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x0014A810 File Offset: 0x00148A10
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x0001AE7A File Offset: 0x0001907A
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x0014A838 File Offset: 0x00148A38
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x0001AE95 File Offset: 0x00019095
		public unsafe int freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeList)) = value;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x0014A860 File Offset: 0x00148A60
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x0001AEB0 File Offset: 0x000190B0
		public unsafe int freeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeCount)) = value;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x0014A888 File Offset: 0x00148A88
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x0001AECB File Offset: 0x000190CB
		public unsafe IEqualityComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x0014A8B8 File Offset: 0x00148AB8
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x0001AEEA File Offset: 0x000190EA
		public unsafe Dictionary<TKey, TValue>.KeyCollection keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.KeyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x0014A8E8 File Offset: 0x00148AE8
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x0001AF09 File Offset: 0x00019109
		public unsafe Dictionary<TKey, TValue>.ValueCollection values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.ValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x0014A918 File Offset: 0x00148B18
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x0001AF28 File Offset: 0x00019128
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x0014A948 File Offset: 0x00148B48
		// (set) Token: 0x06004799 RID: 18329 RVA: 0x0001AF47 File Offset: 0x00019147
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x0014A968 File Offset: 0x00148B68
		// (set) Token: 0x0600479B RID: 18331 RVA: 0x0001AF59 File Offset: 0x00019159
		public unsafe static string HashSizeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x0014A988 File Offset: 0x00148B88
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x0001AF6B File Offset: 0x0001916B
		public unsafe static string KeyValuePairsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600479E RID: 18334 RVA: 0x0014A9A8 File Offset: 0x00148BA8
		// (set) Token: 0x0600479F RID: 18335 RVA: 0x0001AF7D File Offset: 0x0001917D
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039F4 RID: 14836
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x040039F5 RID: 14837
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040039F6 RID: 14838
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040039F7 RID: 14839
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040039F8 RID: 14840
		private static readonly IntPtr NativeFieldInfoPtr_freeList;

		// Token: 0x040039F9 RID: 14841
		private static readonly IntPtr NativeFieldInfoPtr_freeCount;

		// Token: 0x040039FA RID: 14842
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040039FB RID: 14843
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x040039FC RID: 14844
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x040039FD RID: 14845
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x040039FE RID: 14846
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x040039FF RID: 14847
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeName;

		// Token: 0x04003A00 RID: 14848
		private static readonly IntPtr NativeFieldInfoPtr_KeyValuePairsName;

		// Token: 0x04003A01 RID: 14849
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x04003A02 RID: 14850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A03 RID: 14851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003A04 RID: 14852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x04003A05 RID: 14853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0;

		// Token: 0x04003A06 RID: 14854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

		// Token: 0x04003A07 RID: 14855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0;

		// Token: 0x04003A08 RID: 14856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003A09 RID: 14857
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_TKey_0;

		// Token: 0x04003A0A RID: 14858
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003A0B RID: 14859
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0;

		// Token: 0x04003A0C RID: 14860
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04003A0D RID: 14861
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0;

		// Token: 0x04003A0E RID: 14862
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04003A0F RID: 14863
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x04003A10 RID: 14864
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04003A11 RID: 14865
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04003A12 RID: 14866
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003A13 RID: 14867
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003A14 RID: 14868
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x04003A15 RID: 14869
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003A16 RID: 14870
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003A17 RID: 14871
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0;

		// Token: 0x04003A18 RID: 14872
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003A19 RID: 14873
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

		// Token: 0x04003A1A RID: 14874
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003A1B RID: 14875
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003A1C RID: 14876
		private static readonly IntPtr NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0;

		// Token: 0x04003A1D RID: 14877
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Int32_0;

		// Token: 0x04003A1E RID: 14878
		private static readonly IntPtr NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0;

		// Token: 0x04003A1F RID: 14879
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003A20 RID: 14880
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;

		// Token: 0x04003A21 RID: 14881
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0;

		// Token: 0x04003A22 RID: 14882
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003A23 RID: 14883
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003A24 RID: 14884
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003A25 RID: 14885
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003A26 RID: 14886
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003A27 RID: 14887
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003A28 RID: 14888
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003A29 RID: 14889
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003A2A RID: 14890
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003A2B RID: 14891
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003A2C RID: 14892
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003A2D RID: 14893
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003A2E RID: 14894
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04003A2F RID: 14895
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04003A30 RID: 14896
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0;

		// Token: 0x04003A31 RID: 14897
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04003A32 RID: 14898
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04003A33 RID: 14899
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04003A34 RID: 14900
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0200066B RID: 1643
		public sealed class Entry : ValueType
		{
			// Token: 0x060057FD RID: 22525 RVA: 0x00187D04 File Offset: 0x00185F04
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr);
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "hashCode");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "next");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "key");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "value");
			}

			// Token: 0x060057FE RID: 22526 RVA: 0x000218CE File Offset: 0x0001FACE
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060057FF RID: 22527 RVA: 0x000218D7 File Offset: 0x0001FAD7
			public Entry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr))
			{
			}

			// Token: 0x170016C1 RID: 5825
			// (get) Token: 0x06005800 RID: 22528 RVA: 0x00187DCC File Offset: 0x00185FCC
			// (set) Token: 0x06005801 RID: 22529 RVA: 0x000218E9 File Offset: 0x0001FAE9
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x170016C2 RID: 5826
			// (get) Token: 0x06005802 RID: 22530 RVA: 0x00187DF4 File Offset: 0x00185FF4
			// (set) Token: 0x06005803 RID: 22531 RVA: 0x00021904 File Offset: 0x0001FB04
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x170016C3 RID: 5827
			// (get) Token: 0x06005804 RID: 22532 RVA: 0x00187E1C File Offset: 0x0018601C
			// (set) Token: 0x06005805 RID: 22533 RVA: 0x00187E44 File Offset: 0x00186044
			public unsafe TKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
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

			// Token: 0x170016C4 RID: 5828
			// (get) Token: 0x06005806 RID: 22534 RVA: 0x00187EEC File Offset: 0x001860EC
			// (set) Token: 0x06005807 RID: 22535 RVA: 0x00187F14 File Offset: 0x00186114
			public unsafe TValue value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
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

			// Token: 0x04004693 RID: 18067
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04004694 RID: 18068
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04004695 RID: 18069
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04004696 RID: 18070
			private static readonly IntPtr NativeFieldInfoPtr_value;
		}

		// Token: 0x0200066C RID: 1644
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06005808 RID: 22536 RVA: 0x00187FBC File Offset: 0x001861BC
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr);
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "dictionary");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "version");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "index");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "current");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_getEnumeratorRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "getEnumeratorRetType");
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673956);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673957);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673958);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673959);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673960);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673961);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673962);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673963);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673964);
			}

			// Token: 0x06005809 RID: 22537 RVA: 0x0018814C File Offset: 0x0018634C
			[CallerCount(0)]
			public unsafe Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getEnumeratorRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600580A RID: 22538 RVA: 0x001881AC File Offset: 0x001863AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230678, XrefRangeEnd = 230680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170016CA RID: 5834
			// (get) Token: 0x0600580B RID: 22539 RVA: 0x001881F0 File Offset: 0x001863F0
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x0600580C RID: 22540 RVA: 0x0018822C File Offset: 0x0018642C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016CB RID: 5835
			// (get) Token: 0x0600580D RID: 22541 RVA: 0x00188264 File Offset: 0x00186464
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230680, XrefRangeEnd = 230687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600580E RID: 22542 RVA: 0x001882A8 File Offset: 0x001864A8
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016CC RID: 5836
			// (get) Token: 0x0600580F RID: 22543 RVA: 0x001882E0 File Offset: 0x001864E0
			public unsafe DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230687, XrefRangeEnd = 230693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170016CD RID: 5837
			// (get) Token: 0x06005810 RID: 22544 RVA: 0x0018831C File Offset: 0x0018651C
			public unsafe Object System.Collections.IDictionaryEnumerator.Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230693, XrefRangeEnd = 230697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170016CE RID: 5838
			// (get) Token: 0x06005811 RID: 22545 RVA: 0x00188360 File Offset: 0x00186560
			public unsafe Object System.Collections.IDictionaryEnumerator.Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230697, XrefRangeEnd = 230698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005812 RID: 22546 RVA: 0x0002191F File Offset: 0x0001FB1F
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005813 RID: 22547 RVA: 0x00021928 File Offset: 0x0001FB28
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170016C5 RID: 5829
			// (get) Token: 0x06005814 RID: 22548 RVA: 0x001883A4 File Offset: 0x001865A4
			// (set) Token: 0x06005815 RID: 22549 RVA: 0x0002193A File Offset: 0x0001FB3A
			public unsafe Dictionary<TKey, TValue> dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016C6 RID: 5830
			// (get) Token: 0x06005816 RID: 22550 RVA: 0x001883D4 File Offset: 0x001865D4
			// (set) Token: 0x06005817 RID: 22551 RVA: 0x00021959 File Offset: 0x0001FB59
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170016C7 RID: 5831
			// (get) Token: 0x06005818 RID: 22552 RVA: 0x001883FC File Offset: 0x001865FC
			// (set) Token: 0x06005819 RID: 22553 RVA: 0x00021974 File Offset: 0x0001FB74
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170016C8 RID: 5832
			// (get) Token: 0x0600581A RID: 22554 RVA: 0x00188424 File Offset: 0x00186624
			// (set) Token: 0x0600581B RID: 22555 RVA: 0x0002198F File Offset: 0x0001FB8F
			public KeyValuePair<TKey, TValue> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170016C9 RID: 5833
			// (get) Token: 0x0600581C RID: 22556 RVA: 0x00188454 File Offset: 0x00186654
			// (set) Token: 0x0600581D RID: 22557 RVA: 0x000219BD File Offset: 0x0001FBBD
			public unsafe int getEnumeratorRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_getEnumeratorRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_getEnumeratorRetType)) = value;
				}
			}

			// Token: 0x04004697 RID: 18071
			private static readonly IntPtr NativeFieldInfoPtr_dictionary;

			// Token: 0x04004698 RID: 18072
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04004699 RID: 18073
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400469A RID: 18074
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x0400469B RID: 18075
			private static readonly IntPtr NativeFieldInfoPtr_getEnumeratorRetType;

			// Token: 0x0400469C RID: 18076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0;

			// Token: 0x0400469D RID: 18077
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400469E RID: 18078
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x0400469F RID: 18079
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040046A0 RID: 18080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040046A1 RID: 18081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040046A2 RID: 18082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x040046A3 RID: 18083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040046A4 RID: 18084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200066D RID: 1645
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x0600581E RID: 22558 RVA: 0x0018847C File Offset: 0x0018667C
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "dictionary");
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673965);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673966);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673967);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673968);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673969);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673970);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673971);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673972);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673973);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673974);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673975);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673976);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673977);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673978);
			}

			// Token: 0x0600581F RID: 22559 RVA: 0x00188620 File Offset: 0x00186820
			[CallerCount(0)]
			public unsafe KeyCollection(Dictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005820 RID: 22560 RVA: 0x0018866C File Offset: 0x0018686C
			[CallerCount(0)]
			public unsafe Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(intPtr);
			}

			// Token: 0x06005821 RID: 22561 RVA: 0x001886A4 File Offset: 0x001868A4
			[CallerCount(0)]
			public unsafe void CopyTo(Il2CppArrayBase<TKey> array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016D0 RID: 5840
			// (get) Token: 0x06005822 RID: 22562 RVA: 0x001886F4 File Offset: 0x001868F4
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170016D1 RID: 5841
			// (get) Token: 0x06005823 RID: 22563 RVA: 0x00188730 File Offset: 0x00186930
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005824 RID: 22564 RVA: 0x0018876C File Offset: 0x0018696C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230702, XrefRangeEnd = 230708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Add(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TKey ptr4;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
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
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005825 RID: 22565 RVA: 0x001887FC File Offset: 0x001869FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230708, XrefRangeEnd = 230714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005826 RID: 22566 RVA: 0x00188830 File Offset: 0x00186A30
			[CallerCount(0)]
			public unsafe bool System_Collections_Generic_ICollection_TKey__Contains(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TKey ptr4;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
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
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005827 RID: 22567 RVA: 0x001888C8 File Offset: 0x00186AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230714, XrefRangeEnd = 230720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TKey__Remove(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TKey ptr4;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
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
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005828 RID: 22568 RVA: 0x00188960 File Offset: 0x00186B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230720, XrefRangeEnd = 230722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> System_Collections_Generic_IEnumerable_TKey__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x06005829 RID: 22569 RVA: 0x001889A0 File Offset: 0x00186BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600582A RID: 22570 RVA: 0x001889E0 File Offset: 0x00186BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230722, XrefRangeEnd = 230735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016D2 RID: 5842
			// (get) Token: 0x0600582B RID: 22571 RVA: 0x00188A30 File Offset: 0x00186C30
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170016D3 RID: 5843
			// (get) Token: 0x0600582C RID: 22572 RVA: 0x00188A6C File Offset: 0x00186C6C
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230735, XrefRangeEnd = 230739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600582D RID: 22573 RVA: 0x000219D8 File Offset: 0x0001FBD8
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016CF RID: 5839
			// (get) Token: 0x0600582E RID: 22574 RVA: 0x00188AAC File Offset: 0x00186CAC
			// (set) Token: 0x0600582F RID: 22575 RVA: 0x000219E1 File Offset: 0x0001FBE1
			public unsafe Dictionary<TKey, TValue> dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040046A5 RID: 18085
			private static readonly IntPtr NativeFieldInfoPtr_dictionary;

			// Token: 0x040046A6 RID: 18086
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0;

			// Token: 0x040046A7 RID: 18087
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x040046A8 RID: 18088
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x040046A9 RID: 18089
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040046AA RID: 18090
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040046AB RID: 18091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x040046AC RID: 18092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x040046AD RID: 18093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x040046AE RID: 18094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x040046AF RID: 18095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x040046B0 RID: 18096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040046B1 RID: 18097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040046B2 RID: 18098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040046B3 RID: 18099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020006CF RID: 1743
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060059D6 RID: 22998 RVA: 0x0018CCE4 File Offset: 0x0018AEE4
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "dictionary");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "index");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "version");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "currentKey");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673979);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673980);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673981);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673982);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673983);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673984);
				}

				// Token: 0x060059D7 RID: 22999 RVA: 0x0018CE24 File Offset: 0x0018B024
				[CallerCount(0)]
				public unsafe Enumerator(Dictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060059D8 RID: 23000 RVA: 0x0018CE74 File Offset: 0x0018B074
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059D9 RID: 23001 RVA: 0x0018CEAC File Offset: 0x0018B0AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230698, XrefRangeEnd = 230699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001729 RID: 5929
				// (get) Token: 0x060059DA RID: 23002 RVA: 0x0018CEF0 File Offset: 0x0018B0F0
				public unsafe TKey Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
					}
				}

				// Token: 0x1700172A RID: 5930
				// (get) Token: 0x060059DB RID: 23003 RVA: 0x0018CF30 File Offset: 0x0018B130
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230699, XrefRangeEnd = 230702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060059DC RID: 23004 RVA: 0x0018CF74 File Offset: 0x0018B174
				[CallerCount(0)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059DD RID: 23005 RVA: 0x00022BBD File Offset: 0x00020DBD
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060059DE RID: 23006 RVA: 0x00022BC6 File Offset: 0x00020DC6
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17001725 RID: 5925
				// (get) Token: 0x060059DF RID: 23007 RVA: 0x0018CFAC File Offset: 0x0018B1AC
				// (set) Token: 0x060059E0 RID: 23008 RVA: 0x00022BD8 File Offset: 0x00020DD8
				public unsafe Dictionary<TKey, TValue> dictionary
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_dictionary);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001726 RID: 5926
				// (get) Token: 0x060059E1 RID: 23009 RVA: 0x0018CFDC File Offset: 0x0018B1DC
				// (set) Token: 0x060059E2 RID: 23010 RVA: 0x00022BF7 File Offset: 0x00020DF7
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x17001727 RID: 5927
				// (get) Token: 0x060059E3 RID: 23011 RVA: 0x0018D004 File Offset: 0x0018B204
				// (set) Token: 0x060059E4 RID: 23012 RVA: 0x00022C12 File Offset: 0x00020E12
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x17001728 RID: 5928
				// (get) Token: 0x060059E5 RID: 23013 RVA: 0x0018D02C File Offset: 0x0018B22C
				// (set) Token: 0x060059E6 RID: 23014 RVA: 0x0018D054 File Offset: 0x0018B254
				public unsafe TKey currentKey
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_currentKey);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_currentKey);
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

				// Token: 0x040047B8 RID: 18360
				private static readonly IntPtr NativeFieldInfoPtr_dictionary;

				// Token: 0x040047B9 RID: 18361
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x040047BA RID: 18362
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x040047BB RID: 18363
				private static readonly IntPtr NativeFieldInfoPtr_currentKey;

				// Token: 0x040047BC RID: 18364
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0;

				// Token: 0x040047BD RID: 18365
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x040047BE RID: 18366
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x040047BF RID: 18367
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0;

				// Token: 0x040047C0 RID: 18368
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040047C1 RID: 18369
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x0200066E RID: 1646
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x06005830 RID: 22576 RVA: 0x00188ADC File Offset: 0x00186CDC
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "dictionary");
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673985);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673986);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673987);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673988);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673989);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673990);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673991);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673992);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673993);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673994);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673995);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673996);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673997);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673998);
			}

			// Token: 0x06005831 RID: 22577 RVA: 0x00188C80 File Offset: 0x00186E80
			[CallerCount(0)]
			public unsafe ValueCollection(Dictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005832 RID: 22578 RVA: 0x00188CCC File Offset: 0x00186ECC
			[CallerCount(0)]
			public unsafe Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(intPtr);
			}

			// Token: 0x06005833 RID: 22579 RVA: 0x00188D04 File Offset: 0x00186F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230740, XrefRangeEnd = 230741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppArrayBase<TValue> array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016D5 RID: 5845
			// (get) Token: 0x06005834 RID: 22580 RVA: 0x00188D54 File Offset: 0x00186F54
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170016D6 RID: 5846
			// (get) Token: 0x06005835 RID: 22581 RVA: 0x00188D90 File Offset: 0x00186F90
			public unsafe bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005836 RID: 22582 RVA: 0x00188DCC File Offset: 0x00186FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230741, XrefRangeEnd = 230747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Add(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TValue ptr4;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						if (!(tvalue is string))
						{
							ref TValue ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005837 RID: 22583 RVA: 0x00188E5C File Offset: 0x0018705C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230747, XrefRangeEnd = 230753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TValue__Remove(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TValue ptr4;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						if (!(tvalue is string))
						{
							ref TValue ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005838 RID: 22584 RVA: 0x00188EF4 File Offset: 0x001870F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230753, XrefRangeEnd = 230759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005839 RID: 22585 RVA: 0x00188F28 File Offset: 0x00187128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230759, XrefRangeEnd = 230766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TValue__Contains(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TValue ptr4;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						if (!(tvalue is string))
						{
							ref TValue ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600583A RID: 22586 RVA: 0x00188FC0 File Offset: 0x001871C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230766, XrefRangeEnd = 230768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> System_Collections_Generic_IEnumerable_TValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x0600583B RID: 22587 RVA: 0x00189000 File Offset: 0x00187200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600583C RID: 22588 RVA: 0x00189040 File Offset: 0x00187240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230768, XrefRangeEnd = 230779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016D7 RID: 5847
			// (get) Token: 0x0600583D RID: 22589 RVA: 0x00189090 File Offset: 0x00187290
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170016D8 RID: 5848
			// (get) Token: 0x0600583E RID: 22590 RVA: 0x001890CC File Offset: 0x001872CC
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230779, XrefRangeEnd = 230783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600583F RID: 22591 RVA: 0x00021A00 File Offset: 0x0001FC00
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016D4 RID: 5844
			// (get) Token: 0x06005840 RID: 22592 RVA: 0x0018910C File Offset: 0x0018730C
			// (set) Token: 0x06005841 RID: 22593 RVA: 0x00021A09 File Offset: 0x0001FC09
			public unsafe Dictionary<TKey, TValue> dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040046B4 RID: 18100
			private static readonly IntPtr NativeFieldInfoPtr_dictionary;

			// Token: 0x040046B5 RID: 18101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0;

			// Token: 0x040046B6 RID: 18102
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x040046B7 RID: 18103
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0;

			// Token: 0x040046B8 RID: 18104
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040046B9 RID: 18105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040046BA RID: 18106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0;

			// Token: 0x040046BB RID: 18107
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x040046BC RID: 18108
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x040046BD RID: 18109
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x040046BE RID: 18110
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x040046BF RID: 18111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040046C0 RID: 18112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040046C1 RID: 18113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040046C2 RID: 18114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020006D0 RID: 1744
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060059E7 RID: 23015 RVA: 0x0018D0FC File Offset: 0x0018B2FC
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "dictionary");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "index");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "version");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "currentValue");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100673999);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674000);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674001);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674002);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674003);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674004);
				}

				// Token: 0x060059E8 RID: 23016 RVA: 0x0018D23C File Offset: 0x0018B43C
				[CallerCount(0)]
				public unsafe Enumerator(Dictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060059E9 RID: 23017 RVA: 0x0018D28C File Offset: 0x0018B48C
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059EA RID: 23018 RVA: 0x0018D2C4 File Offset: 0x0018B4C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230739, XrefRangeEnd = 230740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700172F RID: 5935
				// (get) Token: 0x060059EB RID: 23019 RVA: 0x0018D308 File Offset: 0x0018B508
				public unsafe TValue Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
					}
				}

				// Token: 0x17001730 RID: 5936
				// (get) Token: 0x060059EC RID: 23020 RVA: 0x0018D348 File Offset: 0x0018B548
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060059ED RID: 23021 RVA: 0x0018D38C File Offset: 0x0018B58C
				[CallerCount(0)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059EE RID: 23022 RVA: 0x00022C2D File Offset: 0x00020E2D
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060059EF RID: 23023 RVA: 0x00022C36 File Offset: 0x00020E36
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x1700172B RID: 5931
				// (get) Token: 0x060059F0 RID: 23024 RVA: 0x0018D3C4 File Offset: 0x0018B5C4
				// (set) Token: 0x060059F1 RID: 23025 RVA: 0x00022C48 File Offset: 0x00020E48
				public unsafe Dictionary<TKey, TValue> dictionary
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_dictionary);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700172C RID: 5932
				// (get) Token: 0x060059F2 RID: 23026 RVA: 0x0018D3F4 File Offset: 0x0018B5F4
				// (set) Token: 0x060059F3 RID: 23027 RVA: 0x00022C67 File Offset: 0x00020E67
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x1700172D RID: 5933
				// (get) Token: 0x060059F4 RID: 23028 RVA: 0x0018D41C File Offset: 0x0018B61C
				// (set) Token: 0x060059F5 RID: 23029 RVA: 0x00022C82 File Offset: 0x00020E82
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x1700172E RID: 5934
				// (get) Token: 0x060059F6 RID: 23030 RVA: 0x0018D444 File Offset: 0x0018B644
				// (set) Token: 0x060059F7 RID: 23031 RVA: 0x0018D46C File Offset: 0x0018B66C
				public unsafe TValue currentValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_currentValue);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_currentValue);
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

				// Token: 0x040047C2 RID: 18370
				private static readonly IntPtr NativeFieldInfoPtr_dictionary;

				// Token: 0x040047C3 RID: 18371
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x040047C4 RID: 18372
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x040047C5 RID: 18373
				private static readonly IntPtr NativeFieldInfoPtr_currentValue;

				// Token: 0x040047C6 RID: 18374
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0;

				// Token: 0x040047C7 RID: 18375
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x040047C8 RID: 18376
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x040047C9 RID: 18377
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0;

				// Token: 0x040047CA RID: 18378
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040047CB RID: 18379
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}
	}
}
