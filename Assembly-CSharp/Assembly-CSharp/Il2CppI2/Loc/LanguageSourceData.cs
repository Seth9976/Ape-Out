using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace Il2CppI2.Loc
{
	// Token: 0x0200023D RID: 573
	[Serializable]
	public class LanguageSourceData : global::Il2CppSystem.Object
	{
		// Token: 0x06004393 RID: 17299 RVA: 0x000FAD68 File Offset: 0x000F8F68
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageSourceData()
		{
			Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LanguageSourceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr);
			LanguageSourceData.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "owner");
			LanguageSourceData.NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "UserAgreesToHaveItOnTheScene");
			LanguageSourceData.NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "UserAgreesToHaveItInsideThePluginsFolder");
			LanguageSourceData.NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "GoogleLiveSyncIsUptoDate");
			LanguageSourceData.NativeFieldInfoPtr_mIsGlobalSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "mIsGlobalSource");
			LanguageSourceData.NativeFieldInfoPtr_mTerms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "mTerms");
			LanguageSourceData.NativeFieldInfoPtr_CaseInsensitiveTerms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "CaseInsensitiveTerms");
			LanguageSourceData.NativeFieldInfoPtr_mDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "mDictionary");
			LanguageSourceData.NativeFieldInfoPtr_OnMissingTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "OnMissingTranslation");
			LanguageSourceData.NativeFieldInfoPtr_mTerm_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "mTerm_AppName");
			LanguageSourceData.NativeFieldInfoPtr_mLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "mLanguages");
			LanguageSourceData.NativeFieldInfoPtr_IgnoreDeviceLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "IgnoreDeviceLanguage");
			LanguageSourceData.NativeFieldInfoPtr__AllowUnloadingLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "_AllowUnloadingLanguages");
			LanguageSourceData.NativeFieldInfoPtr_Google_WebServiceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "Google_WebServiceURL");
			LanguageSourceData.NativeFieldInfoPtr_Google_SpreadsheetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "Google_SpreadsheetKey");
			LanguageSourceData.NativeFieldInfoPtr_Google_SpreadsheetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "Google_SpreadsheetName");
			LanguageSourceData.NativeFieldInfoPtr_Google_LastUpdatedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "Google_LastUpdatedVersion");
			LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "GoogleUpdateFrequency");
			LanguageSourceData.NativeFieldInfoPtr_GoogleInEditorCheckFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "GoogleInEditorCheckFrequency");
			LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateSynchronization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "GoogleUpdateSynchronization");
			LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "GoogleUpdateDelay");
			LanguageSourceData.NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "Event_OnSourceUpdateFromGoogle");
			LanguageSourceData.NativeFieldInfoPtr_Assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "Assets");
			LanguageSourceData.NativeFieldInfoPtr_mAssetDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "mAssetDictionary");
			LanguageSourceData.NativeFieldInfoPtr_mDelayedGoogleData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "mDelayedGoogleData");
			LanguageSourceData.NativeFieldInfoPtr_EmptyCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "EmptyCategory");
			LanguageSourceData.NativeFieldInfoPtr_CategorySeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "CategorySeparators");
			LanguageSourceData.NativeMethodInfoPtr_get_ownerObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669942);
			LanguageSourceData.NativeMethodInfoPtr_add_Event_OnSourceUpdateFromGoogle_Public_add_Void_fnOnSourceUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669943);
			LanguageSourceData.NativeMethodInfoPtr_remove_Event_OnSourceUpdateFromGoogle_Public_rem_Void_fnOnSourceUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669944);
			LanguageSourceData.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669945);
			LanguageSourceData.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669946);
			LanguageSourceData.NativeMethodInfoPtr_IsEqualTo_Public_Boolean_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669947);
			LanguageSourceData.NativeMethodInfoPtr_ManagerHasASimilarSource_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669948);
			LanguageSourceData.NativeMethodInfoPtr_ClearAllData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669949);
			LanguageSourceData.NativeMethodInfoPtr_IsGlobalSource_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669950);
			LanguageSourceData.NativeMethodInfoPtr_Editor_SetDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669951);
			LanguageSourceData.NativeMethodInfoPtr_UpdateAssetDictionary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669952);
			LanguageSourceData.NativeMethodInfoPtr_FindAsset_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669953);
			LanguageSourceData.NativeMethodInfoPtr_HasAsset_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669954);
			LanguageSourceData.NativeMethodInfoPtr_AddAsset_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669955);
			LanguageSourceData.NativeMethodInfoPtr_Export_I2CSV_Public_String_String_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669956);
			LanguageSourceData.NativeMethodInfoPtr_AppendI2Term_Private_Static_Void_StringBuilder_Int32_String_TermData_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669957);
			LanguageSourceData.NativeMethodInfoPtr_AppendI2Text_Private_Static_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669958);
			LanguageSourceData.NativeMethodInfoPtr_Export_Language_to_Cache_Private_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669959);
			LanguageSourceData.NativeMethodInfoPtr_Export_CSV_Public_String_String_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669960);
			LanguageSourceData.NativeMethodInfoPtr_AppendTerm_Private_Static_Void_StringBuilder_Int32_String_TermData_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669961);
			LanguageSourceData.NativeMethodInfoPtr_AppendString_Private_Static_Void_StringBuilder_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669962);
			LanguageSourceData.NativeMethodInfoPtr_AppendTranslation_Private_Static_Void_StringBuilder_String_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669963);
			LanguageSourceData.NativeMethodInfoPtr_Export_Google_CreateWWWcall_Public_UnityWebRequest_eSpreadsheetUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669964);
			LanguageSourceData.NativeMethodInfoPtr_Export_Google_CreateData_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669965);
			LanguageSourceData.NativeMethodInfoPtr_Import_CSV_Public_String_String_String_eSpreadsheetUpdateMode_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669966);
			LanguageSourceData.NativeMethodInfoPtr_Import_I2CSV_Public_String_String_String_eSpreadsheetUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669967);
			LanguageSourceData.NativeMethodInfoPtr_Import_CSV_Public_String_String_List_1_Il2CppStringArray_eSpreadsheetUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669968);
			LanguageSourceData.NativeMethodInfoPtr_ArrayContains_Private_Boolean_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669969);
			LanguageSourceData.NativeMethodInfoPtr_GetTermType_Public_Static_eTermType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669970);
			LanguageSourceData.NativeMethodInfoPtr_Import_Language_from_Cache_Private_Void_Int32_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669971);
			LanguageSourceData.NativeMethodInfoPtr_FreeUnusedLanguages_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669972);
			LanguageSourceData.NativeMethodInfoPtr_Import_Google_FromCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669973);
			LanguageSourceData.NativeMethodInfoPtr_IsNewerVersion_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669974);
			LanguageSourceData.NativeMethodInfoPtr_Import_Google_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669975);
			LanguageSourceData.NativeMethodInfoPtr_GetSourcePlayerPrefName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669976);
			LanguageSourceData.NativeMethodInfoPtr_Import_Google_Coroutine_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669977);
			LanguageSourceData.NativeMethodInfoPtr_ApplyDownloadedDataOnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669978);
			LanguageSourceData.NativeMethodInfoPtr_ApplyDownloadedDataFromGoogle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669979);
			LanguageSourceData.NativeMethodInfoPtr_Import_Google_CreateWWWcall_Public_UnityWebRequest_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669980);
			LanguageSourceData.NativeMethodInfoPtr_HasGoogleSpreadsheet_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669981);
			LanguageSourceData.NativeMethodInfoPtr_Import_Google_Result_Public_String_String_eSpreadsheetUpdateMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669982);
			LanguageSourceData.NativeMethodInfoPtr_GetLanguageIndex_Public_Int32_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669983);
			LanguageSourceData.NativeMethodInfoPtr_GetLanguageData_Public_LanguageData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669984);
			LanguageSourceData.NativeMethodInfoPtr_IsCurrentLanguage_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669985);
			LanguageSourceData.NativeMethodInfoPtr_GetLanguageIndexFromCode_Public_Int32_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669986);
			LanguageSourceData.NativeMethodInfoPtr_GetCommonWordInLanguageNames_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669987);
			LanguageSourceData.NativeMethodInfoPtr_AreTheSameLanguage_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669988);
			LanguageSourceData.NativeMethodInfoPtr_GetLanguageWithoutRegion_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669989);
			LanguageSourceData.NativeMethodInfoPtr_AddLanguage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669990);
			LanguageSourceData.NativeMethodInfoPtr_AddLanguage_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669991);
			LanguageSourceData.NativeMethodInfoPtr_RemoveLanguage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669992);
			LanguageSourceData.NativeMethodInfoPtr_GetLanguages_Public_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669993);
			LanguageSourceData.NativeMethodInfoPtr_GetLanguagesCode_Public_List_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669994);
			LanguageSourceData.NativeMethodInfoPtr_IsLanguageEnabled_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669995);
			LanguageSourceData.NativeMethodInfoPtr_EnableLanguage_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669996);
			LanguageSourceData.NativeMethodInfoPtr_AllowUnloadingLanguages_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669997);
			LanguageSourceData.NativeMethodInfoPtr_GetSavedLanguageFileName_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669998);
			LanguageSourceData.NativeMethodInfoPtr_LoadLanguage_Public_Void_Int32_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100669999);
			LanguageSourceData.NativeMethodInfoPtr_LoadAllLanguages_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670000);
			LanguageSourceData.NativeMethodInfoPtr_UnloadLanguage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670001);
			LanguageSourceData.NativeMethodInfoPtr_SaveLanguages_Public_Void_Boolean_eFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670002);
			LanguageSourceData.NativeMethodInfoPtr_HasUnloadedLanguages_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670003);
			LanguageSourceData.NativeMethodInfoPtr_GetCategories_Public_List_1_String_Boolean_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670004);
			LanguageSourceData.NativeMethodInfoPtr_GetKeyFromFullTerm_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670005);
			LanguageSourceData.NativeMethodInfoPtr_GetCategoryFromFullTerm_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670006);
			LanguageSourceData.NativeMethodInfoPtr_DeserializeFullTerm_Public_Static_Void_String_byref_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670007);
			LanguageSourceData.NativeMethodInfoPtr_UpdateDictionary_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670008);
			LanguageSourceData.NativeMethodInfoPtr_GetTranslation_Public_String_String_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670009);
			LanguageSourceData.NativeMethodInfoPtr_TryGetTranslation_Public_Boolean_String_byref_String_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670010);
			LanguageSourceData.NativeMethodInfoPtr_TryGetFallbackTranslation_Private_Boolean_TermData_byref_String_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670011);
			LanguageSourceData.NativeMethodInfoPtr_AddTerm_Public_TermData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670012);
			LanguageSourceData.NativeMethodInfoPtr_GetTermData_Public_TermData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670013);
			LanguageSourceData.NativeMethodInfoPtr_ContainsTerm_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670014);
			LanguageSourceData.NativeMethodInfoPtr_GetTermsList_Public_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670015);
			LanguageSourceData.NativeMethodInfoPtr_AddTerm_Public_TermData_String_eTermType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670016);
			LanguageSourceData.NativeMethodInfoPtr_RemoveTerm_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670017);
			LanguageSourceData.NativeMethodInfoPtr_ValidateFullTerm_Public_Static_Void_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670018);
			LanguageSourceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, 100670019);
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x000FB5CC File Offset: 0x000F97CC
		public unsafe global::UnityEngine.Object ownerObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108867, XrefRangeEnd = 108868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_get_ownerObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x000FB60C File Offset: 0x000F980C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108868, XrefRangeEnd = 108871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Event_OnSourceUpdateFromGoogle(LanguageSource.fnOnSourceUpdated value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_add_Event_OnSourceUpdateFromGoogle_Public_add_Void_fnOnSourceUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x000FB650 File Offset: 0x000F9850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108871, XrefRangeEnd = 108874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Event_OnSourceUpdateFromGoogle(LanguageSource.fnOnSourceUpdated value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_remove_Event_OnSourceUpdateFromGoogle_Public_rem_Void_fnOnSourceUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x000FB694 File Offset: 0x000F9894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108874, XrefRangeEnd = 108881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x000FB6C8 File Offset: 0x000F98C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108881, XrefRangeEnd = 108885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x000FB6FC File Offset: 0x000F98FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108892, RefRangeEnd = 108893, XrefRangeStart = 108885, XrefRangeEnd = 108892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEqualTo(LanguageSourceData Source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_IsEqualTo_Public_Boolean_LanguageSourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x000FB74C File Offset: 0x000F994C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108893, XrefRangeEnd = 108903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ManagerHasASimilarSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_ManagerHasASimilarSource_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x000FB788 File Offset: 0x000F9988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108914, RefRangeEnd = 108916, XrefRangeStart = 108903, XrefRangeEnd = 108914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_ClearAllData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x000FB7BC File Offset: 0x000F99BC
		[CallerCount(0)]
		public unsafe bool IsGlobalSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_IsGlobalSource_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x000FB7F8 File Offset: 0x000F99F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Editor_SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Editor_SetDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x000FB82C File Offset: 0x000F9A2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108985, RefRangeEnd = 108989, XrefRangeStart = 108916, XrefRangeEnd = 108985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAssetDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_UpdateAssetDictionary_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x000FB860 File Offset: 0x000F9A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108994, RefRangeEnd = 108995, XrefRangeStart = 108989, XrefRangeEnd = 108994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::UnityEngine.Object FindAsset(string Name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_FindAsset_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x000FB8B0 File Offset: 0x000F9AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108995, XrefRangeEnd = 108999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAsset(global::UnityEngine.Object Obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_HasAsset_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x000FB900 File Offset: 0x000F9B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108999, XrefRangeEnd = 109006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAsset(global::UnityEngine.Object Obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AddAsset_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x000FB944 File Offset: 0x000F9B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109091, XrefRangeStart = 109006, XrefRangeEnd = 109090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specializationsAsRows;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Export_I2CSV_Public_String_String_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x000FB9A8 File Offset: 0x000F9BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109122, RefRangeEnd = 109124, XrefRangeStart = 109091, XrefRangeEnd = 109122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLanguages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Term);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(termData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(forceSpecialization);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AppendI2Term_Private_Static_Void_StringBuilder_Int32_String_TermData_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x000FBA34 File Offset: 0x000F9C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109135, RefRangeEnd = 109137, XrefRangeStart = 109124, XrefRangeEnd = 109135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendI2Text(StringBuilder Builder, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AppendI2Text_Private_Static_Void_StringBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x000FBA7C File Offset: 0x000F9C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109162, RefRangeEnd = 109163, XrefRangeStart = 109137, XrefRangeEnd = 109162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref langIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillTermWithFallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Export_Language_to_Cache_Private_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x000FBAD0 File Offset: 0x000F9CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109163, XrefRangeEnd = 109253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specializationsAsRows;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Export_CSV_Public_String_String_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x000FBB34 File Offset: 0x000F9D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109284, RefRangeEnd = 109286, XrefRangeStart = 109253, XrefRangeEnd = 109284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLanguages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Term);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(termData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specialization);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AppendTerm_Private_Static_Void_StringBuilder_Int32_String_TermData_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x000FBBC0 File Offset: 0x000F9DC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109306, RefRangeEnd = 109309, XrefRangeStart = 109286, XrefRangeEnd = 109306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AppendString_Private_Static_Void_StringBuilder_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x000FBC18 File Offset: 0x000F9E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109330, RefRangeEnd = 109331, XrefRangeStart = 109309, XrefRangeEnd = 109330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AppendTranslation_Private_Static_Void_StringBuilder_String_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x000FBC80 File Offset: 0x000F9E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109331, XrefRangeEnd = 109359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref UpdateMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Export_Google_CreateWWWcall_Public_UnityWebRequest_eSpreadsheetUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x000FBCCC File Offset: 0x000F9ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109384, RefRangeEnd = 109385, XrefRangeStart = 109359, XrefRangeEnd = 109384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Export_Google_CreateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Export_Google_CreateData_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x000FBD04 File Offset: 0x000F9F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109385, XrefRangeEnd = 109398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(CSVstring);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UpdateMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_CSV_Public_String_String_String_eSpreadsheetUpdateMode_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x000FBD7C File Offset: 0x000F9F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109398, XrefRangeEnd = 109400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(I2CSVstring);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UpdateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_I2CSV_Public_String_String_String_eSpreadsheetUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x000FBDE4 File Offset: 0x000F9FE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109566, RefRangeEnd = 109569, XrefRangeStart = 109400, XrefRangeEnd = 109566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Import_CSV(string Category, List<Il2CppStringArray> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(CSV);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UpdateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_CSV_Public_String_String_List_1_Il2CppStringArray_eSpreadsheetUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x000FBE4C File Offset: 0x000FA04C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109574, RefRangeEnd = 109579, XrefRangeStart = 109569, XrefRangeEnd = 109574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ArrayContains(string MainText, [Optional] Il2CppStringArray texts)
		{
			if (texts == null)
			{
				texts = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(MainText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_ArrayContains_Private_Boolean_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x000FBEB8 File Offset: 0x000FA0B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109584, RefRangeEnd = 109585, XrefRangeStart = 109579, XrefRangeEnd = 109584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static eTermType GetTermType(string type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetTermType_Public_Static_eTermType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x000FBEFC File Offset: 0x000FA0FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109616, RefRangeEnd = 109618, XrefRangeStart = 109585, XrefRangeEnd = 109616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref langIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(langData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useFallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyCurrentSpecialization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_Language_from_Cache_Private_Void_Int32_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x000FBF68 File Offset: 0x000FA168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109618, XrefRangeEnd = 109634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeUnusedLanguages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_FreeUnusedLanguages_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x000FBF90 File Offset: 0x000FA190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109670, RefRangeEnd = 109671, XrefRangeStart = 109634, XrefRangeEnd = 109670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Import_Google_FromCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_Google_FromCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x000FBFC4 File Offset: 0x000FA1C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109675, RefRangeEnd = 109677, XrefRangeStart = 109671, XrefRangeEnd = 109675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNewerVersion(string currentVersion, string newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(currentVersion);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_IsNewerVersion_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x000FC024 File Offset: 0x000FA224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109724, RefRangeEnd = 109725, XrefRangeStart = 109677, XrefRangeEnd = 109724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Import_Google(bool ForceUpdate, bool justCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ForceUpdate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref justCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_Google_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x000FC070 File Offset: 0x000FA270
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109746, RefRangeEnd = 109751, XrefRangeStart = 109725, XrefRangeEnd = 109746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSourcePlayerPrefName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetSourcePlayerPrefName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x000FC0A8 File Offset: 0x000FA2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109751, XrefRangeEnd = 109754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref JustCheck;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_Google_Coroutine_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x000FC0F4 File Offset: 0x000FA2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109754, XrefRangeEnd = 109767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_ApplyDownloadedDataOnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x000FC140 File Offset: 0x000FA340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109788, RefRangeEnd = 109790, XrefRangeStart = 109767, XrefRangeEnd = 109788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDownloadedDataFromGoogle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_ApplyDownloadedDataFromGoogle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x000FC174 File Offset: 0x000FA374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109814, RefRangeEnd = 109815, XrefRangeStart = 109790, XrefRangeEnd = 109814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ForceUpdate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref justCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_Google_CreateWWWcall_Public_UnityWebRequest_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x000FC1D0 File Offset: 0x000FA3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109819, RefRangeEnd = 109821, XrefRangeStart = 109815, XrefRangeEnd = 109819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasGoogleSpreadsheet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_HasGoogleSpreadsheet_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x000FC20C File Offset: 0x000FA40C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109923, RefRangeEnd = 109925, XrefRangeStart = 109821, XrefRangeEnd = 109923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(JsonString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UpdateMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveInPlayerPrefs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_Import_Google_Result_Public_String_String_eSpreadsheetUpdateMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x000FC270 File Offset: 0x000FA470
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 109933, RefRangeEnd = 109948, XrefRangeStart = 109925, XrefRangeEnd = 109933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AllowDiscartingRegion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref SkipDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetLanguageIndex_Public_Int32_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x000FC2DC File Offset: 0x000FA4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109948, XrefRangeEnd = 109950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AllowDiscartingRegion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetLanguageData_Public_LanguageData_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageData>(intPtr3) : null;
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x000FC33C File Offset: 0x000FA53C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109960, RefRangeEnd = 109963, XrefRangeStart = 109950, XrefRangeEnd = 109960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentLanguage(int languageIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref languageIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_IsCurrentLanguage_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x000FC388 File Offset: 0x000FA588
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109970, RefRangeEnd = 109974, XrefRangeStart = 109963, XrefRangeEnd = 109970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exactMatch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetLanguageIndexFromCode_Public_Int32_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x000FC3F4 File Offset: 0x000FA5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109974, XrefRangeEnd = 109986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Language2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetCommonWordInLanguageNames_Public_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x000FC448 File Offset: 0x000FA648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109986, XrefRangeEnd = 110007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreTheSameLanguage(string Language1, string Language2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Language2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AreTheSameLanguage_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x000FC49C File Offset: 0x000FA69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110007, XrefRangeEnd = 110013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLanguageWithoutRegion(string Language)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetLanguageWithoutRegion_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x000FC4D8 File Offset: 0x000FA6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110013, XrefRangeEnd = 110018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLanguage(string LanguageName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(LanguageName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AddLanguage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x000FC51C File Offset: 0x000FA71C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110039, RefRangeEnd = 110041, XrefRangeStart = 110018, XrefRangeEnd = 110039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLanguage(string LanguageName, string LanguageCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(LanguageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(LanguageCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AddLanguage_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x000FC570 File Offset: 0x000FA770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110041, XrefRangeEnd = 110056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLanguage(string LanguageName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(LanguageName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_RemoveLanguage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x000FC5B4 File Offset: 0x000FA7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110067, RefRangeEnd = 110068, XrefRangeStart = 110056, XrefRangeEnd = 110067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetLanguages(bool skipDisabled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipDisabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetLanguages_Public_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x000FC600 File Offset: 0x000FA800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110084, RefRangeEnd = 110085, XrefRangeStart = 110068, XrefRangeEnd = 110084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowRegions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetLanguagesCode_Public_List_1_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x000FC65C File Offset: 0x000FA85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110087, RefRangeEnd = 110088, XrefRangeStart = 110085, XrefRangeEnd = 110087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLanguageEnabled(string Language)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_IsLanguageEnabled_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x000FC6AC File Offset: 0x000FA8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110088, XrefRangeEnd = 110090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLanguage(string Language, bool bEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_EnableLanguage_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x000FC6FC File Offset: 0x000FA8FC
		[CallerCount(0)]
		public unsafe bool AllowUnloadingLanguages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AllowUnloadingLanguages_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x000FC738 File Offset: 0x000FA938
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110115, RefRangeEnd = 110119, XrefRangeStart = 110090, XrefRangeEnd = 110115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSavedLanguageFileName(int languageIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref languageIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetSavedLanguageFileName_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x000FC77C File Offset: 0x000FA97C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110128, RefRangeEnd = 110130, XrefRangeStart = 110119, XrefRangeEnd = 110128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref languageIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UnloadOtherLanguages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useFallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyCurrentSpecialization;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceLoad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_LoadLanguage_Public_Void_Int32_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x000FC7F4 File Offset: 0x000FA9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110130, XrefRangeEnd = 110138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAllLanguages(bool forceLoad = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forceLoad;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_LoadAllLanguages_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x000FC834 File Offset: 0x000FAA34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110160, RefRangeEnd = 110162, XrefRangeStart = 110138, XrefRangeEnd = 110160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadLanguage(int languageIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref languageIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_UnloadLanguage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x000FC874 File Offset: 0x000FAA74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110172, RefRangeEnd = 110175, XrefRangeStart = 110162, XrefRangeEnd = 110172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unloadAll;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fileLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_SaveLanguages_Public_Void_Boolean_eFileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x000FC8C0 File Offset: 0x000FAAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110175, XrefRangeEnd = 110178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasUnloadedLanguages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_HasUnloadedLanguages_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x000FC8FC File Offset: 0x000FAAFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110204, RefRangeEnd = 110206, XrefRangeStart = 110178, XrefRangeEnd = 110204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetCategories(bool OnlyMainCategory = false, List<string> Categories = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref OnlyMainCategory;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Categories);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetCategories_Public_List_1_String_Boolean_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x000FC95C File Offset: 0x000FAB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110215, RefRangeEnd = 110216, XrefRangeStart = 110206, XrefRangeEnd = 110215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(FullTerm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OnlyMainCategory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetKeyFromFullTerm_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x000FC9A8 File Offset: 0x000FABA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110228, RefRangeEnd = 110230, XrefRangeStart = 110216, XrefRangeEnd = 110228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(FullTerm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OnlyMainCategory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetCategoryFromFullTerm_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x000FC9F4 File Offset: 0x000FABF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110230, XrefRangeEnd = 110241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(FullTerm);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OnlyMainCategory;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_DeserializeFullTerm_Public_Static_Void_String_byref_String_byref_String_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			Key = IL2CPP.Il2CppStringToManaged(intPtr);
			Category = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x000FCA6C File Offset: 0x000FAC6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 110271, RefRangeEnd = 110276, XrefRangeStart = 110241, XrefRangeEnd = 110271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDictionary(bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_UpdateDictionary_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x000FCAAC File Offset: 0x000FACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110276, XrefRangeEnd = 110280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTranslation(string term, string overrideLanguage = null, string overrideSpecialization = null, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLanguage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideSpecialization);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabled;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCategoryMistmatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetTranslation_Public_String_String_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x000FCB34 File Offset: 0x000FAD34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110298, RefRangeEnd = 110300, XrefRangeStart = 110280, XrefRangeEnd = 110298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTranslation(string term, out string Translation, string overrideLanguage = null, string overrideSpecialization = null, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLanguage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideSpecialization);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabled;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCategoryMistmatch;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_TryGetTranslation_Public_Boolean_String_byref_String_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			Translation = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x000FCBE0 File Offset: 0x000FADE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110322, RefRangeEnd = 110324, XrefRangeStart = 110300, XrefRangeEnd = 110322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, string overrideSpecialization = null, bool skipDisabled = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(termData);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref langIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideSpecialization);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabled;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_TryGetFallbackTranslation_Private_Boolean_TermData_byref_String_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			Translation = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x000FCC78 File Offset: 0x000FAE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110324, XrefRangeEnd = 110325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermData AddTerm(string term)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AddTerm_Public_TermData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TermData>(intPtr3) : null;
			}
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x000FCCC8 File Offset: 0x000FAEC8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 110347, RefRangeEnd = 110357, XrefRangeStart = 110325, XrefRangeEnd = 110347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCategoryMistmatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetTermData_Public_TermData_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TermData>(intPtr3) : null;
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x000FCD28 File Offset: 0x000FAF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110357, XrefRangeEnd = 110358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsTerm(string term)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_ContainsTerm_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x000FCD78 File Offset: 0x000FAF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110378, RefRangeEnd = 110379, XrefRangeStart = 110358, XrefRangeEnd = 110378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetTermsList(string Category = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_GetTermsList_Public_List_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x000FCDC8 File Offset: 0x000FAFC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110406, RefRangeEnd = 110407, XrefRangeStart = 110379, XrefRangeEnd = 110406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(NewTerm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref termType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref SaveSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_AddTerm_Public_TermData_String_eTermType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TermData>(intPtr3) : null;
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x000FCE34 File Offset: 0x000FB034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110407, XrefRangeEnd = 110411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTerm(string term)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_RemoveTerm_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x000FCE78 File Offset: 0x000FB078
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110432, RefRangeEnd = 110435, XrefRangeStart = 110411, XrefRangeEnd = 110432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateFullTerm(ref string Term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(Term);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr_ValidateFullTerm_Public_Static_Void_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				Term = IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x000FCEBC File Offset: 0x000FB0BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110468, RefRangeEnd = 110471, XrefRangeStart = 110435, XrefRangeEnd = 110468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageSourceData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x0002904C File Offset: 0x0002724C
		public bool ArrayContains(string MainText, params string[] texts)
		{
			return this.ArrayContains(MainText, new Il2CppStringArray(texts));
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x0002905B File Offset: 0x0002725B
		public LanguageSourceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x060043E4 RID: 17380 RVA: 0x000FCEF8 File Offset: 0x000FB0F8
		// (set) Token: 0x060043E5 RID: 17381 RVA: 0x00029064 File Offset: 0x00027264
		public unsafe ILanguageSource owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILanguageSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x000FCF28 File Offset: 0x000FB128
		// (set) Token: 0x060043E7 RID: 17383 RVA: 0x00029083 File Offset: 0x00027283
		public unsafe bool UserAgreesToHaveItOnTheScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene)) = value;
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060043E8 RID: 17384 RVA: 0x000FCF50 File Offset: 0x000FB150
		// (set) Token: 0x060043E9 RID: 17385 RVA: 0x0002909E File Offset: 0x0002729E
		public unsafe bool UserAgreesToHaveItInsideThePluginsFolder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder)) = value;
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x060043EA RID: 17386 RVA: 0x000FCF78 File Offset: 0x000FB178
		// (set) Token: 0x060043EB RID: 17387 RVA: 0x000290B9 File Offset: 0x000272B9
		public unsafe bool GoogleLiveSyncIsUptoDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate)) = value;
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x060043EC RID: 17388 RVA: 0x000FCFA0 File Offset: 0x000FB1A0
		// (set) Token: 0x060043ED RID: 17389 RVA: 0x000290D4 File Offset: 0x000272D4
		public unsafe bool mIsGlobalSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mIsGlobalSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mIsGlobalSource)) = value;
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x060043EE RID: 17390 RVA: 0x000FCFC8 File Offset: 0x000FB1C8
		// (set) Token: 0x060043EF RID: 17391 RVA: 0x000290EF File Offset: 0x000272EF
		public unsafe List<TermData> mTerms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mTerms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TermData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mTerms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060043F0 RID: 17392 RVA: 0x000FCFF8 File Offset: 0x000FB1F8
		// (set) Token: 0x060043F1 RID: 17393 RVA: 0x0002910E File Offset: 0x0002730E
		public unsafe bool CaseInsensitiveTerms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_CaseInsensitiveTerms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_CaseInsensitiveTerms)) = value;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x000FD020 File Offset: 0x000FB220
		// (set) Token: 0x060043F3 RID: 17395 RVA: 0x00029129 File Offset: 0x00027329
		public unsafe Dictionary<string, TermData> mDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TermData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x000FD050 File Offset: 0x000FB250
		// (set) Token: 0x060043F5 RID: 17397 RVA: 0x00029148 File Offset: 0x00027348
		public unsafe LanguageSourceData.MissingTranslationAction OnMissingTranslation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_OnMissingTranslation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_OnMissingTranslation)) = value;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x000FD078 File Offset: 0x000FB278
		// (set) Token: 0x060043F7 RID: 17399 RVA: 0x00029163 File Offset: 0x00027363
		public unsafe string mTerm_AppName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mTerm_AppName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mTerm_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x000FD0A0 File Offset: 0x000FB2A0
		// (set) Token: 0x060043F9 RID: 17401 RVA: 0x00029182 File Offset: 0x00027382
		public unsafe List<LanguageData> mLanguages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mLanguages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LanguageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mLanguages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x000FD0D0 File Offset: 0x000FB2D0
		// (set) Token: 0x060043FB RID: 17403 RVA: 0x000291A1 File Offset: 0x000273A1
		public unsafe bool IgnoreDeviceLanguage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_IgnoreDeviceLanguage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_IgnoreDeviceLanguage)) = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x000FD0F8 File Offset: 0x000FB2F8
		// (set) Token: 0x060043FD RID: 17405 RVA: 0x000291BC File Offset: 0x000273BC
		public unsafe LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr__AllowUnloadingLanguages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr__AllowUnloadingLanguages)) = value;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x000FD120 File Offset: 0x000FB320
		// (set) Token: 0x060043FF RID: 17407 RVA: 0x000291D7 File Offset: 0x000273D7
		public unsafe string Google_WebServiceURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_WebServiceURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_WebServiceURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x000FD148 File Offset: 0x000FB348
		// (set) Token: 0x06004401 RID: 17409 RVA: 0x000291F6 File Offset: 0x000273F6
		public unsafe string Google_SpreadsheetKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_SpreadsheetKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_SpreadsheetKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x000FD170 File Offset: 0x000FB370
		// (set) Token: 0x06004403 RID: 17411 RVA: 0x00029215 File Offset: 0x00027415
		public unsafe string Google_SpreadsheetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_SpreadsheetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_SpreadsheetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x000FD198 File Offset: 0x000FB398
		// (set) Token: 0x06004405 RID: 17413 RVA: 0x00029234 File Offset: 0x00027434
		public unsafe string Google_LastUpdatedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_LastUpdatedVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Google_LastUpdatedVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x000FD1C0 File Offset: 0x000FB3C0
		// (set) Token: 0x06004407 RID: 17415 RVA: 0x00029253 File Offset: 0x00027453
		public unsafe LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateFrequency)) = value;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x000FD1E8 File Offset: 0x000FB3E8
		// (set) Token: 0x06004409 RID: 17417 RVA: 0x0002926E File Offset: 0x0002746E
		public unsafe LanguageSourceData.eGoogleUpdateFrequency GoogleInEditorCheckFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleInEditorCheckFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleInEditorCheckFrequency)) = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x000FD210 File Offset: 0x000FB410
		// (set) Token: 0x0600440B RID: 17419 RVA: 0x00029289 File Offset: 0x00027489
		public unsafe LanguageSourceData.eGoogleUpdateSynchronization GoogleUpdateSynchronization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateSynchronization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateSynchronization)) = value;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x000FD238 File Offset: 0x000FB438
		// (set) Token: 0x0600440D RID: 17421 RVA: 0x000292A4 File Offset: 0x000274A4
		public unsafe float GoogleUpdateDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_GoogleUpdateDelay)) = value;
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x000FD260 File Offset: 0x000FB460
		// (set) Token: 0x0600440F RID: 17423 RVA: 0x000292BF File Offset: 0x000274BF
		public unsafe LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageSource.fnOnSourceUpdated>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x000FD290 File Offset: 0x000FB490
		// (set) Token: 0x06004411 RID: 17425 RVA: 0x000292DE File Offset: 0x000274DE
		public unsafe List<global::UnityEngine.Object> Assets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Assets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_Assets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x000FD2C0 File Offset: 0x000FB4C0
		// (set) Token: 0x06004413 RID: 17427 RVA: 0x000292FD File Offset: 0x000274FD
		public unsafe Dictionary<string, global::UnityEngine.Object> mAssetDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mAssetDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mAssetDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x000FD2F0 File Offset: 0x000FB4F0
		// (set) Token: 0x06004415 RID: 17429 RVA: 0x0002931C File Offset: 0x0002751C
		public unsafe string mDelayedGoogleData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mDelayedGoogleData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData.NativeFieldInfoPtr_mDelayedGoogleData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06004416 RID: 17430 RVA: 0x000FD318 File Offset: 0x000FB518
		// (set) Token: 0x06004417 RID: 17431 RVA: 0x0002933B File Offset: 0x0002753B
		public unsafe static string EmptyCategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.NativeFieldInfoPtr_EmptyCategory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.NativeFieldInfoPtr_EmptyCategory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06004418 RID: 17432 RVA: 0x000FD338 File Offset: 0x000FB538
		// (set) Token: 0x06004419 RID: 17433 RVA: 0x0002934D File Offset: 0x0002754D
		public unsafe static Il2CppStructArray<char> CategorySeparators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.NativeFieldInfoPtr_CategorySeparators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.NativeFieldInfoPtr_CategorySeparators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002996 RID: 10646
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x04002997 RID: 10647
		private static readonly IntPtr NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene;

		// Token: 0x04002998 RID: 10648
		private static readonly IntPtr NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder;

		// Token: 0x04002999 RID: 10649
		private static readonly IntPtr NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate;

		// Token: 0x0400299A RID: 10650
		private static readonly IntPtr NativeFieldInfoPtr_mIsGlobalSource;

		// Token: 0x0400299B RID: 10651
		private static readonly IntPtr NativeFieldInfoPtr_mTerms;

		// Token: 0x0400299C RID: 10652
		private static readonly IntPtr NativeFieldInfoPtr_CaseInsensitiveTerms;

		// Token: 0x0400299D RID: 10653
		private static readonly IntPtr NativeFieldInfoPtr_mDictionary;

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeFieldInfoPtr_OnMissingTranslation;

		// Token: 0x0400299F RID: 10655
		private static readonly IntPtr NativeFieldInfoPtr_mTerm_AppName;

		// Token: 0x040029A0 RID: 10656
		private static readonly IntPtr NativeFieldInfoPtr_mLanguages;

		// Token: 0x040029A1 RID: 10657
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreDeviceLanguage;

		// Token: 0x040029A2 RID: 10658
		private static readonly IntPtr NativeFieldInfoPtr__AllowUnloadingLanguages;

		// Token: 0x040029A3 RID: 10659
		private static readonly IntPtr NativeFieldInfoPtr_Google_WebServiceURL;

		// Token: 0x040029A4 RID: 10660
		private static readonly IntPtr NativeFieldInfoPtr_Google_SpreadsheetKey;

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeFieldInfoPtr_Google_SpreadsheetName;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeFieldInfoPtr_Google_LastUpdatedVersion;

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeFieldInfoPtr_GoogleUpdateFrequency;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeFieldInfoPtr_GoogleInEditorCheckFrequency;

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeFieldInfoPtr_GoogleUpdateSynchronization;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeFieldInfoPtr_GoogleUpdateDelay;

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle;

		// Token: 0x040029AC RID: 10668
		private static readonly IntPtr NativeFieldInfoPtr_Assets;

		// Token: 0x040029AD RID: 10669
		private static readonly IntPtr NativeFieldInfoPtr_mAssetDictionary;

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeFieldInfoPtr_mDelayedGoogleData;

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeFieldInfoPtr_EmptyCategory;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeFieldInfoPtr_CategorySeparators;

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeMethodInfoPtr_get_ownerObject_Public_get_Object_0;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr_add_Event_OnSourceUpdateFromGoogle_Public_add_Void_fnOnSourceUpdated_0;

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeMethodInfoPtr_remove_Event_OnSourceUpdateFromGoogle_Public_rem_Void_fnOnSourceUpdated_0;

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeMethodInfoPtr_IsEqualTo_Public_Boolean_LanguageSourceData_0;

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeMethodInfoPtr_ManagerHasASimilarSource_Internal_Boolean_0;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllData_Public_Void_0;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeMethodInfoPtr_IsGlobalSource_Public_Boolean_0;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeMethodInfoPtr_Editor_SetDirty_Public_Void_0;

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAssetDictionary_Public_Void_0;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeMethodInfoPtr_FindAsset_Public_Object_String_0;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeMethodInfoPtr_HasAsset_Public_Boolean_Object_0;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeMethodInfoPtr_AddAsset_Public_Void_Object_0;

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeMethodInfoPtr_Export_I2CSV_Public_String_String_Char_Boolean_0;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeMethodInfoPtr_AppendI2Term_Private_Static_Void_StringBuilder_Int32_String_TermData_Char_String_0;

		// Token: 0x040029C1 RID: 10689
		private static readonly IntPtr NativeMethodInfoPtr_AppendI2Text_Private_Static_Void_StringBuilder_String_0;

		// Token: 0x040029C2 RID: 10690
		private static readonly IntPtr NativeMethodInfoPtr_Export_Language_to_Cache_Private_String_Int32_Boolean_0;

		// Token: 0x040029C3 RID: 10691
		private static readonly IntPtr NativeMethodInfoPtr_Export_CSV_Public_String_String_Char_Boolean_0;

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeMethodInfoPtr_AppendTerm_Private_Static_Void_StringBuilder_Int32_String_TermData_String_Char_0;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeMethodInfoPtr_AppendString_Private_Static_Void_StringBuilder_String_Char_0;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeMethodInfoPtr_AppendTranslation_Private_Static_Void_StringBuilder_String_Char_String_0;

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeMethodInfoPtr_Export_Google_CreateWWWcall_Public_UnityWebRequest_eSpreadsheetUpdateMode_0;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeMethodInfoPtr_Export_Google_CreateData_Private_String_0;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeMethodInfoPtr_Import_CSV_Public_String_String_String_eSpreadsheetUpdateMode_Char_0;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeMethodInfoPtr_Import_I2CSV_Public_String_String_String_eSpreadsheetUpdateMode_0;

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeMethodInfoPtr_Import_CSV_Public_String_String_List_1_Il2CppStringArray_eSpreadsheetUpdateMode_0;

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeMethodInfoPtr_ArrayContains_Private_Boolean_String_Il2CppStringArray_0;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeMethodInfoPtr_GetTermType_Public_Static_eTermType_String_0;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeMethodInfoPtr_Import_Language_from_Cache_Private_Void_Int32_String_Boolean_Boolean_0;

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeMethodInfoPtr_FreeUnusedLanguages_Public_Static_Void_0;

		// Token: 0x040029D0 RID: 10704
		private static readonly IntPtr NativeMethodInfoPtr_Import_Google_FromCache_Public_Void_0;

		// Token: 0x040029D1 RID: 10705
		private static readonly IntPtr NativeMethodInfoPtr_IsNewerVersion_Private_Boolean_String_String_0;

		// Token: 0x040029D2 RID: 10706
		private static readonly IntPtr NativeMethodInfoPtr_Import_Google_Public_Void_Boolean_Boolean_0;

		// Token: 0x040029D3 RID: 10707
		private static readonly IntPtr NativeMethodInfoPtr_GetSourcePlayerPrefName_Private_String_0;

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeMethodInfoPtr_Import_Google_Coroutine_Private_IEnumerator_Boolean_0;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDownloadedDataOnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x040029D6 RID: 10710
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDownloadedDataFromGoogle_Public_Void_0;

		// Token: 0x040029D7 RID: 10711
		private static readonly IntPtr NativeMethodInfoPtr_Import_Google_CreateWWWcall_Public_UnityWebRequest_Boolean_Boolean_0;

		// Token: 0x040029D8 RID: 10712
		private static readonly IntPtr NativeMethodInfoPtr_HasGoogleSpreadsheet_Public_Boolean_0;

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeMethodInfoPtr_Import_Google_Result_Public_String_String_eSpreadsheetUpdateMode_Boolean_0;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageIndex_Public_Int32_String_Boolean_Boolean_0;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageData_Public_LanguageData_String_Boolean_0;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentLanguage_Public_Boolean_Int32_0;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageIndexFromCode_Public_Int32_String_Boolean_Boolean_0;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeMethodInfoPtr_GetCommonWordInLanguageNames_Public_Static_Int32_String_String_0;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeMethodInfoPtr_AreTheSameLanguage_Public_Static_Boolean_String_String_0;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguageWithoutRegion_Public_Static_String_String_0;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeMethodInfoPtr_AddLanguage_Public_Void_String_0;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeMethodInfoPtr_AddLanguage_Public_Void_String_String_0;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLanguage_Public_Void_String_0;

		// Token: 0x040029E4 RID: 10724
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguages_Public_List_1_String_Boolean_0;

		// Token: 0x040029E5 RID: 10725
		private static readonly IntPtr NativeMethodInfoPtr_GetLanguagesCode_Public_List_1_String_Boolean_Boolean_0;

		// Token: 0x040029E6 RID: 10726
		private static readonly IntPtr NativeMethodInfoPtr_IsLanguageEnabled_Public_Boolean_String_0;

		// Token: 0x040029E7 RID: 10727
		private static readonly IntPtr NativeMethodInfoPtr_EnableLanguage_Public_Void_String_Boolean_0;

		// Token: 0x040029E8 RID: 10728
		private static readonly IntPtr NativeMethodInfoPtr_AllowUnloadingLanguages_Public_Boolean_0;

		// Token: 0x040029E9 RID: 10729
		private static readonly IntPtr NativeMethodInfoPtr_GetSavedLanguageFileName_Private_String_Int32_0;

		// Token: 0x040029EA RID: 10730
		private static readonly IntPtr NativeMethodInfoPtr_LoadLanguage_Public_Void_Int32_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040029EB RID: 10731
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllLanguages_Public_Void_Boolean_0;

		// Token: 0x040029EC RID: 10732
		private static readonly IntPtr NativeMethodInfoPtr_UnloadLanguage_Public_Void_Int32_0;

		// Token: 0x040029ED RID: 10733
		private static readonly IntPtr NativeMethodInfoPtr_SaveLanguages_Public_Void_Boolean_eFileType_0;

		// Token: 0x040029EE RID: 10734
		private static readonly IntPtr NativeMethodInfoPtr_HasUnloadedLanguages_Public_Boolean_0;

		// Token: 0x040029EF RID: 10735
		private static readonly IntPtr NativeMethodInfoPtr_GetCategories_Public_List_1_String_Boolean_List_1_String_0;

		// Token: 0x040029F0 RID: 10736
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyFromFullTerm_Public_Static_String_String_Boolean_0;

		// Token: 0x040029F1 RID: 10737
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryFromFullTerm_Public_Static_String_String_Boolean_0;

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeFullTerm_Public_Static_Void_String_byref_String_byref_String_Boolean_0;

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDictionary_Public_Void_Boolean_0;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslation_Public_String_String_String_String_Boolean_Boolean_0;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTranslation_Public_Boolean_String_byref_String_String_String_Boolean_Boolean_0;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFallbackTranslation_Private_Boolean_TermData_byref_String_Int32_String_Boolean_0;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeMethodInfoPtr_AddTerm_Public_TermData_String_0;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeMethodInfoPtr_GetTermData_Public_TermData_String_Boolean_0;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeMethodInfoPtr_ContainsTerm_Public_Boolean_String_0;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeMethodInfoPtr_GetTermsList_Public_List_1_String_String_0;

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeMethodInfoPtr_AddTerm_Public_TermData_String_eTermType_Boolean_0;

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTerm_Public_Void_String_0;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFullTerm_Public_Static_Void_byref_String_0;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003BE RID: 958
		[OriginalName("Assembly-CSharp.dll", "", "MissingTranslationAction")]
		public enum MissingTranslationAction
		{
			// Token: 0x04003BA6 RID: 15270
			Empty,
			// Token: 0x04003BA7 RID: 15271
			Fallback,
			// Token: 0x04003BA8 RID: 15272
			ShowWarning,
			// Token: 0x04003BA9 RID: 15273
			ShowTerm
		}

		// Token: 0x020003BF RID: 959
		[OriginalName("Assembly-CSharp.dll", "", "eAllowUnloadLanguages")]
		public enum eAllowUnloadLanguages
		{
			// Token: 0x04003BAB RID: 15275
			Never,
			// Token: 0x04003BAC RID: 15276
			OnlyInDevice,
			// Token: 0x04003BAD RID: 15277
			EditorAndDevice
		}

		// Token: 0x020003C0 RID: 960
		[OriginalName("Assembly-CSharp.dll", "", "eGoogleUpdateFrequency")]
		public enum eGoogleUpdateFrequency
		{
			// Token: 0x04003BAF RID: 15279
			Always,
			// Token: 0x04003BB0 RID: 15280
			Never,
			// Token: 0x04003BB1 RID: 15281
			Daily,
			// Token: 0x04003BB2 RID: 15282
			Weekly,
			// Token: 0x04003BB3 RID: 15283
			Monthly,
			// Token: 0x04003BB4 RID: 15284
			OnlyOnce,
			// Token: 0x04003BB5 RID: 15285
			EveryOtherDay
		}

		// Token: 0x020003C1 RID: 961
		[OriginalName("Assembly-CSharp.dll", "", "eGoogleUpdateSynchronization")]
		public enum eGoogleUpdateSynchronization
		{
			// Token: 0x04003BB7 RID: 15287
			Manual,
			// Token: 0x04003BB8 RID: 15288
			OnSceneLoaded,
			// Token: 0x04003BB9 RID: 15289
			AsSoonAsDownloaded
		}

		// Token: 0x020003C2 RID: 962
		[ObfuscatedName("I2.Loc.LanguageSourceData+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060059DB RID: 23003 RVA: 0x00144E7C File Offset: 0x0014307C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr);
				LanguageSourceData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, "<>9");
				LanguageSourceData.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, "<>9__39_0");
				LanguageSourceData.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, "<>9__39_1");
				LanguageSourceData.__c.NativeFieldInfoPtr___9__39_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, "<>9__39_2");
				LanguageSourceData.__c.NativeFieldInfoPtr___9__39_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, "<>9__39_3");
				LanguageSourceData.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, "<>9__43_0");
				LanguageSourceData.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, "<>9__47_0");
				LanguageSourceData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, 100670022);
				LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_0_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, 100670023);
				LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_1_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, 100670024);
				LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_2_Internal_String_IGrouping_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, 100670025);
				LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_3_Internal_Object_IGrouping_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, 100670026);
				LanguageSourceData.__c.NativeMethodInfoPtr__Export_I2CSV_b__43_0_Internal_Int32_TermData_TermData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, 100670027);
				LanguageSourceData.__c.NativeMethodInfoPtr__Export_CSV_b__47_0_Internal_Int32_TermData_TermData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr, 100670028);
			}

			// Token: 0x060059DC RID: 23004 RVA: 0x00144FC0 File Offset: 0x001431C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageSourceData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059DD RID: 23005 RVA: 0x00144FFC File Offset: 0x001431FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108831, XrefRangeEnd = 108843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAssetDictionary_b__39_0(global::UnityEngine.Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_0_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060059DE RID: 23006 RVA: 0x0014504C File Offset: 0x0014324C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108843, XrefRangeEnd = 108845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UpdateAssetDictionary_b__39_1(global::UnityEngine.Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_1_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060059DF RID: 23007 RVA: 0x00145094 File Offset: 0x00143294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108845, XrefRangeEnd = 108849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UpdateAssetDictionary_b__39_2(IGrouping<string, global::UnityEngine.Object> g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_2_Internal_String_IGrouping_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060059E0 RID: 23008 RVA: 0x001450DC File Offset: 0x001432DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108849, XrefRangeEnd = 108852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::UnityEngine.Object _UpdateAssetDictionary_b__39_3(IGrouping<string, global::UnityEngine.Object> g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__39_3_Internal_Object_IGrouping_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059E1 RID: 23009 RVA: 0x0014512C File Offset: 0x0014332C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108852, XrefRangeEnd = 108853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Export_I2CSV_b__43_0(TermData a, TermData b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.__c.NativeMethodInfoPtr__Export_I2CSV_b__43_0_Internal_Int32_TermData_TermData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060059E2 RID: 23010 RVA: 0x0014518C File Offset: 0x0014338C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Export_CSV_b__47_0(TermData a, TermData b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData.__c.NativeMethodInfoPtr__Export_CSV_b__47_0_Internal_Int32_TermData_TermData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060059E3 RID: 23011 RVA: 0x000336F0 File Offset: 0x000318F0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020CA RID: 8394
			// (get) Token: 0x060059E4 RID: 23012 RVA: 0x001451EC File Offset: 0x001433EC
			// (set) Token: 0x060059E5 RID: 23013 RVA: 0x000336F9 File Offset: 0x000318F9
			public unsafe static LanguageSourceData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageSourceData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020CB RID: 8395
			// (get) Token: 0x060059E6 RID: 23014 RVA: 0x00145214 File Offset: 0x00143414
			// (set) Token: 0x060059E7 RID: 23015 RVA: 0x0003370B File Offset: 0x0003190B
			public unsafe static Predicate<global::UnityEngine.Object> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<global::UnityEngine.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020CC RID: 8396
			// (get) Token: 0x060059E8 RID: 23016 RVA: 0x0014523C File Offset: 0x0014343C
			// (set) Token: 0x060059E9 RID: 23017 RVA: 0x0003371D File Offset: 0x0003191D
			public unsafe static Func<global::UnityEngine.Object, string> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<global::UnityEngine.Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020CD RID: 8397
			// (get) Token: 0x060059EA RID: 23018 RVA: 0x00145264 File Offset: 0x00143464
			// (set) Token: 0x060059EB RID: 23019 RVA: 0x0003372F File Offset: 0x0003192F
			public unsafe static Func<IGrouping<string, global::UnityEngine.Object>, string> __9__39_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, global::UnityEngine.Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020CE RID: 8398
			// (get) Token: 0x060059EC RID: 23020 RVA: 0x0014528C File Offset: 0x0014348C
			// (set) Token: 0x060059ED RID: 23021 RVA: 0x00033741 File Offset: 0x00031941
			public unsafe static Func<IGrouping<string, global::UnityEngine.Object>, global::UnityEngine.Object> __9__39_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, global::UnityEngine.Object>, global::UnityEngine.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__39_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020CF RID: 8399
			// (get) Token: 0x060059EE RID: 23022 RVA: 0x001452B4 File Offset: 0x001434B4
			// (set) Token: 0x060059EF RID: 23023 RVA: 0x00033753 File Offset: 0x00031953
			public unsafe static Comparison<TermData> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TermData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020D0 RID: 8400
			// (get) Token: 0x060059F0 RID: 23024 RVA: 0x001452DC File Offset: 0x001434DC
			// (set) Token: 0x060059F1 RID: 23025 RVA: 0x00033765 File Offset: 0x00031965
			public unsafe static Comparison<TermData> __9__47_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TermData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LanguageSourceData.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BBA RID: 15290
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BBB RID: 15291
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x04003BBC RID: 15292
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x04003BBD RID: 15293
			private static readonly IntPtr NativeFieldInfoPtr___9__39_2;

			// Token: 0x04003BBE RID: 15294
			private static readonly IntPtr NativeFieldInfoPtr___9__39_3;

			// Token: 0x04003BBF RID: 15295
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04003BC0 RID: 15296
			private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

			// Token: 0x04003BC1 RID: 15297
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BC2 RID: 15298
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__39_0_Internal_Boolean_Object_0;

			// Token: 0x04003BC3 RID: 15299
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__39_1_Internal_String_Object_0;

			// Token: 0x04003BC4 RID: 15300
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__39_2_Internal_String_IGrouping_2_String_Object_0;

			// Token: 0x04003BC5 RID: 15301
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__39_3_Internal_Object_IGrouping_2_String_Object_0;

			// Token: 0x04003BC6 RID: 15302
			private static readonly IntPtr NativeMethodInfoPtr__Export_I2CSV_b__43_0_Internal_Int32_TermData_TermData_0;

			// Token: 0x04003BC7 RID: 15303
			private static readonly IntPtr NativeMethodInfoPtr__Export_CSV_b__47_0_Internal_Int32_TermData_TermData_0;
		}

		// Token: 0x020003C3 RID: 963
		[ObfuscatedName("I2.Loc.LanguageSourceData+<Import_Google_Coroutine>d__65")]
		public sealed class _Import_Google_Coroutine_d__65 : global::Il2CppSystem.Object
		{
			// Token: 0x060059F2 RID: 23026 RVA: 0x00145304 File Offset: 0x00143504
			// Note: this type is marked as 'beforefieldinit'.
			static _Import_Google_Coroutine_d__65()
			{
				Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageSourceData>.NativeClassPtr, "<Import_Google_Coroutine>d__65");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr);
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, "<>1__state");
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, "<>2__current");
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, "<>4__this");
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr_JustCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, "JustCheck");
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, "<www>5__2");
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, 100670029);
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, 100670030);
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, 100670031);
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, 100670032);
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, 100670033);
				LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr, 100670034);
			}

			// Token: 0x060059F3 RID: 23027 RVA: 0x0014540C File Offset: 0x0014360C
			[CallerCount(0)]
			public unsafe _Import_Google_Coroutine_d__65(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageSourceData._Import_Google_Coroutine_d__65>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059F4 RID: 23028 RVA: 0x00145454 File Offset: 0x00143654
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059F5 RID: 23029 RVA: 0x00145488 File Offset: 0x00143688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108853, XrefRangeEnd = 108862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170020D6 RID: 8406
			// (get) Token: 0x060059F6 RID: 23030 RVA: 0x001454C4 File Offset: 0x001436C4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059F7 RID: 23031 RVA: 0x00145504 File Offset: 0x00143704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108862, XrefRangeEnd = 108867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170020D7 RID: 8407
			// (get) Token: 0x060059F8 RID: 23032 RVA: 0x00145538 File Offset: 0x00143738
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceData._Import_Google_Coroutine_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059F9 RID: 23033 RVA: 0x00033777 File Offset: 0x00031977
			public _Import_Google_Coroutine_d__65(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020D1 RID: 8401
			// (get) Token: 0x060059FA RID: 23034 RVA: 0x00145578 File Offset: 0x00143778
			// (set) Token: 0x060059FB RID: 23035 RVA: 0x00033780 File Offset: 0x00031980
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170020D2 RID: 8402
			// (get) Token: 0x060059FC RID: 23036 RVA: 0x001455A0 File Offset: 0x001437A0
			// (set) Token: 0x060059FD RID: 23037 RVA: 0x0003379B File Offset: 0x0003199B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020D3 RID: 8403
			// (get) Token: 0x060059FE RID: 23038 RVA: 0x001455D0 File Offset: 0x001437D0
			// (set) Token: 0x060059FF RID: 23039 RVA: 0x000337BA File Offset: 0x000319BA
			public unsafe LanguageSourceData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020D4 RID: 8404
			// (get) Token: 0x06005A00 RID: 23040 RVA: 0x00145600 File Offset: 0x00143800
			// (set) Token: 0x06005A01 RID: 23041 RVA: 0x000337D9 File Offset: 0x000319D9
			public unsafe bool JustCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr_JustCheck);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr_JustCheck)) = value;
				}
			}

			// Token: 0x170020D5 RID: 8405
			// (get) Token: 0x06005A02 RID: 23042 RVA: 0x00145628 File Offset: 0x00143828
			// (set) Token: 0x06005A03 RID: 23043 RVA: 0x000337F4 File Offset: 0x000319F4
			public unsafe UnityWebRequest _www_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr__www_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceData._Import_Google_Coroutine_d__65.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BC8 RID: 15304
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003BC9 RID: 15305
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003BCA RID: 15306
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BCB RID: 15307
			private static readonly IntPtr NativeFieldInfoPtr_JustCheck;

			// Token: 0x04003BCC RID: 15308
			private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

			// Token: 0x04003BCD RID: 15309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003BCE RID: 15310
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BCF RID: 15311
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003BD0 RID: 15312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003BD1 RID: 15313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BD2 RID: 15314
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
