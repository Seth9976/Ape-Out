using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000242 RID: 578
	public static class LocalizationManager : global::Il2CppSystem.Object
	{
		// Token: 0x0600448E RID: 17550 RVA: 0x000FEBE4 File Offset: 0x000FCDE4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationManager()
		{
			Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr);
			LocalizationManager.NativeFieldInfoPtr_mCurrentLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mCurrentLanguage");
			LocalizationManager.NativeFieldInfoPtr_mLanguageCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mLanguageCode");
			LocalizationManager.NativeFieldInfoPtr_mCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mCurrentCulture");
			LocalizationManager.NativeFieldInfoPtr_mChangeCultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mChangeCultureInfo");
			LocalizationManager.NativeFieldInfoPtr_IsRight2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "IsRight2Left");
			LocalizationManager.NativeFieldInfoPtr_HasJoinedWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "HasJoinedWords");
			LocalizationManager.NativeFieldInfoPtr_ParamManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "ParamManagers");
			LocalizationManager.NativeFieldInfoPtr_CustomApplyLocalizationParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "CustomApplyLocalizationParams");
			LocalizationManager.NativeFieldInfoPtr_LanguagesRTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "LanguagesRTL");
			LocalizationManager.NativeFieldInfoPtr_Sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "Sources");
			LocalizationManager.NativeFieldInfoPtr_GlobalSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "GlobalSources");
			LocalizationManager.NativeFieldInfoPtr_Callback_AllowSyncFromGoogle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "Callback_AllowSyncFromGoogle");
			LocalizationManager.NativeFieldInfoPtr_mCurrentDeviceLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mCurrentDeviceLanguage");
			LocalizationManager.NativeFieldInfoPtr_mLocalizeTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mLocalizeTargets");
			LocalizationManager.NativeFieldInfoPtr_OnLocalizeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "OnLocalizeEvent");
			LocalizationManager.NativeFieldInfoPtr_mLocalizeIsScheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mLocalizeIsScheduled");
			LocalizationManager.NativeFieldInfoPtr_mLocalizeIsScheduledWithForcedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "mLocalizeIsScheduledWithForcedValue");
			LocalizationManager.NativeFieldInfoPtr_HighlightLocalizedTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "HighlightLocalizedTargets");
			LocalizationManager.NativeMethodInfoPtr_InitializeIfNeeded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670085);
			LocalizationManager.NativeMethodInfoPtr_GetVersion_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670086);
			LocalizationManager.NativeMethodInfoPtr_GetRequiredWebServiceVersion_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670087);
			LocalizationManager.NativeMethodInfoPtr_GetWebServiceURL_Public_Static_String_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670088);
			LocalizationManager.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670089);
			LocalizationManager.NativeMethodInfoPtr_set_CurrentLanguage_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670090);
			LocalizationManager.NativeMethodInfoPtr_get_CurrentLanguageCode_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670091);
			LocalizationManager.NativeMethodInfoPtr_set_CurrentLanguageCode_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670092);
			LocalizationManager.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670093);
			LocalizationManager.NativeMethodInfoPtr_set_CurrentRegion_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670094);
			LocalizationManager.NativeMethodInfoPtr_get_CurrentRegionCode_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670095);
			LocalizationManager.NativeMethodInfoPtr_set_CurrentRegionCode_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670096);
			LocalizationManager.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670097);
			LocalizationManager.NativeMethodInfoPtr_SetLanguageAndCode_Public_Static_Void_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670098);
			LocalizationManager.NativeMethodInfoPtr_CreateCultureForCode_Private_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670099);
			LocalizationManager.NativeMethodInfoPtr_EnableChangingCultureInfo_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670100);
			LocalizationManager.NativeMethodInfoPtr_SetCurrentCultureInfo_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670101);
			LocalizationManager.NativeMethodInfoPtr_SelectStartupLanguage_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670102);
			LocalizationManager.NativeMethodInfoPtr_HasLanguage_Public_Static_Boolean_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670103);
			LocalizationManager.NativeMethodInfoPtr_GetSupportedLanguage_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670104);
			LocalizationManager.NativeMethodInfoPtr_GetLanguageCode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670105);
			LocalizationManager.NativeMethodInfoPtr_GetLanguageFromCode_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670106);
			LocalizationManager.NativeMethodInfoPtr_GetAllLanguages_Public_Static_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670107);
			LocalizationManager.NativeMethodInfoPtr_GetAllLanguagesCode_Public_Static_List_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670108);
			LocalizationManager.NativeMethodInfoPtr_IsLanguageEnabled_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670109);
			LocalizationManager.NativeMethodInfoPtr_LoadCurrentLanguage_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670110);
			LocalizationManager.NativeMethodInfoPtr_PreviewLanguage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670111);
			LocalizationManager.NativeMethodInfoPtr_AutoLoadGlobalParamManagers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670112);
			LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670113);
			LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670114);
			LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_Dictionary_2_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670115);
			LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String__GetParam_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670116);
			LocalizationManager.NativeMethodInfoPtr_GetLocalizationParam_Internal_Static_String_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670117);
			LocalizationManager.NativeMethodInfoPtr_GetPluralType_Private_Static_String_MatchCollection_String__GetParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670118);
			LocalizationManager.NativeMethodInfoPtr_ApplyRTLfix_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670119);
			LocalizationManager.NativeMethodInfoPtr_ApplyRTLfix_Public_Static_String_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670120);
			LocalizationManager.NativeMethodInfoPtr_FixRTL_IfNeeded_Public_Static_String_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670121);
			LocalizationManager.NativeMethodInfoPtr_IsRTL_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670122);
			LocalizationManager.NativeMethodInfoPtr_UpdateSources_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670123);
			LocalizationManager.NativeMethodInfoPtr_UnregisterDeletededSources_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670124);
			LocalizationManager.NativeMethodInfoPtr_RegisterSceneSources_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670125);
			LocalizationManager.NativeMethodInfoPtr_RegisterSourceInResources_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670126);
			LocalizationManager.NativeMethodInfoPtr_AllowSyncFromGoogle_Private_Static_Boolean_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670127);
			LocalizationManager.NativeMethodInfoPtr_AddSource_Internal_Static_Void_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670128);
			LocalizationManager.NativeMethodInfoPtr_Delayed_Import_Google_Private_Static_IEnumerator_LanguageSourceData_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670129);
			LocalizationManager.NativeMethodInfoPtr_RemoveSource_Internal_Static_Void_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670130);
			LocalizationManager.NativeMethodInfoPtr_IsGlobalSource_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670131);
			LocalizationManager.NativeMethodInfoPtr_GetSourceContaining_Public_Static_LanguageSourceData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670132);
			LocalizationManager.NativeMethodInfoPtr_FindAsset_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670133);
			LocalizationManager.NativeMethodInfoPtr_ApplyDownloadedDataFromGoogle_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670134);
			LocalizationManager.NativeMethodInfoPtr_GetCurrentDeviceLanguage_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670135);
			LocalizationManager.NativeMethodInfoPtr_DetectDeviceLanguage_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670136);
			LocalizationManager.NativeMethodInfoPtr_RegisterTarget_Public_Static_Void_ILocalizeTargetDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670137);
			LocalizationManager.NativeMethodInfoPtr_add_OnLocalizeEvent_Public_Static_add_Void_OnLocalizeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670138);
			LocalizationManager.NativeMethodInfoPtr_remove_OnLocalizeEvent_Public_Static_rem_Void_OnLocalizeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670139);
			LocalizationManager.NativeMethodInfoPtr_GetTranslation_Public_Static_String_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670140);
			LocalizationManager.NativeMethodInfoPtr_GetTermTranslation_Public_Static_String_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670141);
			LocalizationManager.NativeMethodInfoPtr_TryGetTranslation_Public_Static_Boolean_String_byref_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670142);
			LocalizationManager.NativeMethodInfoPtr_GetTranslatedObject_Public_Static_T_String_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670143);
			LocalizationManager.NativeMethodInfoPtr_GetTranslatedObjectByTermName_Public_Static_T_String_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670144);
			LocalizationManager.NativeMethodInfoPtr_GetAppName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670145);
			LocalizationManager.NativeMethodInfoPtr_LocalizeAll_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670146);
			LocalizationManager.NativeMethodInfoPtr_Coroutine_LocalizeAll_Private_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670147);
			LocalizationManager.NativeMethodInfoPtr_DoLocalizeAll_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670148);
			LocalizationManager.NativeMethodInfoPtr_GetCategories_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670149);
			LocalizationManager.NativeMethodInfoPtr_GetTermsList_Public_Static_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670150);
			LocalizationManager.NativeMethodInfoPtr_GetTermData_Public_Static_TermData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670151);
			LocalizationManager.NativeMethodInfoPtr_GetTermData_Public_Static_TermData_String_byref_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, 100670152);
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x000FF2CC File Offset: 0x000FD4CC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 111421, RefRangeEnd = 111446, XrefRangeStart = 111410, XrefRangeEnd = 111421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeIfNeeded()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_InitializeIfNeeded_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x000FF2F4 File Offset: 0x000FD4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111446, XrefRangeEnd = 111448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetVersion_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x000FF320 File Offset: 0x000FD520
		[CallerCount(0)]
		public unsafe static int GetRequiredWebServiceVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetRequiredWebServiceVersion_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x000FF350 File Offset: 0x000FD550
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 111465, RefRangeEnd = 111472, XrefRangeStart = 111448, XrefRangeEnd = 111465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebServiceURL(LanguageSourceData source = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetWebServiceURL_Public_Static_String_LanguageSourceData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x000FF38C File Offset: 0x000FD58C
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x000FF3B8 File Offset: 0x000FD5B8
		public unsafe static string CurrentLanguage
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 111477, RefRangeEnd = 111484, XrefRangeStart = 111472, XrefRangeEnd = 111477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 111495, RefRangeEnd = 111502, XrefRangeStart = 111484, XrefRangeEnd = 111495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_set_CurrentLanguage_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x000FF3F0 File Offset: 0x000FD5F0
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x000FF41C File Offset: 0x000FD61C
		public unsafe static string CurrentLanguageCode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 111507, RefRangeEnd = 111510, XrefRangeStart = 111502, XrefRangeEnd = 111507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_get_CurrentLanguageCode_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111510, XrefRangeEnd = 111520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_set_CurrentLanguageCode_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x000FF454 File Offset: 0x000FD654
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x000FF480 File Offset: 0x000FD680
		public unsafe static string CurrentRegion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111520, XrefRangeEnd = 111544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111544, XrefRangeEnd = 111578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_set_CurrentRegion_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x000FF4B8 File Offset: 0x000FD6B8
		// (set) Token: 0x0600449A RID: 17562 RVA: 0x000FF4E4 File Offset: 0x000FD6E4
		public unsafe static string CurrentRegionCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111578, XrefRangeEnd = 111593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_get_CurrentRegionCode_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111593, XrefRangeEnd = 111623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_set_CurrentRegionCode_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x000FF51C File Offset: 0x000FD71C
		public unsafe static CultureInfo CurrentCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111623, XrefRangeEnd = 111627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x000FF550 File Offset: 0x000FD750
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 111659, RefRangeEnd = 111663, XrefRangeStart = 111627, XrefRangeEnd = 111659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(LanguageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref RememberLanguage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_SetLanguageAndCode_Public_Static_Void_String_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x000FF5B4 File Offset: 0x000FD7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111673, RefRangeEnd = 111674, XrefRangeStart = 111663, XrefRangeEnd = 111673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateCultureForCode(string code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_CreateCultureForCode_Private_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x000FF5F8 File Offset: 0x000FD7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111674, XrefRangeEnd = 111683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableChangingCultureInfo(bool bEnable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bEnable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_EnableChangingCultureInfo_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x000FF62C File Offset: 0x000FD82C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111690, RefRangeEnd = 111693, XrefRangeStart = 111683, XrefRangeEnd = 111690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCurrentCultureInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_SetCurrentCultureInfo_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x000FF654 File Offset: 0x000FD854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111724, RefRangeEnd = 111725, XrefRangeStart = 111693, XrefRangeEnd = 111724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SelectStartupLanguage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_SelectStartupLanguage_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x000FF67C File Offset: 0x000FD87C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 111745, RefRangeEnd = 111749, XrefRangeStart = 111725, XrefRangeEnd = 111745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AllowDiscartingRegion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Initialize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref SkipDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_HasLanguage_Public_Static_Boolean_String_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x000FF6E8 File Offset: 0x000FD8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111775, RefRangeEnd = 111776, XrefRangeStart = 111749, XrefRangeEnd = 111775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetSupportedLanguage_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x000FF734 File Offset: 0x000FD934
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111797, RefRangeEnd = 111800, XrefRangeStart = 111776, XrefRangeEnd = 111797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLanguageCode(string Language)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetLanguageCode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x000FF770 File Offset: 0x000FD970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111821, RefRangeEnd = 111823, XrefRangeStart = 111800, XrefRangeEnd = 111821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exactMatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetLanguageFromCode_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x000FF7BC File Offset: 0x000FD9BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111859, RefRangeEnd = 111861, XrefRangeStart = 111823, XrefRangeEnd = 111859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref SkipDisabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetAllLanguages_Public_Static_List_1_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x000FF7FC File Offset: 0x000FD9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111861, XrefRangeEnd = 111892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowRegions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref SkipDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetAllLanguagesCode_Public_Static_List_1_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x000FF84C File Offset: 0x000FDA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111892, XrefRangeEnd = 111903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLanguageEnabled(string Language)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_IsLanguageEnabled_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x000FF890 File Offset: 0x000FDA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111903, XrefRangeEnd = 111915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadCurrentLanguage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_LoadCurrentLanguage_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x000FF8B8 File Offset: 0x000FDAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111915, XrefRangeEnd = 111931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreviewLanguage(string NewLanguage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(NewLanguage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_PreviewLanguage_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x000FF8F0 File Offset: 0x000FDAF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111955, RefRangeEnd = 111956, XrefRangeStart = 111931, XrefRangeEnd = 111955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoLoadGlobalParamManagers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_AutoLoadGlobalParamManagers_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x000FF918 File Offset: 0x000FDB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111974, RefRangeEnd = 111975, XrefRangeStart = 111956, XrefRangeEnd = 111974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(translation);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			translation = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x000FF96C File Offset: 0x000FDB6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111988, RefRangeEnd = 111990, XrefRangeStart = 111975, XrefRangeEnd = 111988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(translation);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			translation = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x000FF9D0 File Offset: 0x000FDBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111990, XrefRangeEnd = 112003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyLocalizationParams(ref string translation, Dictionary<string, global::Il2CppSystem.Object> parameters, bool allowLocalizedParameters = true)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(translation);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_Dictionary_2_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			translation = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x000FFA34 File Offset: 0x000FDC34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112076, RefRangeEnd = 112079, XrefRangeStart = 112003, XrefRangeEnd = 112076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyLocalizationParams(ref string translation, LocalizationManager._GetParam getParam, bool allowLocalizedParameters = true)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(translation);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getParam);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String__GetParam_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			translation = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x000FFA98 File Offset: 0x000FDC98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112104, RefRangeEnd = 112106, XrefRangeStart = 112079, XrefRangeEnd = 112104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizationParam(string ParamName, GameObject root)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ParamName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetLocalizationParam_Internal_Static_String_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x000FFAE8 File Offset: 0x000FDCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112106, XrefRangeEnd = 112116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPluralType(MatchCollection matches, string langCode, LocalizationManager._GetParam getParam)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matches);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(langCode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetPluralType_Private_Static_String_MatchCollection_String__GetParam_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000FFB48 File Offset: 0x000FDD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112116, XrefRangeEnd = 112120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ApplyRTLfix(string line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_ApplyRTLfix_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x000FFB84 File Offset: 0x000FDD84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112181, RefRangeEnd = 112185, XrefRangeStart = 112120, XrefRangeEnd = 112181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCharacters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreNumbers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_ApplyRTLfix_Public_Static_String_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x000FFBDC File Offset: 0x000FDDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112185, XrefRangeEnd = 112189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCharacters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_FixRTL_IfNeeded_Public_Static_String_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x000FFC34 File Offset: 0x000FDE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112195, RefRangeEnd = 112197, XrefRangeStart = 112189, XrefRangeEnd = 112195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRTL(string Code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_IsRTL_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x000FFC78 File Offset: 0x000FDE78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 112217, RefRangeEnd = 112224, XrefRangeStart = 112197, XrefRangeEnd = 112217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateSources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_UpdateSources_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x000FFCA8 File Offset: 0x000FDEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112224, XrefRangeEnd = 112236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterDeletededSources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_UnregisterDeletededSources_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x000FFCD0 File Offset: 0x000FDED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112258, RefRangeEnd = 112259, XrefRangeStart = 112236, XrefRangeEnd = 112258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterSceneSources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_RegisterSceneSources_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x000FFCF8 File Offset: 0x000FDEF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112282, RefRangeEnd = 112283, XrefRangeStart = 112259, XrefRangeEnd = 112282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterSourceInResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_RegisterSourceInResources_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x000FFD20 File Offset: 0x000FDF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112283, XrefRangeEnd = 112292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_AllowSyncFromGoogle_Private_Static_Boolean_LanguageSourceData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x000FFD64 File Offset: 0x000FDF64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112333, RefRangeEnd = 112337, XrefRangeStart = 112292, XrefRangeEnd = 112333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSource(LanguageSourceData Source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_AddSource_Internal_Static_Void_LanguageSourceData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x000FFD9C File Offset: 0x000FDF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112337, XrefRangeEnd = 112340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref justCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_Delayed_Import_Google_Private_Static_IEnumerator_LanguageSourceData_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x000FFDFC File Offset: 0x000FDFFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112346, RefRangeEnd = 112350, XrefRangeStart = 112340, XrefRangeEnd = 112346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveSource(LanguageSourceData Source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_RemoveSource_Internal_Static_Void_LanguageSourceData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x000FFE34 File Offset: 0x000FE034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112350, XrefRangeEnd = 112356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGlobalSource(string SourceName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(SourceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_IsGlobalSource_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x000FFE78 File Offset: 0x000FE078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112356, XrefRangeEnd = 112377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackToFirst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetSourceContaining_Public_Static_LanguageSourceData_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr3) : null;
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x000FFECC File Offset: 0x000FE0CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112392, RefRangeEnd = 112394, XrefRangeStart = 112377, XrefRangeEnd = 112392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static global::UnityEngine.Object FindAsset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_FindAsset_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x000FFF10 File Offset: 0x000FE110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112394, XrefRangeEnd = 112405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyDownloadedDataFromGoogle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_ApplyDownloadedDataFromGoogle_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x000FFF38 File Offset: 0x000FE138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112405, XrefRangeEnd = 112414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentDeviceLanguage(bool force = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetCurrentDeviceLanguage_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x000FFF70 File Offset: 0x000FE170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112439, RefRangeEnd = 112441, XrefRangeStart = 112414, XrefRangeEnd = 112439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DetectDeviceLanguage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_DetectDeviceLanguage_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x000FFF98 File Offset: 0x000FE198
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 112470, RefRangeEnd = 112482, XrefRangeStart = 112441, XrefRangeEnd = 112470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_RegisterTarget_Public_Static_Void_ILocalizeTargetDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x000FFFD0 File Offset: 0x000FE1D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112492, RefRangeEnd = 112494, XrefRangeStart = 112482, XrefRangeEnd = 112492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLocalizeEvent(LocalizationManager.OnLocalizeCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_add_OnLocalizeEvent_Public_Static_add_Void_OnLocalizeCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00100008 File Offset: 0x000FE208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112504, RefRangeEnd = 112507, XrefRangeStart = 112494, XrefRangeEnd = 112504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLocalizeEvent(LocalizationManager.OnLocalizeCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_remove_OnLocalizeEvent_Public_Static_rem_Void_OnLocalizeCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x00100040 File Offset: 0x000FE240
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 112511, RefRangeEnd = 112546, XrefRangeStart = 112507, XrefRangeEnd = 112511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, GameObject localParametersRoot = null, string overrideLanguage = null, bool allowLocalizedParameters = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FixForRTL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLineLengthForRTL;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreRTLnumbers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyParameters;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localParametersRoot);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLanguage);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetTranslation_Public_Static_String_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x001000E8 File Offset: 0x000FE2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112546, XrefRangeEnd = 112550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, GameObject localParametersRoot = null, string overrideLanguage = null, bool allowLocalizedParameters = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FixForRTL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLineLengthForRTL;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreRTLnumbers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyParameters;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localParametersRoot);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLanguage);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetTermTranslation_Public_Static_String_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00100190 File Offset: 0x000FE390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112572, RefRangeEnd = 112573, XrefRangeStart = 112550, XrefRangeEnd = 112572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, GameObject localParametersRoot = null, string overrideLanguage = null, bool allowLocalizedParameters = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Term);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FixForRTL;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLineLengthForRTL;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreRTLnumbers;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyParameters;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localParametersRoot);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLanguage);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_TryGetTranslation_Public_Static_Boolean_String_byref_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			Translation = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x0010025C File Offset: 0x000FE45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112573, XrefRangeEnd = 112598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetTranslatedObject<T>(string AssetName, Localize optionalLocComp = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(AssetName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionalLocComp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.MethodInfoStoreGeneric_GetTranslatedObject_Public_Static_T_String_Localize_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x001002AC File Offset: 0x000FE4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112598, XrefRangeEnd = 112602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetTranslatedObjectByTermName<T>(string Term, Localize optionalLocComp = null) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionalLocComp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.MethodInfoStoreGeneric_GetTranslatedObjectByTermName_Public_Static_T_String_Localize_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x001002FC File Offset: 0x000FE4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112602, XrefRangeEnd = 112622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAppName(string languageCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(languageCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetAppName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00100338 File Offset: 0x000FE538
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 112651, RefRangeEnd = 112658, XrefRangeStart = 112622, XrefRangeEnd = 112651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LocalizeAll(bool Force = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_LocalizeAll_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x0010036C File Offset: 0x000FE56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112658, XrefRangeEnd = 112661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Coroutine_LocalizeAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_Coroutine_LocalizeAll_Private_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x001003A0 File Offset: 0x000FE5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112661, XrefRangeEnd = 112679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoLocalizeAll(bool Force = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_DoLocalizeAll_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x001003D4 File Offset: 0x000FE5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112679, XrefRangeEnd = 112696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetCategories()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetCategories_Public_Static_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00100408 File Offset: 0x000FE608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112696, XrefRangeEnd = 112729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetTermsList(string Category = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetTermsList_Public_Static_List_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x0010044C File Offset: 0x000FE64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112729, XrefRangeEnd = 112741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TermData GetTermData(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetTermData_Public_Static_TermData_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TermData>(intPtr3) : null;
			}
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00100490 File Offset: 0x000FE690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112757, RefRangeEnd = 112758, XrefRangeStart = 112741, XrefRangeEnd = 112757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TermData GetTermData(string term, out LanguageSourceData source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.NativeMethodInfoPtr_GetTermData_Public_Static_TermData_String_byref_LanguageSourceData_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : new LanguageSourceData(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TermData>(intPtr5) : null;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x00029700 File Offset: 0x00027900
		public LocalizationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x001004F8 File Offset: 0x000FE6F8
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x00029709 File Offset: 0x00027909
		public unsafe static string mCurrentLanguage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mCurrentLanguage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mCurrentLanguage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x00100518 File Offset: 0x000FE718
		// (set) Token: 0x060044D7 RID: 17623 RVA: 0x0002971B File Offset: 0x0002791B
		public unsafe static string mLanguageCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mLanguageCode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mLanguageCode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x00100538 File Offset: 0x000FE738
		// (set) Token: 0x060044D9 RID: 17625 RVA: 0x0002972D File Offset: 0x0002792D
		public unsafe static CultureInfo mCurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mCurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mCurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x00100560 File Offset: 0x000FE760
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x0002973F File Offset: 0x0002793F
		public unsafe static bool mChangeCultureInfo
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mChangeCultureInfo, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mChangeCultureInfo, (void*)(&value));
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x0010057C File Offset: 0x000FE77C
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x0002974D File Offset: 0x0002794D
		public unsafe static bool IsRight2Left
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_IsRight2Left, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_IsRight2Left, (void*)(&value));
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x00100598 File Offset: 0x000FE798
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x0002975B File Offset: 0x0002795B
		public unsafe static bool HasJoinedWords
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_HasJoinedWords, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_HasJoinedWords, (void*)(&value));
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x001005B4 File Offset: 0x000FE7B4
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x00029769 File Offset: 0x00027969
		public unsafe static List<ILocalizationParamsManager> ParamManagers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_ParamManagers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ILocalizationParamsManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_ParamManagers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x001005DC File Offset: 0x000FE7DC
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x0002977B File Offset: 0x0002797B
		public unsafe static LocalizationManager.FnCustomApplyLocalizationParams CustomApplyLocalizationParams
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_CustomApplyLocalizationParams, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationManager.FnCustomApplyLocalizationParams>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_CustomApplyLocalizationParams, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x00100604 File Offset: 0x000FE804
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x0002978D File Offset: 0x0002798D
		public unsafe static Il2CppStringArray LanguagesRTL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_LanguagesRTL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_LanguagesRTL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x0010062C File Offset: 0x000FE82C
		// (set) Token: 0x060044E7 RID: 17639 RVA: 0x0002979F File Offset: 0x0002799F
		public unsafe static List<LanguageSourceData> Sources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_Sources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LanguageSourceData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_Sources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x00100654 File Offset: 0x000FE854
		// (set) Token: 0x060044E9 RID: 17641 RVA: 0x000297B1 File Offset: 0x000279B1
		public unsafe static Il2CppStringArray GlobalSources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_GlobalSources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_GlobalSources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x0010067C File Offset: 0x000FE87C
		// (set) Token: 0x060044EB RID: 17643 RVA: 0x000297C3 File Offset: 0x000279C3
		public unsafe static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_Callback_AllowSyncFromGoogle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LanguageSourceData, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_Callback_AllowSyncFromGoogle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x001006A4 File Offset: 0x000FE8A4
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x000297D5 File Offset: 0x000279D5
		public unsafe static string mCurrentDeviceLanguage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mCurrentDeviceLanguage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mCurrentDeviceLanguage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x001006C4 File Offset: 0x000FE8C4
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x000297E7 File Offset: 0x000279E7
		public unsafe static List<ILocalizeTargetDescriptor> mLocalizeTargets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mLocalizeTargets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ILocalizeTargetDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mLocalizeTargets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x001006EC File Offset: 0x000FE8EC
		// (set) Token: 0x060044F1 RID: 17649 RVA: 0x000297F9 File Offset: 0x000279F9
		public unsafe static LocalizationManager.OnLocalizeCallback OnLocalizeEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_OnLocalizeEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationManager.OnLocalizeCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_OnLocalizeEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x00100714 File Offset: 0x000FE914
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x0002980B File Offset: 0x00027A0B
		public unsafe static bool mLocalizeIsScheduled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mLocalizeIsScheduled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mLocalizeIsScheduled, (void*)(&value));
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x00100730 File Offset: 0x000FE930
		// (set) Token: 0x060044F5 RID: 17653 RVA: 0x00029819 File Offset: 0x00027A19
		public unsafe static bool mLocalizeIsScheduledWithForcedValue
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_mLocalizeIsScheduledWithForcedValue, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_mLocalizeIsScheduledWithForcedValue, (void*)(&value));
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x0010074C File Offset: 0x000FE94C
		// (set) Token: 0x060044F7 RID: 17655 RVA: 0x00029827 File Offset: 0x00027A27
		public unsafe static bool HighlightLocalizedTargets
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalizationManager.NativeFieldInfoPtr_HighlightLocalizedTargets, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationManager.NativeFieldInfoPtr_HighlightLocalizedTargets, (void*)(&value));
			}
		}

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeFieldInfoPtr_mCurrentLanguage;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeFieldInfoPtr_mLanguageCode;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeFieldInfoPtr_mCurrentCulture;

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeFieldInfoPtr_mChangeCultureInfo;

		// Token: 0x04002A55 RID: 10837
		private static readonly IntPtr NativeFieldInfoPtr_IsRight2Left;

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeFieldInfoPtr_HasJoinedWords;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeFieldInfoPtr_ParamManagers;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeFieldInfoPtr_CustomApplyLocalizationParams;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeFieldInfoPtr_LanguagesRTL;

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeFieldInfoPtr_Sources;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeFieldInfoPtr_GlobalSources;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeFieldInfoPtr_Callback_AllowSyncFromGoogle;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeFieldInfoPtr_mCurrentDeviceLanguage;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeFieldInfoPtr_mLocalizeTargets;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeFieldInfoPtr_OnLocalizeEvent;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeFieldInfoPtr_mLocalizeIsScheduled;

		// Token: 0x04002A61 RID: 10849
		private static readonly IntPtr NativeFieldInfoPtr_mLocalizeIsScheduledWithForcedValue;

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeFieldInfoPtr_HighlightLocalizedTargets;

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeMethodInfoPtr_InitializeIfNeeded_Public_Static_Void_0;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeMethodInfoPtr_GetVersion_Public_Static_String_0;

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredWebServiceVersion_Public_Static_Int32_0;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeMethodInfoPtr_GetWebServiceURL_Public_Static_String_LanguageSourceData_0;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_String_0;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLanguage_Public_Static_set_Void_String_0;

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguageCode_Public_Static_get_String_0;

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLanguageCode_Public_Static_set_Void_String_0;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_String_0;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentRegion_Public_Static_set_Void_String_0;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRegionCode_Public_Static_get_String_0;

		// Token: 0x04002A6E RID: 10862
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentRegionCode_Public_Static_set_Void_String_0;

		// Token: 0x04002A6F RID: 10863
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04002A70 RID: 10864
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguageAndCode_Public_Static_Void_String_String_Boolean_Boolean_0;

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeMethodInfoPtr_CreateCultureForCode_Private_Static_CultureInfo_String_0;

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeMethodInfoPtr_EnableChangingCultureInfo_Public_Static_Void_Boolean_0;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentCultureInfo_Private_Static_Void_0;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeMethodInfoPtr_SelectStartupLanguage_Private_Static_Void_0;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeMethodInfoPtr_HasLanguage_Public_Static_Boolean_String_Boolean_Boolean_Boolean_0;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeMethodInfoPtr_GetSupportedLanguage_Public_Static_String_String_Boolean_0;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageCode_Public_Static_String_String_0;

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageFromCode_Public_Static_String_String_Boolean_0;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLanguages_Public_Static_List_1_String_Boolean_0;

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLanguagesCode_Public_Static_List_1_String_Boolean_Boolean_0;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeMethodInfoPtr_IsLanguageEnabled_Public_Static_Boolean_String_0;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeMethodInfoPtr_LoadCurrentLanguage_Private_Static_Void_0;

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeMethodInfoPtr_PreviewLanguage_Public_Static_Void_String_0;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeMethodInfoPtr_AutoLoadGlobalParamManagers_Public_Static_Void_0;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_Boolean_0;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_GameObject_Boolean_0;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String_Dictionary_2_String_Object_Boolean_0;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocalizationParams_Public_Static_Void_byref_String__GetParam_Boolean_0;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizationParam_Internal_Static_String_String_GameObject_0;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralType_Private_Static_String_MatchCollection_String__GetParam_0;

		// Token: 0x04002A85 RID: 10885
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRTLfix_Public_Static_String_String_0;

		// Token: 0x04002A86 RID: 10886
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRTLfix_Public_Static_String_String_Int32_Boolean_0;

		// Token: 0x04002A87 RID: 10887
		private static readonly IntPtr NativeMethodInfoPtr_FixRTL_IfNeeded_Public_Static_String_String_Int32_Boolean_0;

		// Token: 0x04002A88 RID: 10888
		private static readonly IntPtr NativeMethodInfoPtr_IsRTL_Public_Static_Boolean_String_0;

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSources_Public_Static_Boolean_0;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDeletededSources_Private_Static_Void_0;

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSceneSources_Private_Static_Void_0;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSourceInResources_Private_Static_Void_0;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeMethodInfoPtr_AllowSyncFromGoogle_Private_Static_Boolean_LanguageSourceData_0;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeMethodInfoPtr_AddSource_Internal_Static_Void_LanguageSourceData_0;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeMethodInfoPtr_Delayed_Import_Google_Private_Static_IEnumerator_LanguageSourceData_Single_Boolean_0;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSource_Internal_Static_Void_LanguageSourceData_0;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeMethodInfoPtr_IsGlobalSource_Public_Static_Boolean_String_0;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceContaining_Public_Static_LanguageSourceData_String_Boolean_0;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeMethodInfoPtr_FindAsset_Public_Static_Object_String_0;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDownloadedDataFromGoogle_Public_Static_Void_0;

		// Token: 0x04002A95 RID: 10901
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDeviceLanguage_Public_Static_String_Boolean_0;

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeMethodInfoPtr_DetectDeviceLanguage_Private_Static_Void_0;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTarget_Public_Static_Void_ILocalizeTargetDescriptor_0;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLocalizeEvent_Public_Static_add_Void_OnLocalizeCallback_0;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLocalizeEvent_Public_Static_rem_Void_OnLocalizeCallback_0;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslation_Public_Static_String_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeMethodInfoPtr_GetTermTranslation_Public_Static_String_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTranslation_Public_Static_Boolean_String_byref_String_Boolean_Int32_Boolean_Boolean_GameObject_String_Boolean_0;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslatedObject_Public_Static_T_String_Localize_0;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslatedObjectByTermName_Public_Static_T_String_Localize_0;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_GetAppName_Public_Static_String_String_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_LocalizeAll_Public_Static_Void_Boolean_0;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr_Coroutine_LocalizeAll_Private_Static_IEnumerator_0;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalizeAll_Private_Static_Void_Boolean_0;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeMethodInfoPtr_GetCategories_Public_Static_List_1_String_0;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr_GetTermsList_Public_Static_List_1_String_String_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr_GetTermData_Public_Static_TermData_String_0;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeMethodInfoPtr_GetTermData_Public_Static_TermData_String_byref_LanguageSourceData_0;

		// Token: 0x020003CA RID: 970
		public sealed class FnCustomApplyLocalizationParams : MulticastDelegate
		{
			// Token: 0x06005A19 RID: 23065 RVA: 0x00145AD0 File Offset: 0x00143CD0
			// Note: this type is marked as 'beforefieldinit'.
			static FnCustomApplyLocalizationParams()
			{
				Il2CppClassPointerStore<LocalizationManager.FnCustomApplyLocalizationParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "FnCustomApplyLocalizationParams");
				LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.FnCustomApplyLocalizationParams>.NativeClassPtr, 100670154);
				LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String__GetParam_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.FnCustomApplyLocalizationParams>.NativeClassPtr, 100670155);
				LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String__GetParam_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.FnCustomApplyLocalizationParams>.NativeClassPtr, 100670156);
				LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.FnCustomApplyLocalizationParams>.NativeClassPtr, 100670157);
			}

			// Token: 0x06005A1A RID: 23066 RVA: 0x00145B44 File Offset: 0x00143D44
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FnCustomApplyLocalizationParams(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.FnCustomApplyLocalizationParams>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A1B RID: 23067 RVA: 0x00145BA0 File Offset: 0x00143DA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 111369, RefRangeEnd = 111370, XrefRangeStart = 111369, XrefRangeEnd = 111369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Invoke(ref string translation, LocalizationManager._GetParam getParam, bool allowLocalizedParameters)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.ManagedStringToIl2Cpp(translation);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getParam);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String__GetParam_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				translation = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06005A1C RID: 23068 RVA: 0x00145C1C File Offset: 0x00143E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111370, XrefRangeEnd = 111374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref string translation, LocalizationManager._GetParam getParam, bool allowLocalizedParameters, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.ManagedStringToIl2Cpp(translation);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getParam);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocalizedParameters;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String__GetParam_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				translation = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06005A1D RID: 23069 RVA: 0x00145CC4 File Offset: 0x00143EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111374, XrefRangeEnd = 111375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(ref string translation, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.ManagedStringToIl2Cpp(translation);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.FnCustomApplyLocalizationParams.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				translation = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06005A1E RID: 23070 RVA: 0x00033876 File Offset: 0x00031A76
			public FnCustomApplyLocalizationParams(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003BE7 RID: 15335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003BE8 RID: 15336
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String__GetParam_Boolean_0;

			// Token: 0x04003BE9 RID: 15337
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String__GetParam_Boolean_AsyncCallback_Object_0;

			// Token: 0x04003BEA RID: 15338
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}

		// Token: 0x020003CB RID: 971
		public sealed class _GetParam : MulticastDelegate
		{
			// Token: 0x06005A1F RID: 23071 RVA: 0x00145D34 File Offset: 0x00143F34
			// Note: this type is marked as 'beforefieldinit'.
			static _GetParam()
			{
				Il2CppClassPointerStore<LocalizationManager._GetParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "_GetParam");
				LocalizationManager._GetParam.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._GetParam>.NativeClassPtr, 100670158);
				LocalizationManager._GetParam.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._GetParam>.NativeClassPtr, 100670159);
				LocalizationManager._GetParam.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._GetParam>.NativeClassPtr, 100670160);
				LocalizationManager._GetParam.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._GetParam>.NativeClassPtr, 100670161);
			}

			// Token: 0x06005A20 RID: 23072 RVA: 0x00145DA8 File Offset: 0x00143FA8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetParam(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager._GetParam>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._GetParam.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A21 RID: 23073 RVA: 0x00145E04 File Offset: 0x00144004
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 111375, RefRangeEnd = 111377, XrefRangeStart = 111375, XrefRangeEnd = 111375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object Invoke(string param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._GetParam.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A22 RID: 23074 RVA: 0x00145E54 File Offset: 0x00144054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string param, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._GetParam.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005A23 RID: 23075 RVA: 0x00145EC8 File Offset: 0x001440C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._GetParam.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A24 RID: 23076 RVA: 0x0003387F File Offset: 0x00031A7F
			public _GetParam(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005A25 RID: 23077 RVA: 0x00033888 File Offset: 0x00031A88
			public static implicit operator LocalizationManager._GetParam(Func<string, global::Il2CppSystem.Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<LocalizationManager._GetParam>(A_0);
			}

			// Token: 0x06005A26 RID: 23078 RVA: 0x00033890 File Offset: 0x00031A90
			public static LocalizationManager._GetParam operator +(LocalizationManager._GetParam A_0, LocalizationManager._GetParam A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LocalizationManager._GetParam>();
			}

			// Token: 0x06005A27 RID: 23079 RVA: 0x0003389E File Offset: 0x00031A9E
			public static LocalizationManager._GetParam operator -(LocalizationManager._GetParam A_0, LocalizationManager._GetParam A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LocalizationManager._GetParam>();
				}
				return delegate2;
			}

			// Token: 0x04003BEB RID: 15339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003BEC RID: 15340
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_0;

			// Token: 0x04003BED RID: 15341
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x04003BEE RID: 15342
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0;
		}

		// Token: 0x020003CC RID: 972
		public sealed class OnLocalizeCallback : MulticastDelegate
		{
			// Token: 0x06005A28 RID: 23080 RVA: 0x00145F18 File Offset: 0x00144118
			// Note: this type is marked as 'beforefieldinit'.
			static OnLocalizeCallback()
			{
				Il2CppClassPointerStore<LocalizationManager.OnLocalizeCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "OnLocalizeCallback");
				LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.OnLocalizeCallback>.NativeClassPtr, 100670162);
				LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.OnLocalizeCallback>.NativeClassPtr, 100670163);
				LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.OnLocalizeCallback>.NativeClassPtr, 100670164);
				LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.OnLocalizeCallback>.NativeClassPtr, 100670165);
			}

			// Token: 0x06005A29 RID: 23081 RVA: 0x00145F8C File Offset: 0x0014418C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnLocalizeCallback(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.OnLocalizeCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A2A RID: 23082 RVA: 0x00145FE8 File Offset: 0x001441E8
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A2B RID: 23083 RVA: 0x0014601C File Offset: 0x0014421C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005A2C RID: 23084 RVA: 0x00146080 File Offset: 0x00144280
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.OnLocalizeCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A2D RID: 23085 RVA: 0x000338AF File Offset: 0x00031AAF
			public OnLocalizeCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005A2E RID: 23086 RVA: 0x000338B8 File Offset: 0x00031AB8
			public static implicit operator LocalizationManager.OnLocalizeCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<LocalizationManager.OnLocalizeCallback>(A_0);
			}

			// Token: 0x06005A2F RID: 23087 RVA: 0x000338C0 File Offset: 0x00031AC0
			public static LocalizationManager.OnLocalizeCallback operator +(LocalizationManager.OnLocalizeCallback A_0, LocalizationManager.OnLocalizeCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LocalizationManager.OnLocalizeCallback>();
			}

			// Token: 0x06005A30 RID: 23088 RVA: 0x000338CE File Offset: 0x00031ACE
			public static LocalizationManager.OnLocalizeCallback operator -(LocalizationManager.OnLocalizeCallback A_0, LocalizationManager.OnLocalizeCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LocalizationManager.OnLocalizeCallback>();
				}
				return delegate2;
			}

			// Token: 0x04003BEF RID: 15343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003BF0 RID: 15344
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04003BF1 RID: 15345
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04003BF2 RID: 15346
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003CD RID: 973
		[ObfuscatedName("I2.Loc.LocalizationManager+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005A31 RID: 23089 RVA: 0x001460C4 File Offset: 0x001442C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass33_0>.NativeClassPtr);
				LocalizationManager.__c__DisplayClass33_0.NativeFieldInfoPtr_Languages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass33_0>.NativeClassPtr, "Languages");
				LocalizationManager.__c__DisplayClass33_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass33_0>.NativeClassPtr, "<>9__0");
				LocalizationManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass33_0>.NativeClassPtr, 100670166);
				LocalizationManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetAllLanguages_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass33_0>.NativeClassPtr, 100670167);
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x00146140 File Offset: 0x00144340
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A33 RID: 23091 RVA: 0x0014617C File Offset: 0x0014437C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111377, XrefRangeEnd = 111380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllLanguages_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetAllLanguages_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A34 RID: 23092 RVA: 0x000338DF File Offset: 0x00031ADF
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020DD RID: 8413
			// (get) Token: 0x06005A35 RID: 23093 RVA: 0x001461CC File Offset: 0x001443CC
			// (set) Token: 0x06005A36 RID: 23094 RVA: 0x000338E8 File Offset: 0x00031AE8
			public unsafe List<string> Languages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass33_0.NativeFieldInfoPtr_Languages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass33_0.NativeFieldInfoPtr_Languages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020DE RID: 8414
			// (get) Token: 0x06005A37 RID: 23095 RVA: 0x001461FC File Offset: 0x001443FC
			// (set) Token: 0x06005A38 RID: 23096 RVA: 0x00033907 File Offset: 0x00031B07
			public unsafe Func<string, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass33_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass33_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BF3 RID: 15347
			private static readonly IntPtr NativeFieldInfoPtr_Languages;

			// Token: 0x04003BF4 RID: 15348
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04003BF5 RID: 15349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BF6 RID: 15350
			private static readonly IntPtr NativeMethodInfoPtr__GetAllLanguages_b__0_Internal_Boolean_String_0;
		}

		// Token: 0x020003CE RID: 974
		[ObfuscatedName("I2.Loc.LocalizationManager+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005A39 RID: 23097 RVA: 0x0014622C File Offset: 0x0014442C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass34_0>.NativeClassPtr);
				LocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr_Languages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass34_0>.NativeClassPtr, "Languages");
				LocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass34_0>.NativeClassPtr, "<>9__0");
				LocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass34_0>.NativeClassPtr, 100670168);
				LocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__GetAllLanguagesCode_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass34_0>.NativeClassPtr, 100670169);
			}

			// Token: 0x06005A3A RID: 23098 RVA: 0x001462A8 File Offset: 0x001444A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A3B RID: 23099 RVA: 0x001462E4 File Offset: 0x001444E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111380, XrefRangeEnd = 111383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllLanguagesCode_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__GetAllLanguagesCode_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A3C RID: 23100 RVA: 0x00033926 File Offset: 0x00031B26
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020DF RID: 8415
			// (get) Token: 0x06005A3D RID: 23101 RVA: 0x00146334 File Offset: 0x00144534
			// (set) Token: 0x06005A3E RID: 23102 RVA: 0x0003392F File Offset: 0x00031B2F
			public unsafe List<string> Languages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr_Languages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr_Languages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020E0 RID: 8416
			// (get) Token: 0x06005A3F RID: 23103 RVA: 0x00146364 File Offset: 0x00144564
			// (set) Token: 0x06005A40 RID: 23104 RVA: 0x0003394E File Offset: 0x00031B4E
			public unsafe Func<string, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BF7 RID: 15351
			private static readonly IntPtr NativeFieldInfoPtr_Languages;

			// Token: 0x04003BF8 RID: 15352
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04003BF9 RID: 15353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BFA RID: 15354
			private static readonly IntPtr NativeMethodInfoPtr__GetAllLanguagesCode_b__0_Internal_Boolean_String_0;
		}

		// Token: 0x020003CF RID: 975
		[ObfuscatedName("I2.Loc.LocalizationManager+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06005A41 RID: 23105 RVA: 0x00146394 File Offset: 0x00144594
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalizationManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager.__c>.NativeClassPtr);
				LocalizationManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c>.NativeClassPtr, "<>9");
				LocalizationManager.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c>.NativeClassPtr, "<>9__43_0");
				LocalizationManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c>.NativeClassPtr, 100670171);
				LocalizationManager.__c.NativeMethodInfoPtr__ApplyLocalizationParams_b__43_0_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c>.NativeClassPtr, 100670172);
			}

			// Token: 0x06005A42 RID: 23106 RVA: 0x00146410 File Offset: 0x00144610
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A43 RID: 23107 RVA: 0x0014644C File Offset: 0x0014464C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111383, XrefRangeEnd = 111387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object _ApplyLocalizationParams_b__43_0(string p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c.NativeMethodInfoPtr__ApplyLocalizationParams_b__43_0_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A44 RID: 23108 RVA: 0x0003396D File Offset: 0x00031B6D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020E1 RID: 8417
			// (get) Token: 0x06005A45 RID: 23109 RVA: 0x0014649C File Offset: 0x0014469C
			// (set) Token: 0x06005A46 RID: 23110 RVA: 0x00033976 File Offset: 0x00031B76
			public unsafe static LocalizationManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizationManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizationManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020E2 RID: 8418
			// (get) Token: 0x06005A47 RID: 23111 RVA: 0x001464C4 File Offset: 0x001446C4
			// (set) Token: 0x06005A48 RID: 23112 RVA: 0x00033988 File Offset: 0x00031B88
			public unsafe static LocalizationManager._GetParam __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizationManager.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationManager._GetParam>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizationManager.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BFB RID: 15355
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BFC RID: 15356
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04003BFD RID: 15357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BFE RID: 15358
			private static readonly IntPtr NativeMethodInfoPtr__ApplyLocalizationParams_b__43_0_Internal_Object_String_0;
		}

		// Token: 0x020003D0 RID: 976
		[ObfuscatedName("I2.Loc.LocalizationManager+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005A49 RID: 23113 RVA: 0x001464EC File Offset: 0x001446EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass44_0>.NativeClassPtr);
				LocalizationManager.__c__DisplayClass44_0.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass44_0>.NativeClassPtr, "root");
				LocalizationManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass44_0>.NativeClassPtr, 100670173);
				LocalizationManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ApplyLocalizationParams_b__0_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass44_0>.NativeClassPtr, 100670174);
			}

			// Token: 0x06005A4A RID: 23114 RVA: 0x00146554 File Offset: 0x00144754
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A4B RID: 23115 RVA: 0x00146590 File Offset: 0x00144790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111387, XrefRangeEnd = 111391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object _ApplyLocalizationParams_b__0(string p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ApplyLocalizationParams_b__0_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A4C RID: 23116 RVA: 0x0003399A File Offset: 0x00031B9A
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020E3 RID: 8419
			// (get) Token: 0x06005A4D RID: 23117 RVA: 0x001465E0 File Offset: 0x001447E0
			// (set) Token: 0x06005A4E RID: 23118 RVA: 0x000339A3 File Offset: 0x00031BA3
			public unsafe GameObject root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass44_0.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass44_0.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BFF RID: 15359
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x04003C00 RID: 15360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C01 RID: 15361
			private static readonly IntPtr NativeMethodInfoPtr__ApplyLocalizationParams_b__0_Internal_Object_String_0;
		}

		// Token: 0x020003D1 RID: 977
		[ObfuscatedName("I2.Loc.LocalizationManager+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005A4F RID: 23119 RVA: 0x00146610 File Offset: 0x00144810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass45_0>.NativeClassPtr);
				LocalizationManager.__c__DisplayClass45_0.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass45_0>.NativeClassPtr, "parameters");
				LocalizationManager.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass45_0>.NativeClassPtr, 100670175);
				LocalizationManager.__c__DisplayClass45_0.NativeMethodInfoPtr__ApplyLocalizationParams_b__0_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass45_0>.NativeClassPtr, 100670176);
			}

			// Token: 0x06005A50 RID: 23120 RVA: 0x00146678 File Offset: 0x00144878
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A51 RID: 23121 RVA: 0x001466B4 File Offset: 0x001448B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111391, XrefRangeEnd = 111393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object _ApplyLocalizationParams_b__0(string p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass45_0.NativeMethodInfoPtr__ApplyLocalizationParams_b__0_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A52 RID: 23122 RVA: 0x000339C2 File Offset: 0x00031BC2
			public __c__DisplayClass45_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020E4 RID: 8420
			// (get) Token: 0x06005A53 RID: 23123 RVA: 0x00146704 File Offset: 0x00144904
			// (set) Token: 0x06005A54 RID: 23124 RVA: 0x000339CB File Offset: 0x00031BCB
			public unsafe Dictionary<string, global::Il2CppSystem.Object> parameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass45_0.NativeFieldInfoPtr_parameters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, global::Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass45_0.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C02 RID: 15362
			private static readonly IntPtr NativeFieldInfoPtr_parameters;

			// Token: 0x04003C03 RID: 15363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C04 RID: 15364
			private static readonly IntPtr NativeMethodInfoPtr__ApplyLocalizationParams_b__0_Internal_Object_String_0;
		}

		// Token: 0x020003D2 RID: 978
		[ObfuscatedName("I2.Loc.LocalizationManager+<Delayed_Import_Google>d__63")]
		public sealed class _Delayed_Import_Google_d__63 : global::Il2CppSystem.Object
		{
			// Token: 0x06005A55 RID: 23125 RVA: 0x00146734 File Offset: 0x00144934
			// Note: this type is marked as 'beforefieldinit'.
			static _Delayed_Import_Google_d__63()
			{
				Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<Delayed_Import_Google>d__63");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr);
				LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, "<>1__state");
				LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, "<>2__current");
				LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, "delay");
				LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, "source");
				LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_justCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, "justCheck");
				LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, 100670177);
				LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, 100670178);
				LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, 100670179);
				LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, 100670180);
				LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, 100670181);
				LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr, 100670182);
			}

			// Token: 0x06005A56 RID: 23126 RVA: 0x0014683C File Offset: 0x00144A3C
			[CallerCount(0)]
			public unsafe _Delayed_Import_Google_d__63(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager._Delayed_Import_Google_d__63>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A57 RID: 23127 RVA: 0x00146884 File Offset: 0x00144A84
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A58 RID: 23128 RVA: 0x001468B8 File Offset: 0x00144AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111393, XrefRangeEnd = 111396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170020EA RID: 8426
			// (get) Token: 0x06005A59 RID: 23129 RVA: 0x001468F4 File Offset: 0x00144AF4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A5A RID: 23130 RVA: 0x00146934 File Offset: 0x00144B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111396, XrefRangeEnd = 111401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170020EB RID: 8427
			// (get) Token: 0x06005A5B RID: 23131 RVA: 0x00146968 File Offset: 0x00144B68
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Delayed_Import_Google_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A5C RID: 23132 RVA: 0x000339EA File Offset: 0x00031BEA
			public _Delayed_Import_Google_d__63(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020E5 RID: 8421
			// (get) Token: 0x06005A5D RID: 23133 RVA: 0x001469A8 File Offset: 0x00144BA8
			// (set) Token: 0x06005A5E RID: 23134 RVA: 0x000339F3 File Offset: 0x00031BF3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170020E6 RID: 8422
			// (get) Token: 0x06005A5F RID: 23135 RVA: 0x001469D0 File Offset: 0x00144BD0
			// (set) Token: 0x06005A60 RID: 23136 RVA: 0x00033A0E File Offset: 0x00031C0E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020E7 RID: 8423
			// (get) Token: 0x06005A61 RID: 23137 RVA: 0x00146A00 File Offset: 0x00144C00
			// (set) Token: 0x06005A62 RID: 23138 RVA: 0x00033A2D File Offset: 0x00031C2D
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170020E8 RID: 8424
			// (get) Token: 0x06005A63 RID: 23139 RVA: 0x00146A28 File Offset: 0x00144C28
			// (set) Token: 0x06005A64 RID: 23140 RVA: 0x00033A48 File Offset: 0x00031C48
			public unsafe LanguageSourceData source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020E9 RID: 8425
			// (get) Token: 0x06005A65 RID: 23141 RVA: 0x00146A58 File Offset: 0x00144C58
			// (set) Token: 0x06005A66 RID: 23142 RVA: 0x00033A67 File Offset: 0x00031C67
			public unsafe bool justCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_justCheck);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Delayed_Import_Google_d__63.NativeFieldInfoPtr_justCheck)) = value;
				}
			}

			// Token: 0x04003C05 RID: 15365
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C06 RID: 15366
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C07 RID: 15367
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04003C08 RID: 15368
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04003C09 RID: 15369
			private static readonly IntPtr NativeFieldInfoPtr_justCheck;

			// Token: 0x04003C0A RID: 15370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C0B RID: 15371
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C0C RID: 15372
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C0D RID: 15373
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C0E RID: 15374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C0F RID: 15375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003D3 RID: 979
		[ObfuscatedName("I2.Loc.LocalizationManager+<>c__DisplayClass73_0")]
		public sealed class __c__DisplayClass73_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005A67 RID: 23143 RVA: 0x00146A80 File Offset: 0x00144C80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass73_0()
			{
				Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<>c__DisplayClass73_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass73_0>.NativeClassPtr);
				LocalizationManager.__c__DisplayClass73_0.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass73_0>.NativeClassPtr, "desc");
				LocalizationManager.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass73_0>.NativeClassPtr, 100670183);
				LocalizationManager.__c__DisplayClass73_0.NativeMethodInfoPtr__RegisterTarget_b__0_Internal_Boolean_ILocalizeTargetDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass73_0>.NativeClassPtr, 100670184);
			}

			// Token: 0x06005A68 RID: 23144 RVA: 0x00146AE8 File Offset: 0x00144CE8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass73_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager.__c__DisplayClass73_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A69 RID: 23145 RVA: 0x00146B24 File Offset: 0x00144D24
			[CallerCount(0)]
			public unsafe bool _RegisterTarget_b__0(ILocalizeTargetDescriptor x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager.__c__DisplayClass73_0.NativeMethodInfoPtr__RegisterTarget_b__0_Internal_Boolean_ILocalizeTargetDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A6A RID: 23146 RVA: 0x00033A82 File Offset: 0x00031C82
			public __c__DisplayClass73_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020EC RID: 8428
			// (get) Token: 0x06005A6B RID: 23147 RVA: 0x00146B74 File Offset: 0x00144D74
			// (set) Token: 0x06005A6C RID: 23148 RVA: 0x00033A8B File Offset: 0x00031C8B
			public unsafe ILocalizeTargetDescriptor desc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass73_0.NativeFieldInfoPtr_desc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILocalizeTargetDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager.__c__DisplayClass73_0.NativeFieldInfoPtr_desc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C10 RID: 15376
			private static readonly IntPtr NativeFieldInfoPtr_desc;

			// Token: 0x04003C11 RID: 15377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C12 RID: 15378
			private static readonly IntPtr NativeMethodInfoPtr__RegisterTarget_b__0_Internal_Boolean_ILocalizeTargetDescriptor_0;
		}

		// Token: 0x020003D4 RID: 980
		[ObfuscatedName("I2.Loc.LocalizationManager+<Coroutine_LocalizeAll>d__88")]
		public sealed class _Coroutine_LocalizeAll_d__88 : global::Il2CppSystem.Object
		{
			// Token: 0x06005A6D RID: 23149 RVA: 0x00146BA4 File Offset: 0x00144DA4
			// Note: this type is marked as 'beforefieldinit'.
			static _Coroutine_LocalizeAll_d__88()
			{
				Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr, "<Coroutine_LocalizeAll>d__88");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr);
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, "<>1__state");
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, "<>2__current");
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, 100670185);
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, 100670186);
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, 100670187);
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, 100670188);
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, 100670189);
				LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr, 100670190);
			}

			// Token: 0x06005A6E RID: 23150 RVA: 0x00146C70 File Offset: 0x00144E70
			[CallerCount(0)]
			public unsafe _Coroutine_LocalizeAll_d__88(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationManager._Coroutine_LocalizeAll_d__88>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A6F RID: 23151 RVA: 0x00146CB8 File Offset: 0x00144EB8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A70 RID: 23152 RVA: 0x00146CEC File Offset: 0x00144EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111401, XrefRangeEnd = 111405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170020EF RID: 8431
			// (get) Token: 0x06005A71 RID: 23153 RVA: 0x00146D28 File Offset: 0x00144F28
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A72 RID: 23154 RVA: 0x00146D68 File Offset: 0x00144F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111405, XrefRangeEnd = 111410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170020F0 RID: 8432
			// (get) Token: 0x06005A73 RID: 23155 RVA: 0x00146D9C File Offset: 0x00144F9C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A74 RID: 23156 RVA: 0x00033AAA File Offset: 0x00031CAA
			public _Coroutine_LocalizeAll_d__88(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020ED RID: 8429
			// (get) Token: 0x06005A75 RID: 23157 RVA: 0x00146DDC File Offset: 0x00144FDC
			// (set) Token: 0x06005A76 RID: 23158 RVA: 0x00033AB3 File Offset: 0x00031CB3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170020EE RID: 8430
			// (get) Token: 0x06005A77 RID: 23159 RVA: 0x00146E04 File Offset: 0x00145004
			// (set) Token: 0x06005A78 RID: 23160 RVA: 0x00033ACE File Offset: 0x00031CCE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationManager._Coroutine_LocalizeAll_d__88.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C13 RID: 15379
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C14 RID: 15380
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C15 RID: 15381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C16 RID: 15382
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C17 RID: 15383
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C18 RID: 15384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C19 RID: 15385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C1A RID: 15386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003D5 RID: 981
		private sealed class MethodInfoStoreGeneric_GetTranslatedObject_Public_Static_T_String_Localize_0<T>
		{
			// Token: 0x04003C1B RID: 15387
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizationManager.NativeMethodInfoPtr_GetTranslatedObject_Public_Static_T_String_Localize_0, Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003D6 RID: 982
		private sealed class MethodInfoStoreGeneric_GetTranslatedObjectByTermName_Public_Static_T_String_Localize_0<T>
		{
			// Token: 0x04003C1C RID: 15388
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizationManager.NativeMethodInfoPtr_GetTranslatedObjectByTermName_Public_Static_T_String_Localize_0, Il2CppClassPointerStore<LocalizationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
