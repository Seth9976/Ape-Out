using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000AB RID: 171
	public static class DateTimeParse : Object
	{
		// Token: 0x06000C28 RID: 3112 RVA: 0x0005A77C File Offset: 0x0005897C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeParse()
		{
			Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeParse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr);
			DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "m_hebrewNumberParser");
			DateTimeParse.NativeFieldInfoPtr_dateParsingStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "dateParsingStates");
			DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_String_String_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665358);
			DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_String_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665359);
			DateTimeParse.NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665360);
			DateTimeParse.NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665361);
			DateTimeParse.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665362);
			DateTimeParse.NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665363);
			DateTimeParse.NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665364);
			DateTimeParse.NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665365);
			DateTimeParse.NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665366);
			DateTimeParse.NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665367);
			DateTimeParse.NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665368);
			DateTimeParse.NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665369);
			DateTimeParse.NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665370);
			DateTimeParse.NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665371);
			DateTimeParse.NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665372);
			DateTimeParse.NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665373);
			DateTimeParse.NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665374);
			DateTimeParse.NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665375);
			DateTimeParse.NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665376);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665377);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665378);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665379);
			DateTimeParse.NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665380);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665381);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665382);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665383);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665384);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665385);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665386);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665387);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665388);
			DateTimeParse.NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665389);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665390);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665391);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665392);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665393);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665394);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665395);
			DateTimeParse.NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665396);
			DateTimeParse.NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665397);
			DateTimeParse.NativeMethodInfoPtr_ProcessTerminaltState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665398);
			DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_String_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665399);
			DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665400);
			DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665401);
			DateTimeParse.NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665402);
			DateTimeParse.NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665403);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665404);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665405);
			DateTimeParse.NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665406);
			DateTimeParse.NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665407);
			DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665408);
			DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665409);
			DateTimeParse.NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665410);
			DateTimeParse.NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665411);
			DateTimeParse.NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665412);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665413);
			DateTimeParse.NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665414);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665415);
			DateTimeParse.NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665416);
			DateTimeParse.NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665417);
			DateTimeParse.NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665418);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665419);
			DateTimeParse.NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665420);
			DateTimeParse.NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665421);
			DateTimeParse.NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665422);
			DateTimeParse.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665423);
			DateTimeParse.NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665424);
			DateTimeParse.NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_String_Int32_StringBuilder_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665425);
			DateTimeParse.NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_String_String_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665426);
			DateTimeParse.NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665427);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0005AD4C File Offset: 0x00058F4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155537, RefRangeEnd = 155540, XrefRangeStart = 155524, XrefRangeEnd = 155537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_String_String_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0005ADC0 File Offset: 0x00058FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155540, XrefRangeEnd = 155561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_String_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0005AE4C File Offset: 0x0005904C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155567, RefRangeEnd = 155571, XrefRangeStart = 155561, XrefRangeEnd = 155567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchWord(ref __DTString str, string target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0005AEA8 File Offset: 0x000590A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155571, XrefRangeEnd = 155582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneName(ref __DTString str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0005AEF0 File Offset: 0x000590F0
		[CallerCount(0)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0005AF30 File Offset: 0x00059130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155586, RefRangeEnd = 155588, XrefRangeStart = 155582, XrefRangeEnd = 155586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseFraction(ref __DTString str, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0005AF88 File Offset: 0x00059188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155601, RefRangeEnd = 155604, XrefRangeStart = 155588, XrefRangeEnd = 155601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseTimeZone(ref __DTString str, ref TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0005AFE0 File Offset: 0x000591E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155617, RefRangeEnd = 155619, XrefRangeStart = 155604, XrefRangeEnd = 155617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0005B040 File Offset: 0x00059240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155756, RefRangeEnd = 155757, XrefRangeStart = 155619, XrefRangeEnd = 155756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dtok;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0005B104 File Offset: 0x00059304
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155758, RefRangeEnd = 155761, XrefRangeStart = 155757, XrefRangeEnd = 155758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VerifyValidPunctuation(ref __DTString str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0005B14C File Offset: 0x0005934C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 155769, RefRangeEnd = 155774, XrefRangeStart = 155761, XrefRangeEnd = 155769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(datePattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0005B1B0 File Offset: 0x000593B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155779, RefRangeEnd = 155781, XrefRangeStart = 155774, XrefRangeEnd = 155779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0005B214 File Offset: 0x00059414
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 155787, RefRangeEnd = 155792, XrefRangeStart = 155781, XrefRangeEnd = 155787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0005B278 File Offset: 0x00059478
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 155793, RefRangeEnd = 155809, XrefRangeStart = 155792, XrefRangeEnd = 155793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &adjustedYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0005B2DC File Offset: 0x000594DC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 155809, RefRangeEnd = 155823, XrefRangeStart = 155809, XrefRangeEnd = 155809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0005B350 File Offset: 0x00059550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155823, XrefRangeEnd = 155827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0005B3C4 File Offset: 0x000595C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155827, XrefRangeEnd = 155831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0005B438 File Offset: 0x00059638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155831, XrefRangeEnd = 155835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0005B4AC File Offset: 0x000596AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155839, RefRangeEnd = 155841, XrefRangeStart = 155835, XrefRangeEnd = 155839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0005B4F8 File Offset: 0x000596F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155857, RefRangeEnd = 155859, XrefRangeStart = 155841, XrefRangeEnd = 155857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0005B570 File Offset: 0x00059770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155904, RefRangeEnd = 155905, XrefRangeStart = 155859, XrefRangeEnd = 155904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0005B5D8 File Offset: 0x000597D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155925, RefRangeEnd = 155926, XrefRangeStart = 155905, XrefRangeEnd = 155925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0005B650 File Offset: 0x00059850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155926, XrefRangeEnd = 155935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0005B6B8 File Offset: 0x000598B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155955, RefRangeEnd = 155956, XrefRangeStart = 155935, XrefRangeEnd = 155955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0005B730 File Offset: 0x00059930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155990, RefRangeEnd = 155992, XrefRangeStart = 155956, XrefRangeEnd = 155990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0005B798 File Offset: 0x00059998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156004, RefRangeEnd = 156005, XrefRangeStart = 155992, XrefRangeEnd = 156004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0005B800 File Offset: 0x00059A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156020, RefRangeEnd = 156021, XrefRangeStart = 156005, XrefRangeEnd = 156020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0005B868 File Offset: 0x00059A68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156026, RefRangeEnd = 156028, XrefRangeStart = 156021, XrefRangeEnd = 156026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0005B8D0 File Offset: 0x00059AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156028, XrefRangeEnd = 156033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0005B938 File Offset: 0x00059B38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156038, RefRangeEnd = 156040, XrefRangeStart = 156033, XrefRangeEnd = 156038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0005B9A0 File Offset: 0x00059BA0
		[CallerCount(0)]
		public unsafe static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0005B9E4 File Offset: 0x00059BE4
		[CallerCount(0)]
		public unsafe static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0005BA30 File Offset: 0x00059C30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156041, RefRangeEnd = 156043, XrefRangeStart = 156040, XrefRangeEnd = 156041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0005BA98 File Offset: 0x00059C98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156044, RefRangeEnd = 156046, XrefRangeStart = 156043, XrefRangeEnd = 156044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0005BB00 File Offset: 0x00059D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156047, RefRangeEnd = 156049, XrefRangeStart = 156046, XrefRangeEnd = 156047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0005BB68 File Offset: 0x00059D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156049, XrefRangeEnd = 156050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0005BBC0 File Offset: 0x00059DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156050, XrefRangeEnd = 156055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0005BC18 File Offset: 0x00059E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156085, RefRangeEnd = 156086, XrefRangeStart = 156055, XrefRangeEnd = 156085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0005BC80 File Offset: 0x00059E80
		[CallerCount(0)]
		public unsafe static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dtok;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0005BCE4 File Offset: 0x00059EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156137, RefRangeEnd = 156138, XrefRangeStart = 156086, XrefRangeEnd = 156137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0005BD68 File Offset: 0x00059F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156215, RefRangeEnd = 156216, XrefRangeStart = 156138, XrefRangeEnd = 156215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessTerminaltState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0005BDEC File Offset: 0x00059FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156216, XrefRangeEnd = 156220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_String_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0005BE50 File Offset: 0x0005A050
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 156229, RefRangeEnd = 156233, XrefRangeStart = 156220, XrefRangeEnd = 156229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0005BEC0 File Offset: 0x0005A0C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 156308, RefRangeEnd = 156312, XrefRangeStart = 156233, XrefRangeEnd = 156308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0005BF3C File Offset: 0x0005A13C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156326, RefRangeEnd = 156328, XrefRangeStart = 156312, XrefRangeEnd = 156326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTimeOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0005BFA0 File Offset: 0x0005A1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156328, XrefRangeEnd = 156354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156356, RefRangeEnd = 156357, XrefRangeStart = 156354, XrefRangeEnd = 156356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0005C040 File Offset: 0x0005A240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156357, XrefRangeEnd = 156371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTimeOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0005C098 File Offset: 0x0005A298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156446, RefRangeEnd = 156447, XrefRangeStart = 156371, XrefRangeEnd = 156446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &raw;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0005C114 File Offset: 0x0005A314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156447, XrefRangeEnd = 156453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0005C178 File Offset: 0x0005A378
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 156459, RefRangeEnd = 156466, XrefRangeStart = 156453, XrefRangeEnd = 156459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseDigits(ref __DTString str, int digitLen, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0005C1DC File Offset: 0x0005A3DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 156469, RefRangeEnd = 156476, XrefRangeStart = 156466, XrefRangeEnd = 156469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDigitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDigitLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0005C250 File Offset: 0x0005A450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156483, RefRangeEnd = 156484, XrefRangeStart = 156476, XrefRangeEnd = 156483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDigitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0005C2B4 File Offset: 0x0005A4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156484, XrefRangeEnd = 156486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseSign(ref __DTString str, ref bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0005C30C File Offset: 0x0005A50C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156509, RefRangeEnd = 156511, XrefRangeStart = 156486, XrefRangeEnd = 156509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0005C370 File Offset: 0x0005A570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156523, RefRangeEnd = 156524, XrefRangeStart = 156511, XrefRangeEnd = 156523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0005C3D8 File Offset: 0x0005A5D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156548, RefRangeEnd = 156549, XrefRangeStart = 156524, XrefRangeEnd = 156548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0005C440 File Offset: 0x0005A640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156549, XrefRangeEnd = 156556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0005C4A8 File Offset: 0x0005A6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156556, XrefRangeEnd = 156563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0005C510 File Offset: 0x0005A710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156570, RefRangeEnd = 156571, XrefRangeStart = 156563, XrefRangeEnd = 156570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0005C578 File Offset: 0x0005A778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156572, RefRangeEnd = 156573, XrefRangeStart = 156571, XrefRangeEnd = 156572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0005C5E0 File Offset: 0x0005A7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156573, XrefRangeEnd = 156576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0005C648 File Offset: 0x0005A848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156583, RefRangeEnd = 156584, XrefRangeStart = 156576, XrefRangeEnd = 156583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternChar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0005C6BC File Offset: 0x0005A8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156592, RefRangeEnd = 156593, XrefRangeStart = 156584, XrefRangeEnd = 156592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0005C714 File Offset: 0x0005A914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156598, RefRangeEnd = 156599, XrefRangeStart = 156593, XrefRangeEnd = 156598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cal);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cal = ((intPtr4 == 0) ? null : new Calendar(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0005C794 File Offset: 0x0005A994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156599, XrefRangeEnd = 156668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseInfo));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0005C82C File Offset: 0x0005AA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156908, RefRangeEnd = 156909, XrefRangeStart = 156668, XrefRangeEnd = 156908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseInfo));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0005C8D0 File Offset: 0x0005AAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156909, XrefRangeEnd = 156911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_String_Int32_StringBuilder_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0005C940 File Offset: 0x0005AB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156919, RefRangeEnd = 156921, XrefRangeStart = 156911, XrefRangeEnd = 156919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatParam);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_String_String_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0005C9CC File Offset: 0x0005ABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156921, XrefRangeEnd = 156924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetDateTimeParseException(ref DateTimeResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00005186 File Offset: 0x00003386
		public DateTimeParse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0005CA18 File Offset: 0x0005AC18
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x0000518F File Offset: 0x0000338F
		public unsafe static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0005CA40 File Offset: 0x0005AC40
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x000051A1 File Offset: 0x000033A1
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<DateTimeParse.DS>> dateParsingStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParse.NativeFieldInfoPtr_dateParsingStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<DateTimeParse.DS>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParse.NativeFieldInfoPtr_dateParsingStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_m_hebrewNumberParser;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_dateParsingStates;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_String_String_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_String_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminaltState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_DateTime_String_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_Boolean_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_String_Int32_StringBuilder_byref_Int32_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_String_String_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0;

		// Token: 0x02000595 RID: 1429
		public sealed class MatchNumberDelegate : MulticastDelegate
		{
			// Token: 0x0600509B RID: 20635 RVA: 0x0016E084 File Offset: 0x0016C284
			// Note: this type is marked as 'beforefieldinit'.
			static MatchNumberDelegate()
			{
				Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "MatchNumberDelegate");
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665429);
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665430);
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref___DTString_Int32_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665431);
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref___DTString_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665432);
			}

			// Token: 0x0600509C RID: 20636 RVA: 0x0016E0F8 File Offset: 0x0016C2F8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchNumberDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600509D RID: 20637 RVA: 0x0016E154 File Offset: 0x0016C354
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 155511, RefRangeEnd = 155514, XrefRangeStart = 155511, XrefRangeEnd = 155511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Invoke(ref __DTString str, int digitLen, out int result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600509E RID: 20638 RVA: 0x0016E1C4 File Offset: 0x0016C3C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155514, XrefRangeEnd = 155523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref___DTString_Int32_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600509F RID: 20639 RVA: 0x0016E25C File Offset: 0x0016C45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155523, XrefRangeEnd = 155524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(ref __DTString str, out int result, IAsyncResult __result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref___DTString_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050A0 RID: 20640 RVA: 0x0001E283 File Offset: 0x0001C483
			public MatchNumberDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400410A RID: 16650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400410B RID: 16651
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0;

			// Token: 0x0400410C RID: 16652
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref___DTString_Int32_byref_Int32_AsyncCallback_Object_0;

			// Token: 0x0400410D RID: 16653
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref___DTString_byref_Int32_IAsyncResult_0;
		}

		// Token: 0x02000596 RID: 1430
		[OriginalName("mscorlib.dll", "", "DTT")]
		public enum DTT
		{
			// Token: 0x0400410F RID: 16655
			End,
			// Token: 0x04004110 RID: 16656
			NumEnd,
			// Token: 0x04004111 RID: 16657
			NumAmpm,
			// Token: 0x04004112 RID: 16658
			NumSpace,
			// Token: 0x04004113 RID: 16659
			NumDatesep,
			// Token: 0x04004114 RID: 16660
			NumTimesep,
			// Token: 0x04004115 RID: 16661
			MonthEnd,
			// Token: 0x04004116 RID: 16662
			MonthSpace,
			// Token: 0x04004117 RID: 16663
			MonthDatesep,
			// Token: 0x04004118 RID: 16664
			NumDatesuff,
			// Token: 0x04004119 RID: 16665
			NumTimesuff,
			// Token: 0x0400411A RID: 16666
			DayOfWeek,
			// Token: 0x0400411B RID: 16667
			YearSpace,
			// Token: 0x0400411C RID: 16668
			YearDateSep,
			// Token: 0x0400411D RID: 16669
			YearEnd,
			// Token: 0x0400411E RID: 16670
			TimeZone,
			// Token: 0x0400411F RID: 16671
			Era,
			// Token: 0x04004120 RID: 16672
			NumUTCTimeMark,
			// Token: 0x04004121 RID: 16673
			Unk,
			// Token: 0x04004122 RID: 16674
			NumLocalTimeMark,
			// Token: 0x04004123 RID: 16675
			Max
		}

		// Token: 0x02000597 RID: 1431
		[OriginalName("mscorlib.dll", "", "TM")]
		public enum TM
		{
			// Token: 0x04004125 RID: 16677
			NotSet = -1,
			// Token: 0x04004126 RID: 16678
			AM,
			// Token: 0x04004127 RID: 16679
			PM
		}

		// Token: 0x02000598 RID: 1432
		[OriginalName("mscorlib.dll", "", "DS")]
		public enum DS
		{
			// Token: 0x04004129 RID: 16681
			BEGIN,
			// Token: 0x0400412A RID: 16682
			N,
			// Token: 0x0400412B RID: 16683
			NN,
			// Token: 0x0400412C RID: 16684
			D_Nd,
			// Token: 0x0400412D RID: 16685
			D_NN,
			// Token: 0x0400412E RID: 16686
			D_NNd,
			// Token: 0x0400412F RID: 16687
			D_M,
			// Token: 0x04004130 RID: 16688
			D_MN,
			// Token: 0x04004131 RID: 16689
			D_NM,
			// Token: 0x04004132 RID: 16690
			D_MNd,
			// Token: 0x04004133 RID: 16691
			D_NDS,
			// Token: 0x04004134 RID: 16692
			D_Y,
			// Token: 0x04004135 RID: 16693
			D_YN,
			// Token: 0x04004136 RID: 16694
			D_YNd,
			// Token: 0x04004137 RID: 16695
			D_YM,
			// Token: 0x04004138 RID: 16696
			D_YMd,
			// Token: 0x04004139 RID: 16697
			D_S,
			// Token: 0x0400413A RID: 16698
			T_S,
			// Token: 0x0400413B RID: 16699
			T_Nt,
			// Token: 0x0400413C RID: 16700
			T_NNt,
			// Token: 0x0400413D RID: 16701
			ERROR,
			// Token: 0x0400413E RID: 16702
			DX_NN,
			// Token: 0x0400413F RID: 16703
			DX_NNN,
			// Token: 0x04004140 RID: 16704
			DX_MN,
			// Token: 0x04004141 RID: 16705
			DX_NM,
			// Token: 0x04004142 RID: 16706
			DX_MNN,
			// Token: 0x04004143 RID: 16707
			DX_DS,
			// Token: 0x04004144 RID: 16708
			DX_DSN,
			// Token: 0x04004145 RID: 16709
			DX_NDS,
			// Token: 0x04004146 RID: 16710
			DX_NNDS,
			// Token: 0x04004147 RID: 16711
			DX_YNN,
			// Token: 0x04004148 RID: 16712
			DX_YMN,
			// Token: 0x04004149 RID: 16713
			DX_YN,
			// Token: 0x0400414A RID: 16714
			DX_YM,
			// Token: 0x0400414B RID: 16715
			TX_N,
			// Token: 0x0400414C RID: 16716
			TX_NN,
			// Token: 0x0400414D RID: 16717
			TX_NNN,
			// Token: 0x0400414E RID: 16718
			TX_TS,
			// Token: 0x0400414F RID: 16719
			DX_NNY
		}
	}
}
