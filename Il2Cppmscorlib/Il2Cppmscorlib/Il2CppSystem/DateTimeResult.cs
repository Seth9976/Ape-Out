using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000B3 RID: 179
	public sealed class DateTimeResult : ValueType
	{
		// Token: 0x06000CB3 RID: 3251 RVA: 0x0005D9E8 File Offset: 0x0005BBE8
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeResult()
		{
			Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr);
			DateTimeResult.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Year");
			DateTimeResult.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Month");
			DateTimeResult.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Day");
			DateTimeResult.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Hour");
			DateTimeResult.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Minute");
			DateTimeResult.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Second");
			DateTimeResult.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "fraction");
			DateTimeResult.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "era");
			DateTimeResult.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "flags");
			DateTimeResult.NativeFieldInfoPtr_timeZoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "timeZoneOffset");
			DateTimeResult.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "calendar");
			DateTimeResult.NativeFieldInfoPtr_parsedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "parsedDate");
			DateTimeResult.NativeFieldInfoPtr_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failure");
			DateTimeResult.NativeFieldInfoPtr_failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureMessageID");
			DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureMessageFormatArgument");
			DateTimeResult.NativeFieldInfoPtr_failureArgumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureArgumentName");
			DateTimeResult.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665463);
			DateTimeResult.NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665464);
			DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665465);
			DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665466);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0005DBA8 File Offset: 0x0005BDA8
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0005DBE0 File Offset: 0x0005BDE0
		[CallerCount(0)]
		public unsafe void SetDate(int year, int month, int day)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0005DC40 File Offset: 0x0005BE40
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 157112, RefRangeEnd = 157149, XrefRangeStart = 157112, XrefRangeEnd = 157112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref failure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0005DCA8 File Offset: 0x0005BEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157149, RefRangeEnd = 157151, XrefRangeStart = 157149, XrefRangeEnd = 157149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument, string failureArgumentName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref failure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureArgumentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00005354 File Offset: 0x00003554
		public DateTimeResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0000535D File Offset: 0x0000355D
		public DateTimeResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr))
		{
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0005DD24 File Offset: 0x0005BF24
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0000536F File Offset: 0x0000356F
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0005DD4C File Offset: 0x0005BF4C
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0000538A File Offset: 0x0000358A
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0005DD74 File Offset: 0x0005BF74
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x000053A5 File Offset: 0x000035A5
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0005DD9C File Offset: 0x0005BF9C
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x000053C0 File Offset: 0x000035C0
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0005DDC4 File Offset: 0x0005BFC4
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x000053DB File Offset: 0x000035DB
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0005DDEC File Offset: 0x0005BFEC
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x000053F6 File Offset: 0x000035F6
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0005DE14 File Offset: 0x0005C014
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00005411 File Offset: 0x00003611
		public unsafe double fraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_fraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_fraction)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0005DE3C File Offset: 0x0005C03C
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x0000542C File Offset: 0x0000362C
		public unsafe int era
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_era);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_era)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0005DE64 File Offset: 0x0005C064
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00005447 File Offset: 0x00003647
		public unsafe ParseFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0005DE8C File Offset: 0x0005C08C
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00005462 File Offset: 0x00003662
		public unsafe TimeSpan timeZoneOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_timeZoneOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_timeZoneOffset)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0005DEB4 File Offset: 0x0005C0B4
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x0000547D File Offset: 0x0000367D
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0005DEE4 File Offset: 0x0005C0E4
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x0000549C File Offset: 0x0000369C
		public unsafe DateTime parsedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_parsedDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_parsedDate)) = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0005DF0C File Offset: 0x0005C10C
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x000054B7 File Offset: 0x000036B7
		public unsafe ParseFailureKind failure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failure)) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0005DF34 File Offset: 0x0005C134
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x000054D2 File Offset: 0x000036D2
		public unsafe string failureMessageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0005DF5C File Offset: 0x0005C15C
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x000054F1 File Offset: 0x000036F1
		public unsafe Object failureMessageFormatArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0005DF8C File Offset: 0x0005C18C
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00005510 File Offset: 0x00003710
		public unsafe string failureArgumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureArgumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureArgumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_fraction;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_timeZoneOffset;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_parsedDate;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_failure;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_failureMessageID;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_failureMessageFormatArgument;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_failureArgumentName;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0;
	}
}
