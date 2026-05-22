using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine.Networking;

namespace Il2CppI2.Loc
{
	// Token: 0x02000230 RID: 560
	public static class GoogleTranslation : Object
	{
		// Token: 0x060042C6 RID: 17094 RVA: 0x000F8460 File Offset: 0x000F6660
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleTranslation()
		{
			Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "GoogleTranslation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr);
			GoogleTranslation.NativeFieldInfoPtr_mCurrentTranslations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, "mCurrentTranslations");
			GoogleTranslation.NativeFieldInfoPtr_mTranslationJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, "mTranslationJobs");
			GoogleTranslation.NativeMethodInfoPtr_CanTranslate_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669846);
			GoogleTranslation.NativeMethodInfoPtr_Translate_Public_Static_Void_String_String_String_fnOnTranslated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669847);
			GoogleTranslation.NativeMethodInfoPtr_ForceTranslate_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669848);
			GoogleTranslation.NativeMethodInfoPtr_Translate_Public_Static_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669849);
			GoogleTranslation.NativeMethodInfoPtr_ForceTranslate_Public_Static_Boolean_Dictionary_2_String_TranslationQuery_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669850);
			GoogleTranslation.NativeMethodInfoPtr_ConvertTranslationRequest_Public_Static_List_1_String_Dictionary_2_String_TranslationQuery_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669851);
			GoogleTranslation.NativeMethodInfoPtr_AddTranslationJob_Private_Static_Void_TranslationJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669852);
			GoogleTranslation.NativeMethodInfoPtr_WaitForTranslations_Private_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669853);
			GoogleTranslation.NativeMethodInfoPtr_ParseTranslationResult_Public_Static_String_String_Dictionary_2_String_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669854);
			GoogleTranslation.NativeMethodInfoPtr_IsTranslating_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669855);
			GoogleTranslation.NativeMethodInfoPtr_CancelCurrentGoogleTranslations_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669856);
			GoogleTranslation.NativeMethodInfoPtr_CreateQueries_Public_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669857);
			GoogleTranslation.NativeMethodInfoPtr_CreateQueries_Plurals_Private_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669858);
			GoogleTranslation.NativeMethodInfoPtr_AddQuery_Public_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669859);
			GoogleTranslation.NativeMethodInfoPtr_GetTranslation_Private_Static_String_String_String_Dictionary_2_String_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669860);
			GoogleTranslation.NativeMethodInfoPtr_FindQueryFromOrigText_Private_Static_TranslationQuery_String_Dictionary_2_String_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669861);
			GoogleTranslation.NativeMethodInfoPtr_HasParameters_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669862);
			GoogleTranslation.NativeMethodInfoPtr_GetPluralParameter_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669863);
			GoogleTranslation.NativeMethodInfoPtr_GetPluralText_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669864);
			GoogleTranslation.NativeMethodInfoPtr_FindClosingTag_Private_Static_Int32_String_MatchCollection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669865);
			GoogleTranslation.NativeMethodInfoPtr_GetGoogleNoTranslateTag_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669866);
			GoogleTranslation.NativeMethodInfoPtr_ParseNonTranslatableElements_Private_Static_Void_byref_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669867);
			GoogleTranslation.NativeMethodInfoPtr_GetQueryResult_Public_Static_String_String_String_Dictionary_2_String_TranslationQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669868);
			GoogleTranslation.NativeMethodInfoPtr_RebuildTranslation_Public_Static_String_String_Dictionary_2_String_TranslationQuery_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669869);
			GoogleTranslation.NativeMethodInfoPtr_RebuildTranslation_Plural_Private_Static_String_String_Dictionary_2_String_TranslationQuery_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669870);
			GoogleTranslation.NativeMethodInfoPtr_UppercaseFirst_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669871);
			GoogleTranslation.NativeMethodInfoPtr_TitleCase_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, 100669872);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x000F86D4 File Offset: 0x000F68D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107716, XrefRangeEnd = 107721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanTranslate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_CanTranslate_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x000F8704 File Offset: 0x000F6904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107761, RefRangeEnd = 107762, XrefRangeStart = 107721, XrefRangeEnd = 107761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, GoogleTranslation.fnOnTranslated OnTranslationReady)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnTranslationReady);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_Translate_Public_Static_Void_String_String_String_fnOnTranslated_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x000F8770 File Offset: 0x000F6970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107762, XrefRangeEnd = 107784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_ForceTranslate_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x000F87D0 File Offset: 0x000F69D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107807, RefRangeEnd = 107809, XrefRangeStart = 107784, XrefRangeEnd = 107807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Translate(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnTranslationReady);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usePOST;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_Translate_Public_Static_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x000F8828 File Offset: 0x000F6A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107809, XrefRangeEnd = 107813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usePOST;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_ForceTranslate_Public_Static_Boolean_Dictionary_2_String_TranslationQuery_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x000F8878 File Offset: 0x000F6A78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107875, RefRangeEnd = 107878, XrefRangeStart = 107813, XrefRangeEnd = 107875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encodeGET;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_ConvertTranslationRequest_Public_Static_List_1_String_Dictionary_2_String_TranslationQuery_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x000F88CC File Offset: 0x000F6ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107878, XrefRangeEnd = 107893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddTranslationJob(TranslationJob job)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(job);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_AddTranslationJob_Private_Static_Void_TranslationJob_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x000F8904 File Offset: 0x000F6B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107893, XrefRangeEnd = 107896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator WaitForTranslations()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_WaitForTranslations_Private_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x000F8938 File Offset: 0x000F6B38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107952, RefRangeEnd = 107955, XrefRangeStart = 107896, XrefRangeEnd = 107952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(html);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_ParseTranslationResult_Public_Static_String_String_Dictionary_2_String_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x000F8988 File Offset: 0x000F6B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107955, XrefRangeEnd = 107961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTranslating()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_IsTranslating_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x000F89B8 File Offset: 0x000F6BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107961, XrefRangeEnd = 107981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelCurrentGoogleTranslations()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_CancelCurrentGoogleTranslations_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x000F89E0 File Offset: 0x000F6BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108005, RefRangeEnd = 108006, XrefRangeStart = 107981, XrefRangeEnd = 108005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_CreateQueries_Public_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x000F8A4C File Offset: 0x000F6C4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108036, RefRangeEnd = 108038, XrefRangeStart = 108006, XrefRangeEnd = 108036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_CreateQueries_Plurals_Private_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x000F8AB8 File Offset: 0x000F6CB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 108068, RefRangeEnd = 108076, XrefRangeStart = 108038, XrefRangeEnd = 108068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_AddQuery_Public_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x000F8B24 File Offset: 0x000F6D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108083, RefRangeEnd = 108084, XrefRangeStart = 108076, XrefRangeEnd = 108083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_GetTranslation_Private_Static_String_String_String_Dictionary_2_String_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x000F8B84 File Offset: 0x000F6D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108093, RefRangeEnd = 108094, XrefRangeStart = 108084, XrefRangeEnd = 108093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(origText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_FindQueryFromOrigText_Private_Static_TranslationQuery_String_Dictionary_2_String_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TranslationQuery(intPtr);
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x000F8BD4 File Offset: 0x000F6DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108108, RefRangeEnd = 108110, XrefRangeStart = 108094, XrefRangeEnd = 108108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasParameters(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_HasParameters_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x000F8C18 File Offset: 0x000F6E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108132, RefRangeEnd = 108134, XrefRangeStart = 108110, XrefRangeEnd = 108132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPluralParameter(string text, bool forceTag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceTag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_GetPluralParameter_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x000F8C64 File Offset: 0x000F6E64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108160, RefRangeEnd = 108162, XrefRangeStart = 108134, XrefRangeEnd = 108160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPluralText(string text, string pluralType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pluralType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_GetPluralText_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x000F8CB4 File Offset: 0x000F6EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108167, RefRangeEnd = 108168, XrefRangeStart = 108162, XrefRangeEnd = 108167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matches);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_FindClosingTag_Private_Static_Int32_String_MatchCollection_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x000F8D18 File Offset: 0x000F6F18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 108174, RefRangeEnd = 108179, XrefRangeStart = 108168, XrefRangeEnd = 108174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGoogleNoTranslateTag(int tagNumber)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tagNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_GetGoogleNoTranslateTag_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x000F8D50 File Offset: 0x000F6F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108248, RefRangeEnd = 108249, XrefRangeStart = 108179, XrefRangeEnd = 108248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(query));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_ParseNonTranslatableElements_Private_Static_Void_byref_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x000F8D8C File Offset: 0x000F6F8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 108255, RefRangeEnd = 108262, XrefRangeStart = 108249, XrefRangeEnd = 108255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_GetQueryResult_Public_Static_String_String_String_Dictionary_2_String_TranslationQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x000F8DEC File Offset: 0x000F6FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108297, RefRangeEnd = 108298, XrefRangeStart = 108262, XrefRangeEnd = 108297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_RebuildTranslation_Public_Static_String_String_Dictionary_2_String_TranslationQuery_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x000F8E4C File Offset: 0x000F704C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108343, RefRangeEnd = 108344, XrefRangeStart = 108298, XrefRangeEnd = 108343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCodeTo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_RebuildTranslation_Plural_Private_Static_String_String_Dictionary_2_String_TranslationQuery_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x000F8EAC File Offset: 0x000F70AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108353, RefRangeEnd = 108357, XrefRangeStart = 108344, XrefRangeEnd = 108353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UppercaseFirst(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_UppercaseFirst_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x000F8EE8 File Offset: 0x000F70E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 108365, RefRangeEnd = 108372, XrefRangeStart = 108357, XrefRangeEnd = 108365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TitleCase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.NativeMethodInfoPtr_TitleCase_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x00028977 File Offset: 0x00026B77
		public GoogleTranslation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x000F8F24 File Offset: 0x000F7124
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x00028980 File Offset: 0x00026B80
		public unsafe static List<UnityWebRequest> mCurrentTranslations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleTranslation.NativeFieldInfoPtr_mCurrentTranslations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityWebRequest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleTranslation.NativeFieldInfoPtr_mCurrentTranslations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x000F8F4C File Offset: 0x000F714C
		// (set) Token: 0x060042E6 RID: 17126 RVA: 0x00028992 File Offset: 0x00026B92
		public unsafe static List<TranslationJob> mTranslationJobs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleTranslation.NativeFieldInfoPtr_mTranslationJobs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TranslationJob>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleTranslation.NativeFieldInfoPtr_mTranslationJobs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeFieldInfoPtr_mCurrentTranslations;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeFieldInfoPtr_mTranslationJobs;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr_CanTranslate_Public_Static_Boolean_0;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Static_Void_String_String_String_fnOnTranslated_0;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeMethodInfoPtr_ForceTranslate_Public_Static_String_String_String_String_0;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Static_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_Boolean_0;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeMethodInfoPtr_ForceTranslate_Public_Static_Boolean_Dictionary_2_String_TranslationQuery_Boolean_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTranslationRequest_Public_Static_List_1_String_Dictionary_2_String_TranslationQuery_Boolean_0;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_AddTranslationJob_Private_Static_Void_TranslationJob_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_WaitForTranslations_Private_Static_IEnumerator_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_ParseTranslationResult_Public_Static_String_String_Dictionary_2_String_TranslationQuery_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_IsTranslating_Public_Static_Boolean_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_CancelCurrentGoogleTranslations_Public_Static_Void_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueries_Public_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueries_Plurals_Private_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_AddQuery_Public_Static_Void_String_String_String_Dictionary_2_String_TranslationQuery_0;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslation_Private_Static_String_String_String_Dictionary_2_String_TranslationQuery_0;

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeMethodInfoPtr_FindQueryFromOrigText_Private_Static_TranslationQuery_String_Dictionary_2_String_TranslationQuery_0;

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeMethodInfoPtr_HasParameters_Public_Static_Boolean_String_0;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralParameter_Public_Static_String_String_Boolean_0;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralText_Public_Static_String_String_String_0;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr_FindClosingTag_Private_Static_Int32_String_MatchCollection_Int32_0;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeMethodInfoPtr_GetGoogleNoTranslateTag_Private_Static_String_Int32_0;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr_ParseNonTranslatableElements_Private_Static_Void_byref_TranslationQuery_0;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryResult_Public_Static_String_String_String_Dictionary_2_String_TranslationQuery_0;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeMethodInfoPtr_RebuildTranslation_Public_Static_String_String_Dictionary_2_String_TranslationQuery_String_0;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr_RebuildTranslation_Plural_Private_Static_String_String_Dictionary_2_String_TranslationQuery_String_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr_UppercaseFirst_Public_Static_String_String_0;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeMethodInfoPtr_TitleCase_Public_Static_String_String_0;

		// Token: 0x020003B7 RID: 951
		public sealed class fnOnTranslated : MulticastDelegate
		{
			// Token: 0x0600599A RID: 22938 RVA: 0x00144174 File Offset: 0x00142374
			// Note: this type is marked as 'beforefieldinit'.
			static fnOnTranslated()
			{
				Il2CppClassPointerStore<GoogleTranslation.fnOnTranslated>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, "fnOnTranslated");
				GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslated>.NativeClassPtr, 100669874);
				GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslated>.NativeClassPtr, 100669875);
				GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslated>.NativeClassPtr, 100669876);
				GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslated>.NativeClassPtr, 100669877);
			}

			// Token: 0x0600599B RID: 22939 RVA: 0x001441E8 File Offset: 0x001423E8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe fnOnTranslated(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslated>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600599C RID: 22940 RVA: 0x00144244 File Offset: 0x00142444
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 1337, RefRangeEnd = 1421, XrefRangeStart = 1337, XrefRangeEnd = 1421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string Translation, string Error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(Translation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600599D RID: 22941 RVA: 0x00144298 File Offset: 0x00142498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string Translation, string Error, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(Translation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600599E RID: 22942 RVA: 0x00144320 File Offset: 0x00142520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslated.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600599F RID: 22943 RVA: 0x00033547 File Offset: 0x00031747
			public fnOnTranslated(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060059A0 RID: 22944 RVA: 0x00033550 File Offset: 0x00031750
			public static implicit operator GoogleTranslation.fnOnTranslated(Action<string, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<GoogleTranslation.fnOnTranslated>(A_0);
			}

			// Token: 0x060059A1 RID: 22945 RVA: 0x00033558 File Offset: 0x00031758
			public static GoogleTranslation.fnOnTranslated operator +(GoogleTranslation.fnOnTranslated A_0, GoogleTranslation.fnOnTranslated A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GoogleTranslation.fnOnTranslated>();
			}

			// Token: 0x060059A2 RID: 22946 RVA: 0x00033566 File Offset: 0x00031766
			public static GoogleTranslation.fnOnTranslated operator -(GoogleTranslation.fnOnTranslated A_0, GoogleTranslation.fnOnTranslated A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<GoogleTranslation.fnOnTranslated>();
				}
				return delegate2;
			}

			// Token: 0x04003B7F RID: 15231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003B80 RID: 15232
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0;

			// Token: 0x04003B81 RID: 15233
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0;

			// Token: 0x04003B82 RID: 15234
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B8 RID: 952
		public sealed class fnOnTranslationReady : MulticastDelegate
		{
			// Token: 0x060059A3 RID: 22947 RVA: 0x00144364 File Offset: 0x00142564
			// Note: this type is marked as 'beforefieldinit'.
			static fnOnTranslationReady()
			{
				Il2CppClassPointerStore<GoogleTranslation.fnOnTranslationReady>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, "fnOnTranslationReady");
				GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslationReady>.NativeClassPtr, 100669878);
				GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Dictionary_2_String_TranslationQuery_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslationReady>.NativeClassPtr, 100669879);
				GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Dictionary_2_String_TranslationQuery_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslationReady>.NativeClassPtr, 100669880);
				GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslationReady>.NativeClassPtr, 100669881);
			}

			// Token: 0x060059A4 RID: 22948 RVA: 0x001443D8 File Offset: 0x001425D8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe fnOnTranslationReady(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleTranslation.fnOnTranslationReady>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059A5 RID: 22949 RVA: 0x00144434 File Offset: 0x00142634
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 107679, RefRangeEnd = 107686, XrefRangeStart = 107679, XrefRangeEnd = 107679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Dictionary<string, TranslationQuery> dict, string error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Dictionary_2_String_TranslationQuery_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059A6 RID: 22950 RVA: 0x00144488 File Offset: 0x00142688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Dictionary<string, TranslationQuery> dict, string error, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Dictionary_2_String_TranslationQuery_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060059A7 RID: 22951 RVA: 0x00144510 File Offset: 0x00142710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.fnOnTranslationReady.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059A8 RID: 22952 RVA: 0x00033577 File Offset: 0x00031777
			public fnOnTranslationReady(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060059A9 RID: 22953 RVA: 0x00033580 File Offset: 0x00031780
			public static implicit operator GoogleTranslation.fnOnTranslationReady(Action<Dictionary<string, TranslationQuery>, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<GoogleTranslation.fnOnTranslationReady>(A_0);
			}

			// Token: 0x060059AA RID: 22954 RVA: 0x00033588 File Offset: 0x00031788
			public static GoogleTranslation.fnOnTranslationReady operator +(GoogleTranslation.fnOnTranslationReady A_0, GoogleTranslation.fnOnTranslationReady A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GoogleTranslation.fnOnTranslationReady>();
			}

			// Token: 0x060059AB RID: 22955 RVA: 0x00033596 File Offset: 0x00031796
			public static GoogleTranslation.fnOnTranslationReady operator -(GoogleTranslation.fnOnTranslationReady A_0, GoogleTranslation.fnOnTranslationReady A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<GoogleTranslation.fnOnTranslationReady>();
				}
				return delegate2;
			}

			// Token: 0x04003B83 RID: 15235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003B84 RID: 15236
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Dictionary_2_String_TranslationQuery_String_0;

			// Token: 0x04003B85 RID: 15237
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Dictionary_2_String_TranslationQuery_String_AsyncCallback_Object_0;

			// Token: 0x04003B86 RID: 15238
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B9 RID: 953
		[ObfuscatedName("I2.Loc.GoogleTranslation+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060059AC RID: 22956 RVA: 0x00144554 File Offset: 0x00142754
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr);
				GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_OnTranslationReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr, "OnTranslationReady");
				GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr, "text");
				GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_queries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr, "queries");
				GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_LanguageCodeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr, "LanguageCodeTo");
				GoogleTranslation.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr, 100669882);
				GoogleTranslation.__c__DisplayClass2_0.NativeMethodInfoPtr__Translate_b__0_Internal_Void_Dictionary_2_String_TranslationQuery_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr, 100669883);
			}

			// Token: 0x060059AD RID: 22957 RVA: 0x001445F8 File Offset: 0x001427F8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleTranslation.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059AE RID: 22958 RVA: 0x00144634 File Offset: 0x00142834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107686, XrefRangeEnd = 107694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Translate_b__0(Dictionary<string, TranslationQuery> results, string error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation.__c__DisplayClass2_0.NativeMethodInfoPtr__Translate_b__0_Internal_Void_Dictionary_2_String_TranslationQuery_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059AF RID: 22959 RVA: 0x000335A7 File Offset: 0x000317A7
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020BE RID: 8382
			// (get) Token: 0x060059B0 RID: 22960 RVA: 0x00144688 File Offset: 0x00142888
			// (set) Token: 0x060059B1 RID: 22961 RVA: 0x000335B0 File Offset: 0x000317B0
			public unsafe GoogleTranslation.fnOnTranslated OnTranslationReady
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_OnTranslationReady);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleTranslation.fnOnTranslated>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_OnTranslationReady), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020BF RID: 8383
			// (get) Token: 0x060059B2 RID: 22962 RVA: 0x001446B8 File Offset: 0x001428B8
			// (set) Token: 0x060059B3 RID: 22963 RVA: 0x000335CF File Offset: 0x000317CF
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170020C0 RID: 8384
			// (get) Token: 0x060059B4 RID: 22964 RVA: 0x001446E0 File Offset: 0x001428E0
			// (set) Token: 0x060059B5 RID: 22965 RVA: 0x000335EE File Offset: 0x000317EE
			public unsafe Dictionary<string, TranslationQuery> queries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_queries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TranslationQuery>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_queries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020C1 RID: 8385
			// (get) Token: 0x060059B6 RID: 22966 RVA: 0x00144710 File Offset: 0x00142910
			// (set) Token: 0x060059B7 RID: 22967 RVA: 0x0003360D File Offset: 0x0003180D
			public unsafe string LanguageCodeTo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_LanguageCodeTo);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation.__c__DisplayClass2_0.NativeFieldInfoPtr_LanguageCodeTo), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003B87 RID: 15239
			private static readonly IntPtr NativeFieldInfoPtr_OnTranslationReady;

			// Token: 0x04003B88 RID: 15240
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04003B89 RID: 15241
			private static readonly IntPtr NativeFieldInfoPtr_queries;

			// Token: 0x04003B8A RID: 15242
			private static readonly IntPtr NativeFieldInfoPtr_LanguageCodeTo;

			// Token: 0x04003B8B RID: 15243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B8C RID: 15244
			private static readonly IntPtr NativeMethodInfoPtr__Translate_b__0_Internal_Void_Dictionary_2_String_TranslationQuery_String_0;
		}

		// Token: 0x020003BA RID: 954
		[ObfuscatedName("I2.Loc.GoogleTranslation+<WaitForTranslations>d__11")]
		public sealed class _WaitForTranslations_d__11 : Object
		{
			// Token: 0x060059B8 RID: 22968 RVA: 0x00144738 File Offset: 0x00142938
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForTranslations_d__11()
			{
				Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleTranslation>.NativeClassPtr, "<WaitForTranslations>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr);
				GoogleTranslation._WaitForTranslations_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, "<>1__state");
				GoogleTranslation._WaitForTranslations_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, "<>2__current");
				GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, 100669884);
				GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, 100669885);
				GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, 100669886);
				GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, 100669887);
				GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, 100669888);
				GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr, 100669889);
			}

			// Token: 0x060059B9 RID: 22969 RVA: 0x00144804 File Offset: 0x00142A04
			[CallerCount(0)]
			public unsafe _WaitForTranslations_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleTranslation._WaitForTranslations_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059BA RID: 22970 RVA: 0x0014484C File Offset: 0x00142A4C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059BB RID: 22971 RVA: 0x00144880 File Offset: 0x00142A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107694, XrefRangeEnd = 107711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170020C4 RID: 8388
			// (get) Token: 0x060059BC RID: 22972 RVA: 0x001448BC File Offset: 0x00142ABC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059BD RID: 22973 RVA: 0x001448FC File Offset: 0x00142AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107711, XrefRangeEnd = 107716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170020C5 RID: 8389
			// (get) Token: 0x060059BE RID: 22974 RVA: 0x00144930 File Offset: 0x00142B30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleTranslation._WaitForTranslations_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059BF RID: 22975 RVA: 0x0003362C File Offset: 0x0003182C
			public _WaitForTranslations_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020C2 RID: 8386
			// (get) Token: 0x060059C0 RID: 22976 RVA: 0x00144970 File Offset: 0x00142B70
			// (set) Token: 0x060059C1 RID: 22977 RVA: 0x00033635 File Offset: 0x00031835
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation._WaitForTranslations_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation._WaitForTranslations_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170020C3 RID: 8387
			// (get) Token: 0x060059C2 RID: 22978 RVA: 0x00144998 File Offset: 0x00142B98
			// (set) Token: 0x060059C3 RID: 22979 RVA: 0x00033650 File Offset: 0x00031850
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation._WaitForTranslations_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleTranslation._WaitForTranslations_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B8D RID: 15245
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B8E RID: 15246
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B8F RID: 15247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B90 RID: 15248
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B91 RID: 15249
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B92 RID: 15250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B93 RID: 15251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B94 RID: 15252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
