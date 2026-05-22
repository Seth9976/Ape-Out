using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024C RID: 588
	public class CultureData : Object
	{
		// Token: 0x0600284F RID: 10319 RVA: 0x000D6E50 File Offset: 0x000D5050
		// Note: this type is marked as 'beforefieldinit'.
		static CultureData()
		{
			Il2CppClassPointerStore<CultureData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureData>.NativeClassPtr);
			CultureData.NativeFieldInfoPtr_sAM1159 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sAM1159");
			CultureData.NativeFieldInfoPtr_sPM2359 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sPM2359");
			CultureData.NativeFieldInfoPtr_sTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sTimeSeparator");
			CultureData.NativeFieldInfoPtr_saLongTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saLongTimes");
			CultureData.NativeFieldInfoPtr_saShortTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saShortTimes");
			CultureData.NativeFieldInfoPtr_iFirstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstDayOfWeek");
			CultureData.NativeFieldInfoPtr_iFirstWeekOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstWeekOfYear");
			CultureData.NativeFieldInfoPtr_waCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "waCalendars");
			CultureData.NativeFieldInfoPtr_calendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendars");
			CultureData.NativeFieldInfoPtr_sISO639Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sISO639Language");
			CultureData.NativeFieldInfoPtr_sRealName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sRealName");
			CultureData.NativeFieldInfoPtr_bUseOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "bUseOverrides");
			CultureData.NativeFieldInfoPtr_calendarId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendarId");
			CultureData.NativeFieldInfoPtr_numberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "numberIndex");
			CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultAnsiCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultOemCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultOemCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultMacCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultMacCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultEbcdicCodePage");
			CultureData.NativeFieldInfoPtr_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "isRightToLeft");
			CultureData.NativeFieldInfoPtr_sListSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sListSeparator");
			CultureData.NativeFieldInfoPtr_s_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "s_Invariant");
			CultureData.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669914);
			CultureData.NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669915);
			CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669916);
			CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669917);
			CultureData.NativeMethodInfoPtr_GetCultureData_Internal_Static_CultureData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669918);
			CultureData.NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669919);
			CultureData.NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669920);
			CultureData.NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669921);
			CultureData.NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669922);
			CultureData.NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669923);
			CultureData.NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669924);
			CultureData.NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669925);
			CultureData.NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669926);
			CultureData.NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669927);
			CultureData.NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669928);
			CultureData.NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669929);
			CultureData.NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669930);
			CultureData.NativeMethodInfoPtr_get_CultureName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669931);
			CultureData.NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669932);
			CultureData.NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669933);
			CultureData.NativeMethodInfoPtr_get_ILANGUAGE_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669934);
			CultureData.NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669935);
			CultureData.NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669936);
			CultureData.NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669937);
			CultureData.NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669938);
			CultureData.NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669939);
			CultureData.NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669940);
			CultureData.NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669941);
			CultureData.NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669942);
			CultureData.NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669943);
			CultureData.NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669944);
			CultureData.NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669945);
			CultureData.NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669946);
			CultureData.NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669947);
			CultureData.NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669948);
			CultureData.NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669949);
			CultureData.NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669950);
			CultureData.NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669951);
			CultureData.NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669952);
			CultureData.NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669953);
			CultureData.NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669954);
			CultureData.NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669955);
			CultureData.NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669956);
			CultureData.NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669957);
			CultureData.NativeMethodInfoPtr_fill_number_data_Private_Static_Void_NumberFormatInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669958);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000D73A8 File Offset: 0x000D55A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureData(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x000D73F4 File Offset: 0x000D55F4
		public unsafe static CultureData Invariant
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 198418, RefRangeEnd = 198421, XrefRangeStart = 198359, XrefRangeEnd = 198418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
			}
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x000D7428 File Offset: 0x000D5628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198426, RefRangeEnd = 198428, XrefRangeStart = 198421, XrefRangeEnd = 198426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000D747C File Offset: 0x000D567C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 198434, RefRangeEnd = 198438, XrefRangeStart = 198428, XrefRangeEnd = 198434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref datetimeIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numberIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(iso2lang);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ansiCodePage;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oemCodePage;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref macCodePage;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ebcdicCodePage;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(listSeparator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000D7568 File Offset: 0x000D5768
		[CallerCount(0)]
		public unsafe static CultureData GetCultureData(int culture, bool bUseUserOverride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Internal_Static_CultureData_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x000D75B8 File Offset: 0x000D57B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198438, XrefRangeEnd = 198439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fill_culture_data(int datetimeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref datetimeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x000D75F8 File Offset: 0x000D57F8
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 198448, RefRangeEnd = 198490, XrefRangeStart = 198439, XrefRangeEnd = 198448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData GetCalendar(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr3) : null;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000D7644 File Offset: 0x000D5844
		public unsafe Il2CppStringArray LongTimes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000D7684 File Offset: 0x000D5884
		public unsafe Il2CppStringArray ShortTimes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x000D76C4 File Offset: 0x000D58C4
		public unsafe string SISO639LANGNAME
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x000D76FC File Offset: 0x000D58FC
		public unsafe int IFIRSTDAYOFWEEK
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x000D7738 File Offset: 0x000D5938
		public unsafe int IFIRSTWEEKOFYEAR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x000D7774 File Offset: 0x000D5974
		public unsafe string SAM1159
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x000D77AC File Offset: 0x000D59AC
		public unsafe string SPM2359
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000D77E4 File Offset: 0x000D59E4
		public unsafe string TimeSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x000D781C File Offset: 0x000D5A1C
		public unsafe Il2CppStructArray<int> CalendarIds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 198506, RefRangeEnd = 198507, XrefRangeStart = 198490, XrefRangeEnd = 198506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x000D785C File Offset: 0x000D5A5C
		public unsafe bool IsInvariantCulture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x000D7898 File Offset: 0x000D5A98
		public unsafe string CultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_CultureName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x000D78D0 File Offset: 0x000D5AD0
		public unsafe string SCOMPAREINFO
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198507, XrefRangeEnd = 198509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x000D7908 File Offset: 0x000D5B08
		public unsafe string STEXTINFO
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x000D7940 File Offset: 0x000D5B40
		public unsafe int ILANGUAGE
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_ILANGUAGE_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x000D797C File Offset: 0x000D5B7C
		public unsafe bool UseUserOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000D79B8 File Offset: 0x000D5BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198509, XrefRangeEnd = 198510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray EraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000D7A04 File Offset: 0x000D5C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198510, XrefRangeEnd = 198511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbrevEraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000D7A50 File Offset: 0x000D5C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198511, XrefRangeEnd = 198512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedEnglishEraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000D7A9C File Offset: 0x000D5C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198512, XrefRangeEnd = 198513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray ShortDates(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000D7AE8 File Offset: 0x000D5CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198513, XrefRangeEnd = 198514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray LongDates(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000D7B34 File Offset: 0x000D5D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198514, XrefRangeEnd = 198515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray YearMonths(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x000D7B80 File Offset: 0x000D5D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198515, XrefRangeEnd = 198516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray DayNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000D7BCC File Offset: 0x000D5DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198516, XrefRangeEnd = 198517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedDayNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x000D7C18 File Offset: 0x000D5E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198517, XrefRangeEnd = 198518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray MonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000D7C64 File Offset: 0x000D5E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198518, XrefRangeEnd = 198519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GenitiveMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000D7CB0 File Offset: 0x000D5EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198519, XrefRangeEnd = 198520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x000D7CFC File Offset: 0x000D5EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198520, XrefRangeEnd = 198521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedGenitiveMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x000D7D48 File Offset: 0x000D5F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198521, XrefRangeEnd = 198522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray LeapYearMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000D7D94 File Offset: 0x000D5F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198522, XrefRangeEnd = 198523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MonthDay(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000D7DD8 File Offset: 0x000D5FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198523, XrefRangeEnd = 198530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DateSeparator(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000D7E1C File Offset: 0x000D601C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198530, XrefRangeEnd = 198533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDateSeparator(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000D7E58 File Offset: 0x000D6058
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198547, RefRangeEnd = 198550, XrefRangeStart = 198533, XrefRangeEnd = 198547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSeparator(string format, string timeParts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeParts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000D7EA8 File Offset: 0x000D60A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198550, XrefRangeEnd = 198556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeParts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000D7F0C File Offset: 0x000D610C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198569, RefRangeEnd = 198570, XrefRangeStart = 198556, XrefRangeEnd = 198569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeNlsString(string str, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000D7F64 File Offset: 0x000D6164
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ReescapeWin32Strings(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000D7FA8 File Offset: 0x000D61A8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReescapeWin32String(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000D7FE4 File Offset: 0x000D61E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198570, XrefRangeEnd = 198571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNFIValues(NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000D8028 File Offset: 0x000D6228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198571, XrefRangeEnd = 198572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void fill_number_data(NumberFormatInfo nfi, int numberIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numberIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_fill_number_data_Private_Static_Void_NumberFormatInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0000DAC6 File Offset: 0x0000BCC6
		public CultureData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x000D806C File Offset: 0x000D626C
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x0000DACF File Offset: 0x0000BCCF
		public unsafe string sAM1159
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sAM1159);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sAM1159), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000D8094 File Offset: 0x000D6294
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x0000DAEE File Offset: 0x0000BCEE
		public unsafe string sPM2359
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sPM2359);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sPM2359), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x000D80BC File Offset: 0x000D62BC
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x0000DB0D File Offset: 0x0000BD0D
		public unsafe string sTimeSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sTimeSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sTimeSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x000D80E4 File Offset: 0x000D62E4
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x0000DB2C File Offset: 0x0000BD2C
		public unsafe Il2CppStringArray saLongTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saLongTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saLongTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x000D8114 File Offset: 0x000D6314
		// (set) Token: 0x06002887 RID: 10375 RVA: 0x0000DB4B File Offset: 0x0000BD4B
		public unsafe Il2CppStringArray saShortTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saShortTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saShortTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x000D8144 File Offset: 0x000D6344
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x0000DB6A File Offset: 0x0000BD6A
		public unsafe int iFirstDayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstDayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstDayOfWeek)) = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x000D816C File Offset: 0x000D636C
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x0000DB85 File Offset: 0x0000BD85
		public unsafe int iFirstWeekOfYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstWeekOfYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstWeekOfYear)) = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000D8194 File Offset: 0x000D6394
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
		public unsafe Il2CppStructArray<int> waCalendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_waCalendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_waCalendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000D81C4 File Offset: 0x000D63C4
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x0000DBBF File Offset: 0x0000BDBF
		public unsafe Il2CppReferenceArray<CalendarData> calendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CalendarData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000D81F4 File Offset: 0x000D63F4
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x0000DBDE File Offset: 0x0000BDDE
		public unsafe string sISO639Language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sISO639Language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sISO639Language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000D821C File Offset: 0x000D641C
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x0000DBFD File Offset: 0x0000BDFD
		public unsafe string sRealName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sRealName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sRealName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000D8244 File Offset: 0x000D6444
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		public unsafe bool bUseOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_bUseOverrides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_bUseOverrides)) = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000D826C File Offset: 0x000D646C
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x0000DC37 File Offset: 0x0000BE37
		public unsafe int calendarId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendarId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendarId)) = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000D8294 File Offset: 0x000D6494
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0000DC52 File Offset: 0x0000BE52
		public unsafe int numberIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_numberIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_numberIndex)) = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000D82BC File Offset: 0x000D64BC
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x0000DC6D File Offset: 0x0000BE6D
		public unsafe int iDefaultAnsiCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage)) = value;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000D82E4 File Offset: 0x000D64E4
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x0000DC88 File Offset: 0x0000BE88
		public unsafe int iDefaultOemCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultOemCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultOemCodePage)) = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000D830C File Offset: 0x000D650C
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0000DCA3 File Offset: 0x0000BEA3
		public unsafe int iDefaultMacCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultMacCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultMacCodePage)) = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000D8334 File Offset: 0x000D6534
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0000DCBE File Offset: 0x0000BEBE
		public unsafe int iDefaultEbcdicCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage)) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000D835C File Offset: 0x000D655C
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0000DCD9 File Offset: 0x0000BED9
		public unsafe bool isRightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_isRightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_isRightToLeft)) = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000D8384 File Offset: 0x000D6584
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		public unsafe string sListSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sListSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sListSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000D83AC File Offset: 0x000D65AC
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0000DD13 File Offset: 0x0000BF13
		public unsafe static CultureData s_Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureData.NativeFieldInfoPtr_s_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureData.NativeFieldInfoPtr_s_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeFieldInfoPtr_sAM1159;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeFieldInfoPtr_sPM2359;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeFieldInfoPtr_sTimeSeparator;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeFieldInfoPtr_saLongTimes;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeFieldInfoPtr_saShortTimes;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeFieldInfoPtr_iFirstDayOfWeek;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeFieldInfoPtr_iFirstWeekOfYear;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeFieldInfoPtr_waCalendars;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeFieldInfoPtr_calendars;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeFieldInfoPtr_sISO639Language;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeFieldInfoPtr_sRealName;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeFieldInfoPtr_bUseOverrides;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeFieldInfoPtr_calendarId;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeFieldInfoPtr_numberIndex;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultAnsiCodePage;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultOemCodePage;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultMacCodePage;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultEbcdicCodePage;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeFieldInfoPtr_isRightToLeft;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeFieldInfoPtr_sListSeparator;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeFieldInfoPtr_s_Invariant;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Internal_Static_CultureData_Int32_Boolean_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Internal_get_String_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_get_ILANGUAGE_Internal_get_Int32_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeMethodInfoPtr_fill_number_data_Private_Static_Void_NumberFormatInfo_Int32_0;
	}
}
