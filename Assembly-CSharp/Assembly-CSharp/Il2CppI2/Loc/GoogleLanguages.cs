using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x0200022F RID: 559
	public static class GoogleLanguages : Object
	{
		// Token: 0x060042B3 RID: 17075 RVA: 0x000F7E38 File Offset: 0x000F6038
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleLanguages()
		{
			Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "GoogleLanguages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr);
			GoogleLanguages.NativeFieldInfoPtr_mLanguageDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, "mLanguageDef");
			GoogleLanguages.NativeMethodInfoPtr_GetLanguageCode_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669830);
			GoogleLanguages.NativeMethodInfoPtr_GetLanguagesForDropdown_Public_Static_List_1_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669831);
			GoogleLanguages.NativeMethodInfoPtr_LanguageMatchesFilter_Private_Static_Boolean_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669832);
			GoogleLanguages.NativeMethodInfoPtr_GetFormatedLanguageName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669833);
			GoogleLanguages.NativeMethodInfoPtr_GetCodedLanguage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669834);
			GoogleLanguages.NativeMethodInfoPtr_UnPackCodeFromLanguageName_Public_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669835);
			GoogleLanguages.NativeMethodInfoPtr_GetGoogleLanguageCode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669836);
			GoogleLanguages.NativeMethodInfoPtr_GetLanguageName_Public_Static_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669837);
			GoogleLanguages.NativeMethodInfoPtr_GetAllInternationalCodes_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669838);
			GoogleLanguages.NativeMethodInfoPtr_LanguageCode_HasJoinedWord_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669839);
			GoogleLanguages.NativeMethodInfoPtr_GetPluralRule_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669840);
			GoogleLanguages.NativeMethodInfoPtr_LanguageHasPluralType_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669841);
			GoogleLanguages.NativeMethodInfoPtr_GetPluralType_Public_Static_ePluralType_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669842);
			GoogleLanguages.NativeMethodInfoPtr_GetPluralTestNumber_Public_Static_Int32_String_ePluralType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669843);
			GoogleLanguages.NativeMethodInfoPtr_inRange_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, 100669844);
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x000F7FA8 File Offset: 0x000F61A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 107405, RefRangeEnd = 107409, XrefRangeStart = 107371, XrefRangeEnd = 107405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Filter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ShowWarnings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetLanguageCode_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x000F7FF4 File Offset: 0x000F61F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107409, XrefRangeEnd = 107473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Filter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(CodesToExclude);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetLanguagesForDropdown_Public_Static_List_1_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x000F804C File Offset: 0x000F624C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107484, RefRangeEnd = 107486, XrefRangeStart = 107473, XrefRangeEnd = 107484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LanguageMatchesFilter(string Language, Il2CppStringArray Filters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Filters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_LanguageMatchesFilter_Private_Static_Boolean_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x000F80A0 File Offset: 0x000F62A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107486, XrefRangeEnd = 107507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFormatedLanguageName(string Language)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetFormatedLanguageName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x000F80DC File Offset: 0x000F62DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107518, RefRangeEnd = 107520, XrefRangeStart = 107507, XrefRangeEnd = 107518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCodedLanguage(string Language, string code)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetCodedLanguage_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x000F812C File Offset: 0x000F632C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107546, RefRangeEnd = 107547, XrefRangeStart = 107520, XrefRangeEnd = 107546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(CodedLanguage);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_UnPackCodeFromLanguageName_Public_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			Language = IL2CPP.Il2CppStringToManaged(intPtr);
			code = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x000F8198 File Offset: 0x000F6398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107563, RefRangeEnd = 107565, XrefRangeStart = 107547, XrefRangeEnd = 107563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGoogleLanguageCode(string InternationalCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(InternationalCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetGoogleLanguageCode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x000F81D4 File Offset: 0x000F63D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107565, XrefRangeEnd = 107588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useParenthesesForRegion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDiscardRegion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetLanguageName_Public_Static_String_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x000F822C File Offset: 0x000F642C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107588, XrefRangeEnd = 107618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetAllInternationalCodes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetAllInternationalCodes_Public_Static_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x000F8260 File Offset: 0x000F6460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107631, RefRangeEnd = 107633, XrefRangeStart = 107618, XrefRangeEnd = 107631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(languageCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_LanguageCode_HasJoinedWord_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x000F82A4 File Offset: 0x000F64A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107648, RefRangeEnd = 107651, XrefRangeStart = 107633, XrefRangeEnd = 107648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPluralRule(string langCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(langCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetPluralRule_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x000F82E8 File Offset: 0x000F64E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107666, RefRangeEnd = 107668, XrefRangeStart = 107651, XrefRangeEnd = 107666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(langCode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pluralType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_LanguageHasPluralType_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x000F833C File Offset: 0x000F653C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107672, RefRangeEnd = 107673, XrefRangeStart = 107668, XrefRangeEnd = 107672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ePluralType GetPluralType(string langCode, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(langCode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetPluralType_Public_Static_ePluralType_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x000F838C File Offset: 0x000F658C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107677, RefRangeEnd = 107679, XrefRangeStart = 107673, XrefRangeEnd = 107677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(langCode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pluralType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_GetPluralTestNumber_Public_Static_Int32_String_ePluralType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000F83DC File Offset: 0x000F65DC
		[CallerCount(0)]
		public unsafe static bool inRange(int amount, int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLanguages.NativeMethodInfoPtr_inRange_Private_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x0002895C File Offset: 0x00026B5C
		public GoogleLanguages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x000F8438 File Offset: 0x000F6638
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x00028965 File Offset: 0x00026B65
		public unsafe static Dictionary<string, GoogleLanguages.LanguageCodeDef> mLanguageDef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleLanguages.NativeFieldInfoPtr_mLanguageDef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GoogleLanguages.LanguageCodeDef>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleLanguages.NativeFieldInfoPtr_mLanguageDef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeFieldInfoPtr_mLanguageDef;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageCode_Public_Static_String_String_Boolean_0;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguagesForDropdown_Public_Static_List_1_String_String_String_0;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeMethodInfoPtr_LanguageMatchesFilter_Private_Static_Boolean_String_Il2CppStringArray_0;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatedLanguageName_Public_Static_String_String_0;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeMethodInfoPtr_GetCodedLanguage_Public_Static_String_String_String_0;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeMethodInfoPtr_UnPackCodeFromLanguageName_Public_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeMethodInfoPtr_GetGoogleLanguageCode_Public_Static_String_String_0;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageName_Public_Static_String_String_Boolean_Boolean_0;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeMethodInfoPtr_GetAllInternationalCodes_Public_Static_List_1_String_0;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeMethodInfoPtr_LanguageCode_HasJoinedWord_Public_Static_Boolean_String_0;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralRule_Private_Static_Int32_String_0;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeMethodInfoPtr_LanguageHasPluralType_Public_Static_Boolean_String_String_0;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralType_Public_Static_ePluralType_String_Int32_0;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralTestNumber_Public_Static_Int32_String_ePluralType_0;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeMethodInfoPtr_inRange_Private_Static_Boolean_Int32_Int32_Int32_0;

		// Token: 0x020003B6 RID: 950
		public sealed class LanguageCodeDef : ValueType
		{
			// Token: 0x0600598F RID: 22927 RVA: 0x00144058 File Offset: 0x00142258
			// Note: this type is marked as 'beforefieldinit'.
			static LanguageCodeDef()
			{
				Il2CppClassPointerStore<GoogleLanguages.LanguageCodeDef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleLanguages>.NativeClassPtr, "LanguageCodeDef");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleLanguages.LanguageCodeDef>.NativeClassPtr);
				GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleLanguages.LanguageCodeDef>.NativeClassPtr, "Code");
				GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_GoogleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleLanguages.LanguageCodeDef>.NativeClassPtr, "GoogleCode");
				GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_HasJoinedWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleLanguages.LanguageCodeDef>.NativeClassPtr, "HasJoinedWords");
				GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_PluralRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleLanguages.LanguageCodeDef>.NativeClassPtr, "PluralRule");
			}

			// Token: 0x06005990 RID: 22928 RVA: 0x000334B8 File Offset: 0x000316B8
			public LanguageCodeDef(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005991 RID: 22929 RVA: 0x000334C1 File Offset: 0x000316C1
			public LanguageCodeDef()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleLanguages.LanguageCodeDef>.NativeClassPtr))
			{
			}

			// Token: 0x170020BA RID: 8378
			// (get) Token: 0x06005992 RID: 22930 RVA: 0x001440D4 File Offset: 0x001422D4
			// (set) Token: 0x06005993 RID: 22931 RVA: 0x000334D3 File Offset: 0x000316D3
			public unsafe string Code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_Code);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_Code), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170020BB RID: 8379
			// (get) Token: 0x06005994 RID: 22932 RVA: 0x001440FC File Offset: 0x001422FC
			// (set) Token: 0x06005995 RID: 22933 RVA: 0x000334F2 File Offset: 0x000316F2
			public unsafe string GoogleCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_GoogleCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_GoogleCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170020BC RID: 8380
			// (get) Token: 0x06005996 RID: 22934 RVA: 0x00144124 File Offset: 0x00142324
			// (set) Token: 0x06005997 RID: 22935 RVA: 0x00033511 File Offset: 0x00031711
			public unsafe bool HasJoinedWords
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_HasJoinedWords);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_HasJoinedWords)) = value;
				}
			}

			// Token: 0x170020BD RID: 8381
			// (get) Token: 0x06005998 RID: 22936 RVA: 0x0014414C File Offset: 0x0014234C
			// (set) Token: 0x06005999 RID: 22937 RVA: 0x0003352C File Offset: 0x0003172C
			public unsafe int PluralRule
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_PluralRule);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLanguages.LanguageCodeDef.NativeFieldInfoPtr_PluralRule)) = value;
				}
			}

			// Token: 0x04003B7B RID: 15227
			private static readonly IntPtr NativeFieldInfoPtr_Code;

			// Token: 0x04003B7C RID: 15228
			private static readonly IntPtr NativeFieldInfoPtr_GoogleCode;

			// Token: 0x04003B7D RID: 15229
			private static readonly IntPtr NativeFieldInfoPtr_HasJoinedWords;

			// Token: 0x04003B7E RID: 15230
			private static readonly IntPtr NativeFieldInfoPtr_PluralRule;
		}
	}
}
