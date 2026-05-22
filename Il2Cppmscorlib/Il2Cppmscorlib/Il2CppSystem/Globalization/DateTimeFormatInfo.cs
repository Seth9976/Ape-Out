using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000233 RID: 563
	[Serializable]
	public sealed class DateTimeFormatInfo : Object
	{
		// Token: 0x06002546 RID: 9542 RVA: 0x000CB1D4 File Offset: 0x000C93D4
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormatInfo()
		{
			Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr);
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_cultureData");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_name");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_langName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_langName");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_compareInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_cultureInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "amDesignator");
			DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "pmDesignator");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalShortTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalLongTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "timeSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthDayPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateTimeOffsetPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "rfc1123Pattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "sortableDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "universalSortableDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendar");
			DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "firstDayOfWeek");
			DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendarWeekRule");
			DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "fullDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedDayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_superShortDayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_dayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_monthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "genitiveMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_genitiveAbbreviatedMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "leapYearMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longDatePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortDatePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "yearMonthPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allYearMonthPatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortDatePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongDatePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortTimePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongTimePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_eraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEnglishEraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "optionalCalendars");
			DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "DEFAULT_ALL_DATETIMES_SIZE");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_isReadOnly");
			DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "formatFlags");
			DateTimeFormatInfo.NativeFieldInfoPtr_preferExistingTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "preferExistingTokens");
			DateTimeFormatInfo.NativeFieldInfoPtr_CultureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CultureID");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_useUserOverride");
			DateTimeFormatInfo.NativeFieldInfoPtr_bUseCalendarInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "bUseCalendarInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_nDataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "nDataItem");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_isDefaultCalendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_isDefaultCalendar");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_calendarNativeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_calendarNativeNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_dateWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_dateWords");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_fullTimeSpanPositivePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_fullTimeSpanNegativePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "InvalidDateTimeStyles");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_dtfiTokenHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_dtfiTokenHash");
			DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "TOKEN_HASH_SIZE");
			DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "SECOND_PRIME");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparatorOrTimeZoneOffset");
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantDateSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantTimeSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorablePeriod");
			DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorableComma");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKYearSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMonthSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKDaySuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanYearSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMonthSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanDaySuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMinuteSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanSecondSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "ChineseHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMinuteSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKSecondSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "LocalTimeMark");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "JapaneseLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "EnglishLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_jajpDTFI");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_zhtwDTFI");
			DateTimeFormatInfo.NativeMethodInfoPtr_InitPreferExistingTokens_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669527);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CultureName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669528);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669529);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LanguageName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669530);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669531);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669532);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669533);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669534);
			DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669535);
			DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669536);
			DateTimeFormatInfo.NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669537);
			DateTimeFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669538);
			DateTimeFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669539);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669540);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669541);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669542);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669543);
			DateTimeFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669544);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669545);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669546);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669547);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669548);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669549);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669550);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669551);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669552);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669553);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669554);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669555);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669556);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_LongDatePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669557);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669558);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_LongTimePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669559);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669560);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669561);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669562);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669563);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortDatePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669564);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669565);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortTimePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669566);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669567);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669568);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669569);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669570);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669571);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669572);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669573);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_YearMonthPattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669574);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669575);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669576);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669577);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669578);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669579);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669580);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669581);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669582);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669583);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669584);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669585);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669586);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669587);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669588);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669589);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669590);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669591);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669592);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669593);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669594);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669595);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669596);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669597);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669598);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669599);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669600);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669601);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669602);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669603);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669604);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669605);
			DateTimeFormatInfo.NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669606);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669607);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669608);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669609);
			DateTimeFormatInfo.NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669610);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669611);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669612);
			DateTimeFormatInfo.NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669613);
			DateTimeFormatInfo.NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669614);
			DateTimeFormatInfo.NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669615);
			DateTimeFormatInfo.NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669616);
			DateTimeFormatInfo.NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669617);
			DateTimeFormatInfo.NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669618);
			DateTimeFormatInfo.NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669619);
			DateTimeFormatInfo.NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669620);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000CBFEC File Offset: 0x000CA1EC
		[CallerCount(0)]
		public unsafe static bool InitPreferExistingTokens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InitPreferExistingTokens_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x000CC01C File Offset: 0x000CA21C
		public unsafe string CultureName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 194547, RefRangeEnd = 194550, XrefRangeStart = 194547, XrefRangeEnd = 194547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CultureName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000CC054 File Offset: 0x000CA254
		public unsafe CultureInfo Culture
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 194555, RefRangeEnd = 194560, XrefRangeStart = 194550, XrefRangeEnd = 194555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000CC094 File Offset: 0x000CA294
		public unsafe string LanguageName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 194560, RefRangeEnd = 194565, XrefRangeStart = 194560, XrefRangeEnd = 194560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LanguageName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000CC0CC File Offset: 0x000CA2CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194566, RefRangeEnd = 194569, XrefRangeStart = 194565, XrefRangeEnd = 194566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedDayOfWeekNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000CC10C File Offset: 0x000CA30C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194570, RefRangeEnd = 194573, XrefRangeStart = 194569, XrefRangeEnd = 194570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetDayOfWeekNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000CC14C File Offset: 0x000CA34C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194574, RefRangeEnd = 194577, XrefRangeStart = 194573, XrefRangeEnd = 194574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000CC18C File Offset: 0x000CA38C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194578, RefRangeEnd = 194581, XrefRangeStart = 194577, XrefRangeEnd = 194578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000CC1CC File Offset: 0x000CA3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194581, XrefRangeEnd = 194595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000CC208 File Offset: 0x000CA408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194596, RefRangeEnd = 194599, XrefRangeStart = 194595, XrefRangeEnd = 194596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfo(CultureData cultureData, Calendar cal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000CC268 File Offset: 0x000CA468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194606, RefRangeEnd = 194608, XrefRangeStart = 194599, XrefRangeEnd = 194606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeOverridableProperties(CultureData cultureData, int calendarID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000CC2B8 File Offset: 0x000CA4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194608, XrefRangeEnd = 194641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000CC300 File Offset: 0x000CA500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194641, XrefRangeEnd = 194664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000CC348 File Offset: 0x000CA548
		public unsafe static DateTimeFormatInfo InvariantInfo
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 194689, RefRangeEnd = 194702, XrefRangeStart = 194664, XrefRangeEnd = 194689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x000CC37C File Offset: 0x000CA57C
		public unsafe static DateTimeFormatInfo CurrentInfo
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 194712, RefRangeEnd = 194717, XrefRangeStart = 194702, XrefRangeEnd = 194712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000CC3B0 File Offset: 0x000CA5B0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 194730, RefRangeEnd = 194741, XrefRangeStart = 194717, XrefRangeEnd = 194730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetInstance(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000CC3F4 File Offset: 0x000CA5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194741, XrefRangeEnd = 194747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000CC444 File Offset: 0x000CA644
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194752, RefRangeEnd = 194755, XrefRangeStart = 194747, XrefRangeEnd = 194752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000CC484 File Offset: 0x000CA684
		public unsafe string AMDesignator
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000CC4BC File Offset: 0x000CA6BC
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x000CC4FC File Offset: 0x000CA6FC
		public unsafe Calendar Calendar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 194788, RefRangeEnd = 194793, XrefRangeStart = 194755, XrefRangeEnd = 194788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000CC540 File Offset: 0x000CA740
		public unsafe Il2CppStructArray<int> OptionalCalendars
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 194794, RefRangeEnd = 194797, XrefRangeStart = 194793, XrefRangeEnd = 194794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x000CC580 File Offset: 0x000CA780
		public unsafe Il2CppStringArray EraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194797, XrefRangeEnd = 194798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000CC5C0 File Offset: 0x000CA7C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 194799, RefRangeEnd = 194805, XrefRangeStart = 194798, XrefRangeEnd = 194799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEraName(int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x000CC604 File Offset: 0x000CA804
		public unsafe Il2CppStringArray AbbreviatedEraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194805, XrefRangeEnd = 194806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000CC644 File Offset: 0x000CA844
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194807, RefRangeEnd = 194810, XrefRangeStart = 194806, XrefRangeEnd = 194807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedEraName(int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x000CC688 File Offset: 0x000CA888
		public unsafe Il2CppStringArray AbbreviatedEnglishEraNames
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 194811, RefRangeEnd = 194815, XrefRangeStart = 194810, XrefRangeEnd = 194811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000CC6C8 File Offset: 0x000CA8C8
		public unsafe string DateSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x000CC700 File Offset: 0x000CA900
		public unsafe string FullDateTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194815, XrefRangeEnd = 194820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000CC738 File Offset: 0x000CA938
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x000CC770 File Offset: 0x000CA970
		public unsafe string LongDatePattern
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 194821, RefRangeEnd = 194824, XrefRangeStart = 194820, XrefRangeEnd = 194821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194824, XrefRangeEnd = 194842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_LongDatePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000CC7B4 File Offset: 0x000CA9B4
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x000CC7EC File Offset: 0x000CA9EC
		public unsafe string LongTimePattern
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 194843, RefRangeEnd = 194851, XrefRangeStart = 194842, XrefRangeEnd = 194843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194851, XrefRangeEnd = 194871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_LongTimePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000CC830 File Offset: 0x000CAA30
		public unsafe string MonthDayPattern
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 194872, RefRangeEnd = 194879, XrefRangeStart = 194871, XrefRangeEnd = 194872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x000CC868 File Offset: 0x000CAA68
		public unsafe string PMDesignator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000CC8A0 File Offset: 0x000CAAA0
		public unsafe string RFC1123Pattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194879, XrefRangeEnd = 194881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x000CC8D8 File Offset: 0x000CAAD8
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x000CC910 File Offset: 0x000CAB10
		public unsafe string ShortDatePattern
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 194882, RefRangeEnd = 194893, XrefRangeStart = 194881, XrefRangeEnd = 194882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194893, XrefRangeEnd = 194913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortDatePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x000CC954 File Offset: 0x000CAB54
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x000CC98C File Offset: 0x000CAB8C
		public unsafe string ShortTimePattern
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 194914, RefRangeEnd = 194917, XrefRangeStart = 194913, XrefRangeEnd = 194914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194917, XrefRangeEnd = 194935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortTimePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x000CC9D0 File Offset: 0x000CABD0
		public unsafe string SortableDateTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194935, XrefRangeEnd = 194937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000CCA08 File Offset: 0x000CAC08
		public unsafe string GeneralShortTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194937, XrefRangeEnd = 194942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x000CCA40 File Offset: 0x000CAC40
		public unsafe string GeneralLongTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194942, XrefRangeEnd = 194947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000CCA78 File Offset: 0x000CAC78
		public unsafe string DateTimeOffsetPattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 194961, RefRangeEnd = 194962, XrefRangeStart = 194947, XrefRangeEnd = 194961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x000CCAB0 File Offset: 0x000CACB0
		public unsafe string TimeSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000CCAE8 File Offset: 0x000CACE8
		public unsafe string UniversalSortableDateTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194962, XrefRangeEnd = 194964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x000CCB20 File Offset: 0x000CAD20
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x000CCB58 File Offset: 0x000CAD58
		public unsafe string YearMonthPattern
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 194965, RefRangeEnd = 194971, XrefRangeStart = 194964, XrefRangeEnd = 194965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194971, XrefRangeEnd = 194988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_YearMonthPattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x000CCB9C File Offset: 0x000CAD9C
		public unsafe Il2CppStringArray AbbreviatedDayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194988, XrefRangeEnd = 194992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000CCBDC File Offset: 0x000CADDC
		public unsafe Il2CppStringArray DayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194992, XrefRangeEnd = 194996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x000CCC1C File Offset: 0x000CAE1C
		public unsafe Il2CppStringArray AbbreviatedMonthNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195000, RefRangeEnd = 195002, XrefRangeStart = 194996, XrefRangeEnd = 195000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000CCC5C File Offset: 0x000CAE5C
		public unsafe Il2CppStringArray MonthNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195006, RefRangeEnd = 195008, XrefRangeStart = 195002, XrefRangeEnd = 195006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x000CCC9C File Offset: 0x000CAE9C
		public unsafe bool HasSpacesInMonthNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195008, XrefRangeEnd = 195009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000CCCD8 File Offset: 0x000CAED8
		public unsafe bool HasSpacesInDayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195009, XrefRangeEnd = 195010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000CCD14 File Offset: 0x000CAF14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195017, RefRangeEnd = 195020, XrefRangeStart = 195010, XrefRangeEnd = 195017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref abbreviated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000CCD74 File Offset: 0x000CAF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195022, RefRangeEnd = 195023, XrefRangeStart = 195020, XrefRangeEnd = 195022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetGenitiveMonthNames(bool abbreviated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref abbreviated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000CCDC0 File Offset: 0x000CAFC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195024, RefRangeEnd = 195027, XrefRangeStart = 195023, XrefRangeEnd = 195024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetLeapYearMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000CCE00 File Offset: 0x000CB000
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 195028, RefRangeEnd = 195035, XrefRangeStart = 195027, XrefRangeEnd = 195028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayofweek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000CCE44 File Offset: 0x000CB044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195035, XrefRangeEnd = 195043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetCombinedPatterns(Il2CppStringArray patterns1, Il2CppStringArray patterns2, string connectString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patterns1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(patterns2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(connectString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000CCEAC File Offset: 0x000CB0AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 195055, RefRangeEnd = 195060, XrefRangeStart = 195043, XrefRangeEnd = 195055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAllDateTimePatterns(char format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000CCEF8 File Offset: 0x000CB0F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195061, RefRangeEnd = 195067, XrefRangeStart = 195060, XrefRangeEnd = 195061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDayName(DayOfWeek dayofweek)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayofweek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000CCF3C File Offset: 0x000CB13C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195068, RefRangeEnd = 195074, XrefRangeStart = 195067, XrefRangeEnd = 195068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedMonthName(int month)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000CCF80 File Offset: 0x000CB180
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 195075, RefRangeEnd = 195083, XrefRangeStart = 195074, XrefRangeEnd = 195075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMonthName(int month)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000CCFC4 File Offset: 0x000CB1C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 195096, RefRangeEnd = 195101, XrefRangeStart = 195083, XrefRangeEnd = 195096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetMergedPatterns(Il2CppStringArray patterns, string defaultPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patterns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x000CD01C File Offset: 0x000CB21C
		public unsafe Il2CppStringArray AllYearMonthPatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195107, RefRangeEnd = 195108, XrefRangeStart = 195101, XrefRangeEnd = 195107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x000CD05C File Offset: 0x000CB25C
		public unsafe Il2CppStringArray AllShortDatePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195114, RefRangeEnd = 195115, XrefRangeStart = 195108, XrefRangeEnd = 195114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x000CD09C File Offset: 0x000CB29C
		public unsafe Il2CppStringArray AllShortTimePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195121, RefRangeEnd = 195122, XrefRangeStart = 195115, XrefRangeEnd = 195121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000CD0DC File Offset: 0x000CB2DC
		public unsafe Il2CppStringArray AllLongDatePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195128, RefRangeEnd = 195129, XrefRangeStart = 195122, XrefRangeEnd = 195128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000CD11C File Offset: 0x000CB31C
		public unsafe Il2CppStringArray AllLongTimePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195135, RefRangeEnd = 195136, XrefRangeStart = 195129, XrefRangeEnd = 195135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x000CD15C File Offset: 0x000CB35C
		public unsafe Il2CppStringArray UnclonedYearMonthPatterns
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195137, RefRangeEnd = 195139, XrefRangeStart = 195136, XrefRangeEnd = 195137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000CD19C File Offset: 0x000CB39C
		public unsafe Il2CppStringArray UnclonedShortDatePatterns
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195140, RefRangeEnd = 195142, XrefRangeStart = 195139, XrefRangeEnd = 195140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x000CD1DC File Offset: 0x000CB3DC
		public unsafe Il2CppStringArray UnclonedLongDatePatterns
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195143, RefRangeEnd = 195145, XrefRangeStart = 195142, XrefRangeEnd = 195143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x000CD21C File Offset: 0x000CB41C
		public unsafe Il2CppStringArray UnclonedShortTimePatterns
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195145, RefRangeEnd = 195147, XrefRangeStart = 195145, XrefRangeEnd = 195145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000CD25C File Offset: 0x000CB45C
		public unsafe Il2CppStringArray UnclonedLongTimePatterns
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195147, RefRangeEnd = 195149, XrefRangeStart = 195147, XrefRangeEnd = 195147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000CD29C File Offset: 0x000CB49C
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000CD2D8 File Offset: 0x000CB4D8
		public unsafe Il2CppStringArray MonthGenitiveNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195149, XrefRangeEnd = 195154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x000CD318 File Offset: 0x000CB518
		public unsafe string FullTimeSpanPositivePattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195164, RefRangeEnd = 195165, XrefRangeStart = 195154, XrefRangeEnd = 195164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000CD350 File Offset: 0x000CB550
		public unsafe string FullTimeSpanNegativePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195165, XrefRangeEnd = 195169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x000CD388 File Offset: 0x000CB588
		public unsafe CompareInfo CompareInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195169, XrefRangeEnd = 195175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000CD3C8 File Offset: 0x000CB5C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195175, RefRangeEnd = 195178, XrefRangeStart = 195175, XrefRangeEnd = 195175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000CD40C File Offset: 0x000CB60C
		public unsafe DateTimeFormatFlags FormatFlags
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 195214, RefRangeEnd = 195234, XrefRangeStart = 195178, XrefRangeEnd = 195214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000CD448 File Offset: 0x000CB648
		public unsafe bool HasForceTwoDigitYears
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000CD484 File Offset: 0x000CB684
		public unsafe bool HasYearMonthAdjustment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195234, XrefRangeEnd = 195235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000CD4C0 File Offset: 0x000CB6C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 195237, RefRangeEnd = 195241, XrefRangeStart = 195235, XrefRangeEnd = 195237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parsedMonthName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000CD528 File Offset: 0x000CB728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195259, RefRangeEnd = 195261, XrefRangeStart = 195241, XrefRangeEnd = 195259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000CD55C File Offset: 0x000CB75C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195279, RefRangeEnd = 195281, XrefRangeStart = 195261, XrefRangeEnd = 195279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000CD590 File Offset: 0x000CB790
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 195281, RefRangeEnd = 195292, XrefRangeStart = 195281, XrefRangeEnd = 195281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTokenHashTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000CD5C4 File Offset: 0x000CB7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195505, RefRangeEnd = 195506, XrefRangeStart = 195292, XrefRangeEnd = 195505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TokenHashValue> CreateTokenHashTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TokenHashValue>>(intPtr3) : null;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000CD604 File Offset: 0x000CB804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195511, RefRangeEnd = 195513, XrefRangeStart = 195506, XrefRangeEnd = 195511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMonthNames(Il2CppReferenceArray<TokenHashValue> temp, string monthPostfix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(temp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(monthPostfix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000CD658 File Offset: 0x000CB858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195529, RefRangeEnd = 195530, XrefRangeStart = 195513, XrefRangeEnd = 195529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &badFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000CD6BC File Offset: 0x000CB8BC
		[CallerCount(0)]
		public unsafe static bool IsHebrewChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000CD6FC File Offset: 0x000CB8FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195552, RefRangeEnd = 195554, XrefRangeStart = 195530, XrefRangeEnd = 195552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref TokenMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000CD77C File Offset: 0x000CB97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195565, RefRangeEnd = 195566, XrefRangeStart = 195554, XrefRangeEnd = 195565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertAtCurrentHashNode(Il2CppReferenceArray<TokenHashValue> hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashProbe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000CD824 File Offset: 0x000CBA24
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 195591, RefRangeEnd = 195642, XrefRangeStart = 195566, XrefRangeEnd = 195591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertHash(Il2CppReferenceArray<TokenHashValue> hashTable, string str, TokenType tokenType, int tokenValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0000C780 File Offset: 0x0000A980
		public DateTimeFormatInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000CD894 File Offset: 0x000CBA94
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0000C789 File Offset: 0x0000A989
		public unsafe static DateTimeFormatInfo invariantInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000CD8BC File Offset: 0x000CBABC
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0000C79B File Offset: 0x0000A99B
		public unsafe CultureData m_cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000CD8EC File Offset: 0x000CBAEC
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x0000C7BA File Offset: 0x0000A9BA
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x000CD914 File Offset: 0x000CBB14
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x0000C7D9 File Offset: 0x0000A9D9
		public unsafe string m_langName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_langName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_langName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000CD93C File Offset: 0x000CBB3C
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		public unsafe CompareInfo m_compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x000CD96C File Offset: 0x000CBB6C
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x0000C817 File Offset: 0x0000AA17
		public unsafe CultureInfo m_cultureInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x000CD99C File Offset: 0x000CBB9C
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x0000C836 File Offset: 0x0000AA36
		public unsafe string amDesignator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x000CD9C4 File Offset: 0x000CBBC4
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x0000C855 File Offset: 0x0000AA55
		public unsafe string pmDesignator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x000CD9EC File Offset: 0x000CBBEC
		// (set) Token: 0x060025B7 RID: 9655 RVA: 0x0000C874 File Offset: 0x0000AA74
		public unsafe string dateSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000CDA14 File Offset: 0x000CBC14
		// (set) Token: 0x060025B9 RID: 9657 RVA: 0x0000C893 File Offset: 0x0000AA93
		public unsafe string generalShortTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x000CDA3C File Offset: 0x000CBC3C
		// (set) Token: 0x060025BB RID: 9659 RVA: 0x0000C8B2 File Offset: 0x0000AAB2
		public unsafe string generalLongTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x000CDA64 File Offset: 0x000CBC64
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x0000C8D1 File Offset: 0x0000AAD1
		public unsafe string timeSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x000CDA8C File Offset: 0x000CBC8C
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		public unsafe string monthDayPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x000CDAB4 File Offset: 0x000CBCB4
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x0000C90F File Offset: 0x0000AB0F
		public unsafe string dateTimeOffsetPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x000CDADC File Offset: 0x000CBCDC
		// (set) Token: 0x060025C3 RID: 9667 RVA: 0x0000C92E File Offset: 0x0000AB2E
		public unsafe static string rfc1123Pattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060025C4 RID: 9668 RVA: 0x000CDAFC File Offset: 0x000CBCFC
		// (set) Token: 0x060025C5 RID: 9669 RVA: 0x0000C940 File Offset: 0x0000AB40
		public unsafe static string sortableDateTimePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x000CDB1C File Offset: 0x000CBD1C
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x0000C952 File Offset: 0x0000AB52
		public unsafe static string universalSortableDateTimePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000CDB3C File Offset: 0x000CBD3C
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x0000C964 File Offset: 0x0000AB64
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x000CDB6C File Offset: 0x000CBD6C
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x0000C983 File Offset: 0x0000AB83
		public unsafe int firstDayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek)) = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x000CDB94 File Offset: 0x000CBD94
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x0000C99E File Offset: 0x0000AB9E
		public unsafe int calendarWeekRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule)) = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x000CDBBC File Offset: 0x000CBDBC
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x0000C9B9 File Offset: 0x0000ABB9
		public unsafe string fullDateTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x000CDBE4 File Offset: 0x000CBDE4
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		public unsafe Il2CppStringArray abbreviatedDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000CDC14 File Offset: 0x000CBE14
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0000C9F7 File Offset: 0x0000ABF7
		public unsafe Il2CppStringArray m_superShortDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000CDC44 File Offset: 0x000CBE44
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x0000CA16 File Offset: 0x0000AC16
		public unsafe Il2CppStringArray dayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000CDC74 File Offset: 0x000CBE74
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x0000CA35 File Offset: 0x0000AC35
		public unsafe Il2CppStringArray abbreviatedMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000CDCA4 File Offset: 0x000CBEA4
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x0000CA54 File Offset: 0x0000AC54
		public unsafe Il2CppStringArray monthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000CDCD4 File Offset: 0x000CBED4
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x0000CA73 File Offset: 0x0000AC73
		public unsafe Il2CppStringArray genitiveMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000CDD04 File Offset: 0x000CBF04
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x0000CA92 File Offset: 0x0000AC92
		public unsafe Il2CppStringArray m_genitiveAbbreviatedMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000CDD34 File Offset: 0x000CBF34
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x0000CAB1 File Offset: 0x0000ACB1
		public unsafe Il2CppStringArray leapYearMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000CDD64 File Offset: 0x000CBF64
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
		public unsafe string longDatePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000CDD8C File Offset: 0x000CBF8C
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x0000CAEF File Offset: 0x0000ACEF
		public unsafe string shortDatePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000CDDB4 File Offset: 0x000CBFB4
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x0000CB0E File Offset: 0x0000AD0E
		public unsafe string yearMonthPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000CDDDC File Offset: 0x000CBFDC
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x0000CB2D File Offset: 0x0000AD2D
		public unsafe string longTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000CDE04 File Offset: 0x000CC004
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		public unsafe string shortTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x000CDE2C File Offset: 0x000CC02C
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x0000CB6B File Offset: 0x0000AD6B
		public unsafe Il2CppStringArray allYearMonthPatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x000CDE5C File Offset: 0x000CC05C
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x0000CB8A File Offset: 0x0000AD8A
		public unsafe Il2CppStringArray allShortDatePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000CDE8C File Offset: 0x000CC08C
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x0000CBA9 File Offset: 0x0000ADA9
		public unsafe Il2CppStringArray allLongDatePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000CDEBC File Offset: 0x000CC0BC
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		public unsafe Il2CppStringArray allShortTimePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000CDEEC File Offset: 0x000CC0EC
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x0000CBE7 File Offset: 0x0000ADE7
		public unsafe Il2CppStringArray allLongTimePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000CDF1C File Offset: 0x000CC11C
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x0000CC06 File Offset: 0x0000AE06
		public unsafe Il2CppStringArray m_eraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000CDF4C File Offset: 0x000CC14C
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x0000CC25 File Offset: 0x0000AE25
		public unsafe Il2CppStringArray m_abbrevEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000CDF7C File Offset: 0x000CC17C
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x0000CC44 File Offset: 0x0000AE44
		public unsafe Il2CppStringArray m_abbrevEnglishEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x000CDFAC File Offset: 0x000CC1AC
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x0000CC63 File Offset: 0x0000AE63
		public unsafe Il2CppStructArray<int> optionalCalendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000CDFDC File Offset: 0x000CC1DC
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0000CC82 File Offset: 0x0000AE82
		public unsafe static int DEFAULT_ALL_DATETIMES_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000CDFF8 File Offset: 0x000CC1F8
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0000CC90 File Offset: 0x0000AE90
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000CE020 File Offset: 0x000CC220
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0000CCAB File Offset: 0x0000AEAB
		public unsafe DateTimeFormatFlags formatFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags)) = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000CE048 File Offset: 0x000CC248
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x0000CCC6 File Offset: 0x0000AEC6
		public unsafe static bool preferExistingTokens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_preferExistingTokens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_preferExistingTokens, (void*)(&value));
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000CE064 File Offset: 0x000CC264
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		public unsafe int CultureID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_CultureID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_CultureID)) = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000CE08C File Offset: 0x000CC28C
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x0000CCEF File Offset: 0x0000AEEF
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x000CE0B4 File Offset: 0x000CC2B4
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x0000CD0A File Offset: 0x0000AF0A
		public unsafe bool bUseCalendarInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_bUseCalendarInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_bUseCalendarInfo)) = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000CE0DC File Offset: 0x000CC2DC
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x0000CD25 File Offset: 0x0000AF25
		public unsafe int nDataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_nDataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_nDataItem)) = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000CE104 File Offset: 0x000CC304
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x0000CD40 File Offset: 0x0000AF40
		public unsafe bool m_isDefaultCalendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isDefaultCalendar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isDefaultCalendar)) = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x000CE12C File Offset: 0x000CC32C
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0000CD5B File Offset: 0x0000AF5B
		public unsafe static Hashtable s_calendarNativeNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_calendarNativeNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_calendarNativeNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000CE154 File Offset: 0x000CC354
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x0000CD6D File Offset: 0x0000AF6D
		public unsafe Il2CppStringArray m_dateWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dateWords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dateWords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000CE184 File Offset: 0x000CC384
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		public unsafe string m_fullTimeSpanPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanPositivePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanPositivePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000CE1AC File Offset: 0x000CC3AC
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x0000CDAB File Offset: 0x0000AFAB
		public unsafe string m_fullTimeSpanNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanNegativePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanNegativePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000CE1D4 File Offset: 0x000CC3D4
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x0000CDCA File Offset: 0x0000AFCA
		public unsafe static DateTimeStyles InvalidDateTimeStyles
		{
			get
			{
				DateTimeStyles dateTimeStyles;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&dateTimeStyles));
				return dateTimeStyles;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&value));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000CE1F0 File Offset: 0x000CC3F0
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x0000CDD8 File Offset: 0x0000AFD8
		public unsafe Il2CppReferenceArray<TokenHashValue> m_dtfiTokenHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dtfiTokenHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TokenHashValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dtfiTokenHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000CE220 File Offset: 0x000CC420
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0000CDF7 File Offset: 0x0000AFF7
		public unsafe static int TOKEN_HASH_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000CE23C File Offset: 0x000CC43C
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x0000CE05 File Offset: 0x0000B005
		public unsafe static int SECOND_PRIME
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME, (void*)(&value));
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x000CE258 File Offset: 0x000CC458
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0000CE13 File Offset: 0x0000B013
		public unsafe static string dateSeparatorOrTimeZoneOffset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000CE278 File Offset: 0x000CC478
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0000CE25 File Offset: 0x0000B025
		public unsafe static string invariantDateSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000CE298 File Offset: 0x000CC498
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x0000CE37 File Offset: 0x0000B037
		public unsafe static string invariantTimeSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x000CE2B8 File Offset: 0x000CC4B8
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x0000CE49 File Offset: 0x0000B049
		public unsafe static string IgnorablePeriod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x000CE2D8 File Offset: 0x000CC4D8
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x0000CE5B File Offset: 0x0000B05B
		public unsafe static string IgnorableComma
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x000CE2F8 File Offset: 0x000CC4F8
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x0000CE6D File Offset: 0x0000B06D
		public unsafe static string CJKYearSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000CE318 File Offset: 0x000CC518
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x0000CE7F File Offset: 0x0000B07F
		public unsafe static string CJKMonthSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000CE338 File Offset: 0x000CC538
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x0000CE91 File Offset: 0x0000B091
		public unsafe static string CJKDaySuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000CE358 File Offset: 0x000CC558
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0000CEA3 File Offset: 0x0000B0A3
		public unsafe static string KoreanYearSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x000CE378 File Offset: 0x000CC578
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x0000CEB5 File Offset: 0x0000B0B5
		public unsafe static string KoreanMonthSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x000CE398 File Offset: 0x000CC598
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x0000CEC7 File Offset: 0x0000B0C7
		public unsafe static string KoreanDaySuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000CE3B8 File Offset: 0x000CC5B8
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x0000CED9 File Offset: 0x0000B0D9
		public unsafe static string KoreanHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x000CE3D8 File Offset: 0x000CC5D8
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x0000CEEB File Offset: 0x0000B0EB
		public unsafe static string KoreanMinuteSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000CE3F8 File Offset: 0x000CC5F8
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x0000CEFD File Offset: 0x0000B0FD
		public unsafe static string KoreanSecondSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x000CE418 File Offset: 0x000CC618
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x0000CF0F File Offset: 0x0000B10F
		public unsafe static string CJKHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x000CE438 File Offset: 0x000CC638
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x0000CF21 File Offset: 0x0000B121
		public unsafe static string ChineseHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x000CE458 File Offset: 0x000CC658
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x0000CF33 File Offset: 0x0000B133
		public unsafe static string CJKMinuteSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x000CE478 File Offset: 0x000CC678
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x0000CF45 File Offset: 0x0000B145
		public unsafe static string CJKSecondSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x000CE498 File Offset: 0x000CC698
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x0000CF57 File Offset: 0x0000B157
		public unsafe static string LocalTimeMark
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x000CE4B8 File Offset: 0x000CC6B8
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x0000CF69 File Offset: 0x0000B169
		public unsafe static string KoreanLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x000CE4D8 File Offset: 0x000CC6D8
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x0000CF7B File Offset: 0x0000B17B
		public unsafe static string JapaneseLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x000CE4F8 File Offset: 0x000CC6F8
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x0000CF8D File Offset: 0x0000B18D
		public unsafe static string EnglishLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x000CE518 File Offset: 0x000CC718
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x0000CF9F File Offset: 0x0000B19F
		public unsafe static DateTimeFormatInfo s_jajpDTFI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000CE540 File Offset: 0x000CC740
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x0000CFB1 File Offset: 0x0000B1B1
		public unsafe static DateTimeFormatInfo s_zhtwDTFI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeFieldInfoPtr_invariantInfo;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureData;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeFieldInfoPtr_m_langName;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeFieldInfoPtr_m_compareInfo;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureInfo;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeFieldInfoPtr_amDesignator;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeFieldInfoPtr_pmDesignator;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeFieldInfoPtr_dateSeparator;

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeFieldInfoPtr_generalShortTimePattern;

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeFieldInfoPtr_generalLongTimePattern;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeFieldInfoPtr_timeSeparator;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeFieldInfoPtr_monthDayPattern;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeOffsetPattern;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeFieldInfoPtr_rfc1123Pattern;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeFieldInfoPtr_sortableDateTimePattern;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeFieldInfoPtr_universalSortableDateTimePattern;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeFieldInfoPtr_firstDayOfWeek;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeFieldInfoPtr_calendarWeekRule;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeFieldInfoPtr_fullDateTimePattern;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeFieldInfoPtr_abbreviatedDayNames;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeFieldInfoPtr_m_superShortDayNames;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeFieldInfoPtr_dayNames;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeFieldInfoPtr_abbreviatedMonthNames;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeFieldInfoPtr_monthNames;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeFieldInfoPtr_genitiveMonthNames;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeFieldInfoPtr_leapYearMonthNames;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeFieldInfoPtr_longDatePattern;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeFieldInfoPtr_shortDatePattern;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeFieldInfoPtr_yearMonthPattern;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeFieldInfoPtr_longTimePattern;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeFieldInfoPtr_shortTimePattern;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeFieldInfoPtr_allYearMonthPatterns;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeFieldInfoPtr_allShortDatePatterns;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeFieldInfoPtr_allLongDatePatterns;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeFieldInfoPtr_allShortTimePatterns;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeFieldInfoPtr_allLongTimePatterns;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeFieldInfoPtr_m_eraNames;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeFieldInfoPtr_m_abbrevEraNames;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeFieldInfoPtr_m_abbrevEnglishEraNames;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeFieldInfoPtr_optionalCalendars;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeFieldInfoPtr_formatFlags;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeFieldInfoPtr_preferExistingTokens;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeFieldInfoPtr_CultureID;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeFieldInfoPtr_bUseCalendarInfo;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeFieldInfoPtr_nDataItem;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultCalendar;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeFieldInfoPtr_s_calendarNativeNames;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeFieldInfoPtr_m_dateWords;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeFieldInfoPtr_m_fullTimeSpanPositivePattern;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeFieldInfoPtr_m_fullTimeSpanNegativePattern;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeFieldInfoPtr_InvalidDateTimeStyles;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeFieldInfoPtr_m_dtfiTokenHash;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeFieldInfoPtr_TOKEN_HASH_SIZE;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeFieldInfoPtr_SECOND_PRIME;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeFieldInfoPtr_invariantDateSeparator;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeFieldInfoPtr_invariantTimeSeparator;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeFieldInfoPtr_IgnorablePeriod;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeFieldInfoPtr_IgnorableComma;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeFieldInfoPtr_CJKYearSuff;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeFieldInfoPtr_CJKMonthSuff;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeFieldInfoPtr_CJKDaySuff;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeFieldInfoPtr_KoreanYearSuff;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeFieldInfoPtr_KoreanMonthSuff;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeFieldInfoPtr_KoreanDaySuff;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeFieldInfoPtr_KoreanHourSuff;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeFieldInfoPtr_KoreanMinuteSuff;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeFieldInfoPtr_KoreanSecondSuff;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeFieldInfoPtr_CJKHourSuff;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeFieldInfoPtr_ChineseHourSuff;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeFieldInfoPtr_CJKMinuteSuff;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeFieldInfoPtr_CJKSecondSuff;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeFieldInfoPtr_LocalTimeMark;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeFieldInfoPtr_KoreanLangName;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeFieldInfoPtr_JapaneseLangName;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeFieldInfoPtr_EnglishLangName;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeFieldInfoPtr_s_jajpDTFI;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeFieldInfoPtr_s_zhtwDTFI;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_InitPreferExistingTokens_Private_Static_Boolean_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Private_get_String_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_get_LanguageName_Private_get_String_0;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_GetEraName_Public_String_Int32_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_set_LongDatePattern_Public_set_Void_String_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_set_LongTimePattern_Public_set_Void_String_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_set_ShortDatePattern_Public_set_Void_String_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_set_ShortTimePattern_Public_set_Void_String_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_set_YearMonthPattern_Public_set_Void_String_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0;
	}
}
