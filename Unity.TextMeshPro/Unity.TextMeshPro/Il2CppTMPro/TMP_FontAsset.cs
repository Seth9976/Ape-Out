using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class TMP_FontAsset : TMP_Asset
	{
		// Token: 0x060001CF RID: 463 RVA: 0x00010184 File Offset: 0x0000E384
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontAsset()
		{
			Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr);
			TMP_FontAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_Version");
			TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_SourceFontFileGUID");
			TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_SourceFontFile");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasPopulationMode");
			TMP_FontAsset.NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FaceInfo");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphLookupDictionary");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharacterTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharacterLookupDictionary");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTexture");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTextures");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTextureIndex");
			TMP_FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_IsMultiAtlasTexturesEnabled");
			TMP_FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_ClearDynamicDataOnBuild");
			TMP_FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_UsedGlyphRects");
			TMP_FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FreeGlyphRects");
			TMP_FontAsset.NativeFieldInfoPtr_m_fontInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_fontInfo");
			TMP_FontAsset.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "atlas");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasWidth");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasHeight");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasPadding");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasRenderMode");
			TMP_FontAsset.NativeFieldInfoPtr_m_glyphInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_glyphInfoList");
			TMP_FontAsset.NativeFieldInfoPtr_m_KerningTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_KerningTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_FontFeatureTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FontFeatureTable");
			TMP_FontAsset.NativeFieldInfoPtr_fallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "fallbackFontAssets");
			TMP_FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FallbackFontAssetTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_CreationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CreationSettings");
			TMP_FontAsset.NativeFieldInfoPtr_m_FontWeightTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FontWeightTable");
			TMP_FontAsset.NativeFieldInfoPtr_fontWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "fontWeights");
			TMP_FontAsset.NativeFieldInfoPtr_normalStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "normalStyle");
			TMP_FontAsset.NativeFieldInfoPtr_normalSpacingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "normalSpacingOffset");
			TMP_FontAsset.NativeFieldInfoPtr_boldStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "boldStyle");
			TMP_FontAsset.NativeFieldInfoPtr_boldSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "boldSpacing");
			TMP_FontAsset.NativeFieldInfoPtr_italicStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "italicStyle");
			TMP_FontAsset.NativeFieldInfoPtr_tabSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "tabSize");
			TMP_FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "IsFontAssetLookupTablesDirty");
			TMP_FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_ReadFontAssetDefinitionMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_AddSynthesizedCharactersMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_TryAddCharacterMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_TryAddCharactersMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateGlyphAdjustmentRecordsMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_ClearFontAssetDataMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateFontAssetDataMarker");
			TMP_FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "s_DefaultMaterialSuffix");
			TMP_FontAsset.NativeFieldInfoPtr_FallbackSearchQueryLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "FallbackSearchQueryLookup");
			TMP_FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_SearchedFontAssetLookup");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueue");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueueLookup");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueue");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueueLookup");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToRender");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsRendered");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphIndexList");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphIndexListNewlyAdded");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToAdd");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToAddLookup");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharactersToAdd");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharactersToAddLookup");
			TMP_FontAsset.NativeFieldInfoPtr_s_MissingCharacterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "s_MissingCharacterList");
			TMP_FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_MissingUnicodesFromFontFile");
			TMP_FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_GlyphIndexArray");
			TMP_FontAsset.NativeMethodInfoPtr_get_version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663522);
			TMP_FontAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663523);
			TMP_FontAsset.NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663524);
			TMP_FontAsset.NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663525);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663526);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663527);
			TMP_FontAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663528);
			TMP_FontAsset.NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663529);
			TMP_FontAsset.NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663530);
			TMP_FontAsset.NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663531);
			TMP_FontAsset.NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663532);
			TMP_FontAsset.NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663533);
			TMP_FontAsset.NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663534);
			TMP_FontAsset.NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663535);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663536);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663537);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663538);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663539);
			TMP_FontAsset.NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663540);
			TMP_FontAsset.NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663541);
			TMP_FontAsset.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663542);
			TMP_FontAsset.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663543);
			TMP_FontAsset.NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663544);
			TMP_FontAsset.NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663545);
			TMP_FontAsset.NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663546);
			TMP_FontAsset.NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663547);
			TMP_FontAsset.NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663548);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663549);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663550);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663551);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663552);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663553);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663554);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663555);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663556);
			TMP_FontAsset.NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663557);
			TMP_FontAsset.NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663558);
			TMP_FontAsset.NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663559);
			TMP_FontAsset.NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663560);
			TMP_FontAsset.NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663561);
			TMP_FontAsset.NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663562);
			TMP_FontAsset.NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663563);
			TMP_FontAsset.NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663564);
			TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663565);
			TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663566);
			TMP_FontAsset.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663567);
			TMP_FontAsset.NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663568);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663569);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663570);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663571);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663572);
			TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663573);
			TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663574);
			TMP_FontAsset.NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663575);
			TMP_FontAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663576);
			TMP_FontAsset.NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663577);
			TMP_FontAsset.NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663578);
			TMP_FontAsset.NativeMethodInfoPtr_SortAllTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663579);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663580);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663581);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663582);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663583);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663584);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663585);
			TMP_FontAsset.NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663586);
			TMP_FontAsset.NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663587);
			TMP_FontAsset.NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663588);
			TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663589);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663590);
			TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForAtlasTextureUpdate_Internal_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663591);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexturesForFontAssetsInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663592);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663593);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663594);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663595);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663596);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663597);
			TMP_FontAsset.NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663598);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663599);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663600);
			TMP_FontAsset.NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663601);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663602);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663603);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663604);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663605);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663606);
			TMP_FontAsset.NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663607);
			TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663608);
			TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663609);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663610);
			TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663611);
			TMP_FontAsset.NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663612);
			TMP_FontAsset.NativeMethodInfoPtr_UpgradeFontAsset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663613);
			TMP_FontAsset.NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663614);
			TMP_FontAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663615);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00010E1C File Offset: 0x0000F01C
		public unsafe string version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00010E60 File Offset: 0x0000F060
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		public unsafe Font sourceFontFile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00010EE4 File Offset: 0x0000F0E4
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00010F20 File Offset: 0x0000F120
		public unsafe AtlasPopulationMode atlasPopulationMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00010F60 File Offset: 0x0000F160
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00010F98 File Offset: 0x0000F198
		public unsafe FaceInfo faceInfo
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 452073, RefRangeEnd = 452078, XrefRangeStart = 452073, XrefRangeEnd = 452073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FaceInfo(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00011020 File Offset: 0x0000F220
		public unsafe List<Glyph> glyphTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 426723, RefRangeEnd = 426724, XrefRangeStart = 426723, XrefRangeEnd = 426724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00011064 File Offset: 0x0000F264
		public unsafe Dictionary<uint, Glyph> glyphLookupTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452078, XrefRangeEnd = 452079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr3) : null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000110A4 File Offset: 0x0000F2A4
		// (set) Token: 0x060001DC RID: 476 RVA: 0x000110E4 File Offset: 0x0000F2E4
		public unsafe List<TMP_Character> characterTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 386301, RefRangeEnd = 386305, XrefRangeStart = 386301, XrefRangeEnd = 386305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00011128 File Offset: 0x0000F328
		public unsafe Dictionary<uint, TMP_Character> characterLookupTable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 452080, RefRangeEnd = 452084, XrefRangeStart = 452079, XrefRangeEnd = 452080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_Character>>(intPtr3) : null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00011168 File Offset: 0x0000F368
		public unsafe Texture2D atlasTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 452096, RefRangeEnd = 452098, XrefRangeStart = 452084, XrefRangeEnd = 452096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000111A8 File Offset: 0x0000F3A8
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000111E8 File Offset: 0x0000F3E8
		public unsafe Il2CppReferenceArray<Texture2D> atlasTextures
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 429503, RefRangeEnd = 429504, XrefRangeStart = 429503, XrefRangeEnd = 429504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001122C File Offset: 0x0000F42C
		public unsafe int atlasTextureCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00011268 File Offset: 0x0000F468
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x000112A4 File Offset: 0x0000F4A4
		public unsafe bool isMultiAtlasTexturesEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000112E4 File Offset: 0x0000F4E4
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00011320 File Offset: 0x0000F520
		public unsafe bool clearDynamicDataOnBuild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00011360 File Offset: 0x0000F560
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000113A0 File Offset: 0x0000F5A0
		public unsafe List<GlyphRect> usedGlyphRects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 92148, RefRangeEnd = 92153, XrefRangeStart = 92148, XrefRangeEnd = 92153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000113E4 File Offset: 0x0000F5E4
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00011424 File Offset: 0x0000F624
		public unsafe List<GlyphRect> freeGlyphRects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00011468 File Offset: 0x0000F668
		public unsafe FaceInfo_Legacy fontInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FaceInfo_Legacy>(intPtr3) : null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x060001EC RID: 492 RVA: 0x000114E4 File Offset: 0x0000F6E4
		public unsafe int atlasWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00011524 File Offset: 0x0000F724
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00011560 File Offset: 0x0000F760
		public unsafe int atlasHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000115A0 File Offset: 0x0000F7A0
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x000115DC File Offset: 0x0000F7DC
		public unsafe int atlasPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0001161C File Offset: 0x0000F81C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00011658 File Offset: 0x0000F858
		public unsafe GlyphRenderMode atlasRenderMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00011698 File Offset: 0x0000F898
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000116D8 File Offset: 0x0000F8D8
		public unsafe TMP_FontFeatureTable fontFeatureTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001171C File Offset: 0x0000F91C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0001175C File Offset: 0x0000F95C
		public unsafe List<TMP_FontAsset> fallbackFontAssetTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000117A0 File Offset: 0x0000F9A0
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000117D8 File Offset: 0x0000F9D8
		public unsafe FontAssetCreationSettings creationSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontAssetCreationSettings(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00011820 File Offset: 0x0000FA20
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00011860 File Offset: 0x0000FA60
		public unsafe Il2CppReferenceArray<TMP_FontWeightPair> fontWeightTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000118A4 File Offset: 0x0000FAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452098, XrefRangeEnd = 452102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset CreateFontAsset(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000118E8 File Offset: 0x0000FAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452187, RefRangeEnd = 452188, XrefRangeStart = 452102, XrefRangeEnd = 452187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingPointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPadding;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPopulationMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMultiAtlasSupport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00011990 File Offset: 0x0000FB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452188, XrefRangeEnd = 452201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000119C4 File Offset: 0x0000FBC4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 452240, RefRangeEnd = 452263, XrefRangeStart = 452201, XrefRangeEnd = 452240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadFontAssetDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000119F8 File Offset: 0x0000FBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452263, XrefRangeEnd = 452266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDictionaryLookupTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00011A2C File Offset: 0x0000FC2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452296, RefRangeEnd = 452298, XrefRangeStart = 452266, XrefRangeEnd = 452296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeGlyphLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00011A60 File Offset: 0x0000FC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452324, RefRangeEnd = 452326, XrefRangeStart = 452298, XrefRangeEnd = 452324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCharacterLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00011A94 File Offset: 0x0000FC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452344, RefRangeEnd = 452346, XrefRangeStart = 452326, XrefRangeEnd = 452344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452375, RefRangeEnd = 452376, XrefRangeStart = 452346, XrefRangeEnd = 452375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSynthesizedCharactersAndFaceMetrics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00011AFC File Offset: 0x0000FCFC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 452396, RefRangeEnd = 452408, XrefRangeStart = 452376, XrefRangeEnd = 452396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFontFaceLoaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addImmediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00011B58 File Offset: 0x0000FD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452408, XrefRangeEnd = 452414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCharacterToLookupCache(uint unicode, TMP_Character character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(character);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452436, RefRangeEnd = 452437, XrefRangeStart = 452414, XrefRangeEnd = 452436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCharacterTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00011BDC File Offset: 0x0000FDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452459, RefRangeEnd = 452460, XrefRangeStart = 452437, XrefRangeEnd = 452459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00011C10 File Offset: 0x0000FE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452460, XrefRangeEnd = 452462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortFontFeatureTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00011C44 File Offset: 0x0000FE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452462, XrefRangeEnd = 452466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortAllTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortAllTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00011C78 File Offset: 0x0000FE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452466, XrefRangeEnd = 452468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(int character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00011CC4 File Offset: 0x0000FEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452468, XrefRangeEnd = 452560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00011D2C File Offset: 0x0000FF2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 452588, RefRangeEnd = 452595, XrefRangeStart = 452560, XrefRangeEnd = 452588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00011D94 File Offset: 0x0000FF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452595, XrefRangeEnd = 452607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text, out List<char> missingCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingCharacters = ((intPtr4 == 0) ? null : new List<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00011E04 File Offset: 0x00010004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452607, XrefRangeEnd = 452705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text, out Il2CppStructArray<uint> missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingCharacters = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00011E90 File Offset: 0x00010090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452705, XrefRangeEnd = 452709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00011EE0 File Offset: 0x000100E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452709, XrefRangeEnd = 452730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCharacters(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00011F1C File Offset: 0x0001011C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452730, XrefRangeEnd = 452736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetCharactersArray(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00011F60 File Offset: 0x00010160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452736, XrefRangeEnd = 452747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetGlyphIndex(uint unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00011FAC File Offset: 0x000101AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452747, XrefRangeEnd = 452760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00011FE4 File Offset: 0x000101E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452777, RefRangeEnd = 452779, XrefRangeStart = 452760, XrefRangeEnd = 452777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateFontFeaturesForFontAssetsInQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001200C File Offset: 0x0001020C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452779, XrefRangeEnd = 452792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForAtlasTextureUpdate_Internal_Static_Void_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00012044 File Offset: 0x00010244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452792, XrefRangeEnd = 452807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAtlasTexturesForFontAssetsInQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexturesForFontAssetsInQueue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001206C File Offset: 0x0001026C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452807, XrefRangeEnd = 452808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000120C8 File Offset: 0x000102C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452901, RefRangeEnd = 452903, XrefRangeStart = 452808, XrefRangeEnd = 452901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, out Il2CppStructArray<uint> missingUnicodes, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingUnicodes = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00012148 File Offset: 0x00010348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452903, XrefRangeEnd = 452904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(string characters, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000121A4 File Offset: 0x000103A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452998, RefRangeEnd = 452999, XrefRangeStart = 452904, XrefRangeEnd = 452998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			missingCharacters = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001221C File Offset: 0x0001041C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 453031, RefRangeEnd = 453036, XrefRangeStart = 452999, XrefRangeEnd = 453031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacterInternal(uint unicode, out TMP_Character character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00012288 File Offset: 0x00010488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453036, XrefRangeEnd = 453063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000122F4 File Offset: 0x000104F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAddGlyphsToAtlasTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00012328 File Offset: 0x00010528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 453096, RefRangeEnd = 453098, XrefRangeStart = 453063, XrefRangeEnd = 453096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddGlyphsToNewAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00012364 File Offset: 0x00010564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453118, RefRangeEnd = 453119, XrefRangeStart = 453098, XrefRangeEnd = 453118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupNewAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00012398 File Offset: 0x00010598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453119, XrefRangeEnd = 453127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000123CC File Offset: 0x000105CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 453150, RefRangeEnd = 453153, XrefRangeStart = 453127, XrefRangeEnd = 453150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00012400 File Offset: 0x00010600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453153, XrefRangeEnd = 453189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00012444 File Offset: 0x00010644
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00012488 File Offset: 0x00010688
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newGlyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allGlyphIndexes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000124DC File Offset: 0x000106DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453189, XrefRangeEnd = 453192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyListDataToArray<T>(List<T> srcList, ref Il2CppArrayBase<T> dstArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcList);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dstArray);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dstArray = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00012548 File Offset: 0x00010748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453192, XrefRangeEnd = 453195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetData(bool setAtlasSizeToZero = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setAtlasSizeToZero;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00012588 File Offset: 0x00010788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453195, XrefRangeEnd = 453197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetDataInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000125BC File Offset: 0x000107BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453197, XrefRangeEnd = 453207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFontAssetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000125F0 File Offset: 0x000107F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 453220, RefRangeEnd = 453223, XrefRangeStart = 453207, XrefRangeEnd = 453220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00012624 File Offset: 0x00010824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 453257, RefRangeEnd = 453260, XrefRangeStart = 453223, XrefRangeEnd = 453257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAtlasTextures(bool setAtlasSizeToZero = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setAtlasSizeToZero;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00012664 File Offset: 0x00010864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 453408, RefRangeEnd = 453410, XrefRangeStart = 453260, XrefRangeEnd = 453408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpgradeFontAsset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00012698 File Offset: 0x00010898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453443, RefRangeEnd = 453444, XrefRangeStart = 453410, XrefRangeEnd = 453443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeGlyphAdjustmentTableToFontFeatureTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000126CC File Offset: 0x000108CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453444, XrefRangeEnd = 453577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002E1D File Offset: 0x0000101D
		public TMP_FontAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00012708 File Offset: 0x00010908
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002E26 File Offset: 0x00001026
		public unsafe string m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_Version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_Version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00012730 File Offset: 0x00010930
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002E45 File Offset: 0x00001045
		public unsafe string m_SourceFontFileGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00012758 File Offset: 0x00010958
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002E64 File Offset: 0x00001064
		public unsafe Font m_SourceFontFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00012788 File Offset: 0x00010988
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002E83 File Offset: 0x00001083
		public unsafe AtlasPopulationMode m_AtlasPopulationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000127B0 File Offset: 0x000109B0
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002E9E File Offset: 0x0000109E
		public FaceInfo m_FaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FaceInfo);
				return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000127E0 File Offset: 0x000109E0
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002ECC File Offset: 0x000010CC
		public unsafe List<Glyph> m_GlyphTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00012810 File Offset: 0x00010A10
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002EEB File Offset: 0x000010EB
		public unsafe Dictionary<uint, Glyph> m_GlyphLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00012840 File Offset: 0x00010A40
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002F0A File Offset: 0x0000110A
		public unsafe List<TMP_Character> m_CharacterTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00012870 File Offset: 0x00010A70
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002F29 File Offset: 0x00001129
		public unsafe Dictionary<uint, TMP_Character> m_CharacterLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000128A0 File Offset: 0x00010AA0
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002F48 File Offset: 0x00001148
		public unsafe Texture2D m_AtlasTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000128D0 File Offset: 0x00010AD0
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002F67 File Offset: 0x00001167
		public unsafe Il2CppReferenceArray<Texture2D> m_AtlasTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00012900 File Offset: 0x00010B00
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002F86 File Offset: 0x00001186
		public unsafe int m_AtlasTextureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00012928 File Offset: 0x00010B28
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002FA1 File Offset: 0x000011A1
		public unsafe bool m_IsMultiAtlasTexturesEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00012950 File Offset: 0x00010B50
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002FBC File Offset: 0x000011BC
		public unsafe bool m_ClearDynamicDataOnBuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00012978 File Offset: 0x00010B78
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002FD7 File Offset: 0x000011D7
		public unsafe List<GlyphRect> m_UsedGlyphRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000129A8 File Offset: 0x00010BA8
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002FF6 File Offset: 0x000011F6
		public unsafe List<GlyphRect> m_FreeGlyphRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000129D8 File Offset: 0x00010BD8
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00003015 File Offset: 0x00001215
		public unsafe FaceInfo_Legacy m_fontInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_fontInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FaceInfo_Legacy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_fontInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00012A08 File Offset: 0x00010C08
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00003034 File Offset: 0x00001234
		public unsafe Texture2D atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00012A38 File Offset: 0x00010C38
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00003053 File Offset: 0x00001253
		public unsafe int m_AtlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasWidth)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00012A60 File Offset: 0x00010C60
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000306E File Offset: 0x0000126E
		public unsafe int m_AtlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasHeight)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00012A88 File Offset: 0x00010C88
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00003089 File Offset: 0x00001289
		public unsafe int m_AtlasPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPadding)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00012AB0 File Offset: 0x00010CB0
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000030A4 File Offset: 0x000012A4
		public unsafe GlyphRenderMode m_AtlasRenderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00012AD8 File Offset: 0x00010CD8
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000030BF File Offset: 0x000012BF
		public unsafe List<TMP_Glyph> m_glyphInfoList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_glyphInfoList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_glyphInfoList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00012B08 File Offset: 0x00010D08
		// (set) Token: 0x0600025E RID: 606 RVA: 0x000030DE File Offset: 0x000012DE
		public unsafe KerningTable m_KerningTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_KerningTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_KerningTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00012B38 File Offset: 0x00010D38
		// (set) Token: 0x06000260 RID: 608 RVA: 0x000030FD File Offset: 0x000012FD
		public unsafe TMP_FontFeatureTable m_FontFeatureTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontFeatureTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontFeatureTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00012B68 File Offset: 0x00010D68
		// (set) Token: 0x06000262 RID: 610 RVA: 0x0000311C File Offset: 0x0000131C
		public unsafe List<TMP_FontAsset> fallbackFontAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fallbackFontAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fallbackFontAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00012B98 File Offset: 0x00010D98
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0000313B File Offset: 0x0000133B
		public unsafe List<TMP_FontAsset> m_FallbackFontAssetTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00012BC8 File Offset: 0x00010DC8
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0000315A File Offset: 0x0000135A
		public FontAssetCreationSettings m_CreationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CreationSettings);
				return new FontAssetCreationSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CreationSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00012BF8 File Offset: 0x00010DF8
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00003188 File Offset: 0x00001388
		public unsafe Il2CppReferenceArray<TMP_FontWeightPair> m_FontWeightTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontWeightTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontWeightTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00012C28 File Offset: 0x00010E28
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000031A7 File Offset: 0x000013A7
		public unsafe Il2CppReferenceArray<TMP_FontWeightPair> fontWeights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fontWeights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fontWeights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00012C58 File Offset: 0x00010E58
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000031C6 File Offset: 0x000013C6
		public unsafe float normalStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalStyle)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00012C80 File Offset: 0x00010E80
		// (set) Token: 0x0600026E RID: 622 RVA: 0x000031E1 File Offset: 0x000013E1
		public unsafe float normalSpacingOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalSpacingOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalSpacingOffset)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00012CA8 File Offset: 0x00010EA8
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000031FC File Offset: 0x000013FC
		public unsafe float boldStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldStyle)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00012CD0 File Offset: 0x00010ED0
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00003217 File Offset: 0x00001417
		public unsafe float boldSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldSpacing)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00012CF8 File Offset: 0x00010EF8
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00003232 File Offset: 0x00001432
		public unsafe byte italicStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_italicStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_italicStyle)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00012D20 File Offset: 0x00010F20
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000324D File Offset: 0x0000144D
		public unsafe byte tabSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_tabSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_tabSize)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00012D48 File Offset: 0x00010F48
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003268 File Offset: 0x00001468
		public unsafe bool IsFontAssetLookupTablesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00012D70 File Offset: 0x00010F70
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00003283 File Offset: 0x00001483
		public unsafe static ProfilerMarker k_ReadFontAssetDefinitionMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00012D8C File Offset: 0x00010F8C
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00003291 File Offset: 0x00001491
		public unsafe static ProfilerMarker k_AddSynthesizedCharactersMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00012DA8 File Offset: 0x00010FA8
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0000329F File Offset: 0x0000149F
		public unsafe static ProfilerMarker k_TryAddCharacterMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00012DC4 File Offset: 0x00010FC4
		// (set) Token: 0x06000280 RID: 640 RVA: 0x000032AD File Offset: 0x000014AD
		public unsafe static ProfilerMarker k_TryAddCharactersMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00012DE0 File Offset: 0x00010FE0
		// (set) Token: 0x06000282 RID: 642 RVA: 0x000032BB File Offset: 0x000014BB
		public unsafe static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00012DFC File Offset: 0x00010FFC
		// (set) Token: 0x06000284 RID: 644 RVA: 0x000032C9 File Offset: 0x000014C9
		public unsafe static ProfilerMarker k_ClearFontAssetDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00012E18 File Offset: 0x00011018
		// (set) Token: 0x06000286 RID: 646 RVA: 0x000032D7 File Offset: 0x000014D7
		public unsafe static ProfilerMarker k_UpdateFontAssetDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00012E34 File Offset: 0x00011034
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000032E5 File Offset: 0x000014E5
		public unsafe static string s_DefaultMaterialSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00012E54 File Offset: 0x00011054
		// (set) Token: 0x0600028A RID: 650 RVA: 0x000032F7 File Offset: 0x000014F7
		public unsafe HashSet<int> FallbackSearchQueryLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_FallbackSearchQueryLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_FallbackSearchQueryLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00012E84 File Offset: 0x00011084
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003316 File Offset: 0x00001516
		public unsafe static HashSet<int> k_SearchedFontAssetLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00012EAC File Offset: 0x000110AC
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003328 File Offset: 0x00001528
		public unsafe static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00012ED4 File Offset: 0x000110D4
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000333A File Offset: 0x0000153A
		public unsafe static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00012EFC File Offset: 0x000110FC
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000334C File Offset: 0x0000154C
		public unsafe static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00012F24 File Offset: 0x00011124
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000335E File Offset: 0x0000155E
		public unsafe static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00012F4C File Offset: 0x0001114C
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00003370 File Offset: 0x00001570
		public unsafe List<Glyph> m_GlyphsToRender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToRender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToRender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00012F7C File Offset: 0x0001117C
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000338F File Offset: 0x0000158F
		public unsafe List<Glyph> m_GlyphsRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsRendered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsRendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00012FAC File Offset: 0x000111AC
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000033AE File Offset: 0x000015AE
		public unsafe List<uint> m_GlyphIndexList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00012FDC File Offset: 0x000111DC
		// (set) Token: 0x0600029C RID: 668 RVA: 0x000033CD File Offset: 0x000015CD
		public unsafe List<uint> m_GlyphIndexListNewlyAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0001300C File Offset: 0x0001120C
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000033EC File Offset: 0x000015EC
		public unsafe List<uint> m_GlyphsToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0001303C File Offset: 0x0001123C
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000340B File Offset: 0x0000160B
		public unsafe HashSet<uint> m_GlyphsToAddLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001306C File Offset: 0x0001126C
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000342A File Offset: 0x0000162A
		public unsafe List<TMP_Character> m_CharactersToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001309C File Offset: 0x0001129C
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003449 File Offset: 0x00001649
		public unsafe HashSet<uint> m_CharactersToAddLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x000130CC File Offset: 0x000112CC
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003468 File Offset: 0x00001668
		public unsafe List<uint> s_MissingCharacterList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_s_MissingCharacterList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_s_MissingCharacterList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x000130FC File Offset: 0x000112FC
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003487 File Offset: 0x00001687
		public unsafe HashSet<uint> m_MissingUnicodesFromFontFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001312C File Offset: 0x0001132C
		// (set) Token: 0x060002AA RID: 682 RVA: 0x000034A6 File Offset: 0x000016A6
		public unsafe static Il2CppStructArray<uint> k_GlyphIndexArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceFontFileGUID;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceFontFile;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasPopulationMode;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceInfo;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphTable;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphLookupDictionary;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterTable;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLookupDictionary;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTexture;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTextures;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTextureIndex;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDynamicDataOnBuild;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_m_UsedGlyphRects;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeGlyphRects;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_m_fontInfo;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_atlas;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasWidth;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasHeight;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasPadding;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasRenderMode;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_m_glyphInfoList;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_m_KerningTable;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_m_FontFeatureTable;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_fallbackFontAssets;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackFontAssetTable;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_CreationSettings;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightTable;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_fontWeights;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_normalStyle;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_normalSpacingOffset;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_boldStyle;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_boldSpacing;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_italicStyle;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_tabSize;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_IsFontAssetLookupTablesDirty;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_k_TryAddCharacterMarker;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_k_TryAddCharactersMarker;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_k_ClearFontAssetDataMarker;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateFontAssetDataMarker;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultMaterialSuffix;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_FallbackSearchQueryLookup;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_k_SearchedFontAssetLookup;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToRender;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsRendered;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexList;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToAdd;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToAddLookup;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_m_CharactersToAdd;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_m_CharactersToAddLookup;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_s_MissingCharacterList;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingUnicodesFromFontFile;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_k_GlyphIndexArray;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_String_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_set_version_Internal_set_Void_String_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_SortAllTables_Internal_Void_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFontAssetForAtlasTextureUpdate_Internal_Static_Void_TMP_FontAsset_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAtlasTexturesForFontAssetsInQueue_Internal_Static_Void_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeFontAsset_Internal_Void_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000083 RID: 131
		[ObfuscatedName("TMPro.TMP_FontAsset+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000EEC RID: 3820 RVA: 0x0003C0D0 File Offset: 0x0003A2D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr);
				TMP_FontAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, "<>9");
				TMP_FontAsset.__c.NativeFieldInfoPtr___9__124_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, "<>9__124_0");
				TMP_FontAsset.__c.NativeFieldInfoPtr___9__125_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, "<>9__125_0");
				TMP_FontAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, 100663618);
				TMP_FontAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__124_0_Internal_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, 100663619);
				TMP_FontAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__125_0_Internal_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, 100663620);
			}

			// Token: 0x06000EED RID: 3821 RVA: 0x0003C174 File Offset: 0x0003A374
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EEE RID: 3822 RVA: 0x0003C1B0 File Offset: 0x0003A3B0
			[CallerCount(0)]
			public unsafe uint _SortCharacterTable_b__124_0(TMP_Character c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__124_0_Internal_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EEF RID: 3823 RVA: 0x0003C200 File Offset: 0x0003A400
			[CallerCount(0)]
			public unsafe uint _SortGlyphTable_b__125_0(Glyph c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__125_0_Internal_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EF0 RID: 3824 RVA: 0x00009106 File Offset: 0x00007306
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000580 RID: 1408
			// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x0003C250 File Offset: 0x0003A450
			// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x0000910F File Offset: 0x0000730F
			public unsafe static TMP_FontAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000581 RID: 1409
			// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0003C278 File Offset: 0x0003A478
			// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x00009121 File Offset: 0x00007321
			public unsafe static Func<TMP_Character, uint> __9__124_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__124_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_Character, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__124_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000582 RID: 1410
			// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0003C2A0 File Offset: 0x0003A4A0
			// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x00009133 File Offset: 0x00007333
			public unsafe static Func<Glyph, uint> __9__125_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__125_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Glyph, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__125_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BCC RID: 3020
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000BCD RID: 3021
			private static readonly IntPtr NativeFieldInfoPtr___9__124_0;

			// Token: 0x04000BCE RID: 3022
			private static readonly IntPtr NativeFieldInfoPtr___9__125_0;

			// Token: 0x04000BCF RID: 3023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BD0 RID: 3024
			private static readonly IntPtr NativeMethodInfoPtr__SortCharacterTable_b__124_0_Internal_UInt32_TMP_Character_0;

			// Token: 0x04000BD1 RID: 3025
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphTable_b__125_0_Internal_UInt32_Glyph_0;
		}

		// Token: 0x02000084 RID: 132
		private sealed class MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04000BD2 RID: 3026
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_FontAsset.NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
