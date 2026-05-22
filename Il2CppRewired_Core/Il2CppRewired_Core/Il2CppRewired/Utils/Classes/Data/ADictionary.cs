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
	// Token: 0x020001B7 RID: 439
	public class ADictionary<TKey, TValue> : Object
	{
		// Token: 0x06002CD7 RID: 11479 RVA: 0x000DDFF8 File Offset: 0x000DC1F8
		// Note: this type is marked as 'beforefieldinit'.
		static ADictionary()
		{
			Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "ADictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr);
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_XiKikjWXxklaMlATFaHXJdFPhAC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "XiKikjWXxklaMlATFaHXJdFPhAC");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_FoBDMcstceuEOEGEzTSFlXgfreX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "FoBDMcstceuEOEGEzTSFlXgfreX");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_PJWstjOoKHGSnnhfmjIAKCZAtmmk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "PJWstjOoKHGSnnhfmjIAKCZAtmmk");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_HjDuuyZguTUshSxAcZKEyMvfIFz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "HjDuuyZguTUshSxAcZKEyMvfIFz");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_BVNdMpJjcbNFmhsZHfMOfausfASr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "BVNdMpJjcbNFmhsZHfMOfausfASr");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "_entries");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "_count");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "HjjnxSNoowqRBXlgFxQnyOTSKdg");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_NfShnqBdbeGMTSPwAvyurbvaiUA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "NfShnqBdbeGMTSPwAvyurbvaiUA");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_qNaQysaUHwugrnJRvaprHpAqSRQf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "qNaQysaUHwugrnJRvaprHpAqSRQf");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_uRfpYfDYIXQvTmLzlsRueNPvpUb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "uRfpYfDYIXQvTmLzlsRueNPvpUb");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "rKWSwKmIhNDTzhLhIevaHwnfvwbJ");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "TaNQqqGIyLgPUHVmRCwddtyGHCBD");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "yMWHcoZgVBayuPKzlxlxgqwAhpR");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "HBIIXimIAqIVHGkNXwXTiuSAgUDD");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_WIEpnJHUYtGWWDqkMQqkOyrSkha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "WIEpnJHUYtGWWDqkMQqkOyrSkha");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "hVRYlvkeMegeilrvqzjMTEgLgtIf");
			ADictionary<TKey, TValue>.NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "BRnOGwiQsoyBdDLDAjvpbphqCGu");
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674857);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674858);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674859);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674860);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_KeyComparer_Public_get_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674861);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_set_KeyComparer_Public_set_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674862);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_ValueComparer_Public_get_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674863);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_set_ValueComparer_Public_set_Void_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674864);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674865);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674866);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674867);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674868);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674869);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674870);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674871);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674872);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674873);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674874);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674875);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674876);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674877);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674878);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674879);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674880);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674881);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674882);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetValueSafe_Public_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674883);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_IndexOfFirst_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674884);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_IndexOfLast_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674885);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674886);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfValue_Public_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674887);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_IsValidAt_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674888);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeyAt_Public_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674889);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetValueAt_Public_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674890);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetEntryAt_Public_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674891);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetKeyAt_Public_Boolean_Int32_byref_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674892);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueAt_Public_Boolean_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674893);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetEntryAt_Public_Boolean_Int32_byref_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674894);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextIndex_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674895);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674896);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextKey_Public_Boolean_byref_Int32_byref_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674897);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextValue_Public_Boolean_byref_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674898);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextEntry_Public_Boolean_byref_Int32_byref_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674899);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousIndex_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674900);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674901);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousKey_Public_Boolean_byref_Int32_byref_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674902);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousValue_Public_Boolean_byref_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674903);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousEntry_Public_Boolean_byref_Int32_byref_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674904);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveAt_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674905);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_MVALiRCiKZhyDpRnenUOXaSMxky_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674906);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674907);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_BDGEvnlkxFdzRvpCaLETcmnAdFxE_Private_Void_TKey_TValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674908);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_hGJbZFhhwTpggGktXrktItfiveIl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674909);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_hGJbZFhhwTpggGktXrktItfiveIl_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674910);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674911);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674912);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674913);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674914);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674915);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674916);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674917);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674918);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674919);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674920);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674921);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674922);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674923);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674924);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674925);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674926);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674927);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674928);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674929);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674930);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674931);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674932);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_wlxDUHaFeiVdKTKYLBdwRAFqttV_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674933);
			ADictionary<TKey, TValue>.NativeMethodInfoPtr_uDVXgxGkGmkmbHkpANAwuqqoiwP_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, 100674934);
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000DE7F8 File Offset: 0x000DC9F8
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x000DE834 File Offset: 0x000DCA34
		public unsafe int TotalCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x000DE870 File Offset: 0x000DCA70
		public unsafe ADictionary<TKey, TValue>.KeyCollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330635, XrefRangeEnd = 330638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>.KeyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000DE8B0 File Offset: 0x000DCAB0
		public unsafe ADictionary<TKey, TValue>.ValueCollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330638, XrefRangeEnd = 330641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>.ValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x000DE8F0 File Offset: 0x000DCAF0
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x000DE930 File Offset: 0x000DCB30
		public unsafe IEqualityComparer<TKey> KeyComparer
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_KeyComparer_Public_get_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_set_KeyComparer_Public_set_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000DE974 File Offset: 0x000DCB74
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x000DE9B4 File Offset: 0x000DCBB4
		public unsafe IEqualityComparer<TValue> ValueComparer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_ValueComparer_Public_get_IEqualityComparer_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_set_ValueComparer_Public_set_Void_IEqualityComparer_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E5B RID: 3675
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 330641, RefRangeEnd = 330660, XrefRangeStart = 330641, XrefRangeEnd = 330641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000DEB7C File Offset: 0x000DCD7C
		[CallerCount(0)]
		public unsafe ADictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000DEBB8 File Offset: 0x000DCDB8
		[CallerCount(0)]
		public unsafe ADictionary(IEqualityComparer<TKey> keyComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000DEC04 File Offset: 0x000DCE04
		[CallerCount(0)]
		public unsafe ADictionary(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000DEC64 File Offset: 0x000DCE64
		[CallerCount(0)]
		public unsafe ADictionary(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000DECAC File Offset: 0x000DCEAC
		[CallerCount(0)]
		public unsafe ADictionary(int capacity, IEqualityComparer<TKey> keyComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x000DED08 File Offset: 0x000DCF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330660, XrefRangeEnd = 330663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ADictionary(int capacity, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000DED74 File Offset: 0x000DCF74
		[CallerCount(0)]
		public unsafe ADictionary(IDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000DEDC0 File Offset: 0x000DCFC0
		[CallerCount(0)]
		public unsafe ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000DEE20 File Offset: 0x000DD020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330663, XrefRangeEnd = 330679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x000DEE90 File Offset: 0x000DD090
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x000DEF7C File Offset: 0x000DD17C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330681, RefRangeEnd = 330683, XrefRangeStart = 330679, XrefRangeEnd = 330681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000DEFB0 File Offset: 0x000DD1B0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000DF048 File Offset: 0x000DD248
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x000DF0E0 File Offset: 0x000DD2E0
		[CallerCount(0)]
		public unsafe ADictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ADictionary<TKey, TValue>.Enumerator(intPtr);
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000DF118 File Offset: 0x000DD318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330683, XrefRangeEnd = 330694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x000DF1B0 File Offset: 0x000DD3B0
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x000DF298 File Offset: 0x000DD498
		[CallerCount(0)]
		public unsafe TValue GetValueSafe(TKey key)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetValueSafe_Public_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000DF330 File Offset: 0x000DD530
		public unsafe int IndexOfFirst
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_IndexOfFirst_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000DF36C File Offset: 0x000DD56C
		public unsafe int IndexOfLast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_get_IndexOfLast_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000DF3A8 File Offset: 0x000DD5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330694, XrefRangeEnd = 330705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x000DF440 File Offset: 0x000DD640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330705, XrefRangeEnd = 330712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_IndexOfValue_Public_Int32_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000DF4D8 File Offset: 0x000DD6D8
		[CallerCount(0)]
		public unsafe bool IsValidAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_IsValidAt_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x000DF524 File Offset: 0x000DD724
		[CallerCount(0)]
		public unsafe TKey GetKeyAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeyAt_Public_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x000DF56C File Offset: 0x000DD76C
		[CallerCount(0)]
		public unsafe TValue GetValueAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetValueAt_Public_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000DF5B4 File Offset: 0x000DD7B4
		[CallerCount(0)]
		public unsafe KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetEntryAt_Public_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<TKey, TValue>(intPtr);
			}
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000DF5F8 File Offset: 0x000DD7F8
		[CallerCount(0)]
		public unsafe bool TryGetKeyAt(int index, out TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TKey).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref key;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetKeyAt_Public_Boolean_Int32_byref_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TKey).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				key = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TKey>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x000DF690 File Offset: 0x000DD890
		[CallerCount(0)]
		public unsafe bool TryGetValueAt(int index, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
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
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueAt_Public_Boolean_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x000DF728 File Offset: 0x000DD928
		[CallerCount(0)]
		public unsafe bool TryGetEntryAt(int index, out KeyValuePair<TKey, TValue> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetEntryAt_Public_Boolean_Int32_byref_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new KeyValuePair<TKey, TValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x000DF794 File Offset: 0x000DD994
		[CallerCount(0)]
		public unsafe bool GetNextIndex(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextIndex_Public_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000DF7E0 File Offset: 0x000DD9E0
		[CallerCount(0)]
		public unsafe int GetNextIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000DF82C File Offset: 0x000DDA2C
		[CallerCount(0)]
		public unsafe bool GetNextKey(ref int index, out TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TKey).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref key;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextKey_Public_Boolean_byref_Int32_byref_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TKey).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				key = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TKey>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000DF8C4 File Offset: 0x000DDAC4
		[CallerCount(0)]
		public unsafe bool GetNextValue(ref int index, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
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
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextValue_Public_Boolean_byref_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000DF95C File Offset: 0x000DDB5C
		[CallerCount(0)]
		public unsafe bool GetNextEntry(ref int index, out KeyValuePair<TKey, TValue> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetNextEntry_Public_Boolean_byref_Int32_byref_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new KeyValuePair<TKey, TValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000DF9C8 File Offset: 0x000DDBC8
		[CallerCount(0)]
		public unsafe bool GetPreviousIndex(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousIndex_Public_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000DFA14 File Offset: 0x000DDC14
		[CallerCount(0)]
		public unsafe int GetPreviousIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x000DFA60 File Offset: 0x000DDC60
		[CallerCount(0)]
		public unsafe bool GetPreviousKey(ref int index, out TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TKey).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref key;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousKey_Public_Boolean_byref_Int32_byref_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TKey).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				key = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TKey>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x000DFAF8 File Offset: 0x000DDCF8
		[CallerCount(0)]
		public unsafe bool GetPreviousValue(ref int index, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
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
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousValue_Public_Boolean_byref_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000DFB90 File Offset: 0x000DDD90
		[CallerCount(0)]
		public unsafe bool GetPreviousEntry(ref int index, out KeyValuePair<TKey, TValue> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_GetPreviousEntry_Public_Boolean_byref_Int32_byref_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new KeyValuePair<TKey, TValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000DFBFC File Offset: 0x000DDDFC
		[CallerCount(0)]
		public unsafe bool RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_RemoveAt_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000DFC48 File Offset: 0x000DDE48
		[CallerCount(0)]
		public unsafe void MVALiRCiKZhyDpRnenUOXaSMxky(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_MVALiRCiKZhyDpRnenUOXaSMxky_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000DFC98 File Offset: 0x000DDE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330712, XrefRangeEnd = 330722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dwHOFmApnpWkXreTmwZYsRXRrow(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x000DFCD8 File Offset: 0x000DDED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330722, XrefRangeEnd = 330734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BDGEvnlkxFdzRvpCaLETcmnAdFxE(TKey A_1, TValue A_2, bool A_3)
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
					TKey tkey = A_1;
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
					ptr4 = ref A_1;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TValue ptr7;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = A_2;
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
				ptr7 = ref A_2;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_BDGEvnlkxFdzRvpCaLETcmnAdFxE_Private_Void_TKey_TValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000DFDD0 File Offset: 0x000DDFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330734, XrefRangeEnd = 330738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void hGJbZFhhwTpggGktXrktItfiveIl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_hGJbZFhhwTpggGktXrktItfiveIl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000DFE04 File Offset: 0x000DE004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330738, XrefRangeEnd = 330747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void hGJbZFhhwTpggGktXrktItfiveIl(int A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_hGJbZFhhwTpggGktXrktItfiveIl_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000DFE50 File Offset: 0x000DE050
		public unsafe virtual ICollection<TKey> prop_ICollection_1_TKey_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000DFE90 File Offset: 0x000DE090
		public unsafe virtual ICollection<TValue> prop_ICollection_1_TValue_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000DFED0 File Offset: 0x000DE0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330747, XrefRangeEnd = 330749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000DFF10 File Offset: 0x000DE110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330749, XrefRangeEnd = 330750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x000DFF58 File Offset: 0x000DE158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330750, XrefRangeEnd = 330752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x000DFFAC File Offset: 0x000DE1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330752, XrefRangeEnd = 330754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x000E0000 File Offset: 0x000DE200
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000E003C File Offset: 0x000DE23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330754, XrefRangeEnd = 330755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000E008C File Offset: 0x000DE28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330755, XrefRangeEnd = 330779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000E00DC File Offset: 0x000DE2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x000E011C File Offset: 0x000DE31C
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000E0158 File Offset: 0x000DE358
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x000E0198 File Offset: 0x000DE398
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x000E01D4 File Offset: 0x000DE3D4
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x000E0210 File Offset: 0x000DE410
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330779, XrefRangeEnd = 330780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000E0250 File Offset: 0x000DE450
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330780, XrefRangeEnd = 330781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x000E0290 File Offset: 0x000DE490
		// (set) Token: 0x06002D1F RID: 11551 RVA: 0x000E02E0 File Offset: 0x000DE4E0
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330781, XrefRangeEnd = 330789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330789, XrefRangeEnd = 330797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000E0334 File Offset: 0x000DE534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330797, XrefRangeEnd = 330805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000E0388 File Offset: 0x000DE588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330805, XrefRangeEnd = 330809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x000E03D8 File Offset: 0x000DE5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330809, XrefRangeEnd = 330811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000E0418 File Offset: 0x000DE618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330811, XrefRangeEnd = 330816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000E045C File Offset: 0x000DE65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330816, XrefRangeEnd = 330819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool wlxDUHaFeiVdKTKYLBdwRAFqttV(Object A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.NativeMethodInfoPtr_wlxDUHaFeiVdKTKYLBdwRAFqttV_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x000E04A0 File Offset: 0x000DE6A0
		[CallerCount(0)]
		public static void uDVXgxGkGmkmbHkpANAwuqqoiwP<T>(Object A_0, string A_1)
		{
			/*
An exception occurred when decompiling this method (06002D25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppRewired.Utils.Classes.Data.ADictionary`2::uDVXgxGkGmkmbHkpANAwuqqoiwP<T>(Il2CppSystem.Object,System.String)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 149
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1660
*/;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00010BC5 File Offset: 0x0000EDC5
		public ADictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000E04E8 File Offset: 0x000DE6E8
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x00010BCE File Offset: 0x0000EDCE
		public unsafe static string XiKikjWXxklaMlATFaHXJdFPhAC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_XiKikjWXxklaMlATFaHXJdFPhAC, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_XiKikjWXxklaMlATFaHXJdFPhAC, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000E0508 File Offset: 0x000DE708
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		public unsafe static string FoBDMcstceuEOEGEzTSFlXgfreX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_FoBDMcstceuEOEGEzTSFlXgfreX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_FoBDMcstceuEOEGEzTSFlXgfreX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000E0528 File Offset: 0x000DE728
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x00010BF2 File Offset: 0x0000EDF2
		public unsafe static string PJWstjOoKHGSnnhfmjIAKCZAtmmk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_PJWstjOoKHGSnnhfmjIAKCZAtmmk, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_PJWstjOoKHGSnnhfmjIAKCZAtmmk, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x000E0548 File Offset: 0x000DE748
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x00010C04 File Offset: 0x0000EE04
		public unsafe static string HjDuuyZguTUshSxAcZKEyMvfIFz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_HjDuuyZguTUshSxAcZKEyMvfIFz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_HjDuuyZguTUshSxAcZKEyMvfIFz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000E0568 File Offset: 0x000DE768
		// (set) Token: 0x06002D30 RID: 11568 RVA: 0x00010C16 File Offset: 0x0000EE16
		public unsafe Il2CppStructArray<int> BVNdMpJjcbNFmhsZHfMOfausfASr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_BVNdMpJjcbNFmhsZHfMOfausfASr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_BVNdMpJjcbNFmhsZHfMOfausfASr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x000E0598 File Offset: 0x000DE798
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x00010C35 File Offset: 0x0000EE35
		public unsafe Il2CppReferenceArray<ADictionary<TKey, TValue>.Entry> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ADictionary<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x000E05C8 File Offset: 0x000DE7C8
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x00010C54 File Offset: 0x0000EE54
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x000E05F0 File Offset: 0x000DE7F0
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x00010C6F File Offset: 0x0000EE6F
		public unsafe int HjjnxSNoowqRBXlgFxQnyOTSKdg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg)) = value;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x000E0618 File Offset: 0x000DE818
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x00010C8A File Offset: 0x0000EE8A
		public unsafe int NfShnqBdbeGMTSPwAvyurbvaiUA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_NfShnqBdbeGMTSPwAvyurbvaiUA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_NfShnqBdbeGMTSPwAvyurbvaiUA)) = value;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x000E0640 File Offset: 0x000DE840
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x00010CA5 File Offset: 0x0000EEA5
		public unsafe int qNaQysaUHwugrnJRvaprHpAqSRQf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_qNaQysaUHwugrnJRvaprHpAqSRQf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_qNaQysaUHwugrnJRvaprHpAqSRQf)) = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000E0668 File Offset: 0x000DE868
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x00010CC0 File Offset: 0x0000EEC0
		public unsafe int uRfpYfDYIXQvTmLzlsRueNPvpUb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_uRfpYfDYIXQvTmLzlsRueNPvpUb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_uRfpYfDYIXQvTmLzlsRueNPvpUb)) = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x000E0690 File Offset: 0x000DE890
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x00010CDB File Offset: 0x0000EEDB
		public unsafe IEqualityComparer<TKey> rKWSwKmIhNDTzhLhIevaHwnfvwbJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000E06C0 File Offset: 0x000DE8C0
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x00010CFA File Offset: 0x0000EEFA
		public unsafe IEqualityComparer<TValue> TaNQqqGIyLgPUHVmRCwddtyGHCBD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x000E06F0 File Offset: 0x000DE8F0
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00010D19 File Offset: 0x0000EF19
		public unsafe ADictionary<TKey, TValue>.KeyCollection yMWHcoZgVBayuPKzlxlxgqwAhpR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>.KeyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x000E0720 File Offset: 0x000DE920
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x00010D38 File Offset: 0x0000EF38
		public unsafe ADictionary<TKey, TValue>.ValueCollection HBIIXimIAqIVHGkNXwXTiuSAgUDD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>.ValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x000E0750 File Offset: 0x000DE950
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x00010D57 File Offset: 0x0000EF57
		public unsafe Object WIEpnJHUYtGWWDqkMQqkOyrSkha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_WIEpnJHUYtGWWDqkMQqkOyrSkha);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.NativeFieldInfoPtr_WIEpnJHUYtGWWDqkMQqkOyrSkha), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x000E0780 File Offset: 0x000DE980
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x00010D76 File Offset: 0x0000EF76
		public unsafe static bool hVRYlvkeMegeilrvqzjMTEgLgtIf
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf, (void*)(&value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x000E079C File Offset: 0x000DE99C
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x00010D84 File Offset: 0x0000EF84
		public unsafe static bool BRnOGwiQsoyBdDLDAjvpbphqCGu
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu, (void*)(&value));
			}
		}

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeFieldInfoPtr_XiKikjWXxklaMlATFaHXJdFPhAC;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeFieldInfoPtr_FoBDMcstceuEOEGEzTSFlXgfreX;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeFieldInfoPtr_PJWstjOoKHGSnnhfmjIAKCZAtmmk;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeFieldInfoPtr_HjDuuyZguTUshSxAcZKEyMvfIFz;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeFieldInfoPtr_BVNdMpJjcbNFmhsZHfMOfausfASr;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeFieldInfoPtr_NfShnqBdbeGMTSPwAvyurbvaiUA;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeFieldInfoPtr_qNaQysaUHwugrnJRvaprHpAqSRQf;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeFieldInfoPtr_uRfpYfDYIXQvTmLzlsRueNPvpUb;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeFieldInfoPtr_rKWSwKmIhNDTzhLhIevaHwnfvwbJ;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeFieldInfoPtr_TaNQqqGIyLgPUHVmRCwddtyGHCBD;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeFieldInfoPtr_WIEpnJHUYtGWWDqkMQqkOyrSkha;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeFieldInfoPtr_hVRYlvkeMegeilrvqzjMTEgLgtIf;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeFieldInfoPtr_BRnOGwiQsoyBdDLDAjvpbphqCGu;

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400260F RID: 9743
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0;

		// Token: 0x04002610 RID: 9744
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0;

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0;

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyComparer_Public_get_IEqualityComparer_1_TKey_0;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyComparer_Public_set_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueComparer_Public_get_IEqualityComparer_1_TValue_0;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueComparer_Public_set_Void_IEqualityComparer_1_TValue_0;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0;

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_IEqualityComparer_1_TValue_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_GetValueSafe_Public_TValue_TKey_0;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr_get_IndexOfFirst_Public_get_Int32_0;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeMethodInfoPtr_get_IndexOfLast_Public_get_Int32_0;

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfValue_Public_Int32_TValue_0;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAt_Public_Boolean_Int32_0;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyAt_Public_TKey_Int32_0;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeMethodInfoPtr_GetValueAt_Public_TValue_Int32_0;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryAt_Public_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_TryGetKeyAt_Public_Boolean_Int32_byref_TKey_0;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueAt_Public_Boolean_Int32_byref_TValue_0;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEntryAt_Public_Boolean_Int32_byref_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeMethodInfoPtr_GetNextIndex_Public_Boolean_byref_Int32_0;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr_GetNextIndex_Public_Int32_Int32_0;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeMethodInfoPtr_GetNextKey_Public_Boolean_byref_Int32_byref_TKey_0;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr_GetNextValue_Public_Boolean_byref_Int32_byref_TValue_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_GetNextEntry_Public_Boolean_byref_Int32_byref_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousIndex_Public_Boolean_byref_Int32_0;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousIndex_Public_Int32_Int32_0;

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousKey_Public_Boolean_byref_Int32_byref_TKey_0;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousValue_Public_Boolean_byref_Int32_byref_TValue_0;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousEntry_Public_Boolean_byref_Int32_byref_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Boolean_Int32_0;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeMethodInfoPtr_MVALiRCiKZhyDpRnenUOXaSMxky_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_Int32_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeMethodInfoPtr_BDGEvnlkxFdzRvpCaLETcmnAdFxE_Private_Void_TKey_TValue_Boolean_0;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_hGJbZFhhwTpggGktXrktItfiveIl_Private_Void_0;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeMethodInfoPtr_hGJbZFhhwTpggGktXrktItfiveIl_Private_Void_Int32_Boolean_0;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr_wlxDUHaFeiVdKTKYLBdwRAFqttV_Private_Static_Boolean_Object_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_uDVXgxGkGmkmbHkpANAwuqqoiwP_Private_Static_Void_Object_String_0;

		// Token: 0x020003CE RID: 974
		public sealed class Entry : ValueType
		{
			// Token: 0x06004F8B RID: 20363 RVA: 0x00169C10 File Offset: 0x00167E10
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<ADictionary<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Entry>.NativeClassPtr);
				ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Entry>.NativeClassPtr, "hashCode");
				ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Entry>.NativeClassPtr, "next");
				ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Entry>.NativeClassPtr, "key");
				ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Entry>.NativeClassPtr, "value");
			}

			// Token: 0x06004F8C RID: 20364 RVA: 0x0001CF64 File Offset: 0x0001B164
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F8D RID: 20365 RVA: 0x0001CF6D File Offset: 0x0001B16D
			public Entry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Entry>.NativeClassPtr))
			{
			}

			// Token: 0x170018A8 RID: 6312
			// (get) Token: 0x06004F8E RID: 20366 RVA: 0x00169CD8 File Offset: 0x00167ED8
			// (set) Token: 0x06004F8F RID: 20367 RVA: 0x0001CF7F File Offset: 0x0001B17F
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x170018A9 RID: 6313
			// (get) Token: 0x06004F90 RID: 20368 RVA: 0x00169D00 File Offset: 0x00167F00
			// (set) Token: 0x06004F91 RID: 20369 RVA: 0x0001CF9A File Offset: 0x0001B19A
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x170018AA RID: 6314
			// (get) Token: 0x06004F92 RID: 20370 RVA: 0x00169D28 File Offset: 0x00167F28
			// (set) Token: 0x06004F93 RID: 20371 RVA: 0x00169D50 File Offset: 0x00167F50
			public unsafe TKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
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

			// Token: 0x170018AB RID: 6315
			// (get) Token: 0x06004F94 RID: 20372 RVA: 0x00169DF8 File Offset: 0x00167FF8
			// (set) Token: 0x06004F95 RID: 20373 RVA: 0x00169E20 File Offset: 0x00168020
			public unsafe TValue value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
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

			// Token: 0x0400425C RID: 16988
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x0400425D RID: 16989
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400425E RID: 16990
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400425F RID: 16991
			private static readonly IntPtr NativeFieldInfoPtr_value;
		}

		// Token: 0x020003CF RID: 975
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06004F96 RID: 20374 RVA: 0x00169EC8 File Offset: 0x001680C8
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr);
				ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "DictEntry");
				ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "KeyValuePair");
				ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
				ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "YZXVMrPYKUmYEMLUdSpMBLWplnu");
				ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "DvCDMNCBudLHkpnvfpAAHNGzbZYB");
				ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "EDWjCkozGqmyQyquicPQVDMTCVq");
				ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "tYCVbjQNhtzugVkpXQTBPOUTWUE");
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674936);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674937);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674938);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674939);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674940);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674941);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674942);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674943);
				ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674944);
			}

			// Token: 0x06004F97 RID: 20375 RVA: 0x0016A080 File Offset: 0x00168280
			[CallerCount(0)]
			public unsafe Enumerator(ADictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getEnumeratorRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F98 RID: 20376 RVA: 0x0016A0E0 File Offset: 0x001682E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330535, XrefRangeEnd = 330537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018B3 RID: 6323
			// (get) Token: 0x06004F99 RID: 20377 RVA: 0x0016A124 File Offset: 0x00168324
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06004F9A RID: 20378 RVA: 0x0016A160 File Offset: 0x00168360
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B4 RID: 6324
			// (get) Token: 0x06004F9B RID: 20379 RVA: 0x0016A198 File Offset: 0x00168398
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330537, XrefRangeEnd = 330544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F9C RID: 20380 RVA: 0x0016A1DC File Offset: 0x001683DC
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B5 RID: 6325
			// (get) Token: 0x06004F9D RID: 20381 RVA: 0x0016A214 File Offset: 0x00168414
			public unsafe DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330544, XrefRangeEnd = 330553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170018B6 RID: 6326
			// (get) Token: 0x06004F9E RID: 20382 RVA: 0x0016A250 File Offset: 0x00168450
			public unsafe Object System.Collections.IDictionaryEnumerator.Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330553, XrefRangeEnd = 330557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170018B7 RID: 6327
			// (get) Token: 0x06004F9F RID: 20383 RVA: 0x0016A294 File Offset: 0x00168494
			public unsafe Object System.Collections.IDictionaryEnumerator.Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330557, XrefRangeEnd = 330561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FA0 RID: 20384 RVA: 0x0001CFB5 File Offset: 0x0001B1B5
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004FA1 RID: 20385 RVA: 0x0001CFBE File Offset: 0x0001B1BE
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170018AC RID: 6316
			// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x0016A2D8 File Offset: 0x001684D8
			// (set) Token: 0x06004FA3 RID: 20387 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
			public unsafe static int DictEntry
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry, (void*)(&value));
				}
			}

			// Token: 0x170018AD RID: 6317
			// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x0016A2F4 File Offset: 0x001684F4
			// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x0001CFDE File Offset: 0x0001B1DE
			public unsafe static int KeyValuePair
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair, (void*)(&value));
				}
			}

			// Token: 0x170018AE RID: 6318
			// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x0016A310 File Offset: 0x00168510
			// (set) Token: 0x06004FA7 RID: 20391 RVA: 0x0001CFEC File Offset: 0x0001B1EC
			public unsafe ADictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018AF RID: 6319
			// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x0016A340 File Offset: 0x00168540
			// (set) Token: 0x06004FA9 RID: 20393 RVA: 0x0001D00B File Offset: 0x0001B20B
			public unsafe int YZXVMrPYKUmYEMLUdSpMBLWplnu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu)) = value;
				}
			}

			// Token: 0x170018B0 RID: 6320
			// (get) Token: 0x06004FAA RID: 20394 RVA: 0x0016A368 File Offset: 0x00168568
			// (set) Token: 0x06004FAB RID: 20395 RVA: 0x0001D026 File Offset: 0x0001B226
			public unsafe int DvCDMNCBudLHkpnvfpAAHNGzbZYB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB)) = value;
				}
			}

			// Token: 0x170018B1 RID: 6321
			// (get) Token: 0x06004FAC RID: 20396 RVA: 0x0016A390 File Offset: 0x00168590
			// (set) Token: 0x06004FAD RID: 20397 RVA: 0x0001D041 File Offset: 0x0001B241
			public KeyValuePair<TKey, TValue> EDWjCkozGqmyQyquicPQVDMTCVq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018B2 RID: 6322
			// (get) Token: 0x06004FAE RID: 20398 RVA: 0x0016A3C0 File Offset: 0x001685C0
			// (set) Token: 0x06004FAF RID: 20399 RVA: 0x0001D06F File Offset: 0x0001B26F
			public unsafe int tYCVbjQNhtzugVkpXQTBPOUTWUE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE)) = value;
				}
			}

			// Token: 0x04004260 RID: 16992
			private static readonly IntPtr NativeFieldInfoPtr_DictEntry;

			// Token: 0x04004261 RID: 16993
			private static readonly IntPtr NativeFieldInfoPtr_KeyValuePair;

			// Token: 0x04004262 RID: 16994
			private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

			// Token: 0x04004263 RID: 16995
			private static readonly IntPtr NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu;

			// Token: 0x04004264 RID: 16996
			private static readonly IntPtr NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB;

			// Token: 0x04004265 RID: 16997
			private static readonly IntPtr NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq;

			// Token: 0x04004266 RID: 16998
			private static readonly IntPtr NativeFieldInfoPtr_tYCVbjQNhtzugVkpXQTBPOUTWUE;

			// Token: 0x04004267 RID: 16999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_Int32_0;

			// Token: 0x04004268 RID: 17000
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004269 RID: 17001
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x0400426A RID: 17002
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400426B RID: 17003
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400426C RID: 17004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400426D RID: 17005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x0400426E RID: 17006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400426F RID: 17007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003D0 RID: 976
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x06004FB0 RID: 20400 RVA: 0x0016A3E8 File Offset: 0x001685E8
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				ADictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_ADictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674945);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674946);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674947);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674948);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674949);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674950);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674951);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674952);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674953);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674954);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674955);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674956);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674957);
				ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674958);
			}

			// Token: 0x06004FB1 RID: 20401 RVA: 0x0016A58C File Offset: 0x0016878C
			[CallerCount(0)]
			public unsafe KeyCollection(ADictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_ADictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FB2 RID: 20402 RVA: 0x0016A5D8 File Offset: 0x001687D8
			[CallerCount(0)]
			public unsafe ADictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ADictionary<TKey, TValue>.KeyCollection.Enumerator(intPtr);
			}

			// Token: 0x06004FB3 RID: 20403 RVA: 0x0016A610 File Offset: 0x00168810
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B9 RID: 6329
			// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x0016A660 File Offset: 0x00168860
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018BA RID: 6330
			// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x0016A69C File Offset: 0x0016889C
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FB6 RID: 20406 RVA: 0x0016A6D8 File Offset: 0x001688D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330565, XrefRangeEnd = 330570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FB7 RID: 20407 RVA: 0x0016A768 File Offset: 0x00168968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330570, XrefRangeEnd = 330575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FB8 RID: 20408 RVA: 0x0016A79C File Offset: 0x0016899C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FB9 RID: 20409 RVA: 0x0016A834 File Offset: 0x00168A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330575, XrefRangeEnd = 330580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FBA RID: 20410 RVA: 0x0016A8CC File Offset: 0x00168ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330580, XrefRangeEnd = 330582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> System_Collections_Generic_IEnumerable_TKey__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x06004FBB RID: 20411 RVA: 0x0016A90C File Offset: 0x00168B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004FBC RID: 20412 RVA: 0x0016A94C File Offset: 0x00168B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330582, XrefRangeEnd = 330595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018BB RID: 6331
			// (get) Token: 0x06004FBD RID: 20413 RVA: 0x0016A99C File Offset: 0x00168B9C
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018BC RID: 6332
			// (get) Token: 0x06004FBE RID: 20414 RVA: 0x0016A9D8 File Offset: 0x00168BD8
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330595, XrefRangeEnd = 330599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBF RID: 20415 RVA: 0x0001D08A File Offset: 0x0001B28A
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018B8 RID: 6328
			// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x0016AA18 File Offset: 0x00168C18
			// (set) Token: 0x06004FC1 RID: 20417 RVA: 0x0001D093 File Offset: 0x0001B293
			public unsafe ADictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004270 RID: 17008
			private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

			// Token: 0x04004271 RID: 17009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ADictionary_2_TKey_TValue_0;

			// Token: 0x04004272 RID: 17010
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x04004273 RID: 17011
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x04004274 RID: 17012
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004275 RID: 17013
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004276 RID: 17014
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x04004277 RID: 17015
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004278 RID: 17016
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x04004279 RID: 17017
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x0400427A RID: 17018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x0400427B RID: 17019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400427C RID: 17020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x0400427D RID: 17021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400427E RID: 17022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020005A6 RID: 1446
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060060A6 RID: 24742 RVA: 0x001AE104 File Offset: 0x001AC304
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr);
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "DvCDMNCBudLHkpnvfpAAHNGzbZYB");
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "YZXVMrPYKUmYEMLUdSpMBLWplnu");
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "IznGGaUbVZqwskfVHXBzPOSTqNf");
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674959);
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674960);
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674961);
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674962);
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674963);
					ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674964);
				}

				// Token: 0x060060A7 RID: 24743 RVA: 0x001AE244 File Offset: 0x001AC444
				[CallerCount(0)]
				public unsafe Enumerator(ADictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060060A8 RID: 24744 RVA: 0x001AE294 File Offset: 0x001AC494
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060A9 RID: 24745 RVA: 0x001AE2CC File Offset: 0x001AC4CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330561, XrefRangeEnd = 330562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001D44 RID: 7492
				// (get) Token: 0x060060AA RID: 24746 RVA: 0x001AE310 File Offset: 0x001AC510
				public unsafe TKey Current
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
					}
				}

				// Token: 0x17001D45 RID: 7493
				// (get) Token: 0x060060AB RID: 24747 RVA: 0x001AE350 File Offset: 0x001AC550
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330562, XrefRangeEnd = 330565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060060AC RID: 24748 RVA: 0x001AE394 File Offset: 0x001AC594
				[CallerCount(0)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060AD RID: 24749 RVA: 0x00023A4C File Offset: 0x00021C4C
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060060AE RID: 24750 RVA: 0x00023A55 File Offset: 0x00021C55
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17001D40 RID: 7488
				// (get) Token: 0x060060AF RID: 24751 RVA: 0x001AE3CC File Offset: 0x001AC5CC
				// (set) Token: 0x060060B0 RID: 24752 RVA: 0x00023A67 File Offset: 0x00021C67
				public unsafe ADictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001D41 RID: 7489
				// (get) Token: 0x060060B1 RID: 24753 RVA: 0x001AE3FC File Offset: 0x001AC5FC
				// (set) Token: 0x060060B2 RID: 24754 RVA: 0x00023A86 File Offset: 0x00021C86
				public unsafe int DvCDMNCBudLHkpnvfpAAHNGzbZYB
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB)) = value;
					}
				}

				// Token: 0x17001D42 RID: 7490
				// (get) Token: 0x060060B3 RID: 24755 RVA: 0x001AE424 File Offset: 0x001AC624
				// (set) Token: 0x060060B4 RID: 24756 RVA: 0x00023AA1 File Offset: 0x00021CA1
				public unsafe int YZXVMrPYKUmYEMLUdSpMBLWplnu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu)) = value;
					}
				}

				// Token: 0x17001D43 RID: 7491
				// (get) Token: 0x060060B5 RID: 24757 RVA: 0x001AE44C File Offset: 0x001AC64C
				// (set) Token: 0x060060B6 RID: 24758 RVA: 0x001AE474 File Offset: 0x001AC674
				public unsafe TKey IznGGaUbVZqwskfVHXBzPOSTqNf
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf);
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

				// Token: 0x04004F4B RID: 20299
				private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

				// Token: 0x04004F4C RID: 20300
				private static readonly IntPtr NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB;

				// Token: 0x04004F4D RID: 20301
				private static readonly IntPtr NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu;

				// Token: 0x04004F4E RID: 20302
				private static readonly IntPtr NativeFieldInfoPtr_IznGGaUbVZqwskfVHXBzPOSTqNf;

				// Token: 0x04004F4F RID: 20303
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_0;

				// Token: 0x04004F50 RID: 20304
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04004F51 RID: 20305
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04004F52 RID: 20306
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0;

				// Token: 0x04004F53 RID: 20307
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004F54 RID: 20308
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x020003D1 RID: 977
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x06004FC2 RID: 20418 RVA: 0x0016AA48 File Offset: 0x00168C48
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ADictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				ADictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ADictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674965);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674966);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674967);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674968);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674969);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674970);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674971);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674972);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674973);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674974);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674975);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674976);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674977);
				ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674978);
			}

			// Token: 0x06004FC3 RID: 20419 RVA: 0x0016ABEC File Offset: 0x00168DEC
			[CallerCount(0)]
			public unsafe ValueCollection(ADictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ADictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FC4 RID: 20420 RVA: 0x0016AC38 File Offset: 0x00168E38
			[CallerCount(0)]
			public unsafe ADictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ADictionary<TKey, TValue>.ValueCollection.Enumerator(intPtr);
			}

			// Token: 0x06004FC5 RID: 20421 RVA: 0x0016AC70 File Offset: 0x00168E70
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018BE RID: 6334
			// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x0016ACC0 File Offset: 0x00168EC0
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018BF RID: 6335
			// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x0016ACFC File Offset: 0x00168EFC
			public unsafe bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FC8 RID: 20424 RVA: 0x0016AD38 File Offset: 0x00168F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330603, XrefRangeEnd = 330608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FC9 RID: 20425 RVA: 0x0016ADC8 File Offset: 0x00168FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330608, XrefRangeEnd = 330613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FCA RID: 20426 RVA: 0x0016AE60 File Offset: 0x00169060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330613, XrefRangeEnd = 330618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FCB RID: 20427 RVA: 0x0016AE94 File Offset: 0x00169094
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FCC RID: 20428 RVA: 0x0016AF2C File Offset: 0x0016912C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> System_Collections_Generic_IEnumerable_TValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x06004FCD RID: 20429 RVA: 0x0016AF6C File Offset: 0x0016916C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004FCE RID: 20430 RVA: 0x0016AFAC File Offset: 0x001691AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330618, XrefRangeEnd = 330631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018C0 RID: 6336
			// (get) Token: 0x06004FCF RID: 20431 RVA: 0x0016AFFC File Offset: 0x001691FC
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018C1 RID: 6337
			// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x0016B038 File Offset: 0x00169238
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330631, XrefRangeEnd = 330635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD1 RID: 20433 RVA: 0x0001D0B2 File Offset: 0x0001B2B2
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018BD RID: 6333
			// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x0016B078 File Offset: 0x00169278
			// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x0001D0BB File Offset: 0x0001B2BB
			public unsafe ADictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400427F RID: 17023
			private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

			// Token: 0x04004280 RID: 17024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ADictionary_2_TKey_TValue_0;

			// Token: 0x04004281 RID: 17025
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x04004282 RID: 17026
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0;

			// Token: 0x04004283 RID: 17027
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004284 RID: 17028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004285 RID: 17029
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0;

			// Token: 0x04004286 RID: 17030
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x04004287 RID: 17031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004288 RID: 17032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x04004289 RID: 17033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x0400428A RID: 17034
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400428B RID: 17035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x0400428C RID: 17036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400428D RID: 17037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020005A7 RID: 1447
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060060B7 RID: 24759 RVA: 0x001AE51C File Offset: 0x001AC71C
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr);
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "DvCDMNCBudLHkpnvfpAAHNGzbZYB");
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "YZXVMrPYKUmYEMLUdSpMBLWplnu");
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "TCvQSFfpSHkNMlRsCRtrbHRRPVo");
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674979);
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674980);
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674981);
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674982);
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674983);
					ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674984);
				}

				// Token: 0x060060B8 RID: 24760 RVA: 0x001AE65C File Offset: 0x001AC85C
				[CallerCount(0)]
				public unsafe Enumerator(ADictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060060B9 RID: 24761 RVA: 0x001AE6AC File Offset: 0x001AC8AC
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060BA RID: 24762 RVA: 0x001AE6E4 File Offset: 0x001AC8E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330599, XrefRangeEnd = 330600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001D4A RID: 7498
				// (get) Token: 0x060060BB RID: 24763 RVA: 0x001AE728 File Offset: 0x001AC928
				public unsafe TValue Current
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
					}
				}

				// Token: 0x17001D4B RID: 7499
				// (get) Token: 0x060060BC RID: 24764 RVA: 0x001AE768 File Offset: 0x001AC968
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330600, XrefRangeEnd = 330603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060060BD RID: 24765 RVA: 0x001AE7AC File Offset: 0x001AC9AC
				[CallerCount(0)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060BE RID: 24766 RVA: 0x00023ABC File Offset: 0x00021CBC
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060060BF RID: 24767 RVA: 0x00023AC5 File Offset: 0x00021CC5
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ADictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17001D46 RID: 7494
				// (get) Token: 0x060060C0 RID: 24768 RVA: 0x001AE7E4 File Offset: 0x001AC9E4
				// (set) Token: 0x060060C1 RID: 24769 RVA: 0x00023AD7 File Offset: 0x00021CD7
				public unsafe ADictionary<TKey, TValue> ePPbmHJRexSdoExlntQpBSQjqgIV
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001D47 RID: 7495
				// (get) Token: 0x060060C2 RID: 24770 RVA: 0x001AE814 File Offset: 0x001ACA14
				// (set) Token: 0x060060C3 RID: 24771 RVA: 0x00023AF6 File Offset: 0x00021CF6
				public unsafe int DvCDMNCBudLHkpnvfpAAHNGzbZYB
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB)) = value;
					}
				}

				// Token: 0x17001D48 RID: 7496
				// (get) Token: 0x060060C4 RID: 24772 RVA: 0x001AE83C File Offset: 0x001ACA3C
				// (set) Token: 0x060060C5 RID: 24773 RVA: 0x00023B11 File Offset: 0x00021D11
				public unsafe int YZXVMrPYKUmYEMLUdSpMBLWplnu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu)) = value;
					}
				}

				// Token: 0x17001D49 RID: 7497
				// (get) Token: 0x060060C6 RID: 24774 RVA: 0x001AE864 File Offset: 0x001ACA64
				// (set) Token: 0x060060C7 RID: 24775 RVA: 0x001AE88C File Offset: 0x001ACA8C
				public unsafe TValue TCvQSFfpSHkNMlRsCRtrbHRRPVo
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ADictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo);
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

				// Token: 0x04004F55 RID: 20309
				private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

				// Token: 0x04004F56 RID: 20310
				private static readonly IntPtr NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB;

				// Token: 0x04004F57 RID: 20311
				private static readonly IntPtr NativeFieldInfoPtr_YZXVMrPYKUmYEMLUdSpMBLWplnu;

				// Token: 0x04004F58 RID: 20312
				private static readonly IntPtr NativeFieldInfoPtr_TCvQSFfpSHkNMlRsCRtrbHRRPVo;

				// Token: 0x04004F59 RID: 20313
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ADictionary_2_TKey_TValue_0;

				// Token: 0x04004F5A RID: 20314
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04004F5B RID: 20315
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04004F5C RID: 20316
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0;

				// Token: 0x04004F5D RID: 20317
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004F5E RID: 20318
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x020003D2 RID: 978
		private sealed class MethodInfoStoreGeneric_uDVXgxGkGmkmbHkpANAwuqqoiwP_Private_Static_Void_Object_String_0
		{
			// Token: 0x06004FD4 RID: 20436 RVA: 0x0016B0A8 File Offset: 0x001692A8
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_uDVXgxGkGmkmbHkpANAwuqqoiwP_Private_Static_Void_Object_String_0()
			{
				/*
An exception occurred when decompiling this method (06004FD4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppRewired.Utils.Classes.Data.ADictionary`2/MethodInfoStoreGeneric_uDVXgxGkGmkmbHkpANAwuqqoiwP_Private_Static_Void_Object_String_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 149
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1660
*/;
			}

			// Token: 0x0400428E RID: 17038
			internal static IntPtr Pointer;
		}
	}
}
