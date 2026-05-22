using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000237 RID: 567
	public class DateTimeFormatInfoScanner : Object
	{
		// Token: 0x06002657 RID: 9815 RVA: 0x000CE6C8 File Offset: 0x000CC8C8
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormatInfoScanner()
		{
			Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfoScanner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr);
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "m_dateWords");
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "s_knownWords");
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_ymdFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "m_ymdFlags");
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669623);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669624);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669625);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669626);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669627);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669628);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669629);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669630);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669631);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669632);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669633);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669634);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669635);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669636);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669637);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669638);
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x000CE874 File Offset: 0x000CCA74
		public unsafe static Dictionary<string, string> KnownWords
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195642, XrefRangeEnd = 195717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000CE8A8 File Offset: 0x000CCAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195717, XrefRangeEnd = 195723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000CE8F8 File Offset: 0x000CCAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195733, RefRangeEnd = 195735, XrefRangeStart = 195723, XrefRangeEnd = 195733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDateWordOrPostfix(string formatPostfix, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000CE94C File Offset: 0x000CCB4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195761, RefRangeEnd = 195763, XrefRangeStart = 195735, XrefRangeEnd = 195761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddDateWords(string pattern, int index, string formatPostfix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000CE9BC File Offset: 0x000CCBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195763, XrefRangeEnd = 195764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ScanRepeatChar(string pattern, char ch, int index, out int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000CEA28 File Offset: 0x000CCC28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195779, RefRangeEnd = 195781, XrefRangeStart = 195764, XrefRangeEnd = 195779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIgnorableSymbols(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x000CEA6C File Offset: 0x000CCC6C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195802, RefRangeEnd = 195808, XrefRangeStart = 195781, XrefRangeEnd = 195802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanDateWord(string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000CEAB0 File Offset: 0x000CCCB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195833, RefRangeEnd = 195834, XrefRangeStart = 195808, XrefRangeEnd = 195833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000CEB00 File Offset: 0x000CCD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195834, XrefRangeEnd = 195836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagGenitiveMonth(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monthNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genitveMonthNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevMonthNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genetiveAbbrevMonthNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000CEB78 File Offset: 0x000CCD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195836, XrefRangeEnd = 195844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monthNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genitveMonthNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevMonthNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genetiveAbbrevMonthNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000CEBF0 File Offset: 0x000CCDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195844, XrefRangeEnd = 195846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(Il2CppStringArray dayNames, Il2CppStringArray abbrevDayNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dayNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevDayNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000CEC44 File Offset: 0x000CCE44
		[CallerCount(0)]
		public unsafe static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000CEC84 File Offset: 0x000CCE84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 195847, RefRangeEnd = 195851, XrefRangeStart = 195846, XrefRangeEnd = 195847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualStringArrays(Il2CppStringArray array1, Il2CppStringArray array2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000CECD8 File Offset: 0x000CCED8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 195858, RefRangeEnd = 195870, XrefRangeStart = 195851, XrefRangeEnd = 195858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayElementsHaveSpace(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000CED1C File Offset: 0x000CCF1C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 195879, RefRangeEnd = 195887, XrefRangeStart = 195870, XrefRangeEnd = 195879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayElementsBeginWithDigit(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000CED60 File Offset: 0x000CCF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195887, XrefRangeEnd = 195893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfoScanner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x0000D021 File Offset: 0x0000B221
		public DateTimeFormatInfoScanner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002669 RID: 9833 RVA: 0x000CED9C File Offset: 0x000CCF9C
		// (set) Token: 0x0600266A RID: 9834 RVA: 0x0000D02A File Offset: 0x0000B22A
		public unsafe List<string> m_dateWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x000CEDCC File Offset: 0x000CCFCC
		// (set) Token: 0x0600266C RID: 9836 RVA: 0x0000D049 File Offset: 0x0000B249
		public unsafe static Dictionary<string, string> s_knownWords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x000CEDF4 File Offset: 0x000CCFF4
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x0000D05B File Offset: 0x0000B25B
		public unsafe DateTimeFormatInfoScanner.FoundDatePattern m_ymdFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_ymdFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_ymdFlags)) = value;
			}
		}

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeFieldInfoPtr_m_dateWords;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeFieldInfoPtr_s_knownWords;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeFieldInfoPtr_m_ymdFlags;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005E1 RID: 1505
		[OriginalName("mscorlib.dll", "", "FoundDatePattern")]
		public enum FoundDatePattern
		{
			// Token: 0x040043C5 RID: 17349
			None,
			// Token: 0x040043C6 RID: 17350
			FoundYearPatternFlag,
			// Token: 0x040043C7 RID: 17351
			FoundMonthPatternFlag,
			// Token: 0x040043C8 RID: 17352
			FoundDayPatternFlag = 4,
			// Token: 0x040043C9 RID: 17353
			FoundYMDPatternFlag = 7
		}
	}
}
