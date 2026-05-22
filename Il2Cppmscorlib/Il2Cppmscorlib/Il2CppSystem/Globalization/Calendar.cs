using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022B RID: 555
	[Serializable]
	public class Calendar : Object
	{
		// Token: 0x06002439 RID: 9273 RVA: 0x000C79D8 File Offset: 0x000C5BD8
		// Note: this type is marked as 'beforefieldinit'.
		static Calendar()
		{
			Il2CppClassPointerStore<Calendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Calendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Calendar>.NativeClassPtr);
			Calendar.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerMillisecond");
			Calendar.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerSecond");
			Calendar.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerMinute");
			Calendar.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerHour");
			Calendar.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerDay");
			Calendar.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerSecond");
			Calendar.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerMinute");
			Calendar.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerHour");
			Calendar.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerDay");
			Calendar.NativeFieldInfoPtr_DaysPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPerYear");
			Calendar.NativeFieldInfoPtr_DaysPer4Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer4Years");
			Calendar.NativeFieldInfoPtr_DaysPer100Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer100Years");
			Calendar.NativeFieldInfoPtr_DaysPer400Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer400Years");
			Calendar.NativeFieldInfoPtr_DaysTo10000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysTo10000");
			Calendar.NativeFieldInfoPtr_MaxMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MaxMillis");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_US");
			Calendar.NativeFieldInfoPtr_CAL_JAPAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JAPAN");
			Calendar.NativeFieldInfoPtr_CAL_TAIWAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_TAIWAN");
			Calendar.NativeFieldInfoPtr_CAL_KOREA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_KOREA");
			Calendar.NativeFieldInfoPtr_CAL_HIJRI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_HIJRI");
			Calendar.NativeFieldInfoPtr_CAL_THAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_THAI");
			Calendar.NativeFieldInfoPtr_CAL_HEBREW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_HEBREW");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_ME_FRENCH");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_ARABIC");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_XLIT_ENGLISH");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_XLIT_FRENCH");
			Calendar.NativeFieldInfoPtr_CAL_JULIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JULIAN");
			Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JAPANESELUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_CHINESELUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_SAKA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_SAKA");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_CHN");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_KOR");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_ROKUYOU");
			Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_KOREANLUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_TAIWANLUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_PERSIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_PERSIAN");
			Calendar.NativeFieldInfoPtr_CAL_UMALQURA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_UMALQURA");
			Calendar.NativeFieldInfoPtr_m_currentEraValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "m_currentEraValue");
			Calendar.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "m_isReadOnly");
			Calendar.NativeFieldInfoPtr_CurrentEra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CurrentEra");
			Calendar.NativeFieldInfoPtr_twoDigitYearMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "twoDigitYearMax");
			Calendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669445);
			Calendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669446);
			Calendar.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669447);
			Calendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669448);
			Calendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669449);
			Calendar.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669450);
			Calendar.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669451);
			Calendar.NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669452);
			Calendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669453);
			Calendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669454);
			Calendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669455);
			Calendar.NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669456);
			Calendar.NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669457);
			Calendar.NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669458);
			Calendar.NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669459);
			Calendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669460);
			Calendar.NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669461);
			Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669462);
			Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669463);
			Calendar.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669464);
			Calendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669465);
			Calendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669466);
			Calendar.NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669467);
			Calendar.NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669468);
			Calendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669469);
			Calendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669470);
			Calendar.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669471);
			Calendar.NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669472);
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000C7F80 File Offset: 0x000C6180
		public unsafe virtual DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194057, XrefRangeEnd = 194061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x000C7FC8 File Offset: 0x000C61C8
		public unsafe virtual DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194061, XrefRangeEnd = 194065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000C8010 File Offset: 0x000C6210
		[CallerCount(0)]
		public unsafe Calendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Calendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x000C804C File Offset: 0x000C624C
		public unsafe virtual int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x000C8094 File Offset: 0x000C6294
		public unsafe virtual int BaseCalendarID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000C80DC File Offset: 0x000C62DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194065, XrefRangeEnd = 194068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000C8128 File Offset: 0x000C6328
		[CallerCount(0)]
		public unsafe void SetReadOnlyState(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x000C8168 File Offset: 0x000C6368
		public unsafe virtual int CurrentEraValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194068, XrefRangeEnd = 194109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x000C81B0 File Offset: 0x000C63B0
		[CallerCount(0)]
		public unsafe virtual int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x000C8204 File Offset: 0x000C6404
		[CallerCount(0)]
		public unsafe virtual DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x000C8258 File Offset: 0x000C6458
		[CallerCount(0)]
		public unsafe virtual int GetDaysInMonth(int year, int month, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x000C82C8 File Offset: 0x000C64C8
		[CallerCount(0)]
		public unsafe virtual int GetDaysInYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x000C832C File Offset: 0x000C652C
		[CallerCount(0)]
		public unsafe virtual int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x000C8380 File Offset: 0x000C6580
		public unsafe virtual Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x000C83CC File Offset: 0x000C65CC
		[CallerCount(0)]
		public unsafe virtual int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x000C8420 File Offset: 0x000C6620
		[CallerCount(0)]
		public unsafe virtual int GetMonthsInYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x000C8484 File Offset: 0x000C6684
		[CallerCount(0)]
		public unsafe virtual int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x000C84D8 File Offset: 0x000C66D8
		[CallerCount(0)]
		public unsafe virtual bool IsLeapYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x000C852C File Offset: 0x000C672C
		[CallerCount(0)]
		public unsafe virtual bool IsLeapYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x000C8590 File Offset: 0x000C6790
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x000C8648 File Offset: 0x000C6848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194109, XrefRangeEnd = 194114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x000C8710 File Offset: 0x000C6910
		[CallerCount(0)]
		public unsafe virtual bool IsValidYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x000C8774 File Offset: 0x000C6974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194114, XrefRangeEnd = 194115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidMonth(int year, int month, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000C87E4 File Offset: 0x000C69E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194115, XrefRangeEnd = 194116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidDay(int year, int month, int day, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x000C8864 File Offset: 0x000C6A64
		public unsafe virtual int TwoDigitYearMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x000C88AC File Offset: 0x000C6AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194116, RefRangeEnd = 194117, XrefRangeStart = 194116, XrefRangeEnd = 194116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x000C8900 File Offset: 0x000C6B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194121, RefRangeEnd = 194123, XrefRangeStart = 194117, XrefRangeEnd = 194121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x000C8968 File Offset: 0x000C6B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194123, XrefRangeEnd = 194126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref CalID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultYearValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0000C07B File Offset: 0x0000A27B
		public Calendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000C89B4 File Offset: 0x000C6BB4
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0000C084 File Offset: 0x0000A284
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000C89D0 File Offset: 0x000C6BD0
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0000C092 File Offset: 0x0000A292
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000C89EC File Offset: 0x000C6BEC
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000C8A08 File Offset: 0x000C6C08
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0000C0AE File Offset: 0x0000A2AE
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x000C8A24 File Offset: 0x000C6C24
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000C8A40 File Offset: 0x000C6C40
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x0000C0CA File Offset: 0x0000A2CA
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000C8A5C File Offset: 0x000C6C5C
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x000C8A78 File Offset: 0x000C6C78
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x0000C0E6 File Offset: 0x0000A2E6
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x000C8A94 File Offset: 0x000C6C94
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x000C8AB0 File Offset: 0x000C6CB0
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x0000C102 File Offset: 0x0000A302
		public unsafe static int DaysPerYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPerYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPerYear, (void*)(&value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000C8ACC File Offset: 0x000C6CCC
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x0000C110 File Offset: 0x0000A310
		public unsafe static int DaysPer4Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer4Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer4Years, (void*)(&value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x000C8AE8 File Offset: 0x000C6CE8
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x0000C11E File Offset: 0x0000A31E
		public unsafe static int DaysPer100Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer100Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer100Years, (void*)(&value));
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000C8B04 File Offset: 0x000C6D04
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x0000C12C File Offset: 0x0000A32C
		public unsafe static int DaysPer400Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer400Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer400Years, (void*)(&value));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x000C8B20 File Offset: 0x000C6D20
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x0000C13A File Offset: 0x0000A33A
		public unsafe static int DaysTo10000
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysTo10000, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysTo10000, (void*)(&value));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000C8B3C File Offset: 0x000C6D3C
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x0000C148 File Offset: 0x0000A348
		public unsafe static long MaxMillis
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MaxMillis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MaxMillis, (void*)(&value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000C8B58 File Offset: 0x000C6D58
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x0000C156 File Offset: 0x0000A356
		public unsafe static int CAL_GREGORIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN, (void*)(&value));
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000C8B74 File Offset: 0x000C6D74
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0000C164 File Offset: 0x0000A364
		public unsafe static int CAL_GREGORIAN_US
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US, (void*)(&value));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x000C8B90 File Offset: 0x000C6D90
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0000C172 File Offset: 0x0000A372
		public unsafe static int CAL_JAPAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JAPAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JAPAN, (void*)(&value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x000C8BAC File Offset: 0x000C6DAC
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0000C180 File Offset: 0x0000A380
		public unsafe static int CAL_TAIWAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_TAIWAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_TAIWAN, (void*)(&value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x000C8BC8 File Offset: 0x000C6DC8
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x0000C18E File Offset: 0x0000A38E
		public unsafe static int CAL_KOREA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_KOREA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_KOREA, (void*)(&value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x000C8BE4 File Offset: 0x000C6DE4
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x0000C19C File Offset: 0x0000A39C
		public unsafe static int CAL_HIJRI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_HIJRI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_HIJRI, (void*)(&value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x000C8C00 File Offset: 0x000C6E00
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0000C1AA File Offset: 0x0000A3AA
		public unsafe static int CAL_THAI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_THAI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_THAI, (void*)(&value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x000C8C1C File Offset: 0x000C6E1C
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		public unsafe static int CAL_HEBREW
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_HEBREW, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_HEBREW, (void*)(&value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x000C8C38 File Offset: 0x000C6E38
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x0000C1C6 File Offset: 0x0000A3C6
		public unsafe static int CAL_GREGORIAN_ME_FRENCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH, (void*)(&value));
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000C8C54 File Offset: 0x000C6E54
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public unsafe static int CAL_GREGORIAN_ARABIC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC, (void*)(&value));
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000C8C70 File Offset: 0x000C6E70
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x0000C1E2 File Offset: 0x0000A3E2
		public unsafe static int CAL_GREGORIAN_XLIT_ENGLISH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH, (void*)(&value));
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x000C8C8C File Offset: 0x000C6E8C
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		public unsafe static int CAL_GREGORIAN_XLIT_FRENCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH, (void*)(&value));
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x000C8CA8 File Offset: 0x000C6EA8
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x0000C1FE File Offset: 0x0000A3FE
		public unsafe static int CAL_JULIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JULIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JULIAN, (void*)(&value));
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x000C8CC4 File Offset: 0x000C6EC4
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x0000C20C File Offset: 0x0000A40C
		public unsafe static int CAL_JAPANESELUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000C8CE0 File Offset: 0x000C6EE0
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0000C21A File Offset: 0x0000A41A
		public unsafe static int CAL_CHINESELUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x000C8CFC File Offset: 0x000C6EFC
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0000C228 File Offset: 0x0000A428
		public unsafe static int CAL_SAKA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_SAKA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_SAKA, (void*)(&value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x000C8D18 File Offset: 0x000C6F18
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0000C236 File Offset: 0x0000A436
		public unsafe static int CAL_LUNAR_ETO_CHN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN, (void*)(&value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x000C8D34 File Offset: 0x000C6F34
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0000C244 File Offset: 0x0000A444
		public unsafe static int CAL_LUNAR_ETO_KOR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR, (void*)(&value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000C8D50 File Offset: 0x000C6F50
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0000C252 File Offset: 0x0000A452
		public unsafe static int CAL_LUNAR_ETO_ROKUYOU
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU, (void*)(&value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x000C8D6C File Offset: 0x000C6F6C
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0000C260 File Offset: 0x0000A460
		public unsafe static int CAL_KOREANLUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x000C8D88 File Offset: 0x000C6F88
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0000C26E File Offset: 0x0000A46E
		public unsafe static int CAL_TAIWANLUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x000C8DA4 File Offset: 0x000C6FA4
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x0000C27C File Offset: 0x0000A47C
		public unsafe static int CAL_PERSIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_PERSIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_PERSIAN, (void*)(&value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x0000C28A File Offset: 0x0000A48A
		public unsafe static int CAL_UMALQURA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_UMALQURA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_UMALQURA, (void*)(&value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000C8DDC File Offset: 0x000C6FDC
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x0000C298 File Offset: 0x0000A498
		public unsafe int m_currentEraValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_currentEraValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_currentEraValue)) = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000C8E04 File Offset: 0x000C7004
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x0000C2B3 File Offset: 0x0000A4B3
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000C8E2C File Offset: 0x000C702C
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x0000C2CE File Offset: 0x0000A4CE
		public unsafe static int CurrentEra
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CurrentEra, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CurrentEra, (void*)(&value));
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000C8E48 File Offset: 0x000C7048
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		public unsafe int twoDigitYearMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_twoDigitYearMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_twoDigitYearMax)) = value;
			}
		}

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerYear;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer4Years;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer100Years;

		// Token: 0x0400209B RID: 8347
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer400Years;

		// Token: 0x0400209C RID: 8348
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo10000;

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeFieldInfoPtr_MaxMillis;

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN;

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_US;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JAPAN;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeFieldInfoPtr_CAL_TAIWAN;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeFieldInfoPtr_CAL_KOREA;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeFieldInfoPtr_CAL_HIJRI;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeFieldInfoPtr_CAL_THAI;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeFieldInfoPtr_CAL_HEBREW;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JULIAN;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeFieldInfoPtr_CAL_CHINESELUNISOLAR;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeFieldInfoPtr_CAL_SAKA;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeFieldInfoPtr_CAL_KOREANLUNISOLAR;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeFieldInfoPtr_CAL_PERSIAN;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeFieldInfoPtr_CAL_UMALQURA;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeFieldInfoPtr_m_currentEraValue;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeFieldInfoPtr_CurrentEra;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeFieldInfoPtr_twoDigitYearMax;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0;
	}
}
