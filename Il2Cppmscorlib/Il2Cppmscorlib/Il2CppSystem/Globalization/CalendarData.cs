using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022C RID: 556
	public class CalendarData : Object
	{
		// Token: 0x060024AB RID: 9387 RVA: 0x000C8E70 File Offset: 0x000C7070
		// Note: this type is marked as 'beforefieldinit'.
		static CalendarData()
		{
			Il2CppClassPointerStore<CalendarData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CalendarData");
			CalendarData.NativeFieldInfoPtr_MAX_CALENDARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "MAX_CALENDARS");
			CalendarData.NativeFieldInfoPtr_sNativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "sNativeName");
			CalendarData.NativeFieldInfoPtr_saShortDates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saShortDates");
			CalendarData.NativeFieldInfoPtr_saYearMonths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saYearMonths");
			CalendarData.NativeFieldInfoPtr_saLongDates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saLongDates");
			CalendarData.NativeFieldInfoPtr_sMonthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "sMonthDay");
			CalendarData.NativeFieldInfoPtr_saEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saEraNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevEraNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevEnglishEraNames");
			CalendarData.NativeFieldInfoPtr_saDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saDayNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevDayNames");
			CalendarData.NativeFieldInfoPtr_saSuperShortDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saSuperShortDayNames");
			CalendarData.NativeFieldInfoPtr_saMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saMonthNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevMonthNames");
			CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saMonthGenitiveNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevMonthGenitiveNames");
			CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saLeapYearMonthNames");
			CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "iTwoDigitYearMax");
			CalendarData.NativeFieldInfoPtr_iCurrentEra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "iCurrentEra");
			CalendarData.NativeFieldInfoPtr_bUseUserOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "bUseUserOverrides");
			CalendarData.NativeFieldInfoPtr_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "Invariant");
			CalendarData.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669473);
			CalendarData.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669475);
			CalendarData.NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669476);
			CalendarData.NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669477);
			CalendarData.NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669478);
			CalendarData.NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669479);
			CalendarData.NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669480);
			CalendarData.NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669481);
			CalendarData.NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669482);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000C90F0 File Offset: 0x000C72F0
		[CallerCount(0)]
		public unsafe CalendarData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalendarData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000C912C File Offset: 0x000C732C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194206, RefRangeEnd = 194207, XrefRangeStart = 194126, XrefRangeEnd = 194206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalendarData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseUserOverrides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000C9194 File Offset: 0x000C7394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194230, RefRangeEnd = 194231, XrefRangeStart = 194207, XrefRangeEnd = 194230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeEraNames(string localeName, int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000C91E4 File Offset: 0x000C73E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194238, RefRangeEnd = 194239, XrefRangeStart = 194231, XrefRangeEnd = 194238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAbbreviatedEraNames(string localeName, int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000C9234 File Offset: 0x000C7434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194239, XrefRangeEnd = 194277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CalendarData GetCalendarData(int calendarId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr3) : null;
			}
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000C9274 File Offset: 0x000C7474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194277, XrefRangeEnd = 194288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CalendarIdToCultureName(int calendarId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000C92AC File Offset: 0x000C74AC
		[CallerCount(0)]
		public unsafe static int nativeGetTwoDigitYearMax(int calID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000C92EC File Offset: 0x000C74EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194288, XrefRangeEnd = 194291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000C9350 File Offset: 0x000C7550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194291, XrefRangeEnd = 194292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool fill_calendar_data(string localeName, int datetimeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref datetimeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0000C2F7 File Offset: 0x0000A4F7
		public CalendarData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000C93AC File Offset: 0x000C75AC
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0000C300 File Offset: 0x0000A500
		public unsafe static int MAX_CALENDARS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_MAX_CALENDARS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_MAX_CALENDARS, (void*)(&value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000C93C8 File Offset: 0x000C75C8
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x0000C30E File Offset: 0x0000A50E
		public unsafe string sNativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sNativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sNativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000C93F0 File Offset: 0x000C75F0
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0000C32D File Offset: 0x0000A52D
		public unsafe Il2CppStringArray saShortDates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saShortDates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saShortDates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000C9420 File Offset: 0x000C7620
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x0000C34C File Offset: 0x0000A54C
		public unsafe Il2CppStringArray saYearMonths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saYearMonths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saYearMonths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000C9450 File Offset: 0x000C7650
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0000C36B File Offset: 0x0000A56B
		public unsafe Il2CppStringArray saLongDates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLongDates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLongDates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x000C9480 File Offset: 0x000C7680
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x0000C38A File Offset: 0x0000A58A
		public unsafe string sMonthDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sMonthDay);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sMonthDay), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000C94A8 File Offset: 0x000C76A8
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0000C3A9 File Offset: 0x0000A5A9
		public unsafe Il2CppStringArray saEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000C94D8 File Offset: 0x000C76D8
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0000C3C8 File Offset: 0x0000A5C8
		public unsafe Il2CppStringArray saAbbrevEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000C9508 File Offset: 0x000C7708
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000C3E7 File Offset: 0x0000A5E7
		public unsafe Il2CppStringArray saAbbrevEnglishEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000C9538 File Offset: 0x000C7738
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0000C406 File Offset: 0x0000A606
		public unsafe Il2CppStringArray saDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000C9568 File Offset: 0x000C7768
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x0000C425 File Offset: 0x0000A625
		public unsafe Il2CppStringArray saAbbrevDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000C9598 File Offset: 0x000C7798
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x0000C444 File Offset: 0x0000A644
		public unsafe Il2CppStringArray saSuperShortDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saSuperShortDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saSuperShortDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x000C95C8 File Offset: 0x000C77C8
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0000C463 File Offset: 0x0000A663
		public unsafe Il2CppStringArray saMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000C95F8 File Offset: 0x000C77F8
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x0000C482 File Offset: 0x0000A682
		public unsafe Il2CppStringArray saAbbrevMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000C9628 File Offset: 0x000C7828
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0000C4A1 File Offset: 0x0000A6A1
		public unsafe Il2CppStringArray saMonthGenitiveNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000C9658 File Offset: 0x000C7858
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		public unsafe Il2CppStringArray saAbbrevMonthGenitiveNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000C9688 File Offset: 0x000C7888
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0000C4DF File Offset: 0x0000A6DF
		public unsafe Il2CppStringArray saLeapYearMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x000C96B8 File Offset: 0x000C78B8
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x0000C4FE File Offset: 0x0000A6FE
		public unsafe int iTwoDigitYearMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax)) = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x000C96E0 File Offset: 0x000C78E0
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x0000C519 File Offset: 0x0000A719
		public unsafe int iCurrentEra
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iCurrentEra);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iCurrentEra)) = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000C9708 File Offset: 0x000C7908
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x0000C534 File Offset: 0x0000A734
		public unsafe bool bUseUserOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_bUseUserOverrides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_bUseUserOverrides)) = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000C9730 File Offset: 0x000C7930
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x0000C54F File Offset: 0x0000A74F
		public unsafe static CalendarData Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CALENDARS;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeFieldInfoPtr_sNativeName;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeFieldInfoPtr_saShortDates;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeFieldInfoPtr_saYearMonths;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeFieldInfoPtr_saLongDates;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeFieldInfoPtr_sMonthDay;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeFieldInfoPtr_saEraNames;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevEraNames;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevEnglishEraNames;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_saDayNames;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevDayNames;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_saSuperShortDayNames;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeFieldInfoPtr_saMonthNames;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevMonthNames;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_saMonthGenitiveNames;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevMonthGenitiveNames;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr_saLeapYearMonthNames;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeFieldInfoPtr_iTwoDigitYearMax;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeFieldInfoPtr_iCurrentEra;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr_bUseUserOverrides;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr_Invariant;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0;
	}
}
