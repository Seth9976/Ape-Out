using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000248 RID: 584
	public static class TimeSpanFormat : Object
	{
		// Token: 0x0600280E RID: 10254 RVA: 0x000D5A54 File Offset: 0x000D3C54
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanFormat()
		{
			Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TimeSpanFormat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr);
			TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "PositiveInvariantFormatLiterals");
			TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "NegativeInvariantFormatLiterals");
			TimeSpanFormat.NativeMethodInfoPtr_IntToString_Private_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669862);
			TimeSpanFormat.NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669863);
			TimeSpanFormat.NativeMethodInfoPtr_FormatStandard_Private_Static_String_TimeSpan_Boolean_String_Pattern_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669864);
			TimeSpanFormat.NativeMethodInfoPtr_FormatCustomized_Internal_Static_String_TimeSpan_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669865);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000D5AFC File Offset: 0x000D3CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198024, XrefRangeEnd = 198025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(int n, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_IntToString_Private_Static_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000D5B44 File Offset: 0x000D3D44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198039, RefRangeEnd = 198042, XrefRangeStart = 198025, XrefRangeEnd = 198039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000D5BA0 File Offset: 0x000D3DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198089, RefRangeEnd = 198090, XrefRangeStart = 198042, XrefRangeEnd = 198089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInvariant;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pattern;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_FormatStandard_Private_Static_String_TimeSpan_Boolean_String_Pattern_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000D5C08 File Offset: 0x000D3E08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198177, RefRangeEnd = 198179, XrefRangeStart = 198090, XrefRangeEnd = 198177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_FormatCustomized_Internal_Static_String_TimeSpan_String_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0000D9DB File Offset: 0x0000BBDB
		public TimeSpanFormat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x000D5C64 File Offset: 0x000D3E64
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		public unsafe static TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals, intPtr);
				return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x000D5CA0 File Offset: 0x000D3EA0
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x0000D9FB File Offset: 0x0000BBFB
		public unsafe static TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals, intPtr);
				return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeFieldInfoPtr_PositiveInvariantFormatLiterals;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeFieldInfoPtr_NegativeInvariantFormatLiterals;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Private_Static_String_Int32_Int32_0;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeMethodInfoPtr_FormatStandard_Private_Static_String_TimeSpan_Boolean_String_Pattern_0;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomized_Internal_Static_String_TimeSpan_String_DateTimeFormatInfo_0;

		// Token: 0x020005E5 RID: 1509
		[OriginalName("mscorlib.dll", "", "Pattern")]
		public enum Pattern
		{
			// Token: 0x040043EE RID: 17390
			None,
			// Token: 0x040043EF RID: 17391
			Minimum,
			// Token: 0x040043F0 RID: 17392
			Full
		}

		// Token: 0x020005E6 RID: 1510
		public sealed class FormatLiterals : ValueType
		{
			// Token: 0x060053D1 RID: 21457 RVA: 0x001797FC File Offset: 0x001779FC
			// Note: this type is marked as 'beforefieldinit'.
			static FormatLiterals()
			{
				Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "FormatLiterals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr);
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "AppCompatLiteral");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "dd");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "hh");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "mm");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "ss");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "ff");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_literals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "literals");
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_Start_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669867);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669868);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669869);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669870);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669871);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_End_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669872);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669873);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669874);
			}

			// Token: 0x17001582 RID: 5506
			// (get) Token: 0x060053D2 RID: 21458 RVA: 0x00179954 File Offset: 0x00177B54
			public unsafe string Start
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_Start_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001583 RID: 5507
			// (get) Token: 0x060053D3 RID: 21459 RVA: 0x00179990 File Offset: 0x00177B90
			public unsafe string DayHourSep
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001584 RID: 5508
			// (get) Token: 0x060053D4 RID: 21460 RVA: 0x001799CC File Offset: 0x00177BCC
			public unsafe string HourMinuteSep
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001585 RID: 5509
			// (get) Token: 0x060053D5 RID: 21461 RVA: 0x00179A08 File Offset: 0x00177C08
			public unsafe string MinuteSecondSep
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001586 RID: 5510
			// (get) Token: 0x060053D6 RID: 21462 RVA: 0x00179A44 File Offset: 0x00177C44
			public unsafe string SecondFractionSep
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001587 RID: 5511
			// (get) Token: 0x060053D7 RID: 21463 RVA: 0x00179A80 File Offset: 0x00177C80
			public unsafe string End
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_End_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060053D8 RID: 21464 RVA: 0x00179ABC File Offset: 0x00177CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197963, XrefRangeEnd = 197996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isNegative;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new TimeSpanFormat.FormatLiterals(intPtr);
				}
			}

			// Token: 0x060053D9 RID: 21465 RVA: 0x00179AF4 File Offset: 0x00177CF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 198023, RefRangeEnd = 198024, XrefRangeStart = 197996, XrefRangeEnd = 198023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(string format, bool useInvariantFieldLengths)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInvariantFieldLengths;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053DA RID: 21466 RVA: 0x0001F8DF File Offset: 0x0001DADF
			public FormatLiterals(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060053DB RID: 21467 RVA: 0x0001F8E8 File Offset: 0x0001DAE8
			public FormatLiterals()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr))
			{
			}

			// Token: 0x1700157B RID: 5499
			// (get) Token: 0x060053DC RID: 21468 RVA: 0x00179B4C File Offset: 0x00177D4C
			// (set) Token: 0x060053DD RID: 21469 RVA: 0x0001F8FA File Offset: 0x0001DAFA
			public unsafe string AppCompatLiteral
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700157C RID: 5500
			// (get) Token: 0x060053DE RID: 21470 RVA: 0x00179B74 File Offset: 0x00177D74
			// (set) Token: 0x060053DF RID: 21471 RVA: 0x0001F919 File Offset: 0x0001DB19
			public unsafe int dd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd)) = value;
				}
			}

			// Token: 0x1700157D RID: 5501
			// (get) Token: 0x060053E0 RID: 21472 RVA: 0x00179B9C File Offset: 0x00177D9C
			// (set) Token: 0x060053E1 RID: 21473 RVA: 0x0001F934 File Offset: 0x0001DB34
			public unsafe int hh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh)) = value;
				}
			}

			// Token: 0x1700157E RID: 5502
			// (get) Token: 0x060053E2 RID: 21474 RVA: 0x00179BC4 File Offset: 0x00177DC4
			// (set) Token: 0x060053E3 RID: 21475 RVA: 0x0001F94F File Offset: 0x0001DB4F
			public unsafe int mm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm)) = value;
				}
			}

			// Token: 0x1700157F RID: 5503
			// (get) Token: 0x060053E4 RID: 21476 RVA: 0x00179BEC File Offset: 0x00177DEC
			// (set) Token: 0x060053E5 RID: 21477 RVA: 0x0001F96A File Offset: 0x0001DB6A
			public unsafe int ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss)) = value;
				}
			}

			// Token: 0x17001580 RID: 5504
			// (get) Token: 0x060053E6 RID: 21478 RVA: 0x00179C14 File Offset: 0x00177E14
			// (set) Token: 0x060053E7 RID: 21479 RVA: 0x0001F985 File Offset: 0x0001DB85
			public unsafe int ff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff)) = value;
				}
			}

			// Token: 0x17001581 RID: 5505
			// (get) Token: 0x060053E8 RID: 21480 RVA: 0x00179C3C File Offset: 0x00177E3C
			// (set) Token: 0x060053E9 RID: 21481 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
			public unsafe Il2CppStringArray literals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_literals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_literals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043F1 RID: 17393
			private static readonly IntPtr NativeFieldInfoPtr_AppCompatLiteral;

			// Token: 0x040043F2 RID: 17394
			private static readonly IntPtr NativeFieldInfoPtr_dd;

			// Token: 0x040043F3 RID: 17395
			private static readonly IntPtr NativeFieldInfoPtr_hh;

			// Token: 0x040043F4 RID: 17396
			private static readonly IntPtr NativeFieldInfoPtr_mm;

			// Token: 0x040043F5 RID: 17397
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x040043F6 RID: 17398
			private static readonly IntPtr NativeFieldInfoPtr_ff;

			// Token: 0x040043F7 RID: 17399
			private static readonly IntPtr NativeFieldInfoPtr_literals;

			// Token: 0x040043F8 RID: 17400
			private static readonly IntPtr NativeMethodInfoPtr_get_Start_Internal_get_String_0;

			// Token: 0x040043F9 RID: 17401
			private static readonly IntPtr NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0;

			// Token: 0x040043FA RID: 17402
			private static readonly IntPtr NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0;

			// Token: 0x040043FB RID: 17403
			private static readonly IntPtr NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0;

			// Token: 0x040043FC RID: 17404
			private static readonly IntPtr NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0;

			// Token: 0x040043FD RID: 17405
			private static readonly IntPtr NativeMethodInfoPtr_get_End_Internal_get_String_0;

			// Token: 0x040043FE RID: 17406
			private static readonly IntPtr NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0;

			// Token: 0x040043FF RID: 17407
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0;
		}
	}
}
