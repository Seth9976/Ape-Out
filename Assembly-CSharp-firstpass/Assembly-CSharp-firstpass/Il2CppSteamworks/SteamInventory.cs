using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000144 RID: 324
	public static class SteamInventory : Object
	{
		// Token: 0x06000C60 RID: 3168 RVA: 0x0003D09C File Offset: 0x0003B29C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventory()
		{
			Il2CppClassPointerStore<SteamInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr);
			SteamInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664831);
			SteamInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664832);
			SteamInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664833);
			SteamInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664834);
			SteamInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664835);
			SteamInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664836);
			SteamInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664837);
			SteamInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664838);
			SteamInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664839);
			SteamInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664840);
			SteamInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664841);
			SteamInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664842);
			SteamInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664843);
			SteamInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664844);
			SteamInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664845);
			SteamInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664846);
			SteamInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664847);
			SteamInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664848);
			SteamInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664849);
			SteamInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664850);
			SteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664851);
			SteamInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664852);
			SteamInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664853);
			SteamInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664854);
			SteamInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664855);
			SteamInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664856);
			SteamInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664857);
			SteamInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664858);
			SteamInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664859);
			SteamInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664860);
			SteamInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664861);
			SteamInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664862);
			SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664863);
			SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664864);
			SteamInventory.NativeMethodInfoPtr_SetProperty1_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664865);
			SteamInventory.NativeMethodInfoPtr_SetProperty2_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664866);
			SteamInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100664867);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003D3B0 File Offset: 0x0003B5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9483, XrefRangeEnd = 9487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9487, XrefRangeEnd = 9491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetResultItems(SteamInventoryResult_t resultHandle, Il2CppStructArray<SteamItemDetails_t> pOutItemsArray, ref uint punOutItemsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOutItemsArray);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutItemsArraySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0003D450 File Offset: 0x0003B650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9491, XrefRangeEnd = 9514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unItemIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0003D4D8 File Offset: 0x0003B6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9514, XrefRangeEnd = 9518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0003D518 File Offset: 0x0003B718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9518, XrefRangeEnd = 9522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDExpected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0003D564 File Offset: 0x0003B764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9522, XrefRangeEnd = 9526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003D598 File Offset: 0x0003B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9526, XrefRangeEnd = 9530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9530, XrefRangeEnd = 9534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemInstanceID_t> pInstanceIDs, uint unCountInstanceIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pInstanceIDs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCountInstanceIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0003D638 File Offset: 0x0003B838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9534, XrefRangeEnd = 9538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SerializeResult(SteamInventoryResult_t resultHandle, Il2CppStructArray<byte> pOutBuffer, out uint punOutBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOutBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003D698 File Offset: 0x0003B898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9538, XrefRangeEnd = 9542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, Il2CppStructArray<byte> pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pOutResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRESERVED_MUST_BE_FALSE;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003D704 File Offset: 0x0003B904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9542, XrefRangeEnd = 9547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GenerateItems(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayQuantity);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003D774 File Offset: 0x0003B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9547, XrefRangeEnd = 9551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003D7B4 File Offset: 0x0003B9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9551, XrefRangeEnd = 9555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemDef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0003D800 File Offset: 0x0003BA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9555, XrefRangeEnd = 9559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0003D860 File Offset: 0x0003BA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9559, XrefRangeEnd = 9563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemConsume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0003D8BC File Offset: 0x0003BABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9563, XrefRangeEnd = 9568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemDef_t> pArrayGenerate, Il2CppStructArray<uint> punArrayGenerateQuantity, uint unArrayGenerateLength, Il2CppStructArray<SteamItemInstanceID_t> pArrayDestroy, Il2CppStructArray<uint> punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGenerate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayGenerateQuantity);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayGenerateLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayDestroy);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayDestroyQuantity);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayDestroyLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0003D960 File Offset: 0x0003BB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9568, XrefRangeEnd = 9572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdDest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9572, XrefRangeEnd = 9576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendItemDropHeartbeat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0003D9F0 File Offset: 0x0003BBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9576, XrefRangeEnd = 9580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dropListDefinition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003DA3C File Offset: 0x0003BC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9580, XrefRangeEnd = 9585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, Il2CppStructArray<SteamItemInstanceID_t> pArrayGive, Il2CppStructArray<uint> pArrayGiveQuantity, uint nArrayGiveLength, Il2CppStructArray<SteamItemInstanceID_t> pArrayGet, Il2CppStructArray<uint> pArrayGetQuantity, uint nArrayGetLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDTradePartner;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGive);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGiveQuantity);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGiveLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGet);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGetQuantity);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGetLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0003DAF0 File Offset: 0x0003BCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9585, XrefRangeEnd = 9589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadItemDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0003DB20 File Offset: 0x0003BD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9589, XrefRangeEnd = 9594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemDefinitionIDs(Il2CppStructArray<SteamItemDef_t> pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pItemDefIDs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0003DB70 File Offset: 0x0003BD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9594, XrefRangeEnd = 9617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDefinition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0003DBE8 File Offset: 0x0003BDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9617, XrefRangeEnd = 9624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0003DC28 File Offset: 0x0003BE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9624, XrefRangeEnd = 9628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, Il2CppStructArray<SteamItemDef_t> pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pItemDefIDs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003DC88 File Offset: 0x0003BE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9628, XrefRangeEnd = 9636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t StartPurchase(Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayQuantity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003DCEC File Offset: 0x0003BEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9636, XrefRangeEnd = 9643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0003DD1C File Offset: 0x0003BF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9643, XrefRangeEnd = 9647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumItemsWithPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0003DD4C File Offset: 0x0003BF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9647, XrefRangeEnd = 9652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemsWithPrices(Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, Il2CppStructArray<ulong> pPrices, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pPrices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9652, XrefRangeEnd = 9656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pPrice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDefinition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003DDFC File Offset: 0x0003BFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9656, XrefRangeEnd = 9663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003DE2C File Offset: 0x0003C02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9663, XrefRangeEnd = 9675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003DE8C File Offset: 0x0003C08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9675, XrefRangeEnd = 9694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003DEFC File Offset: 0x0003C0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9694, XrefRangeEnd = 9706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003DF68 File Offset: 0x0003C168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9706, XrefRangeEnd = 9718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty1(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty1_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003DFD4 File Offset: 0x0003C1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9718, XrefRangeEnd = 9730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty2(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty2_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003E040 File Offset: 0x0003C240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9730, XrefRangeEnd = 9734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0000650D File Offset: 0x0000470D
		public SteamInventory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_UInt32_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty1_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty2_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0;
	}
}
