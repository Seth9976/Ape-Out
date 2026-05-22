using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023B RID: 571
	[Serializable]
	public class GregorianCalendarHelper : Object
	{
		// Token: 0x060026A4 RID: 9892 RVA: 0x000CFCF4 File Offset: 0x000CDEF4
		// Note: this type is marked as 'beforefieldinit'.
		static GregorianCalendarHelper()
		{
			Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "GregorianCalendarHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr);
			GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "DaysToMonth365");
			GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "DaysToMonth366");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_maxYear");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_minYear");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_Cal");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_EraInfo");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_eras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_eras");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_minDate");
			GregorianCalendarHelper.NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669665);
			GregorianCalendarHelper.NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669666);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669667);
			GregorianCalendarHelper.NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669668);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669669);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669670);
			GregorianCalendarHelper.NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669671);
			GregorianCalendarHelper.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669672);
			GregorianCalendarHelper.NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669673);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669674);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669675);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669676);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669677);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669678);
			GregorianCalendarHelper.NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669679);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669680);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669681);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669682);
			GregorianCalendarHelper.NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669683);
			GregorianCalendarHelper.NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669684);
			GregorianCalendarHelper.NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669685);
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000CFF68 File Offset: 0x000CE168
		public unsafe int MaxYear
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000CFFA4 File Offset: 0x000CE1A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196018, RefRangeEnd = 196021, XrefRangeStart = 196018, XrefRangeEnd = 196018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GregorianCalendarHelper(Calendar cal, Il2CppReferenceArray<EraInfo> eraInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eraInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x000D0004 File Offset: 0x000CE204
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 196022, RefRangeEnd = 196030, XrefRangeStart = 196021, XrefRangeEnd = 196022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGregorianYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000D005C File Offset: 0x000CE25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196030, XrefRangeEnd = 196031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x000D00B4 File Offset: 0x000CE2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196031, XrefRangeEnd = 196041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDatePart(long ticks, int part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref part;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendarHelper.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000D0118 File Offset: 0x000CE318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196049, RefRangeEnd = 196051, XrefRangeStart = 196041, XrefRangeEnd = 196049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetAbsoluteDate(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000D0174 File Offset: 0x000CE374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196051, XrefRangeEnd = 196055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DateToTicks(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000D01D0 File Offset: 0x000CE3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196059, RefRangeEnd = 196060, XrefRangeStart = 196055, XrefRangeEnd = 196059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000D0238 File Offset: 0x000CE438
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196060, RefRangeEnd = 196066, XrefRangeStart = 196060, XrefRangeEnd = 196060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTicksRange(long ticks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000D0278 File Offset: 0x000CE478
		[CallerCount(0)]
		public unsafe int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000D02C4 File Offset: 0x000CE4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196066, XrefRangeEnd = 196067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000D0310 File Offset: 0x000CE510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196076, RefRangeEnd = 196079, XrefRangeStart = 196067, XrefRangeEnd = 196076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDaysInMonth(int year, int month, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000D0378 File Offset: 0x000CE578
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196080, RefRangeEnd = 196083, XrefRangeStart = 196079, XrefRangeEnd = 196080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDaysInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000D03D0 File Offset: 0x000CE5D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196084, RefRangeEnd = 196087, XrefRangeStart = 196083, XrefRangeEnd = 196084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000D041C File Offset: 0x000CE61C
		public unsafe Il2CppStructArray<int> Eras
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 196096, RefRangeEnd = 196099, XrefRangeStart = 196087, XrefRangeEnd = 196096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000D045C File Offset: 0x000CE65C
		[CallerCount(0)]
		public unsafe int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000D04A8 File Offset: 0x000CE6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196099, XrefRangeEnd = 196100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMonthsInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000D0500 File Offset: 0x000CE700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196101, RefRangeEnd = 196104, XrefRangeStart = 196100, XrefRangeEnd = 196101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x000D054C File Offset: 0x000CE74C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196105, RefRangeEnd = 196108, XrefRangeStart = 196104, XrefRangeEnd = 196105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLeapYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000D05A4 File Offset: 0x000CE7A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196119, RefRangeEnd = 196122, XrefRangeStart = 196108, XrefRangeEnd = 196119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000D0650 File Offset: 0x000CE850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196122, RefRangeEnd = 196123, XrefRangeStart = 196122, XrefRangeEnd = 196122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToFourDigitYear(int year, int twoDigitYearMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref twoDigitYearMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0000D1BD File Offset: 0x0000B3BD
		public GregorianCalendarHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000D06A8 File Offset: 0x000CE8A8
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x0000D1C6 File Offset: 0x0000B3C6
		public unsafe static Il2CppStructArray<int> DaysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000D06D0 File Offset: 0x000CE8D0
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
		public unsafe static Il2CppStructArray<int> DaysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000D06F8 File Offset: 0x000CE8F8
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x0000D1EA File Offset: 0x0000B3EA
		public unsafe int m_maxYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear)) = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000D0720 File Offset: 0x000CE920
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x0000D205 File Offset: 0x0000B405
		public unsafe int m_minYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear)) = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000D0748 File Offset: 0x000CE948
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x0000D220 File Offset: 0x0000B420
		public unsafe Calendar m_Cal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000D0778 File Offset: 0x000CE978
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x0000D23F File Offset: 0x0000B43F
		public unsafe Il2CppReferenceArray<EraInfo> m_EraInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000D07A8 File Offset: 0x000CE9A8
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x0000D25E File Offset: 0x0000B45E
		public unsafe Il2CppStructArray<int> m_eras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_eras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_eras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000D07D8 File Offset: 0x000CE9D8
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x0000D27D File Offset: 0x0000B47D
		public unsafe DateTime m_minDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate)) = value;
			}
		}

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth365;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth366;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeFieldInfoPtr_m_maxYear;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeFieldInfoPtr_m_minYear;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeFieldInfoPtr_m_Cal;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeFieldInfoPtr_m_EraInfo;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeFieldInfoPtr_m_eras;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeFieldInfoPtr_m_minDate;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0;
	}
}
