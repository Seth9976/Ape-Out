using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public sealed class TimeZoneInfo : Object
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x00073854 File Offset: 0x00071A54
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZoneInfo()
		{
			Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZoneInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr);
			TimeZoneInfo.NativeFieldInfoPtr_baseUtcOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "baseUtcOffset");
			TimeZoneInfo.NativeFieldInfoPtr_daylightDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "daylightDisplayName");
			TimeZoneInfo.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "displayName");
			TimeZoneInfo.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "id");
			TimeZoneInfo.NativeFieldInfoPtr_local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "local");
			TimeZoneInfo.NativeFieldInfoPtr_transitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "transitions");
			TimeZoneInfo.NativeFieldInfoPtr_readlinkNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "readlinkNotFound");
			TimeZoneInfo.NativeFieldInfoPtr_standardDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "standardDisplayName");
			TimeZoneInfo.NativeFieldInfoPtr_supportsDaylightSavingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "supportsDaylightSavingTime");
			TimeZoneInfo.NativeFieldInfoPtr_utc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "utc");
			TimeZoneInfo.NativeFieldInfoPtr_timeZoneDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "timeZoneDirectory");
			TimeZoneInfo.NativeFieldInfoPtr_adjustmentRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "adjustmentRules");
			TimeZoneInfo.NativeFieldInfoPtr_timeZoneKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "timeZoneKey");
			TimeZoneInfo.NativeFieldInfoPtr_localZoneKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "localZoneKey");
			TimeZoneInfo.NativeFieldInfoPtr_systemTimeZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "systemTimeZones");
			TimeZoneInfo.NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666283);
			TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRule_Private_Static_List_1_AdjustmentRule_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666284);
			TimeZoneInfo.NativeMethodInfoPtr_CreateLocalUnity_Private_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666285);
			TimeZoneInfo.NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666286);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666287);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationWin32_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666288);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666289);
			TimeZoneInfo.NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666290);
			TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666291);
			TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666292);
			TimeZoneInfo.NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666293);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666294);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneKeyNameWin32Fallback_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666295);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666296);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Internal_Static_List_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666297);
			TimeZoneInfo.NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666298);
			TimeZoneInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666299);
			TimeZoneInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666300);
			TimeZoneInfo.NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666301);
			TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666302);
			TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666303);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetNameFromPath_Private_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666304);
			TimeZoneInfo.NativeMethodInfoPtr_CreateLocal_Private_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666305);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdCore_Private_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666306);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesCore_Private_Static_Void_List_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666307);
			TimeZoneInfo.NativeMethodInfoPtr_get_SupportsDaylightSavingTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666308);
			TimeZoneInfo.NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666309);
			TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneDirectory_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666310);
			TimeZoneInfo.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666311);
			TimeZoneInfo.NativeMethodInfoPtr_TrimSpecial_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666312);
			TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneKey_Private_Static_get_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666313);
			TimeZoneInfo.NativeMethodInfoPtr_get_LocalZoneKey_Private_Static_get_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666314);
			TimeZoneInfo.NativeMethodInfoPtr_TryAddTicks_Private_Static_Boolean_DateTime_Int64_byref_DateTime_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666315);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Public_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666316);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Private_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666317);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666318);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666319);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666320);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666321);
			TimeZoneInfo.NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666322);
			TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666323);
			TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666324);
			TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666325);
			TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666326);
			TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666327);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneById_Public_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666328);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByFileName_Private_Static_TimeZoneInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666329);
			TimeZoneInfo.NativeMethodInfoPtr_FromRegistryKey_Private_Static_TimeZoneInfo_String_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666330);
			TimeZoneInfo.NativeMethodInfoPtr_ParseRegTzi_Private_Static_Void_List_1_AdjustmentRule_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666331);
			TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRules_Public_Il2CppReferenceArray_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666332);
			TimeZoneInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666333);
			TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666334);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666335);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666336);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666337);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetHelper_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666338);
			TimeZoneInfo.NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666339);
			TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousTime_Public_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666340);
			TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousLocalDstFromUtc_Private_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666341);
			TimeZoneInfo.NativeMethodInfoPtr_IsInDST_Private_Boolean_AdjustmentRule_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666342);
			TimeZoneInfo.NativeMethodInfoPtr_IsInDSTForYear_Private_Boolean_AdjustmentRule_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666343);
			TimeZoneInfo.NativeMethodInfoPtr_IsInvalidTime_Public_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666344);
			TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666345);
			TimeZoneInfo.NativeMethodInfoPtr_Validate_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666346);
			TimeZoneInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666347);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666348);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666349);
			TimeZoneInfo.NativeMethodInfoPtr_GetApplicableRule_Private_AdjustmentRule_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666350);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetTransitionOffset_Private_Boolean_DateTime_byref_TimeSpan_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666351);
			TimeZoneInfo.NativeMethodInfoPtr_TransitionPoint_Private_Static_DateTime_TransitionTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666352);
			TimeZoneInfo.NativeMethodInfoPtr_ValidateRules_Private_Static_Il2CppReferenceArray_1_AdjustmentRule_List_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666353);
			TimeZoneInfo.NativeMethodInfoPtr_BuildFromStream_Private_Static_TimeZoneInfo_String_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666354);
			TimeZoneInfo.NativeMethodInfoPtr_ValidTZFile_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666355);
			TimeZoneInfo.NativeMethodInfoPtr_SwapInt32_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666356);
			TimeZoneInfo.NativeMethodInfoPtr_ReadBigEndianInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666357);
			TimeZoneInfo.NativeMethodInfoPtr_ParseTZBuffer_Private_Static_TimeZoneInfo_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666358);
			TimeZoneInfo.NativeMethodInfoPtr_ParseAbbreviations_Private_Static_Dictionary_2_Int32_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666359);
			TimeZoneInfo.NativeMethodInfoPtr_ParseTimesTypes_Private_Static_Dictionary_2_Int32_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666360);
			TimeZoneInfo.NativeMethodInfoPtr_ParseTransitions_Private_Static_List_1_KeyValuePair_2_DateTime_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_TimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666361);
			TimeZoneInfo.NativeMethodInfoPtr_DateTimeFromUnixTime_Private_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666362);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666363);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666364);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666365);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666366);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00074040 File Offset: 0x00072240
		[CallerCount(0)]
		public unsafe static bool UtcOffsetOutOfRange(TimeSpan offset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00074080 File Offset: 0x00072280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168517, XrefRangeEnd = 168535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out Il2CppStructArray<long> data, out Il2CppStringArray names, string standardNameCurrentYear, string daylightNameCurrentYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardNameCurrentYear);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightNameCurrentYear);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRule_Private_Static_List_1_AdjustmentRule_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			data = ((intPtr5 == 0) ? null : new Il2CppStructArray<long>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			names = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<List<TimeZoneInfo.AdjustmentRule>>(intPtr7) : null;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0007412C File Offset: 0x0007232C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168535, XrefRangeEnd = 168571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateLocalUnity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateLocalUnity_Private_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00074160 File Offset: 0x00072360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168571, XrefRangeEnd = 168575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwIndex;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lpTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x000741C0 File Offset: 0x000723C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168575, XrefRangeEnd = 168579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00074214 File Offset: 0x00072414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168579, XrefRangeEnd = 168583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationWin32_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00074268 File Offset: 0x00072468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168583, XrefRangeEnd = 168587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lpTimeZoneInformation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &FirstYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &LastYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x000742CC File Offset: 0x000724CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168593, RefRangeEnd = 168596, XrefRangeStart = 168587, XrefRangeEnd = 168593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wYear;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pdtzi));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ptzi = ((intPtr4 == 0) ? null : new TimeZoneInfo.TIME_ZONE_INFORMATION(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00074344 File Offset: 0x00072544
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 168634, RefRangeEnd = 168638, XrefRangeStart = 168596, XrefRangeEnd = 168634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endDate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultBaseUtcOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000743B8 File Offset: 0x000725B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168638, XrefRangeEnd = 168648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transitionTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readStartDate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0007441C File Offset: 0x0007261C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168717, RefRangeEnd = 168719, XrefRangeStart = 168648, XrefRangeEnd = 168717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00074468 File Offset: 0x00072668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168729, RefRangeEnd = 168731, XrefRangeStart = 168719, XrefRangeEnd = 168729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0007449C File Offset: 0x0007269C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168739, RefRangeEnd = 168740, XrefRangeStart = 168731, XrefRangeEnd = 168739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalTimeZoneKeyNameWin32Fallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneKeyNameWin32Fallback_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x000744C8 File Offset: 0x000726C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168773, RefRangeEnd = 168774, XrefRangeStart = 168740, XrefRangeEnd = 168773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0007450C File Offset: 0x0007270C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168797, RefRangeEnd = 168798, XrefRangeStart = 168774, XrefRangeEnd = 168797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Internal_Static_List_1_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TimeZoneInfo>>(intPtr3) : null;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00074540 File Offset: 0x00072740
		public unsafe TimeSpan BaseUtcOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0007457C File Offset: 0x0007277C
		public unsafe string DisplayName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x000745B4 File Offset: 0x000727B4
		public unsafe string Id
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000745EC File Offset: 0x000727EC
		public unsafe static TimeZoneInfo Local
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 168804, RefRangeEnd = 168852, XrefRangeStart = 168798, XrefRangeEnd = 168804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00074620 File Offset: 0x00072820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168852, XrefRangeEnd = 168854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int readlink(string path, Il2CppStructArray<byte> buffer, int buflen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buflen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00074684 File Offset: 0x00072884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168868, RefRangeEnd = 168869, XrefRangeStart = 168854, XrefRangeEnd = 168868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string readlink(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000746C0 File Offset: 0x000728C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168869, XrefRangeEnd = 168908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetNameFromPath(string path, out string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetNameFromPath_Private_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0007471C File Offset: 0x0007291C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168933, RefRangeEnd = 168934, XrefRangeStart = 168908, XrefRangeEnd = 168933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateLocal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateLocal_Private_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00074750 File Offset: 0x00072950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168934, XrefRangeEnd = 168940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneByIdCore(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdCore_Private_Static_TimeZoneInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00074794 File Offset: 0x00072994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168967, RefRangeEnd = 168969, XrefRangeStart = 168940, XrefRangeEnd = 168967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemTimeZones);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesCore_Private_Static_Void_List_1_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x000747CC File Offset: 0x000729CC
		public unsafe bool SupportsDaylightSavingTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_SupportsDaylightSavingTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00074808 File Offset: 0x00072A08
		public unsafe static TimeZoneInfo Utc
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 168976, RefRangeEnd = 168989, XrefRangeStart = 168969, XrefRangeEnd = 168976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0007483C File Offset: 0x00072A3C
		public unsafe static string TimeZoneDirectory
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 168994, RefRangeEnd = 168998, XrefRangeStart = 168989, XrefRangeEnd = 168994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneDirectory_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00074868 File Offset: 0x00072A68
		public unsafe static bool IsWindows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168998, XrefRangeEnd = 168999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00074898 File Offset: 0x00072A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169008, RefRangeEnd = 169009, XrefRangeStart = 168999, XrefRangeEnd = 169008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimSpecial(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TrimSpecial_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x000748D4 File Offset: 0x00072AD4
		public unsafe static RegistryKey TimeZoneKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 169021, RefRangeEnd = 169024, XrefRangeStart = 169009, XrefRangeEnd = 169021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneKey_Private_Static_get_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00074908 File Offset: 0x00072B08
		public unsafe static RegistryKey LocalZoneKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 169036, RefRangeEnd = 169039, XrefRangeStart = 169024, XrefRangeEnd = 169036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_LocalZoneKey_Private_Static_get_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0007493C File Offset: 0x00072B3C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 169053, RefRangeEnd = 169064, XrefRangeStart = 169039, XrefRangeEnd = 169053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = DateTimeKind.Unspecified)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ticks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryAddTicks_Private_Static_Boolean_DateTime_Int64_byref_DateTime_DateTimeKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x000749A4 File Offset: 0x00072BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169077, RefRangeEnd = 169078, XrefRangeStart = 169064, XrefRangeEnd = 169077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationTimeZone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Public_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00074A08 File Offset: 0x00072C08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169083, RefRangeEnd = 169086, XrefRangeStart = 169078, XrefRangeEnd = 169083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ConvertTimeFromUtc(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Private_DateTime_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00074A54 File Offset: 0x00072C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169086, XrefRangeEnd = 169093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationTimeZone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00074AA4 File Offset: 0x00072CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169095, RefRangeEnd = 169096, XrefRangeStart = 169093, XrefRangeEnd = 169095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00074AF0 File Offset: 0x00072CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169096, XrefRangeEnd = 169097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00074B40 File Offset: 0x00072D40
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 169101, RefRangeEnd = 169111, XrefRangeStart = 169097, XrefRangeEnd = 169101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00074BA0 File Offset: 0x00072DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169111, XrefRangeEnd = 169113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00074BEC File Offset: 0x00072DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169113, XrefRangeEnd = 169114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00074C64 File Offset: 0x00072E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169114, XrefRangeEnd = 169115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00074D00 File Offset: 0x00072F00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 169119, RefRangeEnd = 169124, XrefRangeStart = 169115, XrefRangeEnd = 169119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules, bool disableDaylightSavingTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableDaylightSavingTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00074DAC File Offset: 0x00072FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169124, XrefRangeEnd = 169127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00074DFC File Offset: 0x00072FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169127, XrefRangeEnd = 169128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TimeZoneInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00074E4C File Offset: 0x0007304C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169159, RefRangeEnd = 169160, XrefRangeStart = 169128, XrefRangeEnd = 169159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneById(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneById_Public_Static_TimeZoneInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00074E90 File Offset: 0x00073090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169163, RefRangeEnd = 169165, XrefRangeStart = 169160, XrefRangeEnd = 169163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filepath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByFileName_Private_Static_TimeZoneInfo_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00074EE8 File Offset: 0x000730E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169209, RefRangeEnd = 169210, XrefRangeStart = 169165, XrefRangeEnd = 169209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FromRegistryKey(string id, RegistryKey key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FromRegistryKey_Private_Static_TimeZoneInfo_String_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00074F40 File Offset: 0x00073140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169254, RefRangeEnd = 169255, XrefRangeStart = 169210, XrefRangeEnd = 169254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, Il2CppStructArray<byte> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start_year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end_year;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseRegTzi_Private_Static_Void_List_1_AdjustmentRule_Int32_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00074FA4 File Offset: 0x000731A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169255, XrefRangeEnd = 169258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> GetAdjustmentRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRules_Public_Il2CppReferenceArray_1_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>>(intPtr3) : null;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00074FE4 File Offset: 0x000731E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169258, XrefRangeEnd = 169267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00075020 File Offset: 0x00073220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169267, XrefRangeEnd = 169489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0007507C File Offset: 0x0007327C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169489, XrefRangeEnd = 169504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr3) : null;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000750B0 File Offset: 0x000732B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169504, XrefRangeEnd = 169505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x000750FC File Offset: 0x000732FC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 169512, RefRangeEnd = 169527, XrefRangeStart = 169505, XrefRangeEnd = 169512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST, bool forOffset = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDST;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00075164 File Offset: 0x00073364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169552, RefRangeEnd = 169554, XrefRangeStart = 169527, XrefRangeEnd = 169552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST, bool forOffset = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tz);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDST;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetHelper_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x000751D0 File Offset: 0x000733D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169574, RefRangeEnd = 169576, XrefRangeStart = 169554, XrefRangeEnd = 169574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameRules(TimeZoneInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00075220 File Offset: 0x00073420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169592, RefRangeEnd = 169594, XrefRangeStart = 169576, XrefRangeEnd = 169592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAmbiguousTime(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousTime_Public_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0007526C File Offset: 0x0007346C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169594, XrefRangeEnd = 169605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAmbiguousLocalDstFromUtc(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousLocalDstFromUtc_Private_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000752B8 File Offset: 0x000734B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169613, RefRangeEnd = 169616, XrefRangeStart = 169605, XrefRangeEnd = 169613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsInDST_Private_Boolean_AdjustmentRule_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00075314 File Offset: 0x00073514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169626, RefRangeEnd = 169628, XrefRangeStart = 169616, XrefRangeEnd = 169626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsInDSTForYear_Private_Boolean_AdjustmentRule_DateTime_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00075380 File Offset: 0x00073580
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169638, RefRangeEnd = 169641, XrefRangeStart = 169628, XrefRangeEnd = 169638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInvalidTime(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsInvalidTime_Public_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x000753CC File Offset: 0x000735CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169641, XrefRangeEnd = 169642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00075410 File Offset: 0x00073610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169681, RefRangeEnd = 169682, XrefRangeStart = 169642, XrefRangeEnd = 169681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(string id, TimeSpan baseUtcOffset, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Validate_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00075468 File Offset: 0x00073668
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000754A0 File Offset: 0x000736A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169682, XrefRangeEnd = 169736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00075504 File Offset: 0x00073704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169837, RefRangeEnd = 169839, XrefRangeStart = 169736, XrefRangeEnd = 169837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules, bool disableDaylightSavingTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableDaylightSavingTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x000755B8 File Offset: 0x000737B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 169842, RefRangeEnd = 169849, XrefRangeStart = 169839, XrefRangeEnd = 169842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetApplicableRule_Private_AdjustmentRule_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00075604 File Offset: 0x00073804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169883, RefRangeEnd = 169884, XrefRangeStart = 169849, XrefRangeEnd = 169883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst, bool forOffset = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDst;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetTransitionOffset_Private_Boolean_DateTime_byref_TimeSpan_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00075678 File Offset: 0x00073878
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 169907, RefRangeEnd = 169915, XrefRangeStart = 169884, XrefRangeEnd = 169907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TransitionPoint_Private_Static_DateTime_TransitionTime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000756C4 File Offset: 0x000738C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169927, RefRangeEnd = 169928, XrefRangeStart = 169915, XrefRangeEnd = 169927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ValidateRules_Private_Static_Il2CppReferenceArray_1_AdjustmentRule_List_1_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>>(intPtr3) : null;
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00075708 File Offset: 0x00073908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169933, RefRangeEnd = 169934, XrefRangeStart = 169928, XrefRangeEnd = 169933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo BuildFromStream(string id, Stream stream)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_BuildFromStream_Private_Static_TimeZoneInfo_String_Stream_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00075760 File Offset: 0x00073960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169944, RefRangeEnd = 169945, XrefRangeStart = 169934, XrefRangeEnd = 169944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidTZFile(Il2CppStructArray<byte> buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ValidTZFile_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x000757B0 File Offset: 0x000739B0
		[CallerCount(0)]
		public unsafe static int SwapInt32(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_SwapInt32_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000757F0 File Offset: 0x000739F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 169950, RefRangeEnd = 169958, XrefRangeStart = 169945, XrefRangeEnd = 169950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadBigEndianInt32(Il2CppStructArray<byte> buffer, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ReadBigEndianInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00075840 File Offset: 0x00073A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170083, RefRangeEnd = 170084, XrefRangeStart = 169958, XrefRangeEnd = 170083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo ParseTZBuffer(string id, Il2CppStructArray<byte> buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseTZBuffer_Private_Static_TimeZoneInfo_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000758A4 File Offset: 0x00073AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170106, RefRangeEnd = 170107, XrefRangeStart = 170084, XrefRangeEnd = 170106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, string> ParseAbbreviations(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseAbbreviations_Private_Static_Dictionary_2_Int32_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00075904 File Offset: 0x00073B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170120, RefRangeEnd = 170121, XrefRangeStart = 170107, XrefRangeEnd = 170120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, TimeType> ParseTimesTypes(Il2CppStructArray<byte> buffer, int index, int count, Dictionary<int, string> abbreviations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbreviations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseTimesTypes_Private_Static_Dictionary_2_Int32_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TimeType>>(intPtr3) : null;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00075978 File Offset: 0x00073B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170147, RefRangeEnd = 170148, XrefRangeStart = 170121, XrefRangeEnd = 170147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(Il2CppStructArray<byte> buffer, int index, int count, Dictionary<int, TimeType> time_types)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(time_types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseTransitions_Private_Static_List_1_KeyValuePair_2_DateTime_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_TimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<DateTime, TimeType>>>(intPtr3) : null;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000759EC File Offset: 0x00073BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170148, XrefRangeEnd = 170153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime DateTimeFromUnixTime(long unix_time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unix_time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_DateTimeFromUnixTime_Private_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00075A2C File Offset: 0x00073C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170155, RefRangeEnd = 170156, XrefRangeStart = 170153, XrefRangeEnd = 170155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00075A78 File Offset: 0x00073C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00075AD0 File Offset: 0x00073CD0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 170169, RefRangeEnd = 170184, XrefRangeStart = 170156, XrefRangeEnd = 170169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDaylightSavings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00075B3C File Offset: 0x00073D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170184, XrefRangeEnd = 170187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00006253 File Offset: 0x00004453
		public TimeZoneInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00075B78 File Offset: 0x00073D78
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x0000625C File Offset: 0x0000445C
		public unsafe TimeSpan baseUtcOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_baseUtcOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_baseUtcOffset)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00075BA0 File Offset: 0x00073DA0
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00006277 File Offset: 0x00004477
		public unsafe string daylightDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_daylightDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_daylightDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00075BC8 File Offset: 0x00073DC8
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00006296 File Offset: 0x00004496
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00075BF0 File Offset: 0x00073DF0
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x000062B5 File Offset: 0x000044B5
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00075C18 File Offset: 0x00073E18
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x000062D4 File Offset: 0x000044D4
		public unsafe static TimeZoneInfo local
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_local, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_local, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00075C40 File Offset: 0x00073E40
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x000062E6 File Offset: 0x000044E6
		public unsafe List<KeyValuePair<DateTime, TimeType>> transitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_transitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<DateTime, TimeType>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_transitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00075C70 File Offset: 0x00073E70
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00006305 File Offset: 0x00004505
		public unsafe static bool readlinkNotFound
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_readlinkNotFound, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_readlinkNotFound, (void*)(&value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00075C8C File Offset: 0x00073E8C
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00006313 File Offset: 0x00004513
		public unsafe string standardDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_standardDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_standardDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00075CB4 File Offset: 0x00073EB4
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x00006332 File Offset: 0x00004532
		public unsafe bool supportsDaylightSavingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_supportsDaylightSavingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_supportsDaylightSavingTime)) = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x00075CDC File Offset: 0x00073EDC
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x0000634D File Offset: 0x0000454D
		public unsafe static TimeZoneInfo utc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_utc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_utc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00075D04 File Offset: 0x00073F04
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x0000635F File Offset: 0x0000455F
		public unsafe static string timeZoneDirectory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneDirectory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneDirectory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00075D24 File Offset: 0x00073F24
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00006371 File Offset: 0x00004571
		public unsafe Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_adjustmentRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_adjustmentRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00075D54 File Offset: 0x00073F54
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00006390 File Offset: 0x00004590
		public unsafe static RegistryKey timeZoneKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00075D7C File Offset: 0x00073F7C
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x000063A2 File Offset: 0x000045A2
		public unsafe static RegistryKey localZoneKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_localZoneKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_localZoneKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00075DA4 File Offset: 0x00073FA4
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x000063B4 File Offset: 0x000045B4
		public unsafe static ReadOnlyCollection<TimeZoneInfo> systemTimeZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_systemTimeZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_systemTimeZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeFieldInfoPtr_baseUtcOffset;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeFieldInfoPtr_daylightDisplayName;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeFieldInfoPtr_local;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeFieldInfoPtr_transitions;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeFieldInfoPtr_readlinkNotFound;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_standardDisplayName;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr_supportsDaylightSavingTime;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeFieldInfoPtr_utc;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeFieldInfoPtr_timeZoneDirectory;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_adjustmentRules;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeFieldInfoPtr_timeZoneKey;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeFieldInfoPtr_localZoneKey;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeFieldInfoPtr_systemTimeZones;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Private_Static_List_1_AdjustmentRule_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_String_String_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalUnity_Private_Static_TimeZoneInfo_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformationWin32_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimeZoneKeyNameWin32Fallback_Internal_Static_String_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Internal_Static_List_1_TimeZoneInfo_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr_readlink_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr_readlink_Private_Static_String_String_0;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNameFromPath_Private_Static_Boolean_String_byref_String_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocal_Private_Static_TimeZoneInfo_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByIdCore_Private_Static_TimeZoneInfo_String_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZonesCore_Private_Static_Void_List_1_TimeZoneInfo_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsDaylightSavingTime_Public_get_Boolean_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeZoneDirectory_Private_Static_get_String_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_TrimSpecial_Private_Static_String_String_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeZoneKey_Private_Static_get_RegistryKey_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalZoneKey_Private_Static_get_RegistryKey_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_TryAddTicks_Private_Static_Boolean_DateTime_Int64_byref_DateTime_DateTimeKind_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTime_Public_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeFromUtc_Private_DateTime_DateTime_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeFromUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneById_Public_Static_TimeZoneInfo_String_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByFileName_Private_Static_TimeZoneInfo_String_String_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_FromRegistryKey_Private_Static_TimeZoneInfo_String_RegistryKey_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_ParseRegTzi_Private_Static_Void_List_1_AdjustmentRule_Int32_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustmentRules_Public_Il2CppReferenceArray_1_AdjustmentRule_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_byref_Boolean_Boolean_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffsetHelper_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_Boolean_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_IsAmbiguousTime_Public_Boolean_DateTime_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_IsAmbiguousLocalDstFromUtc_Private_Boolean_DateTime_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_IsInDST_Private_Boolean_AdjustmentRule_DateTime_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_IsInDSTForYear_Private_Boolean_AdjustmentRule_DateTime_Int32_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_IsInvalidTime_Public_Boolean_DateTime_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicableRule_Private_AdjustmentRule_DateTime_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTransitionOffset_Private_Boolean_DateTime_byref_TimeSpan_byref_Boolean_Boolean_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_TransitionPoint_Private_Static_DateTime_TransitionTime_Int32_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRules_Private_Static_Il2CppReferenceArray_1_AdjustmentRule_List_1_AdjustmentRule_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_BuildFromStream_Private_Static_TimeZoneInfo_String_Stream_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_ValidTZFile_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_SwapInt32_Private_Static_Int32_Int32_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_ReadBigEndianInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_ParseTZBuffer_Private_Static_TimeZoneInfo_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_ParseAbbreviations_Private_Static_Dictionary_2_Int32_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimesTypes_Private_Static_Dictionary_2_Int32_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_String_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_ParseTransitions_Private_Static_List_1_KeyValuePair_2_DateTime_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_TimeType_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeFromUnixTime_Private_Static_DateTime_Int64_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x020005A0 RID: 1440
		[Serializable]
		public sealed class AdjustmentRule : Object
		{
			// Token: 0x060050CF RID: 20687 RVA: 0x0016ED08 File Offset: 0x0016CF08
			// Note: this type is marked as 'beforefieldinit'.
			static AdjustmentRule()
			{
				Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "AdjustmentRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr);
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_dateStart");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_dateEnd");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_daylightDelta");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_daylightTransitionStart");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_daylightTransitionEnd");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_baseUtcOffsetDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_baseUtcOffsetDelta");
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666367);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666368);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666369);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666370);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666371);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666372);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666373);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666374);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Public_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666375);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666376);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666377);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666378);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666379);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666380);
			}

			// Token: 0x170014A5 RID: 5285
			// (get) Token: 0x060050D0 RID: 20688 RVA: 0x0016EEC4 File Offset: 0x0016D0C4
			public unsafe DateTime DateStart
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014A6 RID: 5286
			// (get) Token: 0x060050D1 RID: 20689 RVA: 0x0016EF00 File Offset: 0x0016D100
			public unsafe DateTime DateEnd
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014A7 RID: 5287
			// (get) Token: 0x060050D2 RID: 20690 RVA: 0x0016EF3C File Offset: 0x0016D13C
			public unsafe TimeSpan DaylightDelta
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014A8 RID: 5288
			// (get) Token: 0x060050D3 RID: 20691 RVA: 0x0016EF78 File Offset: 0x0016D178
			public unsafe TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014A9 RID: 5289
			// (get) Token: 0x060050D4 RID: 20692 RVA: 0x0016EFB4 File Offset: 0x0016D1B4
			public unsafe TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050D5 RID: 20693 RVA: 0x0016EFF0 File Offset: 0x0016D1F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168230, XrefRangeEnd = 168243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(TimeZoneInfo.AdjustmentRule other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050D6 RID: 20694 RVA: 0x0016F040 File Offset: 0x0016D240
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050D7 RID: 20695 RVA: 0x0016F07C File Offset: 0x0016D27C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdjustmentRule()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050D8 RID: 20696 RVA: 0x0016F0B8 File Offset: 0x0016D2B8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 168251, RefRangeEnd = 168255, XrefRangeStart = 168243, XrefRangeEnd = 168251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Public_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
			}

			// Token: 0x060050D9 RID: 20697 RVA: 0x0016F130 File Offset: 0x0016D330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168255, XrefRangeEnd = 168256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffsetDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
			}

			// Token: 0x060050DA RID: 20698 RVA: 0x0016F1B8 File Offset: 0x0016D3B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 168266, RefRangeEnd = 168268, XrefRangeStart = 168256, XrefRangeEnd = 168266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050DB RID: 20699 RVA: 0x0016F224 File Offset: 0x0016D424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168268, XrefRangeEnd = 168269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050DC RID: 20700 RVA: 0x0016F268 File Offset: 0x0016D468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168269, XrefRangeEnd = 168324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050DD RID: 20701 RVA: 0x0016F2C4 File Offset: 0x0016D4C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168324, XrefRangeEnd = 168369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdjustmentRule(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050DE RID: 20702 RVA: 0x0001E404 File Offset: 0x0001C604
			public AdjustmentRule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700149F RID: 5279
			// (get) Token: 0x060050DF RID: 20703 RVA: 0x0016F328 File Offset: 0x0016D528
			// (set) Token: 0x060050E0 RID: 20704 RVA: 0x0001E40D File Offset: 0x0001C60D
			public unsafe DateTime m_dateStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateStart)) = value;
				}
			}

			// Token: 0x170014A0 RID: 5280
			// (get) Token: 0x060050E1 RID: 20705 RVA: 0x0016F350 File Offset: 0x0016D550
			// (set) Token: 0x060050E2 RID: 20706 RVA: 0x0001E428 File Offset: 0x0001C628
			public unsafe DateTime m_dateEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateEnd)) = value;
				}
			}

			// Token: 0x170014A1 RID: 5281
			// (get) Token: 0x060050E3 RID: 20707 RVA: 0x0016F378 File Offset: 0x0016D578
			// (set) Token: 0x060050E4 RID: 20708 RVA: 0x0001E443 File Offset: 0x0001C643
			public unsafe TimeSpan m_daylightDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightDelta)) = value;
				}
			}

			// Token: 0x170014A2 RID: 5282
			// (get) Token: 0x060050E5 RID: 20709 RVA: 0x0016F3A0 File Offset: 0x0016D5A0
			// (set) Token: 0x060050E6 RID: 20710 RVA: 0x0001E45E File Offset: 0x0001C65E
			public unsafe TimeZoneInfo.TransitionTime m_daylightTransitionStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionStart)) = value;
				}
			}

			// Token: 0x170014A3 RID: 5283
			// (get) Token: 0x060050E7 RID: 20711 RVA: 0x0016F3C8 File Offset: 0x0016D5C8
			// (set) Token: 0x060050E8 RID: 20712 RVA: 0x0001E479 File Offset: 0x0001C679
			public unsafe TimeZoneInfo.TransitionTime m_daylightTransitionEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionEnd)) = value;
				}
			}

			// Token: 0x170014A4 RID: 5284
			// (get) Token: 0x060050E9 RID: 20713 RVA: 0x0016F3F0 File Offset: 0x0016D5F0
			// (set) Token: 0x060050EA RID: 20714 RVA: 0x0001E494 File Offset: 0x0001C694
			public unsafe TimeSpan m_baseUtcOffsetDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_baseUtcOffsetDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_baseUtcOffsetDelta)) = value;
				}
			}

			// Token: 0x04004194 RID: 16788
			private static readonly IntPtr NativeFieldInfoPtr_m_dateStart;

			// Token: 0x04004195 RID: 16789
			private static readonly IntPtr NativeFieldInfoPtr_m_dateEnd;

			// Token: 0x04004196 RID: 16790
			private static readonly IntPtr NativeFieldInfoPtr_m_daylightDelta;

			// Token: 0x04004197 RID: 16791
			private static readonly IntPtr NativeFieldInfoPtr_m_daylightTransitionStart;

			// Token: 0x04004198 RID: 16792
			private static readonly IntPtr NativeFieldInfoPtr_m_daylightTransitionEnd;

			// Token: 0x04004199 RID: 16793
			private static readonly IntPtr NativeFieldInfoPtr_m_baseUtcOffsetDelta;

			// Token: 0x0400419A RID: 16794
			private static readonly IntPtr NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0;

			// Token: 0x0400419B RID: 16795
			private static readonly IntPtr NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0;

			// Token: 0x0400419C RID: 16796
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0;

			// Token: 0x0400419D RID: 16797
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0;

			// Token: 0x0400419E RID: 16798
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0;

			// Token: 0x0400419F RID: 16799
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0;

			// Token: 0x040041A0 RID: 16800
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040041A1 RID: 16801
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040041A2 RID: 16802
			private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Public_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0;

			// Token: 0x040041A3 RID: 16803
			private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_0;

			// Token: 0x040041A4 RID: 16804
			private static readonly IntPtr NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0;

			// Token: 0x040041A5 RID: 16805
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x040041A6 RID: 16806
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040041A7 RID: 16807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
		}

		// Token: 0x020005A1 RID: 1441
		[Serializable]
		[StructLayout(2)]
		public struct TransitionTime
		{
			// Token: 0x060050EB RID: 20715 RVA: 0x0016F418 File Offset: 0x0016D618
			// Note: this type is marked as 'beforefieldinit'.
			static TransitionTime()
			{
				Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "TransitionTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr);
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_timeOfDay");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_month");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_week = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_week");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_day");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_dayOfWeek");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_isFixedDateRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_isFixedDateRule");
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666381);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666382);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Week_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666383);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666384);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666385);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666386);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666387);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666388);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666389);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666390);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666391);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666392);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateTransitionTime_Private_Static_TransitionTime_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666393);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666394);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666395);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666396);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666397);
			}

			// Token: 0x170014AA RID: 5290
			// (get) Token: 0x060050EC RID: 20716 RVA: 0x0016F610 File Offset: 0x0016D810
			public unsafe DateTime TimeOfDay
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014AB RID: 5291
			// (get) Token: 0x060050ED RID: 20717 RVA: 0x0016F640 File Offset: 0x0016D840
			public unsafe int Month
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014AC RID: 5292
			// (get) Token: 0x060050EE RID: 20718 RVA: 0x0016F670 File Offset: 0x0016D870
			public unsafe int Week
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Week_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014AD RID: 5293
			// (get) Token: 0x060050EF RID: 20719 RVA: 0x0016F6A0 File Offset: 0x0016D8A0
			public unsafe int Day
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014AE RID: 5294
			// (get) Token: 0x060050F0 RID: 20720 RVA: 0x0016F6D0 File Offset: 0x0016D8D0
			public unsafe DayOfWeek DayOfWeek
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014AF RID: 5295
			// (get) Token: 0x060050F1 RID: 20721 RVA: 0x0016F700 File Offset: 0x0016D900
			public unsafe bool IsFixedDateRule
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050F2 RID: 20722 RVA: 0x0016F730 File Offset: 0x0016D930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168369, XrefRangeEnd = 168372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050F3 RID: 20723 RVA: 0x0016F774 File Offset: 0x0016D974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168372, XrefRangeEnd = 168373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator !=(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050F4 RID: 20724 RVA: 0x0016F7C0 File Offset: 0x0016D9C0
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 168377, RefRangeEnd = 168386, XrefRangeStart = 168373, XrefRangeEnd = 168377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(TimeZoneInfo.TransitionTime other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050F5 RID: 20725 RVA: 0x0016F800 File Offset: 0x0016DA00
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050F6 RID: 20726 RVA: 0x0016F830 File Offset: 0x0016DA30
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 168387, RefRangeEnd = 168394, XrefRangeStart = 168386, XrefRangeEnd = 168387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050F7 RID: 20727 RVA: 0x0016F88C File Offset: 0x0016DA8C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 168395, RefRangeEnd = 168400, XrefRangeStart = 168394, XrefRangeEnd = 168395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050F8 RID: 20728 RVA: 0x0016F8F4 File Offset: 0x0016DAF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168400, XrefRangeEnd = 168401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFixedDateRule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateTransitionTime_Private_Static_TransitionTime_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050F9 RID: 20729 RVA: 0x0016F978 File Offset: 0x0016DB78
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 168404, RefRangeEnd = 168410, XrefRangeStart = 168401, XrefRangeEnd = 168404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050FA RID: 20730 RVA: 0x0016F9E4 File Offset: 0x0016DBE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168410, XrefRangeEnd = 168411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050FB RID: 20731 RVA: 0x0016FA1C File Offset: 0x0016DC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168411, XrefRangeEnd = 168470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050FC RID: 20732 RVA: 0x0016FA6C File Offset: 0x0016DC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168470, XrefRangeEnd = 168517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionTime(SerializationInfo info, StreamingContext context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050FD RID: 20733 RVA: 0x0001E4AF File Offset: 0x0001C6AF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, ref this));
			}

			// Token: 0x040041A8 RID: 16808
			private static readonly IntPtr NativeFieldInfoPtr_m_timeOfDay;

			// Token: 0x040041A9 RID: 16809
			private static readonly IntPtr NativeFieldInfoPtr_m_month;

			// Token: 0x040041AA RID: 16810
			private static readonly IntPtr NativeFieldInfoPtr_m_week;

			// Token: 0x040041AB RID: 16811
			private static readonly IntPtr NativeFieldInfoPtr_m_day;

			// Token: 0x040041AC RID: 16812
			private static readonly IntPtr NativeFieldInfoPtr_m_dayOfWeek;

			// Token: 0x040041AD RID: 16813
			private static readonly IntPtr NativeFieldInfoPtr_m_isFixedDateRule;

			// Token: 0x040041AE RID: 16814
			private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0;

			// Token: 0x040041AF RID: 16815
			private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

			// Token: 0x040041B0 RID: 16816
			private static readonly IntPtr NativeMethodInfoPtr_get_Week_Public_get_Int32_0;

			// Token: 0x040041B1 RID: 16817
			private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

			// Token: 0x040041B2 RID: 16818
			private static readonly IntPtr NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0;

			// Token: 0x040041B3 RID: 16819
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0;

			// Token: 0x040041B4 RID: 16820
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040041B5 RID: 16821
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0;

			// Token: 0x040041B6 RID: 16822
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0;

			// Token: 0x040041B7 RID: 16823
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040041B8 RID: 16824
			private static readonly IntPtr NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0;

			// Token: 0x040041B9 RID: 16825
			private static readonly IntPtr NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0;

			// Token: 0x040041BA RID: 16826
			private static readonly IntPtr NativeMethodInfoPtr_CreateTransitionTime_Private_Static_TransitionTime_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0;

			// Token: 0x040041BB RID: 16827
			private static readonly IntPtr NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0;

			// Token: 0x040041BC RID: 16828
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x040041BD RID: 16829
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040041BE RID: 16830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040041BF RID: 16831
			[FieldOffset(0)]
			public DateTime m_timeOfDay;

			// Token: 0x040041C0 RID: 16832
			[FieldOffset(8)]
			public byte m_month;

			// Token: 0x040041C1 RID: 16833
			[FieldOffset(9)]
			public byte m_week;

			// Token: 0x040041C2 RID: 16834
			[FieldOffset(10)]
			public byte m_day;

			// Token: 0x040041C3 RID: 16835
			[FieldOffset(12)]
			public DayOfWeek m_dayOfWeek;

			// Token: 0x040041C4 RID: 16836
			[FieldOffset(16)]
			[MarshalAs(4)]
			public bool m_isFixedDateRule;
		}

		// Token: 0x020005A2 RID: 1442
		[StructLayout(2)]
		public struct SYSTEMTIME
		{
			// Token: 0x060050FE RID: 20734 RVA: 0x0016FABC File Offset: 0x0016DCBC
			// Note: this type is marked as 'beforefieldinit'.
			static SYSTEMTIME()
			{
				Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "SYSTEMTIME");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr);
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wYear");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wMonth");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wDayOfWeek");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wDay");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wHour");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wMinute");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wSecond");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wMilliseconds");
			}

			// Token: 0x060050FF RID: 20735 RVA: 0x0001E4C1 File Offset: 0x0001C6C1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, ref this));
			}

			// Token: 0x040041C5 RID: 16837
			private static readonly IntPtr NativeFieldInfoPtr_wYear;

			// Token: 0x040041C6 RID: 16838
			private static readonly IntPtr NativeFieldInfoPtr_wMonth;

			// Token: 0x040041C7 RID: 16839
			private static readonly IntPtr NativeFieldInfoPtr_wDayOfWeek;

			// Token: 0x040041C8 RID: 16840
			private static readonly IntPtr NativeFieldInfoPtr_wDay;

			// Token: 0x040041C9 RID: 16841
			private static readonly IntPtr NativeFieldInfoPtr_wHour;

			// Token: 0x040041CA RID: 16842
			private static readonly IntPtr NativeFieldInfoPtr_wMinute;

			// Token: 0x040041CB RID: 16843
			private static readonly IntPtr NativeFieldInfoPtr_wSecond;

			// Token: 0x040041CC RID: 16844
			private static readonly IntPtr NativeFieldInfoPtr_wMilliseconds;

			// Token: 0x040041CD RID: 16845
			[FieldOffset(0)]
			public ushort wYear;

			// Token: 0x040041CE RID: 16846
			[FieldOffset(2)]
			public ushort wMonth;

			// Token: 0x040041CF RID: 16847
			[FieldOffset(4)]
			public ushort wDayOfWeek;

			// Token: 0x040041D0 RID: 16848
			[FieldOffset(6)]
			public ushort wDay;

			// Token: 0x040041D1 RID: 16849
			[FieldOffset(8)]
			public ushort wHour;

			// Token: 0x040041D2 RID: 16850
			[FieldOffset(10)]
			public ushort wMinute;

			// Token: 0x040041D3 RID: 16851
			[FieldOffset(12)]
			public ushort wSecond;

			// Token: 0x040041D4 RID: 16852
			[FieldOffset(14)]
			public ushort wMilliseconds;
		}

		// Token: 0x020005A3 RID: 1443
		[StructLayout(3, CharSet = 3)]
		public sealed class TIME_ZONE_INFORMATION : ValueType
		{
			// Token: 0x06005100 RID: 20736 RVA: 0x0016FB88 File Offset: 0x0016DD88
			// Note: this type is marked as 'beforefieldinit'.
			static TIME_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "TIME_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr);
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "Bias");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardName");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardDate");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardBias");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightName");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightDate");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightBias");
			}

			// Token: 0x06005101 RID: 20737 RVA: 0x0001E4D3 File Offset: 0x0001C6D3
			public TIME_ZONE_INFORMATION(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005102 RID: 20738 RVA: 0x0001E4DC File Offset: 0x0001C6DC
			public TIME_ZONE_INFORMATION()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr))
			{
			}

			// Token: 0x170014B0 RID: 5296
			// (get) Token: 0x06005103 RID: 20739 RVA: 0x0016FC40 File Offset: 0x0016DE40
			// (set) Token: 0x06005104 RID: 20740 RVA: 0x0001E4EE File Offset: 0x0001C6EE
			public unsafe int Bias
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_Bias);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_Bias)) = value;
				}
			}

			// Token: 0x170014B1 RID: 5297
			// (get) Token: 0x06005105 RID: 20741 RVA: 0x0016FC68 File Offset: 0x0016DE68
			// (set) Token: 0x06005106 RID: 20742 RVA: 0x0001E509 File Offset: 0x0001C709
			public unsafe string StandardName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014B2 RID: 5298
			// (get) Token: 0x06005107 RID: 20743 RVA: 0x0016FC90 File Offset: 0x0016DE90
			// (set) Token: 0x06005108 RID: 20744 RVA: 0x0001E528 File Offset: 0x0001C728
			public unsafe TimeZoneInfo.SYSTEMTIME StandardDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate)) = value;
				}
			}

			// Token: 0x170014B3 RID: 5299
			// (get) Token: 0x06005109 RID: 20745 RVA: 0x0016FCB8 File Offset: 0x0016DEB8
			// (set) Token: 0x0600510A RID: 20746 RVA: 0x0001E543 File Offset: 0x0001C743
			public unsafe int StandardBias
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias)) = value;
				}
			}

			// Token: 0x170014B4 RID: 5300
			// (get) Token: 0x0600510B RID: 20747 RVA: 0x0016FCE0 File Offset: 0x0016DEE0
			// (set) Token: 0x0600510C RID: 20748 RVA: 0x0001E55E File Offset: 0x0001C75E
			public unsafe string DaylightName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014B5 RID: 5301
			// (get) Token: 0x0600510D RID: 20749 RVA: 0x0016FD08 File Offset: 0x0016DF08
			// (set) Token: 0x0600510E RID: 20750 RVA: 0x0001E57D File Offset: 0x0001C77D
			public unsafe TimeZoneInfo.SYSTEMTIME DaylightDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate)) = value;
				}
			}

			// Token: 0x170014B6 RID: 5302
			// (get) Token: 0x0600510F RID: 20751 RVA: 0x0016FD30 File Offset: 0x0016DF30
			// (set) Token: 0x06005110 RID: 20752 RVA: 0x0001E598 File Offset: 0x0001C798
			public unsafe int DaylightBias
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias)) = value;
				}
			}

			// Token: 0x040041D5 RID: 16853
			private static readonly IntPtr NativeFieldInfoPtr_Bias;

			// Token: 0x040041D6 RID: 16854
			private static readonly IntPtr NativeFieldInfoPtr_StandardName;

			// Token: 0x040041D7 RID: 16855
			private static readonly IntPtr NativeFieldInfoPtr_StandardDate;

			// Token: 0x040041D8 RID: 16856
			private static readonly IntPtr NativeFieldInfoPtr_StandardBias;

			// Token: 0x040041D9 RID: 16857
			private static readonly IntPtr NativeFieldInfoPtr_DaylightName;

			// Token: 0x040041DA RID: 16858
			private static readonly IntPtr NativeFieldInfoPtr_DaylightDate;

			// Token: 0x040041DB RID: 16859
			private static readonly IntPtr NativeFieldInfoPtr_DaylightBias;
		}

		// Token: 0x020005A4 RID: 1444
		[StructLayout(3, CharSet = 3)]
		public sealed class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
		{
			// Token: 0x06005111 RID: 20753 RVA: 0x0016FD58 File Offset: 0x0016DF58
			// Note: this type is marked as 'beforefieldinit'.
			static DYNAMIC_TIME_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "DYNAMIC_TIME_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr);
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TZI");
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TimeZoneKeyName");
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "DynamicDaylightTimeDisabled");
			}

			// Token: 0x06005112 RID: 20754 RVA: 0x0001E5B3 File Offset: 0x0001C7B3
			public DYNAMIC_TIME_ZONE_INFORMATION(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005113 RID: 20755 RVA: 0x0001E5BC File Offset: 0x0001C7BC
			public DYNAMIC_TIME_ZONE_INFORMATION()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr))
			{
			}

			// Token: 0x170014B7 RID: 5303
			// (get) Token: 0x06005114 RID: 20756 RVA: 0x0016FDC0 File Offset: 0x0016DFC0
			// (set) Token: 0x06005115 RID: 20757 RVA: 0x0001E5CE File Offset: 0x0001C7CE
			public TimeZoneInfo.TIME_ZONE_INFORMATION TZI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI);
					return new TimeZoneInfo.TIME_ZONE_INFORMATION(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170014B8 RID: 5304
			// (get) Token: 0x06005116 RID: 20758 RVA: 0x0016FDF0 File Offset: 0x0016DFF0
			// (set) Token: 0x06005117 RID: 20759 RVA: 0x0001E5FC File Offset: 0x0001C7FC
			public unsafe string TimeZoneKeyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014B9 RID: 5305
			// (get) Token: 0x06005118 RID: 20760 RVA: 0x0016FE18 File Offset: 0x0016E018
			// (set) Token: 0x06005119 RID: 20761 RVA: 0x0001E61B File Offset: 0x0001C81B
			public unsafe byte DynamicDaylightTimeDisabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled)) = value;
				}
			}

			// Token: 0x040041DC RID: 16860
			private static readonly IntPtr NativeFieldInfoPtr_TZI;

			// Token: 0x040041DD RID: 16861
			private static readonly IntPtr NativeFieldInfoPtr_TimeZoneKeyName;

			// Token: 0x040041DE RID: 16862
			private static readonly IntPtr NativeFieldInfoPtr_DynamicDaylightTimeDisabled;
		}

		// Token: 0x020005A5 RID: 1445
		[ObfuscatedName("System.TimeZoneInfo+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600511A RID: 20762 RVA: 0x0016FE40 File Offset: 0x0016E040
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr);
				TimeZoneInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, "<>9");
				TimeZoneInfo.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, "<>9__19_0");
				TimeZoneInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100666399);
				TimeZoneInfo.__c.NativeMethodInfoPtr__CreateLocalUnity_b__19_0_Internal_Int32_AdjustmentRule_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100666400);
			}

			// Token: 0x0600511B RID: 20763 RVA: 0x0016FEBC File Offset: 0x0016E0BC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600511C RID: 20764 RVA: 0x0016FEF8 File Offset: 0x0016E0F8
			[CallerCount(0)]
			public unsafe int _CreateLocalUnity_b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr__CreateLocalUnity_b__19_0_Internal_Int32_AdjustmentRule_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600511D RID: 20765 RVA: 0x0001E636 File Offset: 0x0001C836
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014BA RID: 5306
			// (get) Token: 0x0600511E RID: 20766 RVA: 0x0016FF58 File Offset: 0x0016E158
			// (set) Token: 0x0600511F RID: 20767 RVA: 0x0001E63F File Offset: 0x0001C83F
			public unsafe static TimeZoneInfo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014BB RID: 5307
			// (get) Token: 0x06005120 RID: 20768 RVA: 0x0016FF80 File Offset: 0x0016E180
			// (set) Token: 0x06005121 RID: 20769 RVA: 0x0001E651 File Offset: 0x0001C851
			public unsafe static Comparison<TimeZoneInfo.AdjustmentRule> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TimeZoneInfo.AdjustmentRule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041DF RID: 16863
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040041E0 RID: 16864
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x040041E1 RID: 16865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040041E2 RID: 16866
			private static readonly IntPtr NativeMethodInfoPtr__CreateLocalUnity_b__19_0_Internal_Int32_AdjustmentRule_AdjustmentRule_0;
		}
	}
}
