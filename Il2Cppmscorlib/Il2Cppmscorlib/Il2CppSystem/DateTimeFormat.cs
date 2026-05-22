using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000AA RID: 170
	public static class DateTimeFormat : Object
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x00059E30 File Offset: 0x00058030
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormat()
		{
			Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeFormat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr);
			DateTimeFormat.NativeFieldInfoPtr_NullOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "NullOffset");
			DateTimeFormat.NativeFieldInfoPtr_allStandardFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "allStandardFormats");
			DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "fixedNumberFormats");
			DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665338);
			DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665339);
			DateTimeFormat.NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665340);
			DateTimeFormat.NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665341);
			DateTimeFormat.NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665342);
			DateTimeFormat.NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665343);
			DateTimeFormat.NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665344);
			DateTimeFormat.NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_String_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665345);
			DateTimeFormat.NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665346);
			DateTimeFormat.NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_String_Int32_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665347);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665348);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_String_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665349);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665350);
			DateTimeFormat.NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665351);
			DateTimeFormat.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665352);
			DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665353);
			DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665354);
			DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665355);
			DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForUtc_Internal_Static_Void_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665356);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0005A018 File Offset: 0x00058218
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 155105, RefRangeEnd = 155113, XrefRangeStart = 155101, XrefRangeEnd = 155105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatDigits(StringBuilder outputBuffer, int value, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0005A06C File Offset: 0x0005826C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155114, RefRangeEnd = 155116, XrefRangeStart = 155113, XrefRangeEnd = 155114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideLengthLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0005A0CC File Offset: 0x000582CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155122, RefRangeEnd = 155124, XrefRangeStart = 155116, XrefRangeEnd = 155122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HebrewFormatDigits(StringBuilder outputBuffer, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0005A110 File Offset: 0x00058310
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 155124, RefRangeEnd = 155141, XrefRangeStart = 155124, XrefRangeEnd = 155124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseRepeatPattern(string format, int pos, char patternChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_String_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0005A170 File Offset: 0x00058370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155141, XrefRangeEnd = 155144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayOfWeek;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0005A1C8 File Offset: 0x000583C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155144, XrefRangeEnd = 155147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0005A220 File Offset: 0x00058420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155148, RefRangeEnd = 155149, XrefRangeStart = 155147, XrefRangeEnd = 155148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0005A288 File Offset: 0x00058488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155152, RefRangeEnd = 155154, XrefRangeStart = 155149, XrefRangeEnd = 155152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseQuoteString(string format, int pos, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_String_Int32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0005A2EC File Offset: 0x000584EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155154, RefRangeEnd = 155158, XrefRangeStart = 155154, XrefRangeEnd = 155154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNextChar(string format, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0005A33C File Offset: 0x0005853C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155161, RefRangeEnd = 155162, XrefRangeStart = 155158, XrefRangeEnd = 155161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternToMatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_String_Int32_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0005A3A8 File Offset: 0x000585A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155330, RefRangeEnd = 155332, XrefRangeStart = 155162, XrefRangeEnd = 155330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0005A414 File Offset: 0x00058614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155381, RefRangeEnd = 155382, XrefRangeStart = 155332, XrefRangeEnd = 155381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOnly;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_String_Int32_Boolean_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0005A498 File Offset: 0x00058698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155396, RefRangeEnd = 155397, XrefRangeStart = 155382, XrefRangeEnd = 155396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0005A4EC File Offset: 0x000586EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155403, XrefRangeStart = 155397, XrefRangeEnd = 155401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRealFormat(string format, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_String_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0005A53C File Offset: 0x0005873C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155469, RefRangeEnd = 155470, XrefRangeStart = 155403, XrefRangeEnd = 155469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dateTime;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0005A5C0 File Offset: 0x000587C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155475, RefRangeEnd = 155479, XrefRangeStart = 155470, XrefRangeEnd = 155475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0005A61C File Offset: 0x0005881C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155508, RefRangeEnd = 155511, XrefRangeStart = 155479, XrefRangeEnd = 155508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0005A688 File Offset: 0x00058888
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvalidFormatForLocal(string format, DateTime dateTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0005A6CC File Offset: 0x000588CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvalidFormatForUtc(string format, DateTime dateTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForUtc_Internal_Static_Void_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0000514B File Offset: 0x0000334B
		public DateTimeFormat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0005A710 File Offset: 0x00058910
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00005154 File Offset: 0x00003354
		public unsafe static TimeSpan NullOffset
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_NullOffset, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_NullOffset, (void*)(&value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0005A72C File Offset: 0x0005892C
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00005162 File Offset: 0x00003362
		public unsafe static Il2CppStructArray<char> allStandardFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_allStandardFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_allStandardFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0005A754 File Offset: 0x00058954
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x00005174 File Offset: 0x00003374
		public unsafe static Il2CppStringArray fixedNumberFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_NullOffset;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_allStandardFormats;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr_fixedNumberFormats;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_String_Int32_Char_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_String_Int32_StringBuilder_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_String_Int32_Int32_Char_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomized_Private_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_String_Int32_Boolean_StringBuilder_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_String_DateTimeFormatInfo_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_String_DateTime_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_InvalidFormatForUtc_Internal_Static_Void_String_DateTime_0;
	}
}
