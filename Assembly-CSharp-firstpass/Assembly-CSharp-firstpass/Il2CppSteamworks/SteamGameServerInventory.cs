using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200013D RID: 317
	public static class SteamGameServerInventory : Object
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00037408 File Offset: 0x00035608
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerInventory()
		{
			Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664598);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664599);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664600);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664601);
			SteamGameServerInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664602);
			SteamGameServerInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664603);
			SteamGameServerInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664604);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664605);
			SteamGameServerInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664606);
			SteamGameServerInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664607);
			SteamGameServerInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664608);
			SteamGameServerInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664609);
			SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664610);
			SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664611);
			SteamGameServerInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664612);
			SteamGameServerInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664613);
			SteamGameServerInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664614);
			SteamGameServerInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664615);
			SteamGameServerInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664616);
			SteamGameServerInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664617);
			SteamGameServerInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664618);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664619);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664620);
			SteamGameServerInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664621);
			SteamGameServerInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664622);
			SteamGameServerInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664623);
			SteamGameServerInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664624);
			SteamGameServerInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664625);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664626);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664627);
			SteamGameServerInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664628);
			SteamGameServerInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664629);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664630);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664631);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty1_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664632);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty2_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664633);
			SteamGameServerInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100664634);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0003771C File Offset: 0x0003591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7765, XrefRangeEnd = 7769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0003775C File Offset: 0x0003595C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7769, XrefRangeEnd = 7773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000377BC File Offset: 0x000359BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7773, XrefRangeEnd = 7796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00037844 File Offset: 0x00035A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7796, XrefRangeEnd = 7800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00037884 File Offset: 0x00035A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7800, XrefRangeEnd = 7804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x000378D0 File Offset: 0x00035AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7804, XrefRangeEnd = 7808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00037904 File Offset: 0x00035B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7808, XrefRangeEnd = 7812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00037944 File Offset: 0x00035B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7812, XrefRangeEnd = 7816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000379A4 File Offset: 0x00035BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7816, XrefRangeEnd = 7820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00037A04 File Offset: 0x00035C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7820, XrefRangeEnd = 7824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00037A70 File Offset: 0x00035C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7824, XrefRangeEnd = 7829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00037AE0 File Offset: 0x00035CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7829, XrefRangeEnd = 7833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00037B20 File Offset: 0x00035D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7833, XrefRangeEnd = 7837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00037B6C File Offset: 0x00035D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7837, XrefRangeEnd = 7841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00037BCC File Offset: 0x00035DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7841, XrefRangeEnd = 7845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00037C28 File Offset: 0x00035E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7845, XrefRangeEnd = 7850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00037CCC File Offset: 0x00035ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7850, XrefRangeEnd = 7854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00037D34 File Offset: 0x00035F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7854, XrefRangeEnd = 7858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendItemDropHeartbeat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00037D5C File Offset: 0x00035F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7858, XrefRangeEnd = 7862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00037DA8 File Offset: 0x00035FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7862, XrefRangeEnd = 7867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00037E5C File Offset: 0x0003605C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7867, XrefRangeEnd = 7871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadItemDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00037E8C File Offset: 0x0003608C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7871, XrefRangeEnd = 7876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00037EDC File Offset: 0x000360DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7876, XrefRangeEnd = 7899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00037F54 File Offset: 0x00036154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7899, XrefRangeEnd = 7906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00037F94 File Offset: 0x00036194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7906, XrefRangeEnd = 7910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00037FF4 File Offset: 0x000361F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7910, XrefRangeEnd = 7918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00038058 File Offset: 0x00036258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7918, XrefRangeEnd = 7925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00038088 File Offset: 0x00036288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7925, XrefRangeEnd = 7929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumItemsWithPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000380B8 File Offset: 0x000362B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7929, XrefRangeEnd = 7934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0003811C File Offset: 0x0003631C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7934, XrefRangeEnd = 7938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00038168 File Offset: 0x00036368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7938, XrefRangeEnd = 7945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00038198 File Offset: 0x00036398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7945, XrefRangeEnd = 7957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000381F8 File Offset: 0x000363F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7957, XrefRangeEnd = 7976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00038268 File Offset: 0x00036468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7976, XrefRangeEnd = 7988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000382D4 File Offset: 0x000364D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7988, XrefRangeEnd = 8000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty1_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00038340 File Offset: 0x00036540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8000, XrefRangeEnd = 8012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty2_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000383AC File Offset: 0x000365AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8012, XrefRangeEnd = 8016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000064CE File Offset: 0x000046CE
		public SteamGameServerInventory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_UInt32_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty1_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty2_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0;
	}
}
