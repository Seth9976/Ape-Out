using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001B8 RID: 440
	public class IndexedDictionary<TKey, TValue> : Object
	{
		// Token: 0x06002D4B RID: 11595 RVA: 0x000E07B8 File Offset: 0x000DE9B8
		// Note: this type is marked as 'beforefieldinit'.
		static IndexedDictionary()
		{
			Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "IndexedDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr);
			IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "hVRYlvkeMegeilrvqzjMTEgLgtIf");
			IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "BRnOGwiQsoyBdDLDAjvpbphqCGu");
			IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "rKWSwKmIhNDTzhLhIevaHwnfvwbJ");
			IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "TaNQqqGIyLgPUHVmRCwddtyGHCBD");
			IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "fxPATlMlJgrpdQJpyRPxIJKzOGb");
			IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_RnDCKqfnobSzgIdLumNLXyNDfxf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "RnDCKqfnobSzgIdLumNLXyNDfxf");
			IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_yUadRyBTxALHCezTlCyJoHUyfzxT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "yUadRyBTxALHCezTlCyJoHUyfzxT");
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674985);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_ContainsDuplicateKeys_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674986);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_AllowDuplicateKeys_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674987);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_AllowDuplicateKeys_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674988);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674989);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674990);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674991);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674992);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674993);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674994);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_get_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674995);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674996);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_KeyComparer_Public_get_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674997);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_KeyComparer_Public_set_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674998);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_ValueComparer_Public_get_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100674999);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_ValueComparer_Public_set_Void_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675000);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675001);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675002);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeyAt_Public_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675003);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEntry_Public_KeyValuePair_2_TKey_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675004);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEntryAt_Public_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675005);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_TKey_byref_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675006);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675007);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_SetValue_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675008);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675009);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675010);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveValue_Public_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675011);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveAll_Public_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675012);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675013);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfValue_Public_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675014);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675015);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675016);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675017);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TrimExcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675018);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675019);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675020);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675021);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675022);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675023);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675024);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675025);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675026);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675027);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675028);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675029);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675030);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675031);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675032);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675033);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675034);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675035);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675036);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675037);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675038);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675039);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675040);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675041);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675042);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_TValue__get_Item_Private_Virtual_Final_New_get_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675043);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_iSLJLAJXjAjQexXBVDvDoMruXpu_Private_Virtual_Final_New_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675044);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_DOlHqXWpZBbbKzPEfAbgXfxxcZgA_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675045);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675046);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675047);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_AaYUMnnIfuSbjBaDkBRuxRBhFflb_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675048);
			IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TqkYFxPbwzGdECbPeYFwtzomsMe_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675049);
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000E0DD8 File Offset: 0x000DEFD8
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x000E0E14 File Offset: 0x000DF014
		public unsafe bool ContainsDuplicateKeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_ContainsDuplicateKeys_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x000E0E50 File Offset: 0x000DF050
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x000E0E8C File Offset: 0x000DF08C
		public unsafe bool AllowDuplicateKeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_AllowDuplicateKeys_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_AllowDuplicateKeys_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x000E0ECC File Offset: 0x000DF0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330929, XrefRangeEnd = 330930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x000E0F08 File Offset: 0x000DF108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330930, XrefRangeEnd = 330931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedDictionary(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x000E0F50 File Offset: 0x000DF150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330931, XrefRangeEnd = 330936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedDictionary(bool allowDuplicateKeys)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowDuplicateKeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x000E0F98 File Offset: 0x000DF198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330936, XrefRangeEnd = 330940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedDictionary(int capacity, bool allowDuplicateKeys)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDuplicateKeys;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x000E0FF0 File Offset: 0x000DF1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330940, XrefRangeEnd = 330963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedDictionary(IDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000E103C File Offset: 0x000DF23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330963, XrefRangeEnd = 330985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedDictionary(IDictionary<TKey, TValue> dictionary, bool allowDuplicateKeys)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDuplicateKeys;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E72 RID: 3698
		public unsafe TValue this[int index]
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 330985, RefRangeEnd = 330997, XrefRangeStart = 330985, XrefRangeEnd = 330985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_get_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					*ptr = ref index;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000E117C File Offset: 0x000DF37C
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x000E11BC File Offset: 0x000DF3BC
		public unsafe IEqualityComparer<TKey> KeyComparer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_KeyComparer_Public_get_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_KeyComparer_Public_set_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x000E1200 File Offset: 0x000DF400
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x000E1240 File Offset: 0x000DF440
		public unsafe IEqualityComparer<TValue> ValueComparer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_ValueComparer_Public_get_IEqualityComparer_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TValue>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_ValueComparer_Public_set_Void_IEqualityComparer_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x000E1284 File Offset: 0x000DF484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330997, RefRangeEnd = 330999, XrefRangeStart = 330997, XrefRangeEnd = 330997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetValue(TKey key)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x000E131C File Offset: 0x000DF51C
		[CallerCount(0)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000E1404 File Offset: 0x000DF604
		[CallerCount(0)]
		public unsafe TKey GetKeyAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeyAt_Public_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000E144C File Offset: 0x000DF64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330999, XrefRangeEnd = 331000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair<TKey, TValue> GetEntry(TKey key)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEntry_Public_KeyValuePair_2_TKey_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<TKey, TValue>(intPtr);
			}
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000E14E0 File Offset: 0x000DF6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331000, XrefRangeEnd = 331001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEntryAt_Public_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<TKey, TValue>(intPtr);
			}
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000E1524 File Offset: 0x000DF724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331001, XrefRangeEnd = 331002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetEntry(TKey key, out KeyValuePair<TKey, TValue> entry)
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
			IntPtr intPtr = 0;
			ptr5 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_TKey_byref_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new KeyValuePair<TKey, TValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x000E15E0 File Offset: 0x000DF7E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 331002, RefRangeEnd = 331008, XrefRangeStart = 331002, XrefRangeEnd = 331002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x000E16CC File Offset: 0x000DF8CC
		[CallerCount(0)]
		public unsafe void SetValue(TKey key, TValue value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_SetValue_Public_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x000E17B8 File Offset: 0x000DF9B8
		[CallerCount(0)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000E1850 File Offset: 0x000DFA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331008, XrefRangeEnd = 331020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000E1890 File Offset: 0x000DFA90
		[CallerCount(0)]
		public unsafe void RemoveValue(TValue value)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveValue_Public_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000E1920 File Offset: 0x000DFB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331020, XrefRangeEnd = 331022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RemoveAll(TValue value)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveAll_Public_Int32_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000E19B8 File Offset: 0x000DFBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331022, XrefRangeEnd = 331029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfKey(TKey key)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000E1A50 File Offset: 0x000DFC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331029, XrefRangeEnd = 331031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfValue(TValue value)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfValue_Public_Int32_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000E1AE8 File Offset: 0x000DFCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331031, XrefRangeEnd = 331032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000E1B80 File Offset: 0x000DFD80
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000E1C18 File Offset: 0x000DFE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331032, XrefRangeEnd = 331033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000E1C4C File Offset: 0x000DFE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331033, XrefRangeEnd = 331034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimExcess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TrimExcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000E1C80 File Offset: 0x000DFE80
		public unsafe virtual ICollection<TKey> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331034, XrefRangeEnd = 331036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000E1CC0 File Offset: 0x000DFEC0
		public unsafe virtual ICollection<TValue> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331036, XrefRangeEnd = 331038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x000E1D00 File Offset: 0x000DFF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331038, XrefRangeEnd = 331039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000E1D48 File Offset: 0x000DFF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331039, XrefRangeEnd = 331041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000E1D9C File Offset: 0x000DFF9C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x000E1DEC File Offset: 0x000DFFEC
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x000E1E28 File Offset: 0x000E0028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331041, XrefRangeEnd = 331043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x000E1E7C File Offset: 0x000E007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331043, XrefRangeEnd = 331046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000E1EBC File Offset: 0x000E00BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000E1EFC File Offset: 0x000E00FC
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x000E1F94 File Offset: 0x000E0194
		public unsafe virtual TValue prop_TValue_0
		{
			[CallerCount(0)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331046, XrefRangeEnd = 331047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000E2080 File Offset: 0x000E0280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331047, XrefRangeEnd = 331054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000E20D4 File Offset: 0x000E02D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331054, XrefRangeEnd = 331057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000E2124 File Offset: 0x000E0324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331057, XrefRangeEnd = 331060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x000E2164 File Offset: 0x000E0364
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x000E21A0 File Offset: 0x000E03A0
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000E21DC File Offset: 0x000E03DC
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000E221C File Offset: 0x000E041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331060, XrefRangeEnd = 331063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x000E2260 File Offset: 0x000E0460
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x000E22A0 File Offset: 0x000E04A0
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x000E22F0 File Offset: 0x000E04F0
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331063, XrefRangeEnd = 331068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331068, XrefRangeEnd = 331074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000E2344 File Offset: 0x000E0544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331074, XrefRangeEnd = 331079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000E2394 File Offset: 0x000E0594
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331079, XrefRangeEnd = 331083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000E23D0 File Offset: 0x000E05D0
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331083, XrefRangeEnd = 331087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000E2410 File Offset: 0x000E0610
		public unsafe virtual TValue Rewired.Utils.Interfaces.IReadOnlyList<TValue>.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331087, XrefRangeEnd = 331088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_TValue__get_Item_Private_Virtual_Final_New_get_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000E2458 File Offset: 0x000E0658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331088, XrefRangeEnd = 331089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int iSLJLAJXjAjQexXBVDvDoMruXpu(TValue A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TValue ptr4;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = A_1;
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
					ptr4 = ref A_1;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_iSLJLAJXjAjQexXBVDvDoMruXpu_Private_Virtual_Final_New_Int32_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000E24F0 File Offset: 0x000E06F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331089, XrefRangeEnd = 331090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DOlHqXWpZBbbKzPEfAbgXfxxcZgA(TValue A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TValue ptr4;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = A_1;
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
					ptr4 = ref A_1;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_DOlHqXWpZBbbKzPEfAbgXfxxcZgA_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x000E2588 File Offset: 0x000E0788
		public unsafe virtual int Rewired.Utils.Interfaces.IReadOnlyList.Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331090, XrefRangeEnd = 331093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000E25C4 File Offset: 0x000E07C4
		public unsafe virtual Object Rewired.Utils.Interfaces.IReadOnlyList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000E2610 File Offset: 0x000E0810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331093, XrefRangeEnd = 331098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AaYUMnnIfuSbjBaDkBRuxRBhFflb(Object A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_AaYUMnnIfuSbjBaDkBRuxRBhFflb_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x000E2660 File Offset: 0x000E0860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331098, XrefRangeEnd = 331114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TqkYFxPbwzGdECbPeYFwtzomsMe(Object A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.NativeMethodInfoPtr_TqkYFxPbwzGdECbPeYFwtzomsMe_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00010D92 File Offset: 0x0000EF92
		public IndexedDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x000E26B0 File Offset: 0x000E08B0
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00010D9B File Offset: 0x0000EF9B
		public unsafe static bool hVRYlvkeMegeilrvqzjMTEgLgtIf
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf, (void*)(&value));
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x000E26CC File Offset: 0x000E08CC
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x00010DA9 File Offset: 0x0000EFA9
		public unsafe static bool BRnOGwiQsoyBdDLDAjvpbphqCGu
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu, (void*)(&value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x000E26E8 File Offset: 0x000E08E8
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x00010DB7 File Offset: 0x0000EFB7
		public unsafe IEqualityComparer<TKey> rKWSwKmIhNDTzhLhIevaHwnfvwbJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x000E2718 File Offset: 0x000E0918
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x00010DD6 File Offset: 0x0000EFD6
		public unsafe IEqualityComparer<TValue> TaNQqqGIyLgPUHVmRCwddtyGHCBD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x000E2748 File Offset: 0x000E0948
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x00010DF5 File Offset: 0x0000EFF5
		public unsafe AList<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX> fxPATlMlJgrpdQJpyRPxIJKzOGb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AList<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000E2778 File Offset: 0x000E0978
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00010E14 File Offset: 0x0000F014
		public unsafe ADictionary<TKey, int> RnDCKqfnobSzgIdLumNLXyNDfxf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_RnDCKqfnobSzgIdLumNLXyNDfxf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_RnDCKqfnobSzgIdLumNLXyNDfxf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000E27A8 File Offset: 0x000E09A8
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00010E33 File Offset: 0x0000F033
		public unsafe bool yUadRyBTxALHCezTlCyJoHUyfzxT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_yUadRyBTxALHCezTlCyJoHUyfzxT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.NativeFieldInfoPtr_yUadRyBTxALHCezTlCyJoHUyfzxT)) = value;
			}
		}

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ;

		// Token: 0x0400265F RID: 9823
		private static readonly IntPtr NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD;

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeFieldInfoPtr_RnDCKqfnobSzgIdLumNLXyNDfxf;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeFieldInfoPtr_yUadRyBTxALHCezTlCyJoHUyfzxT;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsDuplicateKeys_Public_get_Boolean_0;

		// Token: 0x04002665 RID: 9829
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowDuplicateKeys_Public_get_Boolean_0;

		// Token: 0x04002666 RID: 9830
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowDuplicateKeys_Public_set_Void_Boolean_0;

		// Token: 0x04002667 RID: 9831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002668 RID: 9832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002669 RID: 9833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400266A RID: 9834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x0400266B RID: 9835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_Boolean_0;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_TValue_Int32_0;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_TValue_0;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyComparer_Public_get_IEqualityComparer_1_TKey_0;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyComparer_Public_set_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueComparer_Public_get_IEqualityComparer_1_TValue_0;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueComparer_Public_set_Void_IEqualityComparer_1_TValue_0;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_TValue_TKey_0;

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyAt_Public_TKey_Int32_0;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_KeyValuePair_2_TKey_TValue_TKey_0;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryAt_Public_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEntry_Public_Boolean_TKey_byref_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_TKey_TValue_0;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_RemoveValue_Public_Void_TValue_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Int32_TValue_0;

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0;

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfValue_Public_Int32_TValue_0;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeMethodInfoPtr_TrimExcess_Public_Void_0;

		// Token: 0x04002685 RID: 9861
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04002694 RID: 9876
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04002695 RID: 9877
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04002696 RID: 9878
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04002697 RID: 9879
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04002698 RID: 9880
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04002699 RID: 9881
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x0400269A RID: 9882
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400269B RID: 9883
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400269D RID: 9885
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_TValue__get_Item_Private_Virtual_Final_New_get_TValue_Int32_0;

		// Token: 0x0400269E RID: 9886
		private static readonly IntPtr NativeMethodInfoPtr_iSLJLAJXjAjQexXBVDvDoMruXpu_Private_Virtual_Final_New_Int32_TValue_0;

		// Token: 0x0400269F RID: 9887
		private static readonly IntPtr NativeMethodInfoPtr_DOlHqXWpZBbbKzPEfAbgXfxxcZgA_Private_Virtual_Final_New_Boolean_TValue_0;

		// Token: 0x040026A0 RID: 9888
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040026A1 RID: 9889
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IReadOnlyList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeMethodInfoPtr_AaYUMnnIfuSbjBaDkBRuxRBhFflb_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeMethodInfoPtr_TqkYFxPbwzGdECbPeYFwtzomsMe_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x020003D3 RID: 979
		public sealed class pQKdViGBNMlsHqgjGFQxPWNfyPX : ValueType
		{
			// Token: 0x06004FD5 RID: 20437 RVA: 0x0016B0FC File Offset: 0x001692FC
			// Note: this type is marked as 'beforefieldinit'.
			static pQKdViGBNMlsHqgjGFQxPWNfyPX()
			{
				Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "pQKdViGBNMlsHqgjGFQxPWNfyPX"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr);
				IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr, "sZfOAbuViDxxWveYyIghfELthPGh");
				IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr, "wvNaDPcNUyHJKWogdKCZCqbNISpy");
				IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr, 100675051);
				IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeMethodInfoPtr_swXcGeLFAFjygAQhEfYpDlZQrPgA_Public_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr, 100675052);
			}

			// Token: 0x06004FD6 RID: 20438 RVA: 0x0016B1C4 File Offset: 0x001693C4
			[CallerCount(0)]
			public unsafe pQKdViGBNMlsHqgjGFQxPWNfyPX(TKey key, TValue value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr))
			{
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FD7 RID: 20439 RVA: 0x0016B2BC File Offset: 0x001694BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330819, XrefRangeEnd = 330820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<TKey, TValue> swXcGeLFAFjygAQhEfYpDlZQrPgA()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeMethodInfoPtr_swXcGeLFAFjygAQhEfYpDlZQrPgA_Public_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<TKey, TValue>(intPtr);
			}

			// Token: 0x06004FD8 RID: 20440 RVA: 0x0001D0DA File Offset: 0x0001B2DA
			public pQKdViGBNMlsHqgjGFQxPWNfyPX(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004FD9 RID: 20441 RVA: 0x0001D0E3 File Offset: 0x0001B2E3
			public pQKdViGBNMlsHqgjGFQxPWNfyPX()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX>.NativeClassPtr))
			{
			}

			// Token: 0x170018C2 RID: 6338
			// (get) Token: 0x06004FDA RID: 20442 RVA: 0x0016B2F8 File Offset: 0x001694F8
			// (set) Token: 0x06004FDB RID: 20443 RVA: 0x0016B320 File Offset: 0x00169520
			public unsafe TKey sZfOAbuViDxxWveYyIghfELthPGh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh);
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

			// Token: 0x170018C3 RID: 6339
			// (get) Token: 0x06004FDC RID: 20444 RVA: 0x0016B3C8 File Offset: 0x001695C8
			// (set) Token: 0x06004FDD RID: 20445 RVA: 0x0016B3F0 File Offset: 0x001695F0
			public unsafe TValue wvNaDPcNUyHJKWogdKCZCqbNISpy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.pQKdViGBNMlsHqgjGFQxPWNfyPX.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy);
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

			// Token: 0x0400428F RID: 17039
			private static readonly IntPtr NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh;

			// Token: 0x04004290 RID: 17040
			private static readonly IntPtr NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy;

			// Token: 0x04004291 RID: 17041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0;

			// Token: 0x04004292 RID: 17042
			private static readonly IntPtr NativeMethodInfoPtr_swXcGeLFAFjygAQhEfYpDlZQrPgA_Public_KeyValuePair_2_TKey_TValue_0;
		}

		// Token: 0x020003D4 RID: 980
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06004FDE RID: 20446 RVA: 0x0016B498 File Offset: 0x00169698
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "DictEntry");
				IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "KeyValuePair");
				IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
				IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "YZXVMrPYKUmYEMLUdSpMBLWplnu");
				IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "DvCDMNCBudLHkpnvfpAAHNGzbZYB");
				IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "EDWjCkozGqmyQyquicPQVDMTCVq");
				IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "tYCVbjQNhtzugVkpXQTBPOUTWUE");
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675053);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675054);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675055);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675056);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675057);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675058);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675059);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675060);
				IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100675061);
			}

			// Token: 0x06004FDF RID: 20447 RVA: 0x0016B650 File Offset: 0x00169850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330820, XrefRangeEnd = 330822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(IndexedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getEnumeratorRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FE0 RID: 20448 RVA: 0x0016B6B0 File Offset: 0x001698B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330822, XrefRangeEnd = 330824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018CB RID: 6347
			// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x0016B6F4 File Offset: 0x001698F4
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06004FE2 RID: 20450 RVA: 0x0016B730 File Offset: 0x00169930
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018CC RID: 6348
			// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x0016B768 File Offset: 0x00169968
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330824, XrefRangeEnd = 330831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE4 RID: 20452 RVA: 0x0016B7AC File Offset: 0x001699AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330831, XrefRangeEnd = 330833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018CD RID: 6349
			// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x0016B7E4 File Offset: 0x001699E4
			public unsafe DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330833, XrefRangeEnd = 330839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170018CE RID: 6350
			// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x0016B820 File Offset: 0x00169A20
			public unsafe Object System.Collections.IDictionaryEnumerator.Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330839, XrefRangeEnd = 330843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170018CF RID: 6351
			// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x0016B864 File Offset: 0x00169A64
			public unsafe Object System.Collections.IDictionaryEnumerator.Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330843, XrefRangeEnd = 330844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE8 RID: 20456 RVA: 0x0001D0F5 File Offset: 0x0001B2F5
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004FE9 RID: 20457 RVA: 0x0001D0FE File Offset: 0x0001B2FE
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170018C4 RID: 6340
			// (get) Token: 0x06004FEA RID: 20458 RVA: 0x0016B8A8 File Offset: 0x00169AA8
			// (set) Token: 0x06004FEB RID: 20459 RVA: 0x0001D110 File Offset: 0x0001B310
			public unsafe static int DictEntry
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry, (void*)(&value));
				}
			}

			// Token: 0x170018C5 RID: 6341
			// (get) Token: 0x06004FEC RID: 20460 RVA: 0x0016B8C4 File Offset: 0x00169AC4
			// (set) Token: 0x06004FED RID: 20461 RVA: 0x0001D11E File Offset: 0x0001B31E
			public unsafe static int KeyValuePair
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair, (void*)(&value));
				}
			}

			// Token: 0x170018C6 RID: 6342
			// (get) Token: 0x06004FEE RID: 20462 RVA: 0x0016B8E0 File Offset: 0x00169AE0
			// (set) Token: 0x06004FEF RID: 20463 RVA: 0x0001D12C File Offset: 0x0001B32C
			public unsafe IndexedDictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018C7 RID: 6343
			// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x0016B910 File Offset: 0x00169B10
			// (set) Token: 0x06004FF1 RID: 20465 RVA: 0x0001D14B File Offset: 0x0001B34B
			public unsafe int YZXVMrPYKUmYEMLUdSpMBLWplnu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu)) = value;
				}
			}

			// Token: 0x170018C8 RID: 6344
			// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x0016B938 File Offset: 0x00169B38
			// (set) Token: 0x06004FF3 RID: 20467 RVA: 0x0001D166 File Offset: 0x0001B366
			public unsafe int DvCDMNCBudLHkpnvfpAAHNGzbZYB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB)) = value;
				}
			}

			// Token: 0x170018C9 RID: 6345
			// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x0016B960 File Offset: 0x00169B60
			// (set) Token: 0x06004FF5 RID: 20469 RVA: 0x0001D181 File Offset: 0x0001B381
			public KeyValuePair<TKey, TValue> EDWjCkozGqmyQyquicPQVDMTCVq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018CA RID: 6346
			// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x0016B990 File Offset: 0x00169B90
			// (set) Token: 0x06004FF7 RID: 20471 RVA: 0x0001D1AF File Offset: 0x0001B3AF
			public unsafe int tYCVbjQNhtzugVkpXQTBPOUTWUE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE)) = value;
				}
			}

			// Token: 0x04004293 RID: 17043
			private static readonly IntPtr NativeFieldInfoPtr_DictEntry;

			// Token: 0x04004294 RID: 17044
			private static readonly IntPtr NativeFieldInfoPtr_KeyValuePair;

			// Token: 0x04004295 RID: 17045
			private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

			// Token: 0x04004296 RID: 17046
			private static readonly IntPtr NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu;

			// Token: 0x04004297 RID: 17047
			private static readonly IntPtr NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB;

			// Token: 0x04004298 RID: 17048
			private static readonly IntPtr NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq;

			// Token: 0x04004299 RID: 17049
			private static readonly IntPtr NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE;

			// Token: 0x0400429A RID: 17050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_Int32_0;

			// Token: 0x0400429B RID: 17051
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400429C RID: 17052
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x0400429D RID: 17053
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400429E RID: 17054
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400429F RID: 17055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042A0 RID: 17056
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x040042A1 RID: 17057
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040042A2 RID: 17058
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003D5 RID: 981
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x06004FF8 RID: 20472 RVA: 0x0016B9B8 File Offset: 0x00169BB8
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_IndexedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675062);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675063);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675064);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675065);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675066);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675067);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675068);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675069);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675070);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675071);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675072);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675073);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675074);
				IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100675075);
			}

			// Token: 0x06004FF9 RID: 20473 RVA: 0x0016BB5C File Offset: 0x00169D5C
			[CallerCount(0)]
			public unsafe KeyCollection(IndexedDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_IndexedDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FFA RID: 20474 RVA: 0x0016BBA8 File Offset: 0x00169DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330853, XrefRangeEnd = 330854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator(intPtr);
			}

			// Token: 0x06004FFB RID: 20475 RVA: 0x0016BBE0 File Offset: 0x00169DE0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018D1 RID: 6353
			// (get) Token: 0x06004FFC RID: 20476 RVA: 0x0016BC30 File Offset: 0x00169E30
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018D2 RID: 6354
			// (get) Token: 0x06004FFD RID: 20477 RVA: 0x0016BC6C File Offset: 0x00169E6C
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FFE RID: 20478 RVA: 0x0016BCA8 File Offset: 0x00169EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330854, XrefRangeEnd = 330859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FFF RID: 20479 RVA: 0x0016BD38 File Offset: 0x00169F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330859, XrefRangeEnd = 330864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005000 RID: 20480 RVA: 0x0016BD6C File Offset: 0x00169F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005001 RID: 20481 RVA: 0x0016BE04 File Offset: 0x0016A004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330864, XrefRangeEnd = 330869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005002 RID: 20482 RVA: 0x0016BE9C File Offset: 0x0016A09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330869, XrefRangeEnd = 330872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> System_Collections_Generic_IEnumerable_TKey__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x06005003 RID: 20483 RVA: 0x0016BEDC File Offset: 0x0016A0DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005004 RID: 20484 RVA: 0x0016BF1C File Offset: 0x0016A11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330872, XrefRangeEnd = 330885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018D3 RID: 6355
			// (get) Token: 0x06005005 RID: 20485 RVA: 0x0016BF6C File Offset: 0x0016A16C
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018D4 RID: 6356
			// (get) Token: 0x06005006 RID: 20486 RVA: 0x0016BFA8 File Offset: 0x0016A1A8
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330885, XrefRangeEnd = 330889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005007 RID: 20487 RVA: 0x0001D1CA File Offset: 0x0001B3CA
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018D0 RID: 6352
			// (get) Token: 0x06005008 RID: 20488 RVA: 0x0016BFE8 File Offset: 0x0016A1E8
			// (set) Token: 0x06005009 RID: 20489 RVA: 0x0001D1D3 File Offset: 0x0001B3D3
			public unsafe IndexedDictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042A3 RID: 17059
			private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

			// Token: 0x040042A4 RID: 17060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IndexedDictionary_2_TKey_TValue_0;

			// Token: 0x040042A5 RID: 17061
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x040042A6 RID: 17062
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x040042A7 RID: 17063
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040042A8 RID: 17064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040042A9 RID: 17065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x040042AA RID: 17066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042AB RID: 17067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x040042AC RID: 17068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x040042AD RID: 17069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x040042AE RID: 17070
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040042AF RID: 17071
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040042B0 RID: 17072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040042B1 RID: 17073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020005A8 RID: 1448
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060060C8 RID: 24776 RVA: 0x001AE934 File Offset: 0x001ACB34
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr);
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "DvCDMNCBudLHkpnvfpAAHNGzbZYB");
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "YZXVMrPYKUmYEMLUdSpMBLWplnu");
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "IznGGaUbVZqwskfVHXBzPOSTqNf");
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100675076);
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100675077);
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100675078);
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100675079);
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100675080);
					IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100675081);
				}

				// Token: 0x060060C9 RID: 24777 RVA: 0x001AEA74 File Offset: 0x001ACC74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330844, XrefRangeEnd = 330846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(IndexedDictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060060CA RID: 24778 RVA: 0x001AEAC4 File Offset: 0x001ACCC4
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060CB RID: 24779 RVA: 0x001AEAFC File Offset: 0x001ACCFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330846, XrefRangeEnd = 330848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001D50 RID: 7504
				// (get) Token: 0x060060CC RID: 24780 RVA: 0x001AEB40 File Offset: 0x001ACD40
				public unsafe TKey Current
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
					}
				}

				// Token: 0x17001D51 RID: 7505
				// (get) Token: 0x060060CD RID: 24781 RVA: 0x001AEB80 File Offset: 0x001ACD80
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330848, XrefRangeEnd = 330851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060060CE RID: 24782 RVA: 0x001AEBC4 File Offset: 0x001ACDC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330851, XrefRangeEnd = 330853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060CF RID: 24783 RVA: 0x00023B2C File Offset: 0x00021D2C
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060060D0 RID: 24784 RVA: 0x00023B35 File Offset: 0x00021D35
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17001D4C RID: 7500
				// (get) Token: 0x060060D1 RID: 24785 RVA: 0x001AEBFC File Offset: 0x001ACDFC
				// (set) Token: 0x060060D2 RID: 24786 RVA: 0x00023B47 File Offset: 0x00021D47
				public unsafe IndexedDictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedDictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001D4D RID: 7501
				// (get) Token: 0x060060D3 RID: 24787 RVA: 0x001AEC2C File Offset: 0x001ACE2C
				// (set) Token: 0x060060D4 RID: 24788 RVA: 0x00023B66 File Offset: 0x00021D66
				public unsafe int DvCDMNCBudLHkpnvfpAAHNGzbZYB
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB)) = value;
					}
				}

				// Token: 0x17001D4E RID: 7502
				// (get) Token: 0x060060D5 RID: 24789 RVA: 0x001AEC54 File Offset: 0x001ACE54
				// (set) Token: 0x060060D6 RID: 24790 RVA: 0x00023B81 File Offset: 0x00021D81
				public unsafe int YZXVMrPYKUmYEMLUdSpMBLWplnu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu)) = value;
					}
				}

				// Token: 0x17001D4F RID: 7503
				// (get) Token: 0x060060D7 RID: 24791 RVA: 0x001AEC7C File Offset: 0x001ACE7C
				// (set) Token: 0x060060D8 RID: 24792 RVA: 0x001AECA4 File Offset: 0x001ACEA4
				public unsafe TKey IznGGaUbVZqwskfVHXBzPOSTqNf
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf);
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

				// Token: 0x04004F5F RID: 20319
				private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

				// Token: 0x04004F60 RID: 20320
				private static readonly IntPtr NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB;

				// Token: 0x04004F61 RID: 20321
				private static readonly IntPtr NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu;

				// Token: 0x04004F62 RID: 20322
				private static readonly IntPtr NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf;

				// Token: 0x04004F63 RID: 20323
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_0;

				// Token: 0x04004F64 RID: 20324
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04004F65 RID: 20325
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04004F66 RID: 20326
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0;

				// Token: 0x04004F67 RID: 20327
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004F68 RID: 20328
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x020003D6 RID: 982
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x0600500A RID: 20490 RVA: 0x0016C018 File Offset: 0x0016A218
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_IndexedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675082);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675083);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675084);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675085);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675086);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675087);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675088);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675089);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675090);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675091);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675092);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675093);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675094);
				IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100675095);
			}

			// Token: 0x0600500B RID: 20491 RVA: 0x0016C1BC File Offset: 0x0016A3BC
			[CallerCount(0)]
			public unsafe ValueCollection(IndexedDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_IndexedDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600500C RID: 20492 RVA: 0x0016C208 File Offset: 0x0016A408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330895, XrefRangeEnd = 330896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator(intPtr);
			}

			// Token: 0x0600500D RID: 20493 RVA: 0x0016C240 File Offset: 0x0016A440
			[CallerCount(0)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018D6 RID: 6358
			// (get) Token: 0x0600500E RID: 20494 RVA: 0x0016C290 File Offset: 0x0016A490
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018D7 RID: 6359
			// (get) Token: 0x0600500F RID: 20495 RVA: 0x0016C2CC File Offset: 0x0016A4CC
			public unsafe bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005010 RID: 20496 RVA: 0x0016C308 File Offset: 0x0016A508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330896, XrefRangeEnd = 330901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005011 RID: 20497 RVA: 0x0016C398 File Offset: 0x0016A598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330901, XrefRangeEnd = 330906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005012 RID: 20498 RVA: 0x0016C430 File Offset: 0x0016A630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330906, XrefRangeEnd = 330911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005013 RID: 20499 RVA: 0x0016C464 File Offset: 0x0016A664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005014 RID: 20500 RVA: 0x0016C4FC File Offset: 0x0016A6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330911, XrefRangeEnd = 330914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> System_Collections_Generic_IEnumerable_TValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x06005015 RID: 20501 RVA: 0x0016C53C File Offset: 0x0016A73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005016 RID: 20502 RVA: 0x0016C57C File Offset: 0x0016A77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330914, XrefRangeEnd = 330925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018D8 RID: 6360
			// (get) Token: 0x06005017 RID: 20503 RVA: 0x0016C5CC File Offset: 0x0016A7CC
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018D9 RID: 6361
			// (get) Token: 0x06005018 RID: 20504 RVA: 0x0016C608 File Offset: 0x0016A808
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330925, XrefRangeEnd = 330929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005019 RID: 20505 RVA: 0x0001D1F2 File Offset: 0x0001B3F2
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018D5 RID: 6357
			// (get) Token: 0x0600501A RID: 20506 RVA: 0x0016C648 File Offset: 0x0016A848
			// (set) Token: 0x0600501B RID: 20507 RVA: 0x0001D1FB File Offset: 0x0001B3FB
			public unsafe IndexedDictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042B2 RID: 17074
			private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

			// Token: 0x040042B3 RID: 17075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IndexedDictionary_2_TKey_TValue_0;

			// Token: 0x040042B4 RID: 17076
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x040042B5 RID: 17077
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0;

			// Token: 0x040042B6 RID: 17078
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040042B7 RID: 17079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040042B8 RID: 17080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0;

			// Token: 0x040042B9 RID: 17081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x040042BA RID: 17082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042BB RID: 17083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x040042BC RID: 17084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x040042BD RID: 17085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040042BE RID: 17086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040042BF RID: 17087
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040042C0 RID: 17088
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020005A9 RID: 1449
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060060D9 RID: 24793 RVA: 0x001AED4C File Offset: 0x001ACF4C
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr);
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "DvCDMNCBudLHkpnvfpAAHNGzbZYB");
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "YZXVMrPYKUmYEMLUdSpMBLWplnu");
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "TCvQSFfpSHkNMlRsCRtrbHRRPVo");
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100675096);
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100675097);
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100675098);
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100675099);
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100675100);
					IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100675101);
				}

				// Token: 0x060060DA RID: 24794 RVA: 0x001AEE8C File Offset: 0x001AD08C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330889, XrefRangeEnd = 330891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(IndexedDictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060060DB RID: 24795 RVA: 0x001AEEDC File Offset: 0x001AD0DC
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060DC RID: 24796 RVA: 0x001AEF14 File Offset: 0x001AD114
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330891, XrefRangeEnd = 330893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001D56 RID: 7510
				// (get) Token: 0x060060DD RID: 24797 RVA: 0x001AEF58 File Offset: 0x001AD158
				public unsafe TValue Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
					}
				}

				// Token: 0x17001D57 RID: 7511
				// (get) Token: 0x060060DE RID: 24798 RVA: 0x001AEF98 File Offset: 0x001AD198
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060060DF RID: 24799 RVA: 0x001AEFDC File Offset: 0x001AD1DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330893, XrefRangeEnd = 330895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060E0 RID: 24800 RVA: 0x00023B9C File Offset: 0x00021D9C
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060060E1 RID: 24801 RVA: 0x00023BA5 File Offset: 0x00021DA5
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17001D52 RID: 7506
				// (get) Token: 0x060060E2 RID: 24802 RVA: 0x001AF014 File Offset: 0x001AD214
				// (set) Token: 0x060060E3 RID: 24803 RVA: 0x00023BB7 File Offset: 0x00021DB7
				public unsafe IndexedDictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedDictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001D53 RID: 7507
				// (get) Token: 0x060060E4 RID: 24804 RVA: 0x001AF044 File Offset: 0x001AD244
				// (set) Token: 0x060060E5 RID: 24805 RVA: 0x00023BD6 File Offset: 0x00021DD6
				public unsafe int DvCDMNCBudLHkpnvfpAAHNGzbZYB
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB)) = value;
					}
				}

				// Token: 0x17001D54 RID: 7508
				// (get) Token: 0x060060E6 RID: 24806 RVA: 0x001AF06C File Offset: 0x001AD26C
				// (set) Token: 0x060060E7 RID: 24807 RVA: 0x00023BF1 File Offset: 0x00021DF1
				public unsafe int YZXVMrPYKUmYEMLUdSpMBLWplnu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu)) = value;
					}
				}

				// Token: 0x17001D55 RID: 7509
				// (get) Token: 0x060060E8 RID: 24808 RVA: 0x001AF094 File Offset: 0x001AD294
				// (set) Token: 0x060060E9 RID: 24809 RVA: 0x001AF0BC File Offset: 0x001AD2BC
				public unsafe TValue TCvQSFfpSHkNMlRsCRtrbHRRPVo
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo);
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

				// Token: 0x04004F69 RID: 20329
				private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

				// Token: 0x04004F6A RID: 20330
				private static readonly IntPtr NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB;

				// Token: 0x04004F6B RID: 20331
				private static readonly IntPtr NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu;

				// Token: 0x04004F6C RID: 20332
				private static readonly IntPtr NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo;

				// Token: 0x04004F6D RID: 20333
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IndexedDictionary_2_TKey_TValue_0;

				// Token: 0x04004F6E RID: 20334
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04004F6F RID: 20335
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04004F70 RID: 20336
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0;

				// Token: 0x04004F71 RID: 20337
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004F72 RID: 20338
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}
	}
}
