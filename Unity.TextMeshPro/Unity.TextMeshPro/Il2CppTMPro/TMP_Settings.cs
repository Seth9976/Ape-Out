using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200003B RID: 59
	[Serializable]
	public class TMP_Settings : ScriptableObject
	{
		// Token: 0x060005D3 RID: 1491 RVA: 0x0001E158 File Offset: 0x0001C358
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Settings()
		{
			Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr);
			TMP_Settings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "s_Instance");
			TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableWordWrapping");
			TMP_Settings.NativeFieldInfoPtr_m_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableKerning");
			TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableExtraPadding");
			TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableTintAllSprites");
			TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableParseEscapeCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_EnableRaycastTarget");
			TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_GetFontFeaturesAtRuntime");
			TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_missingGlyphCharacter");
			TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_warningsDisabled");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAsset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAssetPath");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontSize");
			TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMinRatio");
			TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMaxRatio");
			TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProTextContainerSize");
			TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProUITextContainerSize");
			TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_autoSizeTextContainer");
			TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_IsTextObjectScaleStatic");
			TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_fallbackFontAssets");
			TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_matchMaterialPreset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAsset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAssetPath");
			TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableEmojiSupport");
			TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_MissingCharacterSpriteUnicode");
			TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultColorGradientPresetsPath");
			TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultStyleSheet");
			TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_StyleSheetsResourcePath");
			TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_leadingCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_followingCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_linebreakingRules");
			TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_UseModernHangulLineBreakingRules");
			TMP_Settings.NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664026);
			TMP_Settings.NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664027);
			TMP_Settings.NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664028);
			TMP_Settings.NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664029);
			TMP_Settings.NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664030);
			TMP_Settings.NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664031);
			TMP_Settings.NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664032);
			TMP_Settings.NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664033);
			TMP_Settings.NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664034);
			TMP_Settings.NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664035);
			TMP_Settings.NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664036);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664037);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664038);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664039);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664040);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664041);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664042);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664043);
			TMP_Settings.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664044);
			TMP_Settings.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664045);
			TMP_Settings.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664046);
			TMP_Settings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664047);
			TMP_Settings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664048);
			TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664049);
			TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664050);
			TMP_Settings.NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664051);
			TMP_Settings.NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664052);
			TMP_Settings.NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664053);
			TMP_Settings.NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664054);
			TMP_Settings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664055);
			TMP_Settings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664056);
			TMP_Settings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664057);
			TMP_Settings.NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664058);
			TMP_Settings.NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664059);
			TMP_Settings.NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664060);
			TMP_Settings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664061);
			TMP_Settings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664062);
			TMP_Settings.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664063);
			TMP_Settings.NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664064);
			TMP_Settings.NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664065);
			TMP_Settings.NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664066);
			TMP_Settings.NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664067);
			TMP_Settings.NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664068);
			TMP_Settings.NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664069);
			TMP_Settings.NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664070);
			TMP_Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664071);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001E7A0 File Offset: 0x0001C9A0
		public unsafe static string version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458074, XrefRangeEnd = 458076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001E7CC File Offset: 0x0001C9CC
		public unsafe static bool enableWordWrapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458076, XrefRangeEnd = 458077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		public unsafe static bool enableKerning
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458077, XrefRangeEnd = 458078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001E82C File Offset: 0x0001CA2C
		public unsafe static bool enableExtraPadding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458078, XrefRangeEnd = 458079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0001E85C File Offset: 0x0001CA5C
		public unsafe static bool enableTintAllSprites
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458079, XrefRangeEnd = 458080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public unsafe static bool enableParseEscapeCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458080, XrefRangeEnd = 458081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001E8BC File Offset: 0x0001CABC
		public unsafe static bool enableRaycastTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458081, XrefRangeEnd = 458082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001E8EC File Offset: 0x0001CAEC
		public unsafe static bool getFontFeaturesAtRuntime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458082, XrefRangeEnd = 458083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001E91C File Offset: 0x0001CB1C
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0001E94C File Offset: 0x0001CB4C
		public unsafe static int missingGlyphCharacter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458083, XrefRangeEnd = 458084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458084, XrefRangeEnd = 458085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001E980 File Offset: 0x0001CB80
		public unsafe static bool warningsDisabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458085, XrefRangeEnd = 458086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		public unsafe static TMP_FontAsset defaultFontAsset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458086, XrefRangeEnd = 458087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		public unsafe static string defaultFontAssetPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458087, XrefRangeEnd = 458088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001EA10 File Offset: 0x0001CC10
		public unsafe static float defaultFontSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458088, XrefRangeEnd = 458089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001EA40 File Offset: 0x0001CC40
		public unsafe static float defaultTextAutoSizingMinRatio
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458089, XrefRangeEnd = 458090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001EA70 File Offset: 0x0001CC70
		public unsafe static float defaultTextAutoSizingMaxRatio
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458090, XrefRangeEnd = 458091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001EAA0 File Offset: 0x0001CCA0
		public unsafe static Vector2 defaultTextMeshProTextContainerSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458091, XrefRangeEnd = 458092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001EAD0 File Offset: 0x0001CCD0
		public unsafe static Vector2 defaultTextMeshProUITextContainerSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458092, XrefRangeEnd = 458093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0001EB00 File Offset: 0x0001CD00
		public unsafe static bool autoSizeTextContainer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458093, XrefRangeEnd = 458094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001EB30 File Offset: 0x0001CD30
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0001EB60 File Offset: 0x0001CD60
		public unsafe static bool isTextObjectScaleStatic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458094, XrefRangeEnd = 458095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458095, XrefRangeEnd = 458096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0001EB94 File Offset: 0x0001CD94
		public unsafe static List<TMP_FontAsset> fallbackFontAssets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458096, XrefRangeEnd = 458097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr3) : null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
		public unsafe static bool matchMaterialPreset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458097, XrefRangeEnd = 458098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001EBF8 File Offset: 0x0001CDF8
		public unsafe static TMP_SpriteAsset defaultSpriteAsset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458098, XrefRangeEnd = 458099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		public unsafe static string defaultSpriteAssetPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458099, XrefRangeEnd = 458100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001EC58 File Offset: 0x0001CE58
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0001EC88 File Offset: 0x0001CE88
		public unsafe static bool enableEmojiSupport
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458100, XrefRangeEnd = 458101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458101, XrefRangeEnd = 458102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001ECBC File Offset: 0x0001CEBC
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0001ECEC File Offset: 0x0001CEEC
		public unsafe static uint missingCharacterSpriteUnicode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458102, XrefRangeEnd = 458103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458103, XrefRangeEnd = 458104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001ED20 File Offset: 0x0001CF20
		public unsafe static string defaultColorGradientPresetsPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458104, XrefRangeEnd = 458105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0001ED4C File Offset: 0x0001CF4C
		public unsafe static TMP_StyleSheet defaultStyleSheet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458105, XrefRangeEnd = 458106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001ED80 File Offset: 0x0001CF80
		public unsafe static string styleSheetsResourcePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458106, XrefRangeEnd = 458107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001EDAC File Offset: 0x0001CFAC
		public unsafe static TextAsset leadingCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458107, XrefRangeEnd = 458108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		public unsafe static TextAsset followingCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458108, XrefRangeEnd = 458109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001EE14 File Offset: 0x0001D014
		public unsafe static TMP_Settings.LineBreakingTable linebreakingRules
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 458112, RefRangeEnd = 458115, XrefRangeStart = 458109, XrefRangeEnd = 458112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings.LineBreakingTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001EE48 File Offset: 0x0001D048
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0001EE78 File Offset: 0x0001D078
		public unsafe static bool useModernHangulLineBreakingRules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 458116, RefRangeEnd = 458117, XrefRangeStart = 458115, XrefRangeEnd = 458116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458117, XrefRangeEnd = 458118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		public unsafe static TMP_Settings instance
		{
			[CallerCount(118)]
			[CachedScanResults(RefRangeStart = 458139, RefRangeEnd = 458257, XrefRangeStart = 458118, XrefRangeEnd = 458139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458257, XrefRangeEnd = 458290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings LoadDefaultSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0001EF14 File Offset: 0x0001D114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458290, XrefRangeEnd = 458304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings GetSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0001EF48 File Offset: 0x0001D148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458304, XrefRangeEnd = 458318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset GetFontAsset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001EF7C File Offset: 0x0001D17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458318, XrefRangeEnd = 458332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset GetSpriteAsset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458332, XrefRangeEnd = 458346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_StyleSheet GetStyleSheet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 458368, RefRangeEnd = 458369, XrefRangeStart = 458346, XrefRangeEnd = 458368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadLinebreakingRules()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001F00C File Offset: 0x0001D20C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 458382, RefRangeEnd = 458384, XrefRangeStart = 458369, XrefRangeEnd = 458382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, char> GetCharacters(TextAsset file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001F050 File Offset: 0x0001D250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458384, XrefRangeEnd = 458385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00004A32 File Offset: 0x00002C32
		public TMP_Settings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001F08C File Offset: 0x0001D28C
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00004A3B File Offset: 0x00002C3B
		public unsafe static TMP_Settings s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Settings.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Settings.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001F0B4 File Offset: 0x0001D2B4
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00004A4D File Offset: 0x00002C4D
		public unsafe bool m_enableWordWrapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001F0DC File Offset: 0x0001D2DC
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00004A68 File Offset: 0x00002C68
		public unsafe bool m_enableKerning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableKerning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableKerning)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0001F104 File Offset: 0x0001D304
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00004A83 File Offset: 0x00002C83
		public unsafe bool m_enableExtraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001F12C File Offset: 0x0001D32C
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00004A9E File Offset: 0x00002C9E
		public unsafe bool m_enableTintAllSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites)) = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0001F154 File Offset: 0x0001D354
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00004AB9 File Offset: 0x00002CB9
		public unsafe bool m_enableParseEscapeCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters)) = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0001F17C File Offset: 0x0001D37C
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00004AD4 File Offset: 0x00002CD4
		public unsafe bool m_EnableRaycastTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget)) = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00004AEF File Offset: 0x00002CEF
		public unsafe bool m_GetFontFeaturesAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001F1CC File Offset: 0x0001D3CC
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00004B0A File Offset: 0x00002D0A
		public unsafe int m_missingGlyphCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter)) = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00004B25 File Offset: 0x00002D25
		public unsafe bool m_warningsDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001F21C File Offset: 0x0001D41C
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00004B40 File Offset: 0x00002D40
		public unsafe TMP_FontAsset m_defaultFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001F24C File Offset: 0x0001D44C
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00004B5F File Offset: 0x00002D5F
		public unsafe string m_defaultFontAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001F274 File Offset: 0x0001D474
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00004B7E File Offset: 0x00002D7E
		public unsafe float m_defaultFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001F29C File Offset: 0x0001D49C
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00004B99 File Offset: 0x00002D99
		public unsafe float m_defaultAutoSizeMinRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public unsafe float m_defaultAutoSizeMaxRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio)) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00004BCF File Offset: 0x00002DCF
		public unsafe Vector2 m_defaultTextMeshProTextContainerSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize)) = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001F314 File Offset: 0x0001D514
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00004BEA File Offset: 0x00002DEA
		public unsafe Vector2 m_defaultTextMeshProUITextContainerSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001F33C File Offset: 0x0001D53C
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00004C05 File Offset: 0x00002E05
		public unsafe bool m_autoSizeTextContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001F364 File Offset: 0x0001D564
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00004C20 File Offset: 0x00002E20
		public unsafe bool m_IsTextObjectScaleStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic)) = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001F38C File Offset: 0x0001D58C
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00004C3B File Offset: 0x00002E3B
		public unsafe List<TMP_FontAsset> m_fallbackFontAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00004C5A File Offset: 0x00002E5A
		public unsafe bool m_matchMaterialPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset)) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001F3E4 File Offset: 0x0001D5E4
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00004C75 File Offset: 0x00002E75
		public unsafe TMP_SpriteAsset m_defaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001F414 File Offset: 0x0001D614
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00004C94 File Offset: 0x00002E94
		public unsafe string m_defaultSpriteAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001F43C File Offset: 0x0001D63C
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00004CB3 File Offset: 0x00002EB3
		public unsafe bool m_enableEmojiSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001F464 File Offset: 0x0001D664
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00004CCE File Offset: 0x00002ECE
		public unsafe uint m_MissingCharacterSpriteUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode)) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001F48C File Offset: 0x0001D68C
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00004CE9 File Offset: 0x00002EE9
		public unsafe string m_defaultColorGradientPresetsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00004D08 File Offset: 0x00002F08
		public unsafe TMP_StyleSheet m_defaultStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00004D27 File Offset: 0x00002F27
		public unsafe string m_StyleSheetsResourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0001F50C File Offset: 0x0001D70C
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00004D46 File Offset: 0x00002F46
		public unsafe TextAsset m_leadingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0001F53C File Offset: 0x0001D73C
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00004D65 File Offset: 0x00002F65
		public unsafe TextAsset m_followingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_followingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_followingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001F56C File Offset: 0x0001D76C
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00004D84 File Offset: 0x00002F84
		public unsafe TMP_Settings.LineBreakingTable m_linebreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings.LineBreakingTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001F59C File Offset: 0x0001D79C
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00004DA3 File Offset: 0x00002FA3
		public unsafe bool m_UseModernHangulLineBreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules)) = value;
			}
		}

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr_m_enableWordWrapping;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_m_enableKerning;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr_m_enableExtraPadding;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_m_enableTintAllSprites;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_m_enableParseEscapeCharacters;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableRaycastTarget;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_m_missingGlyphCharacter;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_m_warningsDisabled;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontAsset;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontAssetPath;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontSize;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMinRatio;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_m_autoSizeTextContainer;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextObjectScaleStatic;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackFontAssets;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_m_matchMaterialPreset;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAsset;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAssetPath;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_m_enableEmojiSupport;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultColorGradientPresetsPath;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultStyleSheet;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheetsResourcePath;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_m_leadingCharacters;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_m_followingCharacters;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_m_linebreakingRules;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A1 RID: 161
		public class LineBreakingTable : global::Il2CppSystem.Object
		{
			// Token: 0x06000F95 RID: 3989 RVA: 0x0003DE58 File Offset: 0x0003C058
			// Note: this type is marked as 'beforefieldinit'.
			static LineBreakingTable()
			{
				Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "LineBreakingTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr);
				TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, "leadingCharacters");
				TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, "followingCharacters");
				TMP_Settings.LineBreakingTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, 100664072);
			}

			// Token: 0x06000F96 RID: 3990 RVA: 0x0003DEC0 File Offset: 0x0003C0C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LineBreakingTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.LineBreakingTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F97 RID: 3991 RVA: 0x00009694 File Offset: 0x00007894
			public LineBreakingTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0003DEFC File Offset: 0x0003C0FC
			// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0000969D File Offset: 0x0000789D
			public unsafe Dictionary<int, char> leadingCharacters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0003DF2C File Offset: 0x0003C12C
			// (set) Token: 0x06000F9B RID: 3995 RVA: 0x000096BC File Offset: 0x000078BC
			public unsafe Dictionary<int, char> followingCharacters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C44 RID: 3140
			private static readonly IntPtr NativeFieldInfoPtr_leadingCharacters;

			// Token: 0x04000C45 RID: 3141
			private static readonly IntPtr NativeFieldInfoPtr_followingCharacters;

			// Token: 0x04000C46 RID: 3142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
